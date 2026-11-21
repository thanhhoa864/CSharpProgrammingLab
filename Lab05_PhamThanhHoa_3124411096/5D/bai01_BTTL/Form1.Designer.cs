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
            components = new System.ComponentModel.Container();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblGioiTinh = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            lblNgoaiNgu = new Label();
            chkAnh = new CheckBox();
            chkPhap = new CheckBox();
            chkHoa = new CheckBox();
            lblDanToc = new Label();
            cboDanToc = new ComboBox();
            lvSinhVien = new ListView();
            colHoTen = new ColumnHeader();
            colMaSV = new ColumnHeader();
            colGioiTinh = new ColumnHeader();
            colNgoaiNgu = new ColumnHeader();
            colDanToc = new ColumnHeader();
            contextMenuListView = new ContextMenuStrip(components);
            menuXoa = new ToolStripMenuItem();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            contextMenuListView.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(39, 24);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ và Tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(104, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(228, 23);
            txtHoTen.TabIndex = 1;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(24, 58);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(74, 15);
            lblMaSV.TabIndex = 2;
            lblMaSV.Text = "Mã sinh viên";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(104, 50);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(228, 23);
            txtMaSV.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(46, 92);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(52, 15);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(105, 92);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 5;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(162, 92);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 6;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // lblNgoaiNgu
            // 
            lblNgoaiNgu.AutoSize = true;
            lblNgoaiNgu.Location = new Point(76, 128);
            lblNgoaiNgu.Name = "lblNgoaiNgu";
            lblNgoaiNgu.Size = new Size(63, 15);
            lblNgoaiNgu.TabIndex = 7;
            lblNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // chkAnh
            // 
            chkAnh.AutoSize = true;
            chkAnh.Checked = true;
            chkAnh.CheckState = CheckState.Checked;
            chkAnh.Location = new Point(145, 127);
            chkAnh.Name = "chkAnh";
            chkAnh.Size = new Size(48, 19);
            chkAnh.TabIndex = 8;
            chkAnh.Text = "Anh";
            chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            chkPhap.AutoSize = true;
            chkPhap.Location = new Point(199, 127);
            chkPhap.Name = "chkPhap";
            chkPhap.Size = new Size(53, 19);
            chkPhap.TabIndex = 9;
            chkPhap.Text = "Pháp";
            chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkHoa
            // 
            chkHoa.AutoSize = true;
            chkHoa.Location = new Point(254, 127);
            chkHoa.Name = "chkHoa";
            chkHoa.Size = new Size(48, 19);
            chkHoa.TabIndex = 10;
            chkHoa.Text = "Hoa";
            chkHoa.UseVisualStyleBackColor = true;
            // 
            // lblDanToc
            // 
            lblDanToc.AutoSize = true;
            lblDanToc.Location = new Point(76, 161);
            lblDanToc.Name = "lblDanToc";
            lblDanToc.Size = new Size(48, 15);
            lblDanToc.TabIndex = 11;
            lblDanToc.Text = "Dân tộc";
            // 
            // cboDanToc
            // 
            cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanToc.FormattingEnabled = true;
            cboDanToc.Location = new Point(130, 158);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(228, 23);
            cboDanToc.TabIndex = 12;
            // 
            // lvSinhVien
            // 
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { colHoTen, colMaSV, colGioiTinh, colNgoaiNgu, colDanToc });
            lvSinhVien.ContextMenuStrip = contextMenuListView;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(8, 187);
            lvSinhVien.MultiSelect = false;
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(508, 146);
            lvSinhVien.TabIndex = 13;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.SelectedIndexChanged += lvSinhVien_SelectedIndexChanged;
            // 
            // colHoTen
            // 
            colHoTen.Text = "Họ tên";
            colHoTen.Width = 120;
            // 
            // colMaSV
            // 
            colMaSV.Text = "Mã sinh viên";
            colMaSV.Width = 100;
            // 
            // colGioiTinh
            // 
            colGioiTinh.Text = "Giới tính";
            colGioiTinh.Width = 80;
            // 
            // colNgoaiNgu
            // 
            colNgoaiNgu.Text = "Ngoại ngữ";
            colNgoaiNgu.Width = 130;
            // 
            // colDanToc
            // 
            colDanToc.Text = "Dân tộc";
            colDanToc.Width = 110;
            // 
            // contextMenuListView
            // 
            contextMenuListView.ImageScalingSize = new Size(20, 20);
            contextMenuListView.Items.AddRange(new ToolStripItem[] { menuXoa });
            contextMenuListView.Name = "contextMenuListView";
            contextMenuListView.Size = new Size(95, 26);
            // 
            // menuXoa
            // 
            menuXoa.Name = "menuXoa";
            menuXoa.Size = new Size(94, 22);
            menuXoa.Text = "Xóa";
            menuXoa.Click += menuXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(105, 366);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 34);
            btnThem.TabIndex = 14;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(219, 366);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 34);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "- Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(332, 366);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 34);
            btnSua.TabIndex = 16;
            btnSua.Text = "↻ Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 412);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(lvSinhVien);
            Controls.Add(cboDanToc);
            Controls.Add(lblDanToc);
            Controls.Add(chkHoa);
            Controls.Add(chkPhap);
            Controls.Add(chkAnh);
            Controls.Add(lblNgoaiNgu);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(lblGioiTinh);
            Controls.Add(txtMaSV);
            Controls.Add(lblMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài tập trên lớp";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            contextMenuListView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblNgoaiNgu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaSV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgoaiNgu;
        private System.Windows.Forms.ColumnHeader colDanToc;
        private System.Windows.Forms.ContextMenuStrip contextMenuListView;
        private System.Windows.Forms.ToolStripMenuItem menuXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}