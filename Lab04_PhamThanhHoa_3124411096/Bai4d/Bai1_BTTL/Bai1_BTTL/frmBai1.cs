namespace Bai1_BTTL
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent(); // Khởi tạo các thành phần giao diện
            txtA.TextChanged += txtA_TextChanged; // Gán sự kiện TextChanged cho txtA
            txtB.TextChanged += txtB_TextChanged; // Gán sự kiện TextChanged cho txtB
            txtC.TextChanged += txtC_TextChanged; // Gán sự kiện TextChanged cho txtC

            // Ban đầu chọn phương trình bậc nhất
            rdoBacNhat.Checked = true;

            // Ô c không được nhập khi chọn bậc nhất
            txtC.Enabled = false;

            // Ô kết quả chỉ dùng để hiển thị
            txtKetQua.ReadOnly = true;

            KiemTraDuLieu();
        }

        // Xử lý khi chọn phương trình bậc nhất
        private void rdoBacNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacNhat.Checked)
            {
                // Không cho nhập c
                txtC.Enabled = false;

                // Xóa dữ liệu c
                txtC.Clear();

                // Kiểm tra dữ liệu
                KiemTraDuLieu();
            }
        }

        // Xử lý khi chọn phương trình bậc hai
        private void rdoBacHai_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBacHai.Checked)
            {
                // Cho phép nhập c
                txtC.Enabled = true;

                // Đưa con trỏ vào ô c
                txtC.Focus();

                // Kiểm tra dữ liệu
                KiemTraDuLieu();
            }
        }

        // Chỉ cho phép nhập số và dấu âm
        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // Kiểm tra đã nhập đủ dữ liệu hay chưa
        private void KiemTraDuLieu()
        {
            txtKetQua.Clear();
            if (rdoBacNhat.Checked)
            {
                // Bậc nhất cần a và b
                btnGiai.Enabled =
                    txtA.Text != "" &&
                    txtB.Text != "";
            }
            else if (rdoBacHai.Checked)
            {
                // Bậc hai cần a, b và c
                btnGiai.Enabled =
                    txtA.Text != "" &&
                    txtB.Text != "" &&
                    txtC.Text != "";
            }
        }

        // Khi nội dung ô a thay đổi
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Khi nội dung ô b thay đổi
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Khi nội dung ô c thay đổi
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        // Nút Giải
        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c = 0;

            // Kiểm tra a
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập đúng số a!");
                txtA.Focus();
                return;
            }

            // Kiểm tra b
            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập đúng số b!");
                txtB.Focus();
                return;
            }

            // Nếu là phương trình bậc hai thì kiểm tra c
            if (rdoBacHai.Checked)
            {
                if (!double.TryParse(txtC.Text, out c))
                {
                    MessageBox.Show("Vui lòng nhập đúng số c!");
                    txtC.Focus();
                    return;
                }
            }
            // Giải phương trình và hiển thị kết quả
            var pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = rdoBacNhat.Checked ? pt.GiaiBacNhat() : pt.GiaiBacHai();

            // Sau khi giải xong thì khóa nút Giải
            btnGiai.Enabled = false;
        }

        // Nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Xác nhận trước khi đóng Form
        private void frmBai1_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
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