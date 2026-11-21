namespace bai02_BTVN
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpListbox = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.grpXuLy = new System.Windows.Forms.GroupBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnChonChan = new System.Windows.Forms.Button();
            this.btnChonLe = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grpListbox.SuspendLayout();
            this.grpXuLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Location = new System.Drawing.Point(180, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LISTBOX";
            // 
            // grpListbox
            // 
            this.grpListbox.Controls.Add(this.txtNhap);
            this.grpListbox.Controls.Add(this.btnNhap);
            this.grpListbox.Controls.Add(this.lstSo);
            this.grpListbox.Location = new System.Drawing.Point(12, 45);
            this.grpListbox.Name = "grpListbox";
            this.grpListbox.Size = new System.Drawing.Size(190, 315);
            this.grpListbox.TabIndex = 1;
            this.grpListbox.TabStop = false;
            this.grpListbox.Text = "Listbox";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(10, 25);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(170, 22);
            this.txtNhap.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(10, 55);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(170, 30);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(10, 95);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSo.Size = new System.Drawing.Size(170, 212);
            this.lstSo.TabIndex = 2;
            // 
            // grpXuLy
            // 
            this.grpXuLy.Controls.Add(this.btnTong);
            this.grpXuLy.Controls.Add(this.btnXoaDauCuoi);
            this.grpXuLy.Controls.Add(this.btnXoaChon);
            this.grpXuLy.Controls.Add(this.btnTang2);
            this.grpXuLy.Controls.Add(this.btnBinhPhuong);
            this.grpXuLy.Controls.Add(this.btnChonChan);
            this.grpXuLy.Controls.Add(this.btnChonLe);
            this.grpXuLy.Location = new System.Drawing.Point(215, 45);
            this.grpXuLy.Name = "grpXuLy";
            this.grpXuLy.Size = new System.Drawing.Size(255, 315);
            this.grpXuLy.TabIndex = 2;
            this.grpXuLy.TabStop = false;
            this.grpXuLy.Text = "Xử lý Listbox";
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(10, 24);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(235, 32);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng các phần tử trong List";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(10, 62);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(235, 32);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(10, 100);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(235, 32);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(10, 138);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(235, 32);
            this.btnTang2.TabIndex = 3;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(10, 176);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(235, 32);
            this.btnBinhPhuong.TabIndex = 4;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnChonChan
            // 
            this.btnChonChan.Location = new System.Drawing.Point(10, 214);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new System.Drawing.Size(235, 32);
            this.btnChonChan.TabIndex = 5;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new System.EventHandler(this.btnChonChan_Click);
            // 
            // btnChonLe
            // 
            this.btnChonLe.Location = new System.Drawing.Point(10, 252);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new System.Drawing.Size(235, 32);
            this.btnChonLe.TabIndex = 6;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new System.EventHandler(this.btnChonLe_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(12, 370);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(458, 35);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 418);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grpXuLy);
            this.Controls.Add(this.grpListbox);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListbox";
            this.grpListbox.ResumeLayout(false);
            this.grpListbox.PerformLayout();
            this.grpXuLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpListbox;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox grpXuLy;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnChonChan;
        private System.Windows.Forms.Button btnChonLe;
        private System.Windows.Forms.Button btnKetThuc;
    }
}