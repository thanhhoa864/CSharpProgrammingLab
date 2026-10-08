//Viết chương trình nhập hai số nguyên x, y. Tính x mũ y và xuất theo định dạng
using System;

namespace bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên x: ");
            int x = int.Parse(Console.ReadLine()); //lưu biến x dưới dạng số nguyên
            Console.Write("Nhập số nguyên y: ");
            int y = int.Parse(Console.ReadLine()); //lưu biến y dưới dạng số nguyên
            double result = Math.Pow(x, y); // sử dụng Math.Pow để tính x mũ y
            Console.WriteLine($"kết quả của {x} mũ {y} là {result}");
        }
    }
}