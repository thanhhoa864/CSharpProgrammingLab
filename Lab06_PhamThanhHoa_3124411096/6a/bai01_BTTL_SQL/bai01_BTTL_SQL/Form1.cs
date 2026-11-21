
using System;
using System.Data.SqlClient; // Thư viện dùng để kết nối và làm việc với SQL Server
using System.Windows.Forms; // Thư viện dùng để tạo giao diện Windows Forms

namespace bai01_BTTL_SQL
{
    public partial class Form1 : Form
    {
        // Khai báo chuỗi kết nối đến SQL Server
        string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_LabSau;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent(); // Khởi tạo các điều khiển đã thiết kế trên Form
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy mã môn học người dùng nhập vào TextBox
            // Trim() dùng để bỏ khoảng trắng ở đầu và cuối chuỗi
            string ma = txtMaMH.Text.Trim();

            // Lấy tên môn học người dùng nhập vào TextBox
            string ten = txtTenMH.Text.Trim();

            // Kiểm tra nếu mã hoặc tên môn học chưa được nhập
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên môn học!"); // Hiển thị thông báo
                return; // Dừng hàm, không thực hiện câu lệnh thêm
            }

            // Tạo đối tượng kết nối đến database bằng chuỗi ketNoi
            // using giúp tự giải phóng kết nối sau khi xử lý xong
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open(); // Mở kết nối đến SQL Server

                    // Tạo câu lệnh INSERT để thêm môn học vào bảng MonHoc
                    // @MaMH và @TenMH là các tham số sẽ nhận dữ liệu từ TextBox
                    string sql = "INSERT INTO dbo.MonHoc (MaMH, TenMH) VALUES (@MaMH, @TenMH)";

                    // Tạo đối tượng SqlCommand để thực hiện câu lệnh SQL trên kết nối conn
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Gán giá trị mã môn học vào tham số @MaMH
                        cmd.Parameters.AddWithValue("@MaMH", ma);

                        // Gán giá trị tên môn học vào tham số @TenMH
                        cmd.Parameters.AddWithValue("@TenMH", ten);

                        // Thực hiện câu lệnh INSERT
                        // ExecuteNonQuery() dùng cho các lệnh thêm, xóa và sửa dữ liệu
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm môn học thành công!"); // Thông báo khi thêm thành công

                        // Xóa nội dung hai TextBox để người dùng nhập môn học tiếp theo
                        txtMaMH.Clear();
                        txtTenMH.Clear();
                    }
                }
                catch (SqlException ex) // Bắt lỗi phát sinh từ SQL Server
                {
                    // Mã lỗi 2627 hoặc 2601 thường xuất hiện khi mã môn học bị trùng
                    if (ex.Number == 2627 || ex.Number == 2601)
                    {
                        MessageBox.Show("Mã môn học đã tồn tại!"); // Báo mã bị trùng
                    }
                    else
                    {
                        // Nếu là lỗi SQL khác thì hiển thị nội dung lỗi để kiểm tra
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
                catch (Exception ex) // Bắt các lỗi khác ngoài lỗi SQL
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy mã môn học cần xóa từ TextBox
            string ma = txtMaMH.Text.Trim();

            // Kiểm tra người dùng đã nhập mã môn học hay chưa
            if (ma == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học cần xóa!");
                return; // Dừng hàm nếu chưa nhập mã
            }

            // Tạo kết nối đến database
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open(); // Mở kết nối đến SQL Server

                    // Tạo câu lệnh DELETE để xóa môn học có mã trùng với mã nhập vào
                    // Điều kiện WHERE giúp chỉ xóa đúng môn học cần xóa
                    string sql = "DELETE FROM dbo.MonHoc WHERE MaMH = @MaMH";

                    // Tạo đối tượng thực hiện câu lệnh DELETE
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Gán mã người dùng nhập vào tham số @MaMH
                        cmd.Parameters.AddWithValue("@MaMH", ma);

                        // Thực hiện xóa và nhận số dòng dữ liệu bị ảnh hưởng
                        int soDong = cmd.ExecuteNonQuery();

                        // Nếu số dòng lớn hơn 0 nghĩa là đã xóa được một môn học
                        if (soDong > 0)
                        {
                            MessageBox.Show("Xóa môn học thành công!");
                        }
                        else
                        {
                            // Nếu số dòng bằng 0 thì mã môn học không tồn tại
                            MessageBox.Show("Không tìm thấy mã môn học!");
                        }

                        // Xóa nội dung hai TextBox sau khi xử lý
                        txtMaMH.Clear();
                        txtTenMH.Clear();
                    }
                }
                catch (Exception ex) // Bắt lỗi nếu kết nối hoặc thực hiện SQL thất bại
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy mã môn học cần sửa từ TextBox
            string ma = txtMaMH.Text.Trim();

            // Lấy tên môn học mới mà người dùng muốn cập nhật
            string ten = txtTenMH.Text.Trim();

            // Kiểm tra người dùng đã nhập đủ mã và tên mới chưa
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên môn học mới!");
                return; // Dừng hàm nếu còn thiếu dữ liệu
            }

            // Tạo kết nối đến database
            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                try
                {
                    conn.Open(); // Mở kết nối đến SQL Server

                    // Tạo câu lệnh UPDATE để thay đổi tên môn học
                    // SET TenMH = @TenMH là cập nhật tên mới
                    // WHERE MaMH = @MaMH là xác định môn học cần sửa theo mã
                    string sql = "UPDATE dbo.MonHoc SET TenMH = @TenMH WHERE MaMH = @MaMH";

                    // Tạo đối tượng thực hiện câu lệnh UPDATE
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Gán mã môn học vào tham số @MaMH
                        cmd.Parameters.AddWithValue("@MaMH", ma);

                        // Gán tên môn học mới vào tham số @TenMH
                        cmd.Parameters.AddWithValue("@TenMH", ten);

                        // Thực hiện cập nhật và lấy số dòng bị ảnh hưởng
                        int soDong = cmd.ExecuteNonQuery();

                        // Nếu tìm thấy mã và cập nhật được dữ liệu
                        if (soDong > 0)
                        {
                            MessageBox.Show("Sửa môn học thành công!");
                        }
                        else
                        {
                            // Nếu không có dòng nào được cập nhật thì mã không tồn tại
                            MessageBox.Show("Không tìm thấy mã môn học!");
                        }
                    }
                }
                catch (Exception ex) // Bắt lỗi khi thực hiện cập nhật
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

    }
}
