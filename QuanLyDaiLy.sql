USE master;
GO
ALTER DATABASE QUANLYDAILY SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE QUANLYDAILY;
GO


CREATE DATABASE QUANLYDAILY;

GO;

USE QUANLYDAILY;

/*	QUY ƯỚC

Cách đặt tên Khoá ngoại: FK_TenKhoaNgoai_TênBảngĐangChứaKhoáNgoại

*/


CREATE TABLE LOAIDAILY  
(
MaLoaiDaiLy INT IDENTITY(1,1) PRIMARY KEY,
TenLoaiDaiLy NVARCHAR(50),
TienNoToiDa MONEY
);

-----------------------------------------------------------------------------

CREATE TABLE QUAN  
(
MaQuan INT IDENTITY(1,1) PRIMARY KEY,
TenQuan NVARCHAR(30)
);

-----------------------------------------------------------------------------

CREATE TABLE DAILY
(
MaDaiLy INT IDENTITY(1,1) PRIMARY KEY,
TenDaiLy NVARCHAR(30),
MaLoaiDaiLy INT,
SDT VARCHAR(12),
Email VARCHAR(50),
DiaChi NVARCHAR(60),
MaQuan INT,
NgayTiepNhan DATE,
TongNo MONEY
);


ALTER TABLE DAILY
ADD CONSTRAINT FK_MaLoaiDaiLy_DAILY FOREIGN KEY (MaLoaiDaiLy) REFERENCES LOAIDAILY (MaLoaiDaiLy);

ALTER TABLE DAILY
ADD CONSTRAINT FK_MaQuan_DAILY FOREIGN KEY (MaQuan) REFERENCES QUAN (MaQuan);
-----------------------------------------------------------------------------

CREATE TABLE DONVITINH 
(
MaDonViTinh INT IDENTITY(1,1) PRIMARY KEY,
TenDonViTinh VARCHAR(6)
);

-----------------------------------------------------------------------------

CREATE TABLE MATHANG 
(
MaMatHang INT IDENTITY(1,1) PRIMARY KEY,
TenMatHang NVARCHAR(30),
MaDonViTinh INT,
DonGiaHienTai MONEY,
TonKho INT
);

ALTER TABLE MATHANG
ADD CONSTRAINT FK_MaDonViTinh_MATHANG FOREIGN KEY (MaDonViTinh) REFERENCES DONVITINH (MaDonViTinh);

-----------------------------------------------------------------------------

CREATE TABLE PHIEUNHAP  
(
MaPhieuNhap INT IDENTITY(1,1) PRIMARY KEY,
NgayLapPhieu DATE,
TongTien MONEY
);

CREATE TABLE CHITIET_PHIEUNHAP  
(
MaPhieuNhap INT,
MaMatHang INT,
SoLuongNhap INT,
DonGiaNhap MONEY,
ThanhTien MONEY

CONSTRAINT PK1 PRIMARY KEY (MaPhieuNhap, MaMatHang)
);

ALTER TABLE CHITIET_PHIEUNHAP 
ADD CONSTRAINT FK_MaPhieuNhap_CHITIET_PHIEUNHAP FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAP (MaPhieuNhap);

ALTER TABLE CHITIET_PHIEUNHAP 
ADD CONSTRAINT FK_MaMatHang_CHITIET_PHIEUNHAP FOREIGN KEY (MaMatHang) REFERENCES MATHANG (MaMatHang);

-----------------------------------------------------------------------------

CREATE TABLE PHIEUXUAT 
(
MaPhieuXuat INT  IDENTITY(1,1) PRIMARY KEY,
MaDaiLy INT,
NgayLapPhieu DATE,
TongTien MONEY,
TienTra MONEY,
ConLai MONEY
);

ALTER TABLE PHIEUXUAT 
ADD CONSTRAINT FK_MaDaiLy_PHIEUXUAT FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy);

CREATE TABLE CHITIET_PHIEUXUAT 
(
MaPhieuXuat INT,
MaMatHang INT,
SoLuongXuat INT,
DonGiaXuat MONEY,
ThanhTien MONEY

CONSTRAINT FK2 PRIMARY KEY (MaPhieuXuat, MaMatHang)
);

ALTER TABLE CHITIET_PHIEUXUAT
ADD CONSTRAINT FK_MaPhieuXuat_CHITIET_PHIEUXUAT FOREIGN KEY (MaPhieuXuat) REFERENCES PHIEUXUAT (MaPhieuXuat);

ALTER TABLE CHITIET_PHIEUXUAT
ADD CONSTRAINT FK_MaMatHang_CHITIET_PHIEUXUAT FOREIGN KEY (MaMatHang) REFERENCES MATHANG (MaMatHang);

-----------------------------------------------------------------------------

CREATE TABLE PHIEUTHU 
(
MaPhieuThu INT IDENTITY(1,1) PRIMARY KEY,
MaDaiLy INT,
NgayThuTien DATE,
SoTienThu MONEY
);

ALTER TABLE PHIEUTHU
ADD CONSTRAINT FK_MaDaiLy_PHIEUTHU FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy);

-----------------------------------------------------------------------------

CREATE TABLE THAMSO 
(
Max_DaiLyMoiQuan INT,
TiLeTinhDonGiaXuat FLOAT,
ApDungQDKTSoTienThu BIT
);

