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
	HinhAnh varbinary,
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