using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBMidTermTeam05
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.DbFileName = "Team05_EmployeeManager.dat";
            //Database.startMain();
            Database.importCompany();
            Database.import5Employees();
            Database.printEmployees();
            Database.cau7();
        }
    }
}
