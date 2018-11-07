using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeam13_DB4O
{
    class DataHelper
    {
        public static string DbFileName  = "ADBTeam13_CourseManager.yap";

        public static List<MonHoc> GetAllSubject()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IList<MonHoc> monHocs = db.Query(delegate (MonHoc m) {
                return m.TenMon != "";
            });

            List<MonHoc> res = monHocs.ToList();
            db.Close();
            return res;
        }

        public static List<Khoa> GetKhoas()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            // get all khoa
            IList<Khoa> kh = db.Query(delegate (Khoa k) {
                return k.TenKhoa != "";
            });
            List<Khoa> khoas = kh.ToList();
            db.Close();
            return khoas;
        }

        public static void addSubject(int mamh, string tenmh, string mota, string tenkhoa, string mondieukien , int stc)
        {
            
            // tao 1 subject
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);

            IList<Khoa> kh = db.Query(delegate (Khoa khoa) {
                return khoa.TenKhoa == tenkhoa;
            });

            Khoa k = kh[0] as Khoa;

            if (mondieukien == "")
            {
                MonHoc mh = new MonHoc();
                MonHoc monHoc = new MonHoc
                {
                    MaMH = mamh,
                    TenMon = tenmh,
                    MoTa = mota,
                    KhoaQuanLy = k,
                    MonDieuKien = mh,
                    SoTinChi = stc
                };
                db.Store(monHoc);
            }
            else
            {
                IList<MonHoc> monHocs = db.Query(delegate(MonHoc m)
                {
                    return m.TenMon == mondieukien;
                });
                MonHoc mh = new MonHoc();
                if (monHocs != null)
                {
                    mh = monHocs[0];
                }
                MonHoc monHoc = new MonHoc
                {
                    MaMH = mamh,
                    TenMon = tenmh,
                    MoTa = mota,
                    KhoaQuanLy = k,
                    MonDieuKien = mh,
                    SoTinChi = stc
                };
                db.Store(monHoc);
            }
            db.Close();
        }


        public static List<Khoa> QueriesSbject2_stc2()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            // get all khoa
            IList<Khoa> kh = db.Query(delegate (Khoa k) {
                return k.TenKhoa != "";
            });
            List<Khoa> khoas = kh.ToList();

            // get all monhoc
            IList<MonHoc> mh = db.Query(delegate (MonHoc m) {
                return m.TenMon != "";
            });

            List<MonHoc> monHocs = mh.ToList();

            //list ket qua
            List<Khoa> khoa = new List<Khoa>();
            foreach (Khoa k in khoas)
            {
                int nMonhoc = 0;
                foreach (MonHoc m in monHocs)
                {
                    if (m.KhoaQuanLy == k && m.SoTinChi > 2)
                    {
                        nMonhoc += 1;
                    }
                }
                if (nMonhoc > 2)
                {
                    khoa.Add(k);
                }
            }
            db.Close();
            return khoa;
        }

        public static List<MonHoc> GetQuery5()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IList<MonHoc> mh = db.Query(delegate (MonHoc m)
            {
                return m.MaMH != 0 && m.TenMon.ToLower().Contains("cơ sở dữ liệu");
            });

            List<MonHoc> monHocs = mh.ToList();
            db.Close();
            return monHocs;

        }


        public static void addKhoa(string makhoa,string tenkhoa,string diachi,string dienthoai)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            
             // tao khoa
             Khoa k = new Khoa
             {
                   MaKhoa = makhoa,
                   TenKhoa = tenkhoa,
                   DiaChi = diachi,
                   DienThoai = dienthoai
             };
             db.Store(k);

            db.Close();
        }
    }
}