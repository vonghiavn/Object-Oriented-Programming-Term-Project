using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public partial class FormEditMajor : Form
    {
        private Major selectedMajor;
        private int index = -1;
        private int indexMajorCourse = -1;
        public FormEditMajor(Major major)
        {
            InitializeComponent();
            selectedMajor = major;
        }

        void LoadInfo()
        {
            if (Const.NewMajor == null)
            {
                MessageBox.Show("Không có dữ liệu ngành để chỉnh sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txbMajorID.Text = Const.NewMajor.MajorID;
            txbMajorName.Text = Const.NewMajor.MajorName;
        }

        void LoadListMajorCourses()
        {
            dtgvMajorCourse.DataSource = null;
            if (Const.NewMajor != null)
                dtgvMajorCourse.DataSource = Const.NewMajor.Courses;
            dtgvMajorCourse.Refresh();
        }

        void LoadListCourses()
        {
            dtgvCourse.DataSource = null;
            dtgvCourse.DataSource = ListCourse.GetInstance().ListCourses;
            dtgvCourse.Refresh();
        }

        private void FormEditMajor_Load(object sender, EventArgs e)
        {
            if (Const.NewMajor == null)
                Const.NewMajor = new Major();

            dtgvCourse.AutoGenerateColumns = false;
            dtgvMajorCourse.AutoGenerateColumns = false;

            LoadInfo();
            LoadListCourses();
            LoadListMajorCourses();
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
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }

            if (Const.NewMajor == null)
                Const.NewMajor = new Major();

            Course selected = ListCourse.GetInstance().ListCourses[index];

            // kiểm tra trùng CourseID trong Const.NewMajor
            for (int i = 0; i < Const.NewMajor.Courses.Count; i++)
            {
                if (Const.NewMajor.Courses[i].CourseID == selected.CourseID)
                {
                    MessageBox.Show("Môn này đã có trong ngành!");
                    return;
                }
            }

            // Thêm vào major
            Const.NewMajor.Courses.Add(selected);

            // Gắn liên kết ngược nếu chưa có
            bool exists = false;
            for (int i = 0; i < selected.Majors.Count; i++)
            {
                if (selected.Majors[i] == Const.NewMajor)
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
                selected.Majors.Add(Const.NewMajor);

            LoadListMajorCourses();
            MessageBox.Show("Đã thêm môn vào ngành!");
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            string idToRemove = txbCourseID.Text.Trim();
            if (string.IsNullOrEmpty(idToRemove))
            {
                MessageBox.Show("Vui lòng chọn môn cần xóa (chọn trên bảng để điền mã môn).");
                return;
            }

            if (Const.NewMajor == null || Const.NewMajor.Courses.Count == 0)
            {
                MessageBox.Show("Ngành chưa có môn nào để xóa.");
                return;
            }

            // Tìm course trong Const.NewMajor theo CourseID
            int foundIndex = -1;
            for (int i = 0; i < Const.NewMajor.Courses.Count; i++)
            {
                if (Const.NewMajor.Courses[i].CourseID == idToRemove)
                {
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                MessageBox.Show("Môn này không tồn tại trong ngành.");
                return;
            }

            Course course = Const.NewMajor.Courses[foundIndex];

            // Gỡ liên kết hai chiều
            for (int i = 0; i < course.Majors.Count; i++)
            {
                if (course.Majors[i] == Const.NewMajor)
                {
                    course.Majors.RemoveAt(i);
                    break;
                }
            }

            Const.NewMajor.Courses.RemoveAt(foundIndex);
            LoadListMajorCourses();
            MessageBox.Show("Đã xóa môn khỏi ngành!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string majorID = txbMajorID.Text;
            string majorName = txbMajorName.Text;

            if (majorID == "" || majorName == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ngành!");
                return;
            }

            Const.NewMajor.MajorID = majorID;
            Const.NewMajor.MajorName = majorName;
            DataStorage.SaveData();

            MessageBox.Show("Đã lưu ngành mới thành công!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy thao tác và thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
