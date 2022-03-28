USE [QLDSV_HTC]
GO
/****** Object:  StoredProcedure [dbo].[SP_ADD_EDIT_DELETE_LOP]    Script Date: 24/11/2021 22:30:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Lay_thong_tin_SV_Theo_Lop] 	
@MALOP nchar(10)
as
select MASV, HO, TEN, PHAI, DIACHI, NGAYSINH, MALOP, DANGHIHOC
FROM  dbo.SINHVIEN where MALOP = @MALOP