INSERT INTO THAMSO VALUES (4, 1.02 , 0);


-----------------------BÁO CÁO-----------------------------------------------

CREATE TABLE BAOCAO_DOANHSO 
(
MaBaoCaoDoanhSo INT IDENTITY(1,1) PRIMARY KEY,
Thang TINYINT,
Nam INT,
TongDoanhSo MONEY
);

CREATE TABLE CHITIET_BAOCAODOANHSO 
(
MaBaoCaoDoanhSo INT,
MaDaiLy INT,
SoLuongPhieuXuat INT,
TongTriGia MONEY,
TiLe FLOAT

CONSTRAINT PK3 PRIMARY KEY (MaBaoCaoDoanhSo, MaDaiLy)
);

ALTER TABLE CHITIET_BAOCAODOANHSO
ADD CONSTRAINT FK_MaBaoCaoDoanhSo_CHITIET_BAOCAODOANHSO FOREIGN KEY (MaBaoCaoDoanhSo) REFERENCES BAOCAO_DOANHSO (MaBaoCaoDoanhSo);

ALTER TABLE CHITIET_BAOCAODOANHSO
ADD CONSTRAINT FK_MaDaiLy_CHITIET_BAOCAODOANHSO FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy);

-----------------------------------------------------------------------------

CREATE TABLE BAOCAO_CONGNO
( 
Thang TINYINT,
Nam INT,
MaDaiLy INT,
NoDau MONEY,
PhatSinh MONEY,
NoCuoi MONEY

CONSTRAINT PK4 PRIMARY KEY (Thang, Nam, MaDaiLy)
);

ALTER TABLE BAOCAO_CONGNO  
ADD CONSTRAINT FK_MaDaiLy_BAOCAO_CONGNO FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy);

----------------------------------------------------PHAN QUYEN-------------------------
DROP TABLE IF EXISTS NHOMNGUOIDUNG;
CREATE TABLE NHOMNGUOIDUNG
(
MaNhom INT IDENTITY(1,1) PRIMARY KEY,
TenNhom NCHAR(30),
);


DROP TABLE IF EXISTS NGUOIDUNG;
CREATE TABLE NGUOIDUNG
(
TenNguoiDung VARCHAR(30) PRIMARY KEY,
MatKhau VARCHAR(30),
MaNhom INT,
);
ALTER TABLE NGUOIDUNG  
ADD CONSTRAINT FK_NGUOIDUNG_NHOMNGUOIDUNG FOREIGN KEY (MaNhom) REFERENCES NHOMNGUOIDUNG(MaNhom);


DROP TABLE IF EXISTS CHUCNANG;
CREATE TABLE CHUCNANG
(
MaChucNang INT IDENTITY(1,1) PRIMARY KEY,
TenManHinhDuocLoad CHAR(30),

);


DROP TABLE IF EXISTS PHANQUYEN;
CREATE TABLE PHANQUYEN
(
MaNhom INT,
MaChucNang INT,
Xem BIT DEFAULT 1,
Them BIT DEFAULT 1,
Xoa BIT DEFAULT 1,
Sua BIT DEFAULT 1,
CONSTRAINT PK_PHANQUYEN PRIMARY KEY(MaNhom,MaChucNang),
);
ALTER TABLE PHANQUYEN 
ADD CONSTRAINT FK_PHANQUYEN_NHOM FOREIGN KEY (MaNhom) REFERENCES NHOMNGUOIDUNG(MaNhom);

ALTER TABLE PHANQUYEN 
ADD CONSTRAINT FK_PHANQUYEN_CHUCNANG FOREIGN KEY (MaChucNang) REFERENCES CHUCNANG(MaChucNang);

------------------------TRIGGER-------------------------------

-- 1.Trong mỗi Quận có tối đa 4 Đại lý-- OK
/*			Thêm	Xoá		Sửa
DAILY		 +		 -		+ (MaQuan)
*/

GO
CREATE TRIGGER t1 ON DAILY
AFTER INSERT, UPDATE
AS
BEGIN
		IF EXISTS (SELECT *
					FROM DAILY
					GROUP BY MaQuan
					HAVING COUNT(*) > (SELECT Max_DaiLyMoiQuan
										FROM THAMSO )
					)
			BEGIN
				print 'LOI: t1'
				ROLLBACK TRAN
			END
		ELSE
				print 'OK: t1'
END


-- 2.Đại lý loại 1 có tiền nợ tối đa là 10.000.000đ, loại 2 nợ tối đa là 5.000.000đ-- ok
/*			Thêm				Xoá		Sửa
LOAIDAILY	 -					 -		+(TienNoToiDa)
DAILY		 +(TongNo=0:Code)	 -      +(MaLoaiDaiLy,TongNo)
*/

GO
CREATE TRIGGER t2 ON LOAIDAILY
AFTER UPDATE
AS
BEGIN
		IF UPDATE(TienNoToiDa) AND EXISTS (SELECT *
											FROM INSERTED I INNER JOIN DAILY D ON I.MaLoaiDaiLy=D.MaLoaiDaiLy
											WHERE I.TienNoToiDa < D.TongNo
											)
									BEGIN
										print 'LOI: t2'
										ROLLBACK TRAN
									END
		ELSE
			print 'OK: t2'
END 


