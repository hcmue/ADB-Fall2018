using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodbwithwinform
{
    public partial class Form1 : Form
    {
        MongoClientSettings settings = new MongoClientSettings();
        public void LoadData()
        {
            gridControlSanPham.DataSource = null;
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<SP>("SANPHAM");
            var query = collection.AsQueryable<SP>().ToList();
            gridControlSanPham.DataSource = query;
            LoadCombobox();

        }

        public void LoadCombobox()
        {
            cbloaisanpham.DataSource = null;
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<LSP>("LOAISANPHAM");
            var query = collection.AsQueryable<LSP>().ToList();

            cbloaisanpham.DataSource = query;
            cbloaisanpham.DisplayMember = "tenloai";
            cbloaisanpham.ValueMember = "maloai";
        }

        public void LoadComboboxNSX()
        {
            cbNSX.DataSource = null;
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<NSX>("NHASANXUAT");
            var query = collection.AsQueryable<NSX>().ToList();

            cbNSX.DataSource = query;
            cbNSX.DisplayMember = "tenthuonghieu";
            cbNSX.ValueMember = "mansx";
        }
        public Form1()
        {
            InitializeComponent();
            LoadData();
            LoadCombobox();
            LoadComboboxNSX();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnnhaploaiSP_Click(object sender, EventArgs e)
        {
          
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<SP>("SANPHAM");

                SP s = new SP();
                s.masanpham = txtmasanpham.Text;
                s.tensanpham = txttensanpham.Text;
                s.loaisanpham = cbloaisanpham.Text;

                collection.InsertOne(s);

                LoadData();
            }
            catch
            {
                MessageBox.Show("Không thể thêm !");
            }
        }
        int dem = 0;
        private void gridControlSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                int num = e.RowIndex;
                txtmasanpham.Text = gridControlSanPham.Rows[num].Cells[1].Value.ToString();
                txttensanpham.Text = gridControlSanPham.Rows[num].Cells[2].Value.ToString();
                cbloaisanpham.Text = gridControlSanPham.Rows[num].Cells[3].Value.ToString();
                cbNSX.Text = gridControlSanPham.Rows[num].Cells[4].Value.ToString();
            }
            catch
            {
                int a = e.ColumnIndex;
                
                if (a == 1)
                {
                    settings.Server = new MongoServerAddress("localhost", 27017);
                    MongoClient cilent = new MongoClient();
                    var db = cilent.GetDatabase("QLSANPHAM");
                    var collection = db.GetCollection<SP>("SANPHAM");

                    var filter = Builders<SP>.Filter.Exists("masanpham");
                    if (dem % 2 == 0)
                    {
                        var sort = Builders<SP>.Sort.Ascending("masanpham");
                        var document = collection.Find(filter).Sort(sort).ToList();

                        gridControlSanPham.DataSource = null;
                        gridControlSanPham.DataSource = document;
                        dem++;
                    }
                    else
                    {
                        var sort = Builders<SP>.Sort.Descending("masanpham");
                        var document = collection.Find(filter).Sort(sort).ToList();

                        gridControlSanPham.DataSource = null;
                        gridControlSanPham.DataSource = document;
                        dem++;
                    }
                    

                }
                else if (a == 2)
                {
                    settings.Server = new MongoServerAddress("localhost", 27017);
                    MongoClient cilent = new MongoClient();
                    var db = cilent.GetDatabase("QLSANPHAM");
                    var collection = db.GetCollection<SP>("SANPHAM");

                    var filter = Builders<SP>.Filter.Exists("tensanpham");
                    if (dem % 2 == 0)
                    {
                        var sort = Builders<SP>.Sort.Ascending("tensanpham");
                        var document = collection.Find(filter).Sort(sort).ToList();

                        gridControlSanPham.DataSource = null;
                        gridControlSanPham.DataSource = document;
                        dem++;
                    }
                    else
                    {
                        var sort = Builders<SP>.Sort.Descending("tensanpham");
                        var document = collection.Find(filter).Sort(sort).ToList();

                        gridControlSanPham.DataSource = null;
                        gridControlSanPham.DataSource = document;
                        dem++;
                    }
                }
                else
                {
                    MessageBox.Show("Không được chọn !");
                }
               
            }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<SP>("SANPHAM");
            var filter = Builders<SP>.Filter.Eq("masanpham",txtmasanpham.Text);

            collection.DeleteOne(filter);
            LoadData();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<SP>("SANPHAM");

                var filter = Builders<SP>.Filter.Eq("masanpham", txtmasanpham.Text);
                var update = Builders<SP>.Update.Set("tensanpham", txttensanpham.Text).Set("loaisanpham", cbloaisanpham.Text).Set("tenthuonghieu",cbNSX.Text);
                collection.UpdateOne(filter, update);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được !");
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (cbTimkiem.SelectedIndex == 0)
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<SP>("SANPHAM");

                var filter = Builders<SP>.Filter.Eq("loaisanpham", cbloaisanpham.Text);
                var document = collection.Find(filter).ToList();

                gridControlSanPham.DataSource = null;
                gridControlSanPham.DataSource = document;
            }
            if (cbTimkiem.SelectedIndex == 1)
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<SP>("SANPHAM");

                var filter = Builders<SP>.Filter.Eq("tenthuonghieu", cbNSX.Text);
                var document = collection.Find(filter).ToList();

                gridControlSanPham.DataSource = null;
                gridControlSanPham.DataSource = document;
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadCombobox();
            LoadComboboxNSX();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cbloaisanpham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNSX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(this);
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog(this);
        }

        private void cbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    public class SP
    {
        public ObjectId id { get; set; }
        public string masanpham { get; set; }
        public string tensanpham { get; set; }
        public string loaisanpham { get; set; }
        public string tenthuonghieu { get; set; }
    }
   
}
