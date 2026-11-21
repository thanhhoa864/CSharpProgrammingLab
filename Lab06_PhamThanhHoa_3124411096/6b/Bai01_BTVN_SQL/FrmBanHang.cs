using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai01_BTVN_SQL
{
    public partial class FrmBanHang : Form
    {
        
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        public FrmBanHang()
        {
            InitializeComponent();
        }

        private int maHoaDon = 0;
        private DateTime ngayHoaDon;

        // Bật/tắt các ô nhập và nút khi có hoặc chưa có hóa đơn.
        private void BatTatNhap(bool choNhap)
        {
            txtHD.Enabled = choNhap;
            cboSP.Enabled = choNhap;
            txtSL.Enabled = choNhap;
            btnThem.Enabled = choNhap;
            btnHuy.Enabled = choNhap;
            btnThanhToan.Enabled = choNhap;
            btnMoi.Enabled = !choNhap;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            BatTatNhap(false);
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaSP FROM dbo.SANPHAM ORDER BY MaSP", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboSP.Items.Add(reader["MaSP"].ToString());
                        }
                    }
                    if (cboSP.Items.Count > 0)
                    {
                        cboSP.SelectedIndex = 0;
                    }

                    // Mở lại hóa đơn đang làm nếu lần trước chương trình tắt đột ngột.
                    string sql = @"SELECT TOP 1 MaHD, NgayTao FROM dbo.HOADON
                                   WHERE TinhTrangThanhToan=0 ORDER BY MaHD";
                    cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maHoaDon = Convert.ToInt32(reader["MaHD"]);
                            ngayHoaDon = Convert.ToDateTime(reader["NgayTao"]);
                            txtHD.Text = maHoaDon.ToString();
                            BatTatNhap(true);
                            MessageBox.Show("Tiếp tục hóa đơn chưa thanh toán số " + maHoaDon);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message);
            }
        }

        private void Moi_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    // So sánh số sản phẩm và số dòng tồn hôm nay trước khi bán.
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.SANPHAM", conn);
                    int soSanPham = Convert.ToInt32(cmd.ExecuteScalar());
                    string sql = "SELECT COUNT(*) FROM dbo.TONKHO WHERE NgayTon=@Ngay";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ngay", DateTime.Today);
                    int soDongTon = Convert.ToInt32(cmd.ExecuteScalar());
                    if (soSanPham == 0 || soDongTon != soSanPham)
                    {
                        MessageBox.Show("Hãy tạo tồn kho hôm nay cho tất cả sản phẩm trước khi bán.");
                        return;
                    }

                    // SQL Server tự tăng mã; OUTPUT lấy mã vừa thêm để hiện trên form.
                    sql = @"INSERT INTO dbo.HOADON (NgayTao,TinhTrangThanhToan)
                            OUTPUT INSERTED.MaHD VALUES (@Ngay,0)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ngay", DateTime.Today);
                    maHoaDon = Convert.ToInt32(cmd.ExecuteScalar());
                    ngayHoaDon = DateTime.Today;
                    txtHD.Text = maHoaDon.ToString();
                    txtSL.Clear();
                    BatTatNhap(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tạo được hóa đơn: " + ex.Message);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (cboSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }
            int soLuong;
            if (!int.TryParse(txtSL.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0.");
                return;
            }
            if (ngayHoaDon.Date != DateTime.Today)
            {
                MessageBox.Show("Hóa đơn ngày cũ chỉ được thanh toán hoặc hủy.");
                return;
            }
            int maSP = Convert.ToInt32(cboSP.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    // Kiểm tra hóa đơn chưa thanh toán.
                    string sql = "SELECT COUNT(*) FROM dbo.HOADON WHERE MaHD=@MaHD AND TinhTrangThanhToan=0";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Hóa đơn không tồn tại hoặc đã thanh toán.");
                        return;
                    }

                    // Kiểm tra khóa ngoại: sản phẩm phải có trong bảng SANPHAM.
                    sql = "SELECT COUNT(*) FROM dbo.SANPHAM WHERE MaSP=@MaSP";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Mã sản phẩm không tồn tại.");
                        return;
                    }

                    // Kiểm tra khóa chính ghép: một sản phẩm chỉ có một dòng trong hóa đơn.
                    sql = "SELECT COUNT(*) FROM dbo.CHITIET_HOADON WHERE MaHD=@MaHD AND MaSP=@MaSP";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                    cmd.Parameters.AddWithValue("@MaSP", maSP);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("Sản phẩm này đã có trong hóa đơn.");
                        return;
                    }

                    using (SqlTransaction giaoDich = conn.BeginTransaction())
                    {
                        try
                        {
                            // Bán hàng thì tổng đã bán tăng. Điều kiện giữ đúng chữ "nhỏ hơn" của đề.
                            sql = @"UPDATE dbo.TONKHO SET SLBan=SLBan+@SoLuong
                                    WHERE MaSP=@MaSP AND NgayTon=@Ngay
                                    AND @SoLuong < SLDau+SLNhap-SLBan";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@Ngay", ngayHoaDon.Date);
                            int soDong = cmd.ExecuteNonQuery();
                            if (soDong == 0)
                            {
                                giaoDich.Rollback();
                                MessageBox.Show("Chưa có tồn kho hoặc số lượng bán không nhỏ hơn lượng tồn.");
                                return;
                            }

                            sql = @"INSERT INTO dbo.CHITIET_HOADON (MaHD,MaSP,SoLuong)
                                    VALUES (@MaHD,@MaSP,@SoLuong)";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmd.ExecuteNonQuery();

                            giaoDich.Commit();
                            MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công.");
                            txtSL.Clear();
                        }
                        catch
                        {
                            giaoDich.Rollback(); // Nếu không thêm được chi tiết thì hoàn lại số lượng bán.
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được chi tiết hóa đơn: " + ex.Message);
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM dbo.CHITIET_HOADON WHERE MaHD=@MaHD";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Hóa đơn chưa có sản phẩm.");
                        return;
                    }

                    // Đã ghi nhận số lượng lúc thêm hàng nên không tăng SLBan lần nữa.
                    sql = "UPDATE dbo.HOADON SET TinhTrangThanhToan=1 WHERE MaHD=@MaHD AND TinhTrangThanhToan=0";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong == 0)
                    {
                        MessageBox.Show("Hóa đơn không tồn tại hoặc đã thanh toán.");
                        return;
                    }
                    maHoaDon = 0;
                    txtHD.Clear();
                    txtSL.Clear();
                    BatTatNhap(false);
                    MessageBox.Show("Thanh toán thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thanh toán được: " + ex.Message);
            }
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn hủy hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                HuyHoaDon();
            }
        }

        // Trả về true khi hủy thành công, dùng cho nút Hủy và lúc đóng form.
        private bool HuyHoaDon()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM dbo.HOADON WHERE MaHD=@MaHD AND TinhTrangThanhToan=0";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                    {
                        MessageBox.Show("Chỉ hủy được hóa đơn chưa thanh toán.");
                        return false;
                    }

                    using (SqlTransaction giaoDich = conn.BeginTransaction())
                    {
                        try
                        {
                            // Dùng bảng chi tiết để trả lại số lượng đã ghi nhận bán.
                            sql = @"UPDATE t SET t.SLBan=t.SLBan-c.SoLuong
                                    FROM dbo.TONKHO t JOIN dbo.CHITIET_HOADON c ON t.MaSP=c.MaSP
                                    WHERE c.MaHD=@MaHD AND t.NgayTon=@Ngay";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                            cmd.Parameters.AddWithValue("@Ngay", ngayHoaDon.Date);
                            cmd.ExecuteNonQuery();

                            // Xóa bảng con trước, bảng cha sau để không vi phạm khóa ngoại.
                            sql = "DELETE FROM dbo.CHITIET_HOADON WHERE MaHD=@MaHD";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                            cmd.ExecuteNonQuery();

                            sql = "DELETE FROM dbo.HOADON WHERE MaHD=@MaHD AND TinhTrangThanhToan=0";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@MaHD", maHoaDon);
                            int soDong = cmd.ExecuteNonQuery();
                            if (soDong == 0)
                            {
                                giaoDich.Rollback();
                                MessageBox.Show("Hóa đơn đã thay đổi, không thể hủy.");
                                return false;
                            }
                            giaoDich.Commit();
                        }
                        catch
                        {
                            giaoDich.Rollback();
                            throw;
                        }
                    }
                }
                maHoaDon = 0;
                txtHD.Clear();
                txtSL.Clear();
                BatTatNhap(false);
                MessageBox.Show("Hủy hóa đơn thành công.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không hủy được hóa đơn: " + ex.Message);
                return false;
            }
        }

        private void DongForm(object sender, FormClosingEventArgs e)
        {
            if (maHoaDon == 0)
            {
                return;
            }
            DialogResult chon = MessageBox.Show("Hóa đơn chưa thanh toán. Hủy hóa đơn để đóng form?", "Xác nhận", MessageBoxButtons.YesNo);
            if (chon == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            if (!HuyHoaDon())
            {
                e.Cancel = true;
            }
        }

    }
}
