
using System;
using System.Windows.Forms;

namespace bai02_BTTL
{
    public partial class Form1 : Form
    {
        private TreeNode rootNode;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoDanhSach();
        }

        // Khởi tạo danh sách lớp ban đầu
        private void KhoiTaoDanhSach()
        {
            tvLop.Nodes.Clear();
            cboLop.Items.Clear();

            rootNode = tvLop.Nodes.Add("Danh sách lớp");

            string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };

            foreach (string lop in dsLop)
            {
                rootNode.Nodes.Add(lop);
                cboLop.Items.Add(lop);
            }

            rootNode.Expand();
            cboLop.SelectedIndex = 0;

            chkThemLop.Checked = false;
            grpThemLop.Visible = false;
        }

        // Hiển thị hoặc ẩn phần thêm lớp
        private void chkThemLop_CheckedChanged(object sender, EventArgs e)
        {
            grpThemLop.Visible = chkThemLop.Checked;

            if (chkThemLop.Checked)
                txtTenLop.Focus();
        }

        // Tìm lớp trong TreeView
        private TreeNode TimLop(string tenLop)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                if (string.Equals(node.Text, tenLop,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return node;
                }
            }

            return null;
        }

        // Thêm lớp mới
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text.Trim();

            if (tenLop == "")
            {
                MessageBox.Show("Vui lòng nhập tên lớp!");
                txtTenLop.Focus();
                return;
            }

            if (TimLop(tenLop) != null)
            {
                MessageBox.Show("Lớp này đã tồn tại!");
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }

            rootNode.Nodes.Add(tenLop);
            cboLop.Items.Add(tenLop);
            cboLop.SelectedItem = tenLop;

            rootNode.Expand();
            txtTenLop.Clear();

            MessageBox.Show("Thêm lớp thành công!");
        }

        // Kiểm tra mã sinh viên có bị trùng không
        private bool KiemTraTrungMaSV(string maSV)
        {
            foreach (TreeNode lop in rootNode.Nodes)
            {
                foreach (TreeNode sv in lop.Nodes)
                {
                    string maCu = sv.Text.Split(',')[0].Trim();

                    if (string.Equals(maCu, maSV,
                        StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // Cập nhật sinh viên vào lớp
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (maSV == "" || hoTen == "" || diaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                txtMaSV.Focus();
                txtMaSV.SelectAll();
                return;
            }

            string tenLop = cboLop.SelectedItem.ToString();
            TreeNode lop = TimLop(tenLop);

            if (lop != null)
            {
                TreeNode sv = new TreeNode(maSV + ", " + hoTen);
                sv.Nodes.Add(diaChi);

                lop.Nodes.Add(sv);
                lop.Expand();
                sv.Expand();

                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtMaSV.Focus();

                MessageBox.Show("Thêm sinh viên thành công!");
            }
        }

        // Hiển thị thông tin khi chọn sinh viên
        private void tvLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            TreeNode sv = null;

            // Cấp 2 là sinh viên, cấp 3 là địa chỉ
            if (node.Level == 2)
            {
                sv = node;
            }
            else if (node.Level == 3)
            {
                sv = node.Parent;
            }

            if (sv == null)
                return;

            string[] thongTin = sv.Text.Split(new char[] { ',' }, 2);

            if (thongTin.Length == 2)
            {
                txtMaSV.Text = thongTin[0].Trim();
                txtHoTen.Text = thongTin[1].Trim();
            }

            if (sv.Nodes.Count > 0)
            {
                txtDiaChi.Text = sv.Nodes[0].Text;
            }

            cboLop.SelectedItem = sv.Parent.Text;
        }

        // Xóa sinh viên được chọn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode node = tvLop.SelectedNode;

            if (node == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            TreeNode sv = null;

            if (node.Level == 2)
            {
                sv = node;
            }
            else if (node.Level == 3)
            {
                sv = node.Parent;
            }

            if (sv == null)
            {
                MessageBox.Show("Chỉ được phép xóa sinh viên!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên " + sv.Text + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                sv.Remove();

                txtMaSV.Clear();
                txtHoTen.Clear();
                txtDiaChi.Clear();

                MessageBox.Show("Xóa sinh viên thành công!");
            }
        }
    }
}
