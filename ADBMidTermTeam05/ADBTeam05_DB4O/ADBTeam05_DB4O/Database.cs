using Db4objects.Db4o;
using MidTerm2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeam05_DB4O
{
    public class Database
    {
        public static string DbFileName { get; set; }
        public static IObjectContainer BD
        {
            get
            {
                return Db4oEmbedded.OpenFile(DbFileName);
            }
        }

        public static void importCompany()
        {
            Console.Write("- Company ID: ");
            int companyID =int.Parse(Console.ReadLine());
            Console.Write("- Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("- House Number: ");
            string house = Console.ReadLine();
            Console.Write("- Company ID: ");
            int id = int.Parse(Console.ReadLine());
        }

        //cau 6
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
                Console.WriteLine(listEmployee[i].ToString());
            }
            db.Close();
        }


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
