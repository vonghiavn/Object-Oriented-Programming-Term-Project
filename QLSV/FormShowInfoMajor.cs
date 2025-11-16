using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormShowInfoMajor : Form
    {
        private Major selectedMajor;
        private int indexMajorCourse = -1;
        public FormShowInfoMajor(Major major)
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
            txbDepartment.Text = Const.NewMajor.Department?.Name ?? "";
        }

        void LoadListMajorCourses()
        {
            dtgvMajorCourse.DataSource = null;
            if (Const.NewMajor != null)
                dtgvMajorCourse.DataSource = Const.NewMajor.Courses;
            dtgvMajorCourse.Refresh();
        }

        private void FormShowInfoMajor_Load(object sender, EventArgs e)
        {
            dtgvMajorCourse.AutoGenerateColumns = false;
            LoadInfo();
            LoadListMajorCourses();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