GO
CREATE TRIGGER t3 ON DAILY
AFTER UPDATE
AS
BEGIN
		IF (UPDATE(MaLoaiDaiLy) OR UPDATE(TongNo)) AND EXISTS (SELECT *	
																FROM INSERTED I INNER JOIN LOAIDAILY L ON I.MaLoaiDaiLy=L.MaLoaiDaiLy
																WHERE L.TienNoToiDa < I.TongNo
																)
					BEGIN
						print 'LOI: t3'
						ROLLBACK TRAN
					END
		ELSE
			print 'OK: t3'
END

-- 4.Số tiền thu không vượt quá số tiền đại lý đang nợ-- ok
/*			Thêm		Xoá		Sửa
PHIEUTHU	 +			 -		 + (SoTienThu = READONLY)
*/

GO
CREATE TRIGGER t4 ON PHIEUTHU
AFTER INSERT
AS 
BEGIN
		IF (SELECT T.ApDungQDKTSoTienThu 
			FROM THAMSO T) = 1 AND EXISTS (SELECT *
										   FROM INSERTED I INNER JOIN DAILY D ON I.MaDaiLy=D.MaDaiLy
										   WHERE I.SoTienThu > D.TongNo
										   )
					BEGIN
						print 'LOI: t4'
						ROLLBACK TRAN
					END
		ELSE
			print 'OK: t4'
END



--5.DAILY.TongNo = SUM(PHIEUXUAT.ConLai) - SUM(PHIEUTHU.SoTienThu)--
/*				Thêm				Xoá							Sửa
DAILY		   	 +(TongNo=0:Code)	 -							+(TongNo = READONLY)
PHIEUXUAT		 +					 +(Không cho xoá PX)		+(MaDaiLy,ConLai)
PHIEUTHU		 +					 +							+(MaDaiLy,SoTienThu)
*/

GO
CREATE TRIGGER t5 ON PHIEUXUAT
AFTER INSERT
AS
BEGIN
				UPDATE DAILY
				SET TongNo = TongNo +  (SELECT SUM(ConLai)
										FROM INSERTED I 
										WHERE I.MaDaiLy=DAILY.MaDaiLy
										)
				FROM INSERTED I
				WHERE I.MaDaiLy=DAILY.MaDaiLy
END 


GO
CREATE TRIGGER t6 ON PHIEUXUAT
AFTER UPDATE
AS
BEGIN
		IF UPDATE(MaDaiLy) OR UPDATE(ConLai)
			BEGIN
				UPDATE DAILY
				SET TongNo = TongNo +  (SELECT SUM(ConLai)
										FROM INSERTED I
										WHERE I.MaDaiLy=DAILY.MaDaiLy
										)
				FROM INSERTED I
				WHERE I.MaDaiLy=DAILY.MaDaiLy

				UPDATE DAILY
				SET TongNo = TongNo -  (SELECT SUM(ConLai)
										FROM DELETED D
										WHERE D.MaDaiLy=DAILY.MaDaiLy
										)
				FROM DELETED D 
				WHERE D.MaDaiLy=DAILY.MaDaiLy
			END
END 

----

GO
CREATE TRIGGER t7 ON PHIEUTHU
AFTER INSERT
AS
BEGIN
		UPDATE DAILY
		SET TongNo = TongNo - (SELECT SUM (SoTienThu)
								FROM INSERTED I
								WHERE I.MaDaiLy=DAILY.MaDaiLy
								)
								
		FROM INSERTED I
		WHERE I.MaDaiLy=DAILY.MaDaiLy
END


GO
CREATE TRIGGER t8 ON PHIEUTHU
AFTER DELETE
AS
BEGIN
		UPDATE DAILY
		SET TongNo = TongNo + (SELECT SUM (SoTienThu)
								FROM DELETED D
								WHERE D.MaDaiLy=DAILY.MaDaiLy
								)
								
		FROM DELETED D
		WHERE D.MaDaiLy=DAILY.MaDaiLy
END


GO
CREATE TRIGGER t9 ON PHIEUTHU
AFTER UPDATE
AS
BEGIN
		IF UPDATE(MaDaiLy) OR UPDATE(SoTienThu)
			BEGIN
				UPDATE DAILY
				SET TongNo = TongNo - (SELECT SUM (SoTienThu)
										FROM INSERTED I
										WHERE I.MaDaiLy=DAILY.MaDaiLy
										)
								
				FROM INSERTED I
				WHERE I.MaDaiLy=DAILY.MaDaiLy

				UPDATE DAILY
				SET TongNo = TongNo + (SELECT SUM (SoTienThu)
										FROM DELETED D
										WHERE D.MaDaiLy=DAILY.MaDaiLy
										)
								
				FROM DELETED D
				WHERE D.MaDaiLy=DAILY.MaDaiLy
			END
END


--6.UPDATE MATHANG.DonGiaHienTai khi INSERT PHIEUNHAP hoặc UPDATE PHIEUNHAP gần nhất --
/*						Thêm			Xoá										Sửa
MATHANG					 +(DGHT=0)		 -										+ (DonGiaHienTai = READONLY)
CHITIET_PHIEUNHAP		 +				 +(Xoá CHITIET gần nhất					+ (DonGiaNhap . Chỉ check đối với update PHIEUNHAP gần nhất)
										của MATHANG mới check)
*/

