USE [QuanLyNhaThuoc]
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
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (19, N'staff12321', N'1')
INSERT [dbo].[tblAccount] ([id], [userName], [passWord]) VALUES (20, N'hoangjava ', N'1')
SET IDENTITY_INSERT [dbo].[tblAccount] OFF
SET IDENTITY_INSERT [dbo].[tblright] ON 

INSERT [dbo].[tblright] ([id], [ten]) VALUES (1, N'staff')
INSERT [dbo].[tblright] ([id], [ten]) VALUES (2, N'admin')
SET IDENTITY_INSERT [dbo].[tblright] OFF
SET IDENTITY_INSERT [dbo].[tblnhanvien] ON 

INSERT [dbo].[tblnhanvien] ([id], [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES (1, N'huydz', N'quanly', 0, 13, N'1 le thuoc', N'thanhhuydev77@gmail.com', N'976063210', 2, 1)
INSERT [dbo].[tblnhanvien] ([id], [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES (7, N'ngan', N'nhan vien', 0, 20, N'1 le thuoc', N'nhan@gmail.com', N'967073210', 1, 2)
INSERT [dbo].[tblnhanvien] ([id], [hoten], [chucvu], [gioitinh], [tuoi], [diachi], [email], [SDT], [phanquyen], [userId]) VALUES (9, N'hà minh hoàng', N'quản lý kho', 0, 20, N'ktx', N'hoangbadaojava@gmail.com', N'9889898989', 2, 20)
SET IDENTITY_INSERT [dbo].[tblnhanvien] OFF
SET IDENTITY_INSERT [dbo].[tbldvt] ON 

INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (1, N'Viên')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (2, N'Vỉ')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (3, N'Hộp')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (4, N'Bao')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (5, N'Gói')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (6, N'Lọ')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (7, N'Ống')
INSERT [dbo].[tbldvt] ([id], [ten]) VALUES (8, N'Tuýp')
SET IDENTITY_INSERT [dbo].[tbldvt] OFF
SET IDENTITY_INSERT [dbo].[tblnhomhang] ON 

INSERT [dbo].[tblnhomhang] ([id], [ten]) VALUES (1, N'thuoc')
INSERT [dbo].[tblnhomhang] ([id], [ten]) VALUES (2, N'khac')
SET IDENTITY_INSERT [dbo].[tblnhomhang] OFF
SET IDENTITY_INSERT [dbo].[tblhang] ON 

INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (17, 1, N'Tràng Vị Khang
', N'Tràng Vị Khang giúp kháng khuẩn, chống viêm, chống co thắt, giảm đau, giảm tiết axit dịch vị, chống loét, điều hòa chức năng sinh lý dạ dày – ruột.
', N'Ngưu nhĩ phong,La liễu
', 1, N'vietnam
', 100, 5500.0000, 6500.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (18, 1, N'Hoàn Khơp Bổ Thận
', N'"Tác dụng dưỡng can thận và bồi bổ khí huyết
Giảm đau nhức xương khớp và tê bì chân tay
Nâng cao sức khỏe và tăng cường sức mạnh cơ bắp
Hỗ trợ điều trị các bệnh lý xương khớp thường gặp
Thúc đẩy quá trình phục hồi mô sụn sau chấn thương"
', N'Cao đỗ trọng,Cao độc hoạt,Bột phục linh,Bột bạch thược,Bột đương quy,Than hoạt tính,Mật ong,Cao ngưu tất,Bột phòng phong,Bột hoàng kỳ.
', 2, N'vietnam
', 20, 90000.0000, 100000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (29, 1, N'Loramark', N'Loratadin không có tác dụng an thần, ngược với tác dụng phụ an thần của các thuóoc kháng histamin thế hệ thứ nhất.', N'Loratadine', 1, N'ấn độ', 100, 6300.0000, 7000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (30, 1, N'Telfast BD', N'viêm mũi dị ứng: Telfast HD 180mg được chỉ định để điều trị viêm mũi dị ứng theo mùa ở người lớn và trẻ em từ 12 tuổi trở lên.', N'Fexofenadine hydrochloride', 1, N'mỹ', 50, 7000.0000, 8000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (31, 1, N'Dexamethason 0,5mg', N'Kháng viêm, dùng trong viêm gan mãn tính, viêm cầu thận, viêm mũi dị ứng, viêm xoang, viêm khớp, viêm đa khớp, hen suyễn.', N'Dexamethasone', 6, N'vietnam', 10, 22500.0000, 25000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (32, 2, N'Thực phẩm chức năng làm đẹp da Acnacare', N'Bổ sung các chất chống Oxy hóa, giúp ngăn ngừa, hỗ trợ điều trị mụn và viêm các tuyến bã nhờn trên da, làm đẹp da.', N'Phức hợp Zinc-Methionin, Vitamin C, E, Kẽm, Crom, dầu đậu nành, dầu thực vật….', 3, N'Úc', 10, 75000.0000, 82000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (34, 1, N'Cetirizin 10mg', N'Viêm mũi dị ứng theo mùa, viêm mũi dị ứng quanh năm & mề đay tự phát mạn tính như hắt hơi, sổ mũi, xuất tiết vùng mũi sau, đỏ mắt & chảy nước mắt, ngứa & phát ban.', N'Cetirizine', 2, N'vietnam', 20, 5000.0000, 6000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (35, 2, N'khẩu trang y tế', N'tránh ô nhiễm', N'vải', 3, N'vietnam', 40, 9000.0000, 10000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (36, 2, N'Băng keo y tế Pharmacity', N'Loại băng keo lý tưởng cho da nhạy cảm, chất kết dính ít gây kích ứng, dùng để băng các vết thương sau phẫu thuật, cố định ống truyền dẫn, truyền dịch, kim luồn…', N'"Băng cuộn: Vải lụa
Keo: Acrylic"', 3, N'vietnam', 20, 18000.0000, 23000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (38, 1, N'Siro long đờm Fluidasa', N'Dự phòng và điều trị các biến chứng phát sinh do bệnh cảm lạnh và cúm như:

Viêm mũi hầu, viêm xoang, viêm tái, viêm xuất tiết.', N'acetylcystein và tá dược vừa đủ
', 3, N'peru ', 30, 75000.0000, 81000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (39, 2, N'Khẩu trang lọc bụi, lọc virus Nexcare', N'Lọc được các vi khuẩn (cúm H5N1,…) và bụi siêu mịn với kích thước từ 2.5 micron
', N'"Vải không dệt (2 lớp)
Gọng nẹp nhôm"
', 2, N' Mỹ 
', 220, 35000.0000, 43000.0000)
INSERT [dbo].[tblhang] ([id], [manhom], [ten], [congdung], [thanhphan], [dvt], [xuatxu], [soluong], [gianhap], [giaban]) VALUES (40, 1, N'Tadaritin', N'"Người lớn và thanh thiếu niên (từ 12 tuổi trở lên) để làm giảm các triệu chứng có liên quan tới các bệnh:
Viêm mũi dị ứng theo mùa hoặc mãn tính
Bệnh mày đay"
', N'Desloratadin và Tá dược
', 3, N'Tây Ban Nha 
', 10, 230000.0000, 250000.0000)
SET IDENTITY_INSERT [dbo].[tblhang] OFF
SET IDENTITY_INSERT [dbo].[tblkhachhang] ON 

INSERT [dbo].[tblkhachhang] ([id], [ten], [sdt], [email]) VALUES (4, N'Nguyễn Văn A', N'967897890', N'Aquocdan@gmail.com')
INSERT [dbo].[tblkhachhang] ([id], [ten], [sdt], [email]) VALUES (5, N'Lê Thị B', N'891233212', N'emanhA@gmail.com')
INSERT [dbo].[tblkhachhang] ([id], [ten], [sdt], [email]) VALUES (6, N'Trần Văn C', N'123321234', N'emut@gmail.com')
SET IDENTITY_INSERT [dbo].[tblkhachhang] OFF
SET IDENTITY_INSERT [dbo].[tblhoadonxuat] ON 

INSERT [dbo].[tblhoadonxuat] ([id], [manv], [makh], [ngayxuat], [tongtien]) VALUES (3, 1, 4, CAST(N'2019-12-16T09:44:34.3700000' AS DateTime2), 130000.0000)
SET IDENTITY_INSERT [dbo].[tblhoadonxuat] OFF
SET IDENTITY_INSERT [dbo].[tblcthoadonxuat] ON 

INSERT [dbo].[tblcthoadonxuat] ([id], [mahang], [mahoadon], [dongiaban], [madvt], [soluong]) VALUES (4, 36, 3, 20000, 1, 20)
SET IDENTITY_INSERT [dbo].[tblcthoadonxuat] OFF
SET IDENTITY_INSERT [dbo].[tblnhacungcap] ON 

INSERT [dbo].[tblnhacungcap] ([id], [ten], [sdt], [email], [diachi]) VALUES (4, N'Công ty Cổ phần dược Hậu Giang', N'7103891433', N'pharma@gmail.com', N'288 Bis Nguyễn Văn Cừ, An Hòa, Ninh Kiều, TP. Cần Thơ ')
INSERT [dbo].[tblnhacungcap] ([id], [ten], [sdt], [email], [diachi]) VALUES (5, N'Công ty Cổ phần Dược Phẩm OPC', N'7103891433', N'info@opcpharma.com', N'Số 1017, Hồng Bàng, P.12, Q.6, TP. Hồ Chí Minh ')
INSERT [dbo].[tblnhacungcap] ([id], [ten], [sdt], [email], [diachi]) VALUES (6, N'Công Ty Cổ Phần Dược Liệu Trung Ương 2', N'7103891433', N'info@phytopharma.vn', N'24 Nguyễn Thị Nghĩa, Phường Bến Thành, Quận 01, TP.HCM')
SET IDENTITY_INSERT [dbo].[tblnhacungcap] OFF
SET IDENTITY_INSERT [dbo].[tblhoadonnhap] ON 

INSERT [dbo].[tblhoadonnhap] ([id], [manv], [ngayTiepNhan], [mancc], [tongtien]) VALUES (19, 1, CAST(N'2019-12-16T09:15:28.3400000' AS DateTime2), 5, 1305000.0000)
INSERT [dbo].[tblhoadonnhap] ([id], [manv], [ngayTiepNhan], [mancc], [tongtien]) VALUES (20, 7, CAST(N'2019-12-16T09:42:13.3700000' AS DateTime2), 6, 70200.0000)
INSERT [dbo].[tblhoadonnhap] ([id], [manv], [ngayTiepNhan], [mancc], [tongtien]) VALUES (21, 1, CAST(N'2019-12-16T09:42:13.3700000' AS DateTime2), 4, 600000.0000)
SET IDENTITY_INSERT [dbo].[tblhoadonnhap] OFF
SET IDENTITY_INSERT [dbo].[tblcthoadonnhap] ON 

INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (50, 19, 29, 6300, 100)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (51, 19, 30, 7000, 50)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (52, 19, 31, 22500, 10)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (55, 19, 34, 5000, 20)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (58, 20, 36, 20, 10)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (59, 20, 39, 1000, 10)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (60, 20, 35, 3000, 20)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (61, 21, 38, 20000, 20)
INSERT [dbo].[tblcthoadonnhap] ([id], [mahoadon], [mahang], [dongiaban], [soluong]) VALUES (62, 21, 39, 1000, 200)
SET IDENTITY_INSERT [dbo].[tblcthoadonnhap] OFF
