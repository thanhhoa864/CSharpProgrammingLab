using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Bai02_BTTL_SQL
{
    public partial class Form1 : Form
    {
        
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_Lab06b;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private decimal diem;

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSinhVien();
                LoadMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message);
            }
        }

        // Đưa các mã có trong cơ sở dữ liệu vào ComboBox.
        private void LoadSinhVien()
        {
            cboSV.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string sql = "SELECT MaSinhVien FROM dbo.SinhVien ORDER BY MaSinhVien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboSV.Items.Add(reader["MaSinhVien"].ToString());
                    }
                }
            }
            if (cboSV.Items.Count > 0)
            {
                cboSV.SelectedIndex = 0;
            }
        }

        // Đưa các mã có trong cơ sở dữ liệu vào ComboBox.
        private void LoadMonHoc()
        {
            cboMH.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string sql = "SELECT MaMonHoc FROM dbo.MonHoc ORDER BY MaMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboMH.Items.Add(reader["MaMonHoc"].ToString());
                    }
                }
            }
            if (cboMH.Items.Count > 0)
            {
                cboMH.SelectedIndex = 0;
            }
        }

        // Trả về true nếu tìm thấy dữ liệu trong bảng Diem.
        private bool KiemTraTrungMa(string maSinhVien, string maMonHoc)
        {
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.Diem WHERE MaSinhVien=@MaSinhVien AND MaMonHoc=@MaMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);
                cmd.Parameters.AddWithValue("@MaMonHoc", maMonHoc);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        // Trả về true nếu tìm thấy dữ liệu trong bảng SinhVien.
        private bool SinhVienTonTai(string ma)
        {
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.SinhVien WHERE MaSinhVien=@MaSinhVien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSinhVien", ma);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        // Trả về true nếu tìm thấy dữ liệu trong bảng MonHoc.
        private bool MonHocTonTai(string ma)
        {
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                string sql = "SELECT * FROM dbo.MonHoc WHERE MaMonHoc=@MaMonHoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaMonHoc", ma);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        // Dùng chung cho nút Thêm và Sửa; Xóa chỉ cần mã.
        private bool KiemTraNhap()
        {
            if (cboSV.Text.Trim() == "" || cboMH.Text.Trim() == "" || txtDiem.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }
            // Cho phép nhập điểm bằng dấu phẩy hoặc dấu chấm.
            if (!decimal.TryParse(txtDiem.Text.Trim().Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem))
            {
                MessageBox.Show("Điểm phải là số.");
                return false;
            }
            if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10.");
                return false;
            }
            return true;
        }

        // Nút Thêm: kiểm tra dữ liệu trước khi thực hiện lệnh SQL.
        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraNhap())
                {
                    return;
                }
                if (KiemTraTrungMa(cboSV.Text, cboMH.Text))
                {
                    MessageBox.Show("Mã đã tồn tại, không thể thêm trùng.");
                    return;
                }
                if (!SinhVienTonTai(cboSV.Text))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.");
                    return;
                }
                if (!MonHocTonTai(cboMH.Text))
                {
                    MessageBox.Show("Mã môn học không tồn tại.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    string sql = "INSERT INTO dbo.Diem (MaSinhVien, MaMonHoc, Diem) VALUES (@MaSinhVien, @MaMonHoc, @Diem)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    // Truyền tham số để lưu đúng cả dữ liệu có dấu nháy.
                    cmd.Parameters.AddWithValue("@MaSinhVien", cboSV.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", cboMH.Text);
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong > 0)
                    {
                        MessageBox.Show("Thêm thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không còn tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thực hiện được: " + ex.Message);
            }
        }

        // Nút Xóa: kiểm tra dữ liệu trước khi thực hiện lệnh SQL.
        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSV.Text == "" || cboMH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập hoặc chọn mã cần xóa.");
                    return;
                }
                if (!KiemTraTrungMa(cboSV.Text, cboMH.Text))
                {
                    MessageBox.Show("Không tìm thấy dữ liệu có mã này.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    string sql = "DELETE FROM dbo.Diem WHERE MaSinhVien=@MaSinhVien AND MaMonHoc=@MaMonHoc";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    // Truyền tham số để lưu đúng cả dữ liệu có dấu nháy.
                    cmd.Parameters.AddWithValue("@MaSinhVien", cboSV.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", cboMH.Text);
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong > 0)
                    {
                        MessageBox.Show("Xóa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không còn tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thực hiện được: " + ex.Message);
            }
        }

        // Nút Sửa: kiểm tra dữ liệu trước khi thực hiện lệnh SQL.
        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraNhap())
                {
                    return;
                }
                if (!KiemTraTrungMa(cboSV.Text, cboMH.Text))
                {
                    MessageBox.Show("Không tìm thấy dữ liệu có mã này.");
                    return;
                }
                if (!SinhVienTonTai(cboSV.Text))
                {
                    MessageBox.Show("Mã sinh viên không tồn tại.");
                    return;
                }
                if (!MonHocTonTai(cboMH.Text))
                {
                    MessageBox.Show("Mã môn học không tồn tại.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    // Giữ nguyên mã; chỉ sửa các thông tin còn lại.
                    string sql = "UPDATE dbo.Diem SET Diem=@Diem WHERE MaSinhVien=@MaSinhVien AND MaMonHoc=@MaMonHoc";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    // Truyền tham số để lưu đúng cả dữ liệu có dấu nháy.
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@MaSinhVien", cboSV.Text);
                    cmd.Parameters.AddWithValue("@MaMonHoc", cboMH.Text);
                    int soDong = cmd.ExecuteNonQuery();
                    if (soDong > 0)
                    {
                        MessageBox.Show("Sửa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu không còn tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thực hiện được: " + ex.Message);
            }
        }


    }
}
