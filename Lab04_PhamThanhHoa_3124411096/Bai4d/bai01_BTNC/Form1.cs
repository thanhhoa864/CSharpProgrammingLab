using System;
using System.Windows.Forms;

namespace bai01_BTNC
{
    public partial class Form1 : Form
    {
        // Lưu tổng số khách hàng đã thanh toán
        private int tongSoKhach = 0;

        // Lưu tổng doanh thu của tất cả khách hàng
        private double tongTienDoanhThu = 0;

        // Lưu số tiền của nhóm khách hàng hiện tại
        private double tienHienTai = 0;

        // Lưu số lượng khách của nhóm hiện tại
        private int soKhachHienTai = 0;

        // Hàm khởi tạo Form
        public Form1()
        {
            InitializeComponent();
        }

        // Thiết lập trạng thái ban đầu khi Form được mở
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đưa con trỏ vào ô tên khách hàng
            txtTenKhachHang.Focus();

            // Các nút chưa được sử dụng sẽ bị vô hiệu hóa
            btnTinhTien.Enabled = false;
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;

            // Hiển thị thống kê ban đầu
            txtTongKhachHang.Text = "0";
            txtTongTienThanhToan.Text = "0 VNĐ";
        }

        // Chỉ cho phép nhập số vào ô số khách hàng
        private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím điều khiển như Backspace
            // và các ký tự từ 0 đến 9
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Kiểm tra khách hàng đã chọn món hay chưa
        private bool CoMonDuocChon()
        {
            // Kiểm tra nhóm đồ uống
            bool coNuoc =
                radCafeDen.Checked ||
                radCafeDa.Checked ||
                radCafeSua.Checked ||
                radCafeSuaDa.Checked ||
                radCafeKem.Checked;

            // Kiểm tra nhóm thức ăn
            bool coThucAn =
                chkBanhMyTrung.Checked ||
                chkBanhMyCa.Checked ||
                chkMyTomTrung.Checked ||
                chkMyXaoBo.Checked ||
                chkMyCay.Checked;

            // Chỉ cần có đồ uống hoặc thức ăn là hợp lệ
            return coNuoc || coThucAn;
        }

        // Kiểm tra dữ liệu để bật hoặc tắt nút Tính Tiền
        private void DuLieu_ThayDoi(object sender, EventArgs e)
        {
            // Kiểm tra đã nhập tên khách hàng
            bool coTen =
                !string.IsNullOrWhiteSpace(txtTenKhachHang.Text);

            // Kiểm tra đã nhập số khách hàng
            bool coSoKhach =
                !string.IsNullOrWhiteSpace(txtSoKhachHang.Text);

            // Kiểm tra đã chọn món
            bool coMon = CoMonDuocChon();

            // Chỉ bật nút khi đủ cả 3 điều kiện
            btnTinhTien.Enabled = coTen && coSoKhach && coMon;
        }

