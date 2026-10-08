namespace bai01_BTVN
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSoNgayO = new System.Windows.Forms.Label();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.grpLoaiPhong = new System.Windows.Forms.GroupBox();
            this.radPhongBa = new System.Windows.Forms.RadioButton();
            this.radPhongDoi = new System.Windows.Forms.RadioButton();
            this.radPhongDon = new System.Windows.Forms.RadioButton();
            this.grpTienNghi = new System.Windows.Forms.GroupBox();
            this.chkMayNuocNong = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkTivi = new System.Windows.Forms.CheckBox();
            this.grpDichVu = new System.Windows.Forms.GroupBox();
            this.chkAnSang = new System.Windows.Forms.CheckBox();
            this.chkKaraoke = new System.Windows.Forms.CheckBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnNhapMoi = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.grpTongKet = new System.Windows.Forms.GroupBox();
            this.txtTongSoTien = new System.Windows.Forms.TextBox();
            this.lblTongSoTien = new System.Windows.Forms.Label();
            this.txtSoLuotNguoi = new System.Windows.Forms.TextBox();
            this.lblSoLuotNguoi = new System.Windows.Forms.Label();
            this.btnTongKet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLoaiPhong.SuspendLayout();
            this.grpTienNghi.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            this.grpTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Location = new System.Drawing.Point(175, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(374, 24);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(25, 55);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(61, 15);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(95, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(275, 23);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiaChi.Location = new System.Drawing.Point(25, 90);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(46, 15);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(95, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 23);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            // 
            // lblSoNgayO
            // 
            this.lblSoNgayO.AutoSize = true;
            this.lblSoNgayO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoNgayO.Location = new System.Drawing.Point(25, 125);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new System.Drawing.Size(63, 15);
            this.lblSoNgayO.TabIndex = 5;
            this.lblSoNgayO.Text = "Số ngày ở:";
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(95, 122);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(95, 23);
            this.txtSoNgayO.TabIndex = 6;
            this.txtSoNgayO.TextChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            this.txtSoNgayO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoNgayO_KeyPress);
            // 
            // grpLoaiPhong
            // 
            this.grpLoaiPhong.Controls.Add(this.radPhongBa);
            this.grpLoaiPhong.Controls.Add(this.radPhongDoi);
            this.grpLoaiPhong.Controls.Add(this.radPhongDon);
            this.grpLoaiPhong.Location = new System.Drawing.Point(25, 160);
            this.grpLoaiPhong.Name = "grpLoaiPhong";
            this.grpLoaiPhong.Size = new System.Drawing.Size(110, 115);
            this.grpLoaiPhong.TabIndex = 7;
            this.grpLoaiPhong.TabStop = false;
            this.grpLoaiPhong.Text = "Loại phòng";
            // 
            // radPhongBa
            // 
            this.radPhongBa.AutoSize = true;
            this.radPhongBa.Location = new System.Drawing.Point(12, 80);
            this.radPhongBa.Name = "radPhongBa";
            this.radPhongBa.Size = new System.Drawing.Size(76, 19);
            this.radPhongBa.TabIndex = 2;
            this.radPhongBa.TabStop = true;
            this.radPhongBa.Text = "Phòng ba";
            this.radPhongBa.UseVisualStyleBackColor = true;
            this.radPhongBa.CheckedChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            // 
            // radPhongDoi
            // 
            this.radPhongDoi.AutoSize = true;
            this.radPhongDoi.Location = new System.Drawing.Point(12, 50);
            this.radPhongDoi.Name = "radPhongDoi";
            this.radPhongDoi.Size = new System.Drawing.Size(80, 19);
            this.radPhongDoi.TabIndex = 1;
            this.radPhongDoi.TabStop = true;
            this.radPhongDoi.Text = "Phòng đôi";
            this.radPhongDoi.UseVisualStyleBackColor = true;
            this.radPhongDoi.CheckedChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            // 
            // radPhongDon
            // 
            this.radPhongDon.AutoSize = true;
            this.radPhongDon.Location = new System.Drawing.Point(12, 22);
            this.radPhongDon.Name = "radPhongDon";
            this.radPhongDon.Size = new System.Drawing.Size(84, 19);
            this.radPhongDon.TabIndex = 0;
            this.radPhongDon.TabStop = true;
            this.radPhongDon.Text = "Phòng đơn";
            this.radPhongDon.UseVisualStyleBackColor = true;
            this.radPhongDon.CheckedChanged += new System.EventHandler(this.DuLieuNhap_Changed);
            // 
            // grpTienNghi
            // 
            this.grpTienNghi.Controls.Add(this.chkMayNuocNong);
            this.grpTienNghi.Controls.Add(this.chkInternet);
            this.grpTienNghi.Controls.Add(this.chkTivi);
            this.grpTienNghi.Location = new System.Drawing.Point(145, 160);
            this.grpTienNghi.Name = "grpTienNghi";
            this.grpTienNghi.Size = new System.Drawing.Size(125, 115);
            this.grpTienNghi.TabIndex = 8;
            this.grpTienNghi.TabStop = false;
            this.grpTienNghi.Text = "Tiện nghi";
            // 
            // chkMayNuocNong
            // 
            this.chkMayNuocNong.AutoSize = true;
            this.chkMayNuocNong.Location = new System.Drawing.Point(10, 80);
            this.chkMayNuocNong.Name = "chkMayNuocNong";
            this.chkMayNuocNong.Size = new System.Drawing.Size(108, 19);
            this.chkMayNuocNong.TabIndex = 2;
            this.chkMayNuocNong.Text = "Máy nước nóng";
            this.chkMayNuocNong.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(10, 50);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(67, 19);
            this.chkInternet.TabIndex = 1;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // chkTivi
            // 
            this.chkTivi.AutoSize = true;
            this.chkTivi.Location = new System.Drawing.Point(10, 22);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new System.Drawing.Size(44, 19);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            // 
            // grpDichVu
            // 
            this.grpDichVu.Controls.Add(this.chkAnSang);
            this.grpDichVu.Controls.Add(this.chkKaraoke);
            this.grpDichVu.Location = new System.Drawing.Point(280, 160);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new System.Drawing.Size(110, 115);
            this.grpDichVu.TabIndex = 9;
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Dịch vụ";
            // 
            // chkAnSang
            // 
            this.chkAnSang.AutoSize = true;
            this.chkAnSang.Location = new System.Drawing.Point(12, 60);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new System.Drawing.Size(69, 19);
            this.chkAnSang.TabIndex = 1;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            // 
            // chkKaraoke
            // 
            this.chkKaraoke.AutoSize = true;
            this.chkKaraoke.Location = new System.Drawing.Point(12, 25);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new System.Drawing.Size(69, 19);
            this.chkKaraoke.TabIndex = 0;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(415, 48);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(85, 30);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnNhapMoi
            // 
            this.btnNhapMoi.Location = new System.Drawing.Point(510, 48);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new System.Drawing.Size(85, 30);
            this.btnNhapMoi.TabIndex = 11;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new System.EventHandler(this.btnNhapMoi_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThanhTien.Location = new System.Drawing.Point(415, 90);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(66, 15);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtThanhTien.Location = new System.Drawing.Point(485, 87);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(185, 23);
            this.txtThanhTien.TabIndex = 13;
            // 
            // grpTongKet
            // 
            this.grpTongKet.Controls.Add(this.txtTongSoTien);
            this.grpTongKet.Controls.Add(this.lblTongSoTien);
            this.grpTongKet.Controls.Add(this.txtSoLuotNguoi);
            this.grpTongKet.Controls.Add(this.lblSoLuotNguoi);
            this.grpTongKet.Controls.Add(this.btnTongKet);
            this.grpTongKet.Location = new System.Drawing.Point(415, 120);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Size = new System.Drawing.Size(255, 125);
            this.grpTongKet.TabIndex = 14;
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Text = "Thông tin tổng kết";
            // 
            // txtTongSoTien
            // 
            this.txtTongSoTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongSoTien.Location = new System.Drawing.Point(85, 88);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.ReadOnly = true;
            this.txtTongSoTien.Size = new System.Drawing.Size(160, 23);
            this.txtTongSoTien.TabIndex = 4;
            // 
            // lblTongSoTien
            // 
            this.lblTongSoTien.AutoSize = true;
            this.lblTongSoTien.Location = new System.Drawing.Point(8, 92);
            this.lblTongSoTien.Name = "lblTongSoTien";
            this.lblTongSoTien.Size = new System.Drawing.Size(75, 15);
            this.lblTongSoTien.TabIndex = 3;
            this.lblTongSoTien.Text = "Tổng số tiền:";
            // 
            // txtSoLuotNguoi
            // 
            this.txtSoLuotNguoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoLuotNguoi.Location = new System.Drawing.Point(85, 55);
            this.txtSoLuotNguoi.Name = "txtSoLuotNguoi";
            this.txtSoLuotNguoi.ReadOnly = true;
            this.txtSoLuotNguoi.Size = new System.Drawing.Size(160, 23);
            this.txtSoLuotNguoi.TabIndex = 2;
            // 
            // lblSoLuotNguoi
            // 
            this.lblSoLuotNguoi.AutoSize = true;
            this.lblSoLuotNguoi.Location = new System.Drawing.Point(8, 58);
            this.lblSoLuotNguoi.Name = "lblSoLuotNguoi";
            this.lblSoLuotNguoi.Size = new System.Drawing.Size(81, 15);
            this.lblSoLuotNguoi.TabIndex = 1;
            this.lblSoLuotNguoi.Text = "Số lượt người:";
            // 
            // btnTongKet
            // 
            this.btnTongKet.Location = new System.Drawing.Point(10, 20);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new System.Drawing.Size(75, 26);
            this.btnTongKet.TabIndex = 0;
            this.btnTongKet.Text = "Tổng Kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new System.EventHandler(this.btnTongKet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(415, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 28);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 295);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpTongKet);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.grpTienNghi);
            this.Controls.Add(this.grpLoaiPhong);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.lblSoNgayO);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangkyKS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLoaiPhong.ResumeLayout(false);
            this.grpLoaiPhong.PerformLayout();
            this.grpTienNghi.ResumeLayout(false);
            this.grpTienNghi.PerformLayout();
            this.grpDichVu.ResumeLayout(false);
            this.grpDichVu.PerformLayout();
            this.grpTongKet.ResumeLayout(false);
            this.grpTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoNgayO;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.GroupBox grpLoaiPhong;
        private System.Windows.Forms.RadioButton radPhongBa;
        private System.Windows.Forms.RadioButton radPhongDoi;
        private System.Windows.Forms.RadioButton radPhongDon;
        private System.Windows.Forms.GroupBox grpTienNghi;
        private System.Windows.Forms.CheckBox chkMayNuocNong;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkTivi;
        private System.Windows.Forms.GroupBox grpDichVu;
        private System.Windows.Forms.CheckBox chkAnSang;
        private System.Windows.Forms.CheckBox chkKaraoke;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnNhapMoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.GroupBox grpTongKet;
        private System.Windows.Forms.TextBox txtTongSoTien;
        private System.Windows.Forms.Label lblTongSoTien;
        private System.Windows.Forms.TextBox txtSoLuotNguoi;
        private System.Windows.Forms.Label lblSoLuotNguoi;
        private System.Windows.Forms.Button btnTongKet;
        private System.Windows.Forms.Button btnThoat;
    }
}