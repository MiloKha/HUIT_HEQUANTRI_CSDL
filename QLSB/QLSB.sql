USE master;
GO
ALTER DATABASE QL_SANBONG SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
drop database QL_SANBONG

----------------------------------------
CREATE DATABASE QL_SANBONG;
GO

USE QL_SANBONG;
GO

CREATE TABLE LOAISAN
(
    MALS NVARCHAR(10) NOT NULL PRIMARY KEY,
    TENLS NVARCHAR(50),
    GHICHU NVARCHAR(250)
);
GO

CREATE TABLE SAN
(
    MASAN NVARCHAR(15) NOT NULL PRIMARY KEY,
    DIACHI NVARCHAR(50),
    TIENTHUE MONEY,
    MALS NVARCHAR(10),
    MANV NVARCHAR(15),
    FOREIGN KEY(MALS) REFERENCES LOAISAN(MALS)
);
GO

CREATE TABLE KHACHHANG
(
    MAKH NVARCHAR(15) NOT NULL PRIMARY KEY,
    TENKH NVARCHAR(50),
    NGSINH DATE,
    DIACHI NVARCHAR(50),
    DIENTHOAI NVARCHAR(20)
);
GO

CREATE TABLE NHANVIEN
(
    MANV NVARCHAR(15) NOT NULL PRIMARY KEY,
    TENNV NVARCHAR(50),
    NGAYSINH DATE
);
GO

CREATE TABLE THANHTOAN
(
    MATHANHTOAN NVARCHAR(40) NOT NULL PRIMARY KEY,
    MASAN NVARCHAR(15),
    MANV NVARCHAR(15),
    MAKH NVARCHAR(15),
    NGAYTHUE DATE,
    GIOBD INT,
    GIOKT INT,
    FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
    FOREIGN KEY(MASAN) REFERENCES SAN(MASAN),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
);
GO

CREATE TABLE CHITIET_THANHTOAN
(
    MATHANHTOAN NVARCHAR(40) NOT NULL,
    MASAN NVARCHAR(15),
    MANV NVARCHAR(15),
    MAKH NVARCHAR(15),
    NGAYTHUE DATE,
    TRANGTHAI NVARCHAR(20),
    NGAYTHANHTOAN DATE,
    SOTIENTHANHTOAN MONEY,
    PRIMARY KEY(MASAN, MANV, MAKH, NGAYTHUE, MATHANHTOAN),
    FOREIGN KEY(MATHANHTOAN) REFERENCES THANHTOAN(MATHANHTOAN)
);
GO

INSERT INTO LOAISAN(MALS, TENLS, GHICHU)
VALUES
('S5', N'Sân 5 Người', NULL),
('S7', N'Sân 7 Người', NULL),
('S11', N'Sân 11 Người', NULL);
GO

SET DATEFORMAT MDY;
INSERT INTO NHANVIEN(MANV, TENNV, NGAYSINH)
VALUES
('NV001', N'Lê Nguyễn Minh Thành', '3/7/1993'),
('NV002', N'Nguyễn Hữu Hiếu', '4/24/1999'),
('NV003', N'Cao Nguyễn Thành Đạt', '6/7/1990'),
('NV004', N'Lê Quý', '5/5/1993'),
('NV005', N'Lê Hoàng Thành', '1/10/2003');
GO

INSERT INTO SAN(MASAN, DIACHI, TIENTHUE, MALS, MANV)
VALUES
('S501', N'142 Lê Trọng Tấn, Tân Phú, TP.HCM', 300000, 'S5', 'NV001'),
('S502', N'111 Bình Thới, Q11, TP.HCM', 350000, 'S5', 'NV002'),
('S701', N'123 Tân Thới Nhất, Q12, TP.HCM', 900000, 'S7', 'NV003'),
('S702', N'21 Tô Kí, Q12, TP.HCM', 1000000, 'S7', 'NV004'),
('S1101', N'221 Phạm Văn Chiêu, TP.HCM', 2500000, 'S11','NV005' );
GO

