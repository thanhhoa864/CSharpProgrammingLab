using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai01_BTNC_SQL
{
    public partial class Form1 : Form
    {
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_Lab06b;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();

            // Tạo các cột cho ListView.
            lvLop.Columns.Clear();
            lvLop.Columns.Add("STT", 50);
            lvLop.Columns.Add("Mã lớp", 120);
            lvLop.Columns.Add("Tên lớp", 330);
            lvLop.Columns.Add("Mã khoa", 120);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HienThi_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa danh sách cũ để không lặp khi nhấn nút nhiều lần.
                lvLop.Items.Clear();
                using (SqlConnection conn = new SqlConnection(ketNoi))
                {
                    conn.Open();
                    string sql = "SELECT MaLop, TenLop, MaKhoa FROM dbo.Lop ORDER BY MaLop";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int stt = 1;
                        while (reader.Read())
                        {
                            // Cột đầu là STT, các cột tiếp theo dùng SubItems.
                            ListViewItem dong = new ListViewItem(stt.ToString());
                            dong.SubItems.Add(reader["MaLop"].ToString());
                            dong.SubItems.Add(reader["TenLop"].ToString());
                            dong.SubItems.Add(reader["MaKhoa"].ToString());
                            lvLop.Items.Add(dong);
                            stt++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách lớp: " + ex.Message);
            }
        }

    }
}
