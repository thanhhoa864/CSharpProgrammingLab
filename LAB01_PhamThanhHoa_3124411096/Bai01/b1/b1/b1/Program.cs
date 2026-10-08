using System;

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho cua ban: ");
            string surname = Console.ReadLine();
            Console.Write("Nhap ten cua ban: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Ho va ten cua ban la: {surname} {name}");
        }
    }
}