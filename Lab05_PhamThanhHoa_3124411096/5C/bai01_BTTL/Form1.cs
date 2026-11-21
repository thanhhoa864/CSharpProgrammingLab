
using System;
using System.Windows.Forms;

namespace bai01_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kiểm tra một số có phải số nguyên tố không
        private bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i * (long)i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Kiểm tra ListBox có dữ liệu hay chưa
        private bool KiemTraDanhSach()
        {
            if (lstUocSo.Items.Count > 0)
                return true;

            MessageBox.Show("Danh sách ước số đang trống!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return false;
        }

        // Cập nhật số vào ComboBox
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int n;

            if (!int.TryParse(txtNhapSo.Text.Trim(), out n) || n <= 0)
            {
                MessageBox.Show("Hãy nhập số nguyên dương hợp lệ!");
                txtNhapSo.Focus();
                txtNhapSo.SelectAll();
                return;
            }

            if (!cboSo.Items.Contains(n))
            {
                cboSo.Items.Add(n);
            }
            else
            {
                MessageBox.Show("Số này đã có trong danh sách!");
            }

            cboSo.SelectedItem = n;
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        // Hiển thị các ước số khi chọn số trong ComboBox
        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUocSo.Items.Clear();

            if (cboSo.SelectedItem == null)
                return;

            int n = Convert.ToInt32(cboSo.SelectedItem);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    lstUocSo.Items.Add(i);
            }
        }

        // Tính tổng tất cả ước số
        private void btnTongUoc_Click(object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            long tong = 0;

            foreach (int so in lstUocSo.Items)
            {
                tong += so;
            }

            MessageBox.Show("Tổng các ước số là: " + tong,
                "Kết quả");
        }

        // Đếm các ước số chẵn
        private void btnDemChan_Click(object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            int dem = 0;

            foreach (int so in lstUocSo.Items)
            {
                if (so % 2 == 0)
                    dem++;
            }

            MessageBox.Show("Số lượng ước số chẵn là: " + dem,
                "Kết quả");
        }

        // Đếm các ước số nguyên tố
        private void btnDemNguyenTo_Click(object sender, EventArgs e)
        {
            if (!KiemTraDanhSach())
                return;

            int dem = 0;

            foreach (int so in lstUocSo.Items)
            {
                if (IsPrime(so))
                    dem++;
            }

            MessageBox.Show("Số lượng ước số nguyên tố là: " + dem,
                "Kết quả");
        }

        // Thoát ứng dụng
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
