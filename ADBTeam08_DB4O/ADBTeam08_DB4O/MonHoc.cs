using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2016
{
    [Serializable]
    public class MonHoc
    {
        public int MaMH { get; set; }
        public string TenMon { get; set; }
        public string MoTa { get; set; }
        public Khoa KhoaQuanLy { get; set; }
        public MonHoc MonDieuKien { get; set; }
        public double SoTinChi { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} ({2})", MaMH, TenMon, SoTinChi);
        }
    }
}
