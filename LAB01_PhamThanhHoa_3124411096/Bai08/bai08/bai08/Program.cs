//Xây dựng lớp có phương thức hoán vị hai số thực.

using System;

namespace bai08
{
    class Program
    {
        public static void HoanVi(ref double a, ref double b) // Phương thức hoán vị hai số thực

        {
            double temp = a; // Lưu giá trị của a vào biến tạm thời
            a = b; // Gán giá trị của b cho a
            b = temp; // Gán giá trị của biến tạm thời cho b
        }
    
        public static void Main(string[] args)
        {
            Console.Write("Nhập số thực thứ nhất: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập số thực thứ hai: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Trước khi hoán vị: "+num1+" "+num2); // In ra giá trị trước khi hoán vị
            HoanVi(ref num1, ref num2);
            Console.WriteLine("Sau khi hoán vị: "+num1+" "+num2); // In ra giá trị sau khi hoán vị
        }
    }
}