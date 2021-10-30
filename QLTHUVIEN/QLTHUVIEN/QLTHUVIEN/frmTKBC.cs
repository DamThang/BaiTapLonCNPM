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
    public partial class frmTKBC : Form
    {
        public frmTKBC()
        {
            InitializeComponent();
        }
        private void phansachtheoloai()
        {
        Connection cn = new Connection();
        cn.OpenConn();
        string sqlht = "select * from sach";
        SqlDataAdapter da = new SqlDataAdapter(sqlht, cn.con);
        RPphansachtheoloai rpt = new RPphansachtheoloai();
        crystalReportViewer1.ReportSource = rpt;
        cn.CloseConn();
        }
        private void phansachtheoSLM()
        {
        Connection cn = new Connection();
        cn.OpenConn();
        string sqlht = "select * from sach oder by solanmuon asc";
        SqlDataAdapter da = new SqlDataAdapter(sqlht, cn.con);
        RPphansachtheoSLM rpt = new RPphansachtheoSLM();
        crystalReportViewer1.ReportSource = rpt;
        cn.CloseConn();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbphanloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbphanloai.Text.CompareTo("MA LOAI") == 0)
            {
                phansachtheoloai();
            }
            else
                 if (cbphanloai.Text.CompareTo("SO LAN MUON") == 0)
            {
                phansachtheoSLM();
            }
        }
    }
}
