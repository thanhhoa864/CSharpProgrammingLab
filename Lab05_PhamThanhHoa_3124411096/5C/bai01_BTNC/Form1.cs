
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace bai01_BTNC
{
    public partial class Form1 : Form
    {
        // Dữ liệu dùng để tạo họ tên ngẫu nhiên
        private string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
        private string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
        private string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

        private Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // Tạo danh sách 50 họ tên ngẫu nhiên
        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();

            for (int i = 0; i < 50; i++)
            {
                string ho = HO[rd.Next(HO.Length)];
                string tenLot = TENLOT[rd.Next(TENLOT.Length)];
                string ten = TEN[rd.Next(TEN.Length)];

                string hoTen = ho + " " + tenLot + " " + ten;
                lstDanhSach.Items.Add(hoTen);
            }
        }

        // Xóa các phần tử đang được chọn
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử cần xóa!");
                return;
            }

            for (int i = lstDanhSach.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int viTri = lstDanhSach.SelectedIndices[i];
                lstDanhSach.Items.RemoveAt(viTri);
            }
        }

        // Hàm xóa phần tử theo họ hoặc tên
        private void XoaTheoHoTen(string giaTri, bool laHo)
        {
            for (int i = lstDanhSach.Items.Count - 1; i >= 0; i--)
            {
                string hoTen = lstDanhSach.Items[i].ToString().Trim();

                string[] tach = hoTen.Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (tach.Length == 0)
                    continue;

                string canKiemTra;

                if (laHo)
                    canKiemTra = tach[0];
                else
                    canKiemTra = tach[tach.Length - 1];

                if (string.Equals(canKiemTra, giaTri,
                    StringComparison.OrdinalIgnoreCase))
                {
                    lstDanhSach.Items.RemoveAt(i);
                }
            }
        }

        // Xóa những người có tên là Sơn
        private void btnXoaSon_Click(object sender, EventArgs e)
        {
            XoaTheoHoTen("Sơn", false);
        }

        // Xóa những người có họ là Lê
        private void btnXoaLe_Click(object sender, EventArgs e)
        {
            XoaTheoHoTen("Lê", true);
        }

        // Hàm xử lý chuyển đổi chữ
        private void ChuyenKieuChu(int kieu)
        {
            if (lstDanhSach.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phần tử!");
                return;
            }

            // Lưu vị trí các phần tử đang chọn
            int[] viTriChon = new int[lstDanhSach.SelectedIndices.Count];
            lstDanhSach.SelectedIndices.CopyTo(viTriChon, 0);

            // Lấy toàn bộ dữ liệu trong ListBox
            List<string> danhSach = new List<string>();

            foreach (var item in lstDanhSach.Items)
            {
                danhSach.Add(item.ToString());
            }

            TextInfo textInfo = new CultureInfo("vi-VN").TextInfo;

            // Chuyển đổi những phần tử được chọn
            foreach (int i in viTriChon)
            {
                string hoTen = danhSach[i];

                if (kieu == 1)
                {
                    danhSach[i] = hoTen.ToUpper();
                }
                else if (kieu == 2)
                {
                    danhSach[i] = hoTen.ToLower();
                }
                else if (kieu == 3)
                {
                    danhSach[i] = textInfo.ToTitleCase(hoTen.ToLower());
                }
            }

            // Cập nhật lại ListBox
            lstDanhSach.BeginUpdate();
            lstDanhSach.Items.Clear();

            foreach (string ten in danhSach)
            {
                lstDanhSach.Items.Add(ten);
            }

            // Chọn lại những phần tử ban đầu
            foreach (int i in viTriChon)
            {
                lstDanhSach.SetSelected(i, true);
            }

            lstDanhSach.EndUpdate();
        }

        // Chuyển thành chữ HOA
        private void btnInHoa_Click(object sender, EventArgs e)
        {
            ChuyenKieuChu(1);
        }

        // Chuyển thành chữ thường
        private void btnInThuong_Click(object sender, EventArgs e)
        {
            ChuyenKieuChu(2);
        }

        // Viết hoa chữ cái đầu mỗi từ
        private void btnVietHoaDauTu_Click(object sender, EventArgs e)
        {
            ChuyenKieuChu(3);
        }

        // Xóa tất cả phần tử
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
        }

        // Nhấp đúp chuột để sửa họ tên
        private void lstDanhSach_DoubleClick(object sender, EventArgs e)
        {
            int viTri = lstDanhSach.SelectedIndex;

            if (viTri < 0)
                return;

            string tenCu = lstDanhSach.Items[viTri].ToString();

            string tenMoi = NhapTenMoi(tenCu);

            if (!string.IsNullOrWhiteSpace(tenMoi))
            {
                lstDanhSach.Items[viTri] = tenMoi.Trim();
                lstDanhSach.SelectedIndex = viTri;
                lstDanhSach.Refresh();
            }
        }

        // Tạo hộp thoại nhập tên mới
        private string NhapTenMoi(string tenCu)
        {
            using (Form frm = new Form())
            {
                frm.Text = "Thay đổi họ tên";
                frm.Width = 360;
                frm.Height = 175;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.FormBorderStyle = FormBorderStyle.FixedDialog;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;

                Label lbl = new Label();
                lbl.Text = "Nhập tên mới:";
                lbl.Left = 20;
                lbl.Top = 15;
                lbl.AutoSize = true;

                TextBox txt = new TextBox();
                txt.Left = 20;
                txt.Top = 40;
                txt.Width = 300;
                txt.Text = tenCu;

                Button btnOK = new Button();
                btnOK.Text = "OK";
                btnOK.Left = 135;
                btnOK.Top = 80;
                btnOK.Width = 85;
                btnOK.DialogResult = DialogResult.OK;

                Button btnHuy = new Button();
                btnHuy.Text = "Hủy";
                btnHuy.Left = 235;
                btnHuy.Top = 80;
                btnHuy.Width = 85;
                btnHuy.DialogResult = DialogResult.Cancel;

                frm.Controls.Add(lbl);
                frm.Controls.Add(txt);
                frm.Controls.Add(btnOK);
                frm.Controls.Add(btnHuy);

                frm.AcceptButton = btnOK;
                frm.CancelButton = btnHuy;

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    return txt.Text;
                }

                return "";
            }
        }
    }
}
