using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeam13_DB4O
{
    [Serializable]
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public override string ToString()
        {
            return TenKhoa;
        }
    }
}
