using System.Data;
using System.Data.SqlClient;
using System.Globalization;
namespace Bai01_BTM_SQL;
public partial class Form1 : Form
{
    public Form1() { InitializeComponent(); }
    private DateTime ngaySinh;
    private decimal diem;
    private void Form_Load(object sender, EventArgs e)
    {
        try {  } catch (Exception ex) { Database.BaoLoi(ex); }
    }
    private void KiemTraKhoa()
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text.Trim())) throw new Exception("Vui lòng nhập hoặc chọn đầy đủ mã cần thao tác.");
    }
    private void KiemTraDuLieu()
    {
        if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text)) throw new Exception("Vui lòng nhập đầy đủ thông tin.");
        
    }
    // Kiểm tra khóa chính bằng SqlDataReader trước khi thao tác.
    private bool DaTonTai() => Database.TonTai("SELECT 1 FROM dbo.Khoa WHERE MaKhoa=@k0", Database.P("@k0", txtMa.Text.Trim()));
    private void Them_Click(object sender, EventArgs e)
    {
        try
        {
            KiemTraKhoa(); KiemTraDuLieu();
            if (DaTonTai()) throw new Exception("Trùng khóa chính. Dữ liệu đã tồn tại.");
            Database.ThucHien("INSERT INTO dbo.Khoa (MaKhoa, TenKhoa) VALUES (@v0, @v1)", Database.P("@v0", txtMa.Text.Trim()), Database.P("@v1", txtTen.Text.Trim()));
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
            if (Database.TonTai("SELECT 1 FROM dbo.Lop WHERE MaKhoa=@k0", Database.P("@k0", txtMa.Text.Trim()))) throw new Exception("Không thể xóa vì đang có dữ liệu tham chiếu.");
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            int soDong = Database.ThucHien("DELETE FROM dbo.Khoa WHERE MaKhoa=@k0", Database.P("@k0", txtMa.Text.Trim()));
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
            int soDong = Database.ThucHien("UPDATE dbo.Khoa SET TenKhoa=@v1 WHERE MaKhoa=@k0", Database.P("@v1", txtTen.Text.Trim()), Database.P("@k0", txtMa.Text.Trim()));
            MessageBox.Show(soDong > 0 ? "Sửa thành công." : "Dữ liệu không còn tồn tại.");
        }
        catch (Exception ex) { Database.BaoLoi(ex); }
    }
}
