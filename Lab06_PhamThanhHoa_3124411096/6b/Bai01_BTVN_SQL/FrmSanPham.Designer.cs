namespace Bai01_BTVN_SQL
{
    partial class FrmSanPham
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
            SuspendLayout();
            lbltxtTen = new Label();
            lbltxtTen.Text = "Tên sản phẩm";
            lbltxtTen.Location = new Point(25, 34);
            lbltxtTen.Size = new Size(140, 25);
            Controls.Add(lbltxtTen);
            txtTen = new TextBox();
            txtTen.Location = new Point(175, 30);
            txtTen.Size = new Size(300, 28);
            txtTen.Name = "txtTen";
            Controls.Add(txtTen);
            btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(25, 87);
            btnThem.Size = new Size(115, 34);
            btnThem.Click += Them_Click;
            Controls.Add(btnThem);
            btnThoat = new Button();
            btnThoat.Text = "Thoát";
            btnThoat.Location = new Point(150, 87);
            btnThoat.Size = new Size(115, 34);
            btnThoat.Click += Thoat_Click;
            Controls.Add(btnThoat);

            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(540, 180);
            Text = "Thêm sản phẩm mới";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lbltxtTen;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnThoat;
    }
}
