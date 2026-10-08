/* Bài 14. Tính lương 1 nhân viên
Viết chương trình nhập thông tin một nhân viên (họ tên, mức lương, số ngày vắng). Tính và xuất lương
của nhân viên, biết rằng một ngày vắng sẽ bị trừ 100.000 VNĐ. */

using System;
namespace Bai14 {
    class NhanVien
    {
        // Các thuộc tính lưu thông tin
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;

        // Nhập thông tin
        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập mức lương (VNĐ): ");
            MucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhập số ngày vắng: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        // Tính lương thực nhận
        public double TinhLuong()
        {
            return MucLuong - (SoNgayVang * 100000);
        }

        // Phương thức thành viên: Xuất thông tin
        public void Xuat()
        {
            Console.WriteLine("\n--- THÔNG TIN LƯƠNG NHÂN VIÊN ---");
            Console.WriteLine($"Họ tên:         {HoTen}");
            Console.WriteLine($"Mức lương gốc:  {MucLuong:N0} VNĐ"); //N0 để định dạng số với dấu phân cách hàng nghìn
            Console.WriteLine($"Số ngày vắng:   {SoNgayVang}");
            Console.WriteLine($"Lương thực nhận: {TinhLuong():N0} VNĐ"); //N0 để định dạng số với dấu phân cách hàng nghìn
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo đối tượng và gọi phương thức
            NhanVien nv = new NhanVien();
            nv.Nhap();
            nv.Xuat();
        }
    }
}