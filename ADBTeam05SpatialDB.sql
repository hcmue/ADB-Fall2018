-- TEAM 05

--CAU 1:
CREATE DATABASE  ADBTeam05SpatialDB
GO
USE ADBTeam05SpatialDB
GO 

CREATE TABLE QUANLY(
	MAU NVARCHAR(10),
	MA VARCHAR(5),
	MUCDICH NVARCHAR(100),
	MATDONUOC NVARCHAR(50),
	MATDODOANHTHU NVARCHAR(50),
	DIADIEM GEOMETRY
)
GO

INSERT INTO dbo.QUANLY
VALUES
(N'Xám',N'M7',N'Trồng lúa',75000,N'250.6 triệu VNĐ/ha',GEOMETRY::STGeomFromText('MULTIPOLYGON(((-1 3 , 1 3 , 1 -1 , -2 -2,-2 2,-1 3 )),((5 3,7 3,7 -2, 5 -2,3 0, 6 1, 5 3)))',4168)),
(N'Nâu',N'M8',N'Trồng cây ăn quả',45000,N'350.4 triệu VNĐ/ha',GEOMETRY::STGeomFromText('POLYGON((1 0, 3 0, 3 -2, -2 -2, 1 -1 ,1 0))',4168)),
(N'Tím',N'M9',N'Trồng rau',35000,N'450.5 triệu VNĐ/ha',GEOMETRY::STGeomFromText('POLYGON((1 3, 3 4, 5 3, 5 1, 3 0, 1 0, 1 3))', 4168))
GO