GO
CREATE TRIGGER t10 ON CHITIET_PHIEUNHAP  
AFTER INSERT
AS
BEGIN
		UPDATE MATHANG
		SET DonGiaHienTai =	(SELECT DonGiaNhap
							 FROM INSERTED I
							  WHERE I.MaMatHang=MATHANG.MaMatHang
							 ) --Mặc định 1 CHITIET chỉ có 1 MATHANG
		FROM INSERTED I
		WHERE I.MaMatHang=MATHANG.MaMatHang
END


GO
CREATE TRIGGER t11 ON CHITIET_PHIEUNHAP
AFTER DELETE
AS
BEGIN
		IF (SELECT D.MaPhieuNhap FROM DELETED D) > (SELECT MAX(CT.MaPhieuNhap)	FROM CHITIET_PHIEUNHAP CT INNER JOIN DELETED D ON CT.MaMatHang=D.MaMatHang)
			BEGIN
				UPDATE MATHANG
				SET DonGiaHienTai = (SELECT	CT1.DonGiaNhap
									 FROM CHITIET_PHIEUNHAP CT1 INNER JOIN DELETED D1 ON CT1.MaMatHang=D1.MaMatHang
									 WHERE CT1.MaPhieuNhap = (SELECT MAX(CT2.MaPhieuNhap)
															 FROM CHITIET_PHIEUNHAP CT2 INNER JOIN DELETED D2 ON CT2.MaMatHang=D2.MaMatHang
															 )
									)
				FROM DELETED D
				WHERE D.MaMatHang=MATHANG.MaMatHang
			END
END 
	
	
GO
CREATE TRIGGER t12 ON CHITIET_PHIEUNHAP
AFTER UPDATE
AS
BEGIN
		IF UPDATE(DonGiaNhap) AND (SELECT I.MaPhieuNhap FROM INSERTED I) = (SELECT MAX(CT.MaPhieuNhap) FROM CHITIET_PHIEUNHAP CT INNER JOIN INSERTED I ON CT.MaMatHang=I.MaMatHang)
			BEGIN
				UPDATE MATHANG
				SET DonGiaHienTai = (SELECT	I.DonGiaNhap
									FROM INSERTED I
									WHERE I.MaMatHang=MATHANG.MaMatHang
									)
									 
				FROM INSERTED I
				WHERE I.MaMatHang=MATHANG.MaMatHang
			END
END


--7.MATHANG.TonKho = SUM(CT_PHIEUNHAP.SoLuongNhap) - SUM(CT_PHIEUXUAT.SoLuongXuat)--
/*						Thêm			Xoá			Sửa
MATHANG					 +(TonKho=0)	 -			+(TonKho = READONLY)
CHITIET_PHIEUNHAP		 +				 +			+(MaMatHang, SoLuongNhap)
CHITIET_PHIEUXUAT		 +				 +			+(MaMatHang, SoLuongXuat)
*/


GO
CREATE TRIGGER t13 ON CHITIET_PHIEUNHAP
AFTER INSERT
AS
BEGIN
		UPDATE MATHANG
		SET TonKho = TonKho + (SELECT SUM(I.SoLuongNhap)
								FROM INSERTED I
								WHERE I.MaMatHang=MATHANG.MaMatHang 
								)
		FROM INSERTED I
		WHERE I.MaMatHang=MATHANG.MaMatHang
END
	

GO
CREATE TRIGGER t14 ON CHITIET_PHIEUNHAP
AFTER DELETE
AS
BEGIN
		UPDATE MATHANG
		SET TonKho = TonKho - (SELECT SUM(D.SoLuongNhap)
								FROM DELETED D
								WHERE D.MaMatHang=MATHANG.MaMatHang 
								)
		FROM DELETED D
		WHERE D.MaMatHang=MATHANG.MaMatHang
END


GO
CREATE TRIGGER t15 ON CHITIET_PHIEUNHAP
AFTER UPDATE
AS
BEGIN
		IF UPDATE(MaMatHang) OR UPDATE(SoLuongNhap)
			BEGIN
				UPDATE MATHANG
				SET TonKho = TonKho + (SELECT SUM(I.SoLuongNhap)
										FROM INSERTED I
										WHERE I.MaMatHang=MATHANG.MaMatHang 
										)
				FROM INSERTED I
				WHERE I.MaMatHang=MATHANG.MaMatHang

				UPDATE MATHANG
				SET TonKho = TonKho - (SELECT SUM(D.SoLuongNhap)
										FROM DELETED D
										WHERE D.MaMatHang=MATHANG.MaMatHang 
										)
				FROM DELETED D
				WHERE D.MaMatHang=MATHANG.MaMatHang
			END
END
		
----

GO
CREATE TRIGGER t16 ON CHITIET_PHIEUXUAT
AFTER INSERT
AS
BEGIN
		UPDATE MATHANG
		SET TonKho = TonKho -  (SELECT SUM(I.SoLuongXuat)
								FROM INSERTED I
								WHERE I.MaMatHang=MATHANG.MaMatHang 
								)
		FROM INSERTED I
		WHERE I.MaMatHang=MATHANG.MaMatHang
END