INSERT INTO KHACHHANG(MAKH, TENKH, NGSINH, DIACHI, DIENTHOAI)
VALUES
('KH001', N'Trần Thanh Bình', '9/13/1998', N'123 Trương Định, Q3, TP.HCM', '0989123456'),
('KH002', N'Lê Minh Tuấn', '4/24/2000', N'10 Lê Lai, Q1, TP.HCM', '0918456234'),
('KH003', N'Lê Thành Nam', '5/12/1999', N'12 Ngô Quyền, Q5, TP.HCM', '0909657456'),
('KH004', N'Nguyễn Hoàng Khang', '1/10/2003', N'123 Trương Định, Q3, TP.HCM', '0912657456'),
('KH005', N'Phạm Anh Tú', '4/20/2005', N'123 Trương Định, Q3, TP.HCM', '0386520124');
GO

INSERT INTO THANHTOAN(MATHANHTOAN, MASAN, MANV, MAKH, NGAYTHUE, GIOBD, GIOKT)
VALUES
('TT001', 'S501', 'NV001', 'KH003', '5/6/2023', 15, 18),
('TT002', 'S1101', 'NV005', 'KH002', '5/10/2023', 14, 17),
('TT003', 'S701', 'NV003', 'KH004', '5/20/2023', 19, 22),
('TT004', 'S502', 'NV002', 'KH005', '5/20/2023', 19, 21),
('TT005', 'S1101', 'NV005', 'KH001', '5/21/2023', 14, 20);
GO

INSERT INTO CHITIET_THANHTOAN(MATHANHTOAN, MASAN, MANV, MAKH, NGAYTHUE, TRANGTHAI, NGAYTHANHTOAN, SOTIENTHANHTOAN)
VALUES
('TT001', 'S501', 'NV001', 'KH003', '5/6/2023', N'Đã thanh toán', '5/7/2023', 540000),
('TT002', 'S1101', 'NV005', 'KH002', '5/10/2023', N'Đã thanh toán', '5/7/2023', 540000),
('TT003', 'S701', 'NV003', 'KH004', '5/20/2023', N'Đã thanh toán', '5/21/2023', 2700000),
('TT004', 'S502', 'NV002', 'KH005', '5/20/2023', N'Đã thanh toán', '5/7/2023', 540000),
('TT005', 'S1101', 'NV005', 'KH001', '5/21/2023', N'Đã thanh toán', '5/7/2023', 540000);
GO

-----------------------------------------
-----------------------------------------
-----------------------------------------
-----------------------------------------------Bùi Trần Minh Kha-----------------------------------------

----------Thủ tục hiện thông tin sân
CREATE PROCEDURE HienThiThongTinSan
AS
BEGIN
    SELECT 
        s.MASAN,
        (SELECT TENLS FROM LOAISAN WHERE MALS = s.MALS) AS TENSAN,
        tt.MATHANHTOAN,
        tt.MAKH,
        tt.GIOBD,
        tt.GIOKT,
        tt.NGAYTHUE,
        CASE 
            WHEN 
                (SELECT COUNT(*) 
                 FROM CHITIET_THANHTOAN 
                 WHERE MATHANHTOAN = tt.MATHANHTOAN 
                 AND NGAYTHANHTOAN IS NULL) > 0 
            THEN N'Chưa thanh toán' 
            ELSE N'Đã thanh toán'
        END AS TRANGTHAI
    FROM SAN s, THANHTOAN tt
    WHERE s.MASAN = tt.MASAN
    AND (SELECT COUNT(*)                   ----- Hiện bản ghi chưa thanh toán
         FROM CHITIET_THANHTOAN 
         WHERE MATHANHTOAN = tt.MATHANHTOAN 
         AND NGAYTHANHTOAN IS NULL) > 0
    ORDER BY s.MASAN, tt.GIOBD;
END;
GO


DROP PROCEDURE HienThiThongTinSan;
go

