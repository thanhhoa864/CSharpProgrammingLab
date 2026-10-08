namespace Bai1_BTTL
{
    partial class frmBai1
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
            groupBox1 = new GroupBox();
            rdoBacHai = new RadioButton();
            rdoBacNhat = new RadioButton();
            label1 = new Label();
            la = new Label();
            lb = new Label();
            lc = new Label();
            btnGiai = new Button();
            btnThoat = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            txtKetQua = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoBacHai);
            groupBox1.Controls.Add(rdoBacNhat);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rdoBacHai
            // 
            rdoBacHai.AutoSize = true;
            rdoBacHai.Location = new Point(11, 47);
            rdoBacHai.Name = "rdoBacHai";
            rdoBacHai.Size = new Size(136, 19);
            rdoBacHai.TabIndex = 1;
            rdoBacHai.TabStop = true;
            rdoBacHai.Text = "Phương trình bậc hai";
            rdoBacHai.UseVisualStyleBackColor = true;
            rdoBacHai.CheckedChanged += rdoBacHai_CheckedChanged;
            // 
            // rdoBacNhat
            // 
            rdoBacNhat.AutoSize = true;
            rdoBacNhat.Checked = true;
            rdoBacNhat.Location = new Point(11, 22);
            rdoBacNhat.Name = "rdoBacNhat";
            rdoBacNhat.Size = new Size(144, 19);
            rdoBacNhat.TabIndex = 0;
            rdoBacNhat.TabStop = true;
            rdoBacNhat.Text = "Phương trình bậc nhất";
            rdoBacNhat.UseVisualStyleBackColor = true;
            rdoBacNhat.CheckedChanged += rdoBacNhat_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 1;
            label1.Text = "Giải phương trình";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(17, 146);
            la.Name = "la";
            la.Size = new Size(45, 15);
            la.TabIndex = 2;
            la.Text = "Nhập a";
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Location = new Point(17, 175);
            lb.Name = "lb";
            lb.Size = new Size(46, 15);
            lb.TabIndex = 3;
            lb.Text = "Nhập b";
            // 
            // lc
            // 
            lc.AutoSize = true;
            lc.Location = new Point(17, 204);
            lc.Name = "lc";
            lc.Size = new Size(45, 15);
            lc.TabIndex = 4;
            lc.Text = "Nhập c";
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(186, 138);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(86, 41);
            btnGiai.TabIndex = 6;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(186, 185);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 34);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(66, 138);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 8;
            txtA.KeyPress += txtSo_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(66, 167);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 9;
            txtB.KeyPress += txtSo_KeyPress;
            // 
            // txtC
            // 
            txtC.Enabled = false;
            txtC.Location = new Point(66, 196);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 10;
            txtC.KeyPress += txtSo_KeyPress;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(66, 225);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(208, 72);
            txtKetQua.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 233);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Kết quả";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtKetQua);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnThoat);
            Controls.Add(btnGiai);
            Controls.Add(lc);
            Controls.Add(lb);
            Controls.Add(la);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmBai1";
            Text = "Giải pt";
            FormClosing += frmBai1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoBacHai;
        private RadioButton rdoBacNhat;
        private Label label1;
        private Label la;
        private Label lb;
        private Label lc;
        private Button btnGiai;
        private Button btnThoat;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtKetQua;
        private Label label2;
    }
}
