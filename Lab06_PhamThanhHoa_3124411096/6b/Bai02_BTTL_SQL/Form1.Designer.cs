namespace Bai02_BTTL_SQL
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
            SuspendLayout();
            lblcboSV = new Label();
            lblcboSV.Text = "Sinh viên";
            lblcboSV.Location = new Point(25, 34);
            lblcboSV.Size = new Size(140, 25);
            Controls.Add(lblcboSV);
            cboSV = new ComboBox();
            cboSV.Location = new Point(175, 30);
            cboSV.Size = new Size(300, 28);
            cboSV.Name = "cboSV";
            Controls.Add(cboSV);
            cboSV.DropDownStyle = ComboBoxStyle.DropDownList;
            lblcboMH = new Label();
            lblcboMH.Text = "Môn học";
            lblcboMH.Location = new Point(25, 79);
            lblcboMH.Size = new Size(140, 25);
            Controls.Add(lblcboMH);
            cboMH = new ComboBox();
            cboMH.Location = new Point(175, 75);
            cboMH.Size = new Size(300, 28);
            cboMH.Name = "cboMH";
            Controls.Add(cboMH);
            cboMH.DropDownStyle = ComboBoxStyle.DropDownList;
            lbltxtDiem = new Label();
            lbltxtDiem.Text = "Điểm";
            lbltxtDiem.Location = new Point(25, 124);
            lbltxtDiem.Size = new Size(140, 25);
            Controls.Add(lbltxtDiem);
            txtDiem = new TextBox();
            txtDiem.Location = new Point(175, 120);
            txtDiem.Size = new Size(300, 28);
            txtDiem.Name = "txtDiem";
            Controls.Add(txtDiem);
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
            Text = "Quản lý điểm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblcboSV;
        private ComboBox cboSV;
        private Label lblcboMH;
        private ComboBox cboMH;
        private Label lbltxtDiem;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
