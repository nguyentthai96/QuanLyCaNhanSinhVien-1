if db_id('QuanLyCaNhanSinhVien') is not null
begin
	exec msdb.dbo.sp_delete_database_backuphistory @database_name = N'QuanLyCaNhanSinhVien'
	use [master]
	drop database QuanLyCaNhanSinhVien
end

create database QuanLyCaNhanSinhVien
go

use QuanLyCaNhanSinhVien
go

create table HocKy
(
	MaHK varchar(10),
	TenHK nvarchar(50),
	NamHoc varchar(10),
	primary key(MaHK)
)

create table MonHoc
(
	MaMon varchar(10),
	TenMon nvarchar(50),
	SoTinhChi int,
	SoTiet int,
	primary key (MaMon)
)

create table SinhVien
(
	MaSV varchar(10),
	HoTen nvarchar(50),
	GioiTinh bit,
	NgaySinh date,
	DiaChi nvarchar(50),
	CacThongTin nvarchar(100),
	HinhAnh nvarchar(MAX),
	primary key (MaSV)
)

create table DanhSachMon
(
	MaSV varchar(10),
	MaMon varchar(10),
	MaHK varchar(10),
	primary key (MaSV, MaMon, MaHK),
	foreign key (MaSV) references SinhVien,
	foreign key (MaMon) references MonHoc,
	foreign key (MaHK) references HocKy
)

create table DiemSo
(
	MaSV varchar(10),
	MaMon varchar(10),
	MaHK varchar(10),
	MaDiem varchar(10), --tu sinh
	SoDiem float,
	HeSo float,
	NgayDiem date,
	primary key (MaSV, MaMon, MaHK, MaDiem),
	foreign key (MaSV) references SinhVien,
	foreign key (MaMon) references MonHoc,
	foreign key (MaSV, MaMon, MaHK) references DanhSachMon
)

create table AccountSinhVien
(
	MaSV varchar(10),
	PasswordSV nvarchar(50),
	primary key (MaSV),
	foreign key (MaSV) references SinhVien
)

create table HocPhi
(
	MaSV varchar(10),
	MaHK varchar(10),
	SoTien money,
	primary key (MaHK, MaSV),
	foreign key (MaHK) references HocKy,
	foreign key (MaSV) references SinhVien
)

create table HoatDong
(
	MaHD varchar(10),
	MaMon varchar(10),
	ChinhKhoa bit,
	GioBD datetime,
	GioKT datetime,
	GhiChuHD nvarchar(100),
	MauMucDo int,
	primary key (MaHD)
)

create table ThoiKhoaBieu
(
	MaSV varchar(10),
	Thu int,
	MaHD varchar(10),
	primary key (MaSV,Thu, MaHD),
	foreign key (MaHD) references HoatDong,
	foreign key (MaSV) references AccountSinhVien(MaSV)
)



go
use [QuanLyCaNhanSinhVien]
go
--alter 
create procedure [dbo].[spLichHocTrongNgay]
@MaSV varchar(10),
@Thu int
as
begin
	select * from HoatDong inner join ThoiKhoaBieu on (HoatDong.MaHD=ThoiKhoaBieu.MaHD)
	where (MaSV=@MaSV and Thu=@Thu and ChinhKhoa=1);
end

go
use [QuanLyCaNhanSinhVien]
go
--alter 
create procedure [dbo].[spHoatDongTuongLai]
@MaSV varchar(10),
@ThoiGianHienTai date
as
begin
	select * from HoatDong inner join ThoiKhoaBieu on (HoatDong.MaHD=ThoiKhoaBieu.MaHD)
	where (MaSV=@MaSV and GioBD>=@ThoiGianHienTai and ChinhKhoa=0);
end

go
use [QuanLyCaNhanSinhVien]
go
--alter 
create procedure [dbo].[spAddLichHoc]
(
@MaSV varchar(10),
@Thu int,
@MaHD varchar(10),
@MaMon varchar(10),
@ChinhKhoa bit,
@GioBD datetime,
@GioKT datetime,
@GhiChuHD nvarchar(100),
@MauMucDo int
)
as
begin
	insert into HoatDong values (@MaHD, @MaMon, @ChinhKhoa, @GioBD, @GioKT, @GhiChuHD,@MauMucDo);
	insert into ThoiKhoaBieu values (@MaSV, @Thu, @MaHD);
end

go
USE QuanLyCaNhanSinhVien
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[reportDiem]
AS
SELECT TenMon ,SoDiem, HeSo
FROM DiemSo, DanhSachMon, MonHoc
WHERE DiemSo.MaMon=DanhSachMon.MaMon and
		DiemSo.MaHK=DanhSachMon.MaHK and
		DiemSo.MaSV=DanhSachMon.MaSV and
		MonHoc.MaMon=DanhSachMon.MaMon

go

use [QuanLyCaNhanSinhVien]
go
--alter 
create procedure [dbo].[spreportDiem]
(
@MaSV varchar(10),
@MaMon varchar(10),
@MaHK varchar(10)
)
as
return
SELECT TenMon ,SoDiem, HeSo
FROM DiemSo, DanhSachMon, MonHoc
WHERE	DiemSo.MaSV=@MaSV and DiemSo.MaMon=@MaMon and DanhSachMon.MaHK=@MaHK and
		DiemSo.MaMon=DanhSachMon.MaMon and
		DiemSo.MaHK=DanhSachMon.MaHK and
		DiemSo.MaSV=DanhSachMon.MaSV and
		MonHoc.MaMon=DanhSachMon.MaMon

