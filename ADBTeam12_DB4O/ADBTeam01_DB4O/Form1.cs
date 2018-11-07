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
using Db4objects.Db4o;
using MidTerm2017;

namespace ADBTeam01_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = Db4oEmbedded.OpenFile("4201104046_EmployeeManager"))
            {
                Company c = new Company();
                c.CompanyID = Convert.ToInt32(companyIDTextBox.Text);
                c.CompanyName = companyNameTextBox.Text;
                c.City = cityTextBox.Text;
                c.HouseNumber = houseNumberTextBox.Text;
                c.Street = streetTextBox.Text;
                Employee b = new Employee();
                b.Manager = new Employee();
                b.Manager.ID = Convert.ToInt32(iDTextBox1.Text);
                b.Manager.FullName = fullNameTextBox1.Text;
                b.Manager.Salary = Convert.ToInt32(salaryTextBox1.Text);
                b.Manager.Skill = skillTextBox1.Text;
                b.Manager.HomeBase = c;
                b.Manager.Manager = null;
                Employee a = new Employee();
                a.ID = Convert.ToInt32(iDTextBox.Text);
                a.Salary = Convert.ToDouble(salaryTextBox.Text);
                a.FullName = fullNameTextBox.Text;
                a.Skill = skillTextBox.Text;
                a.HomeBase = c;
                a.Manager = b;
                db.Store(a);
                db.Commit();
                db.Close();
                laydulieu();
            }
        }
        public void laydulieu()
        {
            using (var db = Db4oEmbedded.OpenFile("4201104046_EmployeeManager"))
            {
                var result = from Employee a in db select a;
                employeeBindingSource.DataSource = result.ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = Db4oEmbedded.OpenFile("4201104046_EmployeeManager"))
            {
                var result = from Employee a in db select a;
                employeeBindingSource.DataSource = result.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
