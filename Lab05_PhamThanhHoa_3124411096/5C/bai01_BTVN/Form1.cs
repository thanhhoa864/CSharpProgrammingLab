using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai01_BTVN
{
    public partial class Form1 : Form
    {
 
        // 1. KHAI BÁO LỚP ĐỐI TƯỢNG TỪ ĐIỂN
 

        // Lớp TuDienItem dùng để lưu một từ và nghĩa của từ đó.
        public class TuDienItem
        {
            // Thuộc tính Tu lưu từ cần tra cứu.
            public string Tu { get; set; }

            // Thuộc tính Nghia lưu nghĩa tương ứng của từ.
            public string Nghia { get; set; }

            // Hàm khởi tạo dùng để gán từ và nghĩa khi tạo đối tượng.
            public TuDienItem(string tu, string nghia)
            {
                Tu = tu;
                Nghia = nghia;
            }

            // Trả về nội dung thuộc tính Tu khi đối tượng được hiển thị.
            public override string ToString()
            {
                return Tu;
            }
        }

 
        // 2. KHAI BÁO DANH SÁCH DỮ LIỆU
 

        // Danh sách từ điển Anh - Việt.
        private List<TuDienItem> dsAnhViet = new List<TuDienItem>();

        // Danh sách từ điển Việt - Anh.
        private List<TuDienItem> dsVietAnh = new List<TuDienItem>();

 
        // 3. KHỞI TẠO FORM
 

        // Hàm khởi tạo Form1.
        public Form1()
        {
            // Khởi tạo các điều khiển được thiết kế trong Designer.
            InitializeComponent();
        }

        // Sự kiện xảy ra khi Form được tải.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu cho hai danh sách từ điển.
            KhoiTaoDuLieu();

            // Hiển thị dữ liệu từ điển lên giao diện.
            HienThiDuLieu();

            // Chọn từ đầu tiên trong danh sách Anh - Việt nếu có dữ liệu.
            if (lstTuAV.Items.Count > 0)
            {
                lstTuAV.SelectedIndex = 0;
            }
        }

 
        // 4. KHỞI TẠO DỮ LIỆU TỪ ĐIỂN
 

        // Thêm các từ và nghĩa mẫu vào hai danh sách.
        private void KhoiTaoDuLieu()
        {
            // Thêm dữ liệu từ điển Anh - Việt.
            dsAnhViet.Add(new TuDienItem("student", "Sinh viên, học sinh"));
            dsAnhViet.Add(new TuDienItem("teacher", "Giáo viên, giảng viên"));
            dsAnhViet.Add(new TuDienItem("worker", "Công nhân, người lao động"));
            dsAnhViet.Add(new TuDienItem("hat", "Cái mũ, cái nón"));
            dsAnhViet.Add(new TuDienItem("head", "Cái đầu, người đứng đầu"));
            dsAnhViet.Add(new TuDienItem("mouse", "Con chuột, chuột máy tính"));
            dsAnhViet.Add(new TuDienItem("cat", "Con mèo"));
            dsAnhViet.Add(new TuDienItem("dog", "Con chó"));
            dsAnhViet.Add(new TuDienItem("snake", "Con rắn"));
            dsAnhViet.Add(new TuDienItem("lumb", "Khối, tảng, cục"));
            dsAnhViet.Add(new TuDienItem("loan", "Khoản vay, tiền vay"));
            dsAnhViet.Add(new TuDienItem("frog", "Con ếch"));
            dsAnhViet.Add(new TuDienItem("sheep", "Con cừu"));

            // Thêm dữ liệu từ điển Việt - Anh.
            dsVietAnh.Add(new TuDienItem("sinh viên", "student"));
            dsVietAnh.Add(new TuDienItem("giáo viên", "teacher"));
            dsVietAnh.Add(new TuDienItem("công nhân", "worker"));
            dsVietAnh.Add(new TuDienItem("cái mũ", "hat"));
            dsVietAnh.Add(new TuDienItem("cái đầu", "head"));
            dsVietAnh.Add(new TuDienItem("con chuột", "mouse"));
            dsVietAnh.Add(new TuDienItem("con mèo", "cat"));
            dsVietAnh.Add(new TuDienItem("con chó", "dog"));
            dsVietAnh.Add(new TuDienItem("con rắn", "snake"));
            dsVietAnh.Add(new TuDienItem("khoản vay", "loan"));
            dsVietAnh.Add(new TuDienItem("con ếch", "frog"));
            dsVietAnh.Add(new TuDienItem("con cừu", "sheep"));
        }

 
        // 5. HIỂN THỊ DỮ LIỆU LÊN GIAO DIỆN
 

        // Đưa các từ trong danh sách lên ComboBox và ListBox.
        private void HienThiDuLieu()
        {
            // Xóa dữ liệu cũ để tránh thêm trùng khi nạp lại.
            cboTuAV.Items.Clear();
            lstTuAV.Items.Clear();
            cboTuVA.Items.Clear();
            lstTuVA.Items.Clear();

            // Hiển thị danh sách từ Anh - Việt.
            foreach (TuDienItem item in dsAnhViet)
            {
                // Thêm từ tiếng Anh vào ComboBox Anh - Việt.
                cboTuAV.Items.Add(item.Tu);

                // Thêm từ tiếng Anh vào ListBox Anh - Việt.
                lstTuAV.Items.Add(item.Tu);
            }

            // Hiển thị danh sách từ Việt - Anh.
            foreach (TuDienItem item in dsVietAnh)
            {
                // Thêm từ tiếng Việt vào ComboBox Việt - Anh.
                cboTuVA.Items.Add(item.Tu);

                // Thêm từ tiếng Việt vào ListBox Việt - Anh.
                lstTuVA.Items.Add(item.Tu);
            }
        }

 
        // 6. TRA TỪ ĐIỂN ANH - VIỆT
 

        // Tìm từ tiếng Anh và hiển thị nghĩa tiếng Việt.
        private void TraTuAnhViet(string tuCanTra)
        {
            // Không thực hiện nếu người dùng chưa nhập từ.
            if (string.IsNullOrWhiteSpace(tuCanTra))
            {
                return;
            }

            // Loại bỏ khoảng trắng ở hai đầu từ cần tra.
            tuCanTra = tuCanTra.Trim();

            // Tìm từ trong danh sách, không phân biệt chữ hoa và chữ thường.
            TuDienItem item = dsAnhViet.Find(
                x => string.Equals(
                    x.Tu,
                    tuCanTra,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            // Kiểm tra xem từ có tồn tại trong từ điển hay không.
            if (item != null)
            {
                // Hiển thị nghĩa của từ tìm được.
                txtNghiaAV.Text = item.Nghia;

                // Hiển thị từ tìm được trong ComboBox.
                cboTuAV.Text = item.Tu;

                // Chọn từ tương ứng trong ListBox.
                lstTuAV.SelectedItem = item.Tu;
            }
            else
            {
                // Thông báo nếu không tìm thấy từ.
                txtNghiaAV.Text = "Không tìm thấy từ này trong từ điển!";
            }
        }

        // Xử lý sự kiện nhấn phím trên ComboBox Anh - Việt.
        private void cboTuAV_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn phím Enter hay không.
            if (e.KeyCode == Keys.Enter)
            {
                // Tra từ theo nội dung người dùng nhập.
                TraTuAnhViet(cboTuAV.Text);

                // Đánh dấu sự kiện phím đã được xử lý.
                e.Handled = true;

                // Ngăn tiếng bíp mặc định khi nhấn Enter.
                e.SuppressKeyPress = true;
            }
        }

        // Xử lý khi người dùng chọn một từ trong ListBox Anh - Việt.
        private void lstTuAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra đã có từ được chọn hay chưa.
            if (lstTuAV.SelectedItem != null)
            {
                // Tra nghĩa của từ được chọn.
                TraTuAnhViet(lstTuAV.SelectedItem.ToString());
            }
        }

        // Xử lý khi người dùng nhấp đúp vào ListBox Anh - Việt.
        private void lstTuAV_DoubleClick(object sender, EventArgs e)
        {
            // Kiểm tra đã có từ được chọn hay chưa.
            if (lstTuAV.SelectedItem != null)
            {
                // Tra nghĩa của từ được chọn.
                TraTuAnhViet(lstTuAV.SelectedItem.ToString());
            }
        }

 
        // 7. TRA TỪ ĐIỂN VIỆT - ANH
 

        // Tìm từ tiếng Việt và hiển thị nghĩa tiếng Anh.
        private void TraTuVietAnh(string tuCanTra)
        {
            // Không thực hiện nếu người dùng chưa nhập từ.
            if (string.IsNullOrWhiteSpace(tuCanTra))
            {
                return;
            }

            // Loại bỏ khoảng trắng ở hai đầu từ cần tra.
            tuCanTra = tuCanTra.Trim();

            // Tìm từ trong danh sách, không phân biệt chữ hoa và chữ thường.
            TuDienItem item = dsVietAnh.Find(
                x => string.Equals(
                    x.Tu,
                    tuCanTra,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            // Kiểm tra xem từ có tồn tại trong từ điển hay không.
            if (item != null)
            {
                // Hiển thị nghĩa tiếng Anh của từ tìm được.
                txtNghiaVA.Text = item.Nghia;

                // Hiển thị từ tiếng Việt trong ComboBox.
                cboTuVA.Text = item.Tu;

                // Chọn từ tương ứng trong ListBox.
                lstTuVA.SelectedItem = item.Tu;
            }
            else
            {
                // Thông báo nếu không tìm thấy từ.
                txtNghiaVA.Text = "Không tìm thấy từ này trong từ điển!";
            }
        }

        // Xử lý sự kiện nhấn phím trên ComboBox Việt - Anh.
        private void cboTuVA_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có nhấn phím Enter hay không.
            if (e.KeyCode == Keys.Enter)
            {
                // Tra từ theo nội dung người dùng nhập.
                TraTuVietAnh(cboTuVA.Text);

                // Đánh dấu sự kiện phím đã được xử lý.
                e.Handled = true;

                // Ngăn tiếng bíp mặc định khi nhấn Enter.
                e.SuppressKeyPress = true;
            }
        }

        // Xử lý khi người dùng chọn một từ trong ListBox Việt - Anh.
        private void lstTuVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra đã có từ được chọn hay chưa.
            if (lstTuVA.SelectedItem != null)
            {
                // Tra nghĩa tiếng Anh của từ được chọn.
                TraTuVietAnh(lstTuVA.SelectedItem.ToString());
            }
        }

        // Xử lý khi người dùng nhấp đúp vào ListBox Việt - Anh.
        private void lstTuVA_DoubleClick(object sender, EventArgs e)
        {
            // Kiểm tra đã có từ được chọn hay chưa.
            if (lstTuVA.SelectedItem != null)
            {
                // Tra nghĩa tiếng Anh của từ được chọn.
                TraTuVietAnh(lstTuVA.SelectedItem.ToString());
            }
        }

 
        // 8. XỬ LÝ NÚT THOÁT CHƯƠNG TRÌNH
 

        // Xử lý khi người dùng nhấn nút Thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận trước khi thoát.
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Chỉ thoát khi người dùng chọn Yes.
            if (ketQua == DialogResult.Yes)
            {
                // Đóng toàn bộ ứng dụng.
                Application.Exit();
            }
        }
    }
}