using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormEditStudent : Form
    {
        public FormEditStudent()
        {
            InitializeComponent();
        }
        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            if (Const.NewStudent == null)
            {
                MessageBox.Show("Không có dữ liệu sinh viên để chỉnh sửa!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            cboSex.DataSource = Const.listSex;
            cboStatus.DataSource = Const.listStatus;

            // Load danh sách Department
            cboDepartment.Items.Clear();
            int deptIndex = 0;
            int selectedDeptIndex = 0;

            foreach (Department d in ListDepartment.GetInstance().ListDepartments)
            {
                cboDepartment.Items.Add(d);

                // Tìm index của department hiện tại
                if (Const.NewStudent.Department != null &&
                    d.Name == Const.NewStudent.Department.Name)
                {
                    selectedDeptIndex = deptIndex;
                }
                deptIndex++;
            }

            cboDepartment.DisplayMember = "Name";

            // Đăng ký event trước khi set SelectedIndex
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;

            // Set department hiện tại
            if (cboDepartment.Items.Count > 0)
            {
                cboDepartment.SelectedIndex = selectedDeptIndex;
            }

            // Load thông tin sinh viên
            LoadInfo();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMajorsByDepartment();
        }

        private void LoadMajorsByDepartment()
        {
            Department selectedDept = cboDepartment.SelectedItem as Department;
            cboMajor.Items.Clear();

            if (selectedDept != null && selectedDept.Majors != null)
            {
                foreach (Major m in selectedDept.Majors)
                    cboMajor.Items.Add(m);
            }

            cboMajor.DisplayMember = "MajorName";

            if (cboMajor.Items.Count > 0)
                cboMajor.SelectedIndex = 0;
        }

        private void LoadInfo()
        {
            if (Const.NewStudent == null)
                return;

            txbName.Text = Const.NewStudent.Name;
            dtpkBirthDay.Value = Const.NewStudent.BirthDay;
            cboSex.Text = Const.NewStudent.Sex;
            txbAddress.Text = Const.NewStudent.Address;
            txbEmail.Text = Const.NewStudent.Email;
            txbPhone.Text = Const.NewStudent.PhoneNumber;
            dtpkEnrollDate.Value = Const.NewStudent.EnrollDate;
            txbEnrollID.Text = Const.NewStudent.EnrollID;
            txbStudentID.Text = Const.NewStudent.StudentID;
            txbPosition.Text = Const.NewStudent.Position;
            cboStatus.Text = Const.NewStudent.Status;

            // Load Major tương ứng với Department đã chọn
            LoadMajorsByDepartment();

            // Set Major hiện tại nếu có
            if (Const.NewStudent.Major != null && cboMajor.Items.Count > 0)
            {
                for (int i = 0; i < cboMajor.Items.Count; i++)
                {
                    Major m = cboMajor.Items[i] as Major;
                    if (m != null && m.MajorID == Const.NewStudent.Major.MajorID)
                    {
                        cboMajor.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txbStudentID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbStudentID.Focus();
                return;
            }

            string name = txbName.Text;
            DateTime birthDay = dtpkBirthDay.Value;
            string sex = cboSex.Text;
            string address = txbAddress.Text;
            string email = txbEmail.Text;
            string phoneNumber = txbPhone.Text;
            DateTime enrollDate = dtpkEnrollDate.Value;
            string enrollID = txbEnrollID.Text;
            string studentID = txbStudentID.Text;
            string position = txbPosition.Text;
            string status = cboStatus.Text;

            Department department = cboDepartment.SelectedItem as Department;
            Major major = cboMajor.SelectedItem as Major;

            // Kiểm tra nếu Major thay đổi
            bool majorChanged = false;
            if (Const.NewStudent.Major != null && major != null)
            {
                if (Const.NewStudent.Major.MajorID != major.MajorID)
                {
                    majorChanged = true;
                }
            }
            else if (Const.NewStudent.Major == null && major != null)
            {
                majorChanged = true;
            }
            else if (Const.NewStudent.Major != null && major == null)
            {
                majorChanged = true;
            }

            // Nếu Major thay đổi, reset danh sách môn đã tính
            if (majorChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn đã thay đổi ngành học!\n" +
                    "Danh sách môn học đã tính tiền và số tiền đã đóng sẽ bị xóa.\n" +
                    "Bạn có chắc muốn tiếp tục?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Reset thông tin học phí
                Const.NewStudent.PaidCourseIDs = new List<string>();
                Const.NewStudent.PaidTuition = 0;
            }

            Const.NewStudent.Name = name;
            Const.NewStudent.BirthDay = birthDay;
            Const.NewStudent.Sex = sex;
            Const.NewStudent.Address = address;
            Const.NewStudent.Email = email;
            Const.NewStudent.PhoneNumber = phoneNumber;
            Const.NewStudent.EnrollDate = enrollDate;
            Const.NewStudent.EnrollID = enrollID;
            Const.NewStudent.StudentID = studentID;
            Const.NewStudent.Position = position;
            Const.NewStudent.Status = status;
            Const.NewStudent.Department = department;
            Const.NewStudent.Major = major; 

            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thành công",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn hủy thao tác và thoát không?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
