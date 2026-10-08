/* Bài 9. Tham chiếu out
Xây dựng lớp có phương thức tìm giá trị lớn nhất và giá trị nhỏ nhất của ba số thực.*/

using System;

namespace bai09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số thực thứ nhất: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực thứ hai: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực thứ ba: ");
            double c = double.Parse(Console.ReadLine());
            double max, min; //khai báo biến max và min để lưu giá trị lớn nhất và nhỏ nhất
            FindMaxMin(a, b, c, out max, out min); //gọi phương thức FindMaxMin để tìm giá trị lớn nhất và nhỏ nhất
            Console.WriteLine($"Giá trị lớn nhất: {max}");
            Console.WriteLine($"Giá trị nhỏ nhất: {min}");
        }
        static void FindMaxMin(double x, double y, double z, out double max, out double min)
        //phương thức FindMaxMin nhận vào 3 số thực và trả về giá trị lớn nhất và nhỏ nhất thông qua tham chiếu out
        {
            max = Math.Max(x, Math.Max(y, z));
            min = Math.Min(x, Math.Min(y, z));
        }
    }
}