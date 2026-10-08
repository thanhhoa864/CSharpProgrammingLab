namespace Bai5_BTTL
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private string DocHangDonVi(int so) // Hàm đọc số hàng đơn vị
        {
            switch (so)
            {
                case 0:
                    return "Không";
                case 1:
                    return "Một";
                case 2:
                    return "Hai";
                case 3:
                    return "Ba";
                case 4:
                    return "Bốn";
                case 5:
                    return "Năm";
                case 6:
                    return "Sáu";
                case 7:
                    return "Bảy";
                case 8:
                    return "Tám";
                case 9:
                    return "Chín";
                default:
                    return "";
            }
        }
        private string DocHaiChuSo(int so) // Hàm đọc số có hai chữ số
        {
            int hangChuc = so / 10; // Lấy chữ số hàng chục
            int hangDonVi = so % 10; // Lấy chữ số hàng đơn vị

            string ketQua = "";

            if (hangChuc == 1)
            {
                ketQua = "Mười"; // Trường hợp đặc biệt: 10 đọc là "Mười"

                if (hangDonVi != 0) // Nếu hàng đơn vị khác 0, đọc tiếp
                {
                    if (hangDonVi == 5) // Trường hợp đặc biệt: 15 đọc là "Mười Lăm"
                        ketQua += " Lăm"; // Trường hợp đặc biệt: 15 đọc là "Mười Lăm"
                    else
                        ketQua += " " + DocHangDonVi(hangDonVi).ToLower(); // Chuyển chữ cái đầu tiên của hàng đơn vị thành chữ thường
                }
            }
            else
            {
                ketQua = DocHangDonVi(hangChuc) + " Mươi"; // Đọc hàng chục

                if (hangDonVi != 0) // Nếu hàng đơn vị khác 0, đọc tiếp
                {
                    if (hangDonVi == 1) // Trường hợp đặc biệt: 21, 31, 41,... đọc là "Hai Mươi Mốt", "Ba Mươi Mốt",...
                        ketQua += " Mốt"; 
                    else if (hangDonVi == 5) // Trường hợp đặc biệt: 25, 35, 45,... đọc là "Hai Mươi Lăm", "Ba Mươi Lăm",...
                        ketQua += " Lăm";
                    else
                        ketQua += " " + DocHangDonVi(hangDonVi).ToLower(); // Chuyển chữ cái đầu tiên của hàng đơn vị thành chữ thường
                }
            }

            return ketQua;
        }

        private string DocSo(int so) // Hàm đọc số có ba chữ số
        {
            if (so < 10) // Nếu số có một chữ số, gọi hàm đọc hàng đơn vị
            {
                return DocHangDonVi(so);
            }

            if (so < 100) // Nếu số có hai chữ số, gọi hàm đọc hai chữ số
            {
                return DocHaiChuSo(so);
            }

            int hangTram = so / 100; // Lấy chữ số hàng trăm
            int phanDu = so % 100; // Lấy phần dư sau khi chia cho 100 (tức là hai chữ số cuối cùng)

            string ketQua = DocHangDonVi(hangTram) + " Trăm"; // Đọc hàng trăm

            if (phanDu == 0) // Nếu phần dư là 0, tức là số có dạng x00, chỉ cần đọc hàng trăm
            {
                return ketQua;
            }

            if (phanDu < 10) // Nếu phần dư nhỏ hơn 10, tức là số có dạng x0y, đọc "Lẻ" và gọi hàm đọc hàng đơn vị
            {
                ketQua += " Lẻ " + DocHangDonVi(phanDu).ToLower(); // Chuyển chữ cái đầu tiên của hàng đơn vị thành chữ thường
            }
            else
            {
                ketQua += " " + DocHaiChuSo(phanDu); // Gọi hàm đọc hai chữ số
            }

            return ketQua;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int so;

            // Kiểm tra người dùng có nhập số nguyên hay không
            if (!int.TryParse(txtSo.Text, out so))
            {
                MessageBox.Show(
                    "Vui lòng nhập một số nguyên!",
                    "Thông báo"
                );

                txtSo.Focus();
                return;
            }

            // Kiểm tra số có nằm trong khoảng từ 1 đến 999 hay không
            if (so < 1 || so > 999)
            {
                MessageBox.Show(
                    "Vui lòng nhập số từ 1 đến 999!",
                    "Thông báo"
                );

                txtSo.Focus();
                return;
            }

            // Đọc số thành chữ
            txtKetQua.Text = DocSo(so);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa số đã nhập
            txtSo.Clear();

            // Xóa kết quả
            txtKetQua.Clear();

            // Đưa con trỏ về ô nhập số
            txtSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát chương trình không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn thoát chương trình không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
