namespace ADBFallTeam20
{
	partial class ThemHoaDon
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
			System.Windows.Forms.Label _idLabel;
			System.Windows.Forms.Label customerNameLabel;
			System.Windows.Forms.Label dateLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.productDataGridView = new System.Windows.Forms.DataGridView();
			this.itemDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this._idTextBox = new System.Windows.Forms.TextBox();
			this.customerNameTextBox = new System.Windows.Forms.TextBox();
			this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.nameSearch = new System.Windows.Forms.TextBox();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			_idLabel = new System.Windows.Forms.Label();
			customerNameLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// _idLabel
			// 
			_idLabel.AutoSize = true;
			_idLabel.Location = new System.Drawing.Point(39, 18);
			_idLabel.Name = "_idLabel";
			_idLabel.Size = new System.Drawing.Size(68, 13);
			_idLabel.TabIndex = 9;
			_idLabel.Text = "Mã hoá đơn:";
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Location = new System.Drawing.Point(39, 44);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(89, 13);
			customerNameLabel.TabIndex = 11;
			customerNameLabel.Text = "Tên khách hàng:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new System.Drawing.Point(39, 71);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(52, 13);
			dateLabel.TabIndex = 13;
			dateLabel.Text = "Ngày lập:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.productDataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox1.Location = new System.Drawing.Point(759, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(555, 470);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách sản phẩm";
			// 
			// productDataGridView
			// 
			this.productDataGridView.AutoGenerateColumns = false;
			this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.productDataGridView.DataSource = this.productBindingSource;
			this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productDataGridView.Location = new System.Drawing.Point(3, 16);
			this.productDataGridView.Name = "productDataGridView";
			this.productDataGridView.Size = new System.Drawing.Size(549, 451);
			this.productDataGridView.TabIndex = 0;
			this.productDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productDataGridView_CellMouseDoubleClick);
			// 
			// itemDataGridView
			// 
			this.itemDataGridView.AllowUserToOrderColumns = true;
			this.itemDataGridView.AutoGenerateColumns = false;
			this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn7});
			this.itemDataGridView.DataSource = this.itemBindingSource;
			this.itemDataGridView.Location = new System.Drawing.Point(5, 151);
			this.itemDataGridView.Name = "itemDataGridView";
			this.itemDataGridView.Size = new System.Drawing.Size(734, 299);
			this.itemDataGridView.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(441, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Lưu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// _idTextBox
			// 
			this._idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "_id", true));
			this._idTextBox.Enabled = false;
			this._idTextBox.Location = new System.Drawing.Point(134, 15);
			this._idTextBox.Name = "_idTextBox";
			this._idTextBox.Size = new System.Drawing.Size(200, 20);
			this._idTextBox.TabIndex = 10;
			// 
			// customerNameTextBox
			// 
			this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerName", true));
			this.customerNameTextBox.Location = new System.Drawing.Point(134, 41);
			this.customerNameTextBox.Name = "customerNameTextBox";
			this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
			this.customerNameTextBox.TabIndex = 12;
			// 
			// dateDateTimePicker
			// 
			this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
			this.dateDateTimePicker.Location = new System.Drawing.Point(134, 67);
			this.dateDateTimePicker.Name = "dateDateTimePicker";
			this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateDateTimePicker.TabIndex = 14;
			// 
			// nameSearch
			// 
			this.nameSearch.Location = new System.Drawing.Point(587, 64);
			this.nameSearch.Name = "nameSearch";
			this.nameSearch.Size = new System.Drawing.Size(152, 20);
			this.nameSearch.TabIndex = 15;
			this.nameSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(ADBFallTeam20.Invoice);
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "_id";
			this.dataGridViewTextBoxColumn8.HeaderText = "Mã sản phẩm";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn9.HeaderText = "Tên sản phẩm";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Quatity";
			this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Price";
			this.dataGridViewTextBoxColumn11.HeaderText = "Giá(VNĐ)";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "Sale";
			this.dataGridViewTextBoxColumn12.HeaderText = "Giảm giá(%)";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn13.HeaderText = "Đơn vị";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "TotalPrice";
			this.dataGridViewTextBoxColumn7.HeaderText = "Giá thành";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// itemBindingSource
			// 
			this.itemBindingSource.DataSource = typeof(ADBFallTeam20.Item);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
			this.dataGridViewTextBoxColumn4.HeaderText = "Giá(VNĐ)";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Sale";
			this.dataGridViewTextBoxColumn5.HeaderText = "Giảm giá(%)";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn6.HeaderText = "Đơn vị";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(ADBFallTeam20.Product);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(483, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Tìm kiếm sản phẩm";
			// 
			// ThemHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 470);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameSearch);
			this.Controls.Add(_idLabel);
			this.Controls.Add(this._idTextBox);
			this.Controls.Add(customerNameLabel);
			this.Controls.Add(this.customerNameTextBox);
			this.Controls.Add(dateLabel);
			this.Controls.Add(this.dateDateTimePicker);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.itemDataGridView);
			this.Controls.Add(this.groupBox1);
			this.Name = "ThemHoaDon";
			this.Text = "Thêm hoá đơn";
			this.Load += new System.EventHandler(this.ThemHoaDon_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView productDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.BindingSource itemBindingSource;
		private System.Windows.Forms.DataGridView itemDataGridView;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox _idTextBox;
		private System.Windows.Forms.TextBox customerNameTextBox;
		private System.Windows.Forms.DateTimePicker dateDateTimePicker;
		private System.Windows.Forms.TextBox nameSearch;
		private System.Windows.Forms.Label label1;
	}
}