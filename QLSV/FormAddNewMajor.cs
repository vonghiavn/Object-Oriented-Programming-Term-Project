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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
                Const.NewMajor = new Major();

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

            txbCourseName.Text = ListCourse.GetInstance().ListCourses[index].Name;
            txbCourseID.Text = ListCourse.GetInstance().ListCourses[index].CourseID;
            txbCourseCredits.Text = ListCourse.GetInstance().ListCourses[index].CourseCredits.ToString();
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
                Const.NewMajor = new Major();

            Course selected = ListCourse.GetInstance().ListCourses[index];

            // Kiểm tra trùng CourseID trong Const.NewMajor
            foreach (Course c in Const.NewMajor.Courses)
            {
                if (c.CourseID == selected.CourseID)
                {
                    MessageBox.Show("Môn này đã có trong ngành!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Chỉ thêm vào Const.NewMajor.Courses, không thêm liên kết ngược
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
                // Chỉ xóa khỏi Const.NewMajor.Courses
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
            string majorID = txbMajorID.Text.Trim();
            string majorName = txbMajorName.Text.Trim();
            Department dept = selectedDepartment;

            // Validation...
            if (string.IsNullOrEmpty(majorID) || string.IsNullOrEmpty(majorName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng
            foreach (Major m in dept.Majors)
            {
                if (m.MajorID == majorID)
                {
                    MessageBox.Show("Mã ngành này đã tồn tại trong khoa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                Major newMajor = new Major(majorID, majorName, dept);

                if (Const.NewMajor != null && Const.NewMajor.Courses.Count > 0)
                {
                    newMajor.Courses = new List<Course>();

                    foreach (Course c in Const.NewMajor.Courses)
                    {
                        newMajor.Courses.Add(c);

                        if (!c.Majors.Contains(newMajor))
                        {
                            c.Majors.Add(newMajor);
                        }
                    }
                }

                dept.Majors.Add(newMajor);
                Const.NewMajor = newMajor;

                DataStorage.SaveData();

                // Đợi DataStorage hoàn tất
                System.Threading.Thread.Sleep(100);

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
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác và thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
