using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace QLTHUVIEN
{
    public partial class frmTIMKIEM : Form
    {
        public frmTIMKIEM()
        {
            InitializeComponent();
        }

        private void frmTIMKIEM_Load(object sender, EventArgs e)
        {
            cbtimkiem.Text = "Mã sách";
        }

        public DataTable hienthi(string sqlht)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            SqlDataAdapter da = new SqlDataAdapter(sqlht, cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            cn.CloseConn();
        }
        //private void btntimkiem_Click(object sender, EventArgs e)
        //{
        //    if(cbtimkiem.Text=="Mã sách")
        //        dgvthongtin.DataSource = hienthi("select * from sach where masach like '%" + txttimkiem.Text.Trim() + "%'");
        //    if (cbtimkiem.Text == "Nhan đề")
        //        dgvthongtin.DataSource = hienthi("select * from sach where nhande like '%" + txttimkiem.Text.Trim() + "%'");
        //    if (cbtimkiem.Text == "Tác giả")               
        //        dgvthongtin.DataSource = hienthi("select * from sach where tacgia like '%" + txttimkiem.Text.Trim() + "%'");
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (cbtimkiem.Text == "Mã sách")
                dgvthongtin.DataSource = hienthi("select * from sach where masach like '%" + txttimkiem.Text.Trim() + "%'");
            if (cbtimkiem.Text == "Nhan đề")
                dgvthongtin.DataSource = hienthi("select * from sach where nhande like '%" + txttimkiem.Text.Trim() + "%'");
            if (cbtimkiem.Text == "Tác giả")
                dgvthongtin.DataSource = hienthi("select * from sach where tacgia like '%" + txttimkiem.Text.Trim() + "%'");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
