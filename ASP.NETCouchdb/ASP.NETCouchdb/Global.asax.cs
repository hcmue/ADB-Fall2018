using ASP.NETCouchdb.Models;
using RedBranch.Hammock;
using RedBranch.Hammock.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ASP.NETCouchdb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            InitDb();
        }

        private void InitDb()
        {
            Connection connection = new Connection(new Uri("http://localhost:5984"));
            if (!connection.ListDatabases().Contains("eshop"))
            {
                connection.CreateDatabase("eshop");


                //if (!connection.ListDatabases().Any(db => db == Config.CLOTHES_DB_NAME))
                //{


                Session session = connection.CreateSession("eshop");

                string allClothesScript =
                    File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/all-product-map.js"));

                string colorsMap =
                    File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/type-map.js"));

                string allspkey =
                    File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/all-sanphamkey.js"));

                string detail =
                   File.ReadAllText(HttpContext.Current.Server.MapPath("~/App_Data/detail.js"));

                DesignDocument designDocument = new DesignDocument();
                designDocument.Language = "javascript";
                designDocument.Views = new Dictionary<string, View>();

                designDocument.Views.Add("all-sanpham", new View { Map = allClothesScript });
                designDocument.Views.Add("loai-breakdown", new View { Map = colorsMap });
                designDocument.Views.Add("all-sanphamkey", new View { Map = allspkey });
                designDocument.Views.Add("detail-sanpham", new View { Map = detail });
                session.Save(designDocument, "_design/sanpham-queries");
                //}
            }
        }
    }
}
