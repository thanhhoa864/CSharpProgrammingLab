using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace bai02_BTNC_SQL
{
    public partial class Form1 : Form
    {
        // Kết nối đến cơ sở dữ liệu SQL Server
        private string connectionString =
            @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. CHỨC NĂNG THÊM DỮ LIỆU
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();
            string diemStr = txtDiem.Text.Trim();

            // Yêu cầu: Mã sinh viên, Mã môn học, Điểm không được để trống
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm phải là số từ 0 đến 10
            if (!TryParseDiem(diemStr, out decimal diem))
            {
                MessageBox.Show("Điểm phải là số hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO dbo.Diem (MaSV, MaMH, Diem) VALUES (@MaSV, @MaMH, @Diem)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        ThemThamSoDiem(cmd, diem);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Thêm điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrang();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601) // Trùng khóa chính (MaSV + MaMH)
                    {
                        MessageBox.Show("Điểm của sinh viên này cho môn học tương ứng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Number == 547) // Vi phạm khóa ngoại
                    {
                        MessageBox.Show("Mã sinh viên hoặc Mã môn học không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 2. CHỨC NĂNG XÓA DỮ LIỆU
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();

            // Yêu cầu: Mã sinh viên, Mã môn học không được để trống, Điểm không nhập dữ liệu
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH))
            {
                MessageBox.Show("Mã sinh viên và Mã môn học không được để trống khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtDiem.Text.Trim()))
            {
                MessageBox.Show("Khi xóa không cần nhập ô Điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa điểm môn [{maMH}] của sinh viên [{maSV}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM dbo.Diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu điểm tương ứng với Mã SV và Mã MH vừa nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 3. CHỨC NĂNG SỬA DỮ LIỆU
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string maMH = txtMaMH.Text.Trim();
            string diemStr = txtDiem.Text.Trim();

            // Yêu cầu: Mã sinh viên, Mã môn học không được để trống, Điểm phải được nhập và chỉ được nhập số
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(maMH) || string.IsNullOrEmpty(diemStr))
            {
                MessageBox.Show("Mã sinh viên, Mã môn học và Điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TryParseDiem(diemStr, out decimal diem))
            {
                MessageBox.Show("Điểm sửa phải là số hợp lệ từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE dbo.Diem SET Diem = @Diem WHERE MaSV = @MaSV AND MaMH = @MaMH";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        ThemThamSoDiem(cmd, diem);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu điểm tương ứng với Mã SV và Mã MH vừa nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Chuyển chuỗi thành điểm (0 - 10, tối đa 2 chữ số thập phân).
        // Chấp nhận cả "8.5" lẫn "8,5", không phụ thuộc cấu hình vùng của Windows.
        private bool TryParseDiem(string text, out decimal diem)
        {
            text = text.Replace(',', '.');

            if (decimal.TryParse(text, NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture, out diem)
                && diem >= 0 && diem <= 10)
            {
                diem = Math.Round(diem, 2);
                return true;
            }

            return false;
        }

        // Thêm tham số @Diem kiểu DECIMAL(4,2), khớp với cột Diem trong bảng dbo.Diem
        private void ThemThamSoDiem(SqlCommand cmd, decimal diem)
        {
            SqlParameter p = cmd.Parameters.Add("@Diem", SqlDbType.Decimal);
            p.Precision = 4;
            p.Scale = 2;
            p.Value = diem;
        }

        private void XoaTrang()
        {
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }
    }
}