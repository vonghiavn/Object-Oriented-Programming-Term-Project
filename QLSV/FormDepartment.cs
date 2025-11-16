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
    public partial class FormDepartment : Form
    {
        int index = -1;

        private static List<FormMajor> openMajorForms = new List<FormMajor>();

        public FormDepartment()
        {
            InitializeComponent();
        }

        public static void RegisterMajorForm(FormMajor form)
        {
            if (!openMajorForms.Contains(form))
            {
                openMajorForms.Add(form);

                form.FormClosed += OnMajorFormClosed;       
            }
        }

        private static void OnMajorFormClosed(object sender, FormClosedEventArgs e)
        {
            FormMajor form = sender as FormMajor;
            if (form != null && openMajorForms.Contains(form))
            {
                openMajorForms.Remove(form);

                form.FormClosed -= OnMajorFormClosed;
            }
        }

        private void RefreshAllMajorForms()
        {
            for (int i = openMajorForms.Count - 1; i >= 0; i--)
            {
                if (!openMajorForms[i].IsDisposed)
                {
                    openMajorForms[i].RefreshData();
                }
                else
                {
                    openMajorForms.RemoveAt(i);
                }
            }
        }

        void LoadListDepartment()
        {
            lbDepartment.DataSource = null;
            lbDepartment.DataSource = ListDepartment.GetInstance().ListDepartments;
            lbDepartment.DisplayMember = "Name";
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadListDepartment();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string departmentName = txbDepartmentName.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng tên
            foreach (Department dept in ListDepartment.GetInstance().ListDepartments)
            {
                if (dept.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tên khoa đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            // Thêm Department mới
            Department newDept = new Department(departmentName);
            ListDepartment.GetInstance().ListDepartments.Add(newDept);
            DataStorage.SaveData();

            LoadListDepartment();
            // Tự động chọn Department vừa thêm
            lbDepartment.SelectedItem = newDept;

            // Refresh tất cả FormMajor đang mở
            RefreshAllMajorForms();

            MessageBox.Show("Đã thêm khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Validation
            if (index < 0 || index >= ListDepartment.GetInstance().ListDepartments.Count)
            {
                MessageBox.Show("Vui lòng chọn khoa để chỉnh sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string departmentName = txbDepartmentName.Text;

            // Validation
            if (string.IsNullOrWhiteSpace(departmentName))
            {
                MessageBox.Show("Vui lòng nhập tên khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation
            for (int i = 0; i < ListDepartment.GetInstance().ListDepartments.Count; i++)
            {
                if (i != index &&
                    ListDepartment.GetInstance().ListDepartments[i].Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Tên khoa đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Lưu Department đang chọn
            Department currentDept = ListDepartment.GetInstance().ListDepartments[index];

            // Cập nhật tên
            currentDept.Name = departmentName;

            DataStorage.SaveData();
            LoadListDepartment();

            // Giữ selection
            lbDepartment.SelectedItem = currentDept;

            // Refresh tất cả FormMajor đang mở
            RefreshAllMajorForms();

            MessageBox.Show("Đã cập nhật khoa thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Validation
            if (index < 0 || index >= ListDepartment.GetInstance().ListDepartments.Count)
            {
                MessageBox.Show("Vui lòng chọn khoa để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Department deptToRemove = ListDepartment.GetInstance().ListDepartments[index];
            int majorCount = deptToRemove.Majors.Count;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa khoa '{deptToRemove.Name}'?\n" +
                $"Thao tác này sẽ xóa {majorCount} ngành thuộc khoa này!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                using (deptToRemove)
                {
                    // Dispose tự động xóa Major và ngắt liên kết
                }

                // Xóa Department
                ListDepartment.GetInstance().ListDepartments.RemoveAt(index);
                DataStorage.SaveData();

                // Reset
                index = -1;
                txbDepartmentName.Clear();

                LoadListDepartment();

                // Refresh tất cả FormMajor đang mở
                RefreshAllMajorForms();

                MessageBox.Show("Đã xóa khoa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khoa: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát khỏi quản lý phòng ban?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void lbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbDepartment.SelectedIndex;

            if (index < 0 || index >= ListDepartment.GetInstance().ListDepartments.Count)
            {
                txbDepartmentName.Clear();
                return;
            }

            txbDepartmentName.Text = ListDepartment.GetInstance().ListDepartments[index].Name;
        }
    }
}
