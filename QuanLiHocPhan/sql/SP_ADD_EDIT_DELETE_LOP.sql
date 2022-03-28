USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_EDIT_DELETE_LOP]    Script Date: 3/11/2022 1:41:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[SP_ADD_EDIT_DELETE_LOP] @MALOP NVARCHAR(10)=NULL, @TENLOP NVARCHAR(50)=NULL, @KHOAHOC NVARCHAR(9)=NULL, @TYPE NVARCHAR(10), @MALOPOLD NVARCHAR(10)=NULL
as
begin
if @TYPE='Insert'
	begin
		insert into LOP (MALOP,TENLOP,KHOAHOC) values (@MALOP,@TENLOP,@KHOAHOC)
	end
else if @TYPE='Update'
	begin 
		update LOP set MALOP=@MALOP, TENLOP=@TENLOP, KHOAHOC=@KHOAHOC where MALOP=@MALOPOLD
	end
else if @TYPE='Delete'
	begin
		delete from LOP where MALOP=@MALOP
	end
end
