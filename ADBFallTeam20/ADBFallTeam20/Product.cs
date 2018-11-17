using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBFallTeam20
{
	public class Product
	{
		[DisplayName("Mã sản phẩm")]
		public string _id { get; set; }
		[DisplayName("Tên sản phẩm")]
		public string Name { get; set; }
		public string _rev { get; set; }
		[DisplayName("Giá(VNĐ)")]
		public double Price { get; set; }
		[DisplayName("Giảm giá(%)")]
		public float Sale { get; set; }
		[DisplayName("Đơn vị")]
		public string Unit { get; set; }
	}
}
