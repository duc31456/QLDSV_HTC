USE [QLDSV_HTC]
GO

/****** Object:  View [dbo].[Get_DSLop]    Script Date: 24/11/2021 22:36:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[Get_DSLTC]
AS
SELECT [MALTC]
      ,[SOTC]
      ,[NIENKHOA]
      ,[HOCKY]
      ,[MAMH]
      ,[NHOM]
      ,[MAGV]
      ,[SISO]
      ,[TIETBATDAU]
      ,[THOIGIANBATDAU]
      ,[THOIGIANKETTHUC]
      ,[HUYLOP]
  FROM [LOPTINCHI]
GO


