namespace Bai01_BTTL_SQL;
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
        lblcboLop = new Label();
        lblcboLop.Text = "Lớp";
        lblcboLop.Location = new Point(25, 34);
        lblcboLop.Size = new Size(140, 25);
        Controls.Add(lblcboLop);
        cboLop = new ComboBox();
        cboLop.Location = new Point(175, 30);
        cboLop.Size = new Size(300, 28);
        cboLop.Name = "cboLop";
        Controls.Add(cboLop);
        cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
        lbltxtMa = new Label();
        lbltxtMa.Text = "Mã sinh viên";
        lbltxtMa.Location = new Point(25, 79);
        lbltxtMa.Size = new Size(140, 25);
        Controls.Add(lbltxtMa);
        txtMa = new TextBox();
        txtMa.Location = new Point(175, 75);
        txtMa.Size = new Size(300, 28);
        txtMa.Name = "txtMa";
        Controls.Add(txtMa);
        lbltxtTen = new Label();
        lbltxtTen.Text = "Họ tên";
        lbltxtTen.Location = new Point(25, 124);
        lbltxtTen.Size = new Size(140, 25);
        Controls.Add(lbltxtTen);
        txtTen = new TextBox();
        txtTen.Location = new Point(175, 120);
        txtTen.Size = new Size(300, 28);
        txtTen.Name = "txtTen";
        Controls.Add(txtTen);
        lbltxtNgay = new Label();
        lbltxtNgay.Text = "Ngày sinh";
        lbltxtNgay.Location = new Point(25, 169);
        lbltxtNgay.Size = new Size(140, 25);
        Controls.Add(lbltxtNgay);
        txtNgay = new MaskedTextBox();
        txtNgay.Location = new Point(175, 165);
        txtNgay.Size = new Size(300, 28);
        txtNgay.Name = "txtNgay";
        Controls.Add(txtNgay);
        txtNgay.Mask = "00/00/0000";
        btnThem = new Button();
        btnThem.Text = "Thêm";
        btnThem.Location = new Point(25, 222);
        btnThem.Size = new Size(115, 34);
        btnThem.Click += Them_Click;
        Controls.Add(btnThem);
        btnXoa = new Button();
        btnXoa.Text = "Xóa";
        btnXoa.Location = new Point(150, 222);
        btnXoa.Size = new Size(115, 34);
        btnXoa.Click += Xoa_Click;
        Controls.Add(btnXoa);
        btnSua = new Button();
        btnSua.Text = "Sửa";
        btnSua.Location = new Point(275, 222);
        btnSua.Size = new Size(115, 34);
        btnSua.Click += Sua_Click;
        Controls.Add(btnSua);
        
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 10F);
        ClientSize = new Size(560, 330);
        Text = "Quản lý sinh viên";
        StartPosition = FormStartPosition.CenterScreen;
        Load += Form_Load;
        ResumeLayout(false);
        PerformLayout();
    }
    private Label lblcboLop;
        private ComboBox cboLop;
        private Label lbltxtMa;
        private TextBox txtMa;
        private Label lbltxtTen;
        private TextBox txtTen;
        private Label lbltxtNgay;
        private MaskedTextBox txtNgay;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
}
