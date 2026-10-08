/*Bài 13. Nhập xuất thông tin sinh viên
Xây dựng lớp sinh viên để lưu trữ 1 sinh viên (mã sinh viên, họ tên, địa chỉ, sinh viên năm thứ mấy). Hãy
nhập xuất 1 sinh viên.*/

using System;

namespace Bai13
{
    class SinhVien
    {
        public string MaSinhVien { get; set; } // mã sinh viên
        public string HoTen { get; set; } // họ tên sinh viên
        public string DiaChi { get; set; } // địa chỉ sinh viên
        public int NamThu { get; set; } // sinh viên năm thứ mấy
        public void NhapThongTin()
        {
            Console.Write("Nhập mã sinh viên: ");
            MaSinhVien = Console.ReadLine(); // nhập mã sinh viên
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine(); // nhập họ tên sinh viên
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();// nhập địa chỉ sinh viên
            Console.Write("Nhập năm thứ mấy: ");
            NamThu = int.Parse(Console.ReadLine()); // nhập năm thứ mấy
        }
        public void XuatThongTin()// xuất thông tin sinh viên
        {
            Console.WriteLine("Mã sinh viên: " + MaSinhVien);
            Console.WriteLine("Họ tên: " + HoTen);
            Console.WriteLine("Địa chỉ: " + DiaChi);
            Console.WriteLine("Năm thứ mấy: " + NamThu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien(); // tạo đối tượng sinh viên
            sv.NhapThongTin(); // gọi phương thức nhập thông tin sinh viên
            sv.XuatThongTin(); // gọi phương thức xuất thông tin sinh viên
        }
    }
}