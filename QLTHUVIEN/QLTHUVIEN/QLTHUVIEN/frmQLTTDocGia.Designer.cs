namespace QLTHUVIEN
{
    partial class frmQLTTDocGia
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpngaylapthe = new System.Windows.Forms.DateTimePicker();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmdg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSTTdocgia = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTTdocgia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Nhập mã cần tìm";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTK.Location = new System.Drawing.Point(607, 14);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(100, 33);
            this.btnTK.TabIndex = 32;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(309, 14);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(193, 32);
            this.txtTK.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpngaylapthe);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.txthoten);
            this.groupBox2.Controls.Add(this.dtpNgaysinh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtmdg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(16, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(948, 187);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // dtpngaylapthe
            // 
            this.dtpngaylapthe.CustomFormat = "";
            this.dtpngaylapthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaylapthe.Location = new System.Drawing.Point(652, 112);
            this.dtpngaylapthe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpngaylapthe.Name = "dtpngaylapthe";
            this.dtpngaylapthe.Size = new System.Drawing.Size(196, 24);
            this.dtpngaylapthe.TabIndex = 31;
            this.dtpngaylapthe.Value = new System.DateTime(2017, 5, 2, 0, 0, 0, 0);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(652, 30);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(196, 24);
            this.txtdiachi.TabIndex = 27;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(212, 70);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(193, 24);
            this.txthoten.TabIndex = 25;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(212, 110);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(196, 24);
            this.dtpNgaysinh.TabIndex = 23;
            this.dtpNgaysinh.Value = new System.DateTime(2017, 5, 2, 0, 0, 0, 0);
            this.dtpNgaysinh.ValueChanged += new System.EventHandler(this.dtpNgaysinh_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Địa chỉ";
            // 
            // txtmdg
            // 
            this.txtmdg.Location = new System.Drawing.Point(212, 31);
            this.txtmdg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmdg.Name = "txtmdg";
            this.txtmdg.Size = new System.Drawing.Size(193, 24);
            this.txtmdg.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày lập thẻ";
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLammoi.Location = new System.Drawing.Point(113, 258);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(100, 33);
            this.btnLammoi.TabIndex = 39;
            this.btnLammoi.Text = "LÀM MỚI ";
            this.btnLammoi.UseVisualStyleBackColor = false;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThoat.Location = new System.Drawing.Point(748, 258);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 33);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoa.Location = new System.Drawing.Point(588, 258);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 33);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnsua.Location = new System.Drawing.Point(431, 258);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 33);
            this.btnsua.TabIndex = 36;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnthem.Location = new System.Drawing.Point(276, 258);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 33);
            this.btnthem.TabIndex = 35;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSTTdocgia);
            this.groupBox1.Location = new System.Drawing.Point(15, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(948, 168);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // dgvDSTTdocgia
            // 
            this.dgvDSTTdocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTTdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTTdocgia.Location = new System.Drawing.Point(12, 18);
            this.dgvDSTTdocgia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSTTdocgia.Name = "dgvDSTTdocgia";
            this.dgvDSTTdocgia.RowHeadersWidth = 51;
            this.dgvDSTTdocgia.Size = new System.Drawing.Size(928, 136);
            this.dgvDSTTdocgia.TabIndex = 0;
            this.dgvDSTTdocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTTdocgia_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQLTTDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQLTTDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THÔNG TIN  ĐỘC GIẢ ";
            this.Load += new System.EventHandler(this.frmQLTTDocGia_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTTdocgia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmdg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpngaylapthe;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSTTdocgia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}