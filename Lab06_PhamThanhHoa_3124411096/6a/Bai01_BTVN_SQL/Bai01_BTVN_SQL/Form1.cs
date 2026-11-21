using System.Data;
using System.Data.SqlClient;

namespace Bai01_BTVN_SQL
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối tới SQL Server (đúng theo đề bài)
        private const string ConnectionString =
            "Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_LabSau;Integrated Security=True;TrustServerCertificate=True";

        // Một số mã lỗi của SQL Server cần xử lý riêng
        private const int LoiTrungKhoaChinh = 2627;  // Vi phạm PRIMARY KEY / UNIQUE constraint
        private const int LoiTrungChiMuc = 2601;     // Trùng giá trị trong unique index
        private const int LoiKhoaNgoai = 547;        // Vi phạm FOREIGN KEY

        public Form1()
        {
            InitializeComponent();
        }

         
        // NÚT THÊM
         
        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaLoi();

            // 1. Kiểm tra dữ liệu nhập: cả 3 trường đều bắt buộc.
            //    Dùng toán tử &= để kiểm tra đủ cả 3 ô, ô nào lỗi sẽ hiện biểu tượng lỗi ở ô đó.
            bool hopLe = true;
            hopLe &= KiemTraMa(txtMaKhoa, "Mã khoa");
            hopLe &= KiemTraMa(txtMaLop, "Mã lớp");
            hopLe &= KiemTraBatBuoc(txtTenLop, "Tên lớp");
            if (!hopLe)
            {
                FocusOLoiDauTien();
                return;
            }

            string maKhoa = txtMaKhoa.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // 2. Mã lớp chưa được tồn tại
                    if (LopTonTai(conn, maLop))
                    {
                        errorProvider1.SetError(txtMaLop, "Mã lớp đã tồn tại.");
                        MessageBox.Show("Mã lớp \"" + maLop + "\" đã tồn tại. Không thể thêm.",
                            "Trùng mã lớp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLop.Focus();
                        return;
                    }

                    // 3. Mã khoa phải tồn tại trong bảng Khoa (tránh lỗi khóa ngoại)
                    if (!KhoaTonTai(conn, maKhoa))
                    {
                        errorProvider1.SetError(txtMaKhoa, "Mã khoa không tồn tại trong bảng Khoa.");
                        MessageBox.Show("Mã khoa \"" + maKhoa + "\" không tồn tại trong bảng Khoa. Không thể thêm lớp.",
                            "Mã khoa không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaKhoa.Focus();
                        return;
                    }

                    // 4. Dữ liệu hợp lệ -> thêm vào bảng dbo.Lop (dùng tham số, không nối chuỗi)
                    const string sql =
                        "INSERT INTO dbo.Lop (MaLop, MaKhoa, TenLop) VALUES (@MaLop, @MaKhoa, @TenLop)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                        cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = maKhoa;
                        cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100).Value = tenLop;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm lớp thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaNoiDung();
            }
            catch (SqlException ex)
            {
                XuLyLoiSql(ex, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         
        // NÚT XÓA (chỉ cần nhập Mã lớp)
         
        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaLoi();

            // 1. Chỉ bắt buộc nhập Mã lớp
            if (!KiemTraMa(txtMaLop, "Mã lớp"))
            {
                txtMaLop.Focus();
                return;
            }

            string maLop = txtMaLop.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // 2. Kiểm tra mã lớp có tồn tại không
                    if (!LopTonTai(conn, maLop))
                    {
                        errorProvider1.SetError(txtMaLop, "Không tìm thấy mã lớp này.");
                        MessageBox.Show("Không tìm thấy lớp có mã \"" + maLop + "\".",
                            "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLop.Focus();
                        return;
                    }

                    // 3. Hỏi xác nhận trước khi xóa
                    DialogResult xacNhan = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa lớp có mã \"" + maLop + "\" không?",
                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (xacNhan != DialogResult.Yes)
                    {
                        return;
                    }

                    // 4. Xóa lớp theo MaLop (chỉ xóa bảng Lop, không đụng đến bảng Khoa)
                    const string sql = "DELETE FROM dbo.Lop WHERE MaLop = @MaLop";
                    int soDongXoa;
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                        soDongXoa = cmd.ExecuteNonQuery();
                    }

                    // Phòng trường hợp lớp vừa bị người khác xóa trước đó
                    if (soDongXoa == 0)
                    {
                        errorProvider1.SetError(txtMaLop, "Không tìm thấy mã lớp này.");
                        MessageBox.Show("Không tìm thấy lớp có mã \"" + maLop + "\".",
                            "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MessageBox.Show("Xóa lớp thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaNoiDung();
            }
            catch (SqlException ex)
            {
                XuLyLoiSql(ex, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // NÚT SỬA (bắt buộc nhập Mã lớp, Mã khoa, Tên lớp)

        private void btnSua_Click(object sender, EventArgs e)
        {
            XoaLoi();

            bool coMaKhoa = !string.IsNullOrWhiteSpace(txtMaKhoa.Text);
            bool coTenLop = !string.IsNullOrWhiteSpace(txtTenLop.Text);

            // 1. Kiểm tra dữ liệu nhập
            bool hopLe = KiemTraMa(txtMaLop, "Mã lớp");   // Mã lớp không được để trống

            if (!coMaKhoa && !coTenLop)
            {
                // Cả Mã khoa và Tên lớp đều trống -> báo lỗi ở cả 2 ô
                const string thongBao = "Phải nhập ít nhất Mã khoa hoặc Tên lớp.";
                errorProvider1.SetError(txtMaKhoa, thongBao);
                errorProvider1.SetError(txtTenLop, thongBao);
                hopLe = false;
            }
            else if (coMaKhoa)
            {
                // Có nhập Mã khoa -> kiểm tra ký tự hợp lệ (cột VARCHAR)
                hopLe &= KiemTraMa(txtMaKhoa, "Mã khoa");
            }

            if (!hopLe)
            {
                FocusOLoiDauTien();
                return;
            }

            string maLop = txtMaLop.Text.Trim();
            // Ô nào để trống thì để null -> khi cập nhật sẽ giữ nguyên giá trị cũ
            string? maKhoa = coMaKhoa ? txtMaKhoa.Text.Trim() : null;
            string? tenLop = coTenLop ? txtTenLop.Text.Trim() : null;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // 2. Mã lớp (dùng để xác định bản ghi cần sửa) phải tồn tại
                    if (!LopTonTai(conn, maLop))
                    {
                        errorProvider1.SetError(txtMaLop, "Không tìm thấy mã lớp này.");
                        MessageBox.Show("Không tìm thấy lớp có mã \"" + maLop + "\".",
                            "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaLop.Focus();
                        return;
                    }

                    // 3. Nếu có nhập Mã khoa mới thì mã khoa đó phải tồn tại trong bảng Khoa
                    if (maKhoa != null && !KhoaTonTai(conn, maKhoa))
                    {
                        errorProvider1.SetError(txtMaKhoa, "Mã khoa không tồn tại trong bảng Khoa.");
                        MessageBox.Show("Mã khoa \"" + maKhoa + "\" không tồn tại trong bảng Khoa. Không thể cập nhật.",
                            "Mã khoa không tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaKhoa.Focus();
                        return;
                    }

                    // 4. Cập nhật theo MaLop.
                    //    ISNULL(@Tham_so, Cot): nếu tham số là NULL (ô để trống) thì giữ nguyên giá trị cũ.
                    const string sql =
                        "UPDATE dbo.Lop " +
                        "SET MaKhoa = ISNULL(@MaKhoa, MaKhoa), TenLop = ISNULL(@TenLop, TenLop) " +
                        "WHERE MaLop = @MaLop";
                    int soDongSua;
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = (object?)maKhoa ?? DBNull.Value;
                        cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar, 100).Value = (object?)tenLop ?? DBNull.Value;
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                        soDongSua = cmd.ExecuteNonQuery();
                    }

                    // Phòng trường hợp lớp vừa bị người khác xóa trước đó
                    if (soDongSua == 0)
                    {
                        errorProvider1.SetError(txtMaLop, "Không tìm thấy mã lớp này.");
                        MessageBox.Show("Không tìm thấy lớp có mã \"" + maLop + "\".",
                            "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                MessageBox.Show("Sửa lớp thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaNoiDung();
            }
            catch (SqlException ex)
            {
                XuLyLoiSql(ex, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // CÁC HÀM DÙNG CHUNG


        // Kiểm tra mã lớp đã có trong bảng dbo.Lop chưa
        private static bool LopTonTai(SqlConnection conn, string maLop)
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Lop WHERE MaLop = @MaLop";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar, 10).Value = maLop;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Kiểm tra mã khoa đã có trong bảng dbo.Khoa chưa
        private static bool KhoaTonTai(SqlConnection conn, string maKhoa)
        {
            const string sql = "SELECT COUNT(*) FROM dbo.Khoa WHERE MaKhoa = @MaKhoa";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 10).Value = maKhoa;
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Kiểm tra ô nhập không được để trống
        private bool KiemTraBatBuoc(TextBox txt, string tenTruong)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                errorProvider1.SetError(txt, tenTruong + " không được để trống.");
                return false;
            }
            return true;
        }

        // Kiểm tra ô mã (MaKhoa, MaLop): không để trống và chỉ gồm ký tự không dấu,
        // vì 2 cột này có kiểu VARCHAR (không lưu được chữ có dấu tiếng Việt)
        private bool KiemTraMa(TextBox txt, string tenTruong)
        {
            if (!KiemTraBatBuoc(txt, tenTruong))
            {
                return false;
            }

            foreach (char c in txt.Text.Trim())
            {
                if (c > 127)
                {
                    errorProvider1.SetError(txt, tenTruong + " chỉ được nhập ký tự không dấu (chữ, số).");
                    return false;
                }
            }
            return true;
        }

        // Đưa con trỏ về ô đầu tiên đang bị lỗi
        private void FocusOLoiDauTien()
        {
            TextBox[] cacO = { txtMaKhoa, txtMaLop, txtTenLop };
            foreach (TextBox txt in cacO)
            {
                if (errorProvider1.GetError(txt) != "")
                {
                    txt.Focus();
                    return;
                }
            }
        }

        // Xóa các biểu tượng lỗi trên form
        private void XoaLoi()
        {
            errorProvider1.SetError(txtMaKhoa, "");
            errorProvider1.SetError(txtMaLop, "");
            errorProvider1.SetError(txtTenLop, "");
        }

        // Xóa nội dung các ô nhập sau khi thao tác thành công
        private void XoaNoiDung()
        {
            txtMaKhoa.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            XoaLoi();
            txtMaKhoa.Focus();
        }

        // Hiển thị thông báo cho các lỗi SQL thường gặp.
        // dangXoa = true khi đang xóa lớp (lỗi khóa ngoại lúc này có nghĩa khác).
        private void XuLyLoiSql(SqlException ex, bool dangXoa)
        {
            if (ex.Number == LoiTrungKhoaChinh || ex.Number == LoiTrungChiMuc)
            {
                // Trùng khóa chính MaLop
                errorProvider1.SetError(txtMaLop, "Mã lớp đã tồn tại.");
                MessageBox.Show("Mã lớp đã tồn tại (trùng khóa chính).", "Lỗi trùng khóa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ex.Number == LoiKhoaNgoai)
            {
                if (dangXoa)
                {
                    // Có bảng khác đang tham chiếu đến lớp này
                    MessageBox.Show("Không thể xóa lớp này vì còn dữ liệu khác đang tham chiếu đến lớp.",
                        "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // MaKhoa không tồn tại trong bảng Khoa (FK_Lop_Khoa)
                    errorProvider1.SetError(txtMaKhoa, "Mã khoa không tồn tại trong bảng Khoa.");
                    MessageBox.Show("Mã khoa không tồn tại trong bảng Khoa (lỗi khóa ngoại FK_Lop_Khoa).",
                        "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Các lỗi SQL khác (ví dụ không kết nối được SQL Server, sai tên bảng...)
                MessageBox.Show("Lỗi SQL Server (mã " + ex.Number + "): " + ex.Message, "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
