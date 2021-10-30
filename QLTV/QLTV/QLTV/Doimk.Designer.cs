namespace QLTV
{
    partial class frmdoimk
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
            this.grbms = new System.Windows.Forms.GroupBox();
            this.btrs = new System.Windows.Forms.Button();
            this.btchon = new System.Windows.Forms.Button();
            this.txtnlmk = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.txtmkc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbms.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // grbms
            // 
            this.grbms.Controls.Add(this.btrs);
            this.grbms.Controls.Add(this.btchon);
            this.grbms.Controls.Add(this.txtnlmk);
            this.grbms.Controls.Add(this.txtmkm);
            this.grbms.Controls.Add(this.txtmkc);
            this.grbms.Controls.Add(this.label4);
            this.grbms.Controls.Add(this.label3);
            this.grbms.Controls.Add(this.label2);
            this.grbms.Location = new System.Drawing.Point(12, 57);
            this.grbms.Name = "grbms";
            this.grbms.Size = new System.Drawing.Size(260, 192);
            this.grbms.TabIndex = 1;
            this.grbms.TabStop = false;
            this.grbms.Text = "Thay đổi";
            // 
            // btrs
            // 
            this.btrs.Location = new System.Drawing.Point(149, 157);
            this.btrs.Name = "btrs";
            this.btrs.Size = new System.Drawing.Size(75, 23);
            this.btrs.TabIndex = 7;
            this.btrs.Text = "RESET";
            this.btrs.UseVisualStyleBackColor = true;
            this.btrs.Click += new System.EventHandler(this.btrs_Click);
            // 
            // btchon
            // 
            this.btchon.Location = new System.Drawing.Point(46, 157);
            this.btchon.Name = "btchon";
            this.btchon.Size = new System.Drawing.Size(75, 23);
            this.btchon.TabIndex = 6;
            this.btchon.Text = "CHỌN";
            this.btchon.UseVisualStyleBackColor = true;
            this.btchon.Click += new System.EventHandler(this.btchon_Click);
            // 
            // txtnlmk
            // 
            this.txtnlmk.Location = new System.Drawing.Point(127, 107);
            this.txtnlmk.Name = "txtnlmk";
            this.txtnlmk.Size = new System.Drawing.Size(127, 20);
            this.txtnlmk.TabIndex = 5;
            this.txtnlmk.UseSystemPasswordChar = true;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(127, 66);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(127, 20);
            this.txtmkm.TabIndex = 4;
            this.txtmkm.UseSystemPasswordChar = true;
            // 
            // txtmkc
            // 
            this.txtmkc.Location = new System.Drawing.Point(127, 23);
            this.txtmkc.Name = "txtmkc";
            this.txtmkc.Size = new System.Drawing.Size(127, 20);
            this.txtmkc.TabIndex = 3;
            this.txtmkc.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập lại mật khẩu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập mật khẩu mới: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mật khẩu cũ: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbms);
            this.Controls.Add(this.label1);
            this.Name = "frmdoimk";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmdoimk_Load);
            this.grbms.ResumeLayout(false);
            this.grbms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbms;
        private System.Windows.Forms.Button btrs;
        private System.Windows.Forms.Button btchon;
        private System.Windows.Forms.TextBox txtnlmk;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.TextBox txtmkc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}