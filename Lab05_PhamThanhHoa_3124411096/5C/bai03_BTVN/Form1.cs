using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace bai03_BTVN
{
    public partial class Form1 : Form
    {
        // ImageList dùng để lưu icon thư mục và icon người.
        private ImageList imageListIcons;

        // Hàm khởi tạo Form.
        public Form1()
        {
            InitializeComponent();
        }

        // 1. KHỞI TẠO ICON CHO TREEVIEW
        private void KhoiTaoImageList()
        {
            // Tạo danh sách hình ảnh và đặt kích thước icon là 16x16.
            imageListIcons = new ImageList();
            imageListIcons.ImageSize = new Size(16, 16);

            // Tạo bitmap làm icon thư mục.
            Bitmap bmpFolder = new Bitmap(16, 16);

            // Vẽ icon thư mục bằng Graphics.
            using (Graphics g = Graphics.FromImage(bmpFolder))
            {
                // Tạo nền trong suốt.
                g.Clear(Color.Transparent);

                // Vẽ phần thân thư mục.
                g.FillRectangle(Brushes.Goldenrod, 1, 3, 14, 11);

                // Vẽ phần nắp thư mục.
                g.FillRectangle(Brushes.DarkGoldenrod, 1, 1, 7, 3);
            }

            // Tạo bitmap làm icon người.
            Bitmap bmpPerson = new Bitmap(16, 16);

            // Vẽ icon người bằng Graphics.
            using (Graphics g = Graphics.FromImage(bmpPerson))
            {
                // Tạo nền trong suốt.
                g.Clear(Color.Transparent);

                // Vẽ phần đầu người.
                g.FillEllipse(Brushes.Peru, 4, 1, 8, 8);

                // Vẽ phần thân người.
                g.FillPie(Brushes.Peru, 1, 8, 14, 12, 180, 180);
            }

            // Thêm icon thư mục vào vị trí đầu tiên.
            imageListIcons.Images.Add("folder", bmpFolder);

            // Thêm icon người vào vị trí thứ hai.
            imageListIcons.Images.Add("person", bmpPerson);

            // Gán danh sách icon cho TreeView.
            tvDanhBa.ImageList = imageListIcons;
        }

        // 2. KHỞI TẠO TREEVIEW KHI FORM ĐƯỢC MỞ
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo các icon sử dụng trong TreeView.
            KhoiTaoImageList();

            // Xóa các node cũ nếu có.
            tvDanhBa.Nodes.Clear();

            // Tạo các node chữ cái từ A đến Z.
            for (char c = 'A'; c <= 'Z'; c++)
            {
                // Tạo node đại diện cho một chữ cái.
                TreeNode node = new TreeNode(c.ToString());

                // Đặt Name để tìm node bằng phương thức Find.
                node.Name = c.ToString();

                // Gán icon thư mục cho node chữ cái.
                node.ImageIndex = 0;

                // Giữ icon thư mục khi node được chọn.
                node.SelectedImageIndex = 0;

                // Thêm node chữ cái vào TreeView.
                tvDanhBa.Nodes.Add(node);
            }

            // Thêm liên hệ mẫu ban đầu.
            ThemDanhBa("Bình", "Ngô Thanh");
        }

        // 3. CHUYỂN TÊN TIẾNG VIỆT CÓ DẤU THÀNH KHÔNG DẤU
        private string BoDauTiengViet(string text)
        {
            // Nếu chuỗi rỗng hoặc null thì trả về chuỗi ban đầu.
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            // Chuẩn hóa chuỗi để tách các dấu tiếng Việt.
            string normalized = text.Normalize(NormalizationForm.FormD);

            // Tạo StringBuilder để lưu kết quả sau khi bỏ dấu.
            StringBuilder sb = new StringBuilder();

            // Duyệt từng ký tự trong chuỗi đã chuẩn hóa.
            foreach (char ch in normalized)
            {
                // Xác định loại ký tự hiện tại.
                UnicodeCategory loaiKyTu =
                    CharUnicodeInfo.GetUnicodeCategory(ch);

                // Chỉ giữ lại ký tự không phải dấu kết hợp.
                if (loaiKyTu != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(ch);
                }
            }

            // Ghép lại chuỗi, chuẩn hóa và chuyển đ/Đ thành d/D.
            return sb.ToString()
                     .Normalize(NormalizationForm.FormC)
                     .Replace('đ', 'd')
                     .Replace('Đ', 'D');
        }

        // 4. THÊM LIÊN HỆ VÀO TREEVIEW
        private void ThemDanhBa(string firstName, string lastName)
        {
            // Bỏ dấu tên để xác định chữ cái đầu.
            string tenKhongDau = BoDauTiengViet(firstName);

            // Chuyển chữ cái đầu thành chữ in hoa.
            char kyTuDau = char.ToUpper(tenKhongDau[0]);

            // Tìm node chữ cái tương ứng trong TreeView.
            TreeNode[] ketQua =
                tvDanhBa.Nodes.Find(kyTuDau.ToString(), false);

            // Kiểm tra node chữ cái có tồn tại hay không.
            if (ketQua.Length > 0)
            {
                // Lấy node chữ cái làm node cha.
                TreeNode nodeCha = ketQua[0];

                // Tạo node liên hệ theo định dạng FirstName, LastName.
                TreeNode nodeNguoi =
                    new TreeNode(firstName + ", " + lastName);

                // Gán icon người cho node liên hệ.
                nodeNguoi.ImageIndex = 1;

                // Giữ icon người khi node được chọn.
                nodeNguoi.SelectedImageIndex = 1;

                // Thêm liên hệ vào node chữ cái tương ứng.
                nodeCha.Nodes.Add(nodeNguoi);

                // Mở rộng node cha để hiển thị liên hệ.
                nodeCha.Expand();

                // Chọn liên hệ vừa thêm.
                tvDanhBa.SelectedNode = nodeNguoi;
            }
        }

        // 5. XỬ LÝ NÚT ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy First Name và Last Name, loại bỏ khoảng trắng thừa.
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            // Kiểm tra người dùng đã nhập đầy đủ thông tin chưa.
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ First Name và Last Name!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Đưa con trỏ đến ô còn thiếu dữ liệu.
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    txtFirstName.Focus();
                }
                else
                {
                    txtLastName.Focus();
                }

                // Dừng xử lý nếu dữ liệu chưa đầy đủ.
                return;
            }

            // Bỏ dấu tên để kiểm tra chữ cái đầu.
            string tenKhongDau = BoDauTiengViet(firstName);

            // Lấy chữ cái đầu và chuyển thành chữ in hoa.
            char kyTuDau = char.ToUpper(tenKhongDau[0]);

            // Kiểm tra chữ cái đầu có nằm trong A đến Z không.
            if (kyTuDau < 'A' || kyTuDau > 'Z')
            {
                MessageBox.Show(
                    "First Name phải bắt đầu bằng chữ cái hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Chọn toàn bộ nội dung để người dùng nhập lại.
                txtFirstName.SelectAll();
                txtFirstName.Focus();

                // Dừng xử lý nếu tên không hợp lệ.
                return;
            }

            // Thêm liên hệ vào đúng node chữ cái.
            ThemDanhBa(firstName, lastName);

            // Xóa nội dung hai ô nhập sau khi thêm.
            txtFirstName.Clear();
            txtLastName.Clear();

            // Đưa con trỏ về ô First Name.
            txtFirstName.Focus();
        }

        // 6. XỬ LÝ NÚT EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát chương trình.
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Chỉ đóng ứng dụng khi người dùng chọn Yes.
            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}