// Bài 11: Viết phương thức thành viên trả về chuỗi là đảo của một chuỗi

using System;

namespace bai11
{
    public class Program
    {
        public static string ChuoiDaoNguoc(string str)
        {
            char[] charArray = str.ToCharArray(); // Chuyển chuỗi thành mảng kí tự
            Array.Reverse(charArray); // Hàm tự động đảo ngược mảng
            return new string(charArray); // trả về mảng kí tự đã đảo ngược thành chuỗi
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine();
            str = ChuoiDaoNguoc(str); // Gọi phương thức để đảo ngược chuỗi
            Console.WriteLine("Chuỗi đảo ngược: " + str); //in ra chuỗi đảo ngược
        }
    }
}