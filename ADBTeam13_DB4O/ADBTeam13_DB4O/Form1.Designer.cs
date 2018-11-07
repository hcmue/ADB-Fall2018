namespace ADBTeam13_DB4O
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
            this.dgvDSKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadAllKhoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnLoadALLMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenKhoaQL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenMHDK = new System.Windows.Forms.TextBox();
            this.nbrudSTC = new System.Windows.Forms.NumericUpDown();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrudSTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Location = new System.Drawing.Point(12, 172);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.Size = new System.Drawing.Size(473, 196);
            this.dgvDSKhoa.TabIndex = 1;
            this.dgvDSKhoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhoa_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadAllKhoa);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnThemKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Khoa";
            // 
            // btnLoadAllKhoa
            // 
            this.btnLoadAllKhoa.Location = new System.Drawing.Point(303, 114);
            this.btnLoadAllKhoa.Name = "btnLoadAllKhoa";
            this.btnLoadAllKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAllKhoa.TabIndex = 7;
            this.btnLoadAllKhoa.Text = "Load tất cả";
            this.btnLoadAllKhoa.UseVisualStyleBackColor = true;
            this.btnLoadAllKhoa.Click += new System.EventHandler(this.btnLoadAllKhoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Query 6";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(45, 115);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemKhoa.TabIndex = 4;
            this.btnThemKhoa.Text = "Thêm khoa";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khoa";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(262, 75);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(116, 20);
            this.txtSDT.TabIndex = 0;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(262, 20);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(116, 20);
            this.txtTenKhoa.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(62, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(62, 20);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtMaKhoa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuery5);
            this.groupBox2.Controls.Add(this.btnLoadALLMon);
            this.groupBox2.Controls.Add(this.btnThemMon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTenKhoaQL);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTenMHDK);
            this.groupBox2.Controls.Add(this.nbrudSTC);
            this.groupBox2.Controls.Add(this.txtMota);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMaMH);
            this.groupBox2.Controls.Add(this.txtTenMH);
            this.groupBox2.Location = new System.Drawing.Point(492, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Môn học";
            // 
            // btnQuery5
            // 
            this.btnQuery5.Location = new System.Drawing.Point(288, 119);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(75, 23);
            this.btnQuery5.TabIndex = 12;
            this.btnQuery5.Text = "Query 5";
            this.btnQuery5.UseVisualStyleBackColor = true;
            this.btnQuery5.Click += new System.EventHandler(this.btnQuery5_Click);
            // 
            // btnLoadALLMon
            // 
            this.btnLoadALLMon.Location = new System.Drawing.Point(180, 119);
            this.btnLoadALLMon.Name = "btnLoadALLMon";
            this.btnLoadALLMon.Size = new System.Drawing.Size(75, 23);
            this.btnLoadALLMon.TabIndex = 11;
            this.btnLoadALLMon.Text = "Load tat ca";
            this.btnLoadALLMon.UseVisualStyleBackColor = true;
            this.btnLoadALLMon.Click += new System.EventHandler(this.btnLoadALLMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(38, 119);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(94, 23);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = "Them mon hoc";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tên khoa quản lý";
            // 
            // txtTenKhoaQL
            // 
            this.txtTenKhoaQL.Location = new System.Drawing.Point(409, 93);
            this.txtTenKhoaQL.Name = "txtTenKhoaQL";
            this.txtTenKhoaQL.Size = new System.Drawing.Size(100, 20);
            this.txtTenKhoaQL.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên môn học điều kiện";
            // 
            // txtTenMHDK
            // 
            this.txtTenMHDK.Location = new System.Drawing.Point(155, 93);
            this.txtTenMHDK.Name = "txtTenMHDK";
            this.txtTenMHDK.Size = new System.Drawing.Size(100, 20);
            this.txtTenMHDK.TabIndex = 6;
            // 
            // nbrudSTC
            // 
            this.nbrudSTC.Location = new System.Drawing.Point(309, 59);
            this.nbrudSTC.Name = "nbrudSTC";
            this.nbrudSTC.Size = new System.Drawing.Size(68, 20);
            this.nbrudSTC.TabIndex = 5;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(113, 59);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(100, 20);
            this.txtMota.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số tín chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã môn học";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(113, 20);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(100, 20);
            this.txtMaMH.TabIndex = 0;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(309, 20);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(100, 20);
            this.txtTenMH.TabIndex = 0;
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Location = new System.Drawing.Point(492, 173);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.Size = new System.Drawing.Size(555, 195);
            this.dgvDSMonHoc.TabIndex = 4;
            this.dgvDSMonHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonHoc_RowEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 380);
            this.Controls.Add(this.dgvDSMonHoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSKhoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrudSTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nbrudSTC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadAllKhoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenKhoaQL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenMHDK;
        private System.Windows.Forms.Button btnLoadALLMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnQuery5;
    }
}

