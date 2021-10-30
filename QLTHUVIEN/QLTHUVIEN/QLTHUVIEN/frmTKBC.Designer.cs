namespace QLTHUVIEN
{
    partial class frmTKBC
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbphanloai = new System.Windows.Forms.ComboBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(16, 75);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1258, 381);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // cbphanloai
            // 
            this.cbphanloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbphanloai.FormattingEnabled = true;
            this.cbphanloai.Items.AddRange(new object[] {
            "MA LOAI",
            "SO LAN MUON"});
            this.cbphanloai.Location = new System.Drawing.Point(392, 28);
            this.cbphanloai.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbphanloai.Name = "cbphanloai";
            this.cbphanloai.Size = new System.Drawing.Size(340, 23);
            this.cbphanloai.TabIndex = 31;
            this.cbphanloai.SelectedIndexChanged += new System.EventHandler(this.cbphanloai_SelectedIndexChanged);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTHOAT.Location = new System.Drawing.Point(892, 18);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(151, 40);
            this.btnTHOAT.TabIndex = 32;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "CHỌN PHÂN LOẠI";
            // 
            // frmTKBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1291, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.cbphanloai);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTKBC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ BÁO CÁO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox cbphanloai;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Label label1;
    }
}