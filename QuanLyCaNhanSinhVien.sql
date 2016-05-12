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
	Tiet int,
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

insert into HocKy values('MaHK', N'TenHK', 'NamHoc');
insert into HocKy values('HK1', N'Học kỳ 1', '2014');
insert into HocKy values('HK2', N'Học kỳ 2', '2015');
insert into HocKy values('HK3', N'Học kỳ 3', '2015');
insert into HocKy values('HK4', N'Học kỳ 4', '2016');
insert into HocKy values('HK5', N'Học kỳ 5', '2016');

go

insert into MonHoc values('MaMon', N'TenMon',1,1);
insert into MonHoc values('MCSDL', N'Cấu trúc dữ liệu',5,5);
insert into MonHoc values('MDBMS', N'Cơ sở dữ liệu',1,1);
insert into MonHoc values('MLTW', N'Lạp trình Windows',1,1);
insert into MonHoc values('NMLT', N'Nhập Môn lập trình',5,5);

go

insert into SinhVien values('MaSV', N'HoTen',0,'1/1/2016','DiaChi',N'CacThongTin');
insert into SinhVien values('14110182', N'Nguyễn Thành Thái',1,'1/18/1996',N'Đồng Tháp',N'Thông tin');

go

insert into DanhSachMon values('MaSV', 'MaMon', 'MaHK');
insert into DanhSachMon values('14110182', 'MaMon', 'MaHK');
insert into DanhSachMon values('14110182', 'MCSDL', 'HK3');
insert into DanhSachMon values('14110182', 'MLTW', 'HK4');
insert into DanhSachMon values('14110182', 'MDBMS', 'HK4');

go

insert into AccountSinhVien values('MaSV',N'PasswordSV');
insert into AccountSinhVien values('14110182',N'ntt');

go

insert into HocPhi values('MaSV','MaHK',123);
insert into HocPhi values('14110182','MaHK',123);

go

insert into DiemSo values('MaSV', 'MaMon','MaHK', 'MaDiem', 1, 10, '1/1/2016');
insert into DiemSo values('14110182', 'MDBMS', 'HK4' , 'D01', 1, 10, '1/2/2016');
insert into DiemSo values('14110182', 'MCSDL', 'HK3', 'D02', 1, 10, '1/3/2016');

go

insert into HoatDong values ('MaHD', 'MaMon', 1, 2,'10:2','14:2','GhiChuHD');
insert into HoatDong values ('HD01', 'MDBMS', 1, 2,'10:2','14:2','GhiChuHD');
insert into HoatDong values ('HD02', 'MCSDL', 1, 2,'10:2','14:2','GhiChuHD');
insert into HoatDong values ('HD03', 'MCSDL', 0, 2,'10:2','14:2','Ôn Thi');
insert into HoatDong values ('HD04', 'MCSDL', 0, 2,'10:2','14:2','Ôn thi');

go

insert into ThoiKhoaBieu values('MaSV', 2, 'MaHD');
insert into ThoiKhoaBieu values('14110182', 2, 'HD01');
insert into ThoiKhoaBieu values('14110182', 3, 'HD02');