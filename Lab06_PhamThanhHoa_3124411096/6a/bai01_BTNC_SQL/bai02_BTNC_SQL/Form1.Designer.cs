namespace bai02_BTNC_SQL
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
            label1 = new Label();
            label2 = new Label();
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNgaySinh = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 49);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã SV:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(76, 12);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(171, 23);
            txtMaLop.TabIndex = 2;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(76, 41);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(171, 23);
            txtMaSV.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(76, 70);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(171, 23);
            txtHoTen.TabIndex = 4;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(76, 99);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(171, 23);
            txtNgaySinh.TabIndex = 5;
            txtNgaySinh.Text = "__/__/____";
            txtNgaySinh.TextChanged += txtNgaySinh_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 78);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "Họ tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 107);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Ngày sinh";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(10, 128);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(91, 128);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(172, 128);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 155);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtNgaySinh;
        private Label label3;
        private Label label4;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;
    }
}
