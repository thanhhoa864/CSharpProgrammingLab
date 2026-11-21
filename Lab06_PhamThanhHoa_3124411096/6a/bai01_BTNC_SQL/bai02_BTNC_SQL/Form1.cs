using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bai02_BTNC_SQL
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến database QLSinhVien_LabSau
        private string ketNoi =
            @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_LabSau;Integrated Security=True;TrustServerCertificate=True";

        // Biến cờ để tránh lỗi khi xử lý ngày sinh
        private bool dangXuLyNgaySinh = false;

        public Form1()
        {
            InitializeComponent();

            txtNgaySinh.Text = "";
            txtNgaySinh.TextChanged += txtNgaySinh_TextChanged;
        }

        // Chức năng thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa thông báo lỗi cũ
            errorProvider1.Clear();

            // Lấy dữ liệu từ các ô nhập
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ngaySinh = txtNgaySinh.Text.Trim();

            // Kiểm tra các trường không được để trống
            if (maLop == "")
                errorProvider1.SetError(txtMaLop, "Vui lòng nhập mã lớp!");

            if (maSV == "")
                errorProvider1.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");

            if (hoTen == "")
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập họ tên!");

            if (ngaySinh == "")
                errorProvider1.SetError(txtNgaySinh, "Vui lòng nhập ngày sinh!");

            // Nếu có trường trống thì dừng
            if (maLop == "" || maSV == "" ||
                hoTen == "" || ngaySinh == "")
                return;

            // Kiểm tra ngày sinh có hợp lệ không
            if (!DateTime.TryParse(ngaySinh, out DateTime ngaySinhHopLe))
            {
                errorProvider1.SetError(
                    txtNgaySinh, "Ngày sinh không hợp lệ!");
                return;
            }

            try
            {
                // Mở kết nối database
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    // Câu lệnh thêm sinh viên
                    string sql = @"INSERT INTO dbo.SinhVien
                                   (MaSV, MaLop, HoTen, NgaySinh)
                                   VALUES
                                   (@MaSV, @MaLop, @HoTen, @NgaySinh)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Truyền dữ liệu vào các tham số SQL
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue(
                            "@NgaySinh", ngaySinhHopLe.Date);

                        // Thực thi câu lệnh INSERT
                        cmd.ExecuteNonQuery();
                    }
                }

                // Thông báo khi thêm thành công
                MessageBox.Show("Thêm sinh viên thành công!");

                // Xóa nội dung sau khi thêm
                txtMaLop.Clear();
                txtMaSV.Clear();
                txtHoTen.Clear();
                txtNgaySinh.Clear();
                txtMaLop.Focus();
            }
            catch (SqlException ex)
            {
                // Xử lý trường hợp mã sinh viên bị trùng
                if (ex.Number == 2627 || ex.Number == 2601)
                    errorProvider1.SetError(
                        txtMaSV, "Mã sinh viên đã tồn tại!");
                else
                    MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chức năng xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Lấy mã sinh viên và họ tên để xác định sinh viên
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            // Theo yêu cầu đề bài, hai trường này không được trống
            if (maSV == "")
                errorProvider1.SetError(
                    txtMaSV, "Vui lòng nhập mã sinh viên!");

            if (hoTen == "")
                errorProvider1.SetError(
                    txtHoTen, "Vui lòng nhập họ tên!");

            if (maSV == "" || hoTen == "")
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    // Chỉ xóa khi mã sinh viên và họ tên cùng khớp
                    string sql = @"DELETE FROM dbo.SinhVien
                                   WHERE MaSV = @MaSV AND HoTen = @HoTen";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);

                        // Số dòng bị xóa
                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong > 0)
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");

                            // Xóa nội dung trên giao diện
                            txtMaLop.Clear();
                            txtMaSV.Clear();
                            txtHoTen.Clear();
                            txtNgaySinh.Clear();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên phù hợp!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Chức năng sửa sinh viên

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            // Mã sinh viên bắt buộc phải có để xác định sinh viên cần sửa
            if (txtMaSV.Text.Trim() == "")
            {
                errorProvider1.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!");
                txtMaSV.Focus();
                return;
            }

            // Phải nhập ít nhất một trong ba trường cần cập nhật
            if (txtMaLop.Text.Trim() == "" &&
                txtHoTen.Text.Trim() == "" &&
                txtNgaySinh.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtMaLop,
                    "Vui lòng nhập ít nhất một trường cần sửa!"
                );
                return;
            }

            // Kiểm tra ngày sinh nếu người dùng có nhập
            DateTime ngaySinh = DateTime.MinValue;
            if (txtNgaySinh.Text.Trim() != "" &&
                !DateTime.TryParseExact(
                    txtNgaySinh.Text.Trim(),
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out ngaySinh))
            {
                errorProvider1.SetError(
                    txtNgaySinh,
                    "Ngày sinh phải đúng định dạng dd/MM/yyyy!"
                );
                txtNgaySinh.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    // Chỉ cập nhật các trường được nhập.
                    // Trường để trống sẽ giữ nguyên giá trị trong cơ sở dữ liệu.
                    string sql = @"
                UPDATE dbo.SinhVien
                SET
                    MaLop = CASE
                        WHEN @MaLop <> '' THEN @MaLop
                        ELSE MaLop
                    END,
                    HoTen = CASE
                        WHEN @HoTen <> '' THEN @HoTen
                        ELSE HoTen
                    END,
                    NgaySinh = CASE
                        WHEN @NgaySinh <> '' THEN @NgaySinh
                        ELSE NgaySinh
                    END
                WHERE MaSV = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());

                        // Nếu không nhập ngày sinh thì truyền chuỗi rỗng
                        // để SQL giữ nguyên ngày sinh cũ.
                        if (txtNgaySinh.Text.Trim() == "")
                        {
                            cmd.Parameters.AddWithValue("@NgaySinh", "");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue(
                                "@NgaySinh",
                                ngaySinh.Date
                            );
                        }

                        int ketQua = cmd.ExecuteNonQuery();

                        if (ketQua > 0)
                        {
                            MessageBox.Show(
                                "Sửa thông tin sinh viên thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Không tìm thấy sinh viên có mã " +
                                txtMaSV.Text.Trim() + "!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi sửa sinh viên: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            if (dangXuLyNgaySinh)
                return;

            dangXuLyNgaySinh = true;

            // Lấy các ký tự số, bỏ dấu / và ký tự khác
            string ngay = "";
            foreach (char c in txtNgaySinh.Text)
            {
                if (char.IsDigit(c))
                    ngay += c;
            }

            // Chỉ cho nhập tối đa 8 chữ số: ddMMyyyy
            if (ngay.Length > 8)
                ngay = ngay.Substring(0, 8);

            // Tự thêm dấu / sau ngày và tháng
            if (ngay.Length > 4)
                ngay = ngay.Insert(4, "/");

            if (ngay.Length > 2)
                ngay = ngay.Insert(2, "/");

            txtNgaySinh.Text = ngay;

            // Đưa con trỏ về cuối ô nhập
            txtNgaySinh.SelectionStart = txtNgaySinh.Text.Length;

            dangXuLyNgaySinh = false;
        }
    }
}