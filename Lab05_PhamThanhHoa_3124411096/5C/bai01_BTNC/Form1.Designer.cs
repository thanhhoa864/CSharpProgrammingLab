namespace bai01_BTNC
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
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaSon = new System.Windows.Forms.Button();
            this.btnXoaLe = new System.Windows.Forms.Button();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnInThuong = new System.Windows.Forms.Button();
            this.btnVietHoaDauTu = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgauNhien.Location = new System.Drawing.Point(40, 16);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(200, 36);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 20;
            this.lstDanhSach.Location = new System.Drawing.Point(20, 62);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDanhSach.Size = new System.Drawing.Size(240, 364);
            this.lstDanhSach.TabIndex = 1;
            this.lstDanhSach.DoubleClick += new System.EventHandler(this.lstDanhSach_DoubleClick);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChon.Location = new System.Drawing.Point(280, 62);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(260, 38);
            this.btnXoaChon.TabIndex = 2;
            this.btnXoaChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaSon
            // 
            this.btnXoaSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSon.Location = new System.Drawing.Point(280, 110);
            this.btnXoaSon.Name = "btnXoaSon";
            this.btnXoaSon.Size = new System.Drawing.Size(260, 38);
            this.btnXoaSon.TabIndex = 3;
            this.btnXoaSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaSon.UseVisualStyleBackColor = true;
            this.btnXoaSon.Click += new System.EventHandler(this.btnXoaSon_Click);
            // 
            // btnXoaLe
            // 
            this.btnXoaLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLe.Location = new System.Drawing.Point(280, 158);
            this.btnXoaLe.Name = "btnXoaLe";
            this.btnXoaLe.Size = new System.Drawing.Size(260, 38);
            this.btnXoaLe.TabIndex = 4;
            this.btnXoaLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaLe.UseVisualStyleBackColor = true;
            this.btnXoaLe.Click += new System.EventHandler(this.btnXoaLe_Click);
            // 
            // btnInHoa
            // 
            this.btnInHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoa.Location = new System.Drawing.Point(280, 206);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(260, 42);
            this.btnInHoa.TabIndex = 5;
            this.btnInHoa.Text = "Chuyển PT đang chọn thành chữ\r\nHOA";
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnInThuong
            // 
            this.btnInThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInThuong.Location = new System.Drawing.Point(280, 258);
            this.btnInThuong.Name = "btnInThuong";
            this.btnInThuong.Size = new System.Drawing.Size(260, 42);
            this.btnInThuong.TabIndex = 6;
            this.btnInThuong.Text = "Chuyển PT đang chọn thành chữ\r\nthường";
            this.btnInThuong.UseVisualStyleBackColor = true;
            this.btnInThuong.Click += new System.EventHandler(this.btnInThuong_Click);
            // 
            // btnVietHoaDauTu
            // 
            this.btnVietHoaDauTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVietHoaDauTu.Location = new System.Drawing.Point(280, 310);
            this.btnVietHoaDauTu.Name = "btnVietHoaDauTu";
            this.btnVietHoaDauTu.Size = new System.Drawing.Size(260, 52);
            this.btnVietHoaDauTu.TabIndex = 7;
            this.btnVietHoaDauTu.Text = "Chuyển PT đang chọn thành viết\r\nHoa đầu mỗi từ";
            this.btnVietHoaDauTu.UseVisualStyleBackColor = true;
            this.btnVietHoaDauTu.Click += new System.EventHandler(this.btnVietHoaDauTu_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCa.Location = new System.Drawing.Point(280, 372);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(260, 38);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 445);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnVietHoaDauTu);
            this.Controls.Add(this.btnInThuong);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.btnXoaLe);
            this.Controls.Add(this.btnXoaSon);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.btnNgauNhien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuoi";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaSon;
        private System.Windows.Forms.Button btnXoaLe;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnInThuong;
        private System.Windows.Forms.Button btnVietHoaDauTu;
        private System.Windows.Forms.Button btnXoaTatCa;
    }
}