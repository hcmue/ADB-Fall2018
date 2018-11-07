namespace ADBTeam20_DB4O
{
	partial class CompanyList
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label companyIDLabel;
			System.Windows.Forms.Label companyNameLabel;
			System.Windows.Forms.Label houseNumberLabel;
			System.Windows.Forms.Label streetLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.companyDataGridView = new System.Windows.Forms.DataGridView();
			this.insert = new System.Windows.Forms.Button();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.companyIDTextBox = new System.Windows.Forms.TextBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.houseNumberTextBox = new System.Windows.Forms.TextBox();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.houseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			cityLabel = new System.Windows.Forms.Label();
			companyIDLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			houseNumberLabel = new System.Windows.Forms.Label();
			streetLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(108, 30);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 13;
			cityLabel.Text = "City:";
			// 
			// companyIDLabel
			// 
			companyIDLabel.AutoSize = true;
			companyIDLabel.Location = new System.Drawing.Point(108, 56);
			companyIDLabel.Name = "companyIDLabel";
			companyIDLabel.Size = new System.Drawing.Size(68, 13);
			companyIDLabel.TabIndex = 15;
			companyIDLabel.Text = "Company ID:";
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(108, 82);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 17;
			companyNameLabel.Text = "Company Name:";
			// 
			// houseNumberLabel
			// 
			houseNumberLabel.AutoSize = true;
			houseNumberLabel.Location = new System.Drawing.Point(108, 108);
			houseNumberLabel.Name = "houseNumberLabel";
			houseNumberLabel.Size = new System.Drawing.Size(81, 13);
			houseNumberLabel.TabIndex = 19;
			houseNumberLabel.Text = "House Number:";
			// 
			// streetLabel
			// 
			streetLabel.AutoSize = true;
			streetLabel.Location = new System.Drawing.Point(108, 134);
			streetLabel.Name = "streetLabel";
			streetLabel.Size = new System.Drawing.Size(38, 13);
			streetLabel.TabIndex = 21;
			streetLabel.Text = "Street:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.companyDataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 174);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 170);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách công ty";
			// 
			// companyDataGridView
			// 
			this.companyDataGridView.AutoGenerateColumns = false;
			this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyIDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.houseNumberDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
			this.companyDataGridView.DataSource = this.companyBindingSource;
			this.companyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.companyDataGridView.Location = new System.Drawing.Point(3, 16);
			this.companyDataGridView.Name = "companyDataGridView";
			this.companyDataGridView.Size = new System.Drawing.Size(794, 151);
			this.companyDataGridView.TabIndex = 0;
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(445, 39);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(75, 23);
			this.insert.TabIndex = 12;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(199, 27);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 14;
			// 
			// companyIDTextBox
			// 
			this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyID", true));
			this.companyIDTextBox.Location = new System.Drawing.Point(199, 53);
			this.companyIDTextBox.Name = "companyIDTextBox";
			this.companyIDTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyIDTextBox.TabIndex = 16;
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(199, 79);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.companyNameTextBox.TabIndex = 18;
			// 
			// houseNumberTextBox
			// 
			this.houseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "HouseNumber", true));
			this.houseNumberTextBox.Location = new System.Drawing.Point(199, 105);
			this.houseNumberTextBox.Name = "houseNumberTextBox";
			this.houseNumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.houseNumberTextBox.TabIndex = 20;
			// 
			// streetTextBox
			// 
			this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Street", true));
			this.streetTextBox.Location = new System.Drawing.Point(199, 131);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(100, 20);
			this.streetTextBox.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(411, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 23);
			this.button1.TabIndex = 23;
			this.button1.Text = "Danh sách nhân viên";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// companyBindingSource
			// 
			this.companyBindingSource.DataSource = typeof(ADBTeam20_DB4O.Company);
			// 
			// companyIDDataGridViewTextBoxColumn
			// 
			this.companyIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
			this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
			this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
			// 
			// companyNameDataGridViewTextBoxColumn
			// 
			this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
			this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
			this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
			// 
			// houseNumberDataGridViewTextBoxColumn
			// 
			this.houseNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.houseNumberDataGridViewTextBoxColumn.DataPropertyName = "HouseNumber";
			this.houseNumberDataGridViewTextBoxColumn.HeaderText = "HouseNumber";
			this.houseNumberDataGridViewTextBoxColumn.Name = "houseNumberDataGridViewTextBoxColumn";
			// 
			// streetDataGridViewTextBoxColumn
			// 
			this.streetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
			this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
			this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
			this.cityDataGridViewTextBoxColumn.HeaderText = "City";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(445, 102);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 24;
			this.button2.Text = "Xuat Cau 7";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CompanyList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 344);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(cityLabel);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(companyIDLabel);
			this.Controls.Add(this.companyIDTextBox);
			this.Controls.Add(companyNameLabel);
			this.Controls.Add(this.companyNameTextBox);
			this.Controls.Add(houseNumberLabel);
			this.Controls.Add(this.houseNumberTextBox);
			this.Controls.Add(streetLabel);
			this.Controls.Add(this.streetTextBox);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.groupBox1);
			this.Name = "CompanyList";
			this.Text = "Danh Sách Công Ty";
			this.Load += new System.EventHandler(this.CompanyList_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView companyDataGridView;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.BindingSource companyBindingSource;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.TextBox companyIDTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.TextBox houseNumberTextBox;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

