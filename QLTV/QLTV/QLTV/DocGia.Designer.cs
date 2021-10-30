namespace QLTV
{
    partial class frmdg
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.txtmdg = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.cbbk = new System.Windows.Forms.ComboBox();
            this.datengs = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đọc giả: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đọc giả: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khoa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mật khẩu: ";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(667, 20);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(667, 62);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 8;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(667, 111);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 9;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // txtmdg
            // 
            this.txtmdg.Enabled = false;
            this.txtmdg.Location = new System.Drawing.Point(94, 23);
            this.txtmdg.Name = "txtmdg";
            this.txtmdg.Size = new System.Drawing.Size(154, 20);
            this.txtmdg.TabIndex = 10;
            // 
            // txtten
            // 
            this.txtten.Enabled = false;
            this.txtten.Location = new System.Drawing.Point(94, 62);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(154, 20);
            this.txtten.TabIndex = 11;
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(405, 23);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(140, 20);
            this.txtdc.TabIndex = 12;
            // 
            // txtmk
            // 
            this.txtmk.Enabled = false;
            this.txtmk.Location = new System.Drawing.Point(405, 65);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(140, 20);
            this.txtmk.TabIndex = 13;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // cbbk
            // 
            this.cbbk.Enabled = false;
            this.cbbk.FormattingEnabled = true;
            this.cbbk.Location = new System.Drawing.Point(405, 101);
            this.cbbk.Name = "cbbk";
            this.cbbk.Size = new System.Drawing.Size(140, 21);
            this.cbbk.TabIndex = 14;
            // 
            // datengs
            // 
            this.datengs.Enabled = false;
            this.datengs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengs.Location = new System.Drawing.Point(94, 103);
            this.datengs.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.datengs.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.datengs.Name = "datengs";
            this.datengs.Size = new System.Drawing.Size(154, 20);
            this.datengs.TabIndex = 15;
            this.datengs.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(239, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "THÔNG TIN ĐỌC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmdg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datengs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btthem);
            this.groupBox1.Controls.Add(this.btxoa);
            this.groupBox1.Controls.Add(this.btsua);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 143);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // frmdg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmdg";
            this.Text = "Đọc Giả";
            this.Load += new System.EventHandler(this.frmdg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.TextBox txtmdg;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.ComboBox cbbk;
        private System.Windows.Forms.DateTimePicker datengs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}