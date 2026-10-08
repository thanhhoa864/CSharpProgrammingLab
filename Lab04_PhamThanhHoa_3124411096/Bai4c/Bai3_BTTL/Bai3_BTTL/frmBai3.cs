namespace Bai3_BTTL
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e) // Ngăn người dùng nhập ký tự không phải số vào TextBox txtA
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar)) // Kiểm tra nếu ký tự không phải là ký tự điều khiển và không phải là chữ số
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e) // Ngăn người dùng nhập ký tự không phải số vào TextBox txtB
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar)) // Kiểm tra nếu ký tự không phải là ký tự điều khiển và không phải là chữ số
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ được nhập vào TextBox
            }
        }

        private int TimUCLN(int a, int b) // Hàm tìm ước số chung lớn nhất (UCLN) của hai số nguyên a và b
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }

        private int TimBCNN(int a, int b) // Hàm tìm bội số chung nhỏ nhất (BCNN) của hai số nguyên a và b
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }

            int ucln = TimUCLN(a, b);

            return Math.Abs(a * b) / ucln;
        }

        private void btnThucHien_Click(object sender, EventArgs e) // Xử lý sự kiện khi người dùng nhấn nút "Thực hiện"
        {
            errorProvider1.Clear();

            int a;
            int b;

            // Kiểm tra số a
            if (!int.TryParse(txtA.Text, out a))
            {
                errorProvider1.SetError(
                    txtA,
                    "Vui lòng nhập số nguyên a!"
                );

                return;
            }

            // Kiểm tra số b
            if (!int.TryParse(txtB.Text, out b))
            {
                errorProvider1.SetError(
                    txtB,
                    "Vui lòng nhập số nguyên b!"
                );

                return;
            }

            // Không thực hiện khi cả hai số đều bằng 0
            if (a == 0 && b == 0)
            {
                MessageBox.Show(
                    "Không thể tính UCLN và BCNN của 0 và 0!",
                    "Thông báo"
                );

                return;
            }

            // Tính UCLN
            int ucln = TimUCLN(a, b);

            // Tính BCNN
            int bcnn = TimBCNN(a, b);

            // Hiển thị kết quả
            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e) // Xử lý sự kiện khi người dùng nhấn nút "Tiếp tục"
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();

            errorProvider1.Clear();

            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBai3_FormClosing(object sender, FormClosingEventArgs e)
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