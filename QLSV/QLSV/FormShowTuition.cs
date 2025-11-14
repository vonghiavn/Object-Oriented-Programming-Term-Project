using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormShowTuition : Form
    {
        private DataTable dtTuition;

        public FormShowTuition()
        {
            InitializeComponent();
        }

        private void FormShowTuition_Load(object sender, EventArgs e)
        {
            LoadListStudent();
        }

        void LoadListStudent()
        {
            dtTuition = new DataTable();

            dtTuition.Columns.Add("STT", typeof(int));
            dtTuition.Columns.Add("Mã SV", typeof(string));
            dtTuition.Columns.Add("Họ tên", typeof(string));
            dtTuition.Columns.Add("Ngày nhập học", typeof(string));
            dtTuition.Columns.Add("Khoa", typeof(string));
            dtTuition.Columns.Add("Ngành", typeof(string));
            dtTuition.Columns.Add("Tổng học phí", typeof(string));
            dtTuition.Columns.Add("Đã đóng", typeof(string));
            dtTuition.Columns.Add("Còn thiếu", typeof(string));
            dtTuition.Columns.Add("Trạng thái", typeof(string));

            ListStudent listStudent = ListStudent.GetInstance();
            ListMajor listMajor = ListMajor.GetInstance();

            int stt = 1;
            decimal totalRevenue = 0;

            foreach (Student student in listStudent.ListStudents)
            {
                decimal totalFee = 0;
                if (student.Major != null)
                {
                    totalFee = listMajor.GetTotalFeeByMajor(student.Major);
                }

                decimal paidAmount = student.PaidTuition;

                decimal remaining = totalFee - paidAmount;

                string status;
                if (paidAmount == 0)
                {
                    status = "Chưa đóng";
                }
                else if (paidAmount >= totalFee)
                {
                    status = "Đã hoàn thành";
                }
                else
                {
                    status = "Chưa hoàn thành";
                }

                totalRevenue += paidAmount;

                DataRow row = dtTuition.NewRow();
                row["STT"] = stt++;
                row["Mã SV"] = student.StudentID;
                row["Họ tên"] = student.Name;
                row["Ngày nhập học"] = student.EnrollDate.ToString("dd/MM/yyyy");
                row["Khoa"] = student.Department != null ? student.Department.Name : "";
                row["Ngành"] = student.Major != null ? student.Major.MajorName : "";
                row["Tổng học phí"] = totalFee.ToString("N0") + " VNĐ";
                row["Đã đóng"] = paidAmount.ToString("N0") + " VNĐ";
                row["Còn thiếu"] = remaining.ToString("N0") + " VNĐ";
                row["Trạng thái"] = status;

                dtTuition.Rows.Add(row);
            }

            dtgvTuition.DataSource = dtTuition;

            CustomizeDataGridView();

            txtTotalStudents.Text = listStudent.ListStudents.Count.ToString();
            txtTotalRevenue.Text = totalRevenue.ToString("N0") + " VNĐ";
        }

        private void CustomizeDataGridView()
        {
            dtgvTuition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dtgvTuition.ScrollBars = ScrollBars.Both;

            if (dtgvTuition.Columns.Count > 0)
            {
                dtgvTuition.Columns["STT"].Width = 60;
                dtgvTuition.Columns["Mã SV"].Width = 130;
                dtgvTuition.Columns["Họ tên"].Width = 180;
                dtgvTuition.Columns["Ngày nhập học"].Width = 120;
                dtgvTuition.Columns["Khoa"].Width = 200;
                dtgvTuition.Columns["Ngành"].Width = 220;
                dtgvTuition.Columns["Tổng học phí"].Width = 140;
                dtgvTuition.Columns["Đã đóng"].Width = 140;
                dtgvTuition.Columns["Còn thiếu"].Width = 140;
                dtgvTuition.Columns["Trạng thái"].Width = 140;

                dtgvTuition.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvTuition.Columns["Mã SV"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvTuition.Columns["Ngày nhập học"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgvTuition.Columns["Tổng học phí"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgvTuition.Columns["Đã đóng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgvTuition.Columns["Còn thiếu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dtgvTuition.Columns["Trạng thái"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewColumn column in dtgvTuition.Columns)
                {
                    column.Resizable = DataGridViewTriState.True;
                }
            }

            ColorizeStatusRows();
        }

        private void ColorizeStatusRows()
        {
            for (int i = 0; i < dtgvTuition.Rows.Count; i++)
            {
                DataGridViewRow row = dtgvTuition.Rows[i];
                string status = row.Cells["Trạng thái"].Value.ToString();

                if (status == "Đã hoàn thành")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                }
                else if (status == "Chưa hoàn thành")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                }
                else if (status == "Chưa đóng")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListStudent();
            MessageBox.Show("Đã làm mới dữ liệu!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}