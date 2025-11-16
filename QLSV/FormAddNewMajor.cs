using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormAddNewMajor : Form
    {
        private Department selectedDepartment;
        private int index = -1;
        private int indexMajorCourse = -1;

        public FormAddNewMajor(Department dept)
        {
            InitializeComponent();
            selectedDepartment = dept;
        }

        private void FormAddNewMajor_Load(object sender, EventArgs e)
        {
            if (Const.NewMajor == null)
            {
                MajorFactory factory = MajorFactory.GetInstance();
                Const.NewMajor = factory.Create("", "", selectedDepartment);
            }

            dtgvCourse.AutoGenerateColumns = false;
            dtgvMajorCourse.AutoGenerateColumns = false;
            LoadListCourses();
            LoadListMajorCourses();
        }

        void LoadListCourses()
        {
            dtgvCourse.DataSource = null;
            dtgvCourse.DataSource = ListCourse.GetInstance().ListCourses;
            dtgvCourse.Refresh();
        }

        void LoadListMajorCourses()
        {
            dtgvMajorCourse.DataSource = null;
            if (Const.NewMajor != null)
                dtgvMajorCourse.DataSource = Const.NewMajor.Courses;
            dtgvMajorCourse.Refresh();
        }

        private void dtgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index < 0 || index >= ListCourse.GetInstance().ListCourses.Count)
                return;

            Course selected = ListCourse.GetInstance().ListCourses[index];
            txbCourseName.Text = selected.Name;
            txbCourseID.Text = selected.CourseID;
            txbCourseCredits.Text = selected.CourseCredits.ToString();
        }

        private void dtgvMajorCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexMajorCourse = e.RowIndex;
            if (indexMajorCourse < 0 || Const.NewMajor == null || indexMajorCourse >= Const.NewMajor.Courses.Count)
                return;

            Course selected = Const.NewMajor.Courses[indexMajorCourse];
            txbMajorCourseName.Text = selected.Name;
            txbMajorCourseID.Text = selected.CourseID;
            txbMajorCourseCredits.Text = selected.CourseCredits.ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Const.NewMajor == null)
            {
                MajorFactory factory = MajorFactory.GetInstance();
                Const.NewMajor = factory.Create("", "", selectedDepartment);
            }

            Course selected = ListCourse.GetInstance().ListCourses[index];

            // Kiểm tra trùng CourseID
            foreach (Course c in Const.NewMajor.Courses)
            {
                if (c.CourseID == selected.CourseID)
                {
                    MessageBox.Show("Môn này đã có trong ngành!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thêm vào danh sách tạm
            Const.NewMajor.Courses.Add(selected);

            LoadListMajorCourses();
            MessageBox.Show("Đã thêm môn vào ngành!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (indexMajorCourse < 0)
            {
                MessageBox.Show("Vui lòng chọn môn cần xóa từ bảng bên phải!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Const.NewMajor == null || Const.NewMajor.Courses.Count == 0)
            {
                MessageBox.Show("Ngành chưa có môn nào để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (indexMajorCourse >= Const.NewMajor.Courses.Count)
            {
                MessageBox.Show("Môn đã chọn không hợp lệ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Course courseToRemove = Const.NewMajor.Courses[indexMajorCourse];

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa môn '{courseToRemove.Name}' khỏi ngành?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Const.NewMajor.Courses.RemoveAt(indexMajorCourse);

                indexMajorCourse = -1;
                txbMajorCourseName.Clear();
                txbMajorCourseID.Clear();
                txbMajorCourseCredits.Clear();

                LoadListMajorCourses();
                MessageBox.Show("Đã xóa môn khỏi ngành!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string majorID = txbMajorID.Text.Trim();
                string majorName = txbMajorName.Text.Trim();

                if (string.IsNullOrEmpty(majorID) || string.IsNullOrEmpty(majorName))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã ngành
                foreach (Major m in selectedDepartment.Majors)
                {
                    if (m.MajorID == majorID)
                    {
                        MessageBox.Show("Mã ngành này đã tồn tại trong khoa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MajorFactory factory = MajorFactory.GetInstance();
                Major newMajor;

                if (Const.NewMajor != null && Const.NewMajor.Courses.Count > 0)
                {
                    // Tạo Major với danh sách Course
                    newMajor = factory.CreateWithCourses(
                        majorID,
                        majorName,
                        selectedDepartment,
                        Const.NewMajor.Courses
                    );
                }
                else
                {
                    // Tạo Major không có Course
                    newMajor = factory.Create(majorID, majorName, selectedDepartment);
                }

                // Thêm vào Department
                selectedDepartment.Majors.Add(newMajor);

                // Cập nhật Const.NewMajor
                Const.NewMajor = newMajor;

                // Lưu dữ liệu
                DataStorage.SaveData();

                MessageBox.Show("Đã lưu ngành mới thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ngành: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn hủy thao tác và thoát không?",
                "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Reset Const.NewMajor khi cancel
                Const.NewMajor = null;
                this.Close();
            }
        }
    }
}