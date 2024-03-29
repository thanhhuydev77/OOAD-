USE [master]
GO
/****** Object:  Database [QuanLyNhaThuoc]    Script Date: 12/7/2019 1:10:52 AM ******/
CREATE DATABASE [QuanLyNhaThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhaThuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyNhaThuoc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNhaThuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyNhaThuoc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
USE [QuanLyNhaThuoc]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 12/7/2019 1:10:53 AM ******/
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
/****** Object:  Table [dbo].[tblcthoadonnhap]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcthoadonnhap](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[mahoadon] [bigint] NOT NULL,
	[mahang] [bigint] NOT NULL,
	[dongiaban] [int] NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tblcthoadonnhap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcthoadonxuat]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcthoadonxuat](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[mahang] [bigint] NOT NULL,
	[mahoadon] [bigint] NOT NULL,
	[dongiaban] [int] NULL,
	[madvt] [bigint] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tblcthoadonxuat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbldvt]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbldvt](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](200) NULL,
 CONSTRAINT [PK_tbldvt ] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblhang]    Script Date: 12/7/2019 1:10:53 AM ******/
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
	[dvt] [bigint] NOT NULL,
	[xuatxu] [nvarchar](250) NULL,
	[soluong] [int] NULL,
	[gianhap] [money] NULL,
	[giaban] [money] NULL,
 CONSTRAINT [PK_tblhang] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblhoadonnhap]    Script Date: 12/7/2019 1:10:53 AM ******/
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
/****** Object:  Table [dbo].[tblhoadonxuat]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblhoadonxuat](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[manv] [bigint] NOT NULL,
	[makh] [bigint] NULL,
	[ngayxuat] [datetime2](7) NULL,
	[tongtien] [money] NULL,
 CONSTRAINT [PK_tblhoadonxuat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblkhachhang]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  Table [dbo].[tblnhacungcap]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblnhacungcap](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NULL,
	[sdt] [nvarchar](250) NULL,
	[email] [nvarchar](250) NULL,
	[diachi] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblnhacungcap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblnhanvien]    Script Date: 12/7/2019 1:10:53 AM ******/
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
	[userId] [bigint] NOT NULL,
 CONSTRAINT [PK_tblnhanvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblnhomhang]    Script Date: 12/7/2019 1:10:53 AM ******/
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
/****** Object:  Table [dbo].[tblright]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblright](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [varchar](250) NULL,
 CONSTRAINT [PK_tblright] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblthamSo]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblthamSo](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[ts1] [int] NULL,
	[ts2] [int] NULL,
	[ts3] [int] NULL,
	[ts4] [int] NULL,
 CONSTRAINT [PK_tblThamSo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAccount] ON 

INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (1, N'admin', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (2, N'staff', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (11, N'admin10', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (12, N'admin2', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (13, N'admin11', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (15, N'add1', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (16, N'admin111', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (17, N'huydz123', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (18, N'asd1', N'1')
SET IDENTITY_INSERT [dbo].[tblAccount] OFF
SET IDENTITY_INSERT [dbo].[tbldvt] ON 

INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (1, N'Viên')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (2, N'Vỉ')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (3, N'Hộp')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (4, N'Bao')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (5, N'Gói')
SET IDENTITY_INSERT [dbo].[tbldvt] OFF
SET IDENTITY_INSERT [dbo].[tblhang] ON 

INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (1, 1, N'paraxitamon', N'chua dau dau', N'axit', 2, N'vietnam', 20, 3000.0000, 3500.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (2, 1, N'tiffy', N'chua cam cum', N'axit', 3, N'lao', 20, 2000.0000, 2500.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (3, 2, N'Kẹo', N'an cho vui', N'glucozer', 3, N'vietnam', 21, 5000.0000, 5500.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (4, 2, N'rocket 1 tuan', N'vui', N'enzim', 3, N'vietnam', 100, 30000.0000, 35000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (5, 2, N'Khẩu trang', N'deo cho vui', N'nhua', 3, N'vietnam', 200, 1000.0000, 1100.0000)
SET IDENTITY_INSERT [dbo].[tblhang] OFF
SET IDENTITY_INSERT [dbo].[tblnhanvien] ON 

INSERT [dbo].[tblnhanvien] ([id], [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES (1, N'huydz', N'quanly', 0, 13, N'1 le thuoc', N'thanhhuydev77@gmail.com', N'976063210', 2, 1)
INSERT [dbo].[tblnhanvien] ([id], [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES (7, N'ngan', N'nhan vien', 0, 20, N'1 le thuoc', N'nhan@gmail.com', N'967073210', 1, 17)
SET IDENTITY_INSERT [dbo].[tblnhanvien] OFF
SET IDENTITY_INSERT [dbo].[tblnhomhang] ON 

INSERT [dbo].[tblnhomhang] ([id], [ten]) VALUES (1, N'thuoc')
INSERT [dbo].[tblnhomhang] ([id], [ten]) VALUES (2, N'khac')
INSERT [dbo].[tblnhomhang] ([id], [ten]) VALUES (3, N'thuc pham chuc nang ')
SET IDENTITY_INSERT [dbo].[tblnhomhang] OFF
SET IDENTITY_INSERT [dbo].[tblright] ON 

INSERT [dbo].[tblright] ([id], [ten]) VALUES (1, N'staff')
INSERT [dbo].[tblright] ([id], [ten]) VALUES (2, N'admin')
SET IDENTITY_INSERT [dbo].[tblright] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tblAccou__66DCF95C40C3E8EA]    Script Date: 12/7/2019 1:10:53 AM ******/
ALTER TABLE [dbo].[tblAccount] ADD UNIQUE NONCLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblcthoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonnhap_mahang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tblhang] ([id])
GO
ALTER TABLE [dbo].[tblcthoadonnhap] CHECK CONSTRAINT [FK_tblcthoadonnhap_mahang]
GO
ALTER TABLE [dbo].[tblcthoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonnhap_mahoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblhoadonnhap] ([id])
GO
ALTER TABLE [dbo].[tblcthoadonnhap] CHECK CONSTRAINT [FK_tblcthoadonnhap_mahoadon]
GO
ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_madvt] FOREIGN KEY([madvt])
REFERENCES [dbo].[tbldvt] ([id])
GO
ALTER TABLE [dbo].[tblcthoadonxuat] CHECK CONSTRAINT [FK_tblcthoadonxuat_madvt]
GO
ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_mahang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tblhang] ([id])
GO
ALTER TABLE [dbo].[tblcthoadonxuat] CHECK CONSTRAINT [FK_tblcthoadonxuat_mahang]
GO
ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_mahoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblhoadonxuat] ([id])
GO
ALTER TABLE [dbo].[tblcthoadonxuat] CHECK CONSTRAINT [FK_tblcthoadonxuat_mahoadon]
GO
ALTER TABLE [dbo].[tblhang]  WITH CHECK ADD  CONSTRAINT [FK_tblthuoc_Madvt] FOREIGN KEY([dvt])
REFERENCES [dbo].[tbldvt] ([id])
GO
ALTER TABLE [dbo].[tblhang] CHECK CONSTRAINT [FK_tblthuoc_Madvt]
GO
ALTER TABLE [dbo].[tblhang]  WITH CHECK ADD  CONSTRAINT [FK_tblthuoc_MaLoai] FOREIGN KEY([manhom])
REFERENCES [dbo].[tblnhomhang] ([id])
GO
ALTER TABLE [dbo].[tblhang] CHECK CONSTRAINT [FK_tblthuoc_MaLoai]
GO
ALTER TABLE [dbo].[tblhoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonnhap_mancc] FOREIGN KEY([mancc])
REFERENCES [dbo].[tblnhacungcap] ([id])
GO
ALTER TABLE [dbo].[tblhoadonnhap] CHECK CONSTRAINT [FK_tblhoadonnhap_mancc]
GO
ALTER TABLE [dbo].[tblhoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonnhap_manv] FOREIGN KEY([manv])
REFERENCES [dbo].[tblnhanvien] ([id])
GO
ALTER TABLE [dbo].[tblhoadonnhap] CHECK CONSTRAINT [FK_tblhoadonnhap_manv]
GO
ALTER TABLE [dbo].[tblhoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_makh] FOREIGN KEY([makh])
REFERENCES [dbo].[tblkhachhang] ([id])
GO
ALTER TABLE [dbo].[tblhoadonxuat] CHECK CONSTRAINT [FK_tblhoadonxuat_makh]
GO
ALTER TABLE [dbo].[tblhoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_manv] FOREIGN KEY([manv])
REFERENCES [dbo].[tblnhanvien] ([id])
GO
ALTER TABLE [dbo].[tblhoadonxuat] CHECK CONSTRAINT [FK_tblhoadonxuat_manv]
GO
ALTER TABLE [dbo].[tblnhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_quyenid] FOREIGN KEY([phanquyen])
REFERENCES [dbo].[tblright] ([id])
GO
ALTER TABLE [dbo].[tblnhanvien] CHECK CONSTRAINT [FK_tblhoadonxuat_quyenid]
GO
ALTER TABLE [dbo].[tblnhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_userid] FOREIGN KEY([userId])
REFERENCES [dbo].[tblAccount] ([id])
GO
ALTER TABLE [dbo].[tblnhanvien] CHECK CONSTRAINT [FK_tblhoadonxuat_userid]
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 12/7/2019 1:10:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

create proc [dbo].[CheckLogin]
(
	@username varchar(250),
	@password varchar(250)	
)
as
begin
	select * from tblAccount where @username = userName and @password = [passWord]
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhaThuoc] SET  READ_WRITE 
GO
select a.id,a.mahoadon,a.mahang,b.ten,a.dongiaban,a.soluong from tblcthoadonnhap a , tblhang b  where a.mahang = b.id and a.mahoadon = 1
update tblhang
set soluong = soluong+5
where id = 1