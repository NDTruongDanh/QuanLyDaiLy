-- Sử dụng cơ sở dữ liệu QUANLYDAILY
USE QUANLYDAILY;
GO

-- Tắt kiểm tra ràng buộc khóa ngoại và trigger để xóa dữ liệu dễ dàng
EXEC sp_msforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
EXEC sp_msforeachtable 'ALTER TABLE ? DISABLE TRIGGER ALL'
GO

-- Xóa dữ liệu cũ trong các bảng được thêm mới để tránh trùng lặp khi chạy lại script
-- Thứ tự xóa phải từ bảng con đến bảng cha
DELETE FROM CHITIET_PHIEUXUAT;
DELETE FROM CHITIET_PHIEUNHAP;
DELETE FROM PHIEUTHU;
DELETE FROM PHIEUXUAT;
DELETE FROM PHIEUNHAP;
DELETE FROM DAILY;
DELETE FROM MATHANG;
DELETE FROM LOAIDAILY;
DELETE FROM QUAN;
DELETE FROM DONVITINH;
GO

-- Bật lại kiểm tra ràng buộc khóa ngoại và trigger
EXEC sp_msforeachtable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'
EXEC sp_msforeachtable 'ALTER TABLE ? ENABLE TRIGGER ALL'
GO

-- Reset lại giá trị IDENTITY cho các bảng được thêm mới
DBCC CHECKIDENT ('LOAIDAILY', RESEED, 0);
DBCC CHECKIDENT ('QUAN', RESEED, 0);
DBCC CHECKIDENT ('DAILY', RESEED, 0);
DBCC CHECKIDENT ('DONVITINH', RESEED, 0);
DBCC CHECKIDENT ('MATHANG', RESEED, 0);
DBCC CHECKIDENT ('PHIEUNHAP', RESEED, 0);
DBCC CHECKIDENT ('PHIEUXUAT', RESEED, 0);
DBCC CHECKIDENT ('PHIEUTHU', RESEED, 0);
GO


-----------------------------------------------------------------------------
-- 1. BẢNG LOAIDAILY
-----------------------------------------------------------------------------
INSERT INTO LOAIDAILY (TenLoaiDaiLy, TienNoToiDa) VALUES
(N'Loại 1', 20000000),
(N'Loại 2', 50000000);
GO

-----------------------------------------------------------------------------
-- 2. BẢNG QUAN
-----------------------------------------------------------------------------
INSERT INTO QUAN (TenQuan) VALUES
(N'Quận 1'),
(N'Quận Gò Vấp'),
(N'Quận Bình Thạnh'),
(N'Thành phố Thủ Đức');
GO

-----------------------------------------------------------------------------
-- 3. BẢNG DONVITINH
-----------------------------------------------------------------------------
INSERT INTO DONVITINH (TenDonViTinh) VALUES
(N'Thùng'),
(N'Hộp'),
(N'Chai'),
(N'Lon');
GO

-----------------------------------------------------------------------------
-- 4. BẢNG MATHANG
-- Thêm dữ liệu với Tồn Kho ban đầu. Trigger sẽ tự động cập nhật tồn kho sau này.
-----------------------------------------------------------------------------
INSERT INTO MATHANG (TenMatHang, MaDonViTinh, DonGiaHienTai, TonKho) VALUES
(N'Nước ngọt Coca Cola', 4, 10000, 500),
(N'Bánh ChocoPie', 2, 55000, 300),
(N'Sữa tươi Vinamilk', 1, 350000, 150),
(N'Bia Tiger', 1, 420000, 200),
(N'Nước suối Aquafina', 3, 4000, 1000);
GO

-----------------------------------------------------------------------------
-- 5. BẢNG DAILY
-- TongNo ban đầu là 0. Trigger sẽ tự động cập nhật công nợ sau này.
-----------------------------------------------------------------------------
INSERT INTO DAILY (TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo) VALUES
(N'Đại lý An Khang', 1, '0909123456', 'ankhang@email.com', N'123 Nguyễn Huệ', 1, DATEADD(month, -3, GETDATE()), 0),
(N'Đại lý Thịnh Phát', 2, '0987654321', 'thinhphat@email.com', N'456 Lê Lợi', 2, DATEADD(month, -3, GETDATE()), 0),
(N'Đại lý Tài Lộc', 1, '0912345678', 'tailoc@email.com', N'789 Phan Xích Long', 3, DATEADD(month, -3, GETDATE()), 0),
(N'Đại lý Hưng Thịnh', 2, '0398765432', 'hungthinh@email.com', N'101 Võ Văn Ngân', 4, DATEADD(month, -3, GETDATE()), 0);
GO

