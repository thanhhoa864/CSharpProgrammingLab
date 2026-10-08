namespace Bai3_BTTL
{
    partial class frmBai3
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtUCLN = new TextBox();
            txtBCNN = new TextBox();
            btnThucHien = new Button();
            btnTiepTuc = new Button();
            btnThoat = new Button();
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 28);
            label1.TabIndex = 0;
            label1.Text = "Ước số chung - Bội số chung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 84);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Nhập số b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 123);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 3;
            label4.Text = "Ước số chung lớn nhất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 164);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 4;
            label5.Text = "Bội số chung nhỏ nhất:";
            // 
            // txtA
            // 
            txtA.Location = new Point(84, 46);
            txtA.Name = "txtA";
            txtA.Size = new Size(125, 23);
            txtA.TabIndex = 5;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(84, 81);
            txtB.Name = "txtB";
            txtB.Size = new Size(125, 23);
            txtB.TabIndex = 6;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtUCLN
            // 
            txtUCLN.Location = new Point(151, 120);
            txtUCLN.Name = "txtUCLN";
            txtUCLN.Size = new Size(58, 23);
            txtUCLN.TabIndex = 7;
            // 
            // txtBCNN
            // 
            txtBCNN.Location = new Point(151, 161);
            txtBCNN.Name = "txtBCNN";
            txtBCNN.Size = new Size(58, 23);
            txtBCNN.TabIndex = 8;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(15, 191);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(75, 23);
            btnThucHien.TabIndex = 9;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnTiepTuc
            // 
            btnTiepTuc.Location = new Point(96, 191);
            btnTiepTuc.Name = "btnTiepTuc";
            btnTiepTuc.Size = new Size(75, 23);
            btnTiepTuc.TabIndex = 10;
            btnTiepTuc.Text = "Tiếp tục";
            btnTiepTuc.UseVisualStyleBackColor = true;
            btnTiepTuc.Click += btnTiepTuc_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(177, 191);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnTiepTuc);
            Controls.Add(btnThucHien);
            Controls.Add(txtBCNN);
            Controls.Add(txtUCLN);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai3";
            Text = "Ước số - Bội số";
            FormClosing += this.frmBai3_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Label label1;
        private Button btnThoat;
        private Button btnTiepTuc;
        private Button btnThucHien;
        private TextBox txtBCNN;
        private TextBox txtUCLN;
        private TextBox txtB;
        private TextBox txtA;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
