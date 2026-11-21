
using System;
using System.Windows.Forms;

namespace bai01_BTTL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khi mở form, thêm danh sách dân tộc
        private void Form1_Load(object sender, EventArgs e)
        {
            cboDanToc.Items.AddRange(new string[]
            {
                "Kinh", "Tày", "Thái", "Mường", "H'Mông", "Khmer",
                "Nùng", "Hoa", "Dao", "Gia Rai", "Ê Đê", "Ba Na"
            });

            cboDanToc.SelectedIndex = 0;
            radNam.Checked = true;
            chkAnh.Checked = true;
        }

        // Lấy các ngoại ngữ đã chọn
        private string LayNgoaiNgu()
        {
            string ngoaiNgu = "";

            if (chkAnh.Checked)
                ngoaiNgu += "Anh, ";

            if (chkPhap.Checked)
                ngoaiNgu += "Pháp, ";

            if (chkHoa.Checked)
                ngoaiNgu += "Hoa, ";

            if (ngoaiNgu == "")
                return "Không";

            return ngoaiNgu.Substring(0, ngoaiNgu.Length - 2);
        }

        // Kiểm tra mã sinh viên đã tồn tại chưa
        private bool TrungMaSV(string maSV)
        {
            foreach (ListViewItem sv in lvSinhVien.Items)
            {
                if (sv.SubItems[1].Text.Equals(
                    maSV, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        // Xóa dữ liệu trên các ô nhập
        private void XoaTrang()
        {
            txtHoTen.Clear();
            txtMaSV.Clear();
            txtMaSV.ReadOnly = false;

            radNam.Checked = true;
            chkAnh.Checked = true;
            chkPhap.Checked = false;
            chkHoa.Checked = false;

            cboDanToc.SelectedIndex = 0;
            lvSinhVien.SelectedItems.Clear();
            txtHoTen.Focus();
        }

        // Thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string maSV = txtMaSV.Text.Trim();

            if (hoTen == "" || maSV == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Mã sinh viên!");

                if (hoTen == "")
                    txtHoTen.Focus();
                else
                    txtMaSV.Focus();

                return;
            }

            if (TrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            ListViewItem sv = new ListViewItem(hoTen);

            sv.SubItems.Add(maSV);
            sv.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
            sv.SubItems.Add(LayNgoaiNgu());
            sv.SubItems.Add(cboDanToc.SelectedItem.ToString());

            lvSinhVien.Items.Add(sv);

            XoaTrang();
            MessageBox.Show("Thêm sinh viên thành công!");
        }

        // Chọn sinh viên trong danh sách để hiển thị thông tin
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                txtMaSV.ReadOnly = false;
                return;
            }

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            txtHoTen.Text = sv.SubItems[0].Text;
            txtMaSV.Text = sv.SubItems[1].Text;
            txtMaSV.ReadOnly = true;

            radNam.Checked = sv.SubItems[2].Text == "Nam";
            radNu.Checked = sv.SubItems[2].Text == "Nữ";

            chkAnh.Checked = false;
            chkPhap.Checked = false;
            chkHoa.Checked = false;

            string nn = sv.SubItems[3].Text;

            if (nn.Contains("Anh"))
                chkAnh.Checked = true;

            if (nn.Contains("Pháp"))
                chkPhap.Checked = true;

            if (nn.Contains("Hoa"))
                chkHoa.Checked = true;

            cboDanToc.SelectedItem = sv.SubItems[4].Text;
        }

        // Sửa thông tin sinh viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            string hoTen = txtHoTen.Text.Trim();

            if (hoTen == "")
            {
                MessageBox.Show("Họ tên không được để trống!");
                txtHoTen.Focus();
                return;
            }

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            sv.SubItems[0].Text = hoTen;
            sv.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ";
            sv.SubItems[3].Text = LayNgoaiNgu();
            sv.SubItems[4].Text = cboDanToc.SelectedItem.ToString();

            // Giữ nguyên mã sinh viên
            XoaTrang();
            MessageBox.Show("Sửa thông tin thành công!");
        }

        // Xóa sinh viên đang chọn
        private void ThucHienXoa()
        {
            if (lvSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            ListViewItem sv = lvSinhVien.SelectedItems[0];

            DialogResult kq = MessageBox.Show(
                "Bạn có muốn xóa sinh viên " +
                sv.SubItems[0].Text + " - " +
                sv.SubItems[1].Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvSinhVien.Items.Remove(sv);
                XoaTrang();
                MessageBox.Show("Xóa sinh viên thành công!");
            }
        }

        // Nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucHienXoa();
        }

        // Xóa bằng menu chuột phải
        private void menuXoa_Click(object sender, EventArgs e)
        {
            ThucHienXoa();
        }

        // Xác nhận trước khi đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng form không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                e.Cancel = true;
        }
    }
}
