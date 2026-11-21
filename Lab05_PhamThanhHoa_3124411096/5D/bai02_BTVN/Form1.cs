using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace bai02_BTVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mở form được chọn, ẩn các form con khác
        private void MoFormCon<T>() where T : Form, new()
        {
            T formCanMo = null;

            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                    formCanMo = (T)form;
                else
                    form.Hide();
            }

            if (formCanMo == null)
            {
                formCanMo = new T();
                formCanMo.MdiParent = this;
                formCanMo.Show();
            }
            else
            {
                formCanMo.Show();
                formCanMo.Activate();
            }
        }

        private void mnuBai01_BTTL_Click(object sender, EventArgs e)
        {
            MoFormCon<frmBaitap1>();
        }

        private void mnuBai02_BTTL_Click(object sender, EventArgs e)
        {
            MoFormCon<frmBai02_BTTL>();
        }

        private void mnuBai01_BTNC_Click(object sender, EventArgs e)
        {
            MoFormCon<frmBai01_BTNC>();
        }

        private void mnuBai01_BTVN_Click(object sender, EventArgs e)
        {
            MoFormCon<frmBaitap2>();
        }

        private void mnuBai02_BTVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Form chính dùng để quản lý các bài tập.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

    // BÀI 1: Quản lý sinh viên
    public class frmBaitap1 : Form
    {
        private Label lblHoTen, lblMaSV, lblGioiTinh, lblNgoaiNgu, lblDanToc;
        private TextBox txtHoTen, txtMaSV;
        private RadioButton rdoNam, rdoNu;
        private CheckBox chkAnh, chkPhap, chkHoa;
        private ComboBox cboDanToc;
        private ListView lvSinhVien;
        private Button btnThem, btnSua, btnXoa, btnThoat;

        public frmBaitap1()
        {
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            Text = "Quản lý sinh viên";
            Size = new Size(520, 520);
            StartPosition = FormStartPosition.CenterScreen;

            lblHoTen = new Label()
            {
                Text = "Họ và tên",
                Location = new Point(30, 20),
                AutoSize = true
            };
            txtHoTen = new TextBox()
            {
                Location = new Point(150, 17),
                Width = 260
            };

            lblMaSV = new Label()
            {
                Text = "Mã sinh viên",
                Location = new Point(30, 60),
                AutoSize = true
            };
            txtMaSV = new TextBox()
            {
                Location = new Point(150, 57),
                Width = 260
            };

            lblGioiTinh = new Label()
            {
                Text = "Giới tính",
                Location = new Point(30, 100),
                AutoSize = true
            };
            rdoNam = new RadioButton()
            {
                Text = "Nam",
                Location = new Point(150, 98),
                Checked = true,
                AutoSize = true
            };
            rdoNu = new RadioButton()
            {
                Text = "Nữ",
                Location = new Point(230, 98),
                AutoSize = true
            };

            lblNgoaiNgu = new Label()
            {
                Text = "Ngoại ngữ",
                Location = new Point(30, 140),
                AutoSize = true
            };
            chkAnh = new CheckBox()
            {
                Text = "Anh",
                Location = new Point(150, 138),
                Checked = true,
                AutoSize = true
            };
            chkPhap = new CheckBox()
            {
                Text = "Pháp",
                Location = new Point(230, 138),
                AutoSize = true
            };
            chkHoa = new CheckBox()
            {
                Text = "Hoa",
                Location = new Point(310, 138),
                AutoSize = true
            };

            lblDanToc = new Label()
            {
                Text = "Dân tộc",
                Location = new Point(30, 180),
                AutoSize = true
            };
            cboDanToc = new ComboBox()
            {
                Location = new Point(150, 177),
                Width = 260,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboDanToc.Items.AddRange(new object[]
            {
                "Kinh", "Tày", "Nùng", "Mường", "Khơ-me", "H'Mông"
            });
            cboDanToc.SelectedIndex = 0;

            btnThem = new Button()
            {
                Text = "Thêm",
                Location = new Point(30, 215),
                Size = new Size(80, 30)
            };
            btnSua = new Button()
            {
                Text = "Sửa",
                Location = new Point(125, 215),
                Size = new Size(80, 30)
            };
            btnXoa = new Button()
            {
                Text = "Xóa",
                Location = new Point(220, 215),
                Size = new Size(80, 30)
            };
            btnThoat = new Button()
            {
                Text = "Thoát",
                Location = new Point(315, 215),
                Size = new Size(80, 30)
            };

            lvSinhVien = new ListView()
            {
                Location = new Point(20, 260),
                Size = new Size(465, 190),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                MultiSelect = false
            };

            lvSinhVien.Columns.Add("Họ tên", 110);
            lvSinhVien.Columns.Add("Mã sinh viên", 90);
            lvSinhVien.Columns.Add("Giới tính", 70);
            lvSinhVien.Columns.Add("Ngoại ngữ", 100);
            lvSinhVien.Columns.Add("Dân tộc", 80);

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += (s, e) => Close();
            lvSinhVien.SelectedIndexChanged += LvSinhVien_SelectedIndexChanged;

            Controls.AddRange(new Control[]
            {
                lblHoTen, txtHoTen, lblMaSV, txtMaSV,
                lblGioiTinh, rdoNam, rdoNu,
                lblNgoaiNgu, chkAnh, chkPhap, chkHoa,
                lblDanToc, cboDanToc,
                btnThem, btnSua, btnXoa, btnThoat, lvSinhVien
            });
        }

        // Lấy các ngoại ngữ được chọn
        private string GetNgoaiNgu()
        {
            List<string> danhSach = new List<string>();

            if (chkAnh.Checked) danhSach.Add("Anh");
            if (chkPhap.Checked) danhSach.Add("Pháp");
            if (chkHoa.Checked) danhSach.Add("Hoa");

            return string.Join(", ", danhSach);
        }

        // Xóa dữ liệu sau khi xử lý xong
        private void XoaTrang()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();

            rdoNam.Checked = true;
            chkAnh.Checked = true;
            chkPhap.Checked = false;
            chkHoa.Checked = false;
            cboDanToc.SelectedIndex = 0;

            lvSinhVien.SelectedItems.Clear();
            txtHoTen.Focus();
        }

        // Kiểm tra thông tin bắt buộc
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên và mã sinh viên!");
                return false;
            }

            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin())
                return;

            // Không cho phép trùng mã sinh viên
            foreach (ListViewItem sv in lvSinhVien.Items)
            {
                if (sv.SubItems[1].Text.Equals(
                    txtMaSV.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }
            }

            ListViewItem item = new ListViewItem(txtHoTen.Text.Trim());
            item.SubItems.Add(txtMaSV.Text.Trim());
            item.SubItems.Add(rdoNam.Checked ? "Nam" : "Nữ");
            item.SubItems.Add(GetNgoaiNgu());
            item.SubItems.Add(cboDanToc.SelectedItem.ToString());

            lvSinhVien.Items.Add(item);
            XoaTrang();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            if (!KiemTraThongTin())
                return;

            ListViewItem item = lvSinhVien.SelectedItems[0];

            // Kiểm tra mã có trùng với sinh viên khác không
            foreach (ListViewItem sv in lvSinhVien.Items)
            {
                if (sv != item &&
                    sv.SubItems[1].Text.Equals(
                        txtMaSV.Text.Trim(),
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }
            }

            item.SubItems[0].Text = txtHoTen.Text.Trim();
            item.SubItems[1].Text = txtMaSV.Text.Trim();
            item.SubItems[2].Text = rdoNam.Checked ? "Nam" : "Nữ";
            item.SubItems[3].Text = GetNgoaiNgu();
            item.SubItems[4].Text = cboDanToc.SelectedItem.ToString();

            MessageBox.Show("Sửa thông tin thành công!");
            XoaTrang();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(lvSinhVien.SelectedItems[0]);
                XoaTrang();
            }
        }

        private void LvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvSinhVien.SelectedItems[0];

            txtHoTen.Text = item.SubItems[0].Text;
            txtMaSV.Text = item.SubItems[1].Text;
            rdoNam.Checked = item.SubItems[2].Text == "Nam";
            rdoNu.Checked = item.SubItems[2].Text == "Nữ";

            string ngoaiNgu = item.SubItems[3].Text;
            chkAnh.Checked = ngoaiNgu.Contains("Anh");
            chkPhap.Checked = ngoaiNgu.Contains("Pháp");
            chkHoa.Checked = ngoaiNgu.Contains("Hoa");

            cboDanToc.SelectedItem = item.SubItems[4].Text;
        }
    }

    // BÀI 2: Quản lý tài khoản ngân hàng
    public class frmBai02_BTTL : Form
    {
        private Label lblTitle, lblSoTK, lblTenKH, lblDiaChi, lblSoTien, lblTongTien;
        private TextBox txtSoTK, txtTenKH, txtDiaChi, txtSoTien, txtTongTien;
        private Button btnThem, btnLuu, btnXoa, btnThoat;
        private ListView lvTaiKhoan;

        public frmBai02_BTTL()
        {
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            Text = "Quản lý tài khoản ngân hàng";
            Size = new Size(745, 520);
            StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label()
            {
                Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(145, 18),
                AutoSize = true
            };

            lblSoTK = new Label()
            {
                Text = "Số tài khoản",
                Location = new Point(230, 72),
                AutoSize = true
            };
            txtSoTK = new TextBox()
            {
                Location = new Point(325, 69),
                Width = 330,
                ReadOnly = true
            };

            lblTenKH = new Label()
            {
                Text = "Tên khách hàng",
                Location = new Point(208, 108),
                AutoSize = true
            };
            txtTenKH = new TextBox()
            {
                Location = new Point(325, 105),
                Width = 330,
                ReadOnly = true
            };

            lblDiaChi = new Label()
            {
                Text = "Địa chỉ khách hàng",
                Location = new Point(196, 144),
                AutoSize = true
            };
            txtDiaChi = new TextBox()
            {
                Location = new Point(325, 141),
                Width = 330,
                ReadOnly = true
            };

            lblSoTien = new Label()
            {
                Text = "Số tiền trong tài khoản",
                Location = new Point(177, 180),
                AutoSize = true
            };
            txtSoTien = new TextBox()
            {
                Location = new Point(325, 177),
                Width = 330,
                TextAlign = HorizontalAlignment.Right,
                ReadOnly = true
            };

            btnThem = new Button()
            {
                Text = "Thêm",
                Location = new Point(325, 215),
                Size = new Size(75, 30)
            };
            btnLuu = new Button()
            {
                Text = "Lưu",
                Location = new Point(410, 215),
                Size = new Size(75, 30),
                Enabled = false
            };
            btnXoa = new Button()
            {
                Text = "Xóa",
                Location = new Point(495, 215),
                Size = new Size(75, 30),
                Enabled = false
            };
            btnThoat = new Button()
            {
                Text = "Thoát",
                Location = new Point(580, 215),
                Size = new Size(75, 30)
            };

            lvTaiKhoan = new ListView()
            {
                Location = new Point(25, 260),
                Size = new Size(695, 175),
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                MultiSelect = false
            };

            lvTaiKhoan.Columns.Add("STT", 50);
            lvTaiKhoan.Columns.Add("Số tài khoản", 130);
            lvTaiKhoan.Columns.Add("Tên khách hàng", 180);
            lvTaiKhoan.Columns.Add("Địa chỉ", 170);
            lvTaiKhoan.Columns.Add("Số tiền", 140, HorizontalAlignment.Right);

            lblTongTien = new Label()
            {
                Text = "Tổng tiền",
                Location = new Point(435, 452),
                AutoSize = true
            };
            txtTongTien = new TextBox()
            {
                Location = new Point(510, 450),
                Width = 210,
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Right,
                Text = "0"
            };

            btnThem.Click += BtnThem_Click;
            btnLuu.Click += BtnLuu_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += (s, e) => Close();
            lvTaiKhoan.SelectedIndexChanged += LvTaiKhoan_SelectedIndexChanged;

            Controls.AddRange(new Control[]
            {
                lblTitle, lblSoTK, txtSoTK,
                lblTenKH, txtTenKH,
                lblDiaChi, txtDiaChi,
                lblSoTien, txtSoTien,
                btnThem, btnLuu, btnXoa, btnThoat,
                lvTaiKhoan, lblTongTien, txtTongTien
            });
        }

        private void KhoaControls(bool khoa)
        {
            txtSoTK.ReadOnly = khoa;
            txtTenKH.ReadOnly = khoa;
            txtDiaChi.ReadOnly = khoa;
            txtSoTien.ReadOnly = khoa;
        }

        private void XoaTrang()
        {
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Cập nhật số thứ tự và tổng số tiền
        private void CapNhatDanhSach()
        {
            long tongTien = 0;

            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                ListViewItem item = lvTaiKhoan.Items[i];
                item.SubItems[0].Text = (i + 1).ToString();

                string soTien = item.SubItems[4].Text
                    .Replace(",", "")
                    .Replace(".", "")
                    .Trim();

                if (long.TryParse(soTien, out long tien))
                    tongTien += tien;
            }

            txtTongTien.Text = tongTien.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                lvTaiKhoan.SelectedItems.Clear();
                XoaTrang();
                KhoaControls(false);
                txtSoTK.Focus();
            }
            else
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;

                XoaTrang();
                KhoaControls(true);
                btnXoa.Enabled = lvTaiKhoan.SelectedItems.Count > 0;
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTK.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Số tiền phải là số nguyên không âm
            if (!long.TryParse(txtSoTien.Text.Trim(), out long soTien) ||
                soTien < 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }

            // Kiểm tra số tài khoản đã có trong danh sách chưa
            foreach (ListViewItem tk in lvTaiKhoan.Items)
            {
                if (tk.SubItems[1].Text.Equals(
                    txtSoTK.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Số tài khoản đã tồn tại!");
                    return;
                }
            }

            ListViewItem item = new ListViewItem("");
            item.SubItems.Add(txtSoTK.Text.Trim());
            item.SubItems.Add(txtTenKH.Text.Trim());
            item.SubItems.Add(txtDiaChi.Text.Trim());
            item.SubItems.Add(soTien.ToString("N0", CultureInfo.InvariantCulture));

            lvTaiKhoan.Items.Add(item);
            CapNhatDanhSach();

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            KhoaControls(true);
            XoaTrang();
        }

        private void LvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                if (btnThem.Text == "Thêm")
                    btnXoa.Enabled = false;

                return;
            }

            ListViewItem item = lvTaiKhoan.SelectedItems[0];

            txtSoTK.Text = item.SubItems[1].Text;
            txtTenKH.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text
                .Replace(",", "")
                .Replace(".", "")
                .Trim();

            KhoaControls(true);

            if (btnThem.Text == "Thêm")
                btnXoa.Enabled = true;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            lvTaiKhoan.Items.Remove(lvTaiKhoan.SelectedItems[0]);

            CapNhatDanhSach();
            XoaTrang();
            btnXoa.Enabled = false;
        }
    }

    // BÀI 3: Quản lý học viên và chuyển lớp
    public class frmBai01_BTNC : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCapNhat, mnuNhapMoi;
        private ToolStripMenuItem mnuChuyenB, mnuChuyenA, mnuXoa, mnuKetThuc;
        private GroupBox grpLopA, grpLopB;
        private ListBox lstLopA, lstLopB;

        public frmBai01_BTNC()
        {
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            Text = "Quản lý học viên";
            Size = new Size(564, 340);
            StartPosition = FormStartPosition.CenterScreen;

            menuStrip1 = new MenuStrip()
            {
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            mnuCapNhat = new ToolStripMenuItem("Cập nhật");
            mnuKetThuc = new ToolStripMenuItem("Kết thúc");
            mnuNhapMoi = new ToolStripMenuItem("Nhập học viên mới");
            mnuChuyenB = new ToolStripMenuItem("Chuyển sang lớp B");
            mnuChuyenA = new ToolStripMenuItem("Chuyển sang lớp A");
            mnuXoa = new ToolStripMenuItem("Xóa học viên");

            mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[]
            {
                mnuNhapMoi, mnuChuyenB, mnuChuyenA, mnuXoa
            });

            menuStrip1.Items.AddRange(new ToolStripItem[]
            {
                mnuCapNhat, mnuKetThuc
            });

            grpLopA = new GroupBox()
            {
                Text = "Lớp A",
                Location = new Point(30, 40),
                Size = new Size(235, 240)
            };

            lstLopA = new ListBox()
            {
                Dock = DockStyle.Fill,
                SelectionMode = SelectionMode.MultiExtended
            };
            lstLopA.Items.AddRange(new object[]
            {
                "Trần Hùng", "Nguyễn Hưng", "Lâm Tứ"
            });
            grpLopA.Controls.Add(lstLopA);

            grpLopB = new GroupBox()
            {
                Text = "Lớp B",
                Location = new Point(295, 40),
                Size = new Size(235, 240)
            };

            lstLopB = new ListBox()
            {
                Dock = DockStyle.Fill,
                SelectionMode = SelectionMode.MultiExtended
            };
            lstLopB.Items.AddRange(new object[]
            {
                "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm"
            });
            grpLopB.Controls.Add(lstLopB);

            mnuChuyenB.Click += (s, e) =>
                ChuyenLop(lstLopA, lstLopB, "Lớp A");

            mnuChuyenA.Click += (s, e) =>
                ChuyenLop(lstLopB, lstLopA, "Lớp B");

            mnuXoa.Click += MnuXoa_Click;
            mnuNhapMoi.Click += MnuNhapMoi_Click;
            mnuKetThuc.Click += (s, e) => Close();

            MainMenuStrip = menuStrip1;

            Controls.AddRange(new Control[]
            {
                menuStrip1, grpLopA, grpLopB
            });
        }

        // Chuyển các học viên đang chọn từ lớp nguồn sang lớp đích
        private void ChuyenLop(ListBox nguon, ListBox dich, string tenLop)
        {
            if (nguon.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên ở " + tenLop + "!");
                return;
            }

            List<object> danhSach = new List<object>();

            foreach (object hocVien in nguon.SelectedItems)
                danhSach.Add(hocVien);

            foreach (object hocVien in danhSach)
            {
                dich.Items.Add(hocVien);
                nguon.Items.Remove(hocVien);
            }
        }

        private void MnuXoa_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedIndices.Count == 0 &&
                lstLopB.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa!");
                return;
            }

            // Xóa từ chỉ số lớn về nhỏ để không bị lệch vị trí
            for (int i = lstLopA.SelectedIndices.Count - 1; i >= 0; i--)
                lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[i]);

            for (int i = lstLopB.SelectedIndices.Count - 1; i >= 0; i--)
                lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[i]);
        }

        private void MnuNhapMoi_Click(object sender, EventArgs e)
        {
            Form formNhap = new Form()
            {
                Text = "Nhập học viên mới",
                Size = new Size(360, 180),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog
            };

            Label lblTen = new Label()
            {
                Text = "Họ và tên",
                Location = new Point(20, 20),
                AutoSize = true
            };

            TextBox txtTen = new TextBox()
            {
                Location = new Point(100, 17),
                Width = 220
            };

            Label lblLop = new Label()
            {
                Text = "Lớp",
                Location = new Point(20, 60),
                AutoSize = true
            };

            ComboBox cboLop = new ComboBox()
            {
                Location = new Point(100, 57),
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            cboLop.SelectedIndex = 0;

            Button btnCapNhat = new Button()
            {
                Text = "Cập nhật",
                Location = new Point(100, 100),
                Size = new Size(90, 30)
            };

            btnCapNhat.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên học viên!");
                    txtTen.Focus();
                    return;
                }

                if (cboLop.SelectedItem.ToString() == "Lớp A")
                    lstLopA.Items.Add(txtTen.Text.Trim());
                else
                    lstLopB.Items.Add(txtTen.Text.Trim());

                txtTen.Clear();
                txtTen.Focus();
            };

            formNhap.Controls.AddRange(new Control[]
            {
                lblTen, txtTen, lblLop, cboLop, btnCapNhat
            });

            formNhap.ShowDialog(this);
        }
    }

    // BÀI 4: Đồng hồ đếm ngược 30 phút
    public class frmBaitap2 : Form
    {
        private Label lblDongHo;
        private Button btnBatDau;
        private Timer timer;
        private int tongSoGiay = 30 * 60;

        public frmBaitap2()
        {
            TaoGiaoDien();
        }

        private void TaoGiaoDien()
        {
            Text = "Đồng hồ đếm ngược";
            Size = new Size(300, 180);
            StartPosition = FormStartPosition.CenterScreen;

            lblDongHo = new Label()
            {
                Text = "30:00",
                Font = new Font("Consolas", 20, FontStyle.Bold),
                Location = new Point(50, 20),
                Size = new Size(180, 40),
                TextAlign = ContentAlignment.MiddleCenter
            };

            btnBatDau = new Button()
            {
                Text = "Bắt đầu",
                Location = new Point(90, 75),
                Size = new Size(100, 35)
            };
            btnBatDau.Click += BtnBatDau_Click;

            timer = new Timer()
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;

            Controls.AddRange(new Control[]
            {
                lblDongHo, btnBatDau
            });
        }

        private void BtnBatDau_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                // Nếu hết giờ thì bắt đầu lại từ 30 phút
                if (tongSoGiay <= 0)
                {
                    tongSoGiay = 30 * 60;
                    lblDongHo.Text = "30:00";
                }

                timer.Start();
                btnBatDau.Text = "Tạm dừng";
            }
            else
            {
                timer.Stop();
                btnBatDau.Text = "Tiếp tục";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tongSoGiay > 0)
            {
                tongSoGiay--;

                int phut = tongSoGiay / 60;
                int giay = tongSoGiay % 60;

                lblDongHo.Text = $"{phut:D2}:{giay:D2}";
            }

            if (tongSoGiay == 0)
            {
                timer.Stop();
                btnBatDau.Text = "Bắt đầu";

                MessageBox.Show(
                    "Hết giờ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}