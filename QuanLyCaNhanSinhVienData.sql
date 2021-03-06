USE [QuanLyCaNhanSinhVien]
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK1', N'Học kỳ 1', N'2014-2015')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK2', N'Học kỳ 2', N'2014-2015')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK3', N'Học kỳ 3', N'2015-2016')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK4', N'Học kỳ 4', N'2015-2016')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK5', N'Học kỳ 5', N'2016-2017')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK6', N'Học kỳ 6', N'2016-2017')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK7', N'Học kỳ 7', N'2017-2018')
GO
INSERT [dbo].[HocKy] ([MaHK], [TenHK], [NamHoc]) VALUES (N'HK8', N'Học kỳ 8', N'2017-2018')
GO
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinhChi], [SoTiet]) VALUES (N'M1', N'Môn 1', 2, 3)
GO
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinhChi], [SoTiet]) VALUES (N'M2', N'Môn 2', 3, 4)
GO
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinhChi], [SoTiet]) VALUES (N'M3', N'Môn 3', 4, 4)
GO
INSERT [dbo].[MonHoc] ([MaMon], [TenMon], [SoTinhChi], [SoTiet]) VALUES (N'M4', N'Môn 4', 3, 4)
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [CacThongTin], [HinhAnh]) VALUES (N'1', N'Tên Sinh Viên Test1', 1, CAST(N'1996-01-01' AS Date), N'Địa chỉ của sinh viên test1', N'Sinh viên đầu tiên có acc gọi là sinh viên test1', 0x)
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [CacThongTin], [HinhAnh]) VALUES (N'2', N'Nguyễn Ha', 0, CAST(N'1996-01-15' AS Date), N'Địa chỉ của Nguyễn Hai', N'THông tin Ngguyeenx Hai', 0x)
GO
INSERT [dbo].[DanhSachMon] ([MaSV], [MaMon], [MaHK]) VALUES (N'1', N'M1', N'HK4')
GO
INSERT [dbo].[DanhSachMon] ([MaSV], [MaMon], [MaHK]) VALUES (N'1', N'M2', N'HK4')
GO
INSERT [dbo].[DanhSachMon] ([MaSV], [MaMon], [MaHK]) VALUES (N'1', N'M3', N'HK4')
GO
INSERT [dbo].[DanhSachMon] ([MaSV], [MaMon], [MaHK]) VALUES (N'2', N'M1', N'HK1')
GO
INSERT [dbo].[DanhSachMon] ([MaSV], [MaMon], [MaHK]) VALUES (N'2', N'M3', N'HK3')
GO
INSERT [dbo].[DiemSo] ([MaSV], [MaMon], [MaHK], [MaDiem], [SoDiem], [HeSo], [NgayDiem]) VALUES (N'1', N'M1', N'HK4', N'Diem0', 10, 10, CAST(N'2016-05-14' AS Date))
GO
INSERT [dbo].[DiemSo] ([MaSV], [MaMon], [MaHK], [MaDiem], [SoDiem], [HeSo], [NgayDiem]) VALUES (N'1', N'M1', N'HK4', N'Diem1', 9.5, 9.5, CAST(N'2016-05-14' AS Date))
GO
INSERT [dbo].[DiemSo] ([MaSV], [MaMon], [MaHK], [MaDiem], [SoDiem], [HeSo], [NgayDiem]) VALUES (N'1', N'M1', N'HK4', N'Diem2', 10, 10, CAST(N'2016-05-14' AS Date))
GO
INSERT [dbo].[DiemSo] ([MaSV], [MaMon], [MaHK], [MaDiem], [SoDiem], [HeSo], [NgayDiem]) VALUES (N'1', N'M2', N'HK4', N'Diem3', 9.9, 9.9, CAST(N'2016-05-14' AS Date))
GO
INSERT [dbo].[DiemSo] ([MaSV], [MaMon], [MaHK], [MaDiem], [SoDiem], [HeSo], [NgayDiem]) VALUES (N'1', N'M3', N'HK4', N'Diem4', 8, 8, CAST(N'2016-05-14' AS Date))
GO
INSERT [dbo].[AccountSinhVien] ([MaSV], [PasswordSV]) VALUES (N'1', N'1')
GO
INSERT [dbo].[AccountSinhVien] ([MaSV], [PasswordSV]) VALUES (N'2', N'2')
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD0', N'M1', 0, CAST(N'2016-05-14 12:58:00.000' AS DateTime), CAST(N'2016-05-31 12:58:00.000' AS DateTime), N'Chuẩn bị ôn thi, cho kỳ thi', 0)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD1', N'M2', 0, CAST(N'2016-05-14 13:00:00.000' AS DateTime), CAST(N'2016-05-31 13:00:00.000' AS DateTime), N'Làm đồ án chuẩn bị nộp', 0)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD10', N'M2', 1, CAST(N'2016-05-14 13:17:03.000' AS DateTime), CAST(N'2016-05-14 13:17:03.000' AS DateTime), N'Thứ 2 học môn 2', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD11', N'M3', 1, CAST(N'2016-05-14 13:18:38.000' AS DateTime), CAST(N'2016-05-14 13:18:38.000' AS DateTime), N'Thứ 3 học môn 3', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD12', N'M1', 1, CAST(N'2016-05-14 13:19:03.000' AS DateTime), CAST(N'2016-05-14 13:19:03.000' AS DateTime), N'Học môn 1', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD13', N'M4', 1, CAST(N'2016-05-14 13:19:16.000' AS DateTime), CAST(N'2016-05-14 13:19:16.000' AS DateTime), N'Môn 4 tgw', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD14', N'M2', 1, CAST(N'2016-05-14 13:19:34.000' AS DateTime), CAST(N'2016-05-14 13:19:34.000' AS DateTime), N'Thứ 6', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD15', N'M1', 1, CAST(N'2016-05-14 13:19:46.000' AS DateTime), CAST(N'2016-05-14 13:19:46.000' AS DateTime), N'Hsds', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD16', N'M2', 1, CAST(N'2016-05-14 13:20:28.000' AS DateTime), CAST(N'2016-05-14 13:20:28.000' AS DateTime), N'Môn học 2', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD2', N'M1', 1, CAST(N'2016-05-14 13:00:54.000' AS DateTime), CAST(N'2016-05-14 17:00:54.000' AS DateTime), N'Môn thứ nhất có lịch vậy', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD3', N'M1', 1, CAST(N'2016-05-14 13:01:33.000' AS DateTime), CAST(N'2016-05-14 13:01:33.000' AS DateTime), N'Cái này để lịch thứ 2', -32640)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD4', N'M1', 1, CAST(N'2016-05-14 13:01:54.000' AS DateTime), CAST(N'2016-05-14 13:01:54.000' AS DateTime), N'Lịch thứ 6', -16711936)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD5', N'M2', 1, CAST(N'2016-05-14 16:02:13.000' AS DateTime), CAST(N'2016-05-14 17:02:13.000' AS DateTime), N'Lịch thứ 6 môn 2', -32640)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD6', N'M3', 1, CAST(N'2016-05-14 13:02:37.000' AS DateTime), CAST(N'2016-05-14 13:02:37.000' AS DateTime), N'Môn này học thứ 7', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD7', N'M3', 1, CAST(N'2016-05-14 13:02:53.000' AS DateTime), CAST(N'2016-05-14 13:02:53.000' AS DateTime), N'Thứ 7 học thêm môn này nửa nè', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD8', N'M3', 1, CAST(N'2016-05-14 13:03:10.000' AS DateTime), CAST(N'2016-05-14 13:03:10.000' AS DateTime), N'Thứ 7 học môn này', -986896)
GO
INSERT [dbo].[HoatDong] ([MaHD], [MaMon], [ChinhKhoa], [GioBD], [GioKT], [GhiChuHD], [MauMucDo]) VALUES (N'HD9', N'M1', 1, CAST(N'2016-05-14 13:03:28.000' AS DateTime), CAST(N'2016-05-14 13:03:28.000' AS DateTime), N'Thứ 7 có học 2 môn 1 à', -986896)
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 1, N'HD7')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 2, N'HD10')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 3, N'HD11')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 4, N'HD12')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 5, N'HD13')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 6, N'HD0')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 6, N'HD1')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 6, N'HD14')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 7, N'HD15')
GO
INSERT [dbo].[ThoiKhoaBieu] ([MaSV], [Thu], [MaHD]) VALUES (N'1', 7, N'HD16')
GO
