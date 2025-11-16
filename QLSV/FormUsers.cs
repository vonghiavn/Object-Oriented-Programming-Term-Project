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
    public partial class FormUsers : Form
    {
        int index = -1;

        public FormUsers()
        {
            InitializeComponent();
        }
        void LoadListUser()
        {
            dtgvUser.DataSource = null;
            dtgvUser.DataSource = ListUser.GetInstance().ListAccountUser;
            dtgvUser.Refresh();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            cboAccountType.DataSource = Const.listAccountType;
            LoadListUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }

            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            bool accountType = false;

            switch (cboAccountType.Text)
            {
                case "Admin":
                    accountType = true;
                    break;
                case "Nhân sự":
                    accountType = false;
                    break;
            }

            ListUser.GetInstance().ListAccountUser.Add(new User(userName,passWord,accountType));
            DataStorage.SaveData();

            LoadListUser();
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index < 0)
                return;

            txbUsername.Text = ListUser.GetInstance().ListAccountUser[index].UserName;
            txbPassword.Text = ListUser.GetInstance().ListAccountUser[index].PassWord;

            switch (ListUser.GetInstance().ListAccountUser[index].AccountType)
            {
                case true: cboAccountType.Text = "Admin";
                    break;
                case false: cboAccountType.Text = "Nhân sự";
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }

            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            bool accountType = false;

            switch (cboAccountType.Text)
            {
                case "Admin":
                    accountType = true;
                    break;
                case "Nhân sự":
                    accountType = false;
                    break;
            }

            ListUser.GetInstance().ListAccountUser[index].UserName = userName;
            ListUser.GetInstance().ListAccountUser[index].PassWord = passWord;
            ListUser.GetInstance().ListAccountUser[index].AccountType = accountType;
            DataStorage.SaveData();

            LoadListUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi");
                return;
            }

            ListUser.GetInstance().ListAccountUser.RemoveAt(index);
            DataStorage.SaveData();

            LoadListUser();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát khỏi quản lý người dùng?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
