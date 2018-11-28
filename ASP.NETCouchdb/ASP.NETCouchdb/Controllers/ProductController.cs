using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NETCouchdb.Models;
using Microsoft.AspNetCore.Http;
using RedBranch.Hammock;

namespace ASP.NETCouchdb.Controllers
{
    public class ProductController : Controller
    {
        public readonly Session _session;
        public ProductController()
        {
            Connection connection = new Connection(new Uri("http://localhost:5984"));
            _session = connection.CreateSession("eshop");
        }
        // GET: Product
        public ActionResult Index()
        {
            List<SanPham> sanPhams = new Query<SanPham>(_session, "sanpham-queries", "all-sanpham").All().Execute().Rows.Select(r=>
                new SanPham
                {
                    TenSanPham = r.Entity.TenSanPham,
                    MoTa = r.Entity.MoTa,
                    Hinh = r.Entity.Hinh,
                    Type = r.Entity.Type
                }
            ).ToList();

            return View(sanPhams);
        }

        public ActionResult CreateSanPham()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateSanPham(string TenSanPham ,string MoTa,string Type,HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0){
                string path = Path.Combine(Server.MapPath("~/Content/images"),  
                                       Path.GetFileName(file.FileName));  
                file.SaveAs(path);
                SanPham sanPham = new SanPham
                {
                    TenSanPham = TenSanPham,
                    MoTa = MoTa,
                    Hinh = file.FileName,
                    Type = Type
                };
                _session.Save(sanPham);
            }
            else
            {
                SanPham sanPham = new SanPham
                {
                    TenSanPham = TenSanPham,
                    MoTa = MoTa,
                    Type = Type
                };
                _session.Save(sanPham);
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditSanPham(string id)
        {
            var sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanphamkey").From(id).To(id).Execute().Rows.ToList().FirstOrDefault();
            return View(sp.Entity);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditSanPham(string TenSanPham,string Mota,string Type,HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                string path = Path.Combine(Server.MapPath("~/Content/images"),
                                       Path.GetFileName(file.FileName));
                file.SaveAs(path);
                var sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanphamkey").From(TenSanPham).To(TenSanPham).Execute().Rows.ToList().SingleOrDefault();
                SanPham s = sp.Entity;
                s.MoTa = Mota;
                s.Hinh = file.FileName;
                s.Type = Type;
                _session.Delete(sp.Entity);
                _session.Save(s);
            }
            else
            {
                var sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanphamkey").From(TenSanPham).To(TenSanPham).Execute().Rows.ToList().SingleOrDefault();
                SanPham s = sp.Entity;
                s.MoTa = Mota;
                s.Type = Type;
                _session.Delete(sp.Entity);
                _session.Save(s);
            }
            return RedirectToAction("Index");
        }

        public ActionResult DetailSanPham(string id)
        {
            var sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanphamkey").From(id).To(id).Execute().Rows.ToList().SingleOrDefault();
            return View(sp.Entity);
        }

        public ActionResult SearchSanPham(string txtsearch)
        {
            List<SanPham> sp = new List<SanPham>();
            if (txtsearch != null)
            {
                List<SanPham> sanPhams = new Query<SanPham>(_session, "sanpham-queries", "all-sanpham").All().Execute().Rows.Select(r =>
                     new SanPham
                     {
                         TenSanPham = r.Entity.TenSanPham,
                         MoTa = r.Entity.MoTa,
                         Hinh = r.Entity.Hinh,
                         Type = r.Entity.Type
                     }
                 ).ToList();
                sp = sanPhams.Where(p => p.TenSanPham.Contains(txtsearch)).ToList();
            }
            else
            {
                sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanpham").All().Execute().Rows.Select(r =>
                    new SanPham
                    {
                        TenSanPham = r.Entity.TenSanPham,
                        MoTa = r.Entity.MoTa,
                        Type = r.Entity.Type
                    }
                ).ToList();
            }
            return View("Index",sp);
        }


        public ActionResult DeleteSanPham(string id)
        {
            var sp = new Query<SanPham>(_session, "sanpham-queries", "all-sanphamkey").From(id).To(id).Execute().Rows.ToList().SingleOrDefault();
            _session.Delete(sp.Entity);
            return RedirectToAction("Index");
        }

    }
}