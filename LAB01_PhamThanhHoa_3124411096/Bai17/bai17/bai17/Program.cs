/*Bài 17: Viết các phương thức thành viên sau:
• Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100] (n,m nhập từ bàn phím)
• In mảng ra màn hình
• Trả về hai mảng: mảng các số chẳn và mảng các số lẻ*/

using System;

namespace Bai17
{
    public class Program
    {
        // Sinh ngẫu nhiên mảng A[nxm] trong đoạn [10, 100] (yêu cầu 1)
        public static void Input(int[,] arr)
        {
            // Tạo đối tượng Random để sinh số ngẫu nhiên
            Random random = new Random();

            // Duyệt qua từng dòng của mảng
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Duyệt qua từng cột của mảng
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Sinh số ngẫu nhiên từ 10 đến 100
                    arr[i, j] = random.Next(10, 101);
                }
            }
        }

        // In mảng ra màn hình (yêu cầu 2)
        public static void Output(int[,] arr)
        {
            Console.WriteLine("Mảng vừa sinh là:");
            // Duyệt qua từng dòng của mảng
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Duyệt qua từng cột của mảng
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // In phần tử hiện tại ra màn hình
                    Console.Write(arr[i, j] + "\t");
                }
                // Xuống dòng sau khi in xong một dòng của mảng
                Console.WriteLine();
            }
        }

        // Trả về hai mảng: mảng số chẵn và mảng số lẻ (yêu cầu 3)
        public static void GetEvenOdd(int[,] arr, out int[] even, out int[] odd)
        {
            // Khai báo biến đếm số lượng số chẵn
            int evenCount = 0;
            // Khai báo biến đếm số lượng số lẻ
            int oddCount = 0;
            // Duyệt qua từng dòng của mảng
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Duyệt qua từng cột của mảng
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Kiểm tra phần tử có phải số chẵn không
                    if (arr[i, j] % 2 == 0)
                    {
                        // Nếu là số chẵn thì tăng số lượng số chẵn
                        evenCount++;
                    }
                    else
                    {
                        // Nếu không phải số chẵn thì là số lẻ
                        oddCount++;
                    }
                }
            }
            // Tạo mảng chứa các số chẵn với kích thước bằng số lượng số chẵn
            even = new int[evenCount];
            // Tạo mảng chứa các số lẻ với kích thước bằng số lượng số lẻ
            odd = new int[oddCount];
            // Vị trí để đưa số chẵn vào mảng even
            int evenIndex = 0;
            // Vị trí để đưa số lẻ vào mảng odd
            int oddIndex = 0;
            // Duyệt lại từng dòng của mảng
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Duyệt lại từng cột của mảng
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Kiểm tra phần tử có phải số chẵn không
                    if (arr[i, j] % 2 == 0)
                    {
                        // Đưa số chẵn vào mảng even
                        even[evenIndex] = arr[i, j];
                        // Tăng vị trí của mảng even
                        evenIndex++;
                    }
                    else
                    {
                        // Đưa số lẻ vào mảng odd
                        odd[oddIndex] = arr[i, j];
                        // Tăng vị trí của mảng odd
                        oddIndex++;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            // Nhập số dòng n từ bàn phím
            Console.Write("Nhập số dòng n: ");
            int n = int.Parse(Console.ReadLine());
            // Nhập số cột m từ bàn phím
            Console.Write("Nhập số cột m: ");
            int m = int.Parse(Console.ReadLine());
            // Khai báo mảng 2 chiều có n dòng và m cột
            int[,] A = new int[n, m];
            // Gọi phương thức sinh ngẫu nhiên mảng
            Input(A);
            // Gọi phương thức in mảng
            Output(A);
            // Gọi phương thức lấy mảng số chẵn và số lẻ
            GetEvenOdd(A, out int[] even, out int[] odd);
            // In các số chẵn
            Console.Write("\nMảng các số chẵn: ");
            // Duyệt qua mảng số chẵn
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }
            // In các số lẻ
            Console.Write("\nMảng các số lẻ: ");
            // Duyệt qua mảng số lẻ
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }
}