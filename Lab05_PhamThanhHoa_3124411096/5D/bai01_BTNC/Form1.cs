
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai01_BTNC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Thêm học viên mẫu vào hai lớp khi mở chương trình
        private void Form1_Load(object sender, EventArgs e)
        {
            lstLopA.Items.AddRange(new object[]
            {
                "Trần Hùng", "Nguyễn Hưng", "Lâm Tứ"
            });

            lstLopB.Items.AddRange(new object[]
            {
                "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm"
            });
        }

        // Hỏi xác nhận trước khi thoát
        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn kết thúc chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Chuyển học viên được chọn từ lớp A sang lớp B
        private void mnuChuyenSangLopB_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần chuyển!");
                return;
            }

            List<object> dsChuyen = new List<object>();

            foreach (var item in lstLopA.SelectedItems)
            {
                dsChuyen.Add(item);
            }

            foreach (var item in dsChuyen)
            {
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }

        // Chuyển học viên được chọn từ lớp B sang lớp A
        private void mnuChuyenSangLopA_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần chuyển!");
                return;
            }

            List<object> dsChuyen = new List<object>();

            foreach (var item in lstLopB.SelectedItems)
            {
                dsChuyen.Add(item);
            }

            foreach (var item in dsChuyen)
            {
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }

        // Xóa những học viên đang được chọn
        private void mnuXoaHocVien_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0 &&
                lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa!");
                return;
            }

            for (int i = lstLopA.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.RemoveAt(lstLopA.SelectedIndices[i]);
            }

            for (int i = lstLopB.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.RemoveAt(lstLopB.SelectedIndices[i]);
            }

            MessageBox.Show("Đã xóa học viên thành công!");
        }

        // Mở form nhập học viên mới
        private void mnuNhapHocVienMoi_Click(object sender, EventArgs e)
        {
            frmNhapHocVien fNhap = new frmNhapHocVien();

            fNhap.OnThemHocVien += (hoTen, tenLop) =>
            {
                if (tenLop == "Lớp A")
                {
                    lstLopA.Items.Add(hoTen);
                }
                else
                {
                    lstLopB.Items.Add(hoTen);
                }
            };

            fNhap.ShowDialog(this);
        }
    }

    // Form nhập thông tin học viên
    public class frmNhapHocVien : Form
    {
        private Label lblHoTen;
        private Label lblLop;
        private TextBox txtHoTen;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Button btnTroVe;

        // Gửi họ tên và lớp về form chính
        public event Action<string, string> OnThemHocVien;

        public frmNhapHocVien()
        {
            TaoGiaoDien();
        }

        // Tạo các điều khiển trên form nhập
        private void TaoGiaoDien()
        {
            lblHoTen = new Label()
            {
                Text = "Họ và Tên",
                Location = new System.Drawing.Point(30, 30),
                AutoSize = true
            };

            txtHoTen = new TextBox()
            {
                Location = new System.Drawing.Point(120, 27),
                Width = 220
            };

            lblLop = new Label()
            {
                Text = "Lớp",
                Location = new System.Drawing.Point(30, 75),
                AutoSize = true
            };

            cboLop = new ComboBox()
            {
                Location = new System.Drawing.Point(120, 72),
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            cboLop.SelectedIndex = 0;

            btnCapNhat = new Button()
            {
                Text = "Cập nhật",
                Location = new System.Drawing.Point(120, 125),
                Width = 95,
                Height = 32
            };

            btnTroVe = new Button()
            {
                Text = "Trở về",
                Location = new System.Drawing.Point(245, 125),
                Width = 95,
                Height = 32
            };

            btnCapNhat.Click += BtnCapNhat_Click;
            btnTroVe.Click += (s, e) => Close();

            ClientSize = new System.Drawing.Size(380, 180);
            Controls.AddRange(new Control[]
            {
                lblHoTen, txtHoTen, lblLop, cboLop,
                btnCapNhat, btnTroVe
            });

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập học viên mới";
        }

        // Kiểm tra họ tên rồi gửi thông tin về form chính
        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!");
                txtHoTen.Focus();
                return;
            }

            string tenLop = cboLop.SelectedItem.ToString();

            OnThemHocVien?.Invoke(hoTen, tenLop);

            MessageBox.Show("Thêm học viên thành công!");

            txtHoTen.Clear();
            txtHoTen.Focus();
        }
    }
}
