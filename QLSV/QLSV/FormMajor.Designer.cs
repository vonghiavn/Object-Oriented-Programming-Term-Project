namespace QuanLySinhVien
{
    partial class FormMajor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMajor));
            this.dtgvMajor = new System.Windows.Forms.DataGridView();
            this.colStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShow = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMajor
            // 
            this.dtgvMajor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvMajor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMajor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentCode,
            this.colName,
            this.colTotalCourse,
            this.colBirthDay});
            this.dtgvMajor.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvMajor.Location = new System.Drawing.Point(34, 174);
            this.dtgvMajor.MultiSelect = false;
            this.dtgvMajor.Name = "dtgvMajor";
            this.dtgvMajor.ReadOnly = true;
            this.dtgvMajor.RowHeadersWidth = 51;
            this.dtgvMajor.RowTemplate.Height = 24;
            this.dtgvMajor.Size = new System.Drawing.Size(577, 243);
            this.dtgvMajor.TabIndex = 30;
            this.dtgvMajor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMajor_CellClick);
            // 
            // colStudentCode
            // 
            this.colStudentCode.DataPropertyName = "MajorID";
            this.colStudentCode.HeaderText = "Mã ngành";
            this.colStudentCode.MinimumWidth = 6;
            this.colStudentCode.Name = "colStudentCode";
            this.colStudentCode.ReadOnly = true;
            this.colStudentCode.Width = 95;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "MajorName";
            this.colName.HeaderText = "Tên ngành";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colTotalCourse
            // 
            this.colTotalCourse.DataPropertyName = "TotalCourse";
            this.colTotalCourse.HeaderText = "Tổng số môn";
            this.colTotalCourse.MinimumWidth = 6;
            this.colTotalCourse.Name = "colTotalCourse";
            this.colTotalCourse.ReadOnly = true;
            this.colTotalCourse.Width = 125;
            // 
            // colBirthDay
            // 
            this.colBirthDay.DataPropertyName = "TotalCredits";
            this.colBirthDay.HeaderText = "Tổng số tín chỉ";
            this.colBirthDay.MinimumWidth = 6;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.ReadOnly = true;
            this.colBirthDay.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "DANH SÁCH NGÀNH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Chọn khoa";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(248, 59);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(291, 30);
            this.cboDepartment.TabIndex = 37;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShow,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 27);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnShow
            // 
            this.btnShow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(43, 24);
            this.btnShow.Text = "Xem";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 24);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 24);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 24);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 525);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMajor);
            this.Controls.Add(this.label5);
            this.Name = "FormMajor";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.FormMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvMajor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDay;
        private System.Windows.Forms.ToolStripButton btnShow;
    }
}