namespace Bai01_BTNC_SQL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            lvLop = new ListView();
            btnHienThi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lvLop
            // 
            lvLop.FullRowSelect = true;
            lvLop.GridLines = true;
            lvLop.Location = new Point(25, 30);
            lvLop.Name = "lvLop";
            lvLop.Size = new Size(650, 260);
            lvLop.TabIndex = 0;
            lvLop.UseCompatibleStateImageBehavior = false;
            lvLop.View = View.Details;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(25, 322);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(115, 34);
            btnHienThi.TabIndex = 1;
            btnHienThi.Text = "Hiển thị dữ liệu";
            btnHienThi.Click += HienThi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(150, 322);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 34);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.Click += Thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 390);
            Controls.Add(lvLop);
            Controls.Add(btnHienThi);
            Controls.Add(btnThoat);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách lớp";
            ResumeLayout(false);
        }
        private ListView lvLop;
        private Button btnHienThi;
        private Button btnThoat;
    }
}
