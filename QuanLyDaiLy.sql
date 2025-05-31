
CREATE DATABASE QUANLYDAILY


USE QUANLYDAILY

/*	QUY ƯỚC

Cách đặt tên Khoá ngoại: FK_TenKhoaNgoai_TênBảngĐangChứaKhoáNgoại

*/


CREATE TABLE LOAIDAILY  
(
MaLoaiDaiLy INT IDENTITY(1,1) PRIMARY KEY,
TenLoaiDaiLy NVARCHAR(50),
TienNoToiDa MONEY
)

-----------------------------------------------------------------------------

CREATE TABLE QUAN  
(
MaQuan INT IDENTITY(1,1) PRIMARY KEY,
TenQuan NVARCHAR(30)
)

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
)


ALTER TABLE DAILY
ADD CONSTRAINT FK_MaLoaiDaiLy_DAILY FOREIGN KEY (MaLoaiDaiLy) REFERENCES LOAIDAILY (MaLoaiDaiLy)

ALTER TABLE DAILY
ADD CONSTRAINT FK_MaQuan_DAILY FOREIGN KEY (MaQuan) REFERENCES QUAN (MaQuan)

-----------------------------------------------------------------------------

CREATE TABLE DONVITINH 
(
MaDonViTinh INT IDENTITY(1,1) PRIMARY KEY,
TenDonViTinh VARCHAR(6)
)

-----------------------------------------------------------------------------

CREATE TABLE MATHANG 
(
MaMatHang INT IDENTITY(1,1) PRIMARY KEY,
TenMatHang NVARCHAR(30),
MaDonViTinh INT,
DonGiaHienTai MONEY,
TonKho INT
)

ALTER TABLE MATHANG
ADD CONSTRAINT FK_MaDonViTinh_MATHANG FOREIGN KEY (MaDonViTinh) REFERENCES DONVITINH (MaDonViTinh)

-----------------------------------------------------------------------------

CREATE TABLE PHIEUNHAP  
(
MaPhieuNhap INT IDENTITY(1,1) PRIMARY KEY,
NgayLapPhieu DATE,
TongTien MONEY
)

CREATE TABLE CHITIET_PHIEUNHAP  
(
MaPhieuNhap INT,
MaMatHang INT,
SoLuongNhap INT,
DonGiaNhap MONEY,
ThanhTien MONEY

CONSTRAINT PK1 PRIMARY KEY (MaPhieuNhap, MaMatHang)
)

ALTER TABLE CHITIET_PHIEUNHAP 
ADD CONSTRAINT FK_MaPhieuNhap_CHITIET_PHIEUNHAP FOREIGN KEY (MaPhieuNhap) REFERENCES PHIEUNHAP (MaPhieuNhap)

ALTER TABLE CHITIET_PHIEUNHAP 
ADD CONSTRAINT FK_MaMatHang_CHITIET_PHIEUNHAP FOREIGN KEY (MaMatHang) REFERENCES MATHANG (MaMatHang)

-----------------------------------------------------------------------------

CREATE TABLE PHIEUXUAT 
(
MaPhieuXuat INT  IDENTITY(1,1) PRIMARY KEY,
MaDaiLy INT,
NgayLapPhieu DATE,
TongTien MONEY,
TienTra MONEY,
ConLai MONEY
)

ALTER TABLE PHIEUXUAT 
ADD CONSTRAINT FK_MaDaiLy_PHIEUXUAT FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy)

CREATE TABLE CHITIET_PHIEUXUAT 
(
MaPhieuXuat INT,
MaMatHang INT,
SoLuongXuat INT,
DonGiaXuat MONEY,
ThanhTien MONEY

CONSTRAINT FK2 PRIMARY KEY (MaPhieuXuat, MaMatHang)
)

ALTER TABLE CHITIET_PHIEUXUAT
ADD CONSTRAINT FK_MaPhieuXuat_CHITIET_PHIEUXUAT FOREIGN KEY (MaPhieuXuat) REFERENCES PHIEUXUAT (MaPhieuXuat)

ALTER TABLE CHITIET_PHIEUXUAT
ADD CONSTRAINT FK_MaMatHang_CHITIET_PHIEUXUAT FOREIGN KEY (MaMatHang) REFERENCES MATHANG (MaMatHang)

-----------------------------------------------------------------------------

CREATE TABLE PHIEUTHU 
(
MaPhieuThu INT IDENTITY(1,1) PRIMARY KEY,
MaDaiLy INT,
NgayThuTien DATE,
SoTienThu MONEY
)

ALTER TABLE PHIEUTHU
ADD CONSTRAINT FK_MaDaiLy_PHIEUTHU FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy)

-----------------------------------------------------------------------------

CREATE TABLE THAMSO 
(
Max_DaiLyMoiQuan INT,
TiLeTinhDonGiaXuat FLOAT,
ApDungQDKTSoTienThu BIT
)

INSERT INTO THAMSO VALUES (4, 1.02 , 1)


-----------------------BÁO CÁO-----------------------------------------------

CREATE TABLE BAOCAO_DOANHSO 
(
MaBaoCaoDoanhSo INT IDENTITY(1,1) PRIMARY KEY,
Thang TINYINT,
Nam INT,
TongDoanhSo MONEY
)

CREATE TABLE CHITIET_BAOCAODOANHSO 
(
MaBaoCaoDoanhSo INT,
MaDaiLy INT,
SoLuongPhieuXuat INT,
TongTriGia MONEY,
TiLe FLOAT

CONSTRAINT PK3 PRIMARY KEY (MaBaoCaoDoanhSo, MaDaiLy)
)

ALTER TABLE CHITIET_BAOCAODOANHSO
ADD CONSTRAINT FK_MaBaoCaoDoanhSo_CHITIET_BAOCAODOANHSO FOREIGN KEY (MaBaoCaoDoanhSo) REFERENCES BAOCAO_DOANHSO (MaBaoCaoDoanhSo)

ALTER TABLE CHITIET_BAOCAODOANHSO
ADD CONSTRAINT FK_MaDaiLy_CHITIET_BAOCAODOANHSO FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy)

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
)

ALTER TABLE BAOCAO_CONGNO  
ADD CONSTRAINT FK_MaDaiLy_BAOCAO_CONGNO FOREIGN KEY (MaDaiLy) REFERENCES DAILY (MaDaiLy)


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
		
		




		
			












