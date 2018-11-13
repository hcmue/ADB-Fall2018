using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RavenDB_Embedded.Models;

namespace RavenDB_Embedded.Controllers
{
    public class HomeController : Controller
    {                
        public IActionResult Index()
        {           
            List<MuonSachView> li = DatabaseHelper.List(null);
            return View(li);
        }

        [HttpPost]
        public IActionResult Search(string input)
        {           
            List<MuonSachView> li = DatabaseHelper.TimKiemTheoMaPhieu(input);
            if (li.Capacity != 0)
                return View("Search",li);
            else
            {
                ViewBag.Null = "null";
                return View();
            }                
        }
        
        public IActionResult Add([Bind("MaPhieu,TenDG,TenSach,TenChiNhanh,SoLuongMuon,NgayMuon")] MuonSachView pms)
        {
            if (ModelState.IsValid&&pms.MaPhieu!=null)
            {
                PhieuMuonSachSV res = new PhieuMuonSachSV
                {                    
                    MaPhieu = pms.MaPhieu,
                    DocGia = pms.TenDG,
                    Sach = pms.TenSach,
                    ChiNhanh  = pms.TenChiNhanh,
                    SoLuongMuon = pms.SoLuongMuon,
                    NgayMuon = pms.NgayMuon
                };
                DatabaseHelper.Add(res);
                pms.Id = res.Id;
                RedirectToAction(nameof(Index));
            }                        
            return View(pms);
        }

        //Sửa Phiếu không sửa references
        public IActionResult Edit([Bind("Id,MaPhieu,TenDG,TenSach,TenChiNhanh,SoLuongMuon,NgayMuon")]MuonSachView pms)
        {
            pms.Id = pms.Id.Replace("*", "/");
            //Xử lý sửa database
            PhieuMuonSachSV res = new PhieuMuonSachSV
            {
                Id = pms.Id,
                MaPhieu = pms.MaPhieu,
                DocGia = pms.TenDG,
                Sach = pms.TenSach,
                ChiNhanh = pms.TenChiNhanh,
                SoLuongMuon = pms.SoLuongMuon,
                NgayMuon = pms.NgayMuon
            };
            DatabaseHelper.Edit(res);                        
            return View(pms);
        }

        //Xóa Phiếu không xóa references
        public IActionResult Delete(string id)
        {
            id = id.Replace("*", "/");

            //load dữ liệu
            MuonSachView pms = DatabaseHelper.List(id)[0];
            
            DatabaseHelper.Delete(id);
            
            return View(pms);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
