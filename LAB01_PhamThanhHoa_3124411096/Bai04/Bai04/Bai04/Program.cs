using System;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 1. Nhập và kiểm tra x ---
            Console.Write("Nhập số nguyên x: ");
            string x = Console.ReadLine();

            // Nếu KHÔNG PHẢI số nguyên thì báo lỗi và dừng
            if (!int.TryParse(x, out int numberx))
            {
                Console.WriteLine("Lỗi: x không phải là số nguyên!");
                return; // Thoát chương trình vì nhập sai
            }

            // --- 2. Nhập và kiểm tra y ---
            Console.Write("Nhập số nguyên y: ");
            string y = Console.ReadLine();
            // Nếu KHÔNG PHẢI số nguyên thì báo lỗi và dừng
            if (!int.TryParse(y, out int numbery))
            {
                Console.WriteLine("Lỗi: y không phải là số nguyên!");
                return; // Thoát chương trình vì nhập sai
            }

            // --- 3. Tính toán và xuất kết quả ---
            double result = Math.Pow(numberx, numbery);
            Console.WriteLine($"Kết quả của {numberx} mũ {numbery} là: {result}");
        }
    }
}