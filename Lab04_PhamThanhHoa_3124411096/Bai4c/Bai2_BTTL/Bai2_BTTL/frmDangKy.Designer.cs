namespace Bai2_BTTL
{
    partial class frmDangKy
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
            label1 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnDangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(127, 41);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(253, 23);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Địa chỉ email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 4;
            label4.Text = "Xác nhận mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 23);
            txtEmail.TabIndex = 5;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(127, 109);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(253, 23);
            txtMatKhau.TabIndex = 6;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(127, 144);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '*';
            txtXacNhanMatKhau.Size = new Size(253, 23);
            txtXacNhanMatKhau.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 49);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 8;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(386, 83);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 9;
            label6.Text = "(*)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 117);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 10;
            label7.Text = "(*)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(162, 10);
            label8.Name = "label8";
            label8.Size = new Size(170, 28);
            label8.TabIndex = 11;
            label8.Text = "Đăng ký tài khoản";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(217, 173);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(81, 23);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "frmDangKy";
            Text = "Đăng ký tài khoản";
            FormClosing += this.frmDangKy_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ErrorProvider errorProvider1;
        private Button btnDangKy;
    }
}
