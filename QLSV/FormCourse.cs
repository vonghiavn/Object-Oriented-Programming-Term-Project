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

            Course selected = ListCourse.GetInstance().ListCourses[index];
            txbCourseName.Text = selected.Name;
            txbCourseID.Text = selected.CourseID;
            txbCourseCredits.Text = selected.CourseCredits.ToString();
            txbFeePerCredit.Text = selected.FeePerCredit.ToString();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = txbCourseName.Text.Trim();
                string courseID = txbCourseID.Text.Trim();
                string creditText = txbCourseCredits.Text.Trim();
                string feeText = txbFeePerCredit.Text.Trim();

                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Vui lòng nhập tên môn học!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCourseName.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(courseID))
                {
                    MessageBox.Show("Vui lòng nhập mã môn học!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCourseID.Focus();
                    return;
                }

                foreach (Course c in ListCourse.GetInstance().ListCourses)
                {
                    if (c.CourseID == courseID)
                    {
                        MessageBox.Show("Mã môn học đã tồn tại!", "Trùng mã",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbCourseID.Focus();
                        return;
                    }
                }

                if (string.IsNullOrEmpty(creditText))
                {
                    MessageBox.Show("Vui lòng nhập số tín chỉ!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCourseCredits.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(feeText))
                {
                    MessageBox.Show("Vui lòng nhập học phí mỗi tín chỉ!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFeePerCredit.Focus();
                    return;
                }

                // Parse số liệu
                int courseCredits;
                decimal feePerCredit;

                if (!int.TryParse(creditText, out courseCredits) || courseCredits <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải là số nguyên dương!", "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbCourseCredits.Focus();
                    return;
                }

                if (!decimal.TryParse(feeText, out feePerCredit) || feePerCredit < 0)
                {
                    MessageBox.Show("Học phí phải là số không âm!", "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbFeePerCredit.Focus();
                    return;
                }

                CourseFactory factory = CourseFactory.GetInstance();
                Course newCourse = factory.CreateWithFee(courseID, courseName, courseCredits, feePerCredit);

                ListCourse.GetInstance().ListCourses.Add(newCourse);

                DataStorage.SaveData();

                LoadListCourse();

                ClearInputFields();

                MessageBox.Show("Thêm môn học thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm môn học: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi để sửa!", "Chưa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string courseName = txbCourseName.Text.Trim();
                string courseID = txbCourseID.Text.Trim();
                string creditText = txbCourseCredits.Text.Trim();
                string feeText = txbFeePerCredit.Text.Trim();

                if (string.IsNullOrEmpty(courseName))
                {
                    MessageBox.Show("Vui lòng nhập tên môn học!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(courseID))
                {
                    MessageBox.Show("Vui lòng nhập mã môn học!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string oldCourseID = ListCourse.GetInstance().ListCourses[index].CourseID;
                if (courseID != oldCourseID)
                {
                    foreach (Course c in ListCourse.GetInstance().ListCourses)
                    {
                        if (c.CourseID == courseID)
                        {
                            MessageBox.Show("Mã môn học đã tồn tại!", "Trùng mã",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                int courseCredits;
                decimal feePerCredit;

                if (!int.TryParse(creditText, out courseCredits) || courseCredits <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải là số nguyên dương!", "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(feeText, out feePerCredit) || feePerCredit < 0)
                {
                    MessageBox.Show("Học phí phải là số không âm!", "Dữ liệu không hợp lệ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Course currentCourse = ListCourse.GetInstance().ListCourses[index];
                currentCourse.Name = courseName;
                currentCourse.CourseID = courseID;
                currentCourse.CreditInfo.Value = courseCredits;
                currentCourse.CreditInfo.FeePerCredit = feePerCredit;

                DataStorage.SaveData();

                LoadListCourse();

                MessageBox.Show("Cập nhật môn học thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật môn học: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (index < 0)
            {
                MessageBox.Show("Vui lòng chọn 1 bản ghi để xóa!", "Chưa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Course courseToDelete = ListCourse.GetInstance().ListCourses[index];

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa môn '{courseToDelete.Name}'?\n\n" +
                    $"⚠️ Lưu ý: Môn học này có thể đang được sử dụng bởi các ngành học.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (courseToDelete.Majors != null && courseToDelete.Majors.Count > 0)
                    {
                        for (int i = courseToDelete.Majors.Count - 1; i >= 0; i--)
                        {
                            Major major = courseToDelete.Majors[i];
                            if (major.Courses.Contains(courseToDelete))
                            {
                                major.Courses.Remove(courseToDelete);
                            }
                        }
                    }

                    ListCourse.GetInstance().ListCourses.RemoveAt(index);

                    DataStorage.SaveData();

                    index = -1;

                    ClearInputFields();

                    LoadListCourse();

                    MessageBox.Show("Xóa môn học thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa môn học: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txbCourseName.Clear();
            txbCourseID.Clear();
            txbCourseCredits.Clear();
            txbFeePerCredit.Clear();
            index = -1;
        }
    }
}