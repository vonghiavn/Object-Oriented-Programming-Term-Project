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
    public partial class FormMain : Form
    {
        int index = -1;

        public bool isExit = true;
        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
        }

        void Decentralization()
        {
            if (Const.AccountType == false)
            {
                tsmiUser.Enabled = tsmiEmployee.Enabled = tsmiDepartment.Enabled = tsmiMajor.Enabled = false;
            }
        }

        void LoadListStudent()
        {
            dtgvStudent.Rows.Clear();

            foreach (Student item in ListStudent.GetInstance().ListStudents)
            {
                dtgvStudent.Rows.Add(item.StudentID, item.Name, item.BirthDay.ToShortDateString(), item.Sex, item.Department != null ? item.Department.Name : "", item.Position, item.Status);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                    return;
                }

                DataStorage.SaveData();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isExit)
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;

            cboSearchSex.DataSource = Const.listSex;

            cboSearchDepartment.Items.Clear();
            foreach (Department d in ListDepartment.GetInstance().ListDepartments)
            {
                cboSearchDepartment.Items.Add(d.Name);
            }

            if (cboSearchDepartment.Items.Count > 0)
                cboSearchDepartment.SelectedIndex = 0;

            Decentralization();
            LoadListStudent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Logout(this, new EventArgs());
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
           btnShow.Enabled = btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Const.AccountType == false)
            MessageBox.Show("Bạn không phải là Admin", "Cảnh báo");
        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }

        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment f = new FormDepartment();
            f.ShowDialog();
        }

        private void tsmiMajor_Click(object sender, EventArgs e)
        {
            FormMajor f = new FormMajor();

            // Đăng ký để nhận refresh từ FormDepartment
            FormDepartment.RegisterMajorForm(f);
            f.ShowDialog();
        }
        private void tsmiCourse_Click(object sender, EventArgs e)
        {
            FormCourse f = new FormCourse();
            f.ShowDialog();
        }

        private void tsmiTuition_Click(object sender, EventArgs e)
        {
            FormShowTuition f = new FormShowTuition();
            f.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListStudent.GetInstance().ListStudents.Count)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trước khi xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormShowInfoStudent f = new FormShowInfoStudent();
            f.ShowDialog();
        }
        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index < 0 || index >= ListStudent.GetInstance().ListStudents.Count)
                return;

            Const.NewStudent = new Student();
            Const.NewStudent = ListStudent.GetInstance().ListStudents[index];
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txbSearchName.Clear();
            txbSearchStudentID.Clear();
            cboSearchSex.SelectedIndex = -1;
            cboSearchDepartment.SelectedIndex = -1;
            dtpkSearchBirth.Checked = false; 
            LoadListStudent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Const.NewStudent = null;

            FormAddNewStudent f = new FormAddNewStudent();
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Const.NewStudent != null)
            {
                ListStudent.GetInstance().ListStudents.Add(Const.NewStudent);
                DataStorage.SaveData();
                LoadListStudent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListStudent.GetInstance().ListStudents.Count)
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi xem thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormEditStudent f = new FormEditStudent();
            f.FormClosed += F_FormClosed1;
            f.ShowDialog();
        }

        private void F_FormClosed1(object sender, FormClosedEventArgs e)
        {
            if (Const.NewStudent == null)
                return;

            Student currentStudent = ListStudent.GetInstance().ListStudents[index];

            currentStudent.Name = Const.NewStudent.Name;
            currentStudent.BirthDay = Const.NewStudent.BirthDay;
            currentStudent.Sex = Const.NewStudent.Sex;
            currentStudent.StudentID = Const.NewStudent.StudentID;
            currentStudent.Department = Const.NewStudent.Department;
            currentStudent.Position = Const.NewStudent.Position;
            currentStudent.Status = Const.NewStudent.Status;
            currentStudent.Address = Const.NewStudent.Address;
            currentStudent.Email = Const.NewStudent.Email;
            currentStudent.PhoneNumber = Const.NewStudent.PhoneNumber;
            currentStudent.EnrollDate = Const.NewStudent.EnrollDate;
            currentStudent.EnrollID = Const.NewStudent.EnrollID;
            currentStudent.Major = Const.NewStudent.Major;

            currentStudent.PaidCourseIDs = Const.NewStudent.PaidCourseIDs;
            currentStudent.PaidTuition = Const.NewStudent.PaidTuition;
            DataStorage.SaveData();

            LoadListStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListStudent.GetInstance().ListStudents.Count)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trước khi xóa!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student stu = ListStudent.GetInstance().ListStudents[index];

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sinh viên:\n\n" +
                $"🔹 Mã số: {stu.StudentID}\n" +
                $"🔹 Họ tên: {stu.Name}\n\n" +
                $"Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            ListStudent.GetInstance().ListStudents.RemoveAt(index);
            LoadListStudent();

            MessageBox.Show("Đã xóa sinh viên thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataStorage.SaveData();
                MessageBox.Show("✅ Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DataStorage.LoadData();
                MessageBox.Show("🔄 Dữ liệu đã được cập nhật từ file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi load, cập nhật lại giao diện
                LoadListStudent();

                // Làm mới danh sách phòng ban trong combobox
                cboSearchDepartment.Items.Clear();
                foreach (Department d in ListDepartment.GetInstance().ListDepartments)
                {
                    cboSearchDepartment.Items.Add(d.Name);
                }
                if (cboSearchDepartment.Items.Count > 0)
                    cboSearchDepartment.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txbSearchName.Text.Trim().ToLower();
            string sex = cboSearchSex.Text.Trim();
            string department = cboSearchDepartment.Text.Trim();
            string studentIDText = txbSearchStudentID.Text.Trim();
            DateTime selectedDate = dtpkSearchBirth.Value.Date;

            List<Student> allStudents = ListStudent.GetInstance().ListStudents;
            List<Student> result = new List<Student>();

            bool filterByDate = dtpkSearchBirth.Checked;

            if (!string.IsNullOrEmpty(studentIDText))
            {
                Student exactMatch = null;
                List<Student> partialMatches = new List<Student>();

                foreach (Student stu in allStudents)
                {
                    string code = stu.StudentID.ToString().Trim().ToLower();
                    string search = studentIDText.ToLower();

                    // kiểm tra khớp tuyệt đối
                    if (code.Equals(search))
                    {
                        exactMatch = stu;
                        break;
                    }

                    // nếu không khớp hoàn toàn nhưng có chứa chuỗi tìm kiếm
                    if (code.Contains(search))
                        partialMatches.Add(stu);
                }

                // nếu có mã khớp tuyệt đối thì hiển thị luôn nhân viên đó
                if (exactMatch != null)
                {
                    dtgvStudent.Rows.Clear();
                    dtgvStudent.Rows.Add(
                        exactMatch.StudentID,
                        exactMatch.Name,
                        exactMatch.BirthDay.ToShortDateString(),
                        exactMatch.Sex,
                        exactMatch.Department,
                        exactMatch.Position,
                        exactMatch.Status
                    );
                    return;
                }

                // nếu có kết quả gần đúng (mã chứa chuỗi tìm kiếm)
                if (partialMatches.Count > 0)
                {
                    dtgvStudent.Rows.Clear();
                    foreach (Student item in partialMatches)
                    {
                        dtgvStudent.Rows.Add(
                            item.StudentID,
                            item.Name,
                            item.BirthDay.ToShortDateString(),
                            item.Sex,
                            item.Department,
                            item.Position,
                            item.Status
                        );
                    }
                    return;
                }
            }

            foreach (Student stu in allStudents)
            {
                bool match = true;

                // lọc theo tên
                if (!string.IsNullOrEmpty(name) && !stu.Name.ToLower().Contains(name))
                    match = false;

                // lọc theo giới tính
                if (!string.IsNullOrEmpty(sex) && stu.Sex.Trim().ToLower() != sex.Trim().ToLower())
                    match = false;

                // lọc theo phòng ban
                if (!string.IsNullOrEmpty(department))
                {
                    if (stu.Department == null || !stu.Department.Name.Equals(department, StringComparison.OrdinalIgnoreCase))
                        match = false;
                }

                // lọc theo ngày sinh (nếu người dùng chọn)
                if (filterByDate && stu.BirthDay.Date != selectedDate)
                    match = false;

                if (match)
                    result.Add(stu);
            }

            // hiển thị kết quả
            dtgvStudent.Rows.Clear();
            foreach (Student item in result)
            {
                dtgvStudent.Rows.Add(
                    item.StudentID,
                    item.Name,
                    item.BirthDay.ToShortDateString(),
                    item.Sex,
                    item.Department,
                    item.Position,
                    item.Status
                );
            }

            // nếu không có kết quả
            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào khớp với thông tin đã nhập.",
                                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FormTuition f = new FormTuition();
            f.ShowDialog(); 
        }
    }
}
