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




go


USE QuanLyCaNhanSinhVien
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[reportDiems]
AS
	execute fnreportDiem )

go

use [QuanLyCaNhanSinhVien]
go
execute [dbo].[fnreportDiem] ('1',HK4, M1)
go
select HinhAnh from SinhVien