namespace QLTV
{
    partial class frmphieumuon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtg = new System.Windows.Forms.Label();
            this.lbnd = new System.Windows.Forms.Label();
            this.lbms = new System.Windows.Forms.Label();
            this.lbdc = new System.Windows.Forms.Label();
            this.lbht = new System.Windows.Forms.Label();
            this.lbmdg = new System.Windows.Forms.Label();
            this.btin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU MƯỢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(26, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu mượn";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(82, 21);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(418, 20);
            this.txttk.TabIndex = 2;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm kiếm: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtg);
            this.groupBox2.Controls.Add(this.lbnd);
            this.groupBox2.Controls.Add(this.lbms);
            this.groupBox2.Controls.Add(this.lbdc);
            this.groupBox2.Controls.Add(this.lbht);
            this.groupBox2.Controls.Add(this.lbmdg);
            this.groupBox2.Controls.Add(this.btin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(26, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mượn";
            // 
            // lbtg
            // 
            this.lbtg.AutoSize = true;
            this.lbtg.Location = new System.Drawing.Point(352, 87);
            this.lbtg.Name = "lbtg";
            this.lbtg.Size = new System.Drawing.Size(130, 13);
            this.lbtg.TabIndex = 14;
            this.lbtg.Text = ".........................................";
            // 
            // lbnd
            // 
            this.lbnd.AutoSize = true;
            this.lbnd.Location = new System.Drawing.Point(96, 87);
            this.lbnd.Name = "lbnd";
            this.lbnd.Size = new System.Drawing.Size(130, 13);
            this.lbnd.TabIndex = 12;
            this.lbnd.Text = ".........................................";
            this.lbnd.Click += new System.EventHandler(this.lbnd_Click);
            // 
            // lbms
            // 
            this.lbms.AutoSize = true;
            this.lbms.Location = new System.Drawing.Point(96, 62);
            this.lbms.Name = "lbms";
            this.lbms.Size = new System.Drawing.Size(130, 13);
            this.lbms.TabIndex = 11;
            this.lbms.Text = ".........................................";
            // 
            // lbdc
            // 
            this.lbdc.AutoSize = true;
            this.lbdc.Location = new System.Drawing.Point(95, 38);
            this.lbdc.Name = "lbdc";
            this.lbdc.Size = new System.Drawing.Size(130, 13);
            this.lbdc.TabIndex = 10;
            this.lbdc.Text = ".........................................";
            // 
            // lbht
            // 
            this.lbht.AutoSize = true;
            this.lbht.Location = new System.Drawing.Point(352, 16);
            this.lbht.Name = "lbht";
            this.lbht.Size = new System.Drawing.Size(130, 13);
            this.lbht.TabIndex = 9;
            this.lbht.Text = ".........................................";
            this.lbht.Click += new System.EventHandler(this.lbht_Click);
            // 
            // lbmdg
            // 
            this.lbmdg.AutoSize = true;
            this.lbmdg.Location = new System.Drawing.Point(94, 16);
            this.lbmdg.Name = "lbmdg";
            this.lbmdg.Size = new System.Drawing.Size(130, 13);
            this.lbmdg.TabIndex = 8;
            this.lbmdg.Text = ".........................................";
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(137, 127);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(213, 23);
            this.btin.TabIndex = 7;
            this.btin.Text = "IN PHIẾU MƯỢN";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tác giả: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhan đề";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã sách: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đọc giả: ";
            // 
            // frmphieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmphieumuon";
            this.Text = "Phiếu mượn";
            this.Load += new System.EventHandler(this.frmphieumuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtg;
        private System.Windows.Forms.Label lbnd;
        private System.Windows.Forms.Label lbms;
        private System.Windows.Forms.Label lbdc;
        private System.Windows.Forms.Label lbht;
        private System.Windows.Forms.Label lbmdg;
    }
}