EXEC HienThiThongTinSan;
go

---------- Thủ tục thêm bill thanh toán
CREATE PROCEDURE ThemThanhToan
    @MASAN NVARCHAR(15),
    @MAKH NVARCHAR(15),
    @GIOBD INT,
    @GIOKT INT
AS
BEGIN
    DECLARE @NGAYTHUE DATE = CONVERT(DATE, GETDATE());
    DECLARE @MANV NVARCHAR(15);
    DECLARE @MATHANHTOAN NVARCHAR(40);

    -- Tạo MATHANHTOAN duy nhất, ví dụ: sử dụng hàm NEWID()
    SET @MATHANHTOAN = NEWID();

    SELECT @MANV = MANV FROM SAN WHERE MASAN = @MASAN;

    -- Kiểm tra xem có khoảng thời gian nào trùng khớp không cho các bản ghi chưa thanh toán
    IF NOT EXISTS (
        SELECT * FROM THANHTOAN tt
        WHERE tt.MASAN = @MASAN 
          AND tt.NGAYTHUE = @NGAYTHUE
          AND (
              (tt.GIOBD <= @GIOBD AND tt.GIOKT > @GIOBD) OR
              (tt.GIOBD < @GIOKT AND tt.GIOKT >= @GIOKT) OR
              (tt.GIOBD >= @GIOBD AND tt.GIOKT <= @GIOKT)
          )
          AND EXISTS (
              SELECT 1 FROM CHITIET_THANHTOAN ctt
              WHERE ctt.MATHANHTOAN = tt.MATHANHTOAN 
                AND ctt.TRANGTHAI = N'Chưa thanh toán'
          )
    )
    BEGIN
        -- Thêm bản ghi vào bảng THANHTOAN
        INSERT INTO THANHTOAN (MATHANHTOAN, MASAN, MANV, MAKH, NGAYTHUE, GIOBD, GIOKT)
        VALUES (@MATHANHTOAN, @MASAN, @MANV, @MAKH, @NGAYTHUE, @GIOBD, @GIOKT);

        -- Thêm bản ghi vào bảng CHITIET_THANHTOAN
        INSERT INTO CHITIET_THANHTOAN (MATHANHTOAN, MASAN, MANV, MAKH, NGAYTHUE, TRANGTHAI)
        VALUES (@MATHANHTOAN, @MASAN, @MANV, @MAKH, @NGAYTHUE, N'Chưa thanh toán');
    END
    ELSE
    BEGIN
        -- Nếu có bản ghi trùng khớp với trạng thái "Chưa thanh toán", thông báo lỗi
        THROW 50000, 'Thời gian này đã được đặt cho sân này và chưa được thanh toán.', 1;
    END
END;
GO

DROP PROCEDURE ThemThanhToan;

EXEC ThemThanhToan @MASAN = 'S701', @MAKH = 'KH001', @GIOBD = 20, @GIOKT = 23;



------------Thủ tục sửa giờ bắt đầu, giờ kết thúc
CREATE PROCEDURE CapNhatThanhToan
    @MATHANHTOAN NVARCHAR(40),
    @MAKHMOI NVARCHAR(15),
    @GIOBD INT,
    @GIOKT INT
AS
BEGIN
    -- Kiểm tra xem MATHANHTOAN có tồn tại trong THANHTOAN hay không
    IF EXISTS (SELECT 1 FROM THANHTOAN WHERE MATHANHTOAN = @MATHANHTOAN)
    BEGIN
        -- Thực hiện cập nhật giờ bắt đầu, giờ kết thúc và mã khách hàng mới
        UPDATE THANHTOAN
        SET MAKH = @MAKHMOI, GIOBD = @GIOBD, GIOKT = @GIOKT
        WHERE MATHANHTOAN = @MATHANHTOAN;

        -- Cập nhật trạng thái của chi tiết thanh toán nếu cần
        UPDATE CHITIET_THANHTOAN
        SET MAKH = @MAKHMOI
        WHERE MATHANHTOAN = @MATHANHTOAN;
    END
    ELSE
    BEGIN
        -- Nếu không tìm thấy MATHANHTOAN, thông báo lỗi
        THROW 50000, 'Không tìm thấy thông tin thanh toán phù hợp.', 1;
    END
