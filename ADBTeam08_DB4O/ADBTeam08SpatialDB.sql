create table QuanLyDat
(
	MaMD varchar(5) primary key,
	ChiThiMau nvarchar(10) not null,
	YNghia nvarchar(50) not null,
	MatDoLuongNuoc int not null,
	MatDoDoanhThu float not null,
	DatLocation geometry not null
);

insert into QuanLyDat(MaMD, ChiThiMau, YNghia, MatDoLuongNuoc, MatDoDoanhThu,DatLocation) values
(
	'M7', N'Xám', N'Trồng lúa', 45000, 250.6,
	geometry::STGeomFromText('POLYGON((-7 2, 0 2,0 0,-7 0,-5 1,-7 2),(0 2,4 2,2 1,4 0,0 0,0 2))',4326)
);

insert into QuanLyDat(MaMD, ChiThiMau, YNghia, MatDoLuongNuoc, MatDoDoanhThu,DatLocation) values
(
	'M8', N'Nâu', N'Trồng cây ăn quả', 30000, 350.4,
	geometry::STGeomFromText('POLYGON((4 2,5 7,8 6,9 1,4 2)',4326)
);

insert into QuanLyDat(MaMD, ChiThiMau, YNghia, MatDoLuongNuoc, MatDoDoanhThu,DatLocation) values
(
	'M9', N'Tím', N'Trồng rau', 60000, 450.5,
	geometry::STGeomFromText('POLYGON((4 2, 9 1, 8 -4, 7 -5, 4 0, 2 1, 4 2)',4326)
);

insert into QuanLyDat(MaMD, ChiThiMau, YNghia, MatDoLuongNuoc, MatDoDoanhThu,DatLocation) values
(
	'M10', N'Vàng', N'Trồng xoài', 75000, 400.5,
	geometry::STGeomFromText('POLYGON((3 9, 8 6, 5 7, 4 2, 0 2, 3 9))',4326)
);

--Câu 2
--a
SELECT MaMD, DatLocation.MakeValid().STArea() as DienTich,
	DatLocation.MakeValid().STArea()/10000 * MatDoLuongNuoc as LuongNuocTuoiTieu
FROM QuanLyDat;

--b
SELECT MaMD, YNghia, DatLocation.MakeValid().STArea() as DienTichLonNhat
FROM QuanLyDat
WHERE DatLocation.MakeValid().STArea() >= ALL (SELECT DatLocation.MakeValid().STArea() FROM QuanLyDat)