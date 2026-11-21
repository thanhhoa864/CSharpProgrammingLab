namespace Bai01_BTVN_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            txtMaKhoa = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtMaLop = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtTenLop = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new System.Drawing.Point(120, 30);
            txtMaKhoa.MaxLength = 10;
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new System.Drawing.Size(270, 23);
            txtMaKhoa.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(30, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã lớp";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new System.Drawing.Point(120, 70);
            txtMaLop.MaxLength = 10;
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new System.Drawing.Size(270, 23);
            txtMaLop.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Tên lớp";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new System.Drawing.Point(120, 110);
            txtTenLop.MaxLength = 100;
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new System.Drawing.Size(270, 23);
            txtTenLop.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(30, 160);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(100, 32);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(160, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(100, 32);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(290, 160);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(100, 32);
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
            ClientSize = new System.Drawing.Size(420, 215);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenLop);
            Controls.Add(label3);
            Controls.Add(txtMaLop);
            Controls.Add(label2);
            Controls.Add(txtMaKhoa);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLop";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
