using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai02_BTVN
{
    public partial class Form1 : Form
    {
        // Hàm khởi tạo giao diện Form.
        public Form1()
        {
            InitializeComponent();
        }

        // 1. NHẬP SỐ VÀO LISTBOX
        private void btnNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra ô nhập có bị trống hay không.
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập một số tự nhiên!");
                txtNhap.Focus();
                return;
            }

            // Chuyển dữ liệu nhập thành số nguyên kiểu long.
            long n;

            // Kiểm tra dữ liệu có phải số hợp lệ và không âm.
            if (!long.TryParse(txtNhap.Text.Trim(), out n) || n < 0)
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên hợp lệ (>= 0)!");
                txtNhap.SelectAll();
                txtNhap.Focus();
                return;
            }

            // Thêm số vừa nhập vào ListBox.
            lstSo.Items.Add(n);

            // Xóa nội dung ô nhập để nhập số tiếp theo.
            txtNhap.Clear();
            txtNhap.Focus();
        }

        // 2. TÍNH TỔNG CÁC PHẦN TỬ
        private void btnTong_Click(object sender, EventArgs e)
        {
            // Kiểm tra danh sách có phần tử hay không.
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox đang trống!");
                return;
            }

            // Khởi tạo biến lưu tổng.
            long tong = 0;

            // Duyệt từng phần tử và cộng vào tổng.
            foreach (var item in lstSo.Items)
            {
                tong += Convert.ToInt64(item);
            }

            // Hiển thị kết quả tính tổng.
            MessageBox.Show("Tổng các phần tử là: " + tong);
        }

        // 3. XÓA PHẦN TỬ ĐẦU VÀ CUỐI
        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            // Kiểm tra danh sách có trống hay không.
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("ListBox đang trống!");
                return;
            }

            // Xóa phần tử cuối cùng nếu danh sách chỉ có một phần tử.
            if (lstSo.Items.Count == 1)
            {
                lstSo.Items.RemoveAt(0);
            }
            else
            {
                // Xóa phần tử cuối cùng trước.
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);

                // Sau đó xóa phần tử đầu tiên.
                lstSo.Items.RemoveAt(0);
            }
        }

        // 4. XÓA CÁC PHẦN TỬ ĐƯỢC CHỌN
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã chọn phần tử cần xóa chưa.
            if (lstSo.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!");
                return;
            }

            // Xóa từ vị trí cuối về đầu để tránh lệch chỉ số.
            for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
            }
        }

        // 5. TĂNG MỖI PHẦN TỬ LÊN 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            // Kiểm tra danh sách có trống hay không.
            if (lstSo.Items.Count == 0)
            {
                return;
            }

            // Tạo danh sách tạm để lưu các giá trị mới.
            List<long> dsMoi = new List<long>();

            // Duyệt danh sách và tăng mỗi số lên 2.
            foreach (var item in lstSo.Items)
            {
                dsMoi.Add(Convert.ToInt64(item) + 2);
            }

            // Xóa dữ liệu cũ trong ListBox.
            lstSo.Items.Clear();

            // Thêm các giá trị mới vào ListBox.
            foreach (long so in dsMoi)
            {
                lstSo.Items.Add(so);
            }
        }

        // 6. BÌNH PHƯƠNG MỖI PHẦN TỬ
        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            // Kiểm tra danh sách có trống hay không.
            if (lstSo.Items.Count == 0)
            {
                return;
            }

            // Tạo danh sách tạm để lưu các bình phương.
            List<long> dsMoi = new List<long>();

            // Duyệt từng phần tử và tính bình phương.
            foreach (var item in lstSo.Items)
            {
                long so = Convert.ToInt64(item);

                // Thêm bình phương của số vào danh sách mới.
                dsMoi.Add(so * so);
            }

            // Xóa các phần tử cũ.
            lstSo.Items.Clear();

            // Hiển thị danh sách bình phương mới.
            foreach (long so in dsMoi)
            {
                lstSo.Items.Add(so);
            }
        }

        // 7. CHỌN CÁC SỐ CHẴN
        private void btnChonChan_Click(object sender, EventArgs e)
        {
            // Bỏ chọn các phần tử đang được chọn.
            lstSo.ClearSelected();

            // Duyệt tất cả phần tử trong ListBox.
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                // Chuyển phần tử hiện tại thành số nguyên.
                long so = Convert.ToInt64(lstSo.Items[i]);

                // Số chia hết cho 2 là số chẵn.
                if (so % 2 == 0)
                {
                    // Chọn phần tử tại vị trí i.
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // 8. CHỌN CÁC SỐ LẺ
        private void btnChonLe_Click(object sender, EventArgs e)
        {
            // Bỏ chọn các phần tử đang được chọn.
            lstSo.ClearSelected();

            // Duyệt tất cả phần tử trong ListBox.
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                // Chuyển phần tử hiện tại thành số nguyên.
                long so = Convert.ToInt64(lstSo.Items[i]);

                // Số không chia hết cho 2 là số lẻ.
                if (so % 2 != 0)
                {
                    // Chọn phần tử tại vị trí i.
                    lstSo.SetSelected(i, true);
                }
            }
        }

        // 9. KẾT THÚC CHƯƠNG TRÌNH
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận thoát.
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Yes thì đóng chương trình.
            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}