-----------------------------------------------------------------------------
-- 6. BẢNG PHIEUNHAP VÀ CHITIET_PHIEUNHAP
-- Trigger sẽ tự động cập nhật Tồn Kho và Đơn Giá Hiện Tại cho mặt hàng.
-----------------------------------------------------------------------------
-- Phiếu nhập 1 (Ngày -60)
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES (DATEADD(day, -60, GETDATE()), 47500000);
INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(1, 1, 500, 9000, 4500000), -- Coca -> DonGiaHienTai = 9000
(1, 3, 50, 320000, 16000000), -- Sữa -> DonGiaHienTai = 320000
(1, 4, 60, 450000, 27000000); -- Bia -> DonGiaHienTai = 450000
GO

-- Phiếu nhập 2 (Ngày -50)
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES (DATEADD(day, -50, GETDATE()), 27500000);
INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(2, 2, 300, 50000, 15000000), -- Bánh -> DonGiaHienTai = 50000
(2, 5, 2500, 5000, 12500000); -- Nước suối -> DonGiaHienTai = 5000
GO

-- Phiếu nhập 3 (Ngày -40)
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES (DATEADD(day, -40, GETDATE()), 49500000);
INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(3, 1, 1000, 9500, 9500000), -- Coca -> DonGiaHienTai = 9500
(3, 4, 100, 400000, 40000000); -- Bia -> DonGiaHienTai = 400000
GO

-- Phiếu nhập 4 (Ngày -25)
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES (DATEADD(day, -25, GETDATE()), 32100000);
INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(4, 3, 70, 330000, 23100000), -- Sữa -> DonGiaHienTai = 330000
(4, 2, 150, 60000, 9000000);   -- Bánh -> DonGiaHienTai = 60000
GO

-- Phiếu nhập 5 (Ngày -10)
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES (DATEADD(day, -10, GETDATE()), 30250000);
INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(5, 1, 1500, 9700, 14550000), -- Coca -> DonGiaHienTai = 9700
(5, 5, 2500, 6280, 15700000); -- Nước suối -> DonGiaHienTai = 6280
GO

-----------------------------------------------------------------------------
-- 7. BẢNG PHIEUXUAT VÀ CHITIET_PHIEUXUAT
-- DonGiaXuat = DonGiaHienTai * 1.02
-----------------------------------------------------------------------------

