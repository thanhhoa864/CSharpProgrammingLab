USE QLSinhVien_Lab06b;
GO

-- Kiểm tra cửa sổ truy vấn đang dùng database nào
SELECT DB_NAME() AS DatabaseDangDung;

-- Xem dữ liệu trong 5 bảng
SELECT * FROM dbo.Khoa;
SELECT * FROM dbo.Lop;
SELECT * FROM dbo.SinhVien;
SELECT * FROM dbo.MonHoc;
SELECT * FROM dbo.Diem;