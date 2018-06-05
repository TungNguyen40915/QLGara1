

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLGara')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLGara') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLGara]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLGara]
GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblXe](
	[bienso] [nvarchar](10) NOT NULL,
	[machuxe] [nvarchar](8) NOT NULL,
	[mahieuxe] [int] NOT NULL,
 CONSTRAINT [PK_tblXe] PRIMARY KEY CLUSTERED 
(
	[bienso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE TABLE [dbo].[tblHieuXe](
	[mahieuxe] [int] NOT NULL,
	[tenhieuxe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblHieuXe] PRIMARY KEY CLUSTERED 
(
	[mahieuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChuXe](
	[machuxe] [nvarchar](8) NOT NULL,
	[tenchuxe] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[dienthoai] [int] NOT NULL,
	[tienno] [int] NOT NULL,
 CONSTRAINT [PK_tblChuXe] PRIMARY KEY CLUSTERED 
(
	[machuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTiepNhan](
	[matiepnhan] [nvarchar](8) NOT NULL,
	[bienso] [nvarchar](10) NOT NULL,
	[ngaytiepnhan] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblTiepNhan] PRIMARY KEY CLUSTERED 
(
	[matiepnhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblVatTu](
	[mavattu] [int] NOT NULL,
	[tenvattu] [nvarchar](20) NOT NULL,
	[dongia] [int] NOT NULL,
	[tonkho] [int] NOT NULL,
 CONSTRAINT [PK_tblVatTu] PRIMARY KEY CLUSTERED 
(
	[mavattu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNoiDung](
	[manoidung] [int] NOT NULL,
	[tennoidung] [nvarchar](20) NOT NULL,
	[tiencong] [int] NOT NULL,
 CONSTRAINT [PK_tblNoiDung] PRIMARY KEY CLUSTERED 
(
	[manoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuSuaChua](
	[maphieu] [nvarchar](10) NOT NULL,
	[biensoxe] [nvarchar](10) NOT NULL,
	[ngaysuachua] [datetime2](7) NOT NULL,
	[tongtien] [int] NOT NULL,
 CONSTRAINT [PK_tblPhieuSuaChua] PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTPSC](
	[maphieu] [nvarchar](10) NOT NULL,
	[mavattu] [int] NOT NULL,
	[manoidung] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,
	[tiencong] [int] NOT NULL,
	[thanhtien] [int] NOT NULL,
 CONSTRAINT [PK_tblCTPSC] PRIMARY KEY NONCLUSTERED 
(
	[maphieu] ASC,
	[mavattu] ASC, 
	[manoidung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThu](
	[maphieu] [nvarchar](10) NOT NULL,
	[biensoxe] [nvarchar](10) NOT NULL,
	[ngaythu] [datetime2](7) NOT NULL,
	[sotien] [int] NOT NULL,
 CONSTRAINT [PK_tblPhieuThu] PRIMARY KEY CLUSTERED 
(
	[maphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

INSERT INTO[dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(1,N'Honda')
GO
INSERT INTO[dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(2,N'Ford')
GO
INSERT INTO[dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(3,N'Toyota')
GO
INSERT INTO[dbo].[tblHieuXe]([mahieuxe],[tenhieuxe]) VALUES(4,N'Bosch')
GO


USE [QLGara]
GO

INSERT INTO[dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[tienno]) VALUES('CX000001',N'Nguyễn Bá Tùng',N'TPHCM',01217727895,5000000)
GO
INSERT INTO[dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[tienno]) VALUES('CX000002',N'Nguyễn Đức Tuấn',N'Bảo Lộc',01217727895,0)
GO
INSERT INTO[dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[tienno]) VALUES('CX000003',N'Nguyễn Trần Hoàng Thanh',N'Sóc Trăng',01217727895,0)
GO
INSERT INTO[dbo].[tblChuXe]([machuxe],[tenchuxe],[diachi],[dienthoai],[tienno]) VALUES('CX000004',N'Võ Huỳnh Việt',N'Khánh Hòa',01217727895,0)
GO
USE [QLGara]
GO

INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('59N2-23921',N'CX000001',1)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('62M1-40915',N'CX000001',3)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('66M1-78245',N'CX000001',3)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('59N2-11425',N'CX000002',1)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('59N2-6128',N'CX000002',1)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('62M1-3280',N'CX000003',3)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('71P1-39758',N'CX000003',1)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('72B1-56891',N'CX000001',1)
GO
INSERT INTO[dbo].[tblXe]([bienso],[machuxe],[mahieuxe]) VALUES('81N2-39534',N'CX000003',1)
GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoThang](
	[mabaocao] [nvarchar](8) NOT NULL,
	[thang] [int] NOT NULL,
	[nam] [int] NOT NULL,
	[tongdoanhthu] [int] NOT NULL,
 CONSTRAINT [PK_tblBaoCaoThang] PRIMARY KEY CLUSTERED 
(
	[mabaocao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoVatTu](
	[mabaocao] [nvarchar](8) NOT NULL,
	[thang] [int] NOT NULL,
	[nam] [int] NOT NULL,
	
 CONSTRAINT [PK_tblBaoCaoVatTu] PRIMARY KEY CLUSTERED 
(
	[mabaocao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoVatTu](
	[mabaocao] [nvarchar](8) NOT NULL,
	[mavattu] [int] NOT NULL,
	[tondau] [int] NOT NULL,
	[phatsinh] [int] NOT NULL,
	[toncuoi] [int] NOT NULL,
	
 CONSTRAINT [PK_tblChiTietBaoCaoVatTu] PRIMARY KEY CLUSTERED 
(
	[mabaocao] ASC, [mavattu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNhapVatTu](
	[maphieunhap] [nvarchar](8) NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
	
 CONSTRAINT [PK_tblNhapVatTu] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietNhapVatTu](
	[maphieunhap] [nvarchar](8) NOT NULL,
	[mavattu] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[dongia] [int] NOT NULL,

 CONSTRAINT [PK_tblChiTietNhapVatTu] PRIMARY KEY CLUSTERED 
(
	[maphieunhap] ASC, [mavattu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietBaoCaoThang](
	[mabaocao] [nvarchar](8) NOT NULL,
	[mahieuxe] [int] NOT NULL,
	[soluotsua] [int] NOT NULL,
	[thanhtien] [int] NOT NULL,
	[tyle] [float] NOT NULL,

 CONSTRAINT [PK_tblChiTietBaoCaoThang] PRIMARY KEY CLUSTERED 
(
	[mabaocao] ASC, [mahieuxe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [QLGara]
GO
INSERT INTO[dbo].[tblVatTu]([mavattu],[tenvattu],[dongia],[tonkho]) VALUES(1,N'Lốp Xe Yokohama',150000,10)
GO
INSERT INTO[dbo].[tblVatTu]([mavattu],[tenvattu],[dongia],[tonkho]) VALUES(2,N'Nhớt Castrol Power 1',85000,20)
GO
INSERT INTO[dbo].[tblVatTu]([mavattu],[tenvattu],[dongia],[tonkho]) VALUES(3,N'Kính Chiếu Hậu',45000,21)
GO

USE [QLGara]
GO
INSERT INTO[dbo].[tblNoiDung]([manoidung],[tennoidung],[tiencong]) VALUES(1,N'Thay Lốp Xe',30000)
GO
INSERT INTO[dbo].[tblNoiDung]([manoidung],[tennoidung],[tiencong]) VALUES(2,N'Thay Nhớt',30000)
GO
INSERT INTO[dbo].[tblNoiDung]([manoidung],[tennoidung],[tiencong]) VALUES(3,N'Bơm Bánh Xe',2000)
GO
INSERT INTO[dbo].[tblNoiDung]([manoidung],[tennoidung],[tiencong]) VALUES(4,N'Gắn Kính',0)
GO


USE [QLGara]
GO
INSERT INTO[dbo].[tblPhieuSuaChua]([maphieu],[biensoxe],[ngaysuachua],[tongtien]) VALUES(N'SC18041801',N'62M1-40915',convert(datetime,'04/18/2018 00:00:00',101),180000)
GO
INSERT INTO[dbo].[tblPhieuSuaChua]([maphieu],[biensoxe],[ngaysuachua],[tongtien]) VALUES(N'SC18041802',N'66M1-78245',convert(datetime,'04/18/2018 00:00:00',101),160000)
GO
INSERT INTO[dbo].[tblPhieuSuaChua]([maphieu],[biensoxe],[ngaysuachua],[tongtien]) VALUES(N'SC18050101',N'59N2-23921',convert(datetime,'05/01/2018 00:00:00',101),45000)
GO
INSERT INTO[dbo].[tblPhieuSuaChua]([maphieu],[biensoxe],[ngaysuachua],[tongtien]) VALUES(N'SC18050201',N'71P1-39759',convert(datetime,'05/02/2018 00:00:00',101),150000)
GO
INSERT INTO[dbo].[tblPhieuSuaChua]([maphieu],[biensoxe],[ngaysuachua],[tongtien]) VALUES(N'SC18050202',N'62M1-3280',convert(datetime,'05/02/2018 00:00:00',101),115000)
GO

USE [QLGara]
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18041801',1,1,1,150000,30000,180000)
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18041802',3,4,1,45000,0,45000)
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18041802',2,2,1,85000,30000,115000)
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18050101',3,0,1,45000,0,45000)
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18050201',1,0,1,150000,0,150000)
GO
INSERT INTO[dbo].[tblCTPSC]([maphieu],[mavattu],[manoidung],[soluong],[dongia],[tiencong],[thanhtien]) VALUES(N'SC18050202',2,2,1,85000,30000,115000)
GO



USE [QLGara]
GO
INSERT INTO[dbo].[tblNhapVatTu]([maphieunhap],[ngaynhap]) VALUES('18052001',convert(datetime,'05/20/2018 00:00:00',101))
GO

INSERT INTO[dbo].[tblNhapVatTu]([maphieunhap],[ngaynhap]) VALUES('18053101',convert(datetime,'05/31/2018 00:00:00',101))
GO

USE [QLGara]
GO

INSERT INTO[dbo].[tblChiTietNhapVatTu]([maphieunhap],[mavattu],[soluong],[dongia]) VALUES('18053101',1,10,150000)
GO

INSERT INTO[dbo].[tblChiTietNhapVatTu]([maphieunhap],[mavattu],[soluong],[dongia]) VALUES('18053101',2,15,85000)
GO

INSERT INTO[dbo].[tblChiTietNhapVatTu]([maphieunhap],[mavattu],[soluong],[dongia]) VALUES('18052001',2,15,85000)
GO


USE [QLGara]
GO
INSERT INTO[dbo].[tblBaoCaoVatTu]([mabaocao],[thang],[nam]) VALUES('BC180401',4,2018)
GO
INSERT INTO[dbo].[tblBaoCaoVatTu]([mabaocao],[thang],[nam]) VALUES('BC180501',5,2018)
GO


USE [QLGara]
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES('BC180401',1,20,-1,19)
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES('BC180401',2,20,-1,19)
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES('BC180401',3,20,-1,19)
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES(N'BC180501',1,19,9,28)
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES(N'BC180501',2,19,29,48)
GO
INSERT INTO[dbo].[tblChiTietBaoCaoVatTu]([mabaocao],[mavattu],[tondau],[phatsinh],[toncuoi]) VALUES(N'BC180501',3,19,-1,18)
GO