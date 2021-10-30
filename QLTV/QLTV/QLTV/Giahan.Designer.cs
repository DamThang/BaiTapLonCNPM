namespace QLTV
{
    partial class frmgiahan
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
            this.btnhap = new System.Windows.Forms.Button();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtacgia = new System.Windows.Forms.Label();
            this.lbnhande = new System.Windows.Forms.Label();
            this.lbmasach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIA HẠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnhap);
            this.groupBox1.Controls.Add(this.txtmadg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // btnhap
            // 
            this.btnhap.Location = new System.Drawing.Point(355, 14);
            this.btnhap.Name = "btnhap";
            this.btnhap.Size = new System.Drawing.Size(130, 23);
            this.btnhap.TabIndex = 2;
            this.btnhap.Text = "NHẬP";
            this.btnhap.UseVisualStyleBackColor = true;
            this.btnhap.Click += new System.EventHandler(this.btnhap_Click);
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(83, 16);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(246, 20);
            this.txtmadg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đọc giả: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtacgia);
            this.groupBox2.Controls.Add(this.lbnhande);
            this.groupBox2.Controls.Add(this.lbmasach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 255);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // lbtacgia
            // 
            this.lbtacgia.AutoSize = true;
            this.lbtacgia.Location = new System.Drawing.Point(80, 228);
            this.lbtacgia.Name = "lbtacgia";
            this.lbtacgia.Size = new System.Drawing.Size(238, 13);
            this.lbtacgia.TabIndex = 6;
            this.lbtacgia.Text = ".............................................................................";
            // 
            // lbnhande
            // 
            this.lbnhande.AutoSize = true;
            this.lbnhande.Location = new System.Drawing.Point(80, 189);
            this.lbnhande.Name = "lbnhande";
            this.lbnhande.Size = new System.Drawing.Size(238, 13);
            this.lbnhande.TabIndex = 5;
            this.lbnhande.Text = ".............................................................................";
            // 
            // lbmasach
            // 
            this.lbmasach.AutoSize = true;
            this.lbmasach.Location = new System.Drawing.Point(80, 156);
            this.lbmasach.Name = "lbmasach";
            this.lbmasach.Size = new System.Drawing.Size(238, 13);
            this.lbmasach.TabIndex = 4;
            this.lbmasach.Text = ".............................................................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tác giả: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhan đề: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã sách: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(12, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "GIA HẠN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmgiahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmgiahan";
            this.Text = "Gia hạn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnhap;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbtacgia;
        private System.Windows.Forms.Label lbnhande;
        private System.Windows.Forms.Label lbmasach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
    }
}