END;
GO

DROP PROCEDURE CapNhatThanhToan;

EXEC CapNhatThanhToan @MATHANHTOAN = 'B05697BD-15A5-4B8D-8233-2505A7F716C0', @MAKHMOI = 'KH002', @GIOBD = 15, @GIOKT = 19;



------------Thủ tục thanh toán

CREATE PROCEDURE pr_ThanhToan
    @MATHANHTOAN NVARCHAR(40)
AS
BEGIN
    DECLARE @GIOBD INT, @GIOKT INT, @TIENTHUE MONEY, @SOTIEN MONEY, @MASAN NVARCHAR(15);

    -- Lấy thông tin giờ bắt đầu, giờ kết thúc và mã sân từ bảng THANHTOAN
    SELECT @GIOBD = GIOBD, @GIOKT = GIOKT, @MASAN = MASAN FROM THANHTOAN
    WHERE MATHANHTOAN = @MATHANHTOAN;

    -- Lấy tiền thuê từ bảng SAN dựa trên MASAN
    SELECT @TIENTHUE = TIENTHUE FROM SAN WHERE MASAN = @MASAN;

    -- Tính toán số tiền cần thanh toán
    SET @SOTIEN = (@GIOKT - @GIOBD) * @TIENTHUE;

    -- Cập nhật trạng thái và thông tin thanh toán trong bảng CHITIET_THANHTOAN
    UPDATE CHITIET_THANHTOAN
    SET TRANGTHAI = N'Đã thanh toán', NGAYTHANHTOAN = GETDATE(), SOTIENTHANHTOAN = @SOTIEN
    WHERE MATHANHTOAN = @MATHANHTOAN;

END;
GO

EXEC pr_ThanhToan @MATHANHTOAN = 'C4CD638F-F689-4C08-B5DC-8491948E53B9';
go

DROP PROCEDURE pr_ThanhToan

-----------------Thủ tục hiển thị doanh thu
CREATE PROCEDURE HienThiDoanhThu
AS
BEGIN
    SELECT 
        tt.MASAN,
        tt.MAKH,
        (SELECT TENKH FROM KHACHHANG WHERE MAKH = tt.MAKH) AS TENKH,
        tt.MANV,
        tt.NGAYTHUE,
        tt.GIOBD,
        tt.GIOKT,
        (SELECT NGAYTHANHTOAN FROM CHITIET_THANHTOAN WHERE MATHANHTOAN = tt.MATHANHTOAN) AS NGAYTHANHTOAN,
        (SELECT TIENTHUE FROM SAN WHERE MASAN = tt.MASAN) AS TIENTHUE,
        (SELECT SOTIENTHANHTOAN FROM CHITIET_THANHTOAN WHERE MATHANHTOAN = tt.MATHANHTOAN) AS SOTIENTHANHTOAN
    FROM THANHTOAN tt
    WHERE EXISTS (
        SELECT 1 
        FROM CHITIET_THANHTOAN 
        WHERE MATHANHTOAN = tt.MATHANHTOAN 
        AND NGAYTHANHTOAN IS NOT NULL --- đảm bảo chỉ lấy thông tin từ những giao dịch trong THANHTOAN mà 
									------đã có thông tin thanh toán trong CHITIET_THANHTOAN và chắc chắn có NGAYTHANHTOAN để hiện lên thông tin
    )
    ORDER BY tt.NGAYTHUE, tt.GIOBD;
END;
GO

DROP PROCEDURE HienThiDoanhThu

EXEC HienThiDoanhThu
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
-------------------------------------------BÙI TRÍ THỨC-----------------------------------------

