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
            lblTitle = new Label();
            lblSoTK = new Label();
            txtSoTK = new TextBox();
            lblTenKH = new Label();
            txtTenKH = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSoTien = new Label();
            txtSoTien = new TextBox();
            btnThem = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lvTaiKhoan = new ListView();
            colSTT = new ColumnHeader();
            colSoTK = new ColumnHeader();
            colTenKH = new ColumnHeader();
            colDiaChi = new ColumnHeader();
            colSoTien = new ColumnHeader();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.BlueViolet;
            lblTitle.Location = new Point(114, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(460, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // lblSoTK
            // 
            lblSoTK.AutoSize = true;
            lblSoTK.Location = new Point(201, 68);
            lblSoTK.Name = "lblSoTK";
            lblSoTK.Size = new Size(72, 15);
            lblSoTK.TabIndex = 1;
            lblSoTK.Text = "Số tài khoản";
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new Point(284, 65);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(289, 23);
            txtSoTK.TabIndex = 2;
            // 
            // lblTenKH
            // 
            lblTenKH.AutoSize = true;
            lblTenKH.Location = new Point(182, 101);
            lblTenKH.Name = "lblTenKH";
            lblTenKH.Size = new Size(90, 15);
            lblTenKH.TabIndex = 3;
            lblTenKH.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(284, 98);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(289, 23);
            txtTenKH.TabIndex = 4;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(172, 135);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(108, 15);
            lblDiaChi.TabIndex = 5;
            lblDiaChi.Text = "Địa chỉ khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(284, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(289, 23);
            txtDiaChi.TabIndex = 6;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(155, 169);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(127, 15);
            lblSoTien.TabIndex = 7;
            lblSoTien.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(284, 166);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(289, 23);
            txtSoTien.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(284, 202);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(66, 28);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(359, 202);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(66, 28);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(433, 202);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(66, 28);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(508, 202);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(66, 28);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { colSTT, colSoTK, colTenKH, colDiaChi, colSoTien });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.Location = new Point(22, 244);
            lvTaiKhoan.MultiSelect = false;
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(609, 164);
            lvTaiKhoan.TabIndex = 13;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // 
            // colSTT
            // 
            colSTT.Text = "STT";
            colSTT.Width = 50;
            // 
            // colSoTK
            // 
            colSoTK.Text = "Số tài khoản";
            colSoTK.Width = 130;
            // 
            // colTenKH
            // 
            colTenKH.Text = "Tên khách hàng";
            colTenKH.Width = 180;
            // 
            // colDiaChi
            // 
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 170;
            // 
            // colSoTien
            // 
            colSoTien.Text = "Số tiền";
            colSoTien.TextAlign = HorizontalAlignment.Right;
            colSoTien.Width = 140;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(381, 424);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(58, 15);
            lblTongTien.TabIndex = 14;
            lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.Location = new Point(446, 422);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(184, 23);
            txtTongTien.TabIndex = 15;
            txtTongTien.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 464);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(lvTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(txtSoTien);
            Controls.Add(lblSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(lblDiaChi);
            Controls.Add(txtTenKH);
            Controls.Add(lblTenKH);
            Controls.Add(txtSoTK);
            Controls.Add(lblSoTK);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2 bài tập trên lớp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSoTK;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colSoTK;
        private System.Windows.Forms.ColumnHeader colTenKH;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colSoTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}