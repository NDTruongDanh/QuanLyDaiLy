-- Thêm dữ liệu vào bảng LOAIDAILY
INSERT INTO LOAIDAILY (TenLoaiDaiLy, TienNoToiDa) VALUES
(N'Loại 1', 10000000),
(N'Loại 2', 5000000);

-- Thêm dữ liệu vào bảng QUAN
INSERT INTO QUAN (TenQuan) VALUES
(N'Quận 1'),
(N'Quận 2'),
(N'Quận 3'),
(N'Quận Thủ Đức'),
(N'Quận Bình Thạnh');

-- Thêm dữ liệu vào bảng DAILY
INSERT INTO DAILY (TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo) VALUES
(N'Đại lý A', 1, '0901234567', 'daily.a@email.com', N'123 Đường ABC, Quận 1', 1, '2024-01-15', 0),
(N'Đại lý B', 2, '0987654321', 'daily.b@email.com', N'456 Đường XYZ, Quận 2', 2, '2024-02-20', 0),
(N'Đại lý C', 1, '0911223344', 'daily.c@email.com', N'789 Đường UVW, Quận 1', 1, '2024-03-10', 0),
(N'Đại lý D', 2, '0933445566', 'daily.d@email.com', N'101 Đường RST, Quận 3', 3, '2024-04-01', 0),
(N'Đại lý E', 1, '0966778899', 'daily.e@email.com', N'222 Đường LMN, Quận Thủ Đức', 4, '2024-05-05', 0),
(N'Đại lý F', 2, '0977889900', 'daily.f@email.com', N'333 Đường PQR, Quận 2', 2, '2024-06-12', 0),
(N'Đại lý G', 1, '0922334455', 'daily.g@email.com', N'444 Đường GHI, Quận 1', 1, '2024-07-01', 0),
(N'Đại lý H', 2, '0944556677', 'daily.h@email.com', N'555 Đường JKL, Quận Bình Thạnh', 5, '2024-08-18', 0);

-- Thêm dữ liệu vào bảng DONVITINH
INSERT INTO DONVITINH (TenDonViTinh) VALUES
('Thùng'),
('Cái'),
('Kg'),
('Lít');

-- Thêm dữ liệu vào bảng MATHANG
INSERT INTO MATHANG (TenMatHang, MaDonViTinh, DonGiaHienTai, TonKho) VALUES
(N'Bia Tiger', 1, 0, 0),
(N'Nước ngọt Coca-Cola', 1, 0, 0),
(N'Gạo ST25', 3, 0, 0),
(N'Dầu ăn Neptune', 4, 0, 0),
(N'Bánh Choco Pie', 2, 0, 0),
(N'Sữa tươi Vinamilk', 1, 0, 0);

-- Thêm dữ liệu vào bảng PHIEUNHAP
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES
('2024-09-01', 0),
('2024-09-05', 0),
('2024-09-10', 0);

-- Thêm dữ liệu vào bảng CHITIET_PHIEUNHAP
INSERT INTO CHITIET_PHIEUNHAP (MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(1, 1, 50, 240000, 12000000),
(1, 2, 100, 115000, 11500000)
INSERT INTO CHITIET_PHIEUNHAP (MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(2, 3, 200, 17500, 3500000),
(2, 4, 70, 42000, 2940000)
INSERT INTO CHITIET_PHIEUNHAP (MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
(3, 1, 30, 245000, 7350000),
(3, 5, 150, 34000, 5100000);

INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(1, '2024-09-15', 0, 1000000, 3845000)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(2, '2024-09-16', 0, 749300, 1000000)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(1, '2024-09-18', 0, 500000, 1789900)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(3, '2024-09-20', 0, 200000, 1559500)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(2, '2024-09-22', 0, 50000, 128500)
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
(4, '2024-09-25', 0, 100000, 114200)


-- Thêm dữ liệu vào bảng CHITIET_PHIEUXUAT
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(1, 1, 10, 249900, 2499000),
(1, 2, 20, 117300, 2346000)
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(2, 3, 50, 17850, 892500),
(2, 4, 20, 42840, 856800)
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(3, 1, 5, 249900, 1249500),
(3, 5, 30, 34680, 1040400)
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(4, 2, 15, 117300, 1759500)
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(5, 3, 10, 17850, 178500)
INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
(6, 4, 5, 42840, 214200);



-- Thêm dữ liệu vào bảng PHIEUTHU
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES
(1, '2024-09-20', 1000000),
(2, '2024-09-22', 500000),
(1, '2024-09-25', 1500000),
(3, '2024-09-28', 200000)

-- THAMSO already has initial data from your script
-- Bảng THAMSO

SET XACT_ABORT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    UPDATE THAMSO
    SET Max_DaiLyMoiQuan = 4,
        TiLeTinhDonGiaXuat = 1.02,
        ApDungQDKTSoTienThu = 1;

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION;
    THROW;
END CATCH;



SELECT * FROM THAMSO
SELECT * FROM PHIEUTHU