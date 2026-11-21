using System.Data;
using System.Data.SqlClient;
namespace Bai01_BTM_SQL;
internal static class Database
{
    // Sửa tên server tại đây nếu chạy trên máy khác.
    public const string KetNoi = @"Data Source=GINGPHAMPC;Initial Catalog=QLSinhVien_Lab06b;Integrated Security=True;TrustServerCertificate=True;";
    public static SqlParameter P(string ten, object giaTri) => new SqlParameter(ten, giaTri);
    public static SqlConnection Mo()
    {
        var cn = new SqlConnection(KetNoi);
        try { cn.Open(); return cn; }
        catch { cn.Dispose(); throw; }
    }
    // Dùng SqlDataReader kiểm tra sự tồn tại của khóa.
    public static bool TonTai(string sql, params SqlParameter[] ps)
    {
        using var cn = Mo();
        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddRange(ps);
        using var rd = cmd.ExecuteReader();
        return rd.HasRows;
    }
    public static int ThucHien(string sql, params SqlParameter[] ps)
    {
        using var cn = Mo();
        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddRange(ps);
        return cmd.ExecuteNonQuery();
    }
    public static void NapCombo(ComboBox cbo, string sql, bool tatCa = false)
    {
        cbo.Items.Clear();
        if (tatCa) cbo.Items.Add("");
        using var cn = Mo();
        using var cmd = new SqlCommand(sql, cn);
        using var rd = cmd.ExecuteReader();
        while (rd.Read()) cbo.Items.Add(rd[0].ToString());
        if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
    }
    // Phân biệt lỗi dữ liệu với lỗi kết nối để người dùng biết cách sửa.
    public static void BaoLoi(Exception ex)
    {
        string s = ex.Message;
        if (ex is SqlException e)
        {
            if (e.Number == 2627 || e.Number == 2601) s = "Trùng khóa chính. Vui lòng dùng mã khác.";
            else if (e.Number == 547) s = "Vi phạm khóa ngoại hoặc điều kiện dữ liệu. Kiểm tra bản ghi liên quan.";
        }
        MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
