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

use [QuanLyCaNhanSinhVien]
go
EXEC [dbo].[spLichHocTrongNgay] @MaSV=1, @Thu=2