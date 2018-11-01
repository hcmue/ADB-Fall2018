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
        return mongoClient.GetDatabase("Customer");
    }

    [HttpGet]
    public IActionResult Index()
    {
        //Get the database connection  
        mongoDatabase = GetMongoDatabase();
        //fetch the details from CustomerDB and pass into view  
        var result = mongoDatabase.GetCollection<Customer>("Customers").Find(FilterDefinition<Customer>.Empty).ToList();
        return View(result);
    }

    //[HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Customer customer, IFormFile[] myfile)
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
            mongoDatabase.GetCollection<Customer>("Customers").InsertOne(customer);
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
        Customer customer = mongoDatabase.GetCollection<Customer>("Customers").Find<Customer>(k => k.productId == id).FirstOrDefault();
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
        Customer customer = mongoDatabase.GetCollection<Customer>("Customers").Find<Customer>(k => k.productId == id).FirstOrDefault();
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }

    [HttpPost]
    public IActionResult Delete(int productId)
    {
        try
        {
            //Get the database connection  
            mongoDatabase = GetMongoDatabase();
            //Delete the customer record  
            var result = mongoDatabase.GetCollection<Customer>("Customers").DeleteOne<Customer>(k => k.productId == productId);
            if (result.IsAcknowledged == false)
            {
                return BadRequest("Unable to Delete Customer " + productId);
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
        var customer = mongoDatabase.GetCollection<Customer>("Customers").Find<Customer>(k => k.productId == id).FirstOrDefault();
        if (customer == null)
        {
            return NotFound();
        }
        return View(customer);
    }

    [HttpPost]
    public IActionResult Edit(Customer customer, IFormFile[] myfile)
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
            //Build the where condition  
            var filter = Builders<Customer>.Filter.Eq("productId", customer.productId);
            //Build the update statement   
            var updatestatement = Builders<Customer>.Update.Set("productId", customer.productId);
            updatestatement = updatestatement.Set("productName", customer.productName);
            updatestatement = updatestatement.Set("price", customer.price);
            updatestatement = updatestatement.Set("image", customer.image);
            updatestatement = updatestatement.Set("description", customer.description);
            //fetch the details from CustomerDB based on id and pass into view  
            var result = mongoDatabase.GetCollection<Customer>("Customers").UpdateOne(filter, updatestatement);
            if (result.IsAcknowledged == false)
            {
                return BadRequest("Unable to update Customer  " + customer.productName);
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
