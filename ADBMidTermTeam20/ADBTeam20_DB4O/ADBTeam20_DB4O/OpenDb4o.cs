using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeam20_DB4O
{
	public class OpenDb4o
	{
		public static IObjectContainer Database => Db4oEmbedded.OpenFile("Team20_EmployeeManager");
	}
}
