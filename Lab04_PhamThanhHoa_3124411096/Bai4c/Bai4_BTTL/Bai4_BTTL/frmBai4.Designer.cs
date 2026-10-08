namespace Bai4_BTTL
{
    partial class frmBai4
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
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnTiepTuc = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            txtNhap = new TextBox();
            txtDaySo = new TextBox();
            txtTongLe = new TextBox();
            txtTongChan = new TextBox();
            txtTong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập dãy số và tính tổng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 44);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 72);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Dãy Các số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 101);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 3;
            label4.Text = "Tổng các phần tử có trong dãy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 130);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "Tổng chẵn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 130);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 5;
            label6.Text = "Tổng lẽ";
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(63, 164);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(75, 23);
            btnTiepTuc.TabIndex = 6;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(198, 40);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 7;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(144, 164);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtNhap
            // 
            txtNhap.Location = new Point(117, 40);
            txtNhap.Name = "txtNhap";
            txtNhap.Size = new Size(77, 23);
            txtNhap.TabIndex = 9;
            // 
            // txtDaySo
            // 
            txtDaySo.Location = new Point(117, 69);
            txtDaySo.Name = "txtDaySo";
            txtDaySo.Size = new Size(156, 23);
            txtDaySo.TabIndex = 10;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(221, 127);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.Size = new Size(51, 23);
            txtTongLe.TabIndex = 11;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(117, 127);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.Size = new Size(51, 23);
            txtTongChan.TabIndex = 12;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(221, 98);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(51, 23);
            txtTong.TabIndex = 13;
            // 
            // frmBai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTong);
            Controls.Add(txtTongChan);
            Controls.Add(txtTongLe);
            Controls.Add(txtDaySo);
            Controls.Add(txtNhap);
            Controls.Add(btnThoat);
            Controls.Add(btnNhap);
            Controls.Add(btnTiepTuc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai4";
            Text = "Form1";
            FormClosing += frmBai4_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox txtTong;
        private TextBox txtTongChan;
        private TextBox txtTongLe;
        private TextBox txtDaySo;
        private TextBox txtNhap;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnTiepTuc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
