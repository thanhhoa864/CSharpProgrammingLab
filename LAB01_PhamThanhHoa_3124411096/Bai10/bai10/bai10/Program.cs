// Bài 10: Viết phương thức thành viên kiểm tra chuỗi có đối xứng hay không

using System;

namespace bai10
{
    class Program {
        public static bool ChuoiDoiXUng(string str)
        {
            int left = 0;
            int right = str.Length - 1; // Khởi tạo chỉ số trái và phải
            while (left < right) // Lặp cho đến khi chỉ số trái lớn hơn hoặc bằng chỉ số phải
            {
                if (str[left] != str[right]) // Nếu ký tự trái và phải không giống nhau
                {
                    return false; // Trả về false
                }
                left++; // Tăng chỉ số trái
                right--; // Giảm chỉ số phải
            }
            return true; // Trả về true nếu chuỗi đối xứng
        }
        public static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string str = Console.ReadLine(); // Nhập chuỗi từ bàn phím
            if (ChuoiDoiXUng(str)) // Kiểm tra chuỗi có đối xứng hay không
            {
                Console.WriteLine("Chuỗi đối xứng"); // Nếu đối xứng, in ra thông báo
            }
            else
            {
                Console.WriteLine("Chuỗi không đối xứng"); // Nếu không đối xứng, in ra thông báo
            }
        }
    }
}