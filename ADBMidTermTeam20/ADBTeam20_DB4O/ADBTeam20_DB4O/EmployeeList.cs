using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o.Linq;

namespace ADBTeam20_DB4O
{
	public partial class EmployeeList : Form
	{
		public EmployeeList()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = Db4oEmbedded.OpenFile("Team20_EmployeeManager.yap"))
			{
				var com = new Company
				{
					CompanyID = int.Parse(companyIDComboBox.Text)
				};
				IObjectSet result = db.QueryByExample(com);
				var compa = result[0];
				var em = new Employee
				{
					ID = int.Parse(iDTextBox.Text),
					FullName = fullNameTextBox.Text,
					HomeBase =(Company) compa,
					Salary=Convert.ToDouble(salaryTextBox.Text),
					Skill=skillTextBox.Text
				};
				db.Store(em);
				db.Commit();
				db.Close();
				laydulieu();
			}

		}
		public void laydulieu()
		{
			using (var db = Db4oEmbedded.OpenFile("Team20_EmployeeManager.yap"))
			{
				var result = from Employee em in db select em;
				employeeBindingSource.DataSource = result.ToList();
			}
		}
		private void EmployeeList_Load(object sender, EventArgs e)
		{
			laydulieu();
			using (var db = Db4oEmbedded.OpenFile("Team20_EmployeeManager.yap")) {
				var result = from Company c in db select c.CompanyID;
				companyIDComboBox.DataSource = result.ToList();
					   }
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
