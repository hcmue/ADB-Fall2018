namespace ADBFallTeam20
{
	partial class HoaDon
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
			this.itemListDataGridView = new System.Windows.Forms.DataGridView();
			this.itemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
			this._idTextBox = new System.Windows.Forms.TextBox();
			this.customerNameTextBox = new System.Windows.Forms.TextBox();
			this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			_idLabel = new System.Windows.Forms.Label();
			customerNameLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.itemListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// _idLabel
			// 
			_idLabel.AutoSize = true;
			_idLabel.Location = new System.Drawing.Point(20, 23);
			_idLabel.Name = "_idLabel";
			_idLabel.Size = new System.Drawing.Size(68, 13);
			_idLabel.TabIndex = 2;
			_idLabel.Text = "Mã hoá đơn:";
			// 
			// customerNameLabel
			// 
			customerNameLabel.AutoSize = true;
			customerNameLabel.Location = new System.Drawing.Point(20, 49);
			customerNameLabel.Name = "customerNameLabel";
			customerNameLabel.Size = new System.Drawing.Size(89, 13);
			customerNameLabel.TabIndex = 4;
			customerNameLabel.Text = "Tên khách hàng:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.itemListDataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox1.Location = new System.Drawing.Point(451, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(681, 389);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết hoá đơn";
			this.groupBox1.UseWaitCursor = true;
			// 
			// itemListDataGridView
			// 
			this.itemListDataGridView.AutoGenerateColumns = false;
			this.itemListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.itemListDataGridView.DataSource = this.itemListBindingSource;
			this.itemListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemListDataGridView.Location = new System.Drawing.Point(3, 16);
			this.itemListDataGridView.Name = "itemListDataGridView";
			this.itemListDataGridView.Size = new System.Drawing.Size(675, 370);
			this.itemListDataGridView.TabIndex = 0;
			this.itemListDataGridView.UseWaitCursor = true;
			// 
			// itemListBindingSource
			// 
			this.itemListBindingSource.DataMember = "ItemList";
			this.itemListBindingSource.DataSource = this.invoiceBindingSource;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.invoiceDataGridView);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 131);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(451, 258);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách hoá đơn";
			// 
			// invoiceDataGridView
			// 
			this.invoiceDataGridView.AutoGenerateColumns = false;
			this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
			this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.invoiceDataGridView.Location = new System.Drawing.Point(3, 16);
			this.invoiceDataGridView.Name = "invoiceDataGridView";
			this.invoiceDataGridView.Size = new System.Drawing.Size(445, 239);
			this.invoiceDataGridView.TabIndex = 0;
			this.invoiceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellContentClick);
			// 
			// _idTextBox
			// 
			this._idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "_id", true));
			this._idTextBox.Location = new System.Drawing.Point(115, 20);
			this._idTextBox.Name = "_idTextBox";
			this._idTextBox.Size = new System.Drawing.Size(149, 20);
			this._idTextBox.TabIndex = 3;
			// 
			// customerNameTextBox
			// 
			this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "CustomerName", true));
			this.customerNameTextBox.Location = new System.Drawing.Point(115, 46);
			this.customerNameTextBox.Name = "customerNameTextBox";
			this.customerNameTextBox.Size = new System.Drawing.Size(149, 20);
			this.customerNameTextBox.TabIndex = 5;
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new System.Drawing.Point(20, 83);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(52, 13);
			dateLabel.TabIndex = 6;
			dateLabel.Text = "Ngày lập:";
			// 
			// dateDateTimePicker
			// 
			this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "Date", true));
			this.dateDateTimePicker.Location = new System.Drawing.Point(115, 77);
			this.dateDateTimePicker.Name = "dateDateTimePicker";
			this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateDateTimePicker.TabIndex = 7;
			// 
			// invoiceBindingSource
			// 
			this.invoiceBindingSource.DataSource = typeof(ADBFallTeam20.Invoice);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Mã hoá đơn";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "_rev";
			this.dataGridViewTextBoxColumn2.HeaderText = "_rev";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Visible = false;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerName";
			this.dataGridViewTextBoxColumn3.HeaderText = "Tên khách hàng";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn4.HeaderText = "Ngày lập";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "_id";
			this.dataGridViewTextBoxColumn7.HeaderText = "Mã sản phẩm";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn8.HeaderText = "Tên sản phẩm";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Price";
			this.dataGridViewTextBoxColumn10.HeaderText = "Giá(VNĐ)";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Sale";
			this.dataGridViewTextBoxColumn11.HeaderText = "Giảm giá(%)";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Quatity";
			this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalPrice";
			this.dataGridViewTextBoxColumn6.HeaderText = "Giá thành";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// HoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1132, 389);
			this.Controls.Add(dateLabel);
			this.Controls.Add(this.dateDateTimePicker);
			this.Controls.Add(_idLabel);
			this.Controls.Add(this._idTextBox);
			this.Controls.Add(customerNameLabel);
			this.Controls.Add(this.customerNameTextBox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "HoaDon";
			this.Text = "Hoá đơn";
			this.Load += new System.EventHandler(this.HoaDon_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.itemListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource invoiceBindingSource;
		private System.Windows.Forms.DataGridView invoiceDataGridView;
		private System.Windows.Forms.TextBox _idTextBox;
		private System.Windows.Forms.TextBox customerNameTextBox;
		private System.Windows.Forms.BindingSource itemListBindingSource;
		private System.Windows.Forms.DataGridView itemListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DateTimePicker dateDateTimePicker;
	}
}