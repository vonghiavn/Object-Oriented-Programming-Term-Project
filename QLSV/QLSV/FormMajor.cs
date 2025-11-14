using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormMajor : Form
    {
        int index = -1;
        private BindingSource majorBindingSource = new BindingSource();

        private Department selectedDepartment
        {
            get { return cboDepartment.SelectedItem as Department; }
        }

        public FormMajor()
        {
            InitializeComponent();
        }

        private void FormMajor_Load(object sender, EventArgs e)
        {
            LoadDepartmentComboBox();
            dtgvMajor.AutoGenerateColumns = false;

            // Bind DataGridView với BindingSource
            dtgvMajor.DataSource = majorBindingSource;

            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;

            if (cboDepartment.Items.Count > 0)
            {
                cboDepartment.SelectedIndex = 0;
                LoadListMajors();
            }
        }

        public void RefreshData()
        {
            LoadDepartmentComboBox();
            LoadListMajors();
        }

        private void LoadDepartmentComboBox()
        {
            Department currentSelection = selectedDepartment;

            cboDepartment.SelectedIndexChanged -= cboDepartment_SelectedIndexChanged;
            cboDepartment.DataSource = null;
            cboDepartment.DataSource = ListDepartment.GetInstance().ListDepartments;
            cboDepartment.DisplayMember = "Name";
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;

            if (currentSelection != null &&
                ListDepartment.GetInstance().ListDepartments.Contains(currentSelection))
            {
                cboDepartment.SelectedItem = currentSelection;
            }
            else if (cboDepartment.Items.Count > 0)
            {
                cboDepartment.SelectedIndex = 0;
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListMajors();
        }

        private void LoadListMajors()
        {
            if (selectedDepartment == null)
            {
                majorBindingSource.DataSource = typeof(Major);
                majorBindingSource.Clear();
                index = -1;
                return;
            }

            // ✅ TẠO BINDINGLIST MỚI từ List<Major>
            var bindingList = new BindingList<Major>(selectedDepartment.Majors);
            majorBindingSource.DataSource = bindingList;

            // Reset selection
            index = -1;
            dtgvMajor.ClearSelection();
        }

        private void dtgvMajor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            index = e.RowIndex;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (index < 0 || index >= selectedDepartment.Majors.Count)
            {
                MessageBox.Show("Vui lòng chọn ngành học trước khi xem thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Major selectedMajor = selectedDepartment.Majors[index];
            Const.NewMajor = selectedMajor;
            FormShowInfoMajor f = new FormShowInfoMajor(selectedMajor);
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Vui lòng chọn khoa trước khi thêm ngành!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Const.NewMajor = null;
            FormAddNewMajor f = new FormAddNewMajor(selectedDepartment);
            f.FormClosed += F_FormClosed;
            f.ShowDialog();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reload lại list
            LoadListMajors();

            if (Const.NewMajor == null || selectedDepartment == null)
                return;

            // Tìm index mới
            int newIndex = -1;
            for (int i = 0; i < selectedDepartment.Majors.Count; i++)
            {
                if (selectedDepartment.Majors[i].MajorID == Const.NewMajor.MajorID)
                {
                    newIndex = i;
                    break;
                }
            }

            if (newIndex >= 0)
            {
                index = newIndex;

                // Đợi UI update xong
                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        if (index < dtgvMajor.Rows.Count)
                        {
                            dtgvMajor.ClearSelection();
                            dtgvMajor.Rows[index].Selected = true;
                            dtgvMajor.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                    catch
                    {
                        // Bỏ qua lỗi selection
                    }
                }));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (index < 0 || index >= selectedDepartment.Majors.Count)
            {
                MessageBox.Show("Vui lòng chọn ngành học trước khi chỉnh sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Major selectedMajor = selectedDepartment.Majors[index];
            Const.NewMajor = selectedMajor;

            FormEditMajor f = new FormEditMajor(selectedMajor);
            f.FormClosed += F_FormClosed1;
            f.ShowDialog();
        }

        private void F_FormClosed1(object sender, FormClosedEventArgs e)
        {
            LoadListMajors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDepartment == null)
            {
                MessageBox.Show("Vui lòng chọn khoa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (index < 0 || index >= selectedDepartment.Majors.Count)
            {
                MessageBox.Show("Vui lòng chọn ngành học trước khi xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Major majorToRemove = selectedDepartment.Majors[index];
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa ngành {majorToRemove.MajorName}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            try
            {
                // Ngắt liên kết với Course
                if (majorToRemove.Courses != null)
                {
                    foreach (Course course in majorToRemove.Courses)
                    {
                        if (course.Majors != null)
                        {
                            course.Majors.Remove(majorToRemove);
                        }
                    }
                }

                // Xóa khỏi Department
                selectedDepartment.Majors.RemoveAt(index);
                DataStorage.SaveData();

                index = -1;
                LoadListMajors();

                MessageBox.Show("Đã xóa ngành thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa ngành: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}