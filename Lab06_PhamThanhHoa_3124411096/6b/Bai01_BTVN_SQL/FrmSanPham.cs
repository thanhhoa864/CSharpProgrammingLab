using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai01_BTVN_SQL
{
    public partial class FrmSanPham : Form
    {
        
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLCuaHang;Integrated Security=True;TrustServerCertificate=True;";

        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtTen.MaxLength = 100;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            string tenSP = txtTen.Text.Trim();
            if (tenSP == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    // Hai bảng phải được lưu cùng nhau; lỗi một bước thì hoàn tác.
                    using (SqlTransaction giaoDich = conn.BeginTransaction())
                    {
                        try
                        {
                            // OUTPUT trả về đúng mã sản phẩm vừa được SQL Server tạo.
                            string sql = @"INSERT INTO dbo.SANPHAM (TenSP)
                                           OUTPUT INSERTED.MaSP VALUES (@TenSP)";
                            SqlCommand cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@TenSP", tenSP);
                            int maSP = Convert.ToInt32(cmd.ExecuteScalar());

                            // Sản phẩm mới có tồn đầu, nhập và bán đều bằng 0.
                            sql = @"INSERT INTO dbo.TONKHO (MaSP,NgayTon,SLDau,SLNhap,SLBan)
                                    VALUES (@MaSP,@Ngay,0,0,0)";
                            cmd = new SqlCommand(sql, conn, giaoDich);
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@Ngay", DateTime.Today);
                            cmd.ExecuteNonQuery();

                            giaoDich.Commit();
                            MessageBox.Show("Thêm sản phẩm thành công. Mã sản phẩm: " + maSP);
                            txtTen.Clear();
                            txtTen.Focus();
                        }
                        catch
                        {
                            giaoDich.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thêm được sản phẩm: " + ex.Message);
            }
        }

    }
}
