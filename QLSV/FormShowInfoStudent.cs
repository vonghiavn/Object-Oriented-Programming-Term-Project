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
    public partial class FormShowInfoStudent : Form
    {
        public FormShowInfoStudent()
        {
            InitializeComponent();
        }

        void LoadInfo()
        {
            if (Const.NewStudent == null)
            {
                MessageBox.Show("Không có dữ liệu sinh viên để hiển thị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txbName.Text = Const.NewStudent.Name;
            txbSex.Text = Const.NewStudent.Sex;
            txbBirthDay.Text = Const.NewStudent.BirthDay.ToShortDateString();
            txbAddress.Text = Const.NewStudent.Address;
            txbEmail.Text = Const.NewStudent.Email;
            txbPhone.Text = Const.NewStudent.PhoneNumber;
            txbEnrollDate.Text = Const.NewStudent.EnrollDate.ToShortDateString();
            txbEnrollID.Text = Const.NewStudent.EnrollID;
            txbStudentID.Text = Const.NewStudent.StudentID;
            txbDepartment.Text = Const.NewStudent.Department?.Name ?? "";

            txbPosition.Text = Const.NewStudent.Position;
            txbContract.Text = Const.NewStudent.Status;
            txbMajor.Text = Const.NewStudent.Major?.MajorName ?? "";
        }


        private void FormShowInfoStudent_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
