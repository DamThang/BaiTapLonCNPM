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

namespace QLTHUVIEN
{
    public partial class frmthongtincanhan : Form
    {
        xuly xl = new xuly();
        public string ma = "";
        public frmthongtincanhan()
        {
            InitializeComponent();
        }
        private void frmthongtin_Load(object sender, EventArgs e)
        {
            if(frmDangnhap.quyenhan=="admin" )
            {
                dgvthongtin.DataSource = xl.thongtincanhan(frmDangnhap.aidangdangnhap);
            }
            else 
            if(frmDangnhap.quyenhan == "thuthu")
            {
                dgvthongtin.DataSource = xl.thongtincanhan(frmDangnhap.aidangdangnhap);
            }               
            else
                dgvthongtin.DataSource = xl.thongtincanhan2(frmDangnhap.aidangdangnhap);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            
        }
    }
}