-- Cursor 1: Duyệt qua bảng LOAISAN
DECLARE @MALS NVARCHAR(10), @TENLS NVARCHAR(50), @GHICHU NVARCHAR(250)
DECLARE cursor_loaisan CURSOR FOR
SELECT MALS, TENLS, GHICHU FROM LOAISAN
OPEN cursor_loaisan
FETCH NEXT FROM cursor_loaisan INTO @MALS, @TENLS, @GHICHU
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'MALS: ' + @MALS + ', TENLS: ' + @TENLS + ', GHICHU: ' + ISNULL(@GHICHU, '')
    FETCH NEXT FROM cursor_loaisan INTO @MALS, @TENLS, @GHICHU
END

CLOSE cursor_loaisan
DEALLOCATE cursor_loaisan

-- Cursor 2: Duyệt qua bảng SAN
DECLARE @MASAN NVARCHAR(15), @DIACHI NVARCHAR(50), @TIENTHUE MONEY, @MALS NVARCHAR(10), @MANV NVARCHAR(15)
DECLARE cursor_san CURSOR FOR
SELECT MASAN, DIACHI, TIENTHUE, MALS, MANV FROM SAN
OPEN cursor_san
FETCH NEXT FROM cursor_san INTO @MASAN, @DIACHI, @TIENTHUE, @MALS, @MANV
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'MASAN: ' + @MASAN + ', DIACHI: ' + @DIACHI + ', TIENTHUE: ' + CONVERT(NVARCHAR(20), @TIENTHUE) + ', MALS: ' + @MALS + ', MANV: ' + @MANV
    FETCH NEXT FROM cursor_san INTO @MASAN, @DIACHI, @TIENTHUE, @MALS, @MANV
END

CLOSE cursor_san
DEALLOCATE cursor_san

-- Cursor 3: Duyệt qua bảng KHACHHANG
DECLARE @MAKH NVARCHAR(15), @TENKH NVARCHAR(50), @NGSINH DATE, @DIACHI NVARCHAR(50), @DIENTHOAI NVARCHAR(20)
DECLARE cursor_khachhang CURSOR FOR
SELECT MAKH, TENKH, NGSINH, DIACHI, DIENTHOAI FROM KHACHHANG
OPEN cursor_khachhang
FETCH NEXT FROM cursor_khachhang INTO @MAKH, @TENKH, @NGSINH, @DIACHI, @DIENTHOAI
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'MAKH: ' + @MAKH + ', TENKH: ' + @TENKH + ', NGSINH: ' + CONVERT(NVARCHAR(20), @NGSINH) + ', DIACHI: ' + @DIACHI + ', DIENTHOAI: ' + @DIENTHOAI
    FETCH NEXT FROM cursor_khachhang INTO @MAKH, @TENKH, @NGSINH, @DIACHI, @DIENTHOAI
END

CLOSE cursor_khachhang
DEALLOCATE cursor_khachhang
--CURSOR 4 IN THÔNG TIN HÓA ĐƠN TỪ TABLE CHITIET_THANHTOAN
DECLARE @MASAN NVARCHAR(15);
DECLARE @MANV NVARCHAR(15);
DECLARE @MAKH NVARCHAR(15);
DECLARE @NGAYTHUE DATE;
DECLARE @TRANGTHAI NVARCHAR(20);
DECLARE @NGAYTHANHTOAN DATE;
DECLARE @SOTIENTHANHTOAN MONEY;

DECLARE invoiceCursor CURSOR FOR
SELECT MASAN, MANV, MAKH, NGAYTHUE, TRANGTHAI, NGAYTHANHTOAN, SOTIENTHANHTOAN
FROM CHITIET_THANHTOAN;

OPEN invoiceCursor;

