using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mongodbwithwinform
{
    public partial class Form3 : Form
    {
        MongoClientSettings settings = new MongoClientSettings();
        public Form3()
        {
            
            InitializeComponent();
        }
        public void LoadData()
        {
            gridNSX.DataSource = null;
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient cilent = new MongoClient();
            var db = cilent.GetDatabase("QLSANPHAM");
            var collection = db.GetCollection<NSX>("NHASANXUAT");
            var query = collection.AsQueryable<NSX>().ToList();
            gridNSX.DataSource = query;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                settings.Server = new MongoServerAddress("localhost", 27017);
                MongoClient cilent = new MongoClient();
                var db = cilent.GetDatabase("QLSANPHAM");
                var collection = db.GetCollection<NSX>("NHASANXUAT");


                NSX n = new NSX();
                n.mansx = txtMaNsx.Text;
                n.tenthuonghieu = txtThuonghieu.Text;

                collection.InsertOne(n);



                LoadData();
            }
            catch
            {
                MessageBox.Show("Không thể thêm !");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridNSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int num = e.RowIndex;
                txtMaNsx.Text = gridNSX.Rows[num].Cells[1].Value.ToString();
                txtThuonghieu.Text = gridNSX.Rows[num].Cells[2].Value.ToString();
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
            var collection = db.GetCollection<NSX>("NHASANXUAT");
            var filter = Builders<NSX>.Filter.Eq("mansx", txtMaNsx.Text);

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
                var collection = db.GetCollection<LSP>("NHASANXUAT");

                var filter = Builders<LSP>.Filter.Eq("mansx", txtMaNsx.Text);
                var update = Builders<LSP>.Update.Set("tenthuonghieu", txtThuonghieu.Text);
                collection.UpdateOne(filter, update);
                LoadData();
            }
            catch
            {
                MessageBox.Show("Không cập nhật được !");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.LoadComboboxNSX();
        }
    }
    public class NSX
    {
        public ObjectId id { get; set; }
        public string mansx { get; set; }
        public string tenthuonghieu { get; set; }
    }
}
