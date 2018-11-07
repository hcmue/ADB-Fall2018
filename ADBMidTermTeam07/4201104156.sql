use ADBTeam07SpatialDB
go
-- cau 2a
select q1.ID, q1.MaMD, q1.YNghia, q1.Location.STArea()*q1.Nuoc as LuongNuocTuoiTieuCanThiet  from QLD q1

-- Cau 2b
select TOP(1) q1.ID, q1.MaMD, q1.YNghia, q1.Location.STArea()*10000 as DienTich  from QLD q1 order by q1.Location.STArea() ASC 

-- Cau 2c
-- khoi tao con kenh nuoc
DECLARE @g1 geometry ='POLYGON((2 4, 4 4, 4 -2, 2 -2, 2 4))';
select ID,MaMD,YNghia,Location.STArea()-Location.STDifference(@g1).STArea() as DienTichBiMat from QLD