using System;
using System.Windows.Forms;

namespace bai01_BTVN
{
    public partial class Form1 : Form
    {
        // Lưu tổng số lượt khách đã sử dụng phòng
        private int tongSoLuotKhach = 0;

        // Lưu tổng doanh thu của các lượt khách
        private double tongDoanhThu = 0;

        // Lưu số tiền của khách hàng hiện tại
        private double tienKhachHienTai = 0;

        // Hàm khởi tạo Form
        public Form1()
        {
            InitializeComponent();
        }

        // Thiết lập trạng thái ban đầu khi mở chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đưa con trỏ vào ô họ tên
            txtHoTen.Focus();

            // Khóa các nút khi chưa có thông tin khách hàng
            btnThanhToan.Enabled = false;
            btnNhapMoi.Enabled = false;
            btnTongKet.Enabled = false;
        }

        // Chỉ cho phép nhập số vào ô số ngày ở
        private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím điều khiển và các chữ số
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                // Không cho phép ký tự không hợp lệ
                e.Handled = true;
            }
        }

        // Kiểm tra thông tin nhập vào để bật nút Thanh toán
        private void DuLieuNhap_Changed(object sender, EventArgs e)
        {
            // Kiểm tra họ tên đã được nhập chưa
            bool coTen =
                !string.IsNullOrWhiteSpace(txtHoTen.Text);

            // Kiểm tra địa chỉ đã được nhập chưa
            bool coDiaChi =
                !string.IsNullOrWhiteSpace(txtDiaChi.Text);

            // Kiểm tra số ngày ở có hợp lệ không
            int ngay;

            bool coNgayO =
                int.TryParse(txtSoNgayO.Text.Trim(), out ngay)
                && ngay > 0;
            
            // Kiểm tra khách đã chọn loại phòng chưa
            bool coPhong =
                radPhongDon.Checked ||
                radPhongDoi.Checked ||
                radPhongBa.Checked;

            // Chỉ bật nút Thanh toán khi đủ thông tin
            btnThanhToan.Enabled =
                coTen &&
                coDiaChi &&
                coNgayO &&
                coPhong;
        }

        // Thực hiện tính tiền cho khách hàng
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra số ngày ở
            int soNgay;

            if (!int.TryParse(
                    txtSoNgayO.Text.Trim(),
                    out soNgay) ||
                soNgay <= 0)
            {
                MessageBox.Show(
                    "Số ngày ở phải là một số nguyên dương (> 0)!",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Đưa con trỏ về ô số ngày
                txtSoNgayO.Focus();
                return;
            }

            // Biến lưu đơn giá phòng theo ngày
            double giaPhongNgay = 0;

            // Xác định giá dựa trên loại phòng
            if (radPhongDon.Checked)
            {
                giaPhongNgay = 300000;
            }
            else if (radPhongDoi.Checked)
            {
                giaPhongNgay = 350000;
            }
            else if (radPhongBa.Checked)
            {
                giaPhongNgay = 400000;
            }

            // Tính tiền phòng
            double tienPhong =
                giaPhongNgay * soNgay;

            // Biến lưu tiền tiện nghi
            double tienTienNghi = 0;

            // Mỗi tiện nghi có giá 10.000 VNĐ
            if (chkTivi.Checked)
            {
                tienTienNghi += 10000;
            }

            if (chkInternet.Checked)
            {
                tienTienNghi += 10000;
            }

            if (chkMayNuocNong.Checked)
            {
                tienTienNghi += 10000;
            }

            // Biến lưu tiền dịch vụ
            double tienDichVu = 0;

            // Tính tiền Karaoke
            if (chkKaraoke.Checked)
            {
                tienDichVu += 50000;
            }

            // Tính tiền ăn sáng theo số ngày ở
            if (chkAnSang.Checked)
            {
                tienDichVu += 15000 * soNgay;
            }

            // Tính tổng tiền khách phải thanh toán
            tienKhachHienTai =
                tienPhong +
                tienTienNghi +
                tienDichVu;

            // Hiển thị thành tiền lên giao diện
            txtThanhTien.Text =
                tienKhachHienTai.ToString("0") + " VNĐ";

            // Cập nhật thống kê lượt khách
            tongSoLuotKhach++;

            // Cộng tiền khách hiện tại vào doanh thu
            tongDoanhThu += tienKhachHienTai;

            // Cho phép nhập khách mới
            btnNhapMoi.Enabled = true;

            // Cho phép xem tổng kết
            btnTongKet.Enabled = true;

            // Không cho tính tiền lại cùng một khách
            btnThanhToan.Enabled = false;
        }

        // Xóa thông tin để nhập khách hàng mới
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            // Xóa thông tin cá nhân
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoNgayO.Clear();

            // Xóa kết quả thanh toán
            txtThanhTien.Clear();

            // Bỏ chọn các loại phòng
            radPhongDon.Checked = false;
            radPhongDoi.Checked = false;
            radPhongBa.Checked = false;

            // Bỏ chọn các tiện nghi
            chkTivi.Checked = false;
            chkInternet.Checked = false;
            chkMayNuocNong.Checked = false;

            // Bỏ chọn các dịch vụ
            chkKaraoke.Checked = false;
            chkAnSang.Checked = false;

            // Khóa lại các nút
            btnNhapMoi.Enabled = false;
            btnThanhToan.Enabled = false;

            // Đưa con trỏ về ô họ tên
            txtHoTen.Focus();
        }

        // Hiển thị tổng kết doanh thu
        private void btnTongKet_Click(object sender, EventArgs e)
        {
            // Hiển thị tổng số lượt khách
            txtSoLuotNguoi.Text =
                tongSoLuotKhach.ToString();

            // Hiển thị tổng doanh thu
            txtTongSoTien.Text =
                tongDoanhThu.ToString("N0") + " VNĐ";

            // Sau khi tổng kết thì đưa thống kê về 0
            tongSoLuotKhach = 0;
            tongDoanhThu = 0;

            // Khóa nút Tổng kết
            btnTongKet.Enabled = false;
        }

        // Xử lý nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng chương trình
            this.Close();
        }

        // Xác nhận trước khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình hay không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Không thì hủy thao tác đóng Form
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}