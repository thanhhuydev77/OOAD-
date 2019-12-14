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



---------------------------------------------------------RIGHT---------------------------------------------------------------------------------


/****** Object:  Table [dbo].[tblAccount]    Script Date: 5/31/2019 8:03:11 PM ******/
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




---------------------------------------------------------ACCOUNT---------------------------------------------------------------------------------


/****** Object:  Table [dbo].[tblAccount]    Script Date: 5/31/2019 8:03:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](250) unique NULL,
	[passWord] [varchar](250) NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
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



---------------------------------------------------------HANG ,NHOM HANG---------------------------------------------------------------------------------
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
	[dvt] [bigint] not NULL,
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
ALTER TABLE [dbo].[tblhang]  WITH CHECK ADD  CONSTRAINT [FK_tblthuoc_MaLoai] FOREIGN KEY([manhom])
REFERENCES [dbo].[tblnhomhang] ([id])
GO
   
ALTER TABLE [dbo].[tblhang]  WITH CHECK ADD  CONSTRAINT [FK_tblthuoc_Madvt] FOREIGN KEY([dvt])
REFERENCES [dbo].[tbldvt] ([id])
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


   
--------------------------------------------------------------NHA CUNG CAP---------------------------------------------------------------------------


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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
	[userId] [bigint] not null 
 CONSTRAINT [PK_tblnhanvien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE [dbo].[tblnhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_userid] FOREIGN KEY([userid])
REFERENCES [dbo].[tblAccount] ([id])
GO

ALTER TABLE [dbo].[tblnhanvien]  WITH CHECK ADD  CONSTRAINT [FK_tblhoadonxuat_quyenid] FOREIGN KEY([phanquyen])
REFERENCES [dbo].[tblright] ([id])
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
	[mahoadon] [bigint] NOT NULL,
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

ALTER TABLE [dbo].[tblcthoadonxuat]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonxuat_mahoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblhoadonxuat] ([id])
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

ALTER TABLE [dbo].[tblcthoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonnhap_mahang] FOREIGN KEY([mahang])
REFERENCES [dbo].[tblhang] ([id])
GO

ALTER TABLE [dbo].[tblcthoadonnhap]  WITH CHECK ADD  CONSTRAINT [FK_tblcthoadonnhap_mahoadon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblhoadonnhap] ([id])
GO



--------------------------------------------------------------THAM SO----------------------------------------------------------------------------


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
/****** Object:  Table [dbo].[tblThoiGian]    Script Date: 5/31/2019 8:03:12 PM ******/
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


 SET IDENTITY_INSERT [dbo].[tblhang] off
 SET IDENTITY_INSERT [dbo].[tblnhanvien] off
 SET IDENTITY_INSERT [dbo].[tblAccount] off
 INSERT [dbo].[tbldvt] ([ten]) values ('Viên')
 INSERT [dbo].[tbldvt] ([ten]) values ('Vỉ')
 INSERT [dbo].[tbldvt] ([ten]) values ('Hộp')
 INSERT [dbo].[tbldvt] ([ten]) values ('Bao')
 INSERT [dbo].[tbldvt] ([ten]) values ('Gói')
 insert [dbo].[tblnhomhang] ([ten]) values ('Thuốc')
 insert [dbo].[tblnhomhang] ([ten]) values ('Khác')

 insert [dbo].[tblhang] ([manhom],[ten],[congdung],[thanhphan],[dvt],[xuatxu],[soluong],[gianhap],[giaban]) values (1,'paraxitamon','chua dau dau','axit',3,'vietnam',20,3000,3500)
 
 insert [dbo].[tblhang] ([manhom],[ten],[congdung],[thanhphan],[dvt],[xuatxu],[soluong],[gianhap],[giaban]) values (1,'tiffy','chua cam cum','axit',3,'lao',50,2000,2500)
 
 insert [dbo].[tblhang] ([manhom],[ten],[congdung],[thanhphan],[dvt],[xuatxu],[soluong],[gianhap],[giaban]) values (2,'keo','an cho vui','glucozer',1,'vietnam',200,5000,5500)

 insert [dbo].[tblhang] ([manhom],[ten],[congdung],[thanhphan],[dvt],[xuatxu],[soluong],[gianhap],[giaban]) values (2,'khau trang','deo cho vui','nhua',3,'vietnam',200,1000,1100)
 

INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES ( N'admin', N'1')
INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES (N'staff', N'1')

INSERT [dbo].[tblright] ([ten]) VALUES (N'staff')
INSERT [dbo].[tblright] ([ten]) VALUES (N'admin')

INSERT [dbo].[tblnhanvien] ( [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES ( N'huydz', N'quanly', 1,13, N'1 le thuoc', N'thanhhuydev77@gmail.com','112', 2, 1)
INSERT [dbo].[tblnhanvien] ([hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES ( N'ngandz', N'nhanvien', 0, 19, N'thu duc', N'adidafuck','111', 1, 2)

insert tblnhacungcap ([ten],[sdt],[email],[diachi]) values ('cocacola','0909433332','cocacocola@gmai.com','khuc dung dao,q1')
insert tblnhacungcap ([ten],[sdt],[email],[diachi]) values ('pepsi','090934342','pepsico@gmai.com','le van viet,q1')
insert tblnhacungcap ([ten],[sdt],[email],[diachi]) values ('chanh thanh','043433332','chanhthang@gmai.com','thao dien,q1')

insert tblkhachhang([ten],[sdt],[email]) values ('ha minh hoang','043433332','trumjava@gmai.com')

insert tblkhachhang([ten],[sdt],[email]) values ('phan huynh minh duy','043433332','trum.net@gmai.com')

insert tblkhachhang([ten],[sdt],[email]) values ('nguyen du phuc ngan','04343339932','trumannhau@gmai.com')
--SELECT hoten FROM tblnhanvien a,tblaccount b where a.userid = b.id and b.userName ='admin' 

Select count(id) from tblhang;
