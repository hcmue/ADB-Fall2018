namespace mongodbwithwinform
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
            this.txtmasanpham = new System.Windows.Forms.TextBox();
            this.txttensanpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.gridControlSanPham = new System.Windows.Forms.DataGridView();
            this.cbloaisanpham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNSX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàSảnXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTimkiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSanPham)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmasanpham
            // 
            this.txtmasanpham.Location = new System.Drawing.Point(189, 58);
            this.txtmasanpham.Name = "txtmasanpham";
            this.txtmasanpham.Size = new System.Drawing.Size(154, 20);
            this.txtmasanpham.TabIndex = 0;
            // 
            // txttensanpham
            // 
            this.txttensanpham.Location = new System.Drawing.Point(189, 112);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(154, 20);
            this.txttensanpham.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(178, 234);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(758, 278);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(62, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // gridControlSanPham
            // 
            this.gridControlSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControlSanPham.Location = new System.Drawing.Point(427, 58);
            this.gridControlSanPham.Name = "gridControlSanPham";
            this.gridControlSanPham.Size = new System.Drawing.Size(408, 185);
            this.gridControlSanPham.TabIndex = 4;
            this.gridControlSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridControlSanPham_CellClick);
            // 
            // cbloaisanpham
            // 
            this.cbloaisanpham.FormattingEnabled = true;
            this.cbloaisanpham.Location = new System.Drawing.Point(189, 153);
            this.cbloaisanpham.Name = "cbloaisanpham";
            this.cbloaisanpham.Size = new System.Drawing.Size(154, 21);
            this.cbloaisanpham.TabIndex = 5;
            this.cbloaisanpham.SelectedIndexChanged += new System.EventHandler(this.cbloaisanpham_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(268, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Location = new System.Drawing.Point(83, 278);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(68, 23);
            this.btnCapnhat.TabIndex = 8;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(273, 278);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(70, 23);
            this.btnTimkiem.TabIndex = 9;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(83, 234);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(68, 23);
            this.btnLoadAll.TabIndex = 10;
            this.btnLoadAll.Text = "Load all";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập thông tin sản phẩm";
            // 
            // cbNSX
            // 
            this.cbNSX.FormattingEnabled = true;
            this.cbNSX.Location = new System.Drawing.Point(189, 196);
            this.cbNSX.Name = "cbNSX";
            this.cbNSX.Size = new System.Drawing.Size(154, 21);
            this.cbNSX.TabIndex = 13;
            this.cbNSX.SelectedIndexChanged += new System.EventHandler(this.cbNSX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Thương hiệu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiSảnPhẩmToolStripMenuItem,
            this.nhàSảnXuấtToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loạiSảnPhẩmToolStripMenuItem
            // 
            this.loạiSảnPhẩmToolStripMenuItem.Name = "loạiSảnPhẩmToolStripMenuItem";
            this.loạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            this.loạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.loạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // nhàSảnXuấtToolStripMenuItem
            // 
            this.nhàSảnXuấtToolStripMenuItem.Name = "nhàSảnXuấtToolStripMenuItem";
            this.nhàSảnXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhàSảnXuấtToolStripMenuItem.Text = "Nhà sản xuất";
            this.nhàSảnXuấtToolStripMenuItem.Click += new System.EventHandler(this.nhàSảnXuấtToolStripMenuItem_Click);
            // 
            // cbTimkiem
            // 
            this.cbTimkiem.DisplayMember = "Rau";
            this.cbTimkiem.FormattingEnabled = true;
            this.cbTimkiem.Items.AddRange(new object[] {
            "Loại SP",
            "Thương hiệu"});
            this.cbTimkiem.Location = new System.Drawing.Point(164, 278);
            this.cbTimkiem.Name = "cbTimkiem";
            this.cbTimkiem.Size = new System.Drawing.Size(103, 21);
            this.cbTimkiem.TabIndex = 15;
            this.cbTimkiem.SelectedIndexChanged += new System.EventHandler(this.cbTimkiem_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 325);
            this.Controls.Add(this.cbTimkiem);
            this.Controls.Add(this.cbNSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbloaisanpham);
            this.Controls.Add(this.gridControlSanPham);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttensanpham);
            this.Controls.Add(this.txtmasanpham);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSanPham)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmasanpham;
        private System.Windows.Forms.TextBox txttensanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView gridControlSanPham;
        private System.Windows.Forms.ComboBox cbloaisanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàSảnXuấtToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTimkiem;

    }
}

