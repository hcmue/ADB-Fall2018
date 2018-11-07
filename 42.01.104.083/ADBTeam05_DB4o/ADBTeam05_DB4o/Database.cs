using Db4objects.Db4o;
using MidTerm2017;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADBTeam05_DB4o
{
    class Database
    {
        public static string DbFileName { get; set; }
        public static void importCompany()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            for (int i = 0; i < 3; ++i)
            {
                Console.Write(" -Company ID: ");
                int companyID = int.Parse(Console.ReadLine());
                Console.Write(" -Company Name: ");
                string companyName = Console.ReadLine();
                Console.Write(" -House Number: ");
                string houseNumber = Console.ReadLine();
                Console.Write(" -Street: ");
                string street = Console.ReadLine();
                Console.Write(" -City: ");
                string city = Console.ReadLine();
                Console.WriteLine();
                Company company = new Company
                {
                    CompanyID = companyID,
                    CompanyName = companyName,
                    HouseNumber = houseNumber,
                    Street = street,
                    City = city
                };
                if (!check(company, db)) --i;
            }
            db.Close();
        }
        public static bool check(Company c, IObjectContainer db)
        {
            IList<Company> res = db.Query(delegate (Company company)
            {
                return (c.CompanyID == company.CompanyID);
            });
            if (res.Count == 0)
            {
                db.Store(c);
                Console.WriteLine("Success!!!");
                return true;
            }
            else Console.WriteLine("Error !!!");
            return false;

        }
    }
}
