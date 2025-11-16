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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool checkLogin(string userName, string passWord)
        {
            for (int i = 0; i < ListUser.GetInstance().ListAccountUser.Count; i++)
            {
                if (userName == ListUser.GetInstance().ListAccountUser[i].UserName && passWord == ListUser.GetInstance().ListAccountUser[i].PassWord)
                {
                    Const.AccountType = ListUser.GetInstance().ListAccountUser[i].AccountType;
                    return true;
                }
            }    
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            if (checkLogin(userName,passWord))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();

                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK);
                txbUserName.Focus();
                return;
            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ckbShowPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = false;

            if (!ckbShowPassWord.Checked)
                txbPassWord.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataStorage.LoadData();
        }
    }
}
