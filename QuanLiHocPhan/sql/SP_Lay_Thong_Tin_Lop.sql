create proc SP_Lay_Thong_Tin_Lop
@MALOP NVARCHAR(10)
as
SELECT * from dbo.LOP where dbo.LOP.MALOP = @MALOP