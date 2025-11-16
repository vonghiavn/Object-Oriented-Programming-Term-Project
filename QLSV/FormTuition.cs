using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormTuition : Form
    {
        private ListDepartment listDepartment;
        private ListMajor listMajor;
        private ListStudent listStudent;
        private bool isCalculating = false;

        public FormTuition()
        {
            InitializeComponent();
            listDepartment = ListDepartment.GetInstance();
            listMajor = ListMajor.GetInstance();
            listStudent = ListStudent.GetInstance();
        }

        private void FormTuition_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadToolStrip();
            RegisterEventHandlers();
        }

        // ✅ Helper method để parse tiền
        private bool TryParseMoneyText(string text, out decimal result)
        {
            result = 0;
            if (string.IsNullOrEmpty(text))
                return false;

            string clean = text.Replace(",", "").Replace(".", "");
            return decimal.TryParse(clean, out result);
        }

        private void LoadDepartments()
        {
            cboKhoa.Items.Clear();
            cboKhoa.Items.Add("-- Chọn khoa --");

            foreach (Department dept in listDepartment.ListDepartments)
            {
                cboKhoa.Items.Add(dept);
            }

            cboKhoa.DisplayMember = "Name";
            cboKhoa.SelectedIndex = 0;
        }

        private void LoadToolStrip()
        {
            tsbShowAll.Click += tsbShowAll_Click;
        }

        private void RegisterEventHandlers()
        {
            cboKhoa.SelectedIndexChanged += cboKhoa_SelectedIndexChanged;
            cboNganh.SelectedIndexChanged += cboNganh_SelectedIndexChanged;
            cboStudent.SelectedIndexChanged += cboStudent_SelectedIndexChanged;
            clbMonHoc.ItemCheck += clbMonHoc_ItemCheck;
            txbPaid.TextChanged += txbPaid_TextChanged;
            txbPaid.Leave += txbPaid_Leave;
            txbPaid.KeyPress += txbPaid_KeyPress;
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNganh.Items.Clear();
            cboStudent.Items.Clear();
            clbMonHoc.Items.Clear();
            ClearFields();

            if (cboKhoa.SelectedIndex <= 0)
                return;

            Department selectedDept = cboKhoa.SelectedItem as Department;
            if (selectedDept == null || selectedDept.Majors.Count == 0)
                return;

            cboNganh.Items.Add("-- Chọn ngành --");
            foreach (Major major in selectedDept.Majors)
            {
                cboNganh.Items.Add(major);
            }

            cboNganh.DisplayMember = "MajorName";
            cboNganh.SelectedIndex = 0;
        }

        private void cboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboStudent.Items.Clear();
            clbMonHoc.Items.Clear();
            ClearFields();

            if (cboNganh.SelectedIndex <= 0)
                return;

            Major selectedMajor = cboNganh.SelectedItem as Major;
            if (selectedMajor == null)
                return;

            LoadStudentsByMajor(selectedMajor);
        }

        private void LoadStudentsByMajor(Major major)
        {
            cboStudent.Items.Clear();
            cboStudent.Items.Add("-- Chọn sinh viên --");

            int count = 0;
            foreach (Student student in listStudent.ListStudents)
            {
                if (student.Major != null && student.Major.MajorID == major.MajorID)
                {
                    cboStudent.Items.Add(student);
                    count++;
                }
            }

            cboStudent.DisplayMember = "Name";
            cboStudent.SelectedIndex = 0;

            if (count == 0 && listStudent.ListStudents.Count == 0)
            {
                MessageBox.Show("Không có sinh viên nào trong hệ thống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbMonHoc.Items.Clear();
            ClearFields();

            if (cboStudent.SelectedIndex <= 0)
                return;

            Student selectedStudent = cboStudent.SelectedItem as Student;
            if (selectedStudent == null)
                return;

            txbPaid.Text = "0";
            LoadAvailableCourses(selectedStudent, true); 
        }

        private void LoadAvailableCourses(Student student, bool showCompletionMessage = false)
        {
            clbMonHoc.Items.Clear();

            if (student.Major == null || student.Major.Courses == null || student.Major.Courses.Count == 0)
            {
                if (showCompletionMessage)
                {
                    MessageBox.Show("Ngành này chưa có môn học nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

            if (student.PaidCourseIDs == null)
            {
                student.PaidCourseIDs = new List<string>();
            }

            int availableCount = 0;
            foreach (Course course in student.Major.Courses)
            {
                if (!student.PaidCourseIDs.Contains(course.CourseID))
                {
                    clbMonHoc.Items.Add(course);
                    availableCount++;
                }
            }

            clbMonHoc.DisplayMember = "Name";

            if (availableCount == 0 && showCompletionMessage)
            {
                MessageBox.Show("Sinh viên này đã tính tiền cho tất cả môn học trong ngành!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clbMonHoc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1;
            timer.Tick += Timer_Tick_CalculateFee;
            timer.Start();
        }

        private void Timer_Tick_CalculateFee(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = sender as System.Windows.Forms.Timer;
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }
            CalculateTotalCreditsAndFee();
        }

        private void txbPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbPaid_TextChanged(object sender, EventArgs e)
        {
            if (!isCalculating)
            {
                CalculateRemaining();
            }
        }

        private void txbPaid_Leave(object sender, EventArgs e)
        {
            ValidatePaidAmount();
        }

        private void ValidatePaidAmount()
        {
            if (string.IsNullOrEmpty(txbPaid.Text))
            {
                txbPaid.Text = "0";
                return;
            }

            decimal paid;
            if (!TryParseMoneyText(txbPaid.Text, out paid))
            {
                MessageBox.Show("Số tiền đã đóng không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPaid.Text = "0";
                return;
            }

            if (paid < 0)
            {
                MessageBox.Show("Số tiền đã đóng không được âm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPaid.Text = "0";
                return;
            }

            decimal totalFee;
            if (TryParseMoneyText(txbTotalFee.Text, out totalFee) && paid > totalFee)
            {
                MessageBox.Show(
                    string.Format("Số tiền đã đóng ({0:N0} VNĐ) không được lớn hơn tổng học phí ({1:N0} VNĐ)!",
                    paid, totalFee),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txbPaid.Text = totalFee.ToString("N0");
                return;
            }

            isCalculating = true;
            txbPaid.Text = paid.ToString("N0");
            isCalculating = false;
        }

        private void CalculateTotalCreditsAndFee()
        {
            int totalCredits = 0;
            decimal totalFee = 0;

            foreach (object item in clbMonHoc.CheckedItems)
            {
                Course course = item as Course;
                if (course != null)
                {
                    totalCredits += course.CourseCredits;
                    totalFee += course.TotalFee;
                }
            }

            txbTotalCredits.Text = totalCredits.ToString();
            txbTotalFee.Text = totalFee.ToString("N0");

            ValidatePaidAmountAgainstNewTotal();
            CalculateRemaining();
        }

        private void ValidatePaidAmountAgainstNewTotal()
        {
            decimal paid, totalFee;
            if (TryParseMoneyText(txbPaid.Text, out paid) &&
                TryParseMoneyText(txbTotalFee.Text, out totalFee) &&
                paid > totalFee)
            {
                isCalculating = true;
                txbPaid.Text = totalFee.ToString("N0");
                isCalculating = false;
            }
        }

        private void CalculateRemaining()
        {
            decimal totalFee, paid;
            TryParseMoneyText(txbTotalFee.Text, out totalFee);
            TryParseMoneyText(txbPaid.Text, out paid);

            decimal remaining = totalFee - paid;
            txbRemain.Text = remaining.ToString("N0");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboStudent.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbMonHoc.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học để tính tiền!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student selectedStudent = cboStudent.SelectedItem as Student;
            if (selectedStudent == null)
                return;

            if (selectedStudent.Major == null)
            {
                MessageBox.Show("Sinh viên chưa được phân ngành!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal paidThisTime;
            if (!TryParseMoneyText(txbPaid.Text, out paidThisTime))
            {
                MessageBox.Show("Số tiền đã đóng không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paidThisTime < 0)
            {
                MessageBox.Show("Số tiền đã đóng không được âm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal currentBatchFee;
            if (!TryParseMoneyText(txbTotalFee.Text, out currentBatchFee) || currentBatchFee == 0)
            {
                MessageBox.Show("Học phí đợt này là 0 đồng. Vui lòng chọn môn học!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedStudent.PaidCourseIDs == null)
            {
                selectedStudent.PaidCourseIDs = new List<string>();
            }

            int totalCoursesInMajor = selectedStudent.Major.Courses.Count;
            int currentPaidCoursesCount = selectedStudent.PaidCourseIDs.Count;
            int remainingCourses = totalCoursesInMajor - currentPaidCoursesCount;
            int selectedCoursesCount = clbMonHoc.CheckedItems.Count;

            // Tính số tiền còn thiếu thật sự của toàn bộ ngành
            decimal totalMajorFee = listMajor.GetTotalFeeByMajor(selectedStudent.Major);
            decimal remainingMajorFee = totalMajorFee - selectedStudent.PaidTuition;

            // Nếu đây là lần thanh toán cuối cùng → override lại txbTotalFee và txbRemain
            if (selectedCoursesCount == remainingCourses && remainingCourses > 0)
            {
                // Hiển thị số tiền phải đóng (remainingMajorFee)
                txbTotalFee.Text = remainingMajorFee.ToString("N0");

                // Hiển thị số tiền còn lại (0 nếu user nhập đúng)
                decimal remainDisplay = remainingMajorFee - paidThisTime;
                txbRemain.Text = remainDisplay.ToString("N0");
            }

            // Trường hợp 1: chọn đúng tất cả môn còn lại → FULL PAYMENT bắt buộc
            if (selectedCoursesCount == remainingCourses && remainingCourses > 0)
            {
                if (paidThisTime != remainingMajorFee)
                {
                    MessageBox.Show(
                        string.Format(
                            "⚠️ Bạn đang thanh toán TẤT CẢ {0} môn còn lại!\n\n" +
                            "Bạn PHẢI đóng đúng số tiền còn thiếu: {1:N0} VNĐ\n" +
                            "Số tiền bạn nhập: {2:N0} VNĐ\n\n" +
                            "❌ Không được đóng thiếu\n❌ Không được đóng dư",
                            remainingCourses,
                            remainingMajorFee,
                            paidThisTime),
                        "Yêu cầu thanh toán toàn bộ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    isCalculating = true;
                    txbPaid.Text = remainingMajorFee.ToString("N0");
                    isCalculating = false;
                    return;
                }
            }
            else
            {
                // Trường hợp 2: chưa phải full payment
                if (paidThisTime > currentBatchFee)
                {
                    MessageBox.Show(
                        string.Format(
                            "❌ Số tiền đóng ({0:N0} VNĐ) không được lớn hơn học phí đợt này ({1:N0} VNĐ)!",
                            paidThisTime, currentBatchFee),
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }


            List<string> newPaidCourses = new List<string>();
            foreach (object item in clbMonHoc.CheckedItems)
            {
                Course course = item as Course;
                if (course != null && !selectedStudent.PaidCourseIDs.Contains(course.CourseID))
                {
                    selectedStudent.PaidCourseIDs.Add(course.CourseID);
                    newPaidCourses.Add(course.Name);
                }
            }

            selectedStudent.PaidTuition += paidThisTime;

            int paidCoursesCount = selectedStudent.PaidCourseIDs.Count;
            decimal remaining = totalMajorFee - selectedStudent.PaidTuition;

            string tuitionStatus;
            if (selectedStudent.PaidTuition == 0)
                tuitionStatus = "Chưa đóng";
            else if (paidCoursesCount >= totalCoursesInMajor && remaining <= 0)
                tuitionStatus = "Đã hoàn thành";
            else if (paidCoursesCount >= totalCoursesInMajor && remaining > 0)
                tuitionStatus = string.Format("Chưa hoàn thành (còn thiếu {0:N0} VNĐ)", remaining);
            else
                tuitionStatus = string.Format("Chưa hoàn thành (còn {0} môn)", totalCoursesInMajor - paidCoursesCount);

            string courseList = newPaidCourses.Count > 0
                ? string.Join("\n", newPaidCourses.ConvertAll(c => "  - " + c))
                : "  (Không có môn mới)";

            string congratsMessage = tuitionStatus == "Đã hoàn thành"
                ? "\n🎉 CHÚC MỪNG! Sinh viên đã hoàn thành toàn bộ học phí!\n"
                : "";

            MessageBox.Show(
                string.Format(
                    "Lưu thông tin học phí thành công!{0}\n" +
                    "Sinh viên: {1}\n" +
                    "Môn học đã tính trong đợt này:\n{2}\n\n" +
                    "Học phí đợt này: {3:N0} VNĐ\n" +
                    "Số tiền đóng thêm: {4:N0} VNĐ\n" +
                    "Tổng đã đóng: {5:N0} VNĐ\n" +
                    "Tổng học phí ngành: {6:N0} VNĐ\n" +
                    "Còn thiếu: {7:N0} VNĐ\n\n" +
                    "Tiến độ: {8}/{9} môn học\n" +
                    "Trạng thái: {10}",
                    congratsMessage,
                    selectedStudent.Name,
                    courseList,
                    currentBatchFee,
                    paidThisTime,
                    selectedStudent.PaidTuition,
                    totalMajorFee,
                    Math.Max(0, remaining),
                    paidCoursesCount,
                    totalCoursesInMajor,
                    tuitionStatus),
                tuitionStatus == "Đã hoàn thành" ? "🎉 Hoàn thành" : "Thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DataStorage.SaveData();

            clbMonHoc.Items.Clear();
            ClearFields();
            LoadAvailableCourses(selectedStudent, false); // ✅ Không hiển thị MessageBox
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng form?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsbShowAll_Click(object sender, EventArgs e)
        {
            FormShowTuition formShow = new FormShowTuition();
            formShow.ShowDialog();
        }
        private void ClearFields()

        {
            txbTotalCredits.Clear();
            txbPaid.Clear();
            txbTotalFee.Clear();
            txbRemain.Clear();
        }
    }
}