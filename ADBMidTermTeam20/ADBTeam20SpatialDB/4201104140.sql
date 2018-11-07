
use ADBTeam20SpatialDB
go

--Cau 2
--a) Tính Lượng nước tưới tiêu cần thiết
select ql_thua_dat.MaMD, ql_thua_dat.ynghiamd, (ql_thua_dat.vitri.STArea())*ql_thua_dat.matdoluongnuoc as N'Lượng nước tưới tiêu' from ql_thua_dat
--b) loại đất có diện tích bé nhất
declare @min float
select @min = min(ql_thua_dat.vitri.STArea()) from ql_thua_dat

select * from ql_thua_dat where ql_thua_dat.vitri.STArea() =@min
--c) diện tích bị mất sau ứng với mỗi loại sau khi xây dựng kênh nước 
DECLARE @kenh geometry = geometry::STGeomFromText('POLYGON ((2 1, 4 1, 4 -5, 2 -5, 2 1))', 0);
select ql_thua_dat.MaMD, ql_thua_dat.vitri.STIntersection(@kenh).STArea()*10000 as DienTichMat from ql_thua_dat

