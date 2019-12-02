USE [master]
GO
/****** Object:  Database [QuanLyNhaThuoc]    Script Date: 5/31/2019 8:03:11 PM ******/
CREATE DATABASE [QuanLyNhaThuoc]

ALTER DATABASE [QuanLyNhaThuoc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhaThuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhaThuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNhaThuoc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNhaThuoc', N'ON'
GO
ALTER DATABASE [QuanLyNhaThuoc] SET QUERY_STORE = OFF
GO
USE [QuanLyNhaThuoc]
GO





---------------------------------------------------------ACCOUNT---------------------------------------------------------------------------------


/****** Object:  Table [dbo].[tblAccount]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](250) NULL,
	[passWord] [varchar](250) NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO





---------------------------------------------------------THUOC ,NHOM THUOC---------------------------------------------------------------------------------
/****** Object:  Table [dbo].[tblnhomhang]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblnhomhang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblnhomhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblhang]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblhang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[manhom] [bigint] NULL,
	[ten] [nvarchar](250) NULL,
	[congdung] [nvarchar](250) NULL,
	[thanhphan] [nvarchar](250) NULL,
	[dvt] [nvarchar](250) NULL,
	[xuatxu] [nvarchar](250) NULL,
	[soluong] [int] NULL,
	[giaban] [money] NULL,
 CONSTRAINT [PK_tblhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblhang]  WITH CHECK ADD  CONSTRAINT [FK_tblthuoc_MaLoai] FOREIGN KEY([manhom])
REFERENCES [dbo].[tblnhomhang] ([id])
GO
   
--------------------------------------------------------------KHACH HANG----------------------------------------------------------------------------


CREATE TABLE [dbo].[tblkhachhang](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NULL,
	[sdt] [nvarchar](250) NULL,
	[email] [nvarchar](250) NULL,

 CONSTRAINT [PK_tblkhachhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


   
--------------------------------------------------------------KHACH HNHA CUNG CAP---------------------------------------------------------------------------


CREATE TABLE [dbo].[tblnhacungcap](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NULL,
	[sdt] [nvarchar](250) NULL,
	[email] [nvarchar](250) NULL,

 CONSTRAINT [PK_tblnhacungcap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------------------------------------------------------------DVT--------------------------------------------------------------------------

/****** Object:  Table [dbo].[tblcthoadonnhap]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbldvt](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](200) NULL,
 CONSTRAINT [PK_tbldvt ]PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


---------------------------------------------------------NHAN VIEN ---------------------------------------------------------------------------------


/****** Object:  Table [dbo].[tblnhanvien]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblnhanvien](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](250) NULL,
	[chucvu] [nvarchar](250) NULL,
	[gioitinh] [bit] NULL,
	[tuoi] [int] NULL,
	[diachi] [nvarchar](250) NULL,
	[email] [nvarchar](250) NULL,
	[SDT] [nvarchar](250) NULL,
	[phanquyen] [int] NULL,
 CONSTRAINT [PK_tblnhanvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




---------------------------------------------------------HOA DON ---------------------------------------------------------------------------------



/****** Object:  Table [dbo].[tblhoadonxuat]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblhoadonxuat](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[manv] [bigint] NOT NULL,
	[makh] [bigint] null,
	[ngayxuat] [datetime2](7) NULL,
	[tongtien] [money] NULL,
 CONSTRAINT [PK_tblhoadonxuat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblhoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_manv] FOREIGN KEY([manv])
REFERENCES [dbo].[tblnhanvien] ([id])
GO
ALTER TABLE [dbo].[tblhoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_makh] FOREIGN KEY([makh])
REFERENCES [dbo].[tblkhachhang] ([id])
/****** Object:  Table [dbo].[tblcthoadonxuat]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcthoadonxuat](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[mahang] [bigint] NOT NULL,
	[dongiaban] [int]  NULL,
	[madvt]   [bigint] null,
	[soluong] [int]  NULL,

 CONSTRAINT [PK_tblcthoadonxuat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_mahang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tblhang] ([id])
GO

ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_madvt] FOREIGN KEY([madvt])
REFERENCES [dbo].[tbldvt] ([id])
GO
/****** Object:  Table [dbo].[tblhoadonnhap]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblhoadonnhap](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[manv] [bigint] NOT NULL,
	[ngayTiepNhan] [datetime2](7) NULL,
	[mancc] [bigint] NOT NULL,	
	[tongtien] [money] NULL,
 CONSTRAINT [PK_tblhoadonnhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblhoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonnhap_manv] FOREIGN KEY([manv])
REFERENCES [dbo].[tblnhanvien] ([id])
GO

ALTER TABLE [dbo].[tblhoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonnhap_mancc] FOREIGN KEY([mancc])
REFERENCES [dbo].[tblnhacungcap] ([id])
GO

/****** Object:  Table [dbo].[tblcthoadonnhap]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcthoadonnhap](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[mahang] [bigint] NOT NULL,
	[dongiaban] [int] NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tblcthoadonnhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblcthoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonnhap_mahang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tblhang] ([id])
GO



--------------------------------------------------------------THAM SO----------------------------------------------------------------------------


CREATE TABLE [dbo].[tblthamSo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[soDVT] [int] NULL,
 CONSTRAINT [PK_tblThamSo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThoiGian]    Script Date: 5/31/2019 8:03:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


 SET IDENTITY_INSERT [dbo].[tblAccount] ON

INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (1, N'admin', N'1')


