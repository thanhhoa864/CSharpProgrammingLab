
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace bai01_BTNC_SQL
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến database QLSinhVien
        private string connectionString =
    @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ngaySinhStr = mtxtNgaySinh.Text.Trim();

            if (maLop == "" || maSV == "" || hoTen == "" ||
                !mtxtNgaySinh.MaskCompleted)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!DateTime.TryParseExact(
                ngaySinhStr, "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO dbo.SinhVien " +
                        "(MaLop, MaSV, TenSV, NgaySinh) " +
                        "VALUES (@MaLop, @MaSV, @TenSV, @NgaySinh)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@TenSV", hoTen);
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                            .Value = ngaySinh.Date;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm sinh viên thành công!");
                            XoaTrang();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                        MessageBox.Show("Mã sinh viên đã tồn tại!");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        // Xóa sinh viên
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (maSV == "" || hoTen == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên sinh viên!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "DELETE FROM dbo.SinhVien " +
                        "WHERE MaSV = @MaSV AND TenSV = @TenSV";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@TenSV", hoTen);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa sinh viên thành công!");
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên phù hợp!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        // Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            bool coNgaySinh = mtxtNgaySinh.MaskCompleted;

            if (maSV == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên cần sửa!");
                return;
            }

            if (maLop == "" && hoTen == "" && !coNgaySinh)
            {
                MessageBox.Show("Vui lòng nhập thông tin cần cập nhật!");
                return;
            }

            List<string> danhSachSua = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaSV", maSV);

                if (maLop != "")
                {
                    danhSachSua.Add("MaLop = @MaLop");
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                }

                if (hoTen != "")
                {
                    danhSachSua.Add("TenSV = @TenSV");
                    cmd.Parameters.AddWithValue("@TenSV", hoTen);
                }

                if (coNgaySinh)
                {
                    if (!DateTime.TryParseExact(
                        mtxtNgaySinh.Text.Trim(), "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime ngaySinh))
                    {
                        MessageBox.Show("Ngày sinh không hợp lệ!");
                        return;
                    }

                    danhSachSua.Add("NgaySinh = @NgaySinh");
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date)
                        .Value = ngaySinh.Date;
                }

                cmd.CommandText = "UPDATE dbo.SinhVien SET " +
                    string.Join(", ", danhSachSua) +
                    " WHERE MaSV = @MaSV";

                try
                {
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Sửa thông tin thành công!");
                        XoaTrang();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message);
                }
            }
        }

        // Xóa trắng các ô nhập
        private void XoaTrang()
        {
            txtMaLop.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            mtxtNgaySinh.Clear();
            txtMaLop.Focus();
        }
    }
}
