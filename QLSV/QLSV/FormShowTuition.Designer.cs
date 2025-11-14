namespace QuanLySinhVien
{
    partial class FormShowTuition
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtgvTuition = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.txtTotalStudents = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuition)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTuition
            // 
            this.dtgvTuition.AllowUserToAddRows = false;
            this.dtgvTuition.AllowUserToDeleteRows = false;
            this.dtgvTuition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTuition.GridColor = System.Drawing.SystemColors.Control;
            this.dtgvTuition.Location = new System.Drawing.Point(12, 60);
            this.dtgvTuition.Name = "dtgvTuition";
            this.dtgvTuition.ReadOnly = true;
            this.dtgvTuition.RowHeadersWidth = 51;
            this.dtgvTuition.RowTemplate.Height = 24;
            this.dtgvTuition.Size = new System.Drawing.Size(1160, 450);
            this.dtgvTuition.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(400, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DANH SÁCH HỌC PHÍ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 530);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 45);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1052, 534);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.Location = new System.Drawing.Point(301, 541);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(132, 22);
            this.lblTotalStudents.TabIndex = 4;
            this.lblTotalStudents.Text = "Tổng sinh viên:";
            // 
            // txtTotalStudents
            // 
            this.txtTotalStudents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalStudents.Location = new System.Drawing.Point(439, 538);
            this.txtTotalStudents.Name = "txtTotalStudents";
            this.txtTotalStudents.ReadOnly = true;
            this.txtTotalStudents.Size = new System.Drawing.Size(100, 30);
            this.txtTotalStudents.TabIndex = 5;
            this.txtTotalStudents.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(545, 545);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(165, 22);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "Tổng thu (đã đóng):";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRevenue.Location = new System.Drawing.Point(716, 538);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.ReadOnly = true;
            this.txtTotalRevenue.Size = new System.Drawing.Size(200, 30);
            this.txtTotalRevenue.TabIndex = 7;
            this.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormShowTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 637);
            this.Controls.Add(this.txtTotalRevenue);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.txtTotalStudents);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtgvTuition);
            this.Name = "FormShowTuition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học phí sinh viên";
            this.Load += new System.EventHandler(this.FormShowTuition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTuition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.TextBox txtTotalStudents;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.TextBox txtTotalRevenue;
    }
}