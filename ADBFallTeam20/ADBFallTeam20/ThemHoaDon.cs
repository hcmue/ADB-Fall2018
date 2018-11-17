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
	public partial class ThemHoaDon : Form
	{
		public ThemHoaDon()
		{
			InitializeComponent();
		}
		public async void LoadData()
		{
			var db = new DBHelper();
			List<Product> data = new List<Product>();
			data = await db.GetList<Product>();
			productBindingSource.DataSource = data;
			
		}
		private void ThemHoaDon_Load(object sender, EventArgs e)
		{
			_idTextBox.Text = "HD" + DateTime.Now.ToString("ddMMyyhhmmss");
			dateDateTimePicker.Value = DateTime.Now;
			LoadData();
		}
		public List<Item> list = new List<Item>();
		public bool Check(Item item)
		{
			foreach (var i in list)
			{
				if (i._id == item._id)
				{
					i.Quatity++;
					i.UpdatePrice();
					return true;
				}
			}
			return false;
		}
		

		private void productDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			itemBindingSource.AllowNew = true;
			Product pro = (Product)productBindingSource.Current;
			if (pro._id == null)
			{
				return;
			}
			Item item = new Item(pro);
			if (!Check(item))
			{
				list.Add(item);
			}
			itemBindingSource.ResetBindings(true);
			itemBindingSource.DataSource = list;
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var Invo = new Invoice
			{
				_id = _idTextBox.Text,
				Date = dateDateTimePicker.Value.ToString("dd/MM/yyyy"),
				CustomerName = customerNameTextBox.Text,
				ItemList = list
			};
			var db = new DBHelper();
			string _rev = await db.isId(_idTextBox.Text);
			if (_rev != "")
			{
				Invo._rev = _rev;
			}
			db.Update<Invoice>(Invo);
		}

		private async void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (nameSearch.Text == "")
			{
				LoadData();
			}
			else
			{
				string name = nameSearch.Text;
				var db = new DBHelper();
				List<Product> data = new List<Product>();
				data = await db.GetList<Product>(name);
				productBindingSource.DataSource = data;
			}
			
		}
	}
}
