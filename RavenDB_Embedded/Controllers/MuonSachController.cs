using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class MuonSachController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            List<MuonSachView> la = new List<MuonSachView>();

            MuonSachView[] result = new MuonSachView[100];
            var Store = DatabaseHelper.store;
            Store.Initialize();
            using (var session = Store.OpenSession())
            {




                List<MuonSachView> li = session.Query<MuonSachView>().ToList<MuonSachView>();
                foreach (MuonSachView t in li)
                {
                    MuonSachView ti = new MuonSachView
                    {
                        Id = t.Id,
                        MaPhieu = t.MaPhieu,
                        TenDG = t.TenDG,
                        TenSach = t.TenSach,
                        TenChiNhanh = t.TenChiNhanh,
                        SoLuongMuon = t.SoLuongMuon,
                        NgayMuon = t.NgayMuon


                    };
                    la.Add(ti);
                }





            }



            // Send to the Server
            // one request processed in one transaction


            return View(la);

        }
        [HttpGet]

        public IActionResult Edit(MuonSachView t, string Id, string MaPhieu, string Ten, string Tens, string Tencn, string slm, string ngaym)
        {
            ViewBag.Id = Id;
            ViewBag.MP = MaPhieu;
            ViewBag.Ten = Ten;
            ViewBag.TenSach = Tens;
            ViewBag.TenCN = Tencn;
            ViewBag.SoLuong = slm;
            ViewBag.NgayMuon = ngaym;

            List<MuonSachView> li = new List<MuonSachView>();
            var Store = DatabaseHelper.store;
            Store.Initialize();

            using (var session = Store.OpenSession())
            {

                t = session.Load<MuonSachView>(Id);
            }

            return View(t);
        }



        [HttpGet]
        [HttpPost]


        public IActionResult AcceptEdit(string Id, string MaPhieu, string TenDG, string TenSach, string TenChiNhanh, int SoLuongMuon, string NgayMuon)
        {

            MuonSachView t = new MuonSachView();
            ViewBag.Mp = TenDG;
            var sstore = DatabaseHelper.store;
            sstore.Initialize();

            using (var session = sstore.OpenSession())
            {
                t.Id = Id;
                t.MaPhieu = MaPhieu;
                t.TenDG = TenDG;
                t.TenSach = TenSach;
                t.TenChiNhanh = TenChiNhanh;
                t.SoLuongMuon = SoLuongMuon;
                t.NgayMuon = NgayMuon;
                session.Store(t);
                session.SaveChanges();


            }

            return View(t);
        }
    }
}