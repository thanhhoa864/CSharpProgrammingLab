
using System;
using System.Windows.Forms;

namespace bai01_BTVN
{
    public partial class Form1 : Form
    {
        // Thời gian ban đầu là 30 phút
        private int tongSoGiay = 1800;

        public Form1()
        {
            InitializeComponent();
        }

        // Hiển thị thời gian khi mở chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiThoiGian();
        }

        // Đổi số giây thành phút và giây để hiển thị
        private void HienThiThoiGian()
        {
            int phut = tongSoGiay / 60;
            int giay = tongSoGiay % 60;

            lblDongHo.Text = $"{phut:D2}:{giay:D2}";
        }

        // Bấm nút để bắt đầu, tạm dừng hoặc tiếp tục
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (timerDemNguoc.Enabled)
            {
                timerDemNguoc.Stop();
                btnBatDau.Text = "Tiếp tục";
            }
            else
            {
                // Nếu đã hết giờ thì đặt lại 30 phút
                if (tongSoGiay == 0)
                {
                    tongSoGiay = 1800;
                    HienThiThoiGian();
                }

                timerDemNguoc.Start();
                btnBatDau.Text = "Tạm dừng";
            }
        }

        // Timer chạy mỗi giây để giảm thời gian
        private void timerDemNguoc_Tick(object sender, EventArgs e)
        {
            if (tongSoGiay > 0)
            {
                tongSoGiay--;
                HienThiThoiGian();
            }
            else
            {
                timerDemNguoc.Stop();
                btnBatDau.Text = "Bắt đầu";

                MessageBox.Show("Hết giờ!");
            }
        }
    }
}
