namespace Bai2_BTTL
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }
        private void txtEmail_Leave(object sender, EventArgs e) // Sự kiện khi rời khỏi ô nhập email
        {
            string email = txtEmail.Text.Trim();

            if (email == "")
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email"); // Hiển thị thông báo lỗi nếu email trống
                return;
            }
       
            if (!email.Contains("@") || !email.Contains(".")) // Kiểm tra định dạng email cơ bản
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ"); // Hiển thị thông báo lỗi nếu email không hợp lệ
            }
            else
            {
                errorProvider1.Clear();
            }
        }
        private bool KiemTraDuLieu() // Hàm kiểm tra dữ liệu nhập vào
        {
            errorProvider1.Clear();

            bool hopLe = true;

            if (txtHoTen.Text.Trim() == "") // Kiểm tra họ tên có trống không
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên");
                hopLe = false;
            }

            if (txtEmail.Text.Trim() == "")
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập email"); // Kiểm tra email có trống không
                hopLe = false;
            }

            if (txtMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu"); // Kiểm tra mật khẩu có trống không
                hopLe = false;
            }

            if (txtXacNhanMatKhau.Text.Trim() == "")
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Vui lòng xác nhận mật khẩu"); // Kiểm tra xác nhận mật khẩu có trống không
                hopLe = false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                errorProvider1.SetError(
                    txtXacNhanMatKhau,
                    "Mật khẩu xác nhận không giống nhau"); // Kiểm tra mật khẩu và xác nhận mật khẩu có giống nhau không

                hopLe = false;
            }

            return hopLe;
        }
        private void btnDangKy_Click(object sender, EventArgs e) // Sự kiện khi nhấn nút đăng ký
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu!"); // Hiển thị thông báo nếu dữ liệu không hợp lệ
                return;
            }

            string s =
                "Họ tên: " + txtHoTen.Text + "\n" + // Tạo chuỗi thông tin đăng ký từ các ô nhập liệu
                "Email: " + txtEmail.Text + "\n" + // Hiển thị thông tin đăng ký
                "Mật khẩu: " + txtMatKhau.Text + "\n" + // Hiển thị thông tin đăng ký
                "Xác nhận mật khẩu: " + txtXacNhanMatKhau.Text + "\n"; // Hiển thị thông tin đăng ký

            MessageBox.Show(s, "Thông tin đăng ký");
        }
        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e) // Sự kiện khi đóng form
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
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