        // Thực hiện tính tiền cho nhóm khách hàng hiện tại
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Kiểm tra số lượng khách hàng
            if (!int.TryParse(
                    txtSoKhachHang.Text.Trim(),
                    out soKhachHienTai) ||
                soKhachHienTai <= 0)
            {
                MessageBox.Show(
                    "Số khách hàng phải là một số nguyên dương (> 0)!",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Đưa con trỏ về ô số khách hàng
                txtSoKhachHang.Focus();
                return;
            }

            // Biến lưu tổng tiền các món đã chọn
            double tongTienMon = 0;

            // Tính tiền đồ uống
            if (radCafeDen.Checked)
            {
                tongTienMon += 20000;
            }
            else if (radCafeDa.Checked)
            {
                tongTienMon += 25000;
            }
            else if (radCafeSua.Checked)
            {
                tongTienMon += 25000;
            }
            else if (radCafeSuaDa.Checked)
            {
                tongTienMon += 30000;
            }
            else if (radCafeKem.Checked)
            {
                tongTienMon += 35000;
            }

            // Tính tiền các món ăn
            if (chkBanhMyTrung.Checked)
            {
                tongTienMon += 15000;
            }

            if (chkBanhMyCa.Checked)
            {
                tongTienMon += 15000;
            }

            if (chkMyTomTrung.Checked)
            {
                tongTienMon += 20000;
            }

            if (chkMyXaoBo.Checked)
            {
                tongTienMon += 30000;
            }

            if (chkMyCay.Checked)
            {
                tongTienMon += 50000;
            }

            // Tính số tiền được giảm cho sinh viên
            double giamGia = 0;

            if (chkSinhVien.Checked)
            {
                // Sinh viên được giảm 20%
                giamGia = tongTienMon * 0.2;
            }

            // Tính số tiền cuối cùng cần thanh toán
            tienHienTai = tongTienMon - giamGia;

            // Tạo nội dung thông báo thanh toán
            string thongBao =
                $"Khách hàng: {txtTenKhachHang.Text.Trim()}\n" +
                $"Số khách: {soKhachHienTai}\n" +
                $"Tổng tiền gốc: {tongTienMon:N0} VNĐ\n" +
                $"Giảm giá sinh viên (20%): {giamGia:N0} VNĐ\n" +
                $"------------------------------------\n" +
                $"Số tiền cần thanh toán: {tienHienTai:N0} VNĐ";

            // Hiển thị thông tin thanh toán
            MessageBox.Show(
                thongBao,
                "Thông tin thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Sau khi tính tiền thì cho phép nhập lại hoặc thanh toán
            btnNhapLai.Enabled = true;
            btnThanhToan.Enabled = true;
        }

        // Xóa thông tin nhóm khách hàng hiện tại
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            // Gọi hàm xóa dữ liệu
            XoaTrangThongTinKhach();

            // Khóa lại các nút chức năng
            btnNhapLai.Enabled = false;
            btnThanhToan.Enabled = false;
            btnTinhTien.Enabled = false;
        }

        // Xóa toàn bộ thông tin khách hàng hiện tại
        private void XoaTrangThongTinKhach()
        {
            // Xóa thông tin cơ bản
            txtTenKhachHang.Clear();
            txtSoKhachHang.Clear();

            // Bỏ chọn giảm giá sinh viên
            chkSinhVien.Checked = false;

            // Bỏ chọn tất cả đồ uống
            radCafeDen.Checked = false;
            radCafeDa.Checked = false;
            radCafeSua.Checked = false;
            radCafeSuaDa.Checked = false;
            radCafeKem.Checked = false;

            // Bỏ chọn tất cả thức ăn
            chkBanhMyTrung.Checked = false;
            chkBanhMyCa.Checked = false;
            chkMyTomTrung.Checked = false;
            chkMyXaoBo.Checked = false;
            chkMyCay.Checked = false;

            // Đưa các biến của khách hiện tại về ban đầu
            tienHienTai = 0;
            soKhachHienTai = 0;

            // Đưa con trỏ về ô tên khách hàng
            txtTenKhachHang.Focus();
        }

        // Thực hiện thanh toán và cập nhật thống kê
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Cộng số khách hiện tại vào tổng số khách
            tongSoKhach += soKhachHienTai;

            // Cộng tiền hiện tại vào tổng doanh thu
            tongTienDoanhThu += tienHienTai;

            // Cập nhật tổng số khách lên giao diện
            txtTongKhachHang.Text =
                tongSoKhach.ToString();

            // Cập nhật tổng tiền thanh toán
            txtTongTienThanhToan.Text =
                tongTienDoanhThu.ToString("N0") + " VNĐ";

            // Xóa dữ liệu để chuẩn bị cho nhóm khách tiếp theo
            XoaTrangThongTinKhach();

            // Tắt các nút sau khi thanh toán
            btnThanhToan.Enabled = false;
            btnNhapLai.Enabled = false;
            btnTinhTien.Enabled = false;
        }

        // Xử lý nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Đóng Form
            this.Close();
        }

        // Xác nhận trước khi đóng chương trình
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult dialog = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình hay không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn Không thì không đóng Form
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}