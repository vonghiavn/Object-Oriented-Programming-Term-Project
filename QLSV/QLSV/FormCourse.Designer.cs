namespace QuanLySinhVien
{
    partial class FormCourse
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.txbCourseName = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txbCourseCredits = new System.Windows.Forms.TextBox();
            this.txbCourseID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.txbFeePerCredit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCourse = new System.Windows.Forms.DataGridView();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeePerCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tên môn";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(299, 261);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(79, 41);
            this.btnDeleteCourse.TabIndex = 57;
            this.btnDeleteCourse.Text = "Xóa";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // txbCourseName
            // 
            this.txbCourseName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCourseName.Location = new System.Drawing.Point(196, 78);
            this.txbCourseName.Name = "txbCourseName";
            this.txbCourseName.Size = new System.Drawing.Size(182, 30);
            this.txbCourseName.TabIndex = 58;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(63, 261);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(82, 41);
            this.btnAddCourse.TabIndex = 56;
            this.btnAddCourse.Text = "Thêm";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txbCourseCredits
            // 
            this.txbCourseCredits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCourseCredits.Location = new System.Drawing.Point(196, 168);
            this.txbCourseCredits.Name = "txbCourseCredits";
            this.txbCourseCredits.Size = new System.Drawing.Size(182, 30);
            this.txbCourseCredits.TabIndex = 55;
            // 
            // txbCourseID
            // 
            this.txbCourseID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCourseID.Location = new System.Drawing.Point(196, 121);
            this.txbCourseID.Name = "txbCourseID";
            this.txbCourseID.Size = new System.Drawing.Size(182, 30);
            this.txbCourseID.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mã môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tín chỉ";
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCourse.Location = new System.Drawing.Point(180, 261);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(79, 41);
            this.btnEditCourse.TabIndex = 61;
            this.btnEditCourse.Text = "Sửa";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // txbFeePerCredit
            // 
            this.txbFeePerCredit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFeePerCredit.Location = new System.Drawing.Point(196, 211);
            this.txbFeePerCredit.Name = "txbFeePerCredit";
            this.txbFeePerCredit.Size = new System.Drawing.Size(182, 30);
            this.txbFeePerCredit.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Giá tín chỉ";
            // 
            // dtgvCourse
            // 
            this.dtgvCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseName,
            this.colCourseID,
            this.colCourseCredits,
            this.colFeePerCredit,
            this.colTotalFee});
            this.dtgvCourse.Location = new System.Drawing.Point(38, 50);
            this.dtgvCourse.MultiSelect = false;
            this.dtgvCourse.Name = "dtgvCourse";
            this.dtgvCourse.ReadOnly = true;
            this.dtgvCourse.RowHeadersWidth = 51;
            this.dtgvCourse.RowTemplate.Height = 24;
            this.dtgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvCourse.Size = new System.Drawing.Size(776, 189);
            this.dtgvCourse.TabIndex = 60;
            this.dtgvCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCourse_CellClick);
            // 
            // colTotalFee
            // 
            this.colTotalFee.DataPropertyName = "TotalFee";
            this.colTotalFee.HeaderText = "Tổng tiền";
            this.colTotalFee.MinimumWidth = 6;
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.ReadOnly = true;
            this.colTotalFee.Width = 125;
            // 
            // colFeePerCredit
            // 
            this.colFeePerCredit.DataPropertyName = "FeePerCredit";
            this.colFeePerCredit.HeaderText = "Giá tín chỉ";
            this.colFeePerCredit.MinimumWidth = 6;
            this.colFeePerCredit.Name = "colFeePerCredit";
            this.colFeePerCredit.ReadOnly = true;
            this.colFeePerCredit.Width = 125;
            // 
            // colCourseCredits
            // 
            this.colCourseCredits.DataPropertyName = "CourseCredits";
            this.colCourseCredits.HeaderText = "Số tín chỉ";
            this.colCourseCredits.MinimumWidth = 6;
            this.colCourseCredits.Name = "colCourseCredits";
            this.colCourseCredits.ReadOnly = true;
            this.colCourseCredits.Width = 125;
            // 
            // colCourseID
            // 
            this.colCourseID.DataPropertyName = "CourseID";
            this.colCourseID.HeaderText = "Mã môn";
            this.colCourseID.MinimumWidth = 6;
            this.colCourseID.Name = "colCourseID";
            this.colCourseID.ReadOnly = true;
            this.colCourseID.Width = 125;
            // 
            // colCourseName
            // 
            this.colCourseName.DataPropertyName = "Name";
            this.colCourseName.HeaderText = "Tên môn";
            this.colCourseName.MinimumWidth = 6;
            this.colCourseName.Name = "colCourseName";
            this.colCourseName.ReadOnly = true;
            this.colCourseName.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCourse);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(417, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 282);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbFeePerCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.txbCourseName);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txbCourseCredits);
            this.Controls.Add(this.txbCourseID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FormCourse";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.TextBox txbCourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txbCourseCredits;
        private System.Windows.Forms.TextBox txbCourseID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.TextBox txbFeePerCredit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePerCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}