FETCH NEXT FROM invoiceCursor INTO @MASAN, @MANV, @MAKH, @NGAYTHUE, @TRANGTHAI, @NGAYTHANHTOAN, @SOTIENTHANHTOAN;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Thực hiện các thao tác với dữ liệu trong cursor ở đây
    -- Ví dụ: In thông tin hóa đơn
    PRINT N'Mã sân: ' + @MASAN;
    PRINT N'Mã nhân viên: ' + @MANV;
    PRINT N'Mã khách hàng: ' + @MAKH;
    PRINT N'Ngày thuê: ' + CONVERT(NVARCHAR(10), @NGAYTHUE, 103);
    PRINT N'Trạng thái: ' + @TRANGTHAI;
    PRINT N'Ngày thanh toán: ' + CONVERT(NVARCHAR(10), @NGAYTHANHTOAN, 103);
    PRINT N'Số tiền thanh toán: ' + CONVERT(NVARCHAR(20), @SOTIENTHANHTOAN, 2);

    FETCH NEXT FROM invoiceCursor INTO @MASAN, @MANV, @MAKH, @NGAYTHUE, @TRANGTHAI, @NGAYTHANHTOAN, @SOTIENTHANHTOAN;
END;

CLOSE invoiceCursor;
DEALLOCATE invoiceCursor;
-- Backup toàn bộ cơ sở dữ liệu QL_SANBONG
BACKUP DATABASE QL_SANBONG
TO DISK = 'C:\Backup\QL_SANBONG.bak'
WITH FORMAT, NAME = 'QL_SANBONG-FullBackup';

-- Backup log giao dịch
BACKUP LOG QL_SANBONG
TO DISK = 'C:\Backup\QL_SANBONG_Log.bak'
WITH FORMAT, NAME = 'QL_SANBONG-LogBackup';
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
------------------------------------------------------------------------------------

-----------------------------------NGUYỄN TRẦN ĐÌNH KHA-----------------------------------------------
--VIẾT TRIGGER KIẾM TRA GIO BẮT ĐẦU PHẢI LỚN  HƠN GIỜ KẾT THUC
CREATE TRIGGER KT_GIODATSAN ON THANHTOAN
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM INSERTED
        WHERE GIOBD >= GIOKT
    )
    BEGIN
        PRINT 'GIO BAT DAU LON HON GIO KET THUC'
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
		PRINT'THEM THANH CONG'
        COMMIT TRANSACTION
    END
END;

SELECT * FROM THANHTOAN;

--VIẾT TRIGGER KIẾM TRA TIỀN THUÊ SÂN PHẢI LỚN HƠN 0
CREATE TRIGGER KT_TIENTHUE ON SAN 
FOR INSERT
AS
	IF(SELECT TIENTHUE FROM INSERTED) > 0
		BEGIN
			PRINT 'THANH CONG'
			COMMIT TRAN
		END
	ELSE 
		BEGIN 
			PRINT 'TIEN THUE PHAI LON HON 0'
			ROLLBACK TRAN
		END
		
INSERT INTO SAN 
VALUES 
	('S505', '142 Lê Trọng Tấn, Tân Phú, TP.HCM', 1, 'S5', 'NV001')

SELECT * FROM SAN

--TRIGGER KIỂM TRA TUỔI CỦA NHÂN VIÊN PHẢI TRÊN 18 
CREATE TRIGGER KT_TUOINV ON NHANVIEN
FOR INSERT
AS
	IF(SELECT YEAR(NGAYSINH) FROM INSERTED) <= 2005
		BEGIN
			PRINT 'HOP LE'
			COMMIT TRAN
		END
	ELSE 
		BEGIN 
			PRINT 'KHONG HOP LE! CHUA DU 18 TUOI'
			ROLLBACK TRAN
		END
INSERT INTO NHANVIEN
VALUES('NV008', N'Lê Nguyễn Minh Thành', '3/7/2002');

SELECT * FROM NHANVIEN



--VIẾT TRIGGER KIẾM TRA SỐ TIỀN THANH TOÁN PHẢI LỚN HƠN 0

