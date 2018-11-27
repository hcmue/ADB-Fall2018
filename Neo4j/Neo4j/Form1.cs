using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jProject.model;
using Neo4jProject.database;
using Neo4j.Driver.V1;
using Newtonsoft.Json;
namespace Neo4j
{
    public partial class Form1 : Form
    {
        private readonly IDriver _driver;
        Neo4jUser user { get; set; }
        string uri { get; set; }
        DatabaseAction db;
        public Form1()
        {
            InitializeComponent();
            /*access neo4j driver*/
            user = new Neo4jUser();
            uri = "bolt://localhost:7687";
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user.username, user.password));

             db = new DatabaseAction(_driver);

            cbFactor.DataSource= db.GetAllFactorLabels();
            string select = cbFactor.Text;
            cbRelationship.DataSource = db.GetFactorRelationShipByLabel(select);           
            dgvGraph.DataSource = db.GetFactorDataByLabel(select);
            panelAdd.Hide();
            panelChange.Hide();
            panelSearch.Hide();
        }

       

        private void cbFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cbFactor.Text;
            cbRelationship.DataSource = db.GetFactorRelationShipByLabel(select);
            dgvGraph.DataSource = db.GetFactorDataByLabel(select);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelData.Hide();
            panelChange.Hide();
            panelAdd.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelAdd.Hide();
            panelData.Show();
        }

        private void btnAddCommit_Click(object sender, EventArgs e)
        {
            string name, species, feature, factor, id;
            id = txtID.Text;
            name = txtName.Text;
            species = txtSpecies.Text;
            feature = txtFeature.Text;
            factor = cbFactor.Text;

            db.AddNewFactor(factor,feature,id,name,species);
            panelAdd.Hide();
            dgvGraph.DataSource = db.GetFactorDataByLabel(factor);
            dgvGraph.Refresh();
            panelData.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGraph.SelectedCells.Count > 0) {
                string factor = cbFactor.Text;
                string factorname = factor.Substring(0, factor.Length - 1)+"ID";
                int rowindex = dgvGraph.SelectedCells[0].RowIndex;
                string id = dgvGraph.Rows[rowindex].Cells[factorname].Value.ToString();
              
                db.DeleteFactorByID(id,factor);
                dgvGraph.DataSource = db.GetFactorDataByLabel(factor);
                dgvGraph.Refresh();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvGraph.SelectedCells.Count > 0)
            {
                string factor = cbFactor.Text;
                string factorname = factor.Substring(0, factor.Length - 1) + "ID";
                int rowindex = dgvGraph.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(dgvGraph.Rows[rowindex].Cells[factorname].Value.ToString());


                cbFactor.Enabled = false;
                cbRelationship.Enabled = false;
                txtFeatureChange.Text = dgvGraph.Rows[rowindex].Cells["Features"].Value.ToString();
                txtIDChange.Text = dgvGraph.Rows[rowindex].Cells[factorname].Value.ToString();
                txtNameChange.Text = dgvGraph.Rows[rowindex].Cells["Name"].Value.ToString();
                txtSpeciesChange.Text = dgvGraph.Rows[rowindex].Cells["Species"].Value.ToString();
                txtIDChange.Enabled = false;

                panelData.Hide();
                panelChange.Show();
                
            }
        }

        private void btnChangeBack_Click(object sender, EventArgs e)
        {
            panelChange.Hide();      
            panelData.Show();
        }

        private void btnChangeCommit_Click(object sender, EventArgs e)
        {
            string id, name, species, feature, factor;
            id = txtIDChange.Text;
            name = txtNameChange.Text;
            species = txtSpeciesChange.Text;
            feature = txtFeatureChange.Text;
            factor = cbFactor.Text;

            

            db.UpdateFactor(factor, feature, id, name, species);
            dgvGraph.DataSource = db.GetFactorDataByLabel(factor);
            dgvGraph.Refresh();
            panelChange.Hide();
            panelData.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbProperties.DataSource = new string[] { "ID", "Feature", "Name", "Species"};
            panelData.Hide();
            panelSearch.Show();
        }

        private void btnSearchBack_Click(object sender, EventArgs e)
        {
            panelSearch.Hide();
            panelData.Show();
        }

        private void btnSearchCommit_Click(object sender, EventArgs e)
        {
            string pattern = txtPattern.Text;
            string property = cbProperties.Text;
            string factor = cbFactor.Text;
            dgvGraph.DataSource = db.Search(factor,property, pattern);
            dgvGraph.Refresh();
            panelSearch.Hide();
            panelData.Show();
        }

        private void btnSearchByRelationShip_Click(object sender, EventArgs e)
        {
            string pattern = txtPattern.Text;
            string property = cbProperties.Text;
            string factor = cbFactor.Text;
            string relation = cbRelationship.Text;
            dgvGraph.DataSource = db.SearchByRelationship(factor, property, pattern,relation);
            dgvGraph.Refresh();
            panelSearch.Hide();
            panelData.Show();
        }
    }
}
