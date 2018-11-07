using Db4objects.Db4o;
using MidTerm2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBMidTermTeam05
{
    public class Database
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer BD
        {
            get { return Db4oEmbedded.OpenFile(DbFileName); }
        }

        public static void Load_Data()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
        }

        //Employee
        public static Boolean AddEmployee(Employee emp)
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            try
            {
                IList<Employee> resultsList = db.Query(delegate (Employee employee)
                {
                    if(employee.ID == emp.ID && employee.HomeBase.CompanyID==emp.HomeBase.CompanyID) return true;
                    return false;
                });
                if (resultsList.Count == 0)//nếu vầy thì nó thêm trùng được
                {
                    db.Store(emp);
                    Console.WriteLine("Success!!!");
                    db.Close();
                    return true;
                }
                else Console.WriteLine("Error ID !!!");
                db.Close();
            }
            catch
            {
                db.Close();
            }
            db.Close();
            return false;

        }
        public static Boolean importCompanyEmployee(Employee em)
        {
            
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            Console.Write("        +CompanyID: ");
            int ID = int.Parse(Console.ReadLine());

            IList<Company> companies = db.Query(delegate (Company company)
            {
                if (company.CompanyID == ID) return true;
                return false;
            });
            if (companies.Count != 0)
            {
                em.HomeBase = companies[0];
                db.Close();
                return true;
            }
            db.Close();
            return false;

        }
        public static void import5Employees()
        {
            for (int i = 1; i < 4; ++i)
            {
                Employee em = new Employee();
                Console.WriteLine("Employee " + i + ": ");
                Console.Write("     -ID: ");
                em.ID = int.Parse(Console.ReadLine());

                Console.Write("     -Full Name: ");
                em.FullName = Console.ReadLine();

                Console.Write("     -Skill: ");
                em.Skill = Console.ReadLine();

                Console.WriteLine("     -HomeBase: ");
                while (!importCompanyEmployee(em))
                {
                    Console.WriteLine("Company is not exist !!!");
                };
                    
                

                Console.Write("     -Salary: ");
                em.Salary = double.Parse(Console.ReadLine());

                em.Manager = null;
                Console.WriteLine();
                if (!Database.AddEmployee(em)) i--;
                //Console.ReadKey();

            }
        }
        //Company
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
        //Print
        //public static void startMain()
        //{
        //    Console.WriteLine("=============== Team 05 =================");
        //    Console.WriteLine("1. Nhap cong ty");
        //    Console.WriteLine("2. Nhap 5 nhan vien");
        //    string a = "";
        //    while(a!="1" || a != "2")
        //    {
        //        //a = "";
        //        Console.WriteLine("Nhap thao tac muon thuc hien :");
        //        a = Console.ReadLine();
        //        Console.WriteLine(a);
        //    }
        //    Console.WriteLine(a);
        //    //if (a == "1") importCompany();
        //    //if (a == "2") import5Employees();
        //}
        public static void printEmployees()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(DbFileName);
            IList<Employee> listEmployee = db.Query(delegate (Employee ee)
            {
                return true;
            });
            Console.WriteLine(" =========== DANH SACH NHAN VIEN:============ ");
            for (int i = 0; i < listEmployee.Count; ++i)
            {
                Console.WriteLine("FullName -- Skill -- Salary -- Company");
                Console.Write(listEmployee[i].ToString()+" -- ");
                Console.WriteLine(listEmployee[i].HomeBase.CompanyName);
                Console.WriteLine();
                
            }
            db.Close();
            Console.ReadKey();
        }
        //cau 7
        public static void cau7()
        {
            IObjectContainer DB = Db4oEmbedded.OpenFile(DbFileName);
            IList<Employee> ee = DB.Query(delegate (Employee e)
            {
                return e.Salary > 500;
            });

            List<Company> c = new List<Company>();
            foreach (Employee e in ee)
            {
                int count = 0;
                foreach (Employee e2 in ee)
                {
                    if (e.ID != e2.ID && e.HomeBase.CompanyID == e2.HomeBase.CompanyID)
                    {
                        count++;
                    }
                }
                if (count > 2 && checkExist(c, e.HomeBase))
                {
                    c.Add(e.HomeBase);
                }
            }
            Console.WriteLine("======== DANH SACH CONG TY (NHAN VIEN >2 va LUONG >500 USD) =======");
            foreach (Company com in c)
            {

                Console.WriteLine(" -Company ID: " + com.CompanyID);
             
                Console.WriteLine(" -Company Name: " + com.ToString());
                Console.WriteLine();
        
            }
            DB.Close();
            Console.ReadKey();
        }
        public static bool checkExist(List<Company> l, Company c)
        {
            for (int i = 0; i < l.Count; ++i)
            {
                if (l[i].CompanyID == c.CompanyID) return false;
            }
            return true;
        }
    }
}
