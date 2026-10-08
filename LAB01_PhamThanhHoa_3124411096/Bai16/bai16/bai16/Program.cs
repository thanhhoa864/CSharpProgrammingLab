//Bài 16: Nhập vào một mảng họ tên của n người. Hãy sắp xếp mảng đó theo thứ tự tăng dần

using System;

namespace Bai16
{
    public class Program
    {
        // Nhập mảng họ tên
        public static void Input(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++) //chạy vòng lặp
            {
                Console.Write($"Nhập họ tên thứ {i+1}: ");
                arr[i] = Console.ReadLine();
            }
        }

        // In mảng
        public static void Output(string[] arr)
        {
            Console.WriteLine("Danh sách sau khi sắp xếp:"); //in ra danh sách sau khi sắp xếp

            for (int i = 0; i < arr.Length; i++) //chạy vòng lặp
            {
                Console.WriteLine(arr[i]);
            }
        }

        // Sắp xếp tăng dần
        public static void Sort(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++) //chạy vòng lặp
            {
                for (int j = i + 1; j < arr.Length; j++) //chạy vòng lặp
                {
                    if (string.Compare(arr[i], arr[j]) > 0) //so sánh hai chuỗi
                    {
                        string temp = arr[i];//lưu giá trị của arr[i] vào biến temp
                        arr[i] = arr[j];//gán giá trị của arr[j] cho arr[i]
                        arr[j] = temp;//gán giá trị của temp cho arr[j]
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Nhập số lượng người: ");
            int n = int.Parse(Console.ReadLine()); //nhập số lượng người

            string[] names = new string[n]; //khởi tạo mảng họ tên với kích thước n

            Input(names);//gọi hàm Input để nhập mảng họ tên
            Sort(names);//gọi hàm Sort để sắp xếp mảng họ tên
            Output(names);//gọi hàm Output để in mảng họ tên sau khi sắp xếp
        }
    }
}