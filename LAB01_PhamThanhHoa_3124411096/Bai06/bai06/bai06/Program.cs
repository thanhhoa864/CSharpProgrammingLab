// Xây dựng lớp có phương thức tìm giá trị lớn nhất của ba số nguyên.
using System;

namespace bai06
{
    class Program { 
        public  static int Max(int a, int b, int c)
        {
            return (a > b && a > c) ? a : (b > c) ? b : c; //sử dụng toán tử điều kiện để tìm số lớn nhất
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số nguyên thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số nguyên thứ ba: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Số lớn nhất là: " + Max(a, b, c)); //gọi phương thức Max để tìm số lớn nhất
        }
    }
}