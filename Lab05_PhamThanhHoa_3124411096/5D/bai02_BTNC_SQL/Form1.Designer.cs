namespace bai02_BTNC_SQL
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
            lblMaSV = new Label();
            lblMaMH = new Label();
            lblDiem = new Label();
            txtMaSV = new TextBox();
            txtMaMH = new TextBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(26, 23);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(74, 15);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sinh viên";
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(26, 61);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(75, 15);
            lblMaMH.TabIndex = 1;
            lblMaMH.Text = "Mã môn học";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(26, 98);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(35, 15);
            lblDiem.TabIndex = 2;
            lblDiem.Text = "Điểm";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(105, 21);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(193, 23);
            txtMaSV.TabIndex = 3;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(105, 58);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(193, 23);
            txtMaMH.TabIndex = 4;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(105, 96);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(193, 23);
            txtDiem.TabIndex = 5;
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
            Controls.Add(txtDiem);
            Controls.Add(txtMaMH);
            Controls.Add(txtMaSV);
            Controls.Add(lblDiem);
            Controls.Add(lblMaMH);
            Controls.Add(lblMaSV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}