namespace QuanLySinhVien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMajor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTuition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnShow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.btnCalculate = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSearchDepartment = new System.Windows.Forms.ComboBox();
            this.dtpkSearchBirth = new System.Windows.Forms.DateTimePicker();
            this.cboSearchSex = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSearchStudentID = new System.Windows.Forms.TextBox();
            this.txbSearchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.colStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // tsmiUser
            // 
            this.tsmiUser.Name = "tsmiUser";
            this.tsmiUser.Size = new System.Drawing.Size(207, 26);
            this.tsmiUser.Text = "Quản lý tài khoản";
            this.tsmiUser.Click += new System.EventHandler(this.tsmiUser_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmployee,
            this.tsmiDepartment,
            this.tsmiMajor,
            this.tsmiCourse,
            this.tsmiTuition});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // tsmiEmployee
            // 
            this.tsmiEmployee.Name = "tsmiEmployee";
            this.tsmiEmployee.Size = new System.Drawing.Size(224, 26);
            this.tsmiEmployee.Text = "Sinh viên";
            this.tsmiEmployee.Click += new System.EventHandler(this.tsmiEmployee_Click);
            // 
            // tsmiDepartment
            // 
            this.tsmiDepartment.Name = "tsmiDepartment";
            this.tsmiDepartment.Size = new System.Drawing.Size(224, 26);
            this.tsmiDepartment.Text = "Khoa";
            this.tsmiDepartment.Click += new System.EventHandler(this.tsmiDepartment_Click);
            // 
            // tsmiMajor
            // 
            this.tsmiMajor.Name = "tsmiMajor";
            this.tsmiMajor.Size = new System.Drawing.Size(224, 26);
            this.tsmiMajor.Text = "Ngành";
            this.tsmiMajor.Click += new System.EventHandler(this.tsmiMajor_Click);
            // 
            // tsmiCourse
            // 
            this.tsmiCourse.Name = "tsmiCourse";
            this.tsmiCourse.Size = new System.Drawing.Size(224, 26);
            this.tsmiCourse.Text = "Môn học";
            this.tsmiCourse.Click += new System.EventHandler(this.tsmiCourse_Click);
            // 
            // tsmiTuition
            // 
            this.tsmiTuition.Name = "tsmiTuition";
            this.tsmiTuition.Size = new System.Drawing.Size(224, 26);
            this.tsmiTuition.Text = "Học phí";
            this.tsmiTuition.Click += new System.EventHandler(this.tsmiTuition_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShow,
            this.toolStripSeparator4,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnSave,
            this.btnRefresh,
            this.btnShowAll,
            this.btnCalculate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1348, 27);
            this.toolStrip1.TabIndex = 1;
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAddNew
            // 
            this.btnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(50, 24);
            this.btnAddNew.Text = "Thêm";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 24);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 24);
            this.btnRefresh.Text = "Cập nhật";
            this.btnRefresh.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.RightToLeftAutoMirrorImage = true;
            this.btnShowAll.Size = new System.Drawing.Size(106, 24);
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCalculate.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculate.Image")));
            this.btnCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(70, 24);
            this.btnCalculate.Text = "Tính tiền";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSearchDepartment);
            this.groupBox1.Controls.Add(this.dtpkSearchBirth);
            this.groupBox1.Controls.Add(this.cboSearchSex);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbSearchStudentID);
            this.groupBox1.Controls.Add(this.txbSearchName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1233, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cboSearchDepartment
            // 
            this.cboSearchDepartment.FormattingEnabled = true;
            this.cboSearchDepartment.Location = new System.Drawing.Point(675, 62);
            this.cboSearchDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearchDepartment.Name = "cboSearchDepartment";
            this.cboSearchDepartment.Size = new System.Drawing.Size(255, 30);
            this.cboSearchDepartment.TabIndex = 13;
            // 
            // dtpkSearchBirth
            // 
            this.dtpkSearchBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkSearchBirth.Location = new System.Drawing.Point(106, 139);
            this.dtpkSearchBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkSearchBirth.Name = "dtpkSearchBirth";
            this.dtpkSearchBirth.ShowCheckBox = true;
            this.dtpkSearchBirth.Size = new System.Drawing.Size(200, 30);
            this.dtpkSearchBirth.TabIndex = 12;
            // 
            // cboSearchSex
            // 
            this.cboSearchSex.FormattingEnabled = true;
            this.cboSearchSex.Location = new System.Drawing.Point(453, 60);
            this.cboSearchSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSearchSex.Name = "cboSearchSex";
            this.cboSearchSex.Size = new System.Drawing.Size(183, 30);
            this.cboSearchSex.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(675, 139);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã sinh viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // txbSearchStudentID
            // 
            this.txbSearchStudentID.Location = new System.Drawing.Point(453, 139);
            this.txbSearchStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearchStudentID.Name = "txbSearchStudentID";
            this.txbSearchStudentID.Size = new System.Drawing.Size(183, 30);
            this.txbSearchStudentID.TabIndex = 6;
            // 
            // txbSearchName
            // 
            this.txbSearchName.Location = new System.Drawing.Point(106, 62);
            this.txbSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSearchName.Name = "txbSearchName";
            this.txbSearchName.Size = new System.Drawing.Size(200, 30);
            this.txbSearchName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "DANH SÁCH SINH VIÊN";
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentCode,
            this.colName,
            this.colBirthDay,
            this.colSex,
            this.colDepartment,
            this.colPosition,
            this.colStatus});
            this.dtgvStudent.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvStudent.Location = new System.Drawing.Point(16, 33);
            this.dtgvStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvStudent.MultiSelect = false;
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.ReadOnly = true;
            this.dtgvStudent.RowHeadersWidth = 60;
            this.dtgvStudent.RowTemplate.Height = 24;
            this.dtgvStudent.Size = new System.Drawing.Size(1191, 194);
            this.dtgvStudent.TabIndex = 11;
            this.dtgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStudent_CellClick);
            // 
            // colStudentCode
            // 
            this.colStudentCode.DataPropertyName = "StudentID";
            this.colStudentCode.HeaderText = "Mã sinh viên";
            this.colStudentCode.MinimumWidth = 6;
            this.colStudentCode.Name = "colStudentCode";
            this.colStudentCode.ReadOnly = true;
            this.colStudentCode.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Họ tên";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 125;
            // 
            // colBirthDay
            // 
            this.colBirthDay.DataPropertyName = "BirthDay";
            this.colBirthDay.HeaderText = "Ngày sinh";
            this.colBirthDay.MinimumWidth = 6;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.ReadOnly = true;
            this.colBirthDay.Width = 125;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "Giới tính";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Width = 125;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "Department";
            this.colDepartment.HeaderText = "Khoa";
            this.colDepartment.MinimumWidth = 6;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Width = 125;
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "Chức vụ";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvStudent);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(52, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1233, 250);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Quản lý sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiUser;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartment;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNew;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSearchStudentID;
        private System.Windows.Forms.TextBox txbSearchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.ComboBox cboSearchSex;
        private System.Windows.Forms.DateTimePicker dtpkSearchBirth;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnShow;
        private System.Windows.Forms.ComboBox cboSearchDepartment;
        private System.Windows.Forms.ToolStripButton btnShowAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiMajor;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuition;
        private System.Windows.Forms.ToolStripMenuItem tsmiCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.ToolStripButton btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}