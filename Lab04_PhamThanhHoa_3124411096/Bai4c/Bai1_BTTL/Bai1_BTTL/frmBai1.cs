namespace Bai1_BTTL
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        private bool KiemTraDuLieu() // kiểm tra xem dữ liệu nhập vào có hợp lệ hay không
        {
            bool hopLe = true;

            errorProvider1.Clear();

            if (!float.TryParse(txtA.Text, out _))
            {
                errorProvider1.SetError(txtA, "Vui lòng nhập số a hợp lệ");
                hopLe = false;
            }

            if (!float.TryParse(txtB.Text, out _))
            {
                errorProvider1.SetError(txtB, "Vui lòng nhập số b hợp lệ");
                hopLe = false;
            }

            return hopLe;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e) // Chặn nhập ký tự không phải số và dấu chấm
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtB_KeyPress(object sender, KeyPressEventArgs e) // Chặn nhập ký tự không phải số và dấu chấm
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void btnCong_Click(object sender, EventArgs e) // Xử lý sự kiện khi nhấn nút cộng
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                return;
            }

            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e) // Xử lý sự kiện khi nhấn nút trừ
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                return;
            }

            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e) // Xử lý sự kiện khi nhấn nút nhân
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                return;
            }

            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);

            txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e) // Xử lý sự kiện khi nhấn nút chia
        {
            if (!KiemTraDuLieu())
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
                return;
            }
            float a = float.Parse(txtA.Text);
            float b = float.Parse(txtB.Text);
            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }
            txtKetQua.Text = (a / b).ToString();
        }

        private void frmBai1_FormClosing(object sender, FormClosingEventArgs e)
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
