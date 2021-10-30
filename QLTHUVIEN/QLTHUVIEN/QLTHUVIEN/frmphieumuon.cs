using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTHUVIEN
{
    public partial class frmphieumuon : Form
    {
        public frmphieumuon()
        {
            InitializeComponent();
        }
        private void PHIEUMUON()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string sqlht = "select * from phieumuon";
            SqlDataAdapter da = new SqlDataAdapter(sqlht, cn.con);
            RPphieumuon rpt = new RPphieumuon();
            crystalReportViewer1.ReportSource = rpt;
            cn.CloseConn();
        }
        //private void btnthoat_Click(object sender, EventArgs e)
        //{
        //    this.Dispose();
        //}

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            PHIEUMUON();
        }

        private void frmphieumuon_Load(object sender, EventArgs e)
        {

        }
    }
}
