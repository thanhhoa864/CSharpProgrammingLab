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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtA = new TextBox();
            btnCong = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "a =";
            // 
            // txtA
            // 
            txtA.Location = new Point(56, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(66, 23);
            txtA.TabIndex = 1;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(12, 83);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(93, 84);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 3;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(174, 84);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 4;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(255, 84);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 5;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(174, 12);
            txtB.Name = "txtB";
            txtB.Size = new Size(66, 23);
            txtB.TabIndex = 6;
            txtB.KeyPress += txtB_KeyPress;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(65, 54);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(265, 23);
            txtKetQua.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 15);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 8;
            label2.Text = "b =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 57);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 9;
            label3.Text = "Kết Quả";
            // 
            // frmBai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txtA);
            Controls.Add(label1);
            Name = "frmBai1";
            Text = "Cộng trừ nhân chia";
            FormClosing += this.frmBai1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtA;
        private Button btnCong;
        private ErrorProvider errorProvider1;
        private Button btnTru;
        private TextBox txtB;
        private Button btnChia;
        private Button btnNhan;
        private Label label3;
        private Label label2;
        private TextBox txtKetQua;
    }
}
