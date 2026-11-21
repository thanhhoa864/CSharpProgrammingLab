
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bai01_BTTL_SQL
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối đến database QLSinhVien
        private string ketNoi =
            @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Thêm môn học
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim();
            string tenMH = txtTenMH.Text.Trim();

            if (maMH == "" || tenMH == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO dbo.MonHoc (MaMH, TenMH) VALUES (@MaMH, @TenMH)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@TenMH", tenMH);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm môn học thành công!");
                    XoaTrang();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627 || ex.Number == 2601)
                        MessageBox.Show("Mã môn học đã tồn tại!");
                    else
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                }
            }
        }

        // Xóa môn học
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim();

            if (maMH == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?",
                "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open();

                    string sql = "DELETE FROM dbo.MonHoc WHERE MaMH = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", maMH);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Xóa môn học thành công!");
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy môn học!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        // Sửa môn học
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text.Trim();
            string tenMH = txtTenMH.Text.Trim();

            if (maMH == "" || tenMH == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE dbo.MonHoc SET TenMH = @TenMH WHERE MaMH = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@TenMH", tenMH);

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Sửa môn học thành công!");
                            XoaTrang();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy môn học!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa: " + ex.Message);
                }
            }
        }

        // Xóa trắng các ô nhập
        private void XoaTrang()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtMaMH.Focus();
        }
    }
}