GO
CREATE TRIGGER t17 ON CHITIET_PHIEUXUAT
AFTER DELETE
AS
BEGIN
		UPDATE MATHANG
		SET TonKho = TonKho + (SELECT SUM(D.SoLuongXuat)
								FROM DELETED D
								WHERE D.MaMatHang=MATHANG.MaMatHang 
								)
		FROM DELETED D
		WHERE D.MaMatHang=MATHANG.MaMatHang
END
	

GO
CREATE TRIGGER t18 ON CHITIET_PHIEUXUAT
AFTER UPDATE
AS
BEGIN
		IF UPDATE(MaMatHang) OR UPDATE(SoLuongXuat)
			BEGIN
				UPDATE MATHANG
				SET TonKho = TonKho -  (SELECT SUM(I.SoLuongXuat)
										FROM INSERTED I
										WHERE I.MaMatHang=MATHANG.MaMatHang 
										)
				FROM INSERTED I
				WHERE I.MaMatHang=MATHANG.MaMatHang

				UPDATE MATHANG
				SET TonKho = TonKho +  (SELECT SUM(D.SoLuongXuat)
										FROM DELETED D
										WHERE D.MaMatHang=MATHANG.MaMatHang 
										)
				FROM DELETED D
				WHERE D.MaMatHang=MATHANG.MaMatHang
			END
END


-- 8.PHIEUNHAP.TongTien = SUM(CT_PHIEUNHAP.ThanhTien) --
/*					   	Thêm			Xoá		 Sửa
PHIEUNHAP				 +(0:CODE)		 -		 + (TongTien = READONLY)
CHITIET_PHIEUNHAP		 +				 +		 + (ThanhTien = READONLY)
*/

GO
CREATE TRIGGER t19 ON CHITIET_PHIEUNHAP
AFTER INSERT
AS
BEGIN
		UPDATE PHIEUNHAP
		SET TongTien = TongTien +  (SELECT SUM(I.ThanhTien)
									FROM INSERTED I
									WHERE I.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
									)
		FROM INSERTED I
		WHERE I.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
END


GO
CREATE TRIGGER t20 ON CHITIET_PHIEUNHAP
AFTER DELETE
AS
BEGIN
		UPDATE PHIEUNHAP
		SET TongTien = TongTien -  (SELECT SUM(D.ThanhTien)
									FROM DELETED D
									WHERE D.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
									)
		FROM DELETED D
		WHERE D.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
END


GO
CREATE TRIGGER t21 ON CHITIET_PHIEUNHAP
AFTER UPDATE
AS
BEGIN
		IF UPDATE(ThanhTien)
			BEGIN
				UPDATE PHIEUNHAP
				SET TongTien = TongTien +  (SELECT SUM(I.ThanhTien)
											FROM INSERTED I
											WHERE I.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
											)
				FROM INSERTED I
				WHERE I.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap

				UPDATE PHIEUNHAP
				SET TongTien = TongTien -  (SELECT SUM(D.ThanhTien)
											FROM DELETED D
											WHERE D.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
											)
				FROM DELETED D
				WHERE D.MaPhieuNhap=PHIEUNHAP.MaPhieuNhap
			END
END



-- 10.PHIEUXUAT.TongTien = SUM(CT_PHIEUXUAT.ThanhTien)--
/*					   	Thêm			Xoá		 Sửa
PHIEUNHAP				 +(0:CODE)		 -		 + (TongTien = READONLY)
CHITIET_PHIEUNHAP		 +				 +		 + (ThanhTien = READONLY)
*/

GO
CREATE TRIGGER t22 ON CHITIET_PHIEUXUAT
AFTER INSERT
AS
BEGIN
		UPDATE PHIEUXUAT
		SET TongTien = TongTien +  (SELECT SUM(I.ThanhTien)
									FROM INSERTED I
									WHERE I.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
									)
		FROM INSERTED I
		WHERE I.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
END


GO
CREATE TRIGGER t23 ON CHITIET_PHIEUXUAT
AFTER DELETE
AS
BEGIN
		UPDATE PHIEUXUAT
		SET TongTien = TongTien -  (SELECT SUM(D.ThanhTien)
									FROM DELETED D
									WHERE D.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
									)
		FROM DELETED D
		WHERE D.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
END


GO
CREATE TRIGGER t24 ON CHITIET_PHIEUXUAT
AFTER UPDATE
AS
BEGIN
		IF UPDATE(ThanhTien)
			BEGIN
				UPDATE PHIEUXUAT
				SET TongTien = TongTien +  (SELECT SUM(I.ThanhTien)
											FROM INSERTED I
											WHERE I.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
											)
				FROM INSERTED I
				WHERE I.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat

				UPDATE PHIEUXUAT
				SET TongTien = TongTien -  (SELECT SUM(D.ThanhTien)
											FROM DELETED D
											WHERE D.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
											)
				FROM DELETED D
				WHERE D.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
			END
END

-- 13.DAILY.NgayTiepNhan ≤ PHIEUXUAT.NgayLapPhieu --
/*				Thêm	Xoá		Sửa
DAILY			 -		 -		+ (NgayTiepNhan)
PHIEUXUAT		 +		 -		+ (MaDaiLy,NgayLapPhieu)
*/

