namespace ADBTeam20_DB4O
{
	partial class EmployeeList
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
			System.Windows.Forms.Label fullNameLabel;
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label salaryLabel;
			System.Windows.Forms.Label skillLabel;
			System.Windows.Forms.Label companyIDLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.iDTextBox = new System.Windows.Forms.TextBox();
			this.salaryTextBox = new System.Windows.Forms.TextBox();
			this.skillTextBox = new System.Windows.Forms.TextBox();
			this.companyIDComboBox = new System.Windows.Forms.ComboBox();
			fullNameLabel = new System.Windows.Forms.Label();
			iDLabel = new System.Windows.Forms.Label();
			salaryLabel = new System.Windows.Forms.Label();
			skillLabel = new System.Windows.Forms.Label();
			companyIDLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new System.Drawing.Point(67, 25);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new System.Drawing.Size(57, 13);
			fullNameLabel.TabIndex = 2;
			fullNameLabel.Text = "Full Name:";
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Location = new System.Drawing.Point(67, 51);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(21, 13);
			iDLabel.TabIndex = 4;
			iDLabel.Text = "ID:";
			// 
			// salaryLabel
			// 
			salaryLabel.AutoSize = true;
			salaryLabel.Location = new System.Drawing.Point(67, 77);
			salaryLabel.Name = "salaryLabel";
			salaryLabel.Size = new System.Drawing.Size(39, 13);
			salaryLabel.TabIndex = 6;
			salaryLabel.Text = "Salary:";
			// 
			// skillLabel
			// 
			skillLabel.AutoSize = true;
			skillLabel.Location = new System.Drawing.Point(67, 103);
			skillLabel.Name = "skillLabel";
			skillLabel.Size = new System.Drawing.Size(29, 13);
			skillLabel.TabIndex = 8;
			skillLabel.Text = "Skill:";
			// 
			// companyIDLabel
			// 
			companyIDLabel.AutoSize = true;
			companyIDLabel.Location = new System.Drawing.Point(67, 163);
			companyIDLabel.Name = "companyIDLabel";
			companyIDLabel.Size = new System.Drawing.Size(68, 13);
			companyIDLabel.TabIndex = 10;
			companyIDLabel.Text = "Company ID:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.employeeDataGridView);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 201);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 158);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập Nhân Viên";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AutoGenerateColumns = false;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.employeeDataGridView.DataSource = this.employeeBindingSource;
			this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.employeeDataGridView.Location = new System.Drawing.Point(3, 16);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.Size = new System.Drawing.Size(794, 139);
			this.employeeDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
			this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Skill";
			this.dataGridViewTextBoxColumn3.HeaderText = "Skill";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "HomeBase";
			this.dataGridViewTextBoxColumn4.HeaderText = "HomeBase";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Manager";
			this.dataGridViewTextBoxColumn5.HeaderText = "Manager";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Salary";
			this.dataGridViewTextBoxColumn6.HeaderText = "Salary";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(ADBTeam20_DB4O.Employee);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(505, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Thêm Nhân viên";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FullName", true));
			this.fullNameTextBox.Location = new System.Drawing.Point(130, 22);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.fullNameTextBox.TabIndex = 3;
			// 
			// iDTextBox
			// 
			this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
			this.iDTextBox.Location = new System.Drawing.Point(130, 48);
			this.iDTextBox.Name = "iDTextBox";
			this.iDTextBox.Size = new System.Drawing.Size(100, 20);
			this.iDTextBox.TabIndex = 5;
			// 
			// salaryTextBox
			// 
			this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true));
			this.salaryTextBox.Location = new System.Drawing.Point(130, 74);
			this.salaryTextBox.Name = "salaryTextBox";
			this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
			this.salaryTextBox.TabIndex = 7;
			// 
			// skillTextBox
			// 
			this.skillTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Skill", true));
			this.skillTextBox.Location = new System.Drawing.Point(130, 100);
			this.skillTextBox.Name = "skillTextBox";
			this.skillTextBox.Size = new System.Drawing.Size(100, 20);
			this.skillTextBox.TabIndex = 9;
			// 
			// companyIDComboBox
			// 
			this.companyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HomeBase.CompanyID", true));
			this.companyIDComboBox.FormattingEnabled = true;
			this.companyIDComboBox.Location = new System.Drawing.Point(141, 160);
			this.companyIDComboBox.Name = "companyIDComboBox";
			this.companyIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.companyIDComboBox.TabIndex = 11;
			// 
			// EmployeeList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 359);
			this.Controls.Add(companyIDLabel);
			this.Controls.Add(this.companyIDComboBox);
			this.Controls.Add(fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(iDLabel);
			this.Controls.Add(this.iDTextBox);
			this.Controls.Add(salaryLabel);
			this.Controls.Add(this.salaryTextBox);
			this.Controls.Add(skillLabel);
			this.Controls.Add(this.skillTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Name = "EmployeeList";
			this.Text = "EmployeeList";
			this.Load += new System.EventHandler(this.EmployeeList_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox iDTextBox;
		private System.Windows.Forms.TextBox salaryTextBox;
		private System.Windows.Forms.TextBox skillTextBox;
		private System.Windows.Forms.ComboBox companyIDComboBox;
	}
}