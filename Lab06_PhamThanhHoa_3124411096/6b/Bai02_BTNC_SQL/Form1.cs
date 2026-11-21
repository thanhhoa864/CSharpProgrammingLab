using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai02_BTNC_SQL
{
    public partial class Form1 : Form
    {
        private string ketNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_Lab06b;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonHoc();
                HienThiDiem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu: " + ex.Message);
            }
        }

        private void LoadMonHoc()
        {
            cboMH.Items.Clear();
            cboMH.Items.Add(""); // Mục trống dùng để xem tất cả môn học.
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
            cboMH.SelectedIndex = 0;
        }

        private void Loc_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDiem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lọc được dữ liệu: " + ex.Message);
            }
        }

        private void HienThiDiem()
        {
            lvDiem.Items.Clear();
            txtTong.Text = "0";
            decimal tongDiem = 0;
            int stt = 1;

            using (SqlConnection conn = new SqlConnection(ketNoi))
            {
                conn.Open();
                // Ghép ba bảng để lấy tên sinh viên và tên môn học.
                string sql = @"SELECT s.HoTen, s.NgaySinh, m.TenMonHoc, d.Diem
                               FROM dbo.Diem d
                               JOIN dbo.SinhVien s ON d.MaSinhVien = s.MaSinhVien
                               JOIN dbo.MonHoc m ON d.MaMonHoc = m.MaMonHoc";

                if (cboMH.Text != "")
                {
                    sql += " WHERE d.MaMonHoc = @MaMonHoc";
                }
                sql += " ORDER BY s.MaSinhVien, m.MaMonHoc";

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cboMH.Text != "")
                {
                    cmd.Parameters.AddWithValue("@MaMonHoc", cboMH.Text);
                }

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime ngaySinh = Convert.ToDateTime(reader["NgaySinh"]);
                        decimal diem = Convert.ToDecimal(reader["Diem"]);

                        ListViewItem dong = new ListViewItem(stt.ToString());
                        dong.SubItems.Add(reader["HoTen"].ToString());
                        dong.SubItems.Add(ngaySinh.ToString("dd/MM/yyyy"));
                        dong.SubItems.Add(reader["TenMonHoc"].ToString());
                        dong.SubItems.Add(diem.ToString("0.##"));
                        lvDiem.Items.Add(dong);

                        tongDiem += diem; // Chỉ cộng các dòng đang hiển thị.
                        stt++;
                    }
                }
            }
            txtTong.Text = tongDiem.ToString("0.##");
        }

    }
}
