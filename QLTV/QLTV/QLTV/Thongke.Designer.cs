namespace QLTV
{
    partial class frmthongke
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbloai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.btchon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btchon);
            this.groupBox1.Controls.Add(this.lbten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbloai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 161);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại:";
            // 
            // cbbloai
            // 
            this.cbbloai.FormattingEnabled = true;
            this.cbbloai.Location = new System.Drawing.Point(67, 12);
            this.cbbloai.Name = "cbbloai";
            this.cbbloai.Size = new System.Drawing.Size(121, 21);
            this.cbbloai.TabIndex = 1;
            this.cbbloai.SelectedIndexChanged += new System.EventHandler(this.cbbloai_SelectedIndexChanged);
            this.cbbloai.TextChanged += new System.EventHandler(this.cbbloai_TextChanged);
            this.cbbloai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbloai_MouseClick);
            this.cbbloai.MouseCaptureChanged += new System.EventHandler(this.cbbloai_MouseCaptureChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại: ";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Location = new System.Drawing.Point(64, 58);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(139, 13);
            this.lbten.TabIndex = 3;
            this.lbten.Text = "............................................";
            // 
            // btchon
            // 
            this.btchon.Location = new System.Drawing.Point(212, 12);
            this.btchon.Name = "btchon";
            this.btchon.Size = new System.Drawing.Size(75, 23);
            this.btchon.TabIndex = 4;
            this.btchon.Text = "CHỌN";
            this.btchon.UseVisualStyleBackColor = true;
            this.btchon.Click += new System.EventHandler(this.btchon_Click);
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 318);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmthongke";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmthongke_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Button btchon;
    }
}