namespace Bai2_QuanLyDiem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMaSV = new System.Windows.Forms.Label();
            lblMaMH = new System.Windows.Forms.Label();
            lblDiem = new System.Windows.Forms.Label();
            txtMaSV = new System.Windows.Forms.TextBox();
            txtMaMH = new System.Windows.Forms.TextBox();
            txtDiem = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new System.Drawing.Point(22, 28);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new System.Drawing.Size(42, 15);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã sv";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new System.Drawing.Point(91, 24);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new System.Drawing.Size(154, 23);
            txtMaSV.TabIndex = 1;
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new System.Drawing.Point(22, 62);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new System.Drawing.Size(44, 15);
            lblMaMH.TabIndex = 2;
            lblMaMH.Text = "Mã mh";
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new System.Drawing.Point(91, 58);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new System.Drawing.Size(154, 23);
            txtMaMH.TabIndex = 3;
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new System.Drawing.Point(22, 96);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new System.Drawing.Size(34, 15);
            lblDiem.TabIndex = 4;
            lblDiem.Text = "Điểm";
            // 
            // txtDiem
            // 
            txtDiem.Location = new System.Drawing.Point(91, 92);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new System.Drawing.Size(154, 23);
            txtDiem.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(22, 135);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(65, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(105, 135);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(65, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(188, 135);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(65, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(280, 190);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(lblDiem);
            Controls.Add(txtMaMH);
            Controls.Add(lblMaMH);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaSV);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý Điểm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
