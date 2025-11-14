using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormAddNewStudent : Form
    {
        public FormAddNewStudent()
        {
            InitializeComponent();
        }

        private void FormAddNewStudent_Load(object sender, EventArgs e)
        {
            cboSex.DataSource = Const.listSex;
            cboStatus.DataSource = Const.listStatus;

            cboDepartment.Items.Clear();
            foreach (Department d in ListDepartment.GetInstance().ListDepartments)
            {
                cboDepartment.Items.Add(d);
            }
            cboDepartment.DisplayMember = "Name";

            if (cboDepartment.Items.Count > 0)
                cboDepartment.SelectedIndex = 0;

            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            LoadMajorsByDepartment();
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

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbStudentID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbStudentID.Focus();
                return false;
            }

            foreach (Student s in ListStudent.GetInstance().ListStudents)
            {
                if (s.StudentID == txbStudentID.Text)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng nhập mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbStudentID.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txbAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbEnrollID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ghi danh.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbEnrollID.Focus();
                return false;
            }

            if (cboDepartment.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khoa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboMajor.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ngành.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txbPosition.Text))
            {
                MessageBox.Show("Vui lòng nhập chức vụ hoặc vai trò của sinh viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txbPosition.Focus();
                return false;
            }

            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

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

            Const.NewStudent = new Student(
                name, birthDay, sex, studentID,
                department, position, status,
                address, email, phoneNumber, enrollDate, enrollID, major
            );

            MessageBox.Show("Thêm sinh viên mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác và thoát không?","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
