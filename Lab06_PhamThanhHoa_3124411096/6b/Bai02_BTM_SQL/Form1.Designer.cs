namespace Bai02_BTM_SQL;
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
        lblcboKhoa = new Label();
        lblcboKhoa.Text = "Khoa";
        lblcboKhoa.Location = new Point(25, 34);
        lblcboKhoa.Size = new Size(140, 25);
        Controls.Add(lblcboKhoa);
        cboKhoa = new ComboBox();
        cboKhoa.Location = new Point(175, 30);
        cboKhoa.Size = new Size(300, 28);
        cboKhoa.Name = "cboKhoa";
        Controls.Add(cboKhoa);
        cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        lbltxtMa = new Label();
        lbltxtMa.Text = "Mã lớp";
        lbltxtMa.Location = new Point(25, 79);
        lbltxtMa.Size = new Size(140, 25);
        Controls.Add(lbltxtMa);
        txtMa = new TextBox();
        txtMa.Location = new Point(175, 75);
        txtMa.Size = new Size(300, 28);
        txtMa.Name = "txtMa";
        Controls.Add(txtMa);
        lbltxtTen = new Label();
        lbltxtTen.Text = "Tên lớp";
        lbltxtTen.Location = new Point(25, 124);
        lbltxtTen.Size = new Size(140, 25);
        Controls.Add(lbltxtTen);
        txtTen = new TextBox();
        txtTen.Location = new Point(175, 120);
        txtTen.Size = new Size(300, 28);
        txtTen.Name = "txtTen";
        Controls.Add(txtTen);
        btnThem = new Button();
        btnThem.Text = "Thêm";
        btnThem.Location = new Point(25, 177);
        btnThem.Size = new Size(115, 34);
        btnThem.Click += Them_Click;
        Controls.Add(btnThem);
        btnXoa = new Button();
        btnXoa.Text = "Xóa";
        btnXoa.Location = new Point(150, 177);
        btnXoa.Size = new Size(115, 34);
        btnXoa.Click += Xoa_Click;
        Controls.Add(btnXoa);
        btnSua = new Button();
        btnSua.Text = "Sửa";
        btnSua.Location = new Point(275, 177);
        btnSua.Size = new Size(115, 34);
        btnSua.Click += Sua_Click;
        Controls.Add(btnSua);
        
        AutoScaleMode = AutoScaleMode.Font;
        Font = new Font("Segoe UI", 10F);
        ClientSize = new Size(560, 330);
        Text = "Quản lý lớp";
        StartPosition = FormStartPosition.CenterScreen;
        Load += Form_Load;
        ResumeLayout(false);
        PerformLayout();
    }
    private Label lblcboKhoa;
        private ComboBox cboKhoa;
        private Label lbltxtMa;
        private TextBox txtMa;
        private Label lbltxtTen;
        private TextBox txtTen;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
}
