namespace QLTV
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btlg = new System.Windows.Forms.Button();
            this.btrs = new System.Windows.Forms.Button();
            this.chbrm = new System.Windows.Forms.CheckBox();
            this.chbqh = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu: ";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(106, 54);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(178, 20);
            this.txttk.TabIndex = 3;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(106, 94);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(178, 20);
            this.txtmk.TabIndex = 4;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // btlg
            // 
            this.btlg.Location = new System.Drawing.Point(48, 142);
            this.btlg.Name = "btlg";
            this.btlg.Size = new System.Drawing.Size(75, 23);
            this.btlg.TabIndex = 5;
            this.btlg.Text = "LOGIN";
            this.btlg.UseVisualStyleBackColor = true;
            this.btlg.Click += new System.EventHandler(this.btlg_Click);
            // 
            // btrs
            // 
            this.btrs.Location = new System.Drawing.Point(190, 142);
            this.btrs.Name = "btrs";
            this.btrs.Size = new System.Drawing.Size(75, 23);
            this.btrs.TabIndex = 6;
            this.btrs.Text = "RESET";
            this.btrs.UseVisualStyleBackColor = true;
            this.btrs.Click += new System.EventHandler(this.btrs_Click);
            // 
            // chbrm
            // 
            this.chbrm.AutoSize = true;
            this.chbrm.Location = new System.Drawing.Point(106, 119);
            this.chbrm.Name = "chbrm";
            this.chbrm.Size = new System.Drawing.Size(77, 17);
            this.chbrm.TabIndex = 7;
            this.chbrm.Text = "Remember";
            this.chbrm.UseVisualStyleBackColor = true;
            this.chbrm.CheckedChanged += new System.EventHandler(this.chbrm_CheckedChanged);
            // 
            // chbqh
            // 
            this.chbqh.AutoSize = true;
            this.chbqh.Location = new System.Drawing.Point(190, 119);
            this.chbqh.Name = "chbqh";
            this.chbqh.Size = new System.Drawing.Size(75, 17);
            this.chbqh.TabIndex = 8;
            this.chbqh.Text = "Nhân viên";
            this.chbqh.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 172);
            this.Controls.Add(this.chbqh);
            this.Controls.Add(this.chbrm);
            this.Controls.Add(this.btrs);
            this.Controls.Add(this.btlg);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btlg;
        private System.Windows.Forms.Button btrs;
        private System.Windows.Forms.CheckBox chbrm;
        private System.Windows.Forms.CheckBox chbqh;
    }
}