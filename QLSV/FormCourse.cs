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
    public partial class FormCourse : Form
    {
        int index = -1;

        public FormCourse()
        {
            InitializeComponent();
        }

        void LoadListCourse()
        {
            dtgvCourse.DataSource = null;
            dtgvCourse.DataSource = ListCourse.GetInstance().ListCourses;
            dtgvCourse.Refresh();
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            dtgvCourse.AutoGenerateColumns = false;
            LoadListCourse();
        }

        private void dtgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index < 0 || index >= ListCourse.GetInstance().ListCourses.Count)
                return;

            txbCourseName.Text = ListCourse.GetInstance().ListCourses[index].Name;
            txbCourseID.Text = ListCourse.GetInstance().ListCourses[index].CourseID;
            txbCourseCredits.Text = ListCourse.GetInstance().ListCourses[index].CourseCredits.ToString();
            txbFeePerCredit.Text = ListCourse.GetInstance().ListCourses[index].FeePerCredit.ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            string courseName = txbCourseName.Text.Trim();
            string courseID = txbCourseID.Text.Trim();
            string creditText = txbCourseCredits.Text.Trim();
            string feeText = txbFeePerCredit.Text.Trim();

            if (string.IsNullOrEmpty(courseName) ||
                string.IsNullOrEmpty(courseID) ||
                string.IsNullOrEmpty(creditText) ||
                string.IsNullOrEmpty(feeText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int courseCredits;
            decimal feePerCredit;

            if (!int.TryParse(creditText, out courseCredits))
            {
                MessageBox.Show("Số tín chỉ không hợp lệ!");
                return;
            }

            if (!decimal.TryParse(feeText, out feePerCredit))
            {
                MessageBox.Show("Đơn giá 1 tín chỉ không hợp lệ!");
                return;
            }

            ListCourse.GetInstance().ListCourses.Add(
                new Course(courseName, courseID, courseCredits, feePerCredit)
            );

            DataStorage.SaveData();
            LoadListCourse();
        }


        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }

            string courseName = txbCourseName.Text;
            string courseID = txbCourseID.Text;
            int courseCredits = Convert.ToInt32(txbCourseCredits.Text);
            decimal feePerCredit = Convert.ToDecimal(txbFeePerCredit.Text);

            ListCourse.GetInstance().ListCourses[index].Name = courseName;
            ListCourse.GetInstance().ListCourses[index].CourseID = courseID;
            ListCourse.GetInstance().ListCourses[index].CreditInfo.Value = Convert.ToInt32(txbCourseCredits.Text);
            ListCourse.GetInstance().ListCourses[index].CreditInfo.FeePerCredit = Convert.ToDecimal(txbFeePerCredit.Text);
            DataStorage.SaveData();

            LoadListCourse();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }

            ListCourse.GetInstance().ListCourses.RemoveAt(index);
            DataStorage.SaveData();

            LoadListCourse();
        }
    }
}
