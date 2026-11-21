namespace Bai02_BTNC_SQL
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
            lblcboMH = new Label();
            lblcboMH.Text = "Môn học";
            lblcboMH.Location = new Point(25, 34);
            lblcboMH.Size = new Size(140, 25);
            Controls.Add(lblcboMH);
            cboMH = new ComboBox();
            cboMH.Location = new Point(175, 30);
            cboMH.Size = new Size(300, 28);
            cboMH.Name = "cboMH";
            Controls.Add(cboMH);
            cboMH.DropDownStyle = ComboBoxStyle.DropDownList;
            lvDiem = new ListView();
            lvDiem.Location = new Point(25, 75);
            lvDiem.Size = new Size(750, 260);
            lvDiem.View = View.Details;
            lvDiem.FullRowSelect = true;
            lvDiem.GridLines = true;
            Controls.Add(lvDiem);
            lbltxtTong = new Label();
            lbltxtTong.Text = "Tổng điểm";
            lbltxtTong.Location = new Point(25, 359);
            lbltxtTong.Size = new Size(140, 25);
            Controls.Add(lbltxtTong);
            txtTong = new TextBox();
            txtTong.Location = new Point(175, 355);
            txtTong.Size = new Size(300, 28);
            txtTong.Name = "txtTong";
            Controls.Add(txtTong);
            btnLoc = new Button();
            btnLoc.Text = "Lọc dữ liệu";
            btnLoc.Location = new Point(25, 412);
            btnLoc.Size = new Size(115, 34);
            btnLoc.Click += Loc_Click;
            Controls.Add(btnLoc);
            txtTong.ReadOnly = true;
            lvDiem.Columns.Add("STT", 50);
            lvDiem.Columns.Add("Tên sinh viên", 220);
            lvDiem.Columns.Add("Ngày sinh", 120);
            lvDiem.Columns.Add("Tên môn học", 230);
            lvDiem.Columns.Add("Điểm", 80);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(800, 480);
            Text = "Danh sách điểm theo môn học";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblcboMH;
        private ComboBox cboMH;
        private ListView lvDiem;
        private Label lbltxtTong;
        private TextBox txtTong;
        private Button btnLoc;
    }
}
