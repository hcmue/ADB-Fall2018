using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using MidTerm2016;

namespace ADBTeam08_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MyDatabase.FileName = "ADBTeam08.db";
            MyDatabase.OpenDB();
            /* IList<Khoa> emps = MyDatabase.objContainer.Query(delegate (Khoa m) {
   return true;
             });
             comboBox1.DataSource = emps.ToList();
             comboBox1.DisplayMember = "MaKhoa";
             comboBox1.ValueMember = "MaKhoa";
             InitializeComponent();*/
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyDatabase.CloseDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonHoc m = new MonHoc
            {
                MaMH = int.Parse(textBox1.Text),
                TenMon = textBox2.Text,
                SoTinChi = double.Parse(textBox5.Text)

        };
        MyDatabase.Store(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IList<MonHoc> emps = MyDatabase.objContainer.Query(delegate (MonHoc m) {
                
                return true;
            });
            dataGridView1.DataSource = emps.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IList<MonHoc> emps = MyDatabase.objContainer.Query(delegate (MonHoc emp) {
              
                return (emp.SoTinChi > 3);

                
                
            });
            dataGridView1.DataSource = emps.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.ShowDialog();
        }
    }
}