-- Phiếu xuất 1 (Ngày -55) cho Đại lý 1
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (1, DATEADD(day, -55, GETDATE()), 10053000, 5000000, 5053000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(1, 1, 100, 9180, 918000),    -- DonGiaNhap 9000
(1, 2, 50, 56100, 2805000),   -- DonGia ban đầu 55000
(1, 3, 20, 326400, 6528000),  -- DonGiaNhap 320000
(1, 5, 50, 4080, 204000);     -- DonGia ban đầu 4000
GO

-- Phiếu xuất 2 (Ngày -48) cho Đại lý 2
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (2, DATEADD(day, -48, GETDATE()), 27000000, 15000000, 12000000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(2, 4, 50, 459000, 22950000), -- DonGiaNhap 450000
(2, 2, 80, 51000, 4050000);   -- DonGiaNhap 50000
GO

-- Phiếu xuất 3 (Ngày -38) cho Đại lý 1
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (1, DATEADD(day, -38, GETDATE()), 3672000, 0, 3672000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(3, 4, 5, 408000, 2040000),   -- DonGiaNhap 400000
(3, 3, 5, 326400, 1632000);   -- DonGiaNhap 320000
GO

-- Phiếu xuất 4 (Ngày -35) cho Đại lý 3
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (3, DATEADD(day, -35, GETDATE()), 19689000, 10000000, 9689000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(4, 2, 200, 51000, 10200000),  -- DonGiaNhap 50000
(4, 4, 20, 408000, 8160000),   -- DonGiaNhap 400000
(4, 1, 135, 9690, 1308150);     -- DonGiaNhap 9500
GO

-- Phiếu xuất 5 (Ngày -30) cho Đại lý 4 (trả đủ tiền)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (4, DATEADD(day, -30, GETDATE()), 40800000, 40800000, 0);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(5, 4, 100, 408000, 40800000); -- DonGiaNhap 400000
GO

-- Phiếu xuất 6 (Ngày -28) cho Đại lý 2
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (2, DATEADD(day, -28, GETDATE()), 12348000, 5000000, 7348000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES 
(6, 3, 20, 326400, 6528000),  -- DonGiaNhap 320000
(6, 2, 50, 51000, 2550000),   -- DonGiaNhap 50000
(6, 5, 350, 5100, 1785000);   -- DonGiaNhap 5000
GO

-- Phiếu xuất 7 (Ngày -22) cho Đại lý 3
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (3, DATEADD(day, -22, GETDATE()), 12189000, 8000000, 4189000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(7, 1, 500, 9690, 4845000),   -- DonGiaNhap 9500
(7, 2, 120, 61200, 7344000);  -- DonGiaNhap 60000
GO

-- Phiếu xuất 8 (Ngày -18) cho Đại lý 4
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (4, DATEADD(day, -18, GETDATE()), 13015200, 13015200, 0);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(8, 4, 30, 408000, 12240000),  -- DonGiaNhap 400000
(8, 1, 80, 9690, 775200);      -- DonGiaNhap 9500
GO

-- Phiếu xuất 9 (Ngày -15) cho Đại lý 1
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (1, DATEADD(day, -15, GETDATE()), 16830000, 10000000, 6830000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(9, 3, 50, 336600, 16830000); -- DonGiaNhap 330000
GO

-- Phiếu xuất 10 (Ngày -8) cho Đại lý 2
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (2, DATEADD(day, -8, GETDATE()), 16302000, 15000000, 1302000);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(10, 1, 1000, 9894, 9894000), -- DonGiaNhap 9700
(10, 5, 1000, 6408, 6408000); -- DonGiaNhap 6280
GO

-- Phiếu xuất 11 (Ngày -5) cho Đại lý 3
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (3, DATEADD(day, -5, GETDATE()), 989400, 989400, 0);
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(11, 1, 100, 9894, 989400);   -- DonGiaNhap 9700
GO


-----------------------------------------------------------------------------
-- 8. BẢNG PHIEUTHU
-- Trigger sẽ tự động cập nhật lại công nợ cho đại lý.
-----------------------------------------------------------------------------

-- Lô 1
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (1, DATEADD(day, -50, GETDATE()), 5000000);
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (2, DATEADD(day, -45, GETDATE()), 10000000);
GO

-- Lô 2
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (3, DATEADD(day, -33, GETDATE()), 5000000);
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (1, DATEADD(day, -30, GETDATE()), 3000000);
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (2, DATEADD(day, -25, GETDATE()), 5000000);
GO

-- Lô 3
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (1, DATEADD(day, -12, GETDATE()), 6000000);
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (3, DATEADD(day, -10, GETDATE()), 2000000);
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (2, DATEADD(day, -2, GETDATE()), 598600);
GO


-- In ra kết quả để kiểm tra
PRINT N'----------------- KẾT QUẢ SAU KHI THÊM DỮ LIỆU -----------------';
PRINT N'';

PRINT N'Bảng Đại Lý và Công Nợ Cuối Cùng (được tính bởi Trigger):';
SELECT MaDaiLy, TenDaiLy, l.TenLoaiDaiLy, TongNo 
FROM DAILY d JOIN LOAIDAILY l ON d.MaLoaiDaiLy = l.MaLoaiDaiLy;

PRINT N'Bảng Mặt Hàng và Tồn Kho Cuối Cùng (được tính bởi Trigger):';
SELECT MaMatHang, TenMatHang, dv.TenDonViTinh, DonGiaHienTai, TonKho 
FROM MATHANG mh JOIN DONVITINH dv ON mh.MaDonViTinh = dv.MaDonViTinh;

PRINT N'Lịch Sử Phiếu Xuất:';
SELECT px.MaPhieuXuat, d.TenDaiLy, px.NgayLapPhieu, px.TongTien, px.TienTra, px.ConLai
FROM PHIEUXUAT px JOIN DAILY d ON px.MaDaiLy = d.MaDaiLy
ORDER BY px.NgayLapPhieu DESC;

PRINT N'Lịch Sử Phiếu Thu:';
SELECT pt.MaPhieuThu, d.TenDaiLy, pt.NgayThuTien, pt.SoTienThu
FROM PHIEUTHU pt JOIN DAILY d ON pt.MaDaiLy = d.MaDaiLy
ORDER BY pt.NgayThuTien DESC;

GO
