namespace QuanLySinhVien
{
    partial class FormEditMajor
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
            this.txbMajorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMajorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCourseName = new System.Windows.Forms.TextBox();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.txbCourseCredits = new System.Windows.Forms.TextBox();
            this.txbCourseID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCourse = new System.Windows.Forms.DataGridView();
            this.colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeePerCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvMajorCourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMajorCourseName = new System.Windows.Forms.TextBox();
            this.txbMajorCourseCredits = new System.Windows.Forms.TextBox();
            this.txbMajorCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajorCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMajorID
            // 
            this.txbMajorID.Location = new System.Drawing.Point(191, 90);
            this.txbMajorID.Name = "txbMajorID";
            this.txbMajorID.Size = new System.Drawing.Size(182, 30);
            this.txbMajorID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã ngành";
            // 
            // txbMajorName
            // 
            this.txbMajorName.Location = new System.Drawing.Point(191, 44);
            this.txbMajorName.Name = "txbMajorName";
            this.txbMajorName.Size = new System.Drawing.Size(182, 30);
            this.txbMajorName.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tên môn";
            // 
            // txbCourseName
            // 
            this.txbCourseName.Location = new System.Drawing.Point(191, 44);
            this.txbCourseName.Name = "txbCourseName";
            this.txbCourseName.ReadOnly = true;
            this.txbCourseName.Size = new System.Drawing.Size(182, 30);
            this.txbCourseName.TabIndex = 49;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(200, 192);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(101, 41);
            this.btnDeleteCourse.TabIndex = 47;
            this.btnDeleteCourse.Text = "Xóa";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(58, 192);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(102, 41);
            this.btnAddCourse.TabIndex = 45;
            this.btnAddCourse.Text = "Thêm";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // txbCourseCredits
            // 
            this.txbCourseCredits.Location = new System.Drawing.Point(191, 134);
            this.txbCourseCredits.Name = "txbCourseCredits";
            this.txbCourseCredits.ReadOnly = true;
            this.txbCourseCredits.Size = new System.Drawing.Size(182, 30);
            this.txbCourseCredits.TabIndex = 42;
            // 
            // txbCourseID
            // 
            this.txbCourseID.Location = new System.Drawing.Point(191, 87);
            this.txbCourseID.Name = "txbCourseID";
            this.txbCourseID.ReadOnly = true;
            this.txbCourseID.Size = new System.Drawing.Size(182, 30);
            this.txbCourseID.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tín chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Mã môn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbMajorName);
            this.groupBox2.Controls.Add(this.txbMajorID);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(95, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 145);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ngành";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvCourse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDeleteCourse);
            this.groupBox1.Controls.Add(this.txbCourseName);
            this.groupBox1.Controls.Add(this.btnAddCourse);
            this.groupBox1.Controls.Add(this.txbCourseCredits);
            this.groupBox1.Controls.Add(this.txbCourseID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(95, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 267);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều chỉnh môn của ngành";
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
            this.dtgvCourse.Location = new System.Drawing.Point(391, 44);
            this.dtgvCourse.MultiSelect = false;
            this.dtgvCourse.Name = "dtgvCourse";
            this.dtgvCourse.ReadOnly = true;
            this.dtgvCourse.RowHeadersWidth = 51;
            this.dtgvCourse.RowTemplate.Height = 24;
            this.dtgvCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvCourse.Size = new System.Drawing.Size(670, 189);
            this.dtgvCourse.TabIndex = 62;
            this.dtgvCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCourse_CellClick);
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
            // colCourseID
            // 
            this.colCourseID.DataPropertyName = "CourseID";
            this.colCourseID.HeaderText = "Mã môn";
            this.colCourseID.MinimumWidth = 6;
            this.colCourseID.Name = "colCourseID";
            this.colCourseID.ReadOnly = true;
            this.colCourseID.Width = 125;
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
            // colFeePerCredit
            // 
            this.colFeePerCredit.DataPropertyName = "FeePerCredit";
            this.colFeePerCredit.HeaderText = "Giá tín chỉ";
            this.colFeePerCredit.MinimumWidth = 6;
            this.colFeePerCredit.Name = "colFeePerCredit";
            this.colFeePerCredit.ReadOnly = true;
            this.colFeePerCredit.Width = 125;
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(816, 754);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 41);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(975, 754);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 41);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvMajorCourse);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txbMajorCourseName);
            this.groupBox3.Controls.Add(this.txbMajorCourseCredits);
            this.groupBox3.Controls.Add(this.txbMajorCourseID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(95, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1083, 276);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các môn trong ngành";
            // 
            // dtgvMajorCourse
            // 
            this.dtgvMajorCourse.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvMajorCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMajorCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtgvMajorCourse.Location = new System.Drawing.Point(391, 44);
            this.dtgvMajorCourse.MultiSelect = false;
            this.dtgvMajorCourse.Name = "dtgvMajorCourse";
            this.dtgvMajorCourse.ReadOnly = true;
            this.dtgvMajorCourse.RowHeadersWidth = 51;
            this.dtgvMajorCourse.RowTemplate.Height = 24;
            this.dtgvMajorCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgvMajorCourse.Size = new System.Drawing.Size(670, 189);
            this.dtgvMajorCourse.TabIndex = 62;
            this.dtgvMajorCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMajorCourse_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên môn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CourseID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã môn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CourseCredits";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số tín chỉ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FeePerCredit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá tín chỉ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalFee";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên môn";
            // 
            // txbMajorCourseName
            // 
            this.txbMajorCourseName.Location = new System.Drawing.Point(191, 44);
            this.txbMajorCourseName.Name = "txbMajorCourseName";
            this.txbMajorCourseName.ReadOnly = true;
            this.txbMajorCourseName.Size = new System.Drawing.Size(182, 30);
            this.txbMajorCourseName.TabIndex = 49;
            // 
            // txbMajorCourseCredits
            // 
            this.txbMajorCourseCredits.Location = new System.Drawing.Point(191, 134);
            this.txbMajorCourseCredits.Name = "txbMajorCourseCredits";
            this.txbMajorCourseCredits.ReadOnly = true;
            this.txbMajorCourseCredits.Size = new System.Drawing.Size(182, 30);
            this.txbMajorCourseCredits.TabIndex = 42;
            // 
            // txbMajorCourseID
            // 
            this.txbMajorCourseID.Location = new System.Drawing.Point(191, 87);
            this.txbMajorCourseID.Name = "txbMajorCourseID";
            this.txbMajorCourseID.ReadOnly = true;
            this.txbMajorCourseID.Size = new System.Drawing.Size(182, 30);
            this.txbMajorCourseID.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã môn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Tín chỉ";
            // 
            // FormEditMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 818);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditMajor";
            this.Text = "Chỉnh sửa ngành";
            this.Load += new System.EventHandler(this.FormEditMajor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCourse)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajorCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbMajorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMajorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCourseName;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.TextBox txbCourseCredits;
        private System.Windows.Forms.TextBox txbCourseID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dtgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeePerCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvMajorCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMajorCourseName;
        private System.Windows.Forms.TextBox txbMajorCourseCredits;
        private System.Windows.Forms.TextBox txbMajorCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}