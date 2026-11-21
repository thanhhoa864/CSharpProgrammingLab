using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Bai2_QuanLyDiem
{
    public partial class Form1 : Form
    {
        // Kết nối đến database đã có của bạn.
        private readonly string ketNoi =
            @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_LabSau;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Kiểm tra hai mã bắt buộc dùng để xác định một dòng điểm.
        private bool KiemTraMa(out string maSV, out string maMH)
        {
            maSV = txtMaSV.Text.Trim();
            maMH = txtMaMH.Text.Trim();
            errorProvider1.Clear();

            if (maSV == "")
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được để trống!");
                txtMaSV.Focus();
                return false;
            }

            if (maMH == "")
            {
                errorProvider1.SetError(txtMaMH, "Mã môn học không được để trống!");
                txtMaMH.Focus();
                return false;
            }

            return true;
        }

        // Đề yêu cầu điểm phải được nhập bằng số.
        private bool KiemTraDiem(out double diem)
        {
            string chuoiDiem = txtDiem.Text.Trim();

            bool hopLe = double.TryParse(chuoiDiem, NumberStyles.Float,
                CultureInfo.CurrentCulture, out diem);

            if (!hopLe)
            {
                hopLe = double.TryParse(chuoiDiem, NumberStyles.Float,
                    CultureInfo.InvariantCulture, out diem);
            }

            if (!hopLe)
            {
                diem = 0;
                errorProvider1.SetError(txtDiem, "Điểm phải là số!");
                txtDiem.Focus();
                return false;
            }

            if (diem < 0 || diem > 10)
            {
                errorProvider1.SetError(txtDiem, "Điểm phải từ 0 đến 10!");
                txtDiem.Focus();
                return false;
            }

            return true;
        }

        // Thêm điểm theo cặp Mã SV + Mã MH.
        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!KiemTraMa(out string maSV, out string maMH))
                return;

            if (txtDiem.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiem, "Vui lòng nhập điểm!");
                txtDiem.Focus();
                return;
            }

            if (!KiemTraDiem(out double diem))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    string sql = @"INSERT INTO dbo.Diem (MaSV, MaMH, Diem)
                                   VALUES (@MaSV, @MaMH, @Diem)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm điểm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaNoiDung();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    errorProvider1.SetError(txtMaMH,
                        "Sinh viên này đã có điểm cho môn học này!");
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa dòng điểm theo cả Mã SV và Mã MH.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!KiemTraMa(out string maSV, out string maMH))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    string sql = @"DELETE FROM dbo.Diem
                                   WHERE MaSV = @MaSV AND MaMH = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);

                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong > 0)
                        {
                            MessageBox.Show("Xóa điểm thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaNoiDung();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dòng điểm phù hợp.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sửa điểm; Mã SV và Mã MH xác định dòng cần cập nhật.
        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!KiemTraMa(out string maSV, out string maMH))
                return;

            if (txtDiem.Text.Trim() == "")
            {
                errorProvider1.SetError(txtDiem, "Vui lòng nhập điểm cần sửa!");
                txtDiem.Focus();
                return;
            }

            if (!KiemTraDiem(out double diem))
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();

                    string sql = @"UPDATE dbo.Diem
                                   SET Diem = @Diem
                                   WHERE MaSV = @MaSV AND MaMH = @MaMH";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaMH", maMH);
                        cmd.Parameters.AddWithValue("@Diem", diem);

                        int soDong = cmd.ExecuteNonQuery();

                        if (soDong > 0)
                        {
                            MessageBox.Show("Sửa điểm thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaNoiDung();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dòng điểm phù hợp.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa nội dung các ô sau khi thao tác thành công.
        private void XoaNoiDung()
        {
            txtMaSV.Clear();
            txtMaMH.Clear();
            txtDiem.Clear();
            errorProvider1.Clear();
            txtMaSV.Focus();
        }
    }
}
