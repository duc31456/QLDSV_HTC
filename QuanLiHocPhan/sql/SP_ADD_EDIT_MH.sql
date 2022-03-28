USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_EDIT_MH]    Script Date: 3/11/2022 5:10:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_ADD_EDIT_MH] @MAMH NCHAR(10)=NULL, @TENMH NVARCHAR(50)=NULL, @SOTC int=NULL, @SOTIET int = NULL,@TYPE NVARCHAR(10), @MAMHOLD NCHAR(10)=NULL
as
begin
if @TYPE='Insert' and not exists(select MAMH, TENMH from MONHOC where MAMH = @MAMH and TENMH = @TENMH)
	begin
		insert into MONHOC (MAMH,TENMH, SOTC, SOTIET) values (@MAMH,@TENMH,@SOTC, @SOTIET)
	end
else if @TYPE='Update'
	begin 
		update MONHOC set MAMH=@MAMH, TENMH=@TENMH, SOTC = @SOTC, SOTIET = @SOTIET where MAMH=@MAMHOLD
	end
end
