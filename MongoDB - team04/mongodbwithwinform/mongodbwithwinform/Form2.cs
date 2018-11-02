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
using MongoDB.Driver.Builders;
using MongoDB.Driver.Operations;
using MongoDB.Driver.Linq;

namespace mongodbwithwinform
{
    public partial class Form2 : Form
    {
        MongoClientSettings settings = new MongoClientSettings();
        public void LoadData()
        {

            gridControlLoad.DataSource = null;
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<LSP>("LOAISANPHAM");
            var query = collection.AsQueryable<LSP>().ToList();
            gridControlLoad.DataSource = query;
        }
        public Form2()
        {
            InitializeComponent();
            LoadData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<LSP>("LOAISANPHAM");


                LSP l = new LSP();
                l.maloai = txtmaloai.Text;
                l.tenloai = txttenloai.Text;

                collection.InsertOne(l);



                LoadData();
            }
            catch
            {
                MessageBox.Show("Không thể thêm !");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.LoadCombobox();
            this.Close();
        }

        private void gridControlLoad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int num = e.RowIndex;
                txtmaloai.Text = gridControlLoad.Rows[num].Cells[1].Value.ToString();
                txttenloai.Text = gridControlLoad.Rows[num].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không được chọn !");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<LSP>("LOAISANPHAM");
            var filter = Builders<LSP>.Filter.Eq("maloai", txtmaloai.Text);

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
                var collection = db.GetCollection<LSP>("LOAISANPHAM");

                var filter = Builders<LSP>.Filter.Eq("maloai", txtmaloai.Text);
                var update = Builders<LSP>.Update.Set("tenloai", txttenloai.Text);
                collection.UpdateOne(filter, update);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được !");
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    public class LSP
    {
        public ObjectId id { get; set; }
        public string maloai { get; set; }
        public string tenloai { get; set; }

    }
}
