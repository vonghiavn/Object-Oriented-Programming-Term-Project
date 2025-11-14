namespace QuanLySinhVien
{
    partial class FormShowInfoMajor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMajorName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMajorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbDepartment = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvMajorCourse = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMajorCourseName = new System.Windows.Forms.TextBox();
            this.txbMajorCourseCredits = new System.Windows.Forms.TextBox();
            this.txbMajorCourseID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajorCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1013, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 41);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Tên ngành";
            // 
            // txbMajorName
            // 
            this.txbMajorName.Location = new System.Drawing.Point(190, 55);
            this.txbMajorName.Name = "txbMajorName";
            this.txbMajorName.ReadOnly = true;
            this.txbMajorName.Size = new System.Drawing.Size(182, 30);
            this.txbMajorName.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Khoa";
            // 
            // txbMajorID
            // 
            this.txbMajorID.Location = new System.Drawing.Point(190, 101);
            this.txbMajorID.Name = "txbMajorID";
            this.txbMajorID.ReadOnly = true;
            this.txbMajorID.Size = new System.Drawing.Size(182, 30);
            this.txbMajorID.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã ngành";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDepartment);
            this.groupBox2.Controls.Add(this.txbMajorName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbMajorID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(65, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 167);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ngành";
            // 
            // txbDepartment
            // 
            this.txbDepartment.Location = new System.Drawing.Point(631, 52);
            this.txbDepartment.Name = "txbDepartment";
            this.txbDepartment.ReadOnly = true;
            this.txbDepartment.Size = new System.Drawing.Size(182, 30);
            this.txbDepartment.TabIndex = 51;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvMajorCourse);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txbMajorCourseName);
            this.groupBox3.Controls.Add(this.txbMajorCourseCredits);
            this.groupBox3.Controls.Add(this.txbMajorCourseID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(65, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1083, 276);
            this.groupBox3.TabIndex = 67;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tên môn";
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
            // FormShowInfoMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 736);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormShowInfoMajor";
            this.Text = "Hiển thị thông tin khoa";
            this.Load += new System.EventHandler(this.FormShowInfoMajor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMajorCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMajorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMajorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDepartment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvMajorCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMajorCourseName;
        private System.Windows.Forms.TextBox txbMajorCourseCredits;
        private System.Windows.Forms.TextBox txbMajorCourseID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}