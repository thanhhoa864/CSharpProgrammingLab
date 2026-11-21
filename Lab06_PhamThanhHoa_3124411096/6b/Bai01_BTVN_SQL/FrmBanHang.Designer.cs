namespace Bai01_BTVN_SQL
{
    partial class FrmBanHang
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
            lbltxtHD = new Label();
            lbltxtHD.Text = "Mã hóa đơn";
            lbltxtHD.Location = new Point(25, 34);
            lbltxtHD.Size = new Size(140, 25);
            Controls.Add(lbltxtHD);
            txtHD = new TextBox();
            txtHD.Location = new Point(175, 30);
            txtHD.Size = new Size(300, 28);
            txtHD.Name = "txtHD";
            Controls.Add(txtHD);
            lblcboSP = new Label();
            lblcboSP.Text = "Mã sản phẩm";
            lblcboSP.Location = new Point(25, 79);
            lblcboSP.Size = new Size(140, 25);
            Controls.Add(lblcboSP);
            cboSP = new ComboBox();
            cboSP.Location = new Point(175, 75);
            cboSP.Size = new Size(300, 28);
            cboSP.Name = "cboSP";
            Controls.Add(cboSP);
            cboSP.DropDownStyle = ComboBoxStyle.DropDownList;
            lbltxtSL = new Label();
            lbltxtSL.Text = "Số lượng";
            lbltxtSL.Location = new Point(25, 124);
            lbltxtSL.Size = new Size(140, 25);
            Controls.Add(lbltxtSL);
            txtSL = new TextBox();
            txtSL.Location = new Point(175, 120);
            txtSL.Size = new Size(300, 28);
            txtSL.Name = "txtSL";
            Controls.Add(txtSL);
            btnMoi = new Button();
            btnMoi.Text = "Tạo hóa đơn";
            btnMoi.Location = new Point(25, 177);
            btnMoi.Size = new Size(115, 34);
            btnMoi.Click += Moi_Click;
            Controls.Add(btnMoi);
            btnThem = new Button();
            btnThem.Text = "Thêm";
            btnThem.Location = new Point(150, 177);
            btnThem.Size = new Size(115, 34);
            btnThem.Click += Them_Click;
            Controls.Add(btnThem);
            btnHuy = new Button();
            btnHuy.Text = "Hủy";
            btnHuy.Location = new Point(275, 177);
            btnHuy.Size = new Size(115, 34);
            btnHuy.Click += Huy_Click;
            Controls.Add(btnHuy);
            btnThanhToan = new Button();
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.Location = new Point(400, 177);
            btnThanhToan.Size = new Size(115, 34);
            btnThanhToan.Click += ThanhToan_Click;
            Controls.Add(btnThanhToan);
            txtHD.ReadOnly = true;
            FormClosing += DongForm;
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(570, 300);
            Text = "Bán hàng";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lbltxtHD;
        private TextBox txtHD;
        private Label lblcboSP;
        private ComboBox cboSP;
        private Label lbltxtSL;
        private TextBox txtSL;
        private Button btnMoi;
        private Button btnThem;
        private Button btnHuy;
        private Button btnThanhToan;
    }
}
