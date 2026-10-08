namespace bai01_BTNC
{
    partial class Form1
    {
        /// <summary>
        /// Biến quản lý các thành phần designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Giải phóng tài nguyên đang sử dụng.
        /// </summary>
        /// <param name="disposing">true nếu giải phóng tài nguyên quản lý; ngược lại false.</param>
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
        /// Phương thức khởi tạo các thành phần giao diện.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSoKhachHang = new System.Windows.Forms.Label();
            this.txtSoKhachHang = new System.Windows.Forms.TextBox();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.grpNuocUong = new System.Windows.Forms.GroupBox();
            this.radCafeSuaDa = new System.Windows.Forms.RadioButton();
            this.radCafeKem = new System.Windows.Forms.RadioButton();
            this.radCafeSua = new System.Windows.Forms.RadioButton();
            this.radCafeDa = new System.Windows.Forms.RadioButton();
            this.radCafeDen = new System.Windows.Forms.RadioButton();
            this.grpThucAn = new System.Windows.Forms.GroupBox();
            this.chkMyCay = new System.Windows.Forms.CheckBox();
            this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
            this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
            this.chkBanhMyCa = new System.Windows.Forms.CheckBox();
            this.chkBanhMyTrung = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTongKhachHang = new System.Windows.Forms.Label();
            this.txtTongKhachHang = new System.Windows.Forms.TextBox();
            this.lblTongTienThanhToan = new System.Windows.Forms.Label();
            this.txtTongTienThanhToan = new System.Windows.Forms.TextBox();
            this.grpNuocUong.SuspendLayout();
            this.grpThucAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Location = new System.Drawing.Point(145, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(193, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CAFE SINH VIÊN";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenKhachHang.Location = new System.Drawing.Point(30, 56);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(109, 17);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenKhachHang.Location = new System.Drawing.Point(150, 53);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(280, 25);
            this.txtTenKhachHang.TabIndex = 2;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // lblSoKhachHang
            // 
            this.lblSoKhachHang.AutoSize = true;
            this.lblSoKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoKhachHang.Location = new System.Drawing.Point(30, 93);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new System.Drawing.Size(99, 17);
            this.lblSoKhachHang.TabIndex = 3;
            this.lblSoKhachHang.Text = "Số khách hàng";
            // 
            // txtSoKhachHang
            // 
            this.txtSoKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoKhachHang.Location = new System.Drawing.Point(150, 90);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new System.Drawing.Size(280, 25);
            this.txtSoKhachHang.TabIndex = 4;
            this.txtSoKhachHang.TextChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            this.txtSoKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoKhachHang_KeyPress);
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkSinhVien.Location = new System.Drawing.Point(165, 128);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(96, 21);
            this.chkSinhVien.TabIndex = 5;
            this.chkSinhVien.Text = "Sinh viên ?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // grpNuocUong
            // 
            this.grpNuocUong.Controls.Add(this.radCafeSuaDa);
            this.grpNuocUong.Controls.Add(this.radCafeKem);
            this.grpNuocUong.Controls.Add(this.radCafeSua);
            this.grpNuocUong.Controls.Add(this.radCafeDa);
            this.grpNuocUong.Controls.Add(this.radCafeDen);
            this.grpNuocUong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpNuocUong.Location = new System.Drawing.Point(25, 160);
            this.grpNuocUong.Name = "grpNuocUong";
            this.grpNuocUong.Size = new System.Drawing.Size(200, 150);
            this.grpNuocUong.TabIndex = 6;
            this.grpNuocUong.TabStop = false;
            this.grpNuocUong.Text = "Nước uống";
            // 
            // radCafeSuaDa
            // 
            this.radCafeSuaDa.AutoSize = true;
            this.radCafeSuaDa.Location = new System.Drawing.Point(10, 105);
            this.radCafeSuaDa.Name = "radCafeSuaDa";
            this.radCafeSuaDa.Size = new System.Drawing.Size(86, 19);
            this.radCafeSuaDa.TabIndex = 4;
            this.radCafeSuaDa.TabStop = true;
            this.radCafeSuaDa.Text = "Cafe sữa đá";
            this.radCafeSuaDa.UseVisualStyleBackColor = true;
            this.radCafeSuaDa.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // radCafeKem
            // 
            this.radCafeKem.AutoSize = true;
            this.radCafeKem.Location = new System.Drawing.Point(105, 65);
            this.radCafeKem.Name = "radCafeKem";
            this.radCafeKem.Size = new System.Drawing.Size(75, 19);
            this.radCafeKem.TabIndex = 3;
            this.radCafeKem.TabStop = true;
            this.radCafeKem.Text = "Cafe kem";
            this.radCafeKem.UseVisualStyleBackColor = true;
            this.radCafeKem.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // radCafeSua
            // 
            this.radCafeSua.AutoSize = true;
            this.radCafeSua.Location = new System.Drawing.Point(10, 65);
            this.radCafeSua.Name = "radCafeSua";
            this.radCafeSua.Size = new System.Drawing.Size(70, 19);
            this.radCafeSua.TabIndex = 2;
            this.radCafeSua.TabStop = true;
            this.radCafeSua.Text = "Cafe sữa";
            this.radCafeSua.UseVisualStyleBackColor = true;
            this.radCafeSua.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // radCafeDa
            // 
            this.radCafeDa.AutoSize = true;
            this.radCafeDa.Location = new System.Drawing.Point(105, 25);
            this.radCafeDa.Name = "radCafeDa";
            this.radCafeDa.Size = new System.Drawing.Size(65, 19);
            this.radCafeDa.TabIndex = 1;
            this.radCafeDa.TabStop = true;
            this.radCafeDa.Text = "Cafe đá";
            this.radCafeDa.UseVisualStyleBackColor = true;
            this.radCafeDa.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // radCafeDen
            // 
            this.radCafeDen.AutoSize = true;
            this.radCafeDen.Location = new System.Drawing.Point(10, 25);
            this.radCafeDen.Name = "radCafeDen";
            this.radCafeDen.Size = new System.Drawing.Size(72, 19);
            this.radCafeDen.TabIndex = 0;
            this.radCafeDen.TabStop = true;
            this.radCafeDen.Text = "Cafe đen";
            this.radCafeDen.UseVisualStyleBackColor = true;
            this.radCafeDen.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // grpThucAn
            // 
            this.grpThucAn.Controls.Add(this.chkMyCay);
            this.grpThucAn.Controls.Add(this.chkMyXaoBo);
            this.grpThucAn.Controls.Add(this.chkMyTomTrung);
            this.grpThucAn.Controls.Add(this.chkBanhMyCa);
            this.grpThucAn.Controls.Add(this.chkBanhMyTrung);
            this.grpThucAn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThucAn.Location = new System.Drawing.Point(235, 160);
            this.grpThucAn.Name = "grpThucAn";
            this.grpThucAn.Size = new System.Drawing.Size(225, 150);
            this.grpThucAn.TabIndex = 7;
            this.grpThucAn.TabStop = false;
            this.grpThucAn.Text = "Thức ăn";
            // 
            // chkMyCay
            // 
            this.chkMyCay.AutoSize = true;
            this.chkMyCay.Location = new System.Drawing.Point(120, 65);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new System.Drawing.Size(65, 19);
            this.chkMyCay.TabIndex = 4;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            this.chkMyCay.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // chkMyXaoBo
            // 
            this.chkMyXaoBo.AutoSize = true;
            this.chkMyXaoBo.Location = new System.Drawing.Point(120, 25);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new System.Drawing.Size(79, 19);
            this.chkMyXaoBo.TabIndex = 3;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            this.chkMyXaoBo.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // chkMyTomTrung
            // 
            this.chkMyTomTrung.AutoSize = true;
            this.chkMyTomTrung.Location = new System.Drawing.Point(10, 105);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new System.Drawing.Size(97, 19);
            this.chkMyTomTrung.TabIndex = 2;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            this.chkMyTomTrung.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // chkBanhMyCa
            // 
            this.chkBanhMyCa.AutoSize = true;
            this.chkBanhMyCa.Location = new System.Drawing.Point(10, 65);
            this.chkBanhMyCa.Name = "chkBanhMyCa";
            this.chkBanhMyCa.Size = new System.Drawing.Size(86, 19);
            this.chkBanhMyCa.TabIndex = 1;
            this.chkBanhMyCa.Text = "Bánh mỳ cá";
            this.chkBanhMyCa.UseVisualStyleBackColor = true;
            this.chkBanhMyCa.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // chkBanhMyTrung
            // 
            this.chkBanhMyTrung.AutoSize = true;
            this.chkBanhMyTrung.Location = new System.Drawing.Point(10, 25);
            this.chkBanhMyTrung.Name = "chkBanhMyTrung";
            this.chkBanhMyTrung.Size = new System.Drawing.Size(102, 19);
            this.chkBanhMyTrung.TabIndex = 0;
            this.chkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanhMyTrung.UseVisualStyleBackColor = true;
            this.chkBanhMyTrung.CheckedChanged += new System.EventHandler(this.DuLieu_ThayDoi);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTinhTien.Location = new System.Drawing.Point(40, 325);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(88, 30);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhapLai.Location = new System.Drawing.Point(145, 325);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(88, 30);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.Location = new System.Drawing.Point(250, 325);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(88, 30);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(355, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 30);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTongKhachHang
            // 
            this.lblTongKhachHang.AutoSize = true;
            this.lblTongKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongKhachHang.Location = new System.Drawing.Point(30, 380);
            this.lblTongKhachHang.Name = "lblTongKhachHang";
            this.lblTongKhachHang.Size = new System.Drawing.Size(116, 17);
            this.lblTongKhachHang.TabIndex = 12;
            this.lblTongKhachHang.Text = "Tổng khách hàng";
            // 
            // txtTongKhachHang
            // 
            this.txtTongKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongKhachHang.Location = new System.Drawing.Point(180, 377);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.ReadOnly = true;
            this.txtTongKhachHang.Size = new System.Drawing.Size(250, 25);
            this.txtTongKhachHang.TabIndex = 13;
            // 
            // lblTongTienThanhToan
            // 
            this.lblTongTienThanhToan.AutoSize = true;
            this.lblTongTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTienThanhToan.Location = new System.Drawing.Point(30, 420);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new System.Drawing.Size(142, 17);
            this.lblTongTienThanhToan.TabIndex = 14;
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán";
            // 
            // txtTongTienThanhToan
            // 
            this.txtTongTienThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTienThanhToan.Location = new System.Drawing.Point(180, 417);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.ReadOnly = true;
            this.txtTongTienThanhToan.Size = new System.Drawing.Size(250, 25);
            this.txtTongTienThanhToan.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 465);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.txtTongKhachHang);
            this.Controls.Add(this.lblTongKhachHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.grpThucAn);
            this.Controls.Add(this.grpNuocUong);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán tiền";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNuocUong.ResumeLayout(false);
            this.grpNuocUong.PerformLayout();
            this.grpThucAn.ResumeLayout(false);
            this.grpThucAn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSoKhachHang;
        private System.Windows.Forms.TextBox txtSoKhachHang;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.GroupBox grpNuocUong;
        private System.Windows.Forms.RadioButton radCafeSuaDa;
        private System.Windows.Forms.RadioButton radCafeKem;
        private System.Windows.Forms.RadioButton radCafeSua;
        private System.Windows.Forms.RadioButton radCafeDa;
        private System.Windows.Forms.RadioButton radCafeDen;
        private System.Windows.Forms.GroupBox grpThucAn;
        private System.Windows.Forms.CheckBox chkMyCay;
        private System.Windows.Forms.CheckBox chkMyXaoBo;
        private System.Windows.Forms.CheckBox chkMyTomTrung;
        private System.Windows.Forms.CheckBox chkBanhMyCa;
        private System.Windows.Forms.CheckBox chkBanhMyTrung;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongKhachHang;
        private System.Windows.Forms.TextBox txtTongKhachHang;
        private System.Windows.Forms.Label lblTongTienThanhToan;
        private System.Windows.Forms.TextBox txtTongTienThanhToan;
    }
}