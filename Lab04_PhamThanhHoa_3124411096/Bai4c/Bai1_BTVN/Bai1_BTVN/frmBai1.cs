namespace Bai1_BTVN
{
    public partial class frmBai1 : Form
    {
        private double soThuNhat = 0;
        private string phepTinh = "";
        private bool dangNhapSoMoi = true;
        public frmBai1()
        {
            InitializeComponent();
        }
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Nếu đang bắt đầu nhập số mới thì xóa số cũ
            if (dangNhapSoMoi)
            {
                txtKetQua.Clear();
                dangNhapSoMoi = false;
            }

            // Thêm số vừa bấm vào màn hình
            txtKetQua.Text += btn.Text;
        }
        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKetQua.Text))
            {
                MessageBox.Show("Vui lòng nhập số trước!");
                return;
            }

            Button btn = (Button)sender;

            // Lưu số thứ nhất
            soThuNhat = double.Parse(txtKetQua.Text);

            // Lưu phép tính
            phepTinh = btn.Text;

            // Chuẩn bị nhập số thứ hai
            dangNhapSoMoi = true;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double soThuHai = double.Parse(txtKetQua.Text);
            double ketQua = 0;

            switch (phepTinh)
            {
                case "+":
                    ketQua = soThuNhat + soThuHai;
                    break;

                case "-":
                    ketQua = soThuNhat - soThuHai;
                    break;

                case "*":
                    ketQua = soThuNhat * soThuHai;
                    break;

                case "/":
                    if (soThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }

                    ketQua = soThuNhat / soThuHai;
                    break;
            }

            // Hiển thị kết quả
            txtKetQua.Text = ketQua.ToString();

            // Lần nhập tiếp theo là số mới
            dangNhapSoMoi = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa màn hình
            txtKetQua.Clear();

            // Đưa các giá trị về ban đầu
            soThuNhat = 0;
            phepTinh = "";
            dangNhapSoMoi = true;
        }
    }
}
