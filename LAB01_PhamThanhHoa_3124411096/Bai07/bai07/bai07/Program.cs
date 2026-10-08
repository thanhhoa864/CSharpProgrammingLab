// xây dựng lớp có phương thức kiểm tra n có phải là số nguyên tố hay không.

using System;

namespace bai07
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine($"{n} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            }
        }
    }
}