using Raven.Client.Documents;
using Raven.Client.Documents.Session;
using Raven.Client.ServerWide;
using Raven.Embedded;
using RavenDB_Embedded.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RavenDB_Embedded
{
    public class DatabaseHelper
    {
        //(Embedded) Mở kết nối không cần run RavenDB 
        //public static IDocumentStore EmbeddedDB()
        //{
        //    var serverOptions = new ServerOptions();
        //    serverOptions.Secured(
        //        certificate: "C:/Users/vnqma/source/repos/RavenDB_Embedded/RavenDB_Embedded/nhom85.Cluster.Settings/DOAN/cluster.server.certificate.nhom85.pfx"
        //    );

        //    serverOptions.DataDirectory = "C:/Users/vnqma/source/repos/RavenDB_Embedded/RavenDB_Embedded/App_Data/Database/";
        //    serverOptions.ServerUrl = "https://doan.nhom85.ravendb.community";
        //    serverOptions.FrameworkVersion = "2.1.1";
        //    EmbeddedServer.Instance.StartServer(serverOptions);
        //    var db = new DatabaseOptions(new DatabaseRecord { DatabaseName = "QLTHUVIEN" });
        //    return EmbeddedServer.Instance.GetDocumentStore(db);
        //}

        //Mở kết nối chạy bằng server (phải run RavenDB trước)
        static X509Certificate2 clientCertificate = new X509Certificate2("C:\\Users\\vnqma\\Downloads\\Compressed\\nhom85.Cluster.Settings\\Cer\\admin.client.certificate.nhom85.pfx", "vnqmai");
        public static IDocumentStore store = new DocumentStore { Urls = new[] { "https://doan.nhom85.ravendb.community" }, Certificate = clientCertificate, Database = "QLTHUVIEN" }.Initialize();

        //Tìm kiếm
        public static List<MuonSachView> TimKiemTheoMaPhieu(string p)
        {
            List<MuonSachView> phieus = new List<MuonSachView>();
            using (IDocumentSession session = store.OpenSession())  // Open a session for a default 'Database'
            {
                List<PhieuMuonSachSV> phieu = session
                    .Query<PhieuMuonSachSV>()                               // Query for Products
                    .Include(x => x.DocGia)
                    .Include(x => x.Sach)
                    .Include(x => x.ChiNhanh)
                    .Where(x => x.MaPhieu == p)                 // Filter                                                                  
                    .ToList();                                      // Materialize query
                foreach (PhieuMuonSachSV x in phieu)
                {
                    DocGiaSV dg = session.Load<DocGiaSV>(x.DocGia);
                    ChiNhanh cn = session.Load<ChiNhanh>(x.ChiNhanh);
                    Sach s = session.Load<Sach>(x.Sach);

                    MuonSachView detail = new MuonSachView
                    {
                        MaPhieu = x.MaPhieu,
                        TenDG = dg.TenDG,
                        TenSach = s.TenSach,
                        TenChiNhanh = cn.TenChiNhanh,
                        SoLuongMuon = x.SoLuongMuon,
                        NgayMuon = x.NgayMuon
                    };
                    phieus.Add(detail);
                }
            }
            return phieus;
        }

        //Load phiếu
        public static List<MuonSachView> List(string id)
        {            
            List<MuonSachView> res = new List<MuonSachView>();
            using (IDocumentSession session = store.OpenSession())
            {
                List<PhieuMuonSachSV> sv;
                if (id != null)
                {
                    sv = session
                    .Query<PhieuMuonSachSV>()
                    .Where(x=>x.Id==id)
                    .Include(x => x.DocGia)
                    .Include(x => x.Sach)
                    .Include(x => x.ChiNhanh)
                    .ToList<PhieuMuonSachSV>();
                }
                else
                {
                    sv = session
                    .Query<PhieuMuonSachSV>()
                    .Include(x => x.DocGia)
                    .Include(x => x.Sach)
                    .Include(x => x.ChiNhanh)
                    .ToList<PhieuMuonSachSV>();
                }
                
                foreach (PhieuMuonSachSV pms in sv)
                {
                    DocGiaSV dg = session.Load<DocGiaSV>(pms.DocGia);
                    ChiNhanh cn = session.Load<ChiNhanh>(pms.ChiNhanh);
                    Sach s = session.Load<Sach>(pms.Sach);

                    MuonSachView detail = new MuonSachView
                    {
                        Id = pms.Id,
                        MaPhieu = pms.MaPhieu,
                        TenDG = dg.TenDG,
                        TenSach = s.TenSach,
                        TenChiNhanh = cn.TenChiNhanh,
                        SoLuongMuon = pms.SoLuongMuon,
                        NgayMuon = pms.NgayMuon
                    };

                    res.Add(detail);
                }
            }
            return res;
        }

        //Load độc giả
        public static List<DocGiaSV> ListDocGia()
        {
            List<DocGiaSV> res = new List<DocGiaSV>();
            using (IDocumentSession session = store.OpenSession())
            {
                res = session
                    .Query<DocGiaSV>()
                    .ToList();

            }
            return res;
        }

        //Load sách
        public static List<Sach> ListSach()
        {
            List<Sach> res = new List<Sach>();
            using (IDocumentSession session = store.OpenSession())
            {                
                res = session
                    .Query<Sach>()                    
                    .ToList();                
            }
            return res;
        }

        //Load chi nhánh
        public static List<ChiNhanh> ListChiNhanh()
        {
            List<ChiNhanh> res = new List<ChiNhanh>();
            using (IDocumentSession session = store.OpenSession())
            {
                res = session
                    .Query<ChiNhanh>()
                    .ToList();

            }
            return res;
        }

        //Add
        public static void Add<T>(T obj)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(obj);
                session.SaveChanges();
            }
        }

        //Delete
        public static void Delete(string id)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                PhieuMuonSachSV ms = new PhieuMuonSachSV();
                ms = session.Load<PhieuMuonSachSV>(id);
                session.Delete<PhieuMuonSachSV>(ms);
                session.SaveChanges();
            }
        }

        //Edit
        public static void Edit(PhieuMuonSachSV pms)
        {
            using (IDocumentSession session = store.OpenSession())
            {
                session.Store(pms);
                session.SaveChanges();
            }
        }
    }
}