GO
CREATE TRIGGER t25 ON DAILY
AFTER UPDATE
AS
BEGIN
		IF UPDATE(NgayTiepNhan)
			BEGIN
				IF EXISTS (SELECT *
							FROM INSERTED I INNER JOIN PHIEUXUAT P ON I.MaDaiLY=P.MaDaiLy
							WHERE I.NgayTiepNhan > P.NgayLapPhieu
							)
					BEGIN
						print 'LOI: t25'
						ROLLBACK TRAN
					END
				ELSE
					print 'OK: t25'
			END
END

GO
CREATE TRIGGER t26 ON PHIEUXUAT
AFTER INSERT, UPDATE
AS
BEGIN
		IF EXISTS (SELECT *
					FROM INSERTED I INNER JOIN DAILY D ON I.MaDaiLy=D.MaDaiLy
					WHERE I.NgayLapPhieu < D.NgayTiepNhan
					)
			BEGIN
				print 'LOI: t26'
				ROLLBACK TRAN
			END
		ELSE
			print 'OK: t26'
END


-- 14.DAILY.NgayTiepNhan ≤ PHIEUTHU.NgayThuTien --
/*				Thêm	Xoá		Sửa
DAILY			 -		 -		+(NgayTiepNhan)
PHIEUTHU		 +		 -		+(MaDaiLy,NgayThuTien)
*/

GO
CREATE TRIGGER t27 ON DAILY
AFTER UPDATE
AS
BEGIN
		IF UPDATE(NgayTiepNhan)
			BEGIN
				IF EXISTS (SELECT *
							FROM INSERTED I INNER JOIN PHIEUTHU P ON I.MaDaiLy=P.MaDaiLy
							WHERE I.NgayTiepNhan > P.NgayThuTien
							)
					BEGIN
						print 'LOI: t27'
						ROLLBACK TRAN
					END
				ELSE
					print 'OK: t27'
			END
END


GO
CREATE TRIGGER t28 ON PHIEUTHU
AFTER INSERT, UPDATE
AS
BEGIN
		IF EXISTS (SELECT *
					FROM INSERTED I INNER JOIN DAILY D ON I.MaDaiLy=D.MaDaiLy
					WHERE I.NgayThuTien < D.NgayTiepNhan
					)
			BEGIN
				print 'LOI: t28'
				ROLLBACK TRAN
			END
		ELSE
			print 'OK: t28'
END


-- 15.PHIEUXUAT.NgayLapPhieu ( xét ĐẦU TIÊN thôi) ≤ PHIEUTHU.NgayThuTien --
/*				Thêm	Xoá		Sửa
PHIEUXUAT		 -		 +		+ (MaDaiLy,NgayLapPhieu)
PHIEUTHU		 +		 -      + (MaDaiLy,NgayThuTien)
*/

--CHECK data nhớ chú ý ngày có thể giống nhau -> nên để DATETIME thay vì DATE

GO
CREATE TRIGGER t29 ON PHIEUXUAT
AFTER DELETE  --DELETE nhiều dòng cùng lúc được nha
AS
BEGIN
	DECLARE @maphieuxuat INT
	DECLARE @madaily INT
	DECLARE @ngay DATE
	DECLARE @error BIT = 0

	DECLARE cur29 CURSOR FOR
    SELECT MaPhieuXuat, MaDaiLy, NgayLapPhieu FROM deleted  

    OPEN cur29
    FETCH NEXT FROM cur29 INTO @maphieuxuat, @madaily, @ngay

    WHILE @@FETCH_STATUS = 0
		BEGIN
			IF ((SELECT COUNT(*)
			FROM PHIEUXUAT PX
			WHERE PX.MaDaiLy=@madaily) = 0) AND ((SELECT COUNT(*)
												   FROM PHIEUTHU PT
												   WHERE PT.MaDaiLy=@madaily) > 0)
						BEGIN
							print N'LỖI t29.1 tại MaPhieuXuat = ' + CAST(@maphieuxuat AS NVARCHAR)
							SET @error = 1
						END
			ELSE IF @ngay < (SELECT MIN(PX.NgayLapPhieu)
							FROM PHIEUXUAT PX 
							WHERE PX.MaDaiLy = @madaily
							) -- kiểm tra có phải xoá PHIEUXUAT đầu tiên của DAILY đó không?
				BEGIN
					IF (SELECT MIN(PX.NgayLapPhieu)
						FROM PHIEUXUAT PX
						WHERE PX.MaDaiLy=@madaily
						)	>	(SELECT MIN(PT.NgayThuTien)
								 FROM PHIEUTHU PT
								 WHERE PT.MaDaiLy=@madaily
								 )  -- kiểm tra PHIEUXUAT đầu tiên có lớn hơn PHIEUTHU đầu tiên của DAILY đó không
								BEGIN	
									print N'LỖI tại 29.2 tại MaPhieuXuat = ' + CAST(@maphieuxuat AS NVARCHAR)
									SET @error = 1
								END
       
				END
			 FETCH NEXT FROM cur29 INTO @maphieuxuat, @madaily, @ngay
		END


    CLOSE cur29
    DEALLOCATE cur29

    IF (@error = 1)
    BEGIN
        ROLLBACK TRAN
        RETURN 
    END

END

		

