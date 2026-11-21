namespace bai01_BTTL
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
            lblNhapSo = new Label();
            txtNhapSo = new TextBox();
            btnCapNhat = new Button();
            cboSo = new ComboBox();
            lblUocSo = new Label();
            lstUocSo = new ListBox();
            btnTongUoc = new Button();
            btnDemChan = new Button();
            btnDemNguyenTo = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblNhapSo
            // 
            lblNhapSo.AutoSize = true;
            lblNhapSo.Location = new Point(6, 9);
            lblNhapSo.Name = "lblNhapSo";
            lblNhapSo.Size = new Size(52, 15);
            lblNhapSo.TabIndex = 0;
            lblNhapSo.Text = "Nhập Số";
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(9, 32);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(106, 23);
            txtNhapSo.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(124, 30);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(79, 26);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // cboSo
            // 
            cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSo.FormattingEnabled = true;
            cboSo.Location = new Point(9, 66);
            cboSo.Name = "cboSo";
            cboSo.Size = new Size(195, 23);
            cboSo.TabIndex = 3;
            cboSo.SelectedIndexChanged += cboSo_SelectedIndexChanged;
            // 
            // lblUocSo
            // 
            lblUocSo.AutoSize = true;
            lblUocSo.Location = new Point(242, 9);
            lblUocSo.Name = "lblUocSo";
            lblUocSo.Size = new Size(121, 15);
            lblUocSo.TabIndex = 4;
            lblUocSo.Text = "Danh sách các ước số";
            // 
            // lstUocSo
            // 
            lstUocSo.FormattingEnabled = true;
            lstUocSo.Location = new Point(245, 32);
            lstUocSo.Name = "lstUocSo";
            lstUocSo.Size = new Size(219, 124);
            lstUocSo.TabIndex = 5;
            // 
            // btnTongUoc
            // 
            btnTongUoc.Location = new Point(245, 169);
            btnTongUoc.Name = "btnTongUoc";
            btnTongUoc.Size = new Size(219, 28);
            btnTongUoc.TabIndex = 6;
            btnTongUoc.Text = "Tổng các ước số";
            btnTongUoc.UseVisualStyleBackColor = true;
            btnTongUoc.Click += btnTongUoc_Click;
            // 
            // btnDemChan
            // 
            btnDemChan.Location = new Point(245, 206);
            btnDemChan.Name = "btnDemChan";
            btnDemChan.Size = new Size(219, 28);
            btnDemChan.TabIndex = 7;
            btnDemChan.Text = "Số lượng các ướ&c số chẵn";
            btnDemChan.UseVisualStyleBackColor = true;
            btnDemChan.Click += btnDemChan_Click;
            // 
            // btnDemNguyenTo
            // 
            btnDemNguyenTo.Location = new Point(245, 244);
            btnDemNguyenTo.Name = "btnDemNguyenTo";
            btnDemNguyenTo.Size = new Size(219, 28);
            btnDemNguyenTo.TabIndex = 8;
            btnDemNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            btnDemNguyenTo.UseVisualStyleBackColor = true;
            btnDemNguyenTo.Click += btnDemNguyenTo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(129, 244);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 28);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 314);
            Controls.Add(btnThoat);
            Controls.Add(btnDemNguyenTo);
            Controls.Add(btnDemChan);
            Controls.Add(btnTongUoc);
            Controls.Add(lstUocSo);
            Controls.Add(lblUocSo);
            Controls.Add(cboSo);
            Controls.Add(btnCapNhat);
            Controls.Add(txtNhapSo);
            Controls.Add(lblNhapSo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Combobox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Label lblUocSo;
        private System.Windows.Forms.ListBox lstUocSo;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.Button btnDemChan;
        private System.Windows.Forms.Button btnDemNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}