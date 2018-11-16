using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class PhieuMuonSachThuong
    {
        public string Id { get; set; }
        public string MaPhieu { get; set; }
        public string DocGia { get; set; }
        public string ChiNhanh { get; set; }
        public string Sach { get; set; }
        public int SoLuongMuon { get; set; }
        public string NgayMuon { get; set; }
        
    }
}
