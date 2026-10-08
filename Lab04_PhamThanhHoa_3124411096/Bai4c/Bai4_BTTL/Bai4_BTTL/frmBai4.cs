namespace Bai4_BTTL
{
    public partial class frmBai4 : Form
    {
        private List<int> danhSach = new List<int>();
        public frmBai4()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int so;

            // Kiểm tra dữ liệu nhập có phải số nguyên hay không
            if (!int.TryParse(txtNhap.Text, out so))
            {
                errorProvider1.SetError(
                    txtNhap,
                    "Vui lòng nhập một số nguyên!"
                );

                MessageBox.Show(
                    "Vui lòng nhập một số nguyên!",
                    "Thông báo"
                );

                txtNhap.Focus();
                return;
            }

            // Xóa thông báo lỗi
            errorProvider1.Clear();

            // Thêm số vào danh sách
            danhSach.Add(so);

            // Hiển thị dãy số
            txtDaySo.Text = string.Join(" ", danhSach);

            // Tính tổng các phần tử
            int tong = 0;

            foreach (int x in danhSach)
            {
                tong += x;
            }

            txtTong.Text = tong.ToString();

            // Tính tổng các số chẵn
            int tongChan = 0;

            foreach (int x in danhSach)
            {
                if (x % 2 == 0)
                {
                    tongChan += x;
                }
            }

            txtTongChan.Text = tongChan.ToString();

            // Tính tổng các số lẻ
            int tongLe = 0;

            foreach (int x in danhSach)
            {
                if (x % 2 != 0)
                {
                    tongLe += x;
                }
            }

            txtTongLe.Text = tongLe.ToString();

            // Xóa ô nhập
            txtNhap.Clear();

            // Đưa con trỏ về ô nhập
            txtNhap.Focus();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e) // Tiếp tục nhập số
        {
            // Xóa danh sách cũ
            danhSach.Clear();

            // Xóa dữ liệu trên Form
            txtNhap.Clear();
            txtDaySo.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            // Xóa thông báo lỗi
            errorProvider1.Clear();

            // Đưa con trỏ về ô nhập
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e) // Thoát khỏi ứng dụng
        {
            Close();
        }

        private void frmBai4_FormClosing(object sender, FormClosingEventArgs e) // Xác nhận thoát
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
