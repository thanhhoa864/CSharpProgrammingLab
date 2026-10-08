using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai02_BTTL
{
    public class MangSoNguyen // Lớp đại diện cho một mảng số nguyên và cung cấp các phương thức để thao tác với mảng đó.
    {
        private List<int> a; // Danh sách lưu trữ các phần tử của mảng số nguyên.

        public MangSoNguyen() // Constructor mặc định, khởi tạo một mảng số nguyên rỗng.
        {
            a = new List<int>();
        }

        public MangSoNguyen(IEnumerable<int> collection) // Constructor nhận vào một tập hợp các số nguyên và khởi tạo mảng số nguyên với các phần tử từ tập hợp đó.
        {
            a = new List<int>();

            foreach (int so in collection)
            {
                a.Add(so); // Thêm từng phần tử từ tập hợp vào danh sách a.
            }
        }

        public int SoPhanTu // Thuộc tính chỉ đọc trả về số lượng phần tử hiện có trong mảng số nguyên.
        {
            get
            {
                return a.Count;
            }
        }

        public List<int> DanhSach // Thuộc tính chỉ đọc trả về danh sách các phần tử của mảng số nguyên.
        {
            get
            {
                return a;
            }
        }

        public string XuatChuoi() // Phương thức trả về một chuỗi đại diện cho các phần tử của mảng số nguyên, các phần tử được phân tách bằng dấu cách.
        {
            string ketQua = "";

            for (int i = 0; i < a.Count; i++)
            {
                ketQua += a[i];

                if (i < a.Count - 1)
                {
                    ketQua += " ";
                }
            }

            return ketQua;
        }

        public void SapXepTang() // Phương thức sắp xếp các phần tử của mảng số nguyên theo thứ tự tăng dần.
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] > a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }

        public void SapXepGiam() // Phương thức sắp xếp các phần tử của mảng số nguyên theo thứ tự giảm dần.
        {
            for (int i = 0; i < a.Count - 1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[i] < a[j])
                    {
                        int tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }

        public int TimViTriCuaGiaTri(int giaTri) // Phương thức tìm vị trí của một giá trị cụ thể trong mảng số nguyên. Nếu tìm thấy, trả về vị trí (chỉ số) của giá trị đó; nếu không tìm thấy, trả về -1.
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == giaTri)
                {
                    return i;
                }
            }

            return -1;
        }

        public int LayGiaTriTaiViTri(int viTri) // Phương thức lấy giá trị tại một vị trí cụ thể trong mảng số nguyên. Nếu vị trí hợp lệ, trả về giá trị tại vị trí đó; nếu vị trí không hợp lệ, ném ra ngoại lệ IndexOutOfRangeException.
        {
            if (viTri < 0 || viTri >= a.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí nằm ngoài phạm vi mảng!");
            }

            return a[viTri];
        }

        public bool XoaTheoGiaTri(int giaTri) // Phương thức xóa phần tử có giá trị cụ thể trong mảng số nguyên. Nếu xóa thành công, trả về true; nếu không tìm thấy giá trị, trả về false.
        {
            int viTri = TimViTriCuaGiaTri(giaTri);

            if (viTri == -1)
            {
                return false;
            }

            a.RemoveAt(viTri);
            return true;
        }

        public void XoaTaiViTri(int viTri) // Phương thức xóa phần tử tại một vị trí cụ thể trong mảng số nguyên. Nếu vị trí hợp lệ, xóa phần tử tại vị trí đó; nếu vị trí không hợp lệ, ném ra ngoại lệ IndexOutOfRangeException.
        {
            if (viTri < 0 || viTri >= a.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí cần xóa không hợp lệ!");
            }

            a.RemoveAt(viTri);
        }

        public void ThemTaiViTri(int viTri, int giaTri) // Phương thức thêm một giá trị vào mảng số nguyên tại một vị trí cụ thể. Nếu vị trí hợp lệ, thêm giá trị vào vị trí đó; nếu vị trí không hợp lệ, ném ra ngoại lệ IndexOutOfRangeException.
        {
            if (viTri < 0 || viTri > a.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí chèn không hợp lệ!");
            }

            a.Insert(viTri, giaTri);
        }

        public long TinhTongMang() // Phương thức tính tổng tất cả các phần tử trong mảng số nguyên và trả về kết quả dưới dạng kiểu long.
        {
            long tong = 0;

            foreach (int so in a)
            {
                tong += so;
            }

            return tong;
        }

        public long TinhTongChan() // Phương thức tính tổng các phần tử chẵn trong mảng số nguyên và trả về kết quả dưới dạng kiểu long.
        {
            long tong = 0;

            foreach (int so in a)
            {
                if (so % 2 == 0)
                {
                    tong += so;
                }
            }

            return tong;
        }

        public long TinhTongLe() // Phương thức tính tổng các phần tử lẻ trong mảng số nguyên và trả về kết quả dưới dạng kiểu long.
        {
            long tong = 0;

            foreach (int so in a)
            {
                if (so % 2 != 0)
                {
                    tong += so;
                }
            }

            return tong;
        }

        public int TimMax() // Phương thức tìm giá trị lớn nhất trong mảng số nguyên và trả về kết quả. Nếu mảng rỗng, ném ra ngoại lệ InvalidOperationException.
        {
            if (a.Count == 0)
            {
                throw new InvalidOperationException("Mảng không có phần tử!");
            }

            int lonNhat = a[0];

            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] > lonNhat)
                {
                    lonNhat = a[i];
                }
            }

            return lonNhat;
        }

        public int TimMin() // Phương thức tìm giá trị nhỏ nhất trong mảng số nguyên và trả về kết quả. Nếu mảng rỗng, ném ra ngoại lệ InvalidOperationException.
        {
            if (a.Count == 0)
            {
                throw new InvalidOperationException("Mảng không có phần tử!");
            }

            int nhoNhat = a[0];

            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] < nhoNhat)
                {
                    nhoNhat = a[i];
                }
            }

            return nhoNhat;
        }

        public bool ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi) //Phương thức thay thế một giá trị cụ thể trong mảng số nguyên bằng một giá trị mới. Nếu tìm thấy giá trị cũ và thay thế thành công, trả về true; nếu không tìm thấy giá trị cũ, trả về false.
        {
            int viTri = TimViTriCuaGiaTri(giaTriCu);

            if (viTri == -1)
            {
                return false;
            }

            a[viTri] = giaTriMoi;
            return true;
        }

        public void ThayTheTaiViTri(int viTri, int giaTriMoi) // Phương thức thay thế giá trị tại một vị trí cụ thể trong mảng số nguyên bằng một giá trị mới. Nếu vị trí hợp lệ, thay thế giá trị tại vị trí đó; nếu vị trí không hợp lệ, ném ra ngoại lệ IndexOutOfRangeException.
        {
            if (viTri < 0 || viTri >= a.Count)
            {
                throw new IndexOutOfRangeException(
                    "Vị trí cần thay thế không hợp lệ!");
            }

            a[viTri] = giaTriMoi;
        }
    }

    public partial class Form1 : Form // Lớp đại diện cho giao diện người dùng của ứng dụng, kế thừa từ lớp Form.
    {
        private MangSoNguyen mang = null; // Biến lưu trữ đối tượng mảng số nguyên, được sử dụng để thao tác với dữ liệu mảng trong giao diện người dùng.

        public Form1()
        {
            InitializeComponent();
        }

        private bool DocDuLieuMang() // Phương thức đọc dữ liệu từ TextBox nhập mảng, kiểm tra tính hợp lệ của dữ liệu và khởi tạo đối tượng MangSoNguyen. Trả về true nếu dữ liệu hợp lệ và mảng được khởi tạo thành công; trả về false nếu có lỗi trong quá trình đọc dữ liệu.
        {
            string input = txtNhapMang.Text.Trim();

            if (input.Length == 0) // Kiểm tra xem TextBox có rỗng hay không.
            {
                MessageBox.Show(
                    "Vui lòng nhập các phần tử của mảng!",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNhapMang.Focus();
                return false;
            }

            string[] tokens = input.Split(
                new char[] { ' ', ',', '\t' },
                StringSplitOptions.RemoveEmptyEntries); // Tách chuỗi nhập liệu thành các phần tử dựa trên dấu cách, dấu phẩy và tab, loại bỏ các phần tử rỗng.

            List<int> danhSach = new List<int>(); // Tạo một danh sách để lưu trữ các phần tử số nguyên hợp lệ.

            foreach (string token in tokens)
            {
                int so;

                if (int.TryParse(token, out so))
                {
                    danhSach.Add(so);
                }
                else
                {
                    MessageBox.Show(
                        $"Phần tử '{token}' không phải là một số nguyên hợp lệ!",
                        "Lỗi dữ liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtNhapMang.Focus();
                    txtNhapMang.SelectAll();

                    return false;
                }
            }

            if (danhSach.Count == 0) // Kiểm tra xem danh sách có phần tử hợp lệ hay không.
            {
                MessageBox.Show(
                    "Mảng chưa có phần tử nào hợp lệ!",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            mang = new MangSoNguyen(danhSach);
            return true;
        }

        private void btnThucHien_Click(object sender, EventArgs e) // Xử lý sự kiện khi người dùng nhấn nút "Thực hiện". Thực hiện các thao tác trên mảng số nguyên dựa trên các lựa chọn của người dùng trong giao diện.
        {
            if (!DocDuLieuMang())
            {
                return;
            }

            if (radTang.Checked)
            {
                mang.SapXepTang();
            }
            else if (radGiam.Checked)// Nếu người dùng chọn sắp xếp giảm dần, thực hiện sắp xếp mảng theo thứ tự giảm dần.
            {
                mang.SapXepGiam();
            }

            if (radTimGiaTri.Checked) // Nếu người dùng chọn tìm kiếm theo giá trị, thực hiện tìm kiếm vị trí của giá trị trong mảng.
            {
                int giaTri;

                if (int.TryParse(txtGiaTriTim.Text.Trim(), out giaTri))
                {
                    int viTri = mang.TimViTriCuaGiaTri(giaTri);

                    if (viTri >= 0)
                    {
                        txtKetQuaTimKiem.Text = viTri.ToString();
                    }
                    else
                    {
                        txtKetQuaTimKiem.Text = "Không thấy";
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Giá trị cần tìm không hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else if (radTimViTri.Checked) // Nếu người dùng chọn tìm kiếm theo vị trí, thực hiện lấy giá trị tại vị trí trong mảng.
            {
                int viTri;

                if (int.TryParse(txtViTriTim.Text.Trim(), out viTri))
                {
                    if (viTri >= 0 && viTri < mang.SoPhanTu)
                    {
                        txtKetQuaTimKiem.Text =
                            mang.LayGiaTriTaiViTri(viTri).ToString();
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Vị trí tìm kiếm phải nằm trong khoảng [0, {mang.SoPhanTu - 1}]!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Vị trí cần tìm không hợp lệ!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            if (radXoaGiaTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;

                int giaTri;

                if (int.TryParse(txtGiaTriXoa.Text.Trim(), out giaTri))
                {
                    bool daXoa = mang.XoaTheoGiaTri(giaTri);

                    if (!daXoa)
                    {
                        MessageBox.Show(
                            $"Không tìm thấy giá trị {giaTri} để xóa!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else if (radXoaViTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;

                int viTri;

                if (int.TryParse(txtViTriXoa.Text.Trim(), out viTri))
                {
                    if (viTri >= 0 && viTri < mang.SoPhanTu)
                    {
                        mang.XoaTaiViTri(viTri);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Vị trí cần xóa phải từ 0 đến {mang.SoPhanTu - 1}!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }

            if (radThemGiaTri.Checked)
            {
                mang.SapXepTang();
                radTang.Checked = true;

                int giaTri;
                int viTri;

                bool hopLeGiaTri =
                    int.TryParse(txtGiaTriThem.Text.Trim(), out giaTri);

                bool hopLeViTri =
                    int.TryParse(txtViTriThem.Text.Trim(), out viTri);

                if (hopLeGiaTri && hopLeViTri)
                {
                    if (viTri >= 0 && viTri <= mang.SoPhanTu)
                    {
                        mang.ThemTaiViTri(viTri, giaTri);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Vị trí thêm phải nằm trong khoảng [0, {mang.SoPhanTu}]!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }

            if (radGiaTriThayThe.Checked)
            {
                int giaTriCu;
                int giaTriMoi;

                bool hopLeCu =
                    int.TryParse(
                        txtGiaTriThayThe.Text.Trim(),
                        out giaTriCu);

                bool hopLeMoi =
                    int.TryParse(
                        txtSoThayThe.Text.Trim(),
                        out giaTriMoi);

                if (hopLeCu && hopLeMoi)
                {
                    bool daThay = mang.ThayTheTheoGiaTri(
                        giaTriCu,
                        giaTriMoi);

                    if (!daThay)
                    {
                        MessageBox.Show(
                            $"Không tìm thấy giá trị {giaTriCu} để thay thế!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else if (radViTriThayThe.Checked)
            {
                int viTri;
                int giaTriMoi;

                bool hopLeViTri =
                    int.TryParse(
                        txtViTriThayThe.Text.Trim(),
                        out viTri);

                bool hopLeGiaTri =
                    int.TryParse(
                        txtSoThayThe.Text.Trim(),
                        out giaTriMoi);

                if (hopLeViTri && hopLeGiaTri)
                {
                    if (viTri >= 0 && viTri < mang.SoPhanTu)
                    {
                        mang.ThayTheTaiViTri(viTri, giaTriMoi);
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Vị trí cần thay thế phải từ 0 đến {mang.SoPhanTu - 1}!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }

            txtKetQuaMang.Text = mang.XuatChuoi();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (mang == null)
            {
                if (!DocDuLieuMang())
                {
                    return;
                }
            }

            txtTongMang.Text = mang.TinhTongMang().ToString();
            txtTongChan.Text = mang.TinhTongChan().ToString();
            txtTongLe.Text = mang.TinhTongLe().ToString();
        }

        private void btnTimMaxMin_Click(object sender, EventArgs e)
        {
            if (mang == null)
            {
                if (!DocDuLieuMang())
                {
                    return;
                }
            }

            txtGiaTriLonNhat.Text = mang.TimMax().ToString();
            txtGiaTriNhoNhat.Text = mang.TimMin().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mang = null;

            txtNhapMang.Clear();
            txtKetQuaMang.Clear();

            txtGiaTriTim.Clear();
            txtViTriTim.Clear();
            txtKetQuaTimKiem.Clear();

            txtGiaTriXoa.Clear();
            txtViTriXoa.Clear();

            txtGiaTriThem.Clear();
            txtViTriThem.Clear();

            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();

            txtGiaTriLonNhat.Clear();
            txtGiaTriNhoNhat.Clear();

            txtGiaTriThayThe.Clear();
            txtViTriThayThe.Clear();
            txtSoThayThe.Clear();

            radTang.Checked = true;

            radTimGiaTri.Checked = false;
            radTimViTri.Checked = false;

            radXoaGiaTri.Checked = false;
            radXoaViTri.Checked = false;

            radThemGiaTri.Checked = false;

            radGiaTriThayThe.Checked = false;
            radViTriThayThe.Checked = false;

            txtNhapMang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult luaChon = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (luaChon == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}