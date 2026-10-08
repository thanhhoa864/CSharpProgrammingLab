namespace Bai5_BTTL
{
    partial class frmBai5
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
            txtSo = new TextBox();
            txtKetQua = new TextBox();
            btnThucHien = new Button();
            btnXoa = new Button();
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
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 37);
            label1.TabIndex = 0;
            label1.Text = "Đọc số thành chữ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập dãy số: (Từ 1 đến 999)";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(186, 49);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(58, 23);
            txtSo.TabIndex = 2;
            // 
            // txtKetQua
            // 
            txtKetQua.BackColor = Color.IndianRed;
            txtKetQua.BorderStyle = BorderStyle.None;
            txtKetQua.Location = new Point(7, 108);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(237, 16);
            txtKetQua.TabIndex = 3;
            // 
            // btnThucHien
            // 
            btnThucHien.Location = new Point(7, 79);
            btnThucHien.Name = "btnThucHien";
            btnThucHien.Size = new Size(75, 23);
            btnThucHien.TabIndex = 4;
            btnThucHien.Text = "Thực hiện";
            btnThucHien.UseVisualStyleBackColor = true;
            btnThucHien.Click += btnThucHien_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(88, 79);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(169, 79);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmBai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThucHien);
            Controls.Add(txtKetQua);
            Controls.Add(txtSo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai5";
            Text = "Tâm gà - Đọc chữ số";
            FormClosing += this.frmBai5_FormClosing;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnThucHien;
        private TextBox txtKetQua;
        private TextBox txtSo;
        private Label label2;
        private Label label1;
    }
}
