namespace bai01_BTVN_SQL
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
            lblMaKhoa = new Label();
            lblMaLop = new Label();
            lblTenLop = new Label();
            txtMaKhoa = new TextBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(26, 23);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(53, 15);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(26, 61);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(44, 15);
            lblMaLop.TabIndex = 1;
            lblMaLop.Text = "Mã lớp";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(26, 98);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(45, 15);
            lblTenLop.TabIndex = 2;
            lblTenLop.Text = "Tên lớp";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(105, 21);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(193, 23);
            txtMaKhoa.TabIndex = 3;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(105, 58);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(193, 23);
            txtMaLop.TabIndex = 4;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(105, 96);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(193, 23);
            txtTenLop.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(29, 141);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(122, 141);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(219, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 192);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblTenLop);
            Controls.Add(lblMaLop);
            Controls.Add(lblMaKhoa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài tập về nhà bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}