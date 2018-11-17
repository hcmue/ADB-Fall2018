using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBFallTeam20
{
	public partial class QLBH : Form
	{
		public QLBH()
		{
			InitializeComponent();
		}

		private async void insert_Click(object sender, EventArgs e)
		{
			var db = new DBHelper();
			int maxid =await db.getId();
			var data = new Product
			{
				_id = maxid.ToString(),
				Name = this.nameTextBox.Text,
				Price = double.Parse(this.priceTextBox.Text),
				Sale = float.Parse(this.saleTextBox.Text),
				Unit = this.unitTextBox.Text
			};

			var mess = await db.InsertDoc<Product>(data);
			if (mess.IsSuccess)
			{
				MessageBox.Show("Thêm thành công");
			}
			else MessageBox.Show("Không thành công");
			LoadData();
		}

		public async void LoadData()
		{
			var db = new DBHelper();
			List<Product> data = new List<Product>();
			data = await db.GetList<Product>();
			productBindingSource.DataSource = data;
		}
		private void QLBH_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void delete_Click(object sender, EventArgs e)
		{
			Product pro = (Product)productBindingSource.Current;
			var db = new DBHelper();
			db.Delete<Product>(pro);
			LoadData();
		}

		private async void edit_Click(object sender, EventArgs e)
		{
			Product pro = new Product();
			pro = (Product)this.productBindingSource.Current;
			var db = new DBHelper();
			db.Update<Product>(pro);
			List<Product> data = new List<Product>();
			data = await db.GetList<Product>();
			productBindingSource.ResetBindings(true);
			productBindingSource.DataSource = data;
		}

		private void insertBill_Click(object sender, EventArgs e)
		{
			using(var hd = new ThemHoaDon())
			{
				hd.ShowDialog();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var hd = new HoaDon())
			{
				hd.ShowDialog();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