GO				
CREATE TRIGGER t30 ON PHIEUXUAT
AFTER UPDATE -- chỉ được UPDATE mỗi lần 1 Record
AS
BEGIN
				IF UPDATE(MaDaiLy) OR UPDATE(NgayLapPhieu)
					BEGIN	
							IF ((SELECT COUNT(*)
								FROM PHIEUXUAT PX,DELETED D
								WHERE PX.MaDaiLy=D.MaDaiLy) = 0) AND ((SELECT COUNT(*)
																	   FROM PHIEUTHU PT,DELETED D
																	   WHERE PT.MaDaiLy=D.MaDaiLy) > 0)
											BEGIN
												print 'LOI: t30.1'
												ROLLBACK TRAN
											END
								ELSE
									BEGIN
										IF (SELECT TOP 1 PX.NgayLapPhieu
											FROM PHIEUXUAT PX,DELETED D
											WHERE PX.MaDaiLy=D.MaDaiLy
											ORDER BY PX.NgayLapPhieu)     >		(SELECT TOP 1 PT.NgayThuTien
																				 FROM PHIEUTHU PT,DELETED D
																				 WHERE PT.MaDaiLy=D.MaDaiLy
																				 ORDER BY PT.NgayThuTien)
													BEGIN
														print 'LOI: t30.2'
														ROLLBACK TRAN
													END
										ELSE
											print 'OK: t30'
									END
					END
END

GO
CREATE TRIGGER t31 ON PHIEUTHU
AFTER INSERT	
AS 
BEGIN
    DECLARE @ngay DATE
    DECLARE @madaily INT
    DECLARE @error BIT = 0

    DECLARE cur1 CURSOR FOR
    SELECT MaDaiLy, NgayThuTien FROM inserted 

    OPEN cur1
    FETCH NEXT FROM cur1 INTO @madaily, @ngay

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Kiểm tra phiếu xuất tồn tại
        IF (SELECT COUNT(*) FROM PHIEUXUAT PX WHERE PX.MaDaiLy = @madaily) = 0
        BEGIN
            PRINT N'LỖI: t31.1 tại dòng có MaDaiLy = ' + CAST(@madaily AS NVARCHAR) + ' ngày ' + CAST(@ngay AS NVARCHAR)
            SET @error = 1
        END

        -- Kiểm tra ngày thu tiền nhỏ hơn ngày xuất
        ELSE IF (SELECT MIN(PX.NgayLapPhieu) FROM PHIEUXUAT PX WHERE PX.MaDaiLy = @madaily) > @ngay
        BEGIN
            PRINT N'LỖI: t31.2 tại dòng có MaDaiLy = ' + CAST(@madaily AS NVARCHAR) + ' ngày ' + CAST(@ngay AS NVARCHAR)
            SET @error = 1
        END

        FETCH NEXT FROM cur1 INTO @madaily, @ngay
    END

    CLOSE cur1
    DEALLOCATE cur1

    IF (@error = 1)
    BEGIN
        ROLLBACK TRAN
        RETURN  -- Dừng thực thi tiếp theo
    END
END


GO
CREATE TRIGGER t32 ON PHIEUTHU
AFTER UPDATE	-- chỉ được UPDATE mỗi lần 1 Record
AS 
BEGIN
		IF UPDATE(MaDaiLy) OR UPDATE(NgayThuTien)
			BEGIN
				IF (SELECT COUNT(*)	
					FROM INSERTED I, PHIEUXUAT PX
					WHERE I.MaDaiLy=PX.MaDaiLy
					) = 0
							BEGIN
								print 'LOI: t32.1'
								ROLLBACK TRAN
							END

				ELSE IF (SELECT TOP 1 PX.NgayLapPhieu
			 			 FROM PHIEUXUAT PX, INSERTED I
						 WHERE PX.MaDaiLy=I.MaDaiLy
						 ORDER BY PX.NgayLapPhieu) > (SELECT NgayThuTien
													  FROM INSERTED)
							BEGIN
								print 'LOI: t32.2'
								ROLLBACK TRAN
							END
				ELSE
					print 'OK: t32'
			END
END

-- 16.Chỉ có phép tồn tại duy nhất 1 Record của bảng THAMSO trong DataBase --
/*			Thêm	Xoá		Sửa
THAMSO		 +		 +		 -
*/

GO
CREATE TRIGGER t33 ON THAMSO
AFTER INSERT
AS
BEGIN
		IF (SELECT COUNT(*) FROM THAMSO) > 1
			BEGIN
				print 'LOI: t33'
				ROLLBACK TRAN
			END
		ELSE
			print 'OK: t33'
END


GO
CREATE TRIGGER t34 ON THAMSO
AFTER DELETE
AS
BEGIN
		IF (SELECT COUNT(*) FROM THAMSO) < 1
			BEGIN 
				print 'LOI: t34'
				ROLLBACK TRAN
			END
		ELSE
			print 'OK: t34'
END
		
		

-- 17.MATHANG.TonKho ≥ 0 --
/*				Thêm			Xoá		Sửa
MATHANG			 -(CODE:0)		 -		 + (TonKho)
*/

GO 
CREATE TRIGGER t35 ON MATHANG
AFTER UPDATE
AS
BEGIN
		IF UPDATE(TonKho)
			BEGIN	
				IF EXISTS (SELECT *
						   FROM INSERTED I
						   WHERE TonKho < 0
						   )
					BEGIN
						print 'LOI: t35'
						ROLLBACK TRAN
					END
				ELSE 
					print 'OK: t35'
			END
