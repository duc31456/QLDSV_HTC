USE [master]
GO
/****** Object:  Database [QLDSV_HTC]    Script Date: 5/19/2022 9:50:22 PM ******/
CREATE DATABASE [QLDSV_HTC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV_HTC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLDSV_HTC.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_HTC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLDSV_HTC_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDSV_HTC] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV_HTC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV_HTC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLDSV_HTC] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV_HTC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV_HTC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV_HTC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLDSV_HTC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV_HTC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLDSV_HTC] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV_HTC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV_HTC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV_HTC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV_HTC] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLDSV_HTC]
GO
/****** Object:  DatabaseRole [SV]    Script Date: 5/19/2022 9:50:22 PM ******/
CREATE ROLE [SV]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 5/19/2022 9:50:22 PM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [GV]    Script Date: 5/19/2022 9:50:22 PM ******/
CREATE ROLE [GV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [SV]
GO
ALTER ROLE [db_owner] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV]
GO
/****** Object:  StoredProcedure [dbo].[LoadFormDangKyThucHanh]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadFormDangKyThucHanh]
	@nienkhoa nchar(9), @hocky int, 
	@maltc nvarchar(50)
as
	Select dbo.CT_LTC.MALTC, TENMH,dbo.CT_LTC.IDNHOM, SISO, COUNT(dbo.DSSV_LTC.MASV) as SOSVDANGKY,DATENAME(WEEKDAY,THOIGIANBATDAU) as THU,TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG
	from dbo.CT_LTC left join dbo.DSSV_LTC on dbo.DSSV_LTC.MALTC = dbo.CT_LTC.MALTC AND dbo.DSSV_LTC.IDNHOM = dbo.CT_LTC.IDNHOM
	,dbo.LICHHOC_LTC,dbo.MONHOC, dbo.LTC where dbo.CT_LTC.MALTC = dbo.LICHHOC_LTC.MALTC 
	AND dbo.CT_LTC.IDNHOM = dbo.LICHHOC_LTC.IDNHOM
	AND dbo.LTC.MAMH = dbo.MONHOC.MAMH
	AND dbo.CT_LTC.MALTC = dbo.CT_LTC.MALTC
	AND dbo.LTC.MALTC = dbo.LICHHOC_LTC.MALTC
	AND dbo.CT_LTC.NIENKHOA = @nienkhoa
	AND dbo.CT_LTC.HOCKY = @hocky
	AND dbo.CT_LTC.MALTC = @maltc
	AND dbo.CT_LTC.IDNHOM > 0
	GROUP BY dbo.CT_LTC.MALTC, TENMH, dbo.CT_LTC.IDNHOM, SOTC, MALOP, SISO, 
	DATENAME(WEEKDAY,THOIGIANBATDAU), TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG 

GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ADD_EDIT_DELETE_QuanLyLTC]
	@maltc nvarchar(50), @chuthich nvarchar(30), @nienkhoa nchar(9), 
	@hocky int, @malop nchar(20), @siso int, @sotc int, @tenmh nvarchar(50), @type nvarchar(10)
as
DECLARE 
	@idnhom int, @mamh nchar(10)
			SET @idnhom =
            (
                SELECt IDNHOM FROM NHOM_LTC where CHUTHICH = @chuthich
            );
			SET @mamh =
            (
                SELECt MAMH FROM MONHOC where TENMH = @tenmh
            );
if(@type = 'ADD')
	BEGIN
		if not exists(select MALTC, IDNHOM, NIENKHOA, HOCKY from dbo.CT_LTC where MALTC = @maltc 
		and IDNHOM = 0)
			BEGIN
				if(@idnhom = 0)
					BEGIN
						INSERT INTO dbo.CT_LTC(MALTC,IDNHOM, NIENKHOA, HOCKY, MALOP, SISO) VALUES 
						(@maltc, @idnhom, @nienkhoa, @hocky, @malop, @siso)		
						INSERT INTO dbo.LTC(MALTC, MAMH) values (@maltc, @mamh)
						return 0 --Thêm lớp lý thuyết thành công
					END
				else
					BEGIN
						return -1 --Bạn nên tạo lóp lý thuyết trước khi tạo lớp thực hành
					END
			END
		else
			BEGIN
				if(@idnhom = 0)
					BEGIN
						return -2 -- Đã tồn tại Lớp lý thuyết của MALTC này!
					END
				else
					BEGIN
						if exists(select SOTC_TH from dbo.MONHOC where MAMH = @mamh and SOTC_TH > 0)
							BEGIN
								INSERT INTO dbo.CT_LTC(MALTC,IDNHOM, NIENKHOA, HOCKY, MALOP, SISO) VALUES 
								(@maltc, @idnhom, @nienkhoa, @hocky, @malop, @siso)	
									return 1 -- thêm lớp thực hành thành công
							END
						else
							BEGIN
								return -3 -- Môn này không có tiết thực hành
							END
					END
			END
	END
else if(@type = 'EDIT')
	BEGIN
		UPDATE dbo.CT_LTC SET NIENKHOA = @nienkhoa, HOCKY = @hocky,
		MALOP = @malop, SISO = @siso WHERE MALTC = @maltc AND IDNHOM = @idnhom
		UPDATE dbo.LTC SET MAMH = @mamh WHERE MALTC = @maltc
		return 0 -- CHỉnh sửa thành công
	END
else if(@type = 'DELETE')
	BEGIN
		DELETE from dbo.CT_LTC where MALTC = @maltc
		DELETE from dbo.LTC where MALTC = @maltc
		return 0 -- Xóa thành công
	END



GO
/****** Object:  StoredProcedure [dbo].[SP_DangKyLTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DangKyLTC]
	@masv nchar(10), @maltc nvarchar(50), @idnhom int, @sosvdangky int,
	@thoigianbatdau date, @tietbatdau int,

	@maltc_th nvarchar(50), @idnhom_th int,@thoigianbatdau_th date, @tietbatdau_th int
as
DECLARE @siso int
	SET @siso =
            (
                SELECt SISO FROM dbo.CT_LTC where MALTC = @maltc and IDNHOM = @idnhom
            );
	if (@sosvdangky >= @siso)
		BEGIN
			return -3 --Số lượng sv đăng ký đã đủ
		END
	ELSE
		BEGIN
		
			if exists(select MASV, THOIGIANBATDAU, 
			 TIETBATDAU from dbo.DSSV_LTC inner join dbo.LICHHOC_LTC 
			on dbo.LICHHOC_LTC.MALTC = dbo.DSSV_LTC.MALTC and dbo.LICHHOC_LTC.IDNHOM = dbo.DSSV_LTC.IDNHOM
			where MASV = @masv
			and THOIGIANBATDAU = @thoigianbatdau  
			and TIETBATDAU = @tietbatdau)
				BEGIN
					return -1 -- Trùng thời gian học lý thuyết với môn khác
				END
			ELSE
				BEGIN
					if exists(select MASV, THOIGIANBATDAU, 
					 TIETBATDAU from dbo.DSSV_LTC inner join dbo.LICHHOC_LTC 
						on dbo.LICHHOC_LTC.MALTC = dbo.DSSV_LTC.MALTC and dbo.LICHHOC_LTC.IDNHOM = dbo.DSSV_LTC.IDNHOM
						where MASV = @masv
						and THOIGIANBATDAU = @thoigianbatdau_th  
						and TIETBATDAU = @tietbatdau_th)
							BEGIN
								return -2 -- Trùng thời gian học thực hành với môn khác
							END
					ELSE
						BEGIN
							if exists(select MALTC, IDNHOM, MASV from dbo.DSSV_LTC 
							where MALTC =@maltc and MASV = @masv and IDNHOM = 1 
							or IDNHOM = 2 or IDNHOM = 3 and IDNHOM = 0)
								BEGIN
									UPDATE dbo.DSSV_LTC
										SET IDNHOM = @idnhom_th
										WHERE MASV = @masv and MALTC = @maltc AND IDNHOM > 0
									return -1 -- Thay đổi lớp thực hành thành công
								END
							ELSE
								BEGIN
									Insert into dbo.DSSV_LTC(MALTC, IDNHOM, MASV) values (@maltc, @idnhom_th, @masv)
									Insert into dbo.DSSV_LTC(MALTC, IDNHOM, MASV) values (@maltc, @idnhom, @masv)
									return 0 -- Đăng ký lớp thành công
								END
									
						END
				END
		END

		
	

GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DangNhap]
	@username nvarchar(10), @password nvarchar(30), @type int
as
	if exists(Select USERNAME, PASSWORD, IDROLE from dbo.TAIKHOAN
	where USERNAME = @username AND PASSWORD = @password AND IDROLE = @type)
		BEGIN
			if(@type = 1) return 1 -- Đăng nhập quyền PGV
			else if(@type = 2) return 2 -- Đăng nhập quyền SV
		END
	ELSE
		return 0 -- đăng nhập thất bại

			
	


GO
/****** Object:  StoredProcedure [dbo].[SP_EDIT_PhanCongLichHoc]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_EDIT_PhanCongLichHoc]
	@nienkhoa nchar(10), @hocky int, @malop nvarchar(20),
	@maltc nvarchar(50), @chuthich nvarchar(30), @thoigianbatdau date, 
	@thoigianketthuc date, @thu int, @tietbatdau int
as
DECLARE 
	@idnhom int
			SET @idnhom =
            (
                SELECt IDNHOM FROM NHOM_LTC where CHUTHICH = @chuthich
            )
	if exists(select NIENKHOA,HOCKY,MALOP,THOIGIANBATDAU, THOIGIANKETTHUC, THU, TIETBATDAU FROM dbo.LICHHOC_LTC, dbo.CT_LTC
	where THOIGIANBATDAU <= @thoigianbatdau AND THOIGIANKETTHUC > @thoigianbatdau
	 AND TIETBATDAU = @tietbatdau AND THU = @thu AND NIENKHOA = @nienkhoa AND HOCKY = @hocky AND MALOP = @malop
	  AND dbo.LICHHOC_LTC.MALTC = dbo.CT_LTC.MALTC
	 AND dbo.LICHHOC_LTC.IDNHOM = dbo.CT_LTC.IDNHOM)
		BEGIN
			return -1 -- Trùng thời gian với môn học khác
		END
	ELSE
		BEGIN
			UPDATE dbo.LICHHOC_LTC
			set THOIGIANBATDAU = @thoigianbatdau, THOIGIANKETTHUC = @thoigianketthuc, THU = @thu,
			 TIETBATDAU = @tietbatdau where MALTC = @maltc and IDNHOM = @idnhom
			 return 0 -- thành công
		END
	

GO
/****** Object:  StoredProcedure [dbo].[SP_EditPhanCongGV]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_EditPhanCongGV]
    @maltc nvarchar(50), @chuthich nvarchar(30), @magv nchar(10),@thoigianbatdau date,
	 @thu int, @tietbatdau int
as
DECLARE 
	@idnhom int
			SET @idnhom =
            (
                SELECt IDNHOM FROM NHOM_LTC where CHUTHICH = @chuthich
            )
	if exists(select THOIGIANBATDAU, THOIGIANKETTHUC, THU, TIETBATDAU, MAGV FROM dbo.LICHHOC_LTC, dbo.GVDAY_LTC 
	where THOIGIANBATDAU <= @thoigianbatdau AND THOIGIANKETTHUC > @thoigianbatdau
	 AND TIETBATDAU = @tietbatdau AND THU = @thu AND MAGV = @magv AND dbo.LICHHOC_LTC.MALTC = dbo.GVDAY_LTC.MALTC
	 AND dbo.LICHHOC_LTC.IDNHOM = dbo.GVDAY_LTC.IDNHOM)
		BEGIN
			return -1 -- Trùng thời gian giảng viên dạy				
		END
	else
		BEGIN
			UPDATE dbo.GVDAY_LTC set MAGV = @magv where MALTC = @maltc and IDNHOM = @idnhom
			return 0 --thành công
		END	
GO
/****** Object:  StoredProcedure [dbo].[SP_EditPhanCongPhongHoc]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_EditPhanCongPhongHoc]
    @maltc nvarchar(50), @chuthich nvarchar(30), @maphong nchar(10),@thoigianbatdau date, 
	@thu int, @tietbatdau int
as
DECLARE 
	@idnhom int
			SET @idnhom =
            (
                SELECt IDNHOM FROM NHOM_LTC where CHUTHICH = @chuthich
            )
	if exists(select THOIGIANBATDAU, THOIGIANKETTHUC, THU, TIETBATDAU, MAPHONG FROM dbo.LICHHOC_LTC
	where THOIGIANBATDAU <= @thoigianbatdau AND THOIGIANKETTHUC > @thoigianbatdau
	 AND TIETBATDAU = @tietbatdau AND THU = @thu AND MAPHONG = @maphong)
		BEGIN
			return -1 -- Phòng này đã được sắp xếp cho lớp khác!				
		END
	else
		BEGIN
			UPDATE dbo.LICHHOC_LTC set MAPHONG = @maphong where MALTC = @maltc and IDNHOM = @idnhom
			return 0 --thành công
		END	
GO
/****** Object:  StoredProcedure [dbo].[SP_HuyDangKyLTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_HuyDangKyLTC]
	@masv nchar(10), @maltc nvarchar(50), @chuthich nvarchar(50)
as
DECLARE @idnhom int
			SET @idnhom =
            (
                SELECt IDNHOM FROM NHOM_LTC where CHUTHICH = @chuthich
            );
	DELETE FROM dbo.DSSV_LTC where MALTC = @maltc and IDNHOM = @idnhom and MASV = @masv

	

GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraNgayDangKi]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_KiemTraNgayDangKi]
	@malop nvarchar(10)
as
	if exists(select dbo.MoDangKy_LTC.KHOAHOC,THOIGIANMO, THOIGIANDONG from dbo.MoDangKy_LTC, dbo.LOP
	where dbo.MoDangKy_LTC.KHOAHOC = dbo.LOP.KHOAHOC 
	and MALOP = @malop
	and GETDATE() >= THOIGIANMO and GETDATE() <= THOIGIANDONG)
		BEGIN
			return 0 --Khóa này đang trong thời gian đăng ký
		END
	ELSE
		BEGIN
			return 1 --Ngoài thời gian đăng ký
		END


GO
/****** Object:  StoredProcedure [dbo].[SP_LayHocKyMoiNhat]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_LayHocKyMoiNhat] @mssv nchar(10)
as
begin
	-- Lấy dữ liệu học kỳ, niên khóa mới nhất mà sinh viên đó đã và đang học
Declare @hocKyMax int, @nienKhoaMax nchar(9);

--Set @mssv = 'N18DCCN028'

Select Distinct svHocLTC.MALTC, HOCKY, NIENKHOA into #ltcSVHoc 
from (Select Distinct MALTC from DSSV_LTC where MASV = @mssv) as svHocLTC
join CT_LTC on CT_LTC.MALTC = svHocLTC.MALTC

Select Distinct HOCKY, NIENKHOA into #NienKhoaSVHoc
from #ltcSVHoc where NIENKHOA =
(Select MAX(CT_LTC.NIENKHOA) as NienKhoaMAX  from CT_LTC join #ltcSVHoc on CT_LTC.MALTC = #ltcSVHoc.MALTC)

select @hocKyMax =  MAX(HOCKY) from #NienKhoaSVHoc
select @nienKhoaMax =  MAX (NIENKHOA) from #NienKhoaSVHoc

select  @hocKyMax as HOCKYMOINHAT, @nienKhoaMax as NIENKHOAMOINHAT

DROP table #ltcSVHoc
DROP table  #NienKhoaSVHoc
end


GO
/****** Object:  StoredProcedure [dbo].[SP_layNgayBD_KT_HocKy]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_layNgayBD_KT_HocKy] @hocKy int, @nienKhoa varchar(9)
as 
begin

-- Lấy ngày bắt đầu, kết thúc học của học kỳ

declare @ngayBatDauHocKy date, @ngayKetThucHocKy date

--set @hocKy = 2
--set @nienKhoa = '2021-2022'

Select THOIGIANBATDAU, THOIGIANKETTHUC into #ThoiGianHocKy from  (SELECT MALTC, IDNHOM from CT_LTC where HOCKY = @hocKy and NIENKHOA = @nienKhoa) as ltc 
join (SELECT MALTC, IDNHOM, THOIGIANBATDAU, THOIGIANKETTHUC FROM LICHHOC_LTC ) as lichHoc
on ltc.MALTC = lichHoc.MALTC and ltc.IDNHOM = lichHoc.IDNHOM

SELECT @ngayBatDauHocKy = MIN (THOIGIANBATDAU) from #ThoiGianHocKy
SELECT @ngayKetThucHocKy = MAX (THOIGIANKETTHUC) from #ThoiGianHocKy

SELECT @ngayBatDauHocKy as NGAYBATDAUHOCKY, @ngayKetThucHocKy as NGAYKETTHUCHOCKY

Drop table #ThoiGianHocKy
end

GO
/****** Object:  StoredProcedure [dbo].[SP_LayThongTinLTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LayThongTinLTC] @mssv NCHAR(10),
        @hocKy    INT,
        @nienKhoa NCHAR(9)
as
begin
 
--SET @mssv = N'N18DCCN028';
--SET @hocKy = 2;
--SET @nienKhoa = N'2021-2022';

SELECT TENMH,
       MAPHONG,
       CHUTHICH       AS NHOMLOP,
       HO + ' ' + TEN AS GIANGVIEN,
       lopTC.MALOP,
       lopTC.SISO,
       THOIGIANBATDAU,
       THOIGIANKETTHUC,  
	   THU, 
	   TIETBATDAU, 
	   @hocKy as HOCKY, 
	   @nienKhoa as NIENKHOA
FROM   (SELECT MALTC,
               IDNHOM
        FROM   dbo.DSSV_LTC
        WHERE
               MASV = @mssv)          AS dssv
JOIN   (SELECT CT_LTC.MALTC,
               IDNHOM,
               SISO,
               MAMH,
               MALOP
        FROM   dbo.LTC
        JOIN   dbo.CT_LTC
            ON CT_LTC.MALTC = LTC.MALTC
        WHERE
               HOCKY = @hocKy
               AND NIENKHOA = @nienKhoa) AS lopTC
    ON lopTC.MALTC = dssv.MALTC
       AND lopTC.IDNHOM = dssv.IDNHOM
JOIN   (SELECT MALTC,
               IDNHOM,
               MAPHONG,
               THOIGIANBATDAU,
               THOIGIANKETTHUC,
			   THU, 
			   TIETBATDAU
        FROM   dbo.LICHHOC_LTC)         AS lichHoc
    ON lichHoc.MALTC = lopTC.MALTC
       AND lichHoc.IDNHOM = lopTC.IDNHOM
JOIN   (SELECT MAMH,
               TENMH
        FROM   dbo.MONHOC)              AS monHoc
    ON monHoc.MAMH = lopTC.MAMH
JOIN   dbo.NHOM_LTC
    ON NHOM_LTC.IDNHOM = lopTC.IDNHOM
JOIN   dbo.GVDAY_LTC
    ON GVDAY_LTC.MALTC = lopTC.MALTC
       AND GVDAY_LTC.IDNHOM = lopTC.IDNHOM
JOIN   (SELECT MAGV,
               HO,
               TEN
        FROM   dbo.GIANGVIEN)           AS gv
    ON gv.MAGV = GVDAY_LTC.MAGV;
end

GO
/****** Object:  StoredProcedure [dbo].[SP_LOAD_LTC_SV_Dang_Ky]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LOAD_LTC_SV_Dang_Ky]
	@masv nchar(10), @nienkhoa nchar(9), @hocky int
as
	select dbo.DSSV_LTC.MALTC, TENMH, CHUTHICH, MALOP
	from dbo.DSSV_LTC, dbo.MONHOC, dbo.CT_LTC, dbo.LTC, dbo.NHOM_LTC
	where dbo.DSSV_LTC.MALTC = dbo.CT_LTC.MALTC
	and dbo.DSSV_LTC.IDNHOM = dbo.CT_LTC.IDNHOM
	and dbo.DSSV_LTC.IDNHOM = dbo.NHOM_LTC.IDNHOM
	and dbo.NHOM_LTC.IDNHOM = dbo.CT_LTC.IDNHOM
	and dbo.DSSV_LTC.MALTC = dbo.LTC.MALTC
	and dbo.CT_LTC.MALTC = dbo.LTC.MALTC
	and dbo.LTC.MAMH = dbo.MONHOC.MAMH
	and MASV = @masv 
	and NIENKHOA = @nienkhoa
	and HOCKY = @hocky
	

GO
/****** Object:  StoredProcedure [dbo].[SP_LoadFormDangKy]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadFormDangKy]
	@nienkhoa nchar(9), @hocky int, @malop nchar(20)
as
	Select dbo.CT_LTC.MALTC, TENMH, dbo.CT_LTC.IDNHOM, SOTC, MALOP, SISO, COUNT(dbo.DSSV_LTC.MASV) as SOSVDANGKY,DATENAME(WEEKDAY,THOIGIANBATDAU) as THU,TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG 
	from dbo.CT_LTC left join dbo.DSSV_LTC on dbo.DSSV_LTC.MALTC = dbo.CT_LTC.MALTC AND dbo.DSSV_LTC.IDNHOM = dbo.CT_LTC.IDNHOM

	,dbo.LICHHOC_LTC,dbo.MONHOC, dbo.LTC where dbo.CT_LTC.MALTC = dbo.LICHHOC_LTC.MALTC 
	AND dbo.CT_LTC.IDNHOM = dbo.LICHHOC_LTC.IDNHOM
	AND dbo.LTC.MAMH = dbo.MONHOC.MAMH
	AND dbo.CT_LTC.MALTC = dbo.CT_LTC.MALTC
	AND dbo.LTC.MALTC = dbo.LICHHOC_LTC.MALTC
	AND dbo.CT_LTC.NIENKHOA = @nienkhoa
	AND dbo.CT_LTC.HOCKY = @hocky
	AND dbo.CT_LTC.MALOP = @malop
	AND dbo.CT_LTC.IDNHOM = 0
	GROUP BY dbo.CT_LTC.MALTC, TENMH, dbo.CT_LTC.IDNHOM, SOTC, MALOP, SISO, 
	DATENAME(WEEKDAY,THOIGIANBATDAU), TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG 
	

GO
/****** Object:  StoredProcedure [dbo].[SP_LoadThongTinPhanCongGiangDay]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadThongTinPhanCongGiangDay]
	@nienKhoa NCHAR(9),
	@hocKy INT,
	@malop nvarchar(20)
as
	Select GVDAY_LTC.MALTC, CHUTHICH, SISO,MAGV, CONVERT(varchar, THOIGIANBATDAU,103) as THOIGIANBATDAU, CONVERT(varchar, THOIGIANKETTHUC,103) as THOIGIANKETTHUC, THU,TIETBATDAU, MAPHONG 
 from dbo.GVDAY_LTC, dbo.LICHHOC_LTC, dbo.NHOM_LTC, dbo.CT_LTC
	where GVDAY_LTC.MALTC = LICHHOC_LTC.MALTC 
	and NHOM_LTC.IDNHOM = GVDAY_LTC.IDNHOM 
	and LICHHOC_LTC.IDNHOM = GVDAY_LTC.IDNHOM
	and CT_LTC.MALTC = GVDAY_LTC.MALTC
	and CT_LTC.IDNHOM = GVDAY_LTC.IDNHOM
	and NIENKHOA = @nienKhoa
	and HOCKY = @hocKy
	and MALOP = @malop
GO
/****** Object:  StoredProcedure [dbo].[SP_MoDangKy]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_MoDangKy]
	@khoahoc nchar(9), @thoigianmo date, @thoigiandong date
as

			if exists(select THOIGIANMO, THOIGIANDONG from dbo.MoDangKy_LTC 
			where (THOIGIANMO <= @thoigianmo and  @thoigianmo <= THOIGIANDONG)
			or (THOIGIANMO <= @thoigiandong and  @thoigiandong <= THOIGIANDONG))
				BEGIN
					return -1 --Trung thời gian đăng ký môn của khóa khác khi thêm
				END
			Else
				BEGIN
					INSERT INTO dbo.MoDangKy_LTC(KHOAHOC, THOIGIANMO, THOIGIANDONG)
					values (@khoahoc, @thoigianmo, @thoigiandong)
					return 0 -- đăng ký lớp thành công
				END

	


GO
/****** Object:  StoredProcedure [dbo].[SP_QuanLyLTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_QuanLyLTC]
as
	Select CT_LTC.MALTC, TENMH, CHUTHICH, SOTC_LT AS SOTC, 
	NIENKHOA, HOCKY, MALOP, SISO from dbo.CT_LTC, dbo.LTC, dbo.NHOM_LTC, dbo.MONHOC

	where CT_LTC.MALTC = LTC.MALTC and 
	NHOM_LTC.IDNHOM = CT_LTC.IDNHOM and 
	LTC.MAMH = MONHOC.MAMH and
	NHOM_LTC.IDNHOM = 0
	union 
	Select CT_LTC.MALTC, TENMH, CHUTHICH, SOTC_TH AS SOTC, 
	NIENKHOA, HOCKY, MALOP, SISO from dbo.CT_LTC, dbo.LTC, dbo.NHOM_LTC, dbo.MONHOC

	where CT_LTC.MALTC = LTC.MALTC and 
	NHOM_LTC.IDNHOM = CT_LTC.IDNHOM and 
	LTC.MAMH = MONHOC.MAMH and
	NHOM_LTC.IDNHOM > 0



GO
/****** Object:  StoredProcedure [dbo].[SP_TimKiemTheoMonHoc]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TimKiemTheoMonHoc]
	@nienkhoa nchar(9), @hocky int, @tenmh nvarchar(50)
as
	Select dbo.CT_LTC.MALTC, TENMH, dbo.CT_LTC.IDNHOM, SOTC, MALOP, SISO, COUNT(dbo.DSSV_LTC.MASV) as SOSVDANGKY,DATENAME(WEEKDAY,THOIGIANBATDAU) as THU,TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG 
	from dbo.CT_LTC left join dbo.DSSV_LTC on dbo.DSSV_LTC.MALTC = dbo.CT_LTC.MALTC AND dbo.DSSV_LTC.IDNHOM = dbo.CT_LTC.IDNHOM

	,dbo.LICHHOC_LTC,dbo.MONHOC, dbo.LTC where dbo.CT_LTC.MALTC = dbo.LICHHOC_LTC.MALTC 
	AND dbo.CT_LTC.IDNHOM = dbo.LICHHOC_LTC.IDNHOM
	AND dbo.LTC.MAMH = dbo.MONHOC.MAMH
	AND dbo.CT_LTC.MALTC = dbo.CT_LTC.MALTC
	AND dbo.LTC.MALTC = dbo.LICHHOC_LTC.MALTC
	AND dbo.CT_LTC.NIENKHOA = @nienkhoa
	AND dbo.CT_LTC.HOCKY = @hocky
	AND dbo.MONHOC.TENMH = @tenmh
	AND dbo.CT_LTC.IDNHOM = 0
	GROUP BY dbo.CT_LTC.MALTC, TENMH, dbo.CT_LTC.IDNHOM, SOTC, MALOP, SISO, 
	DATENAME(WEEKDAY,THOIGIANBATDAU), TIETBATDAU,THOIGIANBATDAU, THOIGIANKETTHUC, MAPHONG

GO
/****** Object:  Table [dbo].[CT_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_LTC](
	[MALTC] [nvarchar](50) NOT NULL,
	[IDNHOM] [int] NOT NULL,
	[NIENKHOA] [nchar](9) NOT NULL,
	[HOCKY] [int] NOT NULL,
	[MALOP] [nchar](20) NOT NULL,
	[SISO] [int] NULL,
 CONSTRAINT [PK_CT_LTC] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[IDNHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSSV_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSSV_LTC](
	[MALTC] [nvarchar](50) NOT NULL,
	[IDNHOM] [int] NOT NULL,
	[MASV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_DSSV_LTC] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[IDNHOM] ASC,
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[MAGV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NULL,
	[TEN] [nvarchar](10) NULL,
	[CHUYENMON] [nvarchar](50) NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GVDAY_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GVDAY_LTC](
	[MALTC] [nvarchar](50) NOT NULL,
	[IDNHOM] [int] NOT NULL,
	[MAGV] [nchar](10) NULL,
 CONSTRAINT [PK_GVDAY_LTC] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[IDNHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOAHOC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOAHOC](
	[KHOAHOC] [nchar](9) NOT NULL,
	[CHUTHICH] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOAHOC] PRIMARY KEY CLUSTERED 
(
	[KHOAHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LICHHOC_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHHOC_LTC](
	[MALTC] [nvarchar](50) NOT NULL,
	[IDNHOM] [int] NOT NULL,
	[THOIGIANBATDAU] [date] NULL,
	[THOIGIANKETTHUC] [date] NULL,
	[THU] [int] NULL,
	[TIETBATDAU] [int] NULL,
	[MAPHONG] [nchar](10) NULL,
 CONSTRAINT [PK_LICHHOC_LTC] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC,
	[IDNHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [nchar](20) NOT NULL,
	[TENLOP] [nvarchar](50) NOT NULL,
	[KHOAHOC] [nchar](9) NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LTC](
	[MALTC] [nvarchar](50) NOT NULL,
	[MAMH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_LTC] PRIMARY KEY CLUSTERED 
(
	[MALTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MoDangKy_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoDangKy_LTC](
	[KHOAHOC] [nchar](9) NOT NULL,
	[THOIGIANMO] [date] NULL,
	[THOIGIANDONG] [date] NULL,
 CONSTRAINT [PK_MoDangKy_LTC] PRIMARY KEY CLUSTERED 
(
	[KHOAHOC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [nchar](10) NOT NULL,
	[TENMH] [nvarchar](50) NOT NULL,
	[SOTC_LT] [int] NULL,
	[SOTC_TH] [int] NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHOM_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOM_LTC](
	[IDNHOM] [int] NOT NULL,
	[CHUTHICH] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_NHOM_LTC] PRIMARY KEY CLUSTERED 
(
	[IDNHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[IDROLE] [int] NOT NULL,
	[CHUTHICH] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[IDROLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGGIAOVU]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGGIAOVU](
	[MAPGV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NULL,
	[TEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGGIAOVU] PRIMARY KEY CLUSTERED 
(
	[MAPGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGHOC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGHOC](
	[MAPHONG] [nchar](10) NOT NULL,
	[TENPHONG] [nvarchar](50) NULL,
	[SUCCHUA] [int] NULL,
 CONSTRAINT [PK__PHONGHOC__CE71B252818099E0] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[HO] [nvarchar](50) NOT NULL,
	[TEN] [nvarchar](10) NOT NULL,
	[PHAI] [nvarchar](10) NOT NULL CONSTRAINT [DF_SINHVIEN_PHAI]  DEFAULT ('false'),
	[DIACHI] [nvarchar](100) NULL,
	[NGAYSINH] [date] NULL,
	[MALOP] [nchar](20) NOT NULL,
	[DANGHIHOC] [bit] NOT NULL CONSTRAINT [DF_SINHVIEN_DANGHIHOC]  DEFAULT ('false'),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[USERNAME] [nchar](10) NOT NULL,
	[PASSWORD] [nvarchar](30) NOT NULL,
	[IDROLE] [int] NOT NULL,
 CONSTRAINT [PK_TAIKHOAN_1] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'BAS1143', 0, N'2021-2022', 2, N'D20CQCN01           ', 80)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'BAS1145', 0, N'2021-2022', 2, N'D20CQCN02           ', 80)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1306', 0, N'2021-2022', 2, N'D19CQCN01           ', 120)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1306', 1, N'2021-2022', 2, N'D19CQCN01           ', 40)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1306', 2, N'2021-2022', 2, N'D19CQCN01           ', 40)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1306', 3, N'2021-2022', 2, N'D19CQCN01           ', 40)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1408', 0, N'2021-2022', 2, N'D18CQCP01           ', 120)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1408', 1, N'2021-2022', 2, N'D18CQCP01           ', 40)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1434', 0, N'2021-2022', 2, N'D18CQCP01           ', 160)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'INT1434', 1, N'2021-2022', 2, N'D18CQCP01           ', 40)
INSERT [dbo].[CT_LTC] ([MALTC], [IDNHOM], [NIENKHOA], [HOCKY], [MALOP], [SISO]) VALUES (N'SDK1329', 0, N'2021-2022', 1, N'D20CQCN01           ', 80)
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'BAS1143', 0, N'N18DCCN001')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'BAS1143', 0, N'N18DCCN002')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'INT1306', 0, N'N18DCCN028')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'INT1306', 2, N'N18DCCN028')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'INT1408', 0, N'N18DCCN028')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'INT1408', 1, N'N18DCCN028')
INSERT [dbo].[DSSV_LTC] ([MALTC], [IDNHOM], [MASV]) VALUES (N'SDK1329', 0, N'N18DCCN028')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV01      ', N'Phan Thanh', N'Liêm', N'Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV02      ', N'Lê Thành', N'Trì', N'Mạng máy tính')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV03      ', N'Huỳnh Trung', N'Trụ', N'Web, Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV04      ', N'Nguyễn Quốc', N'Minh', N'Truyền thông')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV05      ', N'Châu Minh', N'Lâm', N'Xử lý ảnh')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV06      ', N'Nguyễn Hồng', N'Sơn', N'Phần mềm')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV07      ', N'Lưu Nguyễn Kì', N'Thư', N'Cơ sở dữ liệu')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV08      ', N'Huỳnh Lưu Quốc', N' Linh', N'Xử lý đồ họa')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV09      ', N'Phan Hồng	', N'Hải', N'Toán cao cấp')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV10      ', N'Lê Nhị Lãm', N'Thúy', N'Tiếng Anh')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV11      ', N'Nguyễn Thị', N'Hiền', N'Tiếng Anh')
INSERT [dbo].[GIANGVIEN] ([MAGV], [HO], [TEN], [CHUYENMON]) VALUES (N'GV12      ', N'Phan Thanh', N'Hy', N'Mạng máy tính')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'BAS1143', 0, N'GV10      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'BAS1145', 0, N'GV11      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1306', 0, N'GV07      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1306', 1, N'GV07      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1306', 2, N'GV07      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1306', 3, N'GV07      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1408', 0, N'GV12      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1408', 1, N'GV12      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1434', 0, N'GV12      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'INT1434', 1, N'GV01      ')
INSERT [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM], [MAGV]) VALUES (N'SDK1329', 0, N'GV04      ')
INSERT [dbo].[KHOAHOC] ([KHOAHOC], [CHUTHICH]) VALUES (N'2018-2023', N'Khóa đào tạo của các lớp D18')
INSERT [dbo].[KHOAHOC] ([KHOAHOC], [CHUTHICH]) VALUES (N'2019-2024', N'Khóa đào tạo của các lớp D19')
INSERT [dbo].[KHOAHOC] ([KHOAHOC], [CHUTHICH]) VALUES (N'2020-2025', N'Khóa đào tạo của các lớp D20')
INSERT [dbo].[KHOAHOC] ([KHOAHOC], [CHUTHICH]) VALUES (N'2021-2026', N'Khóa đào tạo của các lớp D21')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'BAS1143', 0, CAST(N'2021-12-20' AS Date), CAST(N'2022-03-27' AS Date), 7, 1, N'2D16      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'BAS1145', 0, CAST(N'2021-12-27' AS Date), CAST(N'2022-03-27' AS Date), 3, 1, N'2D26      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1306', 0, CAST(N'2021-12-27' AS Date), CAST(N'2022-04-17' AS Date), 2, 1, N'2A08      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1306', 1, CAST(N'2021-12-27' AS Date), CAST(N'2022-01-23' AS Date), 3, 7, N'2B11      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1306', 2, CAST(N'2021-12-27' AS Date), CAST(N'2022-02-27' AS Date), 4, 1, N'2B12      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1306', 3, CAST(N'2021-12-27' AS Date), CAST(N'2022-01-23' AS Date), 5, 1, N'2B11      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1408', 0, CAST(N'2021-12-27' AS Date), CAST(N'2022-04-24' AS Date), 2, 7, N'2A27      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1408', 1, CAST(N'2022-03-13' AS Date), CAST(N'2022-04-10' AS Date), 3, 7, N'2B11      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1434', 0, CAST(N'2021-12-27' AS Date), CAST(N'2022-04-20' AS Date), 5, 1, N'2A16      ')
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'INT1434', 1, CAST(N'2022-02-28' AS Date), CAST(N'2022-03-28' AS Date), 4, 1, NULL)
INSERT [dbo].[LICHHOC_LTC] ([MALTC], [IDNHOM], [THOIGIANBATDAU], [THOIGIANKETTHUC], [THU], [TIETBATDAU], [MAPHONG]) VALUES (N'SDK1329', 0, CAST(N'2021-08-09' AS Date), CAST(N'2021-12-19' AS Date), 5, 7, N'2A26      ')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D18CQCP01           ', N'Công nghệ phần mềm 2018-1', N'2018-2023')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D18CQCP02           ', N'Công nghệ phần mềm 2018-2', N'2018-2023')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D18CQIS01           ', N'Hệ thống thông tin 2018-1', N'2018-2023')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D18CQIS02           ', N'Hệ thống thông tin 2018-2', N'2021-2026')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D19CQCN01           ', N'Công nghệ thông tin 2019-1', N'2019-2024')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D19CQCN02           ', N'Công nghệ thông tin 2019-2', N'2019-2024')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D20CQCN01           ', N'Công nghệ thông tin 2020-1', N'2020-2025')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D20CQCN02           ', N'Công nghệ thông tin 2020-2', N'2020-2025')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D21CQCN01           ', N'Công nghệ thông tin 2021-1', N'2021-2026')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [KHOAHOC]) VALUES (N'D21CQCN02           ', N'Công nghệ thông tin 2021-2', N'2021-2026')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'BAS1143', N'AV        ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'BAS1145', N'AV        ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'INT1306', N'CTDL      ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'INT1319', N'HDH       ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'INT1362', N'XLA       ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'INT1408', N'MMT       ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'INT1434', N'LTW       ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'SDK1329', N'TLVB      ')
INSERT [dbo].[LTC] ([MALTC], [MAMH]) VALUES (N'SKD1103', N'TLVB      ')
INSERT [dbo].[MoDangKy_LTC] ([KHOAHOC], [THOIGIANMO], [THOIGIANDONG]) VALUES (N'2018-2023', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-20' AS Date))
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'AV        ', N'Anh văn', 3, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'CSDL      ', N'Cơ sở dữ liệu', 2, 1)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'CTDL      ', N'Cấu trúc dữ liệu & Giải thuật', 2, 1)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'HDH       ', N'Hệ điều hành', 2, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'KTDH      ', N'Kỹ thuật đồ họa', 2, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'KTPM      ', N'Kiến trúc phần mềm', 3, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'LTW       ', N'Lập trình Web', 2, 1)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'MMT       ', N'Mạng máy tính', 2, 1)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'TLVB      ', N'Tạo lập văn bản', 1, 0)
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [SOTC_LT], [SOTC_TH]) VALUES (N'XLA       ', N'Xử lý ảnh', 2, 0)
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (0, N'Lớp lý thuyết')
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (1, N'Lớp thực hành 1')
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (2, N'Lớp thực hành 2')
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (3, N'Lớp thực hành 3')
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (4, N'Lớp thực hành 4')
INSERT [dbo].[NHOM_LTC] ([IDNHOM], [CHUTHICH]) VALUES (5, N'Lớp thực hành 5')
INSERT [dbo].[PHANQUYEN] ([IDROLE], [CHUTHICH]) VALUES (1, N'PHONGGIAOVU')
INSERT [dbo].[PHANQUYEN] ([IDROLE], [CHUTHICH]) VALUES (2, N'SINHVIEN')
INSERT [dbo].[PHONGGIAOVU] ([MAPGV], [HO], [TEN]) VALUES (N'PGV01     ', N'Nguyễn Chí ', N'Thành')
INSERT [dbo].[PHONGGIAOVU] ([MAPGV], [HO], [TEN]) VALUES (N'PGV02     ', N'Ngô Xuân', N'Thành')
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A08      ', N'Phòng lý thuyết dãy A', 220)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A14      ', N'Phòng lý thuyết dãy A', 120)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A16      ', N'Phòng lý thuyết dãy A', 220)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A24      ', N'Phòng lý thuyết dãy A', 120)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A26      ', N'Phòng lý thuyết dãy A', 120)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2A27      ', N'Phòng lý thuyết dãy A', 220)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2B11      ', N'Phòng thực hành dãy B', 40)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2B12      ', N'Phòng thực hành dãy B', 40)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2B13      ', N'Phòng thực hành dãy B', 40)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2B14      ', N'Phòng thực hành dãy B', 40)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2B21      ', N'Phòng thực hành dãy B', 40)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2D16      ', N'Phòng lý thuyết dãy D', 120)
INSERT [dbo].[PHONGHOC] ([MAPHONG], [TENPHONG], [SUCCHUA]) VALUES (N'2D26      ', N'Phòng lý thuyết dãy D', 120)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N18DCCN001', N'Lê Văn', N'Long', N'Nữ', N'Thủ Đức', CAST(N'2000-03-07' AS Date), N'D18CQCP02           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N18DCCN002', N'Bá Hữu', N'Tài', N'Nam', N'Thủ Đức', CAST(N'2002-03-07' AS Date), N'D18CQCP02           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N18DCCN028', N'Ngô Trung', N'Dũng', N'Nam', N'Quận 9', CAST(N'2000-05-01' AS Date), N'D18CQCP01           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N19DCCN001', N'Lê Hữu', N'Hùng', N'Nam', N'Thủ Đức', CAST(N'2001-03-07' AS Date), N'D19CQCN02           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N19DCCN028', N'Ngô Văn', N'Dũng', N'Nam', N'Bình Phước', CAST(N'2001-06-09' AS Date), N'D19CQCN01           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N20DCCN010', N'Bá Hùng', N'Sơn', N'Nữ', N'Thủ Đức', CAST(N'2000-03-07' AS Date), N'D20CQCN02           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N21DCCN011', N'Lê Hữu', N'Sơn', N'Nam', N'Thủ Đức', CAST(N'1999-03-07' AS Date), N'D21CQCN02           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N21DCCN031', N'Lê Văn', N'Huy', N'Nữ', N'Thủ Đức', CAST(N'2003-03-07' AS Date), N'D21CQCN01           ', 0)
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [PHAI], [DIACHI], [NGAYSINH], [MALOP], [DANGHIHOC]) VALUES (N'N21DCCN035', N'Lê Văn', N'Cần', N'Nam', N'Thủ Đức', CAST(N'2002-03-07' AS Date), N'D18CQCP02           ', 1)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N18DCCN001', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N18DCCN002', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N18DCCN028', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N19DCCN001', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N19DCCN028', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N20DCCN010', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N21DCCN011', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N21DCCN031', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'N21DCCN035', N'123', 2)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'PGV01     ', N'123', 1)
INSERT [dbo].[TAIKHOAN] ([USERNAME], [PASSWORD], [IDROLE]) VALUES (N'PGV02     ', N'123', 1)
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__TAIKHOAN__B15BE12EC6706607]    Script Date: 5/19/2022 9:50:22 PM ******/
ALTER TABLE [dbo].[TAIKHOAN] ADD UNIQUE NONCLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_LTC]  WITH CHECK ADD  CONSTRAINT [FK_CT_LTC_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[CT_LTC] CHECK CONSTRAINT [FK_CT_LTC_LOP]
GO
ALTER TABLE [dbo].[DSSV_LTC]  WITH CHECK ADD  CONSTRAINT [FK_DSSV_LTC_GVDAY_LTC] FOREIGN KEY([MALTC], [IDNHOM])
REFERENCES [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM])
GO
ALTER TABLE [dbo].[DSSV_LTC] CHECK CONSTRAINT [FK_DSSV_LTC_GVDAY_LTC]
GO
ALTER TABLE [dbo].[DSSV_LTC]  WITH CHECK ADD  CONSTRAINT [FK_DSSV_LTC_LTC] FOREIGN KEY([MALTC])
REFERENCES [dbo].[LTC] ([MALTC])
GO
ALTER TABLE [dbo].[DSSV_LTC] CHECK CONSTRAINT [FK_DSSV_LTC_LTC]
GO
ALTER TABLE [dbo].[DSSV_LTC]  WITH CHECK ADD  CONSTRAINT [FK_DSSV_LTC_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[DSSV_LTC] CHECK CONSTRAINT [FK_DSSV_LTC_SINHVIEN]
GO
ALTER TABLE [dbo].[GVDAY_LTC]  WITH CHECK ADD  CONSTRAINT [FK_GVDAY_LTC_CT_LTC] FOREIGN KEY([MALTC], [IDNHOM])
REFERENCES [dbo].[CT_LTC] ([MALTC], [IDNHOM])
GO
ALTER TABLE [dbo].[GVDAY_LTC] CHECK CONSTRAINT [FK_GVDAY_LTC_CT_LTC]
GO
ALTER TABLE [dbo].[GVDAY_LTC]  WITH CHECK ADD  CONSTRAINT [FK_GVDAY_LTC_GIANGVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIANGVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[GVDAY_LTC] CHECK CONSTRAINT [FK_GVDAY_LTC_GIANGVIEN]
GO
ALTER TABLE [dbo].[GVDAY_LTC]  WITH CHECK ADD  CONSTRAINT [FK_GVDAY_LTC_LTC] FOREIGN KEY([MALTC])
REFERENCES [dbo].[LTC] ([MALTC])
GO
ALTER TABLE [dbo].[GVDAY_LTC] CHECK CONSTRAINT [FK_GVDAY_LTC_LTC]
GO
ALTER TABLE [dbo].[GVDAY_LTC]  WITH CHECK ADD  CONSTRAINT [FK_GVDAY_LTC_NHOM_LTC] FOREIGN KEY([IDNHOM])
REFERENCES [dbo].[NHOM_LTC] ([IDNHOM])
GO
ALTER TABLE [dbo].[GVDAY_LTC] CHECK CONSTRAINT [FK_GVDAY_LTC_NHOM_LTC]
GO
ALTER TABLE [dbo].[LICHHOC_LTC]  WITH CHECK ADD  CONSTRAINT [FK_LICHHOC_LTC_GVDAY_LTC] FOREIGN KEY([MALTC], [IDNHOM])
REFERENCES [dbo].[GVDAY_LTC] ([MALTC], [IDNHOM])
GO
ALTER TABLE [dbo].[LICHHOC_LTC] CHECK CONSTRAINT [FK_LICHHOC_LTC_GVDAY_LTC]
GO
ALTER TABLE [dbo].[LICHHOC_LTC]  WITH CHECK ADD  CONSTRAINT [FK_LICHHOC_LTC_PHONGHOC] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONGHOC] ([MAPHONG])
GO
ALTER TABLE [dbo].[LICHHOC_LTC] CHECK CONSTRAINT [FK_LICHHOC_LTC_PHONGHOC]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOAHOC] FOREIGN KEY([KHOAHOC])
REFERENCES [dbo].[KHOAHOC] ([KHOAHOC])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOAHOC]
GO
ALTER TABLE [dbo].[LTC]  WITH CHECK ADD  CONSTRAINT [FK_LTC_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[LTC] CHECK CONSTRAINT [FK_LTC_MONHOC]
GO
ALTER TABLE [dbo].[MoDangKy_LTC]  WITH CHECK ADD  CONSTRAINT [FK_MoDangKy_LTC_KHOAHOC] FOREIGN KEY([KHOAHOC])
REFERENCES [dbo].[KHOAHOC] ([KHOAHOC])
GO
ALTER TABLE [dbo].[MoDangKy_LTC] CHECK CONSTRAINT [FK_MoDangKy_LTC_KHOAHOC]
GO
ALTER TABLE [dbo].[PHONGGIAOVU]  WITH CHECK ADD  CONSTRAINT [FK_PHONGGIAOVU_TAIKHOAN] FOREIGN KEY([MAPGV])
REFERENCES [dbo].[TAIKHOAN] ([USERNAME])
GO
ALTER TABLE [dbo].[PHONGGIAOVU] CHECK CONSTRAINT [FK_PHONGGIAOVU_TAIKHOAN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_TAIKHOAN] FOREIGN KEY([MASV])
REFERENCES [dbo].[TAIKHOAN] ([USERNAME])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_TAIKHOAN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_PHANQUYEN] FOREIGN KEY([IDROLE])
REFERENCES [dbo].[PHANQUYEN] ([IDROLE])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_PHANQUYEN]
GO
/****** Object:  Trigger [dbo].[ThemGVDAY_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ThemGVDAY_LTC]
ON [dbo].[CT_LTC]
AFTER INSERT
AS
    BEGIN
        DECLARE @maltc nvarchar(50),@idnhom int
       
        SET @maltc =
            (
                SELECt Inserted.MALTC FROM Inserted
            );
			SET @idnhom =
            (
                SELECt Inserted.IDNHOM FROM Inserted
            );
		Insert into dbo.GVDAY_LTC(MALTC, IDNHOM) values
		 (@maltc, @idnhom)
		 Insert into dbo.LICHHOC_LTC(MALTC, IDNHOM, TIETBATDAU) values
		 (@maltc, @idnhom , 0)
		 
    END;


GO
/****** Object:  Trigger [dbo].[XoaGVDAY_LTC]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[XoaGVDAY_LTC]
ON [dbo].[CT_LTC]
AFTER DELETE
AS
    BEGIN
        DECLARE @maltc nvarchar(50),@idnhom int
       
        SET @maltc =
            (
                SELECt Inserted.MALTC FROM Inserted
            );
			SET @idnhom =
            (
                SELECt Inserted.IDNHOM FROM Inserted
            );
		delete from dbo.GVDAY_LTC where MALTC = @maltc and IDNHOM = @idnhom	 
		delete from dbo.LICHHOC_LTC where MALTC = @maltc and IDNHOM = @idnhom	 
    END;


GO
/****** Object:  Trigger [dbo].[ThemTaiKhoanPhongGiaoVu]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ThemTaiKhoanPhongGiaoVu]
ON [dbo].[PHONGGIAOVU]
INSTEAD OF INSERT
AS
    BEGIN
        DECLARE @mapgv nchar(10),@ho nvarchar(50), @ten nvarchar(50)
		
        SET @mapgv =
            (
                SELECt Inserted.MAPGV FROM Inserted
            );
			SET @ho =
            (
                SELECt Inserted.HO FROM Inserted
            );
			SET @ten =
            (
                SELECt Inserted.TEN FROM Inserted
            );
		Insert into dbo.TAIKHOAN(USERNAME, PASSWORD, IDROLE) values
		 (@mapgv, '123', '1')
		 Insert into dbo.PHONGGIAOVU(MAPGV, HO, TEN) values
		 (@mapgv, @ho,@ten)
    END;


GO
/****** Object:  Trigger [dbo].[ThemTaiKhoanSinhVien]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[ThemTaiKhoanSinhVien]
ON [dbo].[SINHVIEN]
INSTEAD OF INSERT
AS
    BEGIN
        DECLARE @masv nchar(10),@ho nvarchar(50), @ten nvarchar(10),
		@phai nvarchar(10),@diachi nvarchar(100),@ngaysinh date,@malop nchar(20), @danghihoc bit
		
            
        SET @masv =
            (
                SELECt Inserted.MASV FROM Inserted
            );
			SET @ho =
            (
                SELECt Inserted.HO FROM Inserted
            );
			SET @ten =
            (
                SELECt Inserted.TEN FROM Inserted
            );
			SET @phai =
            (
                SELECt Inserted.PHAI FROM Inserted
            );
			SET @diachi =
            (
                SELECt Inserted.DIACHI FROM Inserted
            );
			SET @ngaysinh =
            (
                SELECt Inserted.NGAYSINH FROM Inserted
            );
			SET @malop =
            (
                SELECt Inserted.MALOP FROM Inserted
            );
			SET @danghihoc =
            (
                SELECt Inserted.DANGHIHOC FROM Inserted
            );
		Insert into dbo.TAIKHOAN(USERNAME, PASSWORD, IDROLE) values
		 (@masv, '123', '2')
		 Insert into dbo.SINHVIEN(MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, MALOP, DANGHIHOC) values
		 (@masv, @ho,@ten,@phai,@diachi,@ngaysinh,@malop,@danghihoc)
    END;


GO
/****** Object:  Trigger [dbo].[XoaTaiKhoanSinhVien]    Script Date: 5/19/2022 9:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[XoaTaiKhoanSinhVien]
ON [dbo].[SINHVIEN]
INSTEAD OF DELETE
AS
    BEGIN
        DECLARE @masv nchar(10)

        SET @masv =
            (
                SELECT DELETED.MASV FROM deleted
            );
		delete dbo.SINHVIEN where MASV = @masv
		delete from dbo.TAIKHOAN where USERNAME = @masv
    END;


GO
USE [master]
GO
ALTER DATABASE [QLDSV_HTC] SET  READ_WRITE 
GO
