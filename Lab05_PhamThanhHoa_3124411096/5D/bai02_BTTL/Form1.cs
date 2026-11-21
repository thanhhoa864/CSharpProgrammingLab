
using System;
using System.Globalization;
using System.Windows.Forms;

namespace bai02_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Thiết lập giao diện khi mở chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            txtTongTien.Text = "0";

            KhoaNhapLieu(true);
        }

        // Chỉ cho nhập thông tin khi cần thêm tài khoản
        private void KhoaNhapLieu(bool khoa)
        {
            txtSoTK.ReadOnly = khoa;
            txtTenKH.ReadOnly = khoa;
            txtDiaChi.ReadOnly = khoa;
            txtSoTien.ReadOnly = khoa;
        }

        // Xóa thông tin cũ để nhập tài khoản khác
        private void XoaThongTin()
        {
            txtSoTK.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoTien.Clear();
        }

        // Tính lại tổng tiền và đánh lại số thứ tự
        private void CapNhatDanhSach()
        {
            long tongTien = 0;

            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                ListViewItem item = lvTaiKhoan.Items[i];

                item.SubItems[0].Text = (i + 1).ToString();

                string soTien = item.SubItems[4].Text;
                soTien = soTien.Replace(",", "").Replace(".", "");

                if (long.TryParse(soTien, out long tien))
                {
                    tongTien += tien;
                }
            }

            txtTongTien.Text = tongTien.ToString("N0",
                CultureInfo.InvariantCulture);
        }

        // Không cho thêm hai tài khoản có cùng số tài khoản
        private bool TrungSoTaiKhoan(string soTK)
        {
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == soTK)
                {
                    return true;
                }
            }

            return false;
        }

        // Bấm Thêm để nhập mới, bấm Hủy để dừng nhập
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                lvTaiKhoan.SelectedItems.Clear();
                XoaThongTin();
                KhoaNhapLieu(false);

                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;

                txtSoTK.Focus();
            }
            else
            {
                XoaThongTin();
                KhoaNhapLieu(true);

                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnXoa.Enabled =
                    lvTaiKhoan.SelectedItems.Count > 0;
            }
        }

        // Kiểm tra thông tin rồi thêm vào danh sách
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTK.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string soTienStr = txtSoTien.Text.Trim();

            if (soTK == "" || tenKH == "" ||
                diaChi == "" || soTienStr == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!long.TryParse(soTienStr, out long soTien)
                || soTien < 0)
            {
                MessageBox.Show("Số tiền phải là số nguyên không âm!");
                txtSoTien.Focus();
                txtSoTien.SelectAll();
                return;
            }

            if (TrungSoTaiKhoan(soTK))
            {
                MessageBox.Show("Số tài khoản đã tồn tại!");
                txtSoTK.Focus();
                txtSoTK.SelectAll();
                return;
            }

            ListViewItem item = new ListViewItem("");

            item.SubItems.Add(soTK);
            item.SubItems.Add(tenKH);
            item.SubItems.Add(diaChi);
            item.SubItems.Add(soTien.ToString("N0",
                CultureInfo.InvariantCulture));

            lvTaiKhoan.Items.Add(item);

            CapNhatDanhSach();
            XoaThongTin();
            KhoaNhapLieu(true);

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;

            MessageBox.Show("Thêm tài khoản thành công!");
        }

        // Chọn một dòng để xem thông tin tài khoản
        private void lvTaiKhoan_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];

                txtSoTK.Text = item.SubItems[1].Text;
                txtTenKH.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;

                txtSoTien.Text = item.SubItems[4].Text
                    .Replace(",", "").Replace(".", "");

                KhoaNhapLieu(true);

                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
            }
        }

        // Xóa tài khoản đang được chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            ListViewItem item = lvTaiKhoan.SelectedItems[0];

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa tài khoản " +
                item.SubItems[1].Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(item);

                XoaThongTin();
                KhoaNhapLieu(true);
                CapNhatDanhSach();

                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;

                MessageBox.Show("Đã xóa tài khoản!");
            }
        }

        // Hỏi lại trước khi đóng chương trình
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