CREATE TRIGGER KT_SOTIENTHANHTOAN ON CHITIET_THANHTOAN 
FOR INSERT
AS
	IF(SELECT SOTIENTHANHTOAN FROM INSERTED) > 0
		BEGIN
			PRINT 'THANH CONG'
			COMMIT TRAN
		END
	ELSE 
		BEGIN 
			PRINT 'TIEN THUE PHAI LON HON 0'
			ROLLBACK TRAN
		END

--PHÂN QUYỀN
--TAO RA 2 TAI KHOAN NHANVIEN2 VA NHANVIEN3
USE MASTER
GO 
CREATE LOGIN NV1
	WITH PASSWORD = '123',
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF,
	DEFAULT_DATABASE = QL_SANBONG
GO
USE QL_SANBONG
GO
CREATE USER NV1
	FOR LOGIN NV1


USE MASTER
GO 
CREATE LOGIN NV2
	WITH PASSWORD = '123',
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = OFF,
	DEFAULT_DATABASE = QL_SANBONG
GO
USE QL_SANBONG
GO
CREATE USER NV2
	FOR LOGIN NV2

--CAP QUYEN CHO USER
GRANT SELECT,UPDATE
ON SAN TO NV2
GO

--THU HOI QUYEN INSERT UPDATE CUA USER NHANVIEN2
REVOKE UPDATE
ON SAN
FROM NV2


--TAO RA NHOM QUYEN
SP_ADDROLE NHOM2

GRANT SELECT
ON SAN
TO NHOM2

SP_ADDROLEMEMBER NHOM2, NV1
SP_ADDROLEMEMBER NHOM2, NV2

SP_DROPROLEMEMBER NHOM2, NV2

SP_DROPROLE NHOM2
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
------------------------------------------------------------------------------------

-----------------------------------Phạm Triệu Tuấn-----------------------------------------------
-- 1. Lấy Danh Sách Tất Cả Khách Hàng
CREATE FUNCTION GetAllCustomers()
RETURNS TABLE
AS
RETURN
    SELECT * FROM KHACHHANG;
-- chạy lệnh
select * from GetAllCustomers()

--2.Lấy tổng khách hàng

CREATE FUNCTION GetCustomerCount()
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(*) FROM KHACHHANG;
    RETURN @Count;
END;

-- chạy lệnh
DECLARE @TotalCustomers INT;
SET @TotalCustomers = dbo.GetCustomerCount();
PRINT 'Tổng khách hàng là: ' + CAST(@TotalCustomers AS NVARCHAR);

-- 3.Lấy Danh Sách Thanh Toán Của Một Khách Hàng
CREATE FUNCTION GetPaymentsByCustomer(
    @MAKH NVARCHAR(15)
)
RETURNS TABLE
AS
RETURN
    SELECT * FROM THANHTOAN WHERE MAKH = @MAKH;
-- chạy lệnh
select * from GetPaymentsByCustomer('KH003')

--4. Lấy Danh Sách Sân Bóng Đã Đặt Theo Ngày
CREATE FUNCTION GetBookedPitchesByDate(
    @BookingDate DATE
)
RETURNS TABLE
AS
RETURN
    SELECT P.*
    FROM SAN P
    INNER JOIN THANHTOAN B ON P.MASAN = B.MASAN
    WHERE B.NGAYTHUE = @BookingDate;

-- chạy lệnh
SELECT * FROM dbo.GetBookedPitchesByDate('2023-05-20');

--5.Lấy Tổng Số Lần Thanh Toán Theo Khách Hàng

CREATE FUNCTION GetPaymentCountByCustomer(
    @MAKH NVARCHAR(15)
)
RETURNS INT
AS
BEGIN
    DECLARE @PaymentCount INT;
    SELECT @PaymentCount = COUNT(*) FROM THANHTOAN WHERE MAKH = @MAKH;
    RETURN @PaymentCount;
END;

-- chạy lệnh
DECLARE @PaymentCount INT;
SET @PaymentCount = dbo.GetPaymentCountByCustomer('KH005');
PRINT 'Tổng thành tiền thanh toán của khách hàng này là: ' + CAST(@PaymentCount AS NVARCHAR);