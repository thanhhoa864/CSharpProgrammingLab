namespace bai02_BTTL
{
    partial class Form1
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
            tvLop = new TreeView();
            lblChonLop = new Label();
            cboLop = new ComboBox();
            grpSinhVien = new GroupBox();
            btnXoa = new Button();
            btnCapNhat = new Button();
            txtDiaChi = new TextBox();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            lblDiaChi = new Label();
            lblHoTen = new Label();
            lblMaSV = new Label();
            chkThemLop = new CheckBox();
            grpThemLop = new GroupBox();
            btnThemLop = new Button();
            txtTenLop = new TextBox();
            lblTenLop = new Label();
            grpSinhVien.SuspendLayout();
            grpThemLop.SuspendLayout();
            SuspendLayout();
            // 
            // tvLop
            // 
            tvLop.Location = new Point(10, 11);
            tvLop.Name = "tvLop";
            tvLop.Size = new Size(228, 394);
            tvLop.TabIndex = 0;
            tvLop.AfterSelect += tvLop_AfterSelect;
            // 
            // lblChonLop
            // 
            lblChonLop.AutoSize = true;
            lblChonLop.Location = new Point(262, 23);
            lblChonLop.Name = "lblChonLop";
            lblChonLop.Size = new Size(59, 15);
            lblChonLop.TabIndex = 1;
            lblChonLop.Text = "Chọn Lớp";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(328, 21);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(237, 23);
            cboLop.TabIndex = 2;
            // 
            // grpSinhVien
            // 
            grpSinhVien.Controls.Add(btnXoa);
            grpSinhVien.Controls.Add(btnCapNhat);
            grpSinhVien.Controls.Add(txtDiaChi);
            grpSinhVien.Controls.Add(txtHoTen);
            grpSinhVien.Controls.Add(txtMaSV);
            grpSinhVien.Controls.Add(lblDiaChi);
            grpSinhVien.Controls.Add(lblHoTen);
            grpSinhVien.Controls.Add(lblMaSV);
            grpSinhVien.Location = new Point(254, 61);
            grpSinhVien.Name = "grpSinhVien";
            grpSinhVien.Size = new Size(319, 206);
            grpSinhVien.TabIndex = 3;
            grpSinhVien.TabStop = false;
            grpSinhVien.Text = "Thông tin sinh viên";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(188, 159);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(88, 28);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(74, 159);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(88, 28);
            btnCapNhat.TabIndex = 6;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(74, 117);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(228, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(74, 75);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(228, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(74, 33);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(228, 23);
            txtMaSV.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(13, 120);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(45, 15);
            lblDiaChi.TabIndex = 2;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(13, 78);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(44, 15);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(13, 36);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(43, 15);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // chkThemLop
            // 
            chkThemLop.AutoSize = true;
            chkThemLop.Location = new Point(254, 281);
            chkThemLop.Name = "chkThemLop";
            chkThemLop.Size = new Size(76, 19);
            chkThemLop.TabIndex = 4;
            chkThemLop.Text = "Thêm lớp";
            chkThemLop.UseVisualStyleBackColor = true;
            chkThemLop.CheckedChanged += chkThemLop_CheckedChanged;
            // 
            // grpThemLop
            // 
            grpThemLop.Controls.Add(btnThemLop);
            grpThemLop.Controls.Add(txtTenLop);
            grpThemLop.Controls.Add(lblTenLop);
            grpThemLop.Location = new Point(254, 309);
            grpThemLop.Name = "grpThemLop";
            grpThemLop.Size = new Size(319, 75);
            grpThemLop.TabIndex = 5;
            grpThemLop.TabStop = false;
            grpThemLop.Text = "Thông tin lớp";
            // 
            // btnThemLop
            // 
            btnThemLop.Location = new Point(228, 26);
            btnThemLop.Name = "btnThemLop";
            btnThemLop.Size = new Size(83, 26);
            btnThemLop.TabIndex = 2;
            btnThemLop.Text = "Thêm lớp";
            btnThemLop.UseVisualStyleBackColor = true;
            btnThemLop.Click += btnThemLop_Click;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(74, 29);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(145, 23);
            txtTenLop.TabIndex = 1;
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(13, 32);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(45, 15);
            lblTenLop.TabIndex = 0;
            lblTenLop.Text = "Tên lớp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 417);
            Controls.Add(grpThemLop);
            Controls.Add(chkThemLop);
            Controls.Add(grpSinhVien);
            Controls.Add(cboLop);
            Controls.Add(lblChonLop);
            Controls.Add(tvLop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sinh viên";
            grpSinhVien.ResumeLayout(false);
            grpSinhVien.PerformLayout();
            grpThemLop.ResumeLayout(false);
            grpThemLop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView tvLop;
        private System.Windows.Forms.Label lblChonLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.GroupBox grpSinhVien;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chkThemLop;
        private System.Windows.Forms.GroupBox grpThemLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThemLop;
    }
}