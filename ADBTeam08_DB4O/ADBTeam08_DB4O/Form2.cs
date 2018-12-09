using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidTerm2016;
namespace ADBTeam08_DB4O
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khoa m = new Khoa
            {
                MaKhoa = textBox1.Text
            };
        MyDatabase.Store(m);
        }
    }
}
