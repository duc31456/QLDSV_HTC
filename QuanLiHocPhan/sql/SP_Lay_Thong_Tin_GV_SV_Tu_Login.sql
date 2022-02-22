
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Lay_Thong_Tin_GV_SV_Tu_Login]
	-- Add the parameters for the stored procedure here
	@TENLOGIN NVARCHAR(20),
	@TYPE NVARCHAR(20),
	@PASSWORD NVARCHAR(40)
	
AS
declare @UID int
declare @MA nchar(10)

if @TYPE='SV'
begin
	set @MA =@TENLOGIN
	set @TENLOGIN ='SV'
	select @UID=uid FROM sys.sysusers
	where sid=SUSER_SID(@TENLOGIN)
	select MAGV=@MA,
	HOTEN=(select HO+ ' '+TEN from dbo.SINHVIEN where MASV=@MA and PASSWORD=@PASSWORD),
	TENNHOM=NAME
	from sys.sysusers
	where UID= (select groupuid from sys.sysmembers where memberuid=@uid)
end
else
begin
	select @UID=uid,@MA=name FROM sys.sysusers
	where sid=SUSER_SID(@TENLOGIN)
	select MAGV=@MA,
	HOTEN=(select HO+ ' '+TEN from dbo.GIANGVIEN where MAGV=@MA),
	TENNHOM=NAME
	from sys.sysusers
	where UID= (select groupuid from sys.sysmembers where memberuid=@uid)
end
