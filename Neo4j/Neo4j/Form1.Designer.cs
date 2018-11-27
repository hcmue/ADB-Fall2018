namespace Neo4j
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGraph = new System.Windows.Forms.DataGridView();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFactor = new System.Windows.Forms.ComboBox();
            this.cbRelationship = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddCommit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.panelChange = new System.Windows.Forms.Panel();
            this.btnChangeBack = new System.Windows.Forms.Button();
            this.btnChangeCommit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameChange = new System.Windows.Forms.TextBox();
            this.txtSpeciesChange = new System.Windows.Forms.TextBox();
            this.txtIDChange = new System.Windows.Forms.TextBox();
            this.txtFeatureChange = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbProperties = new System.Windows.Forms.ComboBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.btnSearchCommit = new System.Windows.Forms.Button();
            this.btnSearchByRelationShip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).BeginInit();
            this.panelData.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGraph
            // 
            this.dgvGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraph.Location = new System.Drawing.Point(17, 9);
            this.dgvGraph.Name = "dgvGraph";
            this.dgvGraph.Size = new System.Drawing.Size(576, 132);
            this.dgvGraph.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(51, 35);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(50, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "FACTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RELATIONSHIP";
            // 
            // cbFactor
            // 
            this.cbFactor.FormattingEnabled = true;
            this.cbFactor.Location = new System.Drawing.Point(54, 62);
            this.cbFactor.Name = "cbFactor";
            this.cbFactor.Size = new System.Drawing.Size(121, 21);
            this.cbFactor.TabIndex = 3;
            this.cbFactor.SelectedIndexChanged += new System.EventHandler(this.cbFactor_SelectedIndexChanged);
            // 
            // cbRelationship
            // 
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.Location = new System.Drawing.Point(253, 62);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(121, 21);
            this.cbRelationship.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(447, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(447, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(551, 47);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(551, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dgvGraph);
            this.panelData.Location = new System.Drawing.Point(9, 142);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(624, 154);
            this.panelData.TabIndex = 9;
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnBack);
            this.panelAdd.Controls.Add(this.btnAddCommit);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.txtName);
            this.panelAdd.Controls.Add(this.txtSpecies);
            this.panelAdd.Controls.Add(this.txtID);
            this.panelAdd.Controls.Add(this.txtFeature);
            this.panelAdd.Location = new System.Drawing.Point(6, 179);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(624, 169);
            this.panelAdd.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(521, 75);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddCommit
            // 
            this.btnAddCommit.Location = new System.Drawing.Point(521, 23);
            this.btnAddCommit.Name = "btnAddCommit";
            this.btnAddCommit.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommit.TabIndex = 8;
            this.btnAddCommit.Text = "OK";
            this.btnAddCommit.UseVisualStyleBackColor = true;
            this.btnAddCommit.Click += new System.EventHandler(this.btnAddCommit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Species";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(39, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 13);
            this.label.TabIndex = 5;
            this.label.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Features";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(120, 68);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(367, 20);
            this.txtSpecies.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(367, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtFeature
            // 
            this.txtFeature.Location = new System.Drawing.Point(120, 16);
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(367, 20);
            this.txtFeature.TabIndex = 0;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.btnChangeBack);
            this.panelChange.Controls.Add(this.btnChangeCommit);
            this.panelChange.Controls.Add(this.label3);
            this.panelChange.Controls.Add(this.label6);
            this.panelChange.Controls.Add(this.label7);
            this.panelChange.Controls.Add(this.label8);
            this.panelChange.Controls.Add(this.txtNameChange);
            this.panelChange.Controls.Add(this.txtSpeciesChange);
            this.panelChange.Controls.Add(this.txtIDChange);
            this.panelChange.Controls.Add(this.txtFeatureChange);
            this.panelChange.Location = new System.Drawing.Point(12, 118);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(624, 142);
            this.panelChange.TabIndex = 11;
            // 
            // btnChangeBack
            // 
            this.btnChangeBack.Location = new System.Drawing.Point(511, 84);
            this.btnChangeBack.Name = "btnChangeBack";
            this.btnChangeBack.Size = new System.Drawing.Size(75, 23);
            this.btnChangeBack.TabIndex = 9;
            this.btnChangeBack.Text = "Back";
            this.btnChangeBack.UseVisualStyleBackColor = true;
            this.btnChangeBack.Click += new System.EventHandler(this.btnChangeBack_Click);
            // 
            // btnChangeCommit
            // 
            this.btnChangeCommit.Location = new System.Drawing.Point(511, 32);
            this.btnChangeCommit.Name = "btnChangeCommit";
            this.btnChangeCommit.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCommit.TabIndex = 8;
            this.btnChangeCommit.Text = "OK";
            this.btnChangeCommit.UseVisualStyleBackColor = true;
            this.btnChangeCommit.Click += new System.EventHandler(this.btnChangeCommit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Species";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Features";
            // 
            // txtNameChange
            // 
            this.txtNameChange.Location = new System.Drawing.Point(110, 103);
            this.txtNameChange.Name = "txtNameChange";
            this.txtNameChange.Size = new System.Drawing.Size(367, 20);
            this.txtNameChange.TabIndex = 3;
            // 
            // txtSpeciesChange
            // 
            this.txtSpeciesChange.Location = new System.Drawing.Point(110, 77);
            this.txtSpeciesChange.Name = "txtSpeciesChange";
            this.txtSpeciesChange.Size = new System.Drawing.Size(367, 20);
            this.txtSpeciesChange.TabIndex = 2;
            // 
            // txtIDChange
            // 
            this.txtIDChange.Location = new System.Drawing.Point(110, 51);
            this.txtIDChange.Name = "txtIDChange";
            this.txtIDChange.Size = new System.Drawing.Size(367, 20);
            this.txtIDChange.TabIndex = 1;
            // 
            // txtFeatureChange
            // 
            this.txtFeatureChange.Location = new System.Drawing.Point(110, 25);
            this.txtFeatureChange.Name = "txtFeatureChange";
            this.txtFeatureChange.Size = new System.Drawing.Size(367, 20);
            this.txtFeatureChange.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnSearchByRelationShip);
            this.panelSearch.Controls.Add(this.groupBox1);
            this.panelSearch.Controls.Add(this.btnSearchBack);
            this.panelSearch.Controls.Add(this.btnSearchCommit);
            this.panelSearch.Location = new System.Drawing.Point(44, 92);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(313, 123);
            this.panelSearch.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbProperties);
            this.groupBox1.Controls.Add(this.txtPattern);
            this.groupBox1.Location = new System.Drawing.Point(17, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // cbProperties
            // 
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Location = new System.Drawing.Point(6, 25);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(121, 21);
            this.cbProperties.TabIndex = 3;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(6, 60);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(100, 20);
            this.txtPattern.TabIndex = 8;
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.Location = new System.Drawing.Point(223, 84);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBack.TabIndex = 5;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = true;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // btnSearchCommit
            // 
            this.btnSearchCommit.Location = new System.Drawing.Point(223, 53);
            this.btnSearchCommit.Name = "btnSearchCommit";
            this.btnSearchCommit.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCommit.TabIndex = 4;
            this.btnSearchCommit.Text = "Search";
            this.btnSearchCommit.UseVisualStyleBackColor = true;
            this.btnSearchCommit.Click += new System.EventHandler(this.btnSearchCommit_Click);
            // 
            // btnSearchByRelationShip
            // 
            this.btnSearchByRelationShip.Location = new System.Drawing.Point(223, 21);
            this.btnSearchByRelationShip.Name = "btnSearchByRelationShip";
            this.btnSearchByRelationShip.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByRelationShip.TabIndex = 10;
            this.btnSearchByRelationShip.Text = "Search (R)";
            this.btnSearchByRelationShip.UseVisualStyleBackColor = true;
            this.btnSearchByRelationShip.Click += new System.EventHandler(this.btnSearchByRelationShip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 372);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRelationship);
            this.Controls.Add(this.cbFactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Neo4J";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGraph;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFactor;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFeature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddCommit;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Button btnChangeBack;
        private System.Windows.Forms.Button btnChangeCommit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNameChange;
        private System.Windows.Forms.TextBox txtSpeciesChange;
        private System.Windows.Forms.TextBox txtIDChange;
        private System.Windows.Forms.TextBox txtFeatureChange;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox cbProperties;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.Button btnSearchCommit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchByRelationShip;
    }
}