END


GO
CREATE TRIGGER t36 ON NHOMNGUOIDUNG
FOR INSERT
AS
BEGIN
		 SET NOCOUNT ON;

    -- Chèn dòng phân quyền mặc định (Xem, Thêm, Xóa, Sửa = 0) cho mỗi chức năng
    INSERT INTO PHANQUYEN (MaNhom, MaChucNang, Xem, Them, Xoa, Sua)
    SELECT 
        i.MaNhom, 
        c.MaChucNang,
        0, 0, 0, 0
    FROM INSERTED i
    CROSS JOIN CHUCNANG c
	WHERE i.MaNhom <> 1

	
    INSERT INTO PHANQUYEN (MaNhom, MaChucNang, Xem, Them, Xoa, Sua)
    SELECT 
        i.MaNhom, 
        c.MaChucNang,
        1,1,1,1
    FROM INSERTED i
    CROSS JOIN CHUCNANG c
	WHERE i.MaNhom = 1
	
END



/*
------------------------------------

USE QUANLYDAILY;
GO

-- 1. Loại đại lý
INSERT INTO LOAIDAILY (TenLoaiDaiLy, TienNoToiDa) VALUES
  (N'Đại lý cấp 1', 10000000),
  (N'Đại lý cấp 2', 5000000);
GO

-- 2. Quận
INSERT INTO QUAN (TenQuan) VALUES
  (N'Quận 1'),
  (N'Quận 2'),
  (N'Quận 3');
GO

-- 3. Đơn vị tính
INSERT INTO DONVITINH (TenDonViTinh) VALUES
  ('kg'),
  ('cai'),
  ('lit');
GO

-- 4. Mặt hàng
INSERT INTO MATHANG (TenMatHang, MaDonViTinh, DonGiaHienTai, TonKho) VALUES
  (N'Sản phẩm A', 1, 120000, 0),
  (N'Sản phẩm B', 2,  75000, 0),
  (N'Sản phẩm C', 3,   5000, 0);
GO

-- 5. Đại lý
INSERT INTO DAILY (TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo) VALUES
  (N'Đại lý Alpha',   1, '0912345678', 'alpha@daily.com',   N'123 Đường A, Phường X', 1, '2025-01-10', 0),
  (N'Đại lý Beta',    2, '0987654321', 'beta@daily.com',    N'456 Đường B, Phường Y', 2, '2025-02-15', 0),
  (N'Đại lý Gamma',   1, '0901234567', 'gamma@daily.com',   N'789 Đường C, Phường Z', 3, '2025-03-05', 0);
GO

-- 6. Phiếu nhập và chi tiết phiếu nhập
INSERT INTO PHIEUNHAP (NgayLapPhieu, TongTien) VALUES
  ('2025-03-20', 0),
  ('2025-04-02', 0);
GO

INSERT INTO CHITIET_PHIEUNHAP (MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien) VALUES
  (1, 1,  50, 120000, 50 * 120000),
  (1, 2,  30,  75000, 30 *  75000),
  (2, 3, 100,   5000,100 *   5000);
GO

-- 7. Phiếu xuất và chi tiết phiếu xuất
INSERT INTO PHIEUXUAT (MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES
  (1, '2025-04-10', 0, 0, 0),
  (2, '2025-04-12', 0, 0, 0);
GO

INSERT INTO CHITIET_PHIEUXUAT (MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) VALUES
  (1, 1,  10, 120000, 10 * 120000),
  (1, 3,  20,   5000, 20 *   5000),
  (2, 2,  15,  75000, 15 *  75000);
GO

-- 8. Phiếu thu
INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES
  (1, '2025-04-15',  (SELECT ConLai FROM PHIEUXUAT WHERE MaPhieuXuat = 1)),
  (2, '2025-04-20',  (SELECT ConLai FROM PHIEUXUAT WHERE MaPhieuXuat = 2));
GO

-- 9. Báo cáo doanh số và chi tiết
INSERT INTO BAOCAO_DOANHSO (Thang, Nam, TongDoanhSo) VALUES
  (4, 2025, 0);
GO

INSERT INTO CHITIET_BAOCAODOANHSO (MaBaoCaoDoanhSo, MaDaiLy, SoLuongPhieuXuat, TongTriGia, TiLe) VALUES
  (1, 1, 2, (SELECT TongTien FROM PHIEUXUAT WHERE MaPhieuXuat = 1), 1.0),
  (1, 2, 1, (SELECT TongTien FROM PHIEUXUAT WHERE MaPhieuXuat = 2), 0.5);
GO

-- 10. Báo cáo công nợ
INSERT INTO BAOCAO_CONGNO (Thang, Nam, MaDaiLy, NoDau, PhatSinh, NoCuoi) VALUES
  (4, 2025, 1,
    0,
    (SELECT SUM(ConLai) FROM PHIEUXUAT WHERE MaDaiLy = 1),
    (SELECT TongNo FROM DAILY WHERE MaDaiLy = 1)
  ),
  (4, 2025, 2,
    0,
    (SELECT SUM(ConLai) FROM PHIEUXUAT WHERE MaDaiLy = 2),
    (SELECT TongNo FROM DAILY WHERE MaDaiLy = 2)
  );
GO

*/		












