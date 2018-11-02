using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using NETCOREMONGO2.Models;
using NETCOREMONGO2.Models;
using Newtonsoft.Json;
public class HomeController : Controller
{
    private IMongoDatabase mongoDatabase;

    //Generic method to get the mongodb database details  
    public IMongoDatabase GetMongoDatabase()
    {
        var mongoClient = new MongoClient("mongodb://localhost:27017");
        return mongoClient.GetDatabase("NhaHang");
    }

    [HttpGet]
    public IActionResult Index()
    {
        //Get the database connection  
        mongoDatabase = GetMongoDatabase();
        //fetch the details from CustomerDB and pass into view  
        var result = mongoDatabase.GetCollection<monAn>("monAn").Find(FilterDefinition<monAn>.Empty).ToList();
        return View(result);
    }
    [HttpPost]
    public IActionResult Search(String command,string giatri)
    {
        if(command=="Id")
        {
            int n = int.Parse(giatri);
            mongoDatabase = GetMongoDatabase();
            var result = mongoDatabase.GetCollection<monAn>("monAn").Find(k => k.maMon == n).ToList();
            return View("IdSearch",result);
        }
        else if (command == "Ten")
        {
            string n = giatri.ToString();
            mongoDatabase = GetMongoDatabase();
            var result = mongoDatabase.GetCollection<monAn>("monAn").Find(k => k.tenMon.Contains(n)).ToList();
            return View("IdSearch", result);
        }
        else
        {
            string n = giatri.ToString();
            mongoDatabase = GetMongoDatabase();
            var result = mongoDatabase.GetCollection<monAn>("monAn").Find(k => k.dauBep.Contains(n)).ToList();
            return View("IdSearch", result);
        }
        return View();
        
    }
    //[HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(monAn customer, IFormFile[] myfile)
    {
        string arr = "";

        if (myfile != null)
        {
            foreach (var item in myfile)
            {
                string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", item.FileName);
                using (var f = new FileStream(url, FileMode.Create))
                {
                    item.CopyTo(f);
                }
                arr += item.FileName + ";";
            }
            customer.image = arr;
        }

        try
        {
            //Get the database connection  
            mongoDatabase = GetMongoDatabase();
            mongoDatabase.GetCollection<monAn>("monAn").InsertOne(customer);
        }
        catch (Exception ex)
        {
            throw;
        }
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        //Get the database connection  
        mongoDatabase = GetMongoDatabase();
        //fetch the details from CustomerDB and pass into view  
        monAn customer = mongoDatabase.GetCollection<monAn>("monAn").Find<monAn>(k => k.maMon == id).FirstOrDefault();
        if (customer == null)
        {
            return NotFound();
        }
        string[] arrListStr = customer.image.Split(';');
        ViewBag.arr = arrListStr;
        return View(customer);
    }

    [HttpGet]
    public IActionResult Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        //Get the database connection  
        mongoDatabase = GetMongoDatabase();
        //fetch the details from CustomerDB and pass into view  
        monAn customer = mongoDatabase.GetCollection<monAn>("monAn").Find<monAn>(k => k.maMon == id).FirstOrDefault();
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }

    [HttpPost]
    public IActionResult Delete(int maMon)
    {
        try
        {
            //Get the database connection  
            mongoDatabase = GetMongoDatabase();
            //Delete the customer record  
            var result = mongoDatabase.GetCollection<monAn>("monAn").DeleteOne<monAn>(k => k.maMon == maMon);
            if (result.IsAcknowledged == false)
            {
                return BadRequest("Unable to Delete Customer " + maMon);
            }
        }
        catch (Exception ex)
        {
            throw;
        }
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        //Get the database connection  
        mongoDatabase = GetMongoDatabase();
        //fetch the details from CustomerDB based on id and pass into view  
        var customer = mongoDatabase.GetCollection<monAn>("monAn").Find<monAn>(k => k.maMon == id).FirstOrDefault();
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }

    [HttpPost]
    public IActionResult Edit(monAn monAn, IFormFile[] myfile)
    {
        string arr = "";

        if (myfile != null)
        {
            foreach (var item in myfile)
            {
                string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", item.FileName);
                using (var f = new FileStream(url, FileMode.Create))
                {
                    item.CopyTo(f);
                }
                arr += item.FileName + ";";
            }
            monAn.image = arr;
        }
        try
        {
            //Get the database connection  
            mongoDatabase = GetMongoDatabase();
            //Build the where condition  
            var filter = Builders<monAn>.Filter.Eq("maMon", monAn.maMon);
            //Build the update statement   
            var updatestatement = Builders<monAn>.Update.Set("maMon", monAn.maMon);
            updatestatement = updatestatement.Set("tenMon", monAn.tenMon);
            updatestatement = updatestatement.Set("gia", monAn.gia);
           
            
            updatestatement = updatestatement.Set("image", monAn.image);
            updatestatement = updatestatement.Set("moTa", monAn.moTa);
            updatestatement = updatestatement.Set("loai", monAn.loai);
            updatestatement = updatestatement.Set("dauBep", monAn.dauBep);
            //fetch the details from CustomerDB based on id and pass into view  
            var result = mongoDatabase.GetCollection<monAn>("monAn").UpdateOne(filter, updatestatement);
            if (result.IsAcknowledged == false)
            {
                return BadRequest("Unable to update Customer  " + monAn.tenMon);
            }
        }
        catch (Exception ex)
        {
            throw;
        }

        return RedirectToAction("Index");
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

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
