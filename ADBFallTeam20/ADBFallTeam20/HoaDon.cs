using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace ADBFallTeam20
{
	public partial class HoaDon : Form
	{
		public HoaDon()
		{
			InitializeComponent();
		}

		private async void HoaDon_Load(object sender, EventArgs e)
		{
			var db = new DBHelper();
			var result = await db.GetListInvoice<Invoice>();
			invoiceBindingSource.DataSource = result;
			itemListBindingSource.ResetBindings(true);

		}

		private async void invoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			Invoice invo = (Invoice)invoiceBindingSource.Current;
			string id = invo._id;
			var db = new DBHelper();
			var result = await db.GetListItem<Item>(id) as List<Item>;
			dateDateTimePicker.Value = DateTime.ParseExact(invo.Date, "dd/MM/yyyy",
									   System.Globalization.CultureInfo.InvariantCulture);
			itemListBindingSource.ResetBindings(true);
			itemListBindingSource.DataSource = result;
		}
	}
}
