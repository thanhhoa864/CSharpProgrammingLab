using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai01_BTVN_SQL
{
    public partial class Form1 : Form
    {
       
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void SanPham_Click(object sender, EventArgs e)
        {
            using (FrmSanPham form = new FrmSanPham())
            {
                form.ShowDialog();
            }
        }

        private void BanHang_Click(object sender, EventArgs e)
        {
            using (FrmBanHang form = new FrmBanHang())
            {
                form.ShowDialog();
            }
        }

        private void TonKho_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    DateTime homNay = DateTime.Today;

                    // Phải xử lý xong hóa đơn ngày cũ trước khi chuyển tồn sang ngày mới.
                    string sql = @"SELECT COUNT(*) FROM dbo.HOADON
                                   WHERE NgayTao < @Ngay AND TinhTrangThanhToan = 0";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ngay", homNay);
                    int soHoaDonCu = Convert.ToInt32(cmd.ExecuteScalar());
                    if (soHoaDonCu > 0)
                    {
                        MessageBox.Show("Còn hóa đơn ngày cũ chưa thanh toán. Hãy mở Bán hàng để thanh toán hoặc hủy.");
                        return;
                    }

                    // Lưu danh sách mã trước rồi đóng reader để thực hiện các lệnh khác.
                    List<int> danhSachMa = new List<int>();
                    cmd = new SqlCommand("SELECT MaSP FROM dbo.SANPHAM ORDER BY MaSP", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            danhSachMa.Add(Convert.ToInt32(reader["MaSP"]));
                        }
                    }
                    if (danhSachMa.Count == 0)
                    {
                        MessageBox.Show("Chưa có sản phẩm để tạo tồn kho.");
                        return;
                    }

                    // Giao dịch giúp hoàn tác nếu đang tạo tồn mà có lỗi.
                    using (SqlTransaction giaoDich = conn.BeginTransaction())
                    {
                        try
                        {
                            int soDongThem = 0;
                            foreach (int maSP in danhSachMa)
                            {
                                sql = "SELECT COUNT(*) FROM dbo.TONKHO WHERE MaSP=@MaSP AND NgayTon=@Ngay";
                                cmd = new SqlCommand(sql, conn, giaoDich);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.Parameters.AddWithValue("@Ngay", homNay);
                                int soDong = Convert.ToInt32(cmd.ExecuteScalar());
                                if (soDong > 0)
                                {
                                    continue; // Đã tạo hôm nay thì không ghi đè.
                                }

                                // Lấy số lượng còn lại của ngày gần nhất trước hôm nay.
                                sql = @"SELECT TOP 1 SLDau + SLNhap - SLBan
                                        FROM dbo.TONKHO
                                        WHERE MaSP=@MaSP AND NgayTon < @Ngay
                                        ORDER BY NgayTon DESC";
                                cmd = new SqlCommand(sql, conn, giaoDich);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.Parameters.AddWithValue("@Ngay", homNay);
                                object ketQua = cmd.ExecuteScalar();
                                int tonDau = 0;
                                if (ketQua != null)
                                {
                                    tonDau = Convert.ToInt32(ketQua);
                                }

                                sql = @"INSERT INTO dbo.TONKHO (MaSP,NgayTon,SLDau,SLNhap,SLBan)
                                        VALUES (@MaSP,@Ngay,@SLDau,0,0)";
                                cmd = new SqlCommand(sql, conn, giaoDich);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.Parameters.AddWithValue("@Ngay", homNay);
                                cmd.Parameters.AddWithValue("@SLDau", tonDau);
                                cmd.ExecuteNonQuery();
                                soDongThem++;
                            }
                            giaoDich.Commit(); // Không có lỗi thì lưu tất cả thay đổi.
                            if (soDongThem > 0)
                            {
                                MessageBox.Show("Tạo tồn kho thành công.");
                            }
                            else
                            {
                                MessageBox.Show("Tồn kho hôm nay đã được tạo rồi.");
                            }
                        }
                        catch
                        {
                            giaoDich.Rollback(); // Có lỗi thì không lưu phần đang làm dở.
                            throw; // Chuyển lỗi xuống catch bên ngoài để hiện thông báo.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tạo được tồn kho: " + ex.Message);
            }
        }

    }
}
