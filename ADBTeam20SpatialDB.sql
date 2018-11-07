create database ADBTeam20SpatialDB
use ADBTeam20SpatialDB
go
create table ql_thua_dat
(
	MaMD nvarchar(5) primary key,
	ynghiamd nvarchar(50),
	matdoluongnuoc int,
	matdodoanhthu float,
	vitri geometry
)
INSERT INTO ql_thua_dat(MaMD, ynghiamd, matdoluongnuoc, matdodoanhthu, vitri)
VALUES (N'M7',N'Trong lua',75000,250.6,geometry::STGeomFromText('MULTIPOLYGON(((1 0, 1 -4, -2 -5, -2 -1, -1 0 , 1 0)),((5 0, 7 0, 7 -5, 5 -5, 3 -3, 6 -2, 5 0)))', 0))
INSERT INTO ql_thua_dat(MaMD, ynghiamd, matdoluongnuoc, matdodoanhthu, vitri)
VALUES (N'M8', N'Trong cay an qua',45000,350.4,geometry::STGeomFromText('MULTIPOLYGON(((1 -3,3 -3, 3 -5, -2 -5, 1 -4, 1 -3)))',0))
INSERT INTO ql_thua_dat(MaMD, ynghiamd, matdoluongnuoc, matdodoanhthu, vitri)
VALUES (N'M9', N'Trong rau',35000,450.5,geometry::STGeomFromText('MULTIPOLYGON(((1 0, 3 1, 5 0, 5 -2, 3 -3,1 -3, 1 0)))',0))

SELECT * FROM ql_thua_dat;

--cau 2:
DECLARE @m7 geometry;
SET @m7= geometry::STGeomFromText('MULTIPOLYGON(((1 0, 1 -4, -2 -5, -2 -1, -1 0 , 1 0)),((5 0, 7 0, 7 -5, 5 -5, 3 -3, 6 -2, 5 0)))', 0);
--SELECT @m7.STArea();
DECLARE @m8 geometry;
SET @m8 = geometry::STGeomFromText('MULTIPOLYGON(((1 -3,3 -3, 3 -5, -2 -5, 1 -4, 1 -3)))',0);
--SELECT @m8.STArea();
DECLARE @m9 geometry;
SET @m9 = geometry::STGeomFromText('MULTIPOLYGON(((1 0, 3 1, 5 0, 5 -2, 3 -3,1 -3, 1 0)))',0);
--SELECT @m9.STArea();

--cau 3:
DECLARE @mp geometry;
SET @mp=geometry::STGeomFromText('MULTIPOLYGON(((2 3,4 3,4 -6,2 -6,2 3)))',0 ); 
DECLARE @m7 geometry;
SET @m7= geometry::STGeomFromText('MULTIPOLYGON(((1 0, 1 -4, -2 -5, -2 -1, -1 0 , 1 0)),((5 0, 7 0, 7 -5, 5 -5, 3 -3, 6 -2, 5 0)))', 0);
DECLARE @m7s geometry;
select @m7s = @mp.STDifference(@m7);
select @m7s.STArea();    

