using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
namespace ADBTeam08_DB4O
{
    class MyDatabase
    {
        public static IObjectContainer objContainer = null;
        public static string FileName
        {
            get;
            set;
        }
        public static void OpenDB()
        {
            objContainer = Db4oEmbedded.OpenFile(FileName);
        }
        public static void CloseDB()
        {
            objContainer.Close();
        }

        public static void Store(object obj)
        {
            objContainer.Store(obj);
        }
    }
}
