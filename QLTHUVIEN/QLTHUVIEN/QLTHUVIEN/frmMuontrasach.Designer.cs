namespace QLTHUVIEN
{
    partial class frmMuontrasach
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
            this.dgvmuontra = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbmtrangthai = new System.Windows.Forms.ComboBox();
            this.dtpngaynuon = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.NumericUpDown();
            this.numgiahan = new System.Windows.Forms.NumericUpDown();
            this.cbmadg = new System.Windows.Forms.ComboBox();
            this.cbmathuthu = new System.Windows.Forms.ComboBox();
            this.cbmasach = new System.Windows.Forms.ComboBox();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnGiahan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiahan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmuontra
            // 
            this.dgvmuontra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmuontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmuontra.Location = new System.Drawing.Point(12, 18);
            this.dgvmuontra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvmuontra.Name = "dgvmuontra";
            this.dgvmuontra.RowHeadersWidth = 51;
            this.dgvmuontra.Size = new System.Drawing.Size(928, 136);
            this.dgvmuontra.TabIndex = 0;
            this.dgvmuontra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmuontra_CellClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(501, 294);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 40);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(344, 294);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(116, 40);
            this.btnsua.TabIndex = 46;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(189, 294);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(116, 40);
            this.btnthem.TabIndex = 45;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbmtrangthai
            // 
            this.cbmtrangthai.FormattingEnabled = true;
            this.cbmtrangthai.Items.AddRange(new object[] {
            "ĐA TRA",
            "ĐANG MUON"});
            this.cbmtrangthai.Location = new System.Drawing.Point(649, 82);
            this.cbmtrangthai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmtrangthai.Name = "cbmtrangthai";
            this.cbmtrangthai.Size = new System.Drawing.Size(196, 26);
            this.cbmtrangthai.TabIndex = 30;
            this.cbmtrangthai.Tag = "";
            // 
            // dtpngaynuon
            // 
            this.dtpngaynuon.CustomFormat = "";
            this.dtpngaynuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynuon.Location = new System.Drawing.Point(212, 78);
            this.dtpngaynuon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpngaynuon.Name = "dtpngaynuon";
            this.dtpngaynuon.Size = new System.Drawing.Size(196, 24);
            this.dtpngaynuon.TabIndex = 23;
            this.dtpngaynuon.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã sách ";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Location = new System.Drawing.Point(27, 294);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(116, 40);
            this.btnLammoi.TabIndex = 49;
            this.btnLammoi.Text = "LÀM MỚI ";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(811, 294);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 40);
            this.btnThoat.TabIndex = 48;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Thủ Thư";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trạng thái ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số lượng ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvmuontra);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(948, 168);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THÔNG TIN  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.numgiahan);
            this.groupBox2.Controls.Add(this.cbmadg);
            this.groupBox2.Controls.Add(this.cbmathuthu);
            this.groupBox2.Controls.Add(this.cbmasach);
            this.groupBox2.Controls.Add(this.dtpNgaytra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbmtrangthai);
            this.groupBox2.Controls.Add(this.dtpngaynuon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(948, 225);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN MƯỢN TRẢ";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(645, 29);
            this.txtsoluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsoluong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(200, 24);
            this.txtsoluong.TabIndex = 37;
            this.txtsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtsoluong.ValueChanged += new System.EventHandler(this.txtsoluong_ValueChanged);
            // 
            // numgiahan
            // 
            this.numgiahan.Location = new System.Drawing.Point(649, 177);
            this.numgiahan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numgiahan.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numgiahan.Name = "numgiahan";
            this.numgiahan.Size = new System.Drawing.Size(200, 24);
            this.numgiahan.TabIndex = 36;
            // 
            // cbmadg
            // 
            this.cbmadg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmadg.FormattingEnabled = true;
            this.cbmadg.Location = new System.Drawing.Point(212, 31);
            this.cbmadg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmadg.Name = "cbmadg";
            this.cbmadg.Size = new System.Drawing.Size(196, 26);
            this.cbmadg.TabIndex = 35;
            // 
            // cbmathuthu
            // 
            this.cbmathuthu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmathuthu.FormattingEnabled = true;
            this.cbmathuthu.Location = new System.Drawing.Point(212, 177);
            this.cbmathuthu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmathuthu.Name = "cbmathuthu";
            this.cbmathuthu.Size = new System.Drawing.Size(196, 26);
            this.cbmathuthu.TabIndex = 34;
            // 
            // cbmasach
            // 
            this.cbmasach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmasach.FormattingEnabled = true;
            this.cbmasach.Location = new System.Drawing.Point(212, 126);
            this.cbmasach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbmasach.Name = "cbmasach";
            this.cbmasach.Size = new System.Drawing.Size(196, 26);
            this.cbmasach.TabIndex = 33;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.CustomFormat = "";
            this.dtpNgaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaytra.Location = new System.Drawing.Point(652, 127);
            this.dtpNgaytra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(196, 24);
            this.dtpNgaytra.TabIndex = 32;
            this.dtpNgaytra.Value = new System.DateTime(2017, 5, 21, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 186);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Ngày gia hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày trả";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(152, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Nhập mã cần tìm";
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(603, 14);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(100, 33);
            this.btnTK.TabIndex = 42;
            this.btnTK.Text = "TÌM KIẾM";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(305, 14);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(193, 32);
            this.txtTK.TabIndex = 41;
            // 
            // btnGiahan
            // 
            this.btnGiahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiahan.Location = new System.Drawing.Point(661, 294);
            this.btnGiahan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGiahan.Name = "btnGiahan";
            this.btnGiahan.Size = new System.Drawing.Size(116, 40);
            this.btnGiahan.TabIndex = 51;
            this.btnGiahan.Text = "GIA HẠN";
            this.btnGiahan.UseVisualStyleBackColor = true;
            this.btnGiahan.Click += new System.EventHandler(this.btnGiahan_Click);
            // 
            // frmMuontrasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 523);
            this.Controls.Add(this.btnGiahan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMuontrasach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MƯỢN TRẢ SÁCH ";
            this.Load += new System.EventHandler(this.frmMuontrasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmuontra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numgiahan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmuontra;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbmtrangthai;
        private System.Windows.Forms.DateTimePicker dtpngaynuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmathuthu;
        private System.Windows.Forms.ComboBox cbmasach;
        private System.Windows.Forms.ComboBox cbmadg;
        private System.Windows.Forms.Button btnGiahan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numgiahan;
        private System.Windows.Forms.NumericUpDown txtsoluong;
    }
}