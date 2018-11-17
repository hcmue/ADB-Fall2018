using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBFallTeam20
{
	public class Item : Product
	{
		[DisplayName("Số lượng")]
		public int Quatity { get; set; }
		[DisplayName("Giá thành")]
		public double TotalPrice { get; set; }

		public Item() { }

		public Item(Product pro)
		{
			this._id = pro._id;
			this.Price = pro.Price;
			this.Name = pro.Name;
			this.Quatity = 1;
			this.Sale = pro.Sale;
			this.Unit = pro.Unit;
			TotalPrice = Quatity * Price * (1 - Sale/100);
		}
		public void UpdatePrice()
		{
			TotalPrice = Quatity * Price * (1 - Sale / 100);
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
