using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenDB_Embedded.Models
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongGoc { get; set; }
        public string TenTacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string LoiGioiThieu { get; set; }
        public int Rating { get; set; }
        public List<string> BinhLuan { get; set; }
        public string ChiNhanh { get; set; }//mã chi nhánh
    }
}
