namespace Bai1_BTNC
{
    public partial class frmBai1 : Form
    {
        private Button[] danhSachGhe;
        private int tongTien = 0;
        public frmBai1()
        {
            InitializeComponent();
            danhSachGhe = new Button[]
            {
            btn1, btn2, btn3, btn4, btn5,
            btn6, btn7, btn8, btn9, btn10,
            btn11, btn12, btn13, btn14, btn15
            }; // Khởi tạo danh sách các ghế
            foreach (Button ghe in danhSachGhe)
            {
                ghe.BackColor = Color.White;
            } // Khởi tạo màu nền của các ghế là trắng
        }
        private void btnGhe_Click(object sender, EventArgs e) // Sự kiện click cho các nút ghế
        {
            Button ghe = (Button)sender;

            // Nếu ghế đã bán thì không cho chọn
            if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được bán!");
                return;
            }

            // Ghế trắng thì chuyển sang xanh
            if (ghe.BackColor == Color.White)
            {
                ghe.BackColor = Color.Blue;
            }
            // Ghế xanh thì bỏ chọn, chuyển lại trắng
            else if (ghe.BackColor == Color.Blue)
            {
                ghe.BackColor = Color.White;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (Button ghe in danhSachGhe)
            {
                // Chỉ tính những ghế đang được chọn màu xanh
                if (ghe.BackColor == Color.Blue)
                {
                    // Cộng giá ghế vào tổng tiền
                    tongTien += LayGiaVe(ghe);

                    // Chuyển ghế đã chọn thành màu vàng
                    ghe.BackColor = Color.Yellow;
                }
            }

            // Hiển thị tổng tiền
            txtKetQua.Text = tongTien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Button ghe in danhSachGhe)
            {
                // Chỉ hủy những ghế đang được chọn màu xanh
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.White;
                }
            }

            // Hủy tổng tiền
            tongTien = 0;

            // Hiển thị lại tổng tiền
            txtKetQua.Text = "0";
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có muốn kết thúc chương trình không?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question); // Hiển thị hộp thoại xác nhận kết thúc chương trình

            if (result == DialogResult.Yes)
            {
                Close(); // Đóng form nếu người dùng chọn "Yes"
            }
        }
        private int LayGiaVe(Button ghe) // Hàm lấy giá vé dựa trên nút ghế
        {
            // btn1 đến btn5: giá 1000
            if (ghe == btn1 || ghe == btn2 || ghe == btn3 ||
                ghe == btn4 || ghe == btn5)
            {
                return 1000;
            }

            // btn6 đến btn10: giá 1500
            if (ghe == btn6 || ghe == btn7 || ghe == btn8 ||
                ghe == btn9 || ghe == btn10)
            {
                return 1500;
            }

            // btn11 đến btn15: giá 2000
            if (ghe == btn11 || ghe == btn12 || ghe == btn13 ||
                ghe == btn14 || ghe == btn15)
            {
                return 2000;
            }

            return 0;
        }
    }
}
