using System.Data;
using System.Data.SqlClient;
using System.Globalization;
namespace Bai01_BTTL_SQL;
public partial class Form1 : Form
{
    public Form1() { InitializeComponent(); }
    private DateTime ngaySinh;
    private decimal diem;
    private void Form_Load(object sender, EventArgs e)
    {
        try { Database.NapCombo(cboLop, "SELECT MaLop FROM dbo.Lop ORDER BY MaLop"); } catch (Exception ex) { Database.BaoLoi(ex); }
    }
    private void KiemTraKhoa()
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text.Trim())) throw new Exception("Vui lòng nhập hoặc chọn đầy đủ mã cần thao tác.");
    }
    private void KiemTraDuLieu()
    {
        if (string.IsNullOrWhiteSpace(cboLop.Text) || string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtNgay.Text)) 
            throw new Exception("Vui lòng nhập đầy đủ thông tin.");
        if (!DateTime.TryParseExact(txtNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh)) 
            throw new Exception("Ngày sinh phải hợp lệ, dạng dd/MM/yyyy.");
        if (DateTime.Today.Year - ngaySinh.Year < 17) 
            throw new Exception("Sinh viên phải từ 17 tuổi, tính theo năm sinh.");
        if (!Database.TonTai("SELECT 1 FROM dbo.Lop WHERE MaLop=@ma", Database.P("@ma", cboLop.Text))) 
            throw new Exception("Mã lớp không tồn tại.");
    }
    // Kiểm tra khóa chính bằng SqlDataReader trước khi thao tác.
    private bool DaTonTai() => Database.TonTai("SELECT 1 FROM dbo.SinhVien WHERE MaSinhVien=@k0", Database.P("@k0", txtMa.Text.Trim()));
    private void Them_Click(object sender, EventArgs e)
    {
        try
        {
            KiemTraKhoa(); KiemTraDuLieu();
            if (DaTonTai()) throw new Exception("Trùng khóa chính. Dữ liệu đã tồn tại.");
            Database.ThucHien("INSERT INTO dbo.SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES (@v0, @v1, @v2, @v3)", 
            Database.P("@v0", txtMa.Text.Trim()), Database.P("@v1", txtTen.Text.Trim()), Database.P("@v2", ngaySinh), Database.P("@v3", cboLop.Text));
            MessageBox.Show("Thêm thành công.");
        }
        catch (Exception ex) { Database.BaoLoi(ex); }
    }
    private void Xoa_Click(object sender, EventArgs e)
    {
        try
        {
            KiemTraKhoa();
            if (!DaTonTai()) throw new Exception("Không tìm thấy dữ liệu cần xóa.");
            if (Database.TonTai("SELECT 1 FROM dbo.Diem WHERE MaSinhVien=@k0", 
            Database.P("@k0", txtMa.Text.Trim()))) throw new Exception("Không thể xóa vì đang có dữ liệu tham chiếu.");
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            int soDong = Database.ThucHien("DELETE FROM dbo.SinhVien WHERE MaSinhVien=@k0", Database.P("@k0", txtMa.Text.Trim()));
            MessageBox.Show(soDong > 0 ? "Xóa thành công." : "Dữ liệu không còn tồn tại.");
        }
        catch (Exception ex) { Database.BaoLoi(ex); }
    }
    private void Sua_Click(object sender, EventArgs e)
    {
        try
        {
            KiemTraKhoa(); KiemTraDuLieu();
            if (!DaTonTai()) throw new Exception("Không tìm thấy dữ liệu cần sửa.");
            // Mã là điều kiện tìm kiếm; chỉ cập nhật các cột không thuộc khóa chính.
            int soDong = Database.ThucHien("UPDATE dbo.SinhVien SET HoTen=@v1, NgaySinh=@v2, MaLop=@v3 WHERE MaSinhVien=@k0", 
                Database.P("@v1", txtTen.Text.Trim()), Database.P("@v2", ngaySinh), Database.P("@v3", cboLop.Text), Database.P("@k0", txtMa.Text.Trim()));
            MessageBox.Show(soDong > 0 ? "Sửa thành công." : "Dữ liệu không còn tồn tại.");
        }
        catch (Exception ex) { Database.BaoLoi(ex); }
    }
}
