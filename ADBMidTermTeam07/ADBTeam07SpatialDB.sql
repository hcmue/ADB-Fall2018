create database ADBTeam07SpatialDB
go
use ADBTeam07SpatialDB
go
create table ManhDat(
    ID int IDENTITY PRIMARY KEY,
	MaMD nvarchar(200),
	YNghia nvarchar(200),
	Nuoc int,
	DoanhThu float,
	Location geometry
);
go

-- Nhap du lieu
-- drop table ManhDat
insert into ManhDat (MaMD,YNghia,Nuoc,DoanhThu,Location)
values ('M7', N'Trồng Lúa',75000,250.6,
geometry::STGeomFromText('MULTIPOLYGON(((-2 2, -1 3, 1 3 , 1 -1 ,-2 -2,-2 2)),((5 3, 7 3, 7 -2, 5 -2, 3 0,6 1, 5 3)))', 0))
go

insert into ManhDat (MaMD,YNghia,Nuoc,DoanhThu,Location)
values ('M8', N'Trồng Cây Ăn Quả',45000,350.4,
geometry::STGeomFromText('POLYGON((1 0, 3 0, 3 -2, -2 -2,1 -1,1 0))', 0))
go

insert into ManhDat (MaMD,YNghia,Nuoc,DoanhThu,Location)
values ('M9', N'Trồng Rau',35000,450.5,
geometry::STGeomFromText('POLYGON((1 3, 3 4, 5 3, 5 1, 3 0, 1 0, 1 3))', 0))
go


select * from ManhDat