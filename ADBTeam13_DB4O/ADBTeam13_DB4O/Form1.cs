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


namespace ADBTeam13_DB4O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        

        private void loadDanhSachKhoa()
        {
            dgvDSKhoa.DataSource = DataHelper.GetKhoas();
        }

        //để tạo ra 1 option rỗng ở combobox
        

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDanhSachKhoa();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            DataHelper.addKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtDiaChi.Text, txtSDT.Text);
            MessageBox.Show("Da them khoa thanh cong");
        }

        private void btnLoadAllKhoa_Click(object sender, EventArgs e)
        {
            loadDanhSachKhoa();
            LoadAllMonhoc();
        }

        private void dgvDSKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvDSKhoa.Rows[e.RowIndex];
            if(e.RowIndex >= 0)
            {
                txtMaKhoa.Text = dr.Cells[0].Value.ToString();
                txtTenKhoa.Text = dr.Cells[1].Value.ToString();
                txtDiaChi.Text = dr.Cells[2].Value.ToString();
                txtSDT.Text = dr.Cells[3].Value.ToString();
                txtTenKhoaQL.Text = dr.Cells[1].Value.ToString();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            DataHelper.addSubject(int.Parse(txtMaMH.Text), txtTenMH.Text, txtMota.Text, txtTenKhoaQL.Text, txtTenMHDK.Text, int.Parse(nbrudSTC.Value.ToString()));
            MessageBox.Show("Them mon hoc thanh cong");
            LoadAllMonhoc();
        }

        private void dgvDSMonHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvDSMonHoc .Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtTenMHDK.Text = dr.Cells[1].Value.ToString();
            }
        }

        private void btnLoadALLMon_Click(object sender, EventArgs e)
        {
            LoadAllMonhoc();
        }

        private void LoadAllMonhoc()
        {
            dgvDSMonHoc.DataSource = DataHelper.GetAllSubject();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            
        }


    }
}
