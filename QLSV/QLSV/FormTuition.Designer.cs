namespace QuanLySinhVien
{
    partial class FormTuition
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.lblTotalCredits = new System.Windows.Forms.Label();
            this.txbTotalCredits = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txbPaid = new System.Windows.Forms.TextBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.txbTotalFee = new System.Windows.Forms.TextBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.txbRemain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbShowAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(30, 134);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(133, 22);
            this.lblStudent.TabIndex = 19;
            this.lblStudent.Text = "Chọn sinh viên:";
            // 
            // cboStudent
            // 
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStudent.Location = new System.Drawing.Point(173, 134);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(440, 30);
            this.cboStudent.TabIndex = 20;
            this.cboStudent.SelectedIndexChanged += new System.EventHandler(this.cboStudent_SelectedIndexChanged);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(30, 53);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(58, 22);
            this.lblKhoa.TabIndex = 21;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhoa.Location = new System.Drawing.Point(173, 53);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(260, 30);
            this.cboKhoa.TabIndex = 22;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // lblNganh
            // 
            this.lblNganh.AutoSize = true;
            this.lblNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNganh.Location = new System.Drawing.Point(30, 93);
            this.lblNganh.Name = "lblNganh";
            this.lblNganh.Size = new System.Drawing.Size(66, 22);
            this.lblNganh.TabIndex = 23;
            this.lblNganh.Text = "Ngành:";
            // 
            // cboNganh
            // 
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNganh.Location = new System.Drawing.Point(173, 93);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(260, 30);
            this.cboNganh.TabIndex = 24;
            this.cboNganh.SelectedIndexChanged += new System.EventHandler(this.cboNganh_SelectedIndexChanged);
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(30, 189);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(122, 22);
            this.lblMonHoc.TabIndex = 25;
            this.lblMonHoc.Text = "Chọn môn học";
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMonHoc.Location = new System.Drawing.Point(173, 189);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(440, 129);
            this.clbMonHoc.TabIndex = 26;
            this.clbMonHoc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbMonHoc_ItemCheck);
            // 
            // lblTotalCredits
            // 
            this.lblTotalCredits.AutoSize = true;
            this.lblTotalCredits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredits.Location = new System.Drawing.Point(30, 369);
            this.lblTotalCredits.Name = "lblTotalCredits";
            this.lblTotalCredits.Size = new System.Drawing.Size(110, 22);
            this.lblTotalCredits.TabIndex = 27;
            this.lblTotalCredits.Text = "Tổng tín chỉ:";
            // 
            // txbTotalCredits
            // 
            this.txbTotalCredits.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalCredits.Location = new System.Drawing.Point(196, 366);
            this.txbTotalCredits.Name = "txbTotalCredits";
            this.txbTotalCredits.ReadOnly = true;
            this.txbTotalCredits.Size = new System.Drawing.Size(120, 30);
            this.txbTotalCredits.TabIndex = 28;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(387, 369);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(142, 22);
            this.lblPaid.TabIndex = 29;
            this.lblPaid.Text = "Đã đóng (VNĐ):";
            // 
            // txbPaid
            // 
            this.txbPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPaid.Location = new System.Drawing.Point(549, 366);
            this.txbPaid.Name = "txbPaid";
            this.txbPaid.Size = new System.Drawing.Size(180, 30);
            this.txbPaid.TabIndex = 30;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.Location = new System.Drawing.Point(30, 409);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(150, 22);
            this.lblTotalFee.TabIndex = 31;
            this.lblTotalFee.Text = "Tổng tiền (VNĐ):";
            // 
            // txbTotalFee
            // 
            this.txbTotalFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalFee.Location = new System.Drawing.Point(196, 406);
            this.txbTotalFee.Name = "txbTotalFee";
            this.txbTotalFee.ReadOnly = true;
            this.txbTotalFee.Size = new System.Drawing.Size(180, 30);
            this.txbTotalFee.TabIndex = 32;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.Location = new System.Drawing.Point(433, 410);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(151, 22);
            this.lblRemain.TabIndex = 33;
            this.lblRemain.Text = "Còn thiếu (VNĐ):";
            // 
            // txbRemain
            // 
            this.txbRemain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRemain.Location = new System.Drawing.Point(590, 407);
            this.txbRemain.Name = "txbRemain";
            this.txbRemain.ReadOnly = true;
            this.txbRemain.Size = new System.Drawing.Size(140, 30);
            this.txbRemain.TabIndex = 34;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(437, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 45);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Lưu dữ liệu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(588, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 45);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Đóng";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShowAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 27);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbShowAll
            // 
            this.tsbShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowAll.Name = "tsbShowAll";
            this.tsbShowAll.Size = new System.Drawing.Size(84, 24);
            this.tsbShowAll.Text = "Xem tất cả";
            this.tsbShowAll.Click += new System.EventHandler(this.tsbShowAll_Click);
            // 
            // FormTuition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.cboStudent);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lblNganh);
            this.Controls.Add(this.cboNganh);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblTotalCredits);
            this.Controls.Add(this.txbTotalCredits);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txbPaid);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.txbTotalFee);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.txbRemain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormTuition";
            this.Text = "FormTuition";
            this.Load += new System.EventHandler(this.FormTuition_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Label lblTotalCredits;
        private System.Windows.Forms.TextBox txbTotalCredits;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txbPaid;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.TextBox txbTotalFee;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.TextBox txbRemain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbShowAll;
    }
}