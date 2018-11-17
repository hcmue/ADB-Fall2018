using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBFallTeam20
{
	public class Invoice
	{
		[DisplayName("Mã hoá đơn")]
		public string _id { get; set; }
		public string _rev { get; set; }
		[DisplayName("Tên khách hàng")]
		public string CustomerName { get; set; }
		[DisplayName("Ngày lập")]
		public string Date { get; set; }
		public Invoice()
		{
			Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
		}
		public List<Item> ItemList { get; set; }
	}
}
