using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQCoBanVaNangCao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập mã hóa UTF-8 để Console có thể hiển thị tiếng Việt có dấu
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Gọi lần lượt từng phương thức để chạy các bài tập
            Bai21();
            Bai22();
            Bai31();
            Bai32();
            Bai41();
            Bai51();
            Bai52();
            Bai61();
            Bai62();

            // Thông báo khi tất cả các bài đã được thực hiện xong
            Console.WriteLine("\nKẾT THÚC CHƯƠNG TRÌNH");

            // Tạm dừng chương trình để xem kết quả trước khi cửa sổ Console đóng
            Console.ReadKey();
        }

        // Hàm dùng chung để in từng phần tử của một danh sách
        // T giúp hàm có thể sử dụng cho nhiều kiểu dữ liệu khác nhau
        static void InDanhSach<T>(IEnumerable<T> danhSach)
        {
            // Duyệt lần lượt từng phần tử trong danh sách
            foreach (var item in danhSach)
            {
                // In phần tử hiện tại ra màn hình
                Console.WriteLine(item);
            }
        }

        static void Bai21()
        {
            // In tiêu đề để phân biệt kết quả của bài 2.1
            Console.WriteLine("\nBÀI 2.1");

            // Khai báo một mảng số nguyên gồm các giá trị được cho trong đề
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };

            // Query Syntax:
            // Lọc những số vừa chia hết cho 4 vừa chia hết cho 3
            var aQuery =
                from x in mangSo
                where x % 4 == 0 && x % 3 == 0
                select x;

            // Method Syntax:
            // Dùng phương thức Where() để thực hiện điều kiện lọc tương tự Query Syntax
            var aMethod = mangSo
                .Where(x => x % 4 == 0 && x % 3 == 0);

            // In kết quả của câu a sử dụng Query Syntax
            Console.WriteLine("\nCâu a - Query:");
            InDanhSach(aQuery);

            // In kết quả của câu a sử dụng Method Syntax
            Console.WriteLine("Câu a - Method:");
            InDanhSach(aMethod);

            // Query Syntax:
            // Lấy những số nhỏ hơn hoặc bằng 3
            var bQuery =
                from x in mangSo
                where x <= 3
                select x;

            // Method Syntax:
            // Dùng Where() để lọc những số nhỏ hơn hoặc bằng 3
            var bMethod = mangSo
                .Where(x => x <= 3);

            // In kết quả câu b theo Query Syntax
            Console.WriteLine("\nCâu b - Query:");
            InDanhSach(bQuery);

            // In kết quả câu b theo Method Syntax
            Console.WriteLine("Câu b - Method:");
            InDanhSach(bMethod);

            // Query Syntax:
            // Nếu số là số chẵn thì chia số đó cho 2
            // Nếu số là số lẻ thì giữ nguyên giá trị ban đầu
            var cQuery =
                from x in mangSo
                select x % 2 == 0 ? x / 2 : x;

            // Method Syntax:
            // Dùng Select() để biến đổi từng phần tử trong mảng
            var cMethod = mangSo
                .Select(x => x % 2 == 0 ? x / 2 : x);

            // In kết quả câu c theo Query Syntax
            Console.WriteLine("\nCâu c - Query:");
            InDanhSach(cQuery);

            // In kết quả câu c theo Method Syntax
            Console.WriteLine("Câu c - Method:");
            InDanhSach(cMethod);
        }

        static void Bai22()
        {
            // In tiêu đề bài 2.2
            Console.WriteLine("\nBÀI 2.2");

            // Khai báo mảng chuỗi chứa các từ được cung cấp trong bài
            string[] mangChuoi =
            {
                "đầu", "lòng", "hai", "ả", "tố", "nga",
                "Thúy", "Kiều", "là", "chị", "em",
                "là", "Thúy", "Vân"
            };

            // Query Syntax:
            // Chỉ lấy những chuỗi có đúng 4 ký tự
            // Sau đó sắp xếp tăng dần dựa trên ký tự đầu tiên
            var aQuery =
                from x in mangChuoi
                where x.Length == 4
                orderby x[0]
                select x;

            // Method Syntax:
            // Where() dùng để lọc chuỗi có độ dài bằng 4
            // OrderBy() dùng để sắp xếp theo ký tự đầu tiên
            var aMethod = mangChuoi
                .Where(x => x.Length == 4)
                .OrderBy(x => x[0]);

            // In kết quả Query Syntax
            Console.WriteLine("\nCâu a - Query:");
            InDanhSach(aQuery);

            // In kết quả Method Syntax
            Console.WriteLine("Câu a - Method:");
            InDanhSach(aMethod);

            // Chuyển từng chuỗi thành dạng:
            // chữ thường - CHỮ HOA
            var b =
                from x in mangChuoi
                select $"{x.ToLower()} - {x.ToUpper()}";

            // In kết quả câu b
            Console.WriteLine("\nCâu b:");
            InDanhSach(b);

            // Lọc những chuỗi có chứa ký tự "u"
            var c =
                from x in mangChuoi
                where x.Contains("u")
                select x;

            // In kết quả câu c
            Console.WriteLine("\nCâu c:");
            InDanhSach(c);

            // Chỉ lấy những chuỗi có ký tự đầu tiên là chữ in hoa
            var d =
                from x in mangChuoi
                where x.Length > 0 && char.IsUpper(x[0])
                select x;

            // In kết quả câu d
            Console.WriteLine("\nCâu d:");
            InDanhSach(d);
        }

        static void Bai31()
        {
            // In tiêu đề bài 3.1
            Console.WriteLine("\nBÀI 3.1");

            // Khai báo mảng số nguyên có chứa một số giá trị bị lặp
            int[] mangSo =
            {
                50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85
            };

            // Count() đếm tổng số phần tử trong mảng
            int tongSoPhanTu = mangSo.Count();

            // Count() kết hợp điều kiện để đếm số phần tử là số chẵn
            int soChan = mangSo.Count(x => x % 2 == 0);

            // Count() kết hợp điều kiện để đếm số phần tử là số lẻ
            int soLe = mangSo.Count(x => x % 2 != 0);

            // In kết quả câu a
            Console.WriteLine("\nCâu a:");
            Console.WriteLine($"Tổng số phần tử: {tongSoPhanTu}");
            Console.WriteLine($"Số chẵn: {soChan}");
            Console.WriteLine($"Số lẻ: {soLe}");

            // Sum() tính tổng tất cả các phần tử trong mảng
            int tong = mangSo.Sum();

            // Max() tìm giá trị lớn nhất
            int lonNhat = mangSo.Max();

            // Min() tìm giá trị nhỏ nhất
            int nhoNhat = mangSo.Min();

            // In kết quả câu b
            Console.WriteLine("\nCâu b:");
            Console.WriteLine($"Tổng: {tong}");
            Console.WriteLine($"Lớn nhất: {lonNhat}");
            Console.WriteLine($"Nhỏ nhất: {nhoNhat}");

            // Distinct() loại bỏ những giá trị bị trùng
            // Count() sau đó đếm số giá trị khác nhau
            int soGiaTriKhacNhau = mangSo
                .Distinct()
                .Count();

            // In kết quả câu c
            Console.WriteLine("\nCâu c - Số giá trị khác nhau:");
            Console.WriteLine(soGiaTriKhacNhau);

            // GroupBy() nhóm các số dựa trên số dư khi chia cho 5
            // Ví dụ: các số có cùng số dư 0 sẽ nằm trong cùng một nhóm
            var nhom =
                mangSo
                    .GroupBy(x => x % 5)
                    .OrderBy(g => g.Key);

            // In từng nhóm kết quả
            Console.WriteLine("\nCâu d - Nhóm theo số dư:");

            foreach (var group in nhom)
            {
                // Key chính là số dư khi chia cho 5
                Console.WriteLine($"Số dư {group.Key}:");

                // Duyệt các số thuộc nhóm hiện tại
                foreach (var so in group)
                {
                    Console.WriteLine($"  {so}");
                }
            }
        }

        static void Bai32()
        {
            // In tiêu đề bài 3.2
            Console.WriteLine("\nBÀI 3.2");

            // Khai báo danh sách các món ăn
            string[] monAn =
            {
                "Bún bò Huế",
                "Hủ tiếu heo",
                "Bánh canh",
                "Bánh mì",
                "Nước Cà phê",
                "Mì quảng",
                "Cơm tấm",
                "Nước Chanh dây",
                "Mì xào",
                "Bún riêu",
                "Bánh cuốn",
                "Mì gói",
                "Bún chả",
                "Hủ tiếu Nam vang"
            };

            // Min() tìm độ dài nhỏ nhất của một chuỗi trong danh sách
            int minLen = monAn.Min(x => x.Length);

            // Max() tìm độ dài lớn nhất của một chuỗi trong danh sách
            int maxLen = monAn.Max(x => x.Length);

            // Lọc ra những món có độ dài bằng độ dài nhỏ nhất
            var monNgan =
                monAn.Where(x => x.Length == minLen);

            // In những món ngắn nhất
            Console.WriteLine("\nCâu a - Món ngắn nhất:");
            InDanhSach(monNgan);

            // Lọc ra những món có độ dài bằng độ dài lớn nhất
            var monDai =
                monAn.Where(x => x.Length == maxLen);

            // In những món dài nhất
            Console.WriteLine("Câu a - Món dài nhất:");
            InDanhSach(monDai);

            // GroupBy() lấy từ đầu tiên của mỗi tên món
            // Ví dụ "Bánh canh" sẽ thuộc nhóm "Bánh"
            var nhomMon =
                monAn
                    .GroupBy(x => x.Split(' ')[0])
                    .OrderBy(g => g.Key);

            // In từng nhóm món ăn
            Console.WriteLine("\nCâu b - Nhóm theo từ đầu:");

            foreach (var group in nhomMon)
            {
                // In tên của nhóm
                Console.WriteLine($"{group.Key}:");

                // In các món thuộc nhóm đó
                foreach (var mon in group)
                {
                    Console.WriteLine($"  {mon}");
                }
            }

            // Count() đếm số món bắt đầu bằng chữ "Bánh"
            int soMonBanh =
                monAn.Count(x => x.StartsWith("Bánh"));

            // In số lượng món tìm được
            Console.WriteLine("\nCâu c - Số món bắt đầu bằng Bánh:");
            Console.WriteLine(soMonBanh);
        }

        static void Bai41()
        {
            // In tiêu đề bài 4.1
            Console.WriteLine("\nBÀI 4.1");

            // Gọi phương thức DS_Mon() để lấy danh sách môn học
            var dsMon = DuLieu.DS_Mon();

            // In từng môn học trong danh sách
            Console.WriteLine("Danh sách MonHoc:");

            foreach (var mon in dsMon)
            {
                // In mã môn, tên môn, hệ và số tiết
                Console.WriteLine(
                    $"{mon.MaMon} - {mon.TenMon} - {mon.He} - {mon.SoTiet} tiết"
                );
            }
        }

        static void Bai51()
        {
            // In tiêu đề bài 5.1
            Console.WriteLine("\nBÀI 5.1");

            // Lấy danh sách môn học từ lớp DuLieu
            var dsMon = DuLieu.DS_Mon();

            // Câu a:
            // Tìm những môn học có tên bắt đầu bằng "Lập trình"
            var cauA =
                from mon in dsMon
                where mon.TenMon.StartsWith("Lập trình")
                select mon.TenMon;

            // In tên các môn tìm được
            Console.WriteLine("\nCâu a:");
            InDanhSach(cauA);

            // Câu b:
            // Chỉ lấy những môn thuộc hệ CD
            // Sau đó sắp xếp giảm dần theo số tiết
            // Nếu số tiết bằng nhau thì sắp xếp theo mã môn
            var cauB =
                from mon in dsMon
                where mon.He == "CD"
                orderby mon.SoTiet descending, mon.MaMon
                select mon;

            // In thông tin từng môn
            Console.WriteLine("\nCâu b:");

            foreach (var mon in cauB)
            {
                Console.WriteLine(
                    $"{mon.MaMon} - {mon.TenMon} - {mon.SoTiet} tiết"
                );
            }

            // Câu c:
            // Chuyển tên môn về chữ thường rồi kiểm tra có chứa "web" hay không
            // Kết quả chỉ lấy tên môn và hệ
            var cauC =
                from mon in dsMon
                where mon.TenMon.ToLower().Contains("web")
                select new
                {
                    mon.TenMon,
                    mon.He
                };

            // In kết quả câu c
            Console.WriteLine("\nCâu c:");

            foreach (var mon in cauC)
            {
                Console.WriteLine(
                    $"{mon.TenMon} - {mon.He}"
                );
            }

            // Câu d:
            // Lọc các môn thuộc hệ KTV
            // Sau đó sắp xếp tăng dần theo mã môn
            var cauD =
                from mon in dsMon
                where mon.He == "KTV"
                orderby mon.MaMon
                select mon;

            // In kết quả câu d
            Console.WriteLine("\nCâu d:");

            foreach (var mon in cauD)
            {
                Console.WriteLine(
                    $"{mon.MaMon} - {mon.TenMon} - {mon.SoTiet} tiết"
                );
            }
        }

        static void Bai52()
        {
            // In tiêu đề bài 5.2
            Console.WriteLine("\nBÀI 5.2");

            // Lấy danh sách môn học
            var dsMon = DuLieu.DS_Mon();

            // Count đếm tổng số môn học trong danh sách
            Console.WriteLine("\nCâu a - Tổng số môn:");
            Console.WriteLine(dsMon.Count);

            // Count có điều kiện để đếm số môn bắt đầu bằng "Lập trình"
            int soMonLapTrinh =
                dsMon.Count(x =>
                    x.TenMon.StartsWith("Lập trình"));

            // In kết quả câu b
            Console.WriteLine("\nCâu b - Số môn Lập trình:");
            Console.WriteLine(soMonLapTrinh);

            // Lọc các môn thuộc hệ KTV
            // Sau đó Sum() tổng số tiết của các môn đó
            int tongTietKTV =
                dsMon
                    .Where(x => x.He == "KTV")
                    .Sum(x => x.SoTiet);

            // In tổng số tiết
            Console.WriteLine("\nCâu c - Tổng tiết KTV:");
            Console.WriteLine(tongTietKTV);

            // GroupBy() nhóm môn học theo hệ
            // Count() đếm số môn trong từng hệ
            var cauD =
                dsMon
                    .GroupBy(x => x.He)
                    .OrderBy(g => g.Key)
                    .Select(g => new
                    {
                        He = g.Key,
                        SoMon = g.Count()
                    });

            // In số môn của từng hệ
            Console.WriteLine("\nCâu d:");

            foreach (var item in cauD)
            {
                Console.WriteLine(
                    $"Hệ: {item.He} - Số môn: {item.SoMon}"
                );
            }

            // GroupBy() nhóm các môn theo số tiết
            // OrderByDescending() sắp xếp số tiết từ cao xuống thấp
            var cauE =
                dsMon
                    .GroupBy(x => x.SoTiet)
                    .OrderByDescending(g => g.Key)
                    .Select(g => new
                    {
                        SoTiet = g.Key,
                        SoMon = g.Count()
                    });

            // In số môn tương ứng với từng loại số tiết
            Console.WriteLine("\nCâu e:");

            foreach (var item in cauE)
            {
                Console.WriteLine(
                    $"Số tiết: {item.SoTiet} - Số môn: {item.SoMon}"
                );
            }

            // Sắp xếp môn học theo số tiết giảm dần
            // First() lấy môn đầu tiên sau khi sắp xếp
            // Vì vậy đây là môn có số tiết cao nhất
            var cauF =
                dsMon
                    .OrderByDescending(x => x.SoTiet)
                    .First();

            // In môn có số tiết cao nhất
            Console.WriteLine("\nCâu f - Môn số tiết cao nhất:");
            Console.WriteLine(
                $"{cauF.MaMon} - {cauF.TenMon} - {cauF.SoTiet} tiết"
            );

            // Nhóm môn học theo hệ
            // Sau đó tính tổng môn, tổng tiết, số tiết lớn nhất và nhỏ nhất
            var cauG =
                dsMon
                    .GroupBy(x => x.He)
                    .OrderBy(g => g.Key)
                    .Select(g => new
                    {
                        He = g.Key,
                        TongMon = g.Count(),
                        TongTiet = g.Sum(x => x.SoTiet),
                        MaxTiet = g.Max(x => x.SoTiet),
                        MinTiet = g.Min(x => x.SoTiet)
                    });

            // In các thông tin thống kê của từng hệ
            Console.WriteLine("\nCâu g:");

            foreach (var item in cauG)
            {
                Console.WriteLine(
                    $"Hệ: {item.He} | " +
                    $"Tổng môn: {item.TongMon} | " +
                    $"Tổng tiết: {item.TongTiet} | " +
                    $"Max: {item.MaxTiet} | " +
                    $"Min: {item.MinTiet}"
                );
            }

            // GroupBy() nhóm toàn bộ môn học theo hệ
            // OrderBy() sắp xếp các nhóm theo mã hệ
            var cauH =
                dsMon
                    .GroupBy(x => x.He)
                    .OrderBy(g => g.Key);

            // In từng nhóm hệ và các môn thuộc hệ đó
            Console.WriteLine("\nCâu h:");

            foreach (var group in cauH)
            {
                Console.WriteLine($"Hệ: {group.Key}");

                foreach (var mon in group)
                {
                    Console.WriteLine(
                        $"  {mon.MaMon} - {mon.TenMon}"
                    );
                }
            }

            // GroupBy() nhóm các môn có cùng số tiết
            // OrderBy() sắp xếp nhóm theo số tiết tăng dần
            var cauI =
                dsMon
                    .GroupBy(x => x.SoTiet)
                    .OrderBy(g => g.Key);

            // In từng nhóm số tiết
            Console.WriteLine("\nCâu i:");

            foreach (var group in cauI)
            {
                Console.WriteLine($"Số tiết: {group.Key}");

                foreach (var mon in group)
                {
                    Console.WriteLine(
                        $"  {mon.MaMon} - {mon.TenMon}"
                    );
                }
            }

            // Chỉ lấy các môn thuộc hệ KTV
            // Đồng thời mã môn phải bắt đầu bằng HP2, HP3, HP4 hoặc HP5
            var cauJ =
                dsMon
                    .Where(x =>
                        x.He == "KTV" &&
                        (
                            x.MaMon.StartsWith("HP2") ||
                            x.MaMon.StartsWith("HP3") ||
                            x.MaMon.StartsWith("HP4") ||
                            x.MaMon.StartsWith("HP5")
                        ))
                    // Substring(0, 3) lấy 3 ký tự đầu của mã môn
                    // Ví dụ HP2_1 sẽ được nhóm vào HP2
                    .GroupBy(x => x.MaMon.Substring(0, 3))
                    .OrderBy(g => g.Key);

            // In từng nhóm HP2, HP3, HP4 và HP5
            Console.WriteLine("\nCâu j:");

            foreach (var group in cauJ)
            {
                Console.WriteLine($"Nhóm {group.Key}:");

                foreach (var mon in group)
                {
                    Console.WriteLine(
                        $"  {mon.MaMon} - {mon.TenMon}"
                    );
                }
            }

            // Lọc những môn có số tiết lớn hơn 40
            // Sau đó nhóm các môn theo hệ
            var cauK =
                dsMon
                    .Where(x => x.SoTiet > 40)
                    .GroupBy(x => x.He)
                    .OrderBy(g => g.Key);

            // In các môn có số tiết lớn hơn 40 theo từng hệ
            Console.WriteLine("\nCâu k:");

            foreach (var group in cauK)
            {
                Console.WriteLine($"Hệ: {group.Key}");

                foreach (var mon in group)
                {
                    Console.WriteLine(
                        $"  {mon.MaMon} - {mon.TenMon} - {mon.SoTiet} tiết"
                    );
                }
            }
        }

        static void Bai61()
        {
            // In tiêu đề bài 6.1
            Console.WriteLine("\nBÀI 6.1");

            // Lấy danh sách các hệ đào tạo
            var dsHe = DuLieu.DS_He();

            // In từng hệ đào tạo
            Console.WriteLine("Danh sách Hệ:");

            foreach (var he in dsHe)
            {
                Console.WriteLine(
                    $"{he.MaHe} - {he.TenHe}"
                );
            }
        }

        static void Bai62()
        {
            // In tiêu đề bài 6.2
            Console.WriteLine("\nBÀI 6.2");

            // Lấy danh sách môn học và danh sách hệ đào tạo
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            // Câu a:
            // INNER JOIN ghép mỗi hệ với những môn có mã hệ tương ứng
            var cauA =
                from he in dsHe
                join mon in dsMon
                    on he.MaHe equals mon.He
                select new
                {
                    he.TenHe,
                    mon.MaMon,
                    mon.TenMon
                };

            // In kết quả INNER JOIN
            Console.WriteLine("\nCâu a - INNER JOIN:");

            foreach (var item in cauA)
            {
                Console.WriteLine(
                    $"{item.TenHe} - {item.MaMon} - {item.TenMon}"
                );
            }

            // Câu b:
            // GroupJoin ghép mỗi hệ với danh sách môn học tương ứng
            // DefaultIfEmpty() giúp giữ lại cả những hệ chưa có môn
            var cauB =
                dsHe
                    .GroupJoin(
                        dsMon,
                        he => he.MaHe,
                        mon => mon.He,
                        (he, mons) => new
                        {
                            he,
                            mons
                        })
                    .SelectMany(
                        x => x.mons.DefaultIfEmpty(),
                        (x, mon) => new
                        {
                            x.he,
                            mon
                        })
                    .Select(x =>
                        x.mon == null
                            ? $"{x.he.TenHe} - KHÔNG CÓ MÔN HỌC"
                            : $"{x.he.TenHe} - {x.mon.MaMon} - {x.mon.TenMon}"
                    );

            // In kết quả LEFT OUTER JOIN
            Console.WriteLine("\nCâu b - LEFT OUTER JOIN:");
            InDanhSach(cauB);

            // Tìm những hệ không có bất kỳ môn học nào
            var heKhongCoMon =
                dsHe
                    .GroupJoin(
                        dsMon,
                        he => he.MaHe,
                        mon => mon.He,
                        (he, mons) => new
                        {
                            he,
                            mons
                        })
                    // !Any() nghĩa là danh sách môn của hệ đó không có phần tử
                    .Where(x => !x.mons.Any())
                    .Select(x => new
                    {
                        Loai = "Hệ chưa có môn",
                        ThongTin = x.he.TenHe
                    });

            // Tìm những môn chưa khai báo hệ hoặc có mã hệ không tồn tại
            var monChuaKhaiBaoHe =
                dsMon
                    .Where(mon =>
                        string.IsNullOrWhiteSpace(mon.He) ||
                        !dsHe.Any(he => he.MaHe == mon.He))
                    .Select(mon => new
                    {
                        Loai = "Môn chưa khai báo hệ",
                        ThongTin = $"{mon.MaMon} - {mon.TenMon}"
                    });

            // Concat() nối hai danh sách kết quả lại với nhau
            var cauC =
                heKhongCoMon.Concat(monChuaKhaiBaoHe);

            // In kết quả câu c
            Console.WriteLine("\nCâu c:");

            foreach (var item in cauC)
            {
                Console.WriteLine(
                    $"{item.Loai}: {item.ThongTin}"
                );
            }

            // Tìm những hệ không có môn học tương ứng
            var heChuaCoMon =
                dsHe
                    .Where(h =>
                        !dsMon.Any(m => m.He == h.MaHe));

            // In kết quả hệ chưa có môn
            Console.WriteLine("\nCâu d - Hệ chưa có môn:");

            foreach (var he in heChuaCoMon)
            {
                Console.WriteLine(
                    $"{he.MaHe} - {he.TenHe}"
                );
            }

            // Tìm những môn không có hệ hoặc mã hệ không tồn tại trong danh sách hệ
            var monChuaCoHe =
                dsMon
                    .Where(m =>
                        string.IsNullOrWhiteSpace(m.He) ||
                        !dsHe.Any(h => h.MaHe == m.He));

            // In kết quả môn chưa khai báo hệ
            Console.WriteLine("\nCâu d - Môn chưa khai báo hệ:");

            foreach (var mon in monChuaCoHe)
            {
                Console.WriteLine(
                    $"{mon.MaMon} - {mon.TenMon}"
                );
            }

            // Câu e:
            // JOIN môn học với hệ để lấy thông tin đầy đủ
            // Sau đó sắp xếp theo số tiết giảm dần
            var cauE =
                from mon in dsMon
                join he in dsHe
                    on mon.He equals he.MaHe
                orderby mon.SoTiet descending
                select new
                {
                    he.TenHe,
                    mon.MaMon,
                    mon.TenMon,
                    mon.SoTiet
                };

            // Take(5) chỉ lấy 5 môn đầu tiên sau khi đã sắp xếp
            Console.WriteLine("\nCâu e:");

            foreach (var item in cauE.Take(5))
            {
                Console.WriteLine(
                    $"{item.TenHe} - {item.MaMon} - " +
                    $"{item.TenMon} - {item.SoTiet} tiết"
                );
            }

            // Câu f:
            // GroupJoin mỗi hệ với các môn học thuộc hệ đó
            // Count() đếm tổng số môn của từng hệ
            var cauF =
                dsHe
                    .GroupJoin(
                        dsMon,
                        he => he.MaHe,
                        mon => mon.He,
                        (he, mons) => new
                        {
                            he.MaHe,
                            he.TenHe,
                            TongSoMon = mons.Count()
                        });

            // In tổng số môn của từng hệ
            Console.WriteLine("\nCâu f:");

            foreach (var item in cauF)
            {
                Console.WriteLine(
                    $"{item.MaHe} - {item.TenHe} - " +
                    $"Tổng số môn: {item.TongSoMon}"
                );
            }

            // Select() lấy riêng số tiết của từng môn
            // Distinct() loại bỏ các số tiết trùng nhau
            // Count() đếm số loại số tiết khác nhau
            int soLoaiSoTiet =
                dsMon
                    .Select(x => x.SoTiet)
                    .Distinct()
                    .Count();

            // In kết quả câu g
            Console.WriteLine("\nCâu g - Số loại SoTiet:");
            Console.WriteLine(soLoaiSoTiet);

            // FirstOrDefault() lấy môn đầu tiên có tên bắt đầu bằng "Lập trình"
            // Nếu không tìm thấy thì kết quả sẽ là null
            var cauH =
                dsMon
                    .FirstOrDefault(
                        x => x.TenMon.StartsWith("Lập trình"));

            // Kiểm tra kết quả trước khi sử dụng để tránh lỗi null
            Console.WriteLine("\nCâu h:");

            if (cauH != null)
            {
                Console.WriteLine(
                    $"{cauH.MaMon} - {cauH.TenMon} - " +
                    $"{cauH.He} - {cauH.SoTiet} tiết"
                );
            }

            // Câu i:
            // GroupBy() nhóm môn học theo hệ
            // OrderBy() sắp xếp các nhóm theo mã hệ
            // Bên trong mỗi nhóm, môn học được sắp xếp theo mã môn
            var cauI =
                dsMon
                    .GroupBy(x => x.He)
                    .OrderBy(g => g.Key)
                    .Select(g => new
                    {
                        He = g.Key,

                        // Đánh số thứ tự cho từng môn trong nhóm
                        DanhSach = g
                            .OrderBy(x => x.MaMon)
                            .Select((mon, i) => new
                            {
                                STT = i + 1,
                                mon.MaMon,
                                mon.TenMon
                            })
                    });

            // In danh sách môn học theo từng hệ
            Console.WriteLine("\nCâu i:");

            foreach (var group in cauI)
            {
                Console.WriteLine($"\nHệ: {group.He}");

                foreach (var mon in group.DanhSach)
                {
                    Console.WriteLine(
                        $"{mon.STT}. {mon.MaMon} - {mon.TenMon}"
                    );
                }
            }
        }
    }

    public class MonHoc
    {
        // Mã định danh của môn học
        public string MaMon { get; set; } = "";

        // Tên của môn học
        public string TenMon { get; set; } = "";

        // Mã hệ đào tạo mà môn học thuộc về
        public string He { get; set; } = "";

        // Số tiết của môn học
        public byte SoTiet { get; set; }

        // Chuyển thông tin môn học thành chuỗi để dễ in ra Console
        public override string ToString()
        {
            return $"{MaMon} - {TenMon} - {He} - {SoTiet} tiết";
        }
    }

    public class He
    {
        // Mã định danh của hệ đào tạo
        public string MaHe { get; set; } = "";

        // Tên của hệ đào tạo
        public string TenHe { get; set; } = "";

        // Chuyển thông tin hệ đào tạo thành chuỗi để dễ in ra Console
        public override string ToString()
        {
            return $"{MaHe} - {TenHe}";
        }
    }

    public static class DuLieu
    {
        // Phương thức tạo và trả về danh sách môn học
        public static List<MonHoc> DS_Mon() => new()
        {
            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP2_1",
                TenMon = "Nền tảng C#",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP2_2",
                TenMon = "Công nghệ ADO.NET",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP3_1",
                TenMon = "Lập trình Windows Forms",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP3_2",
                TenMon = "Xây dựng ứng dụng Windows Forms",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP4_1",
                TenMon = "Lập trình Web với HTML, CSS và JavaScript",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP4_2",
                TenMon = "Xây dựng ứng dụng Web với ASP.NET",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP5_1",
                TenMon = "Lập trình CSDL SQL Server căn bản",
                He = "KTV",
                SoTiet = 64
            },

            // Môn thuộc hệ KTV
            new()
            {
                MaMon = "HP5_2",
                TenMon = "Lập trình CSDL SQL Server nâng cao",
                He = "KTV",
                SoTiet = 64
            },

            // Các môn thuộc hệ Chuyên đề
            new()
            {
                MaMon = "JLCB",
                TenMon = "Joomla cơ bản",
                He = "CD",
                SoTiet = 72
            },

            new()
            {
                MaMon = "LINQ",
                TenMon = "Language-Integrated Query",
                He = "CD",
                SoTiet = 64
            },

            new()
            {
                MaMon = "DAWEB",
                TenMon = "Đồ án thực tế Web với ASP.NET",
                He = "CD",
                SoTiet = 40
            },

            new()
            {
                MaMon = "DAWIN",
                TenMon = "Đồ án thực tế Windows Forms",
                He = "CD",
                SoTiet = 40
            },

            new()
            {
                MaMon = "CC++",
                TenMon = "Lập trình hướng đối tượng với C/C++",
                He = "CD",
                SoTiet = 128
            },

            new()
            {
                MaMon = "JQUE",
                TenMon = "JQuery",
                He = "CD",
                SoTiet = 22
            },

            new()
            {
                MaMon = "XML",
                TenMon = "Công nghệ XML",
                He = "CD",
                SoTiet = 32
            },

            new()
            {
                MaMon = "CRYS",
                TenMon = "Crystal Report trong Visual Studio",
                He = "CD",
                SoTiet = 32
            },

            new()
            {
                MaMon = "BWEB",
                TenMon = "HTML, CSS và JavaScript",
                He = "CD",
                SoTiet = 32
            },

            // Môn này không có mã hệ nên dùng để kiểm tra dữ liệu thiếu
            new()
            {
                MaMon = "XYZ",
                TenMon = "Chưa đặt tên môn",
                He = "",
                SoTiet = 0
            }
        };

        // Phương thức tạo và trả về danh sách các hệ đào tạo
        public static List<He> DS_He() => new()
        {
            // Hệ Kỹ thuật viên
            new()
            {
                MaHe = "KTV",
                TenHe = "Kỹ thuật viên"
            },

            // Hệ Chuyên đề
            new()
            {
                MaHe = "CD",
                TenHe = "Chuyên đề"
            },

            // Hệ Chứng chỉ quốc tế
            // Hiện tại hệ này chưa có môn học trong DS_Mon()
            new()
            {
                MaHe = "QT",
                TenHe = "Chứng chỉ quốc tế"
            }
        };
    }
}