namespace ADBFallTeam20
{
	partial class QLBH
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
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label priceLabel;
			System.Windows.Forms.Label saleLabel;
			System.Windows.Forms.Label unitLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.productDataGridView = new System.Windows.Forms.DataGridView();
			this.insert = new System.Windows.Forms.Button();
			this._idTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.saleTextBox = new System.Windows.Forms.TextBox();
			this.unitTextBox = new System.Windows.Forms.TextBox();
			this.delete = new System.Windows.Forms.Button();
			this.edit = new System.Windows.Forms.Button();
			this.insertBill = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.revDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			_idLabel = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			priceLabel = new System.Windows.Forms.Label();
			saleLabel = new System.Windows.Forms.Label();
			unitLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// _idLabel
			// 
			_idLabel.AutoSize = true;
			_idLabel.Location = new System.Drawing.Point(123, 35);
			_idLabel.Name = "_idLabel";
			_idLabel.Size = new System.Drawing.Size(74, 13);
			_idLabel.TabIndex = 11;
			_idLabel.Text = "Mã sản phẩm:";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(123, 61);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(78, 13);
			nameLabel.TabIndex = 13;
			nameLabel.Text = "Tên sản phẩm:";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new System.Drawing.Point(123, 87);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new System.Drawing.Size(55, 13);
			priceLabel.TabIndex = 15;
			priceLabel.Text = "Giá(VNĐ):";
			// 
			// saleLabel
			// 
			saleLabel.AutoSize = true;
			saleLabel.Location = new System.Drawing.Point(123, 113);
			saleLabel.Name = "saleLabel";
			saleLabel.Size = new System.Drawing.Size(65, 13);
			saleLabel.TabIndex = 17;
			saleLabel.Text = "Giảm giá(%):";
			// 
			// unitLabel
			// 
			unitLabel.AutoSize = true;
			unitLabel.Location = new System.Drawing.Point(123, 139);
			unitLabel.Name = "unitLabel";
			unitLabel.Size = new System.Drawing.Size(41, 13);
			unitLabel.TabIndex = 19;
			unitLabel.Text = "Đơn vị:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.productDataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(810, 268);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách sản phẩm";
			// 
			// productDataGridView
			// 
			this.productDataGridView.AutoGenerateColumns = false;
			this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.revDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.saleDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
			this.productDataGridView.DataSource = this.productBindingSource;
			this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productDataGridView.Location = new System.Drawing.Point(3, 16);
			this.productDataGridView.Name = "productDataGridView";
			this.productDataGridView.Size = new System.Drawing.Size(804, 249);
			this.productDataGridView.TabIndex = 0;
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(403, 39);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(75, 23);
			this.insert.TabIndex = 11;
			this.insert.Text = "Thêm";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// _idTextBox
			// 
			this._idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "_id", true));
			this._idTextBox.Enabled = false;
			this._idTextBox.Location = new System.Drawing.Point(207, 32);
			this._idTextBox.Name = "_idTextBox";
			this._idTextBox.Size = new System.Drawing.Size(100, 20);
			this._idTextBox.TabIndex = 12;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(207, 58);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 20);
			this.nameTextBox.TabIndex = 14;
			// 
			// priceTextBox
			// 
			this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
			this.priceTextBox.Location = new System.Drawing.Point(207, 84);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(100, 20);
			this.priceTextBox.TabIndex = 16;
			// 
			// saleTextBox
			// 
			this.saleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sale", true));
			this.saleTextBox.Location = new System.Drawing.Point(207, 110);
			this.saleTextBox.Name = "saleTextBox";
			this.saleTextBox.Size = new System.Drawing.Size(100, 20);
			this.saleTextBox.TabIndex = 18;
			// 
			// unitTextBox
			// 
			this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Unit", true));
			this.unitTextBox.Location = new System.Drawing.Point(207, 136);
			this.unitTextBox.Name = "unitTextBox";
			this.unitTextBox.Size = new System.Drawing.Size(100, 20);
			this.unitTextBox.TabIndex = 20;
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(403, 87);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 21;
			this.delete.Text = "Xoá";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// edit
			// 
			this.edit.Location = new System.Drawing.Point(403, 129);
			this.edit.Name = "edit";
			this.edit.Size = new System.Drawing.Size(75, 23);
			this.edit.TabIndex = 22;
			this.edit.Text = "Sửa";
			this.edit.UseVisualStyleBackColor = true;
			this.edit.Click += new System.EventHandler(this.edit_Click);
			// 
			// insertBill
			// 
			this.insertBill.Location = new System.Drawing.Point(584, 39);
			this.insertBill.Name = "insertBill";
			this.insertBill.Size = new System.Drawing.Size(117, 23);
			this.insertBill.TabIndex = 23;
			this.insertBill.Text = "Thêm hoá đơn";
			this.insertBill.UseVisualStyleBackColor = true;
			this.insertBill.Click += new System.EventHandler(this.insertBill_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(584, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "Danh sách hoá đơn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// productBindingSource
			// 
			this.productBindingSource.DataSource = typeof(ADBFallTeam20.Product);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "_id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// revDataGridViewTextBoxColumn
			// 
			this.revDataGridViewTextBoxColumn.DataPropertyName = "_rev";
			this.revDataGridViewTextBoxColumn.HeaderText = "_rev";
			this.revDataGridViewTextBoxColumn.Name = "revDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Giá(VNĐ)";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// saleDataGridViewTextBoxColumn
			// 
			this.saleDataGridViewTextBoxColumn.DataPropertyName = "Sale";
			this.saleDataGridViewTextBoxColumn.HeaderText = "Giảm giá(%)";
			this.saleDataGridViewTextBoxColumn.Name = "saleDataGridViewTextBoxColumn";
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(403, 178);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 25;
			this.button2.Text = "Load";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// QLBH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 475);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.insertBill);
			this.Controls.Add(this.edit);
			this.Controls.Add(this.delete);
			this.Controls.Add(_idLabel);
			this.Controls.Add(this._idTextBox);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(priceLabel);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(saleLabel);
			this.Controls.Add(this.saleTextBox);
			this.Controls.Add(unitLabel);
			this.Controls.Add(this.unitTextBox);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.groupBox1);
			this.Name = "QLBH";
			this.Text = "Quản lý bán hàng";
			this.Load += new System.EventHandler(this.QLBH_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView productDataGridView;
		private System.Windows.Forms.BindingSource productBindingSource;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.TextBox _idTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox saleTextBox;
		private System.Windows.Forms.TextBox unitTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn revDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn saleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button edit;
		private System.Windows.Forms.Button insertBill;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

