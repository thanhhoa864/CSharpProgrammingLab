namespace Bai01_BTM_SQL;
partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }
    private void InitializeComponent()
    {
        SuspendLayout();
        lbltxtMa = new Label();
        lbltxtMa.Text = "Mã khoa";
        lbltxtMa.Location = new Point(25, 34);
        lbltxtMa.Size = new Size(140, 25);
        Controls.Add(lbltxtMa);
        txtMa = new TextBox();
        txtMa.Location = new Point(175, 30);
        txtMa.Size = new Size(300, 28);
        txtMa.Name = "txtMa";
        Controls.Add(txtMa);
        lbltxtTen = new Label();
        lbltxtTen.Text = "Tên khoa";
        lbltxtTen.Location = new Point(25, 79);
        lbltxtTen.Size = new Size(140, 25);
        Controls.Add(lbltxtTen);
        txtTen = new TextBox();
        txtTen.Location = new Point(175, 75);
        txtTen.Size = new Size(300, 28);
        txtTen.Name = "txtTen";
        Controls.Add(txtTen);
        btnThem = new Button();
        btnThem.Text = "Thêm";
        btnThem.Location = new Point(25, 132);
        btnThem.Size = new Size(115, 34);
        btnThem.Click += Them_Click;
        Controls.Add(btnThem);
        btnXoa = new Button();
        btnXoa.Text = "Xóa";
        btnXoa.Location = new Point(150, 132);
        btnXoa.Size = new Size(115, 34);
        btnXoa.Click += Xoa_Click;
        Controls.Add(btnXoa);
        btnSua = new Button();
        btnSua.Text = "Sửa";
        btnSua.Location = new Point(275, 132);
        btnSua.Size = new Size(115, 34);
        btnSua.Click += Sua_Click;
        Controls.Add(btnSua);
        
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 10F);
        ClientSize = new Size(560, 330);
        Text = "Quản lý khoa";
        StartPosition = FormStartPosition.CenterScreen;
        Load += Form_Load;
        ResumeLayout(false);
        PerformLayout();
    }
    private Label lbltxtMa;
        private TextBox txtMa;
        private Label lbltxtTen;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
}
