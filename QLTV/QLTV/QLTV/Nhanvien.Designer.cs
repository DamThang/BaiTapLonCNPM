namespace QLTV
{
    partial class frmnhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpbtt = new System.Windows.Forms.GroupBox();
            this.cbbqh = new System.Windows.Forms.ComboBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbtt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // grpbtt
            // 
            this.grpbtt.Controls.Add(this.cbbqh);
            this.grpbtt.Controls.Add(this.txtmk);
            this.grpbtt.Controls.Add(this.txtdc);
            this.grpbtt.Controls.Add(this.txtht);
            this.grpbtt.Controls.Add(this.txtmanv);
            this.grpbtt.Controls.Add(this.label6);
            this.grpbtt.Controls.Add(this.label5);
            this.grpbtt.Controls.Add(this.label4);
            this.grpbtt.Controls.Add(this.label3);
            this.grpbtt.Controls.Add(this.label2);
            this.grpbtt.Location = new System.Drawing.Point(12, 51);
            this.grpbtt.Name = "grpbtt";
            this.grpbtt.Size = new System.Drawing.Size(445, 144);
            this.grpbtt.TabIndex = 1;
            this.grpbtt.TabStop = false;
            this.grpbtt.Text = "Thông tin nhân viên";
            this.grpbtt.Enter += new System.EventHandler(this.grpbtt_Enter);
            // 
            // cbbqh
            // 
            this.cbbqh.Enabled = false;
            this.cbbqh.FormattingEnabled = true;
            this.cbbqh.Items.AddRange(new object[] {
            "Admin",
            "Thủ thư"});
            this.cbbqh.Location = new System.Drawing.Point(333, 64);
            this.cbbqh.Name = "cbbqh";
            this.cbbqh.Size = new System.Drawing.Size(100, 21);
            this.cbbqh.TabIndex = 9;
            // 
            // txtmk
            // 
            this.txtmk.Enabled = false;
            this.txtmk.Location = new System.Drawing.Point(333, 24);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(100, 20);
            this.txtmk.TabIndex = 8;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(97, 106);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(100, 20);
            this.txtdc.TabIndex = 7;
            // 
            // txtht
            // 
            this.txtht.Enabled = false;
            this.txtht.Location = new System.Drawing.Point(97, 65);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(100, 20);
            this.txtht.TabIndex = 6;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(97, 24);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quyền hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(479, 73);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "THÊM";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(479, 123);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 11;
            this.btsua.Text = "SỬA";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(479, 172);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 12;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.grpbtt);
            this.Controls.Add(this.label1);
            this.Name = "frmnhanvien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            this.grpbtt.ResumeLayout(false);
            this.grpbtt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbtt;
        private System.Windows.Forms.ComboBox cbbqh;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}