/* Bài 15: Viết các phương thức thành viên sau:
• Nhập mảng gồm n phần tử
• In mảng ra màn hình
• Tìm phẩn tử lớn nhất và nhỏ nhất trong mảng
• Trả về mảng các số nguyên tố */

using System;
using System.Globalization;

namespace Bai15
{
    public class Program
    {
        // Nhập mảng gồm n phần tử
        public static void Input(int[] arr)
        {
            for (int i=0; i<arr.Length; i++) //chạy vòng lặp
            {
                Console.Write($"Nhập phần tử thứ {i}: ");
                arr[i] = int.Parse(Console.ReadLine()); //gán các phần tử vào mảng
            }
        }
        // In mảng ra màn hình
        public static void Output(int[] arr)
        {
            Console.Write("Mảng vừa nhập là: ");
            for (int i = 0; i < arr.Length; i++) { // chạy vòng lặp
                Console.Write(arr[i] + " "); //in ra từng phần tử cách nhau bởi dấu cách
            }
        }
        // tìm phần tử lớn nhất có trong mảng
        public static int FindMax(int[] arr)
        {
            int max = arr[0]; //đặt max có giá trị bằng phần tử đầu tiên
            for (int i = 0; i < arr.Length; i++) //chạy vòng lặp
            {
                if (arr[i] > max) //nếu phần tử trong mảng lớn hơn max
                {
                    max = arr[i]; //đặt max là phần tử được kiểm tra
                }
            }
            return max;
        }
        // tìm phần tử bé nhất có trong mảng
        public static int FindMin(int[] arr)
        {
            int min = arr[0]; //đặt min có giá trị bằng phần tử đầu tiên
            for (int i=0; i<arr.Length; i++) //chạy vòng lặp
            {
                if (arr[i] < min)  //nếu phần tử trong mảng bé hơn min
                { 
                    min =arr[i]; //đặt min là phần tử được kiểm tra
                }
            }
            return min;
        }
        // Kiểm tra xem có phải số nguyên tố không
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false; // nếu n<=1 thì không phải số nguyên tố
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++) //tối ưu độ phức tạp để giảm khoảng vòng lặp
                {
                    if (n % i == 0)//kiểm tra số nguyên tố
                    {
                        return false;//trả về sai
                    }
                }
                return true;//trả về đúng
            }
        }
        // Tính số lượng số nguyên tố trong mảng và in ra các số nguyên tố đó
        public static int[] PrintPrimes(int[] arr)
        {
            int count = 0; //Khởi tạo biến đếm số lượng số nguyên tố
            for(int i = 0; i<arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    count++;//Tăng biên đếm nếu có phần tử là SNT
                }
            }
            int[] primeArray=new int[count];//tạo một mảng mới có kích thước bằng số lượng số nguyên tố
            int index = 0;//khai báo biến index để lưu vị trí của phần tử trong mảng mới
            for (int i = 0; i < arr.Length; i++)//chạy vòng lặp
            {
                if (IsPrime(arr[i])) //kiểm tra phần tử có phải là số nguyên tố không
                {
                    primeArray[index] = arr[i];//nếu là số nguyên tố thì gán vào mảng mới
                    index++;//tăng biến index lên 1 để lưu vị trí của phần tử tiếp theo trong mảng mới
                }
            }

            return primeArray;//trả về mảng mới chứa các số nguyên tố
        }
        //Hàm main
        public static void Main(string[] args) { 
            Console.Write("Nhập số lượng phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine()); //khai báo biến n để nhập số lượng phần tử của mảng
            int[] Numbers = new int[n]; //khai báo mảng Numbers có cố định n phần tử
            Input(Numbers); //sử dụng phương thức Input để nhập các phần tử của mảng Numbers
            Output(Numbers); //sử dụng phương thức Output để in mảng Numbers ra màn hình
            Console.WriteLine("\nPhần tử lớn nhất trong mảng " + FindMax(Numbers)); //in ra phần tử lớn nhất
            Console.WriteLine("Phần tử nhỏ nhất trong mảng " + FindMin(Numbers)); //in ra phần tử nhỏ nhất
            int[] primeNumbers = PrintPrimes(Numbers);//gọi phương thức PrintPrimes để lấy mảng các số nguyên tố từ mảng Numbers
            Console.Write("Các số nguyên tố: ");

            for (int i = 0; i < primeNumbers.Length; i++)//chạy vòng lặp để in ra các số nguyên tố
            {
                Console.Write(primeNumbers[i] + " ");//in ra từng phần tử cách nhau bởi dấu cách
            }
        }
    }
}