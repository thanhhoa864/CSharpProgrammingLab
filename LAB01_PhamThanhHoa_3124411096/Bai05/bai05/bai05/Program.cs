/* Bài 5: Viết chương trình in ra menu sau lên màn hình và xử lý các lựa chọn tương ứng
MENU
1. Nhap hai gia tri so thuc cho x, y
2. Tinh x^y
3. Tinh can bac 2 cua x va y
4. Thoat
Chon chuc nang: */
using System;

namespace bai05
{
    class Program { 
        static void Main(string[] args)
        {
            double x = 0, y = 0; // vì x và y là số thực nên khai báo kiểu double
            int choice; // khai báo biến choice để lưu lựa chọn của người dùng
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhập 2 giá trị x và y");
                Console.WriteLine("2. Tính x^y");
                Console.WriteLine("3. Tính căn bậc 2 của x và y");
                Console.WriteLine("4. Thoát");
                Console.Write("Chọn chức năng: ");
                choice = int.Parse(Console.ReadLine()); // đọc lựa chọn của người dùng và chuyển đổi sang kiểu int
                switch (choice)
                {
                    case 1: //nhập 2 giá trị x và y từ bàn phím
                        Console.Write("Nhập giá trị x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Nhập giá trị y: ");
                        y = double.Parse(Console.ReadLine());
                        break;
                    case 2: // tính giá trị x^y và in ra màn hình
                        Console.WriteLine($"Kết quả {x}^{y} = {Math.Pow(x, y)}");
                        break;
                    case 3: // tính căn bậc 2 của x và y và in ra màn hình
                        Console.WriteLine($"Căn bậc 2 của {x} = {Math.Sqrt(x)}");
                        Console.WriteLine($"Căn bậc 2 của {y} = {Math.Sqrt(y)}");
                        break;
                    case 4: // thoát chương trình nếu nhập 4
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (choice != 4); // vòng lặp sẽ tiếp tục cho đến khi người dùng chọn thoát (4)
        }
    }
}