using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTHUVIEN
{
    

    public partial class frmHeThongQLTV : Form
    {
        //public static string UsertName = "";

        public frmHeThongQLTV()
        {
            InitializeComponent();
        }

        private void frmHeThongQLTV_Load(object sender, EventArgs e)
        {
            xuly xl = new xuly();
            lblXinchao1.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
            lblXinchao2.Text = xl.XinChao2(frmDangnhap.aidangdangnhap);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.LightBlue;
                }
                if (frmDangnhap.quyenhan == "thuthu")
                {
                    qUẢNTRỊHỆTHỐNGToolStripMenuItem.Visible = false;
                    
                    nguoiToolStripMenuItem.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
                }
                if (frmDangnhap.quyenhan == "admin")
                {
                    qUẢNLÝSÁCHToolStripMenuItem.Visible = false;
                    qUẢNLÝMƯỢNTRẢToolStripMenuItem.Visible = false;
                    qUẢNLÝĐỌCGIẢToolStripMenuItem.Visible = false;
                    tKBCToolStripMenuItem.Visible = false;
                    nguoiToolStripMenuItem.Text = xl.XinChao1(frmDangnhap.aidangdangnhap);
                }
                if (frmDangnhap.quyenhan == "docgia")
                {
                    qUẢNLÝSÁCHToolStripMenuItem.Visible = false;
                    qUẢNLÝMƯỢNTRẢToolStripMenuItem.Visible = false;
                    qUẢNLÝĐỌCGIẢToolStripMenuItem.Visible = false;
                    tKBCToolStripMenuItem.Visible = false;
                    qUẢNTRỊHỆTHỐNGToolStripMenuItem.Visible = false;
                    nguoiToolStripMenuItem.Text = xl.XinChao2(frmDangnhap.aidangdangnhap);
                }
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtincanhan f = new frmthongtincanhan();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if(DialogResult.OK == dlr)
            {
                frmDangnhap f = new frmDangnhap();
                f.Show();
                this.Close();
            }
                                
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            frmdoimk f = new frmdoimk();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýThôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlythongtinsach f = new frmQuanlythongtinsach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýThôngTinĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTTDocGia f = new frmQLTTDocGia();
            f.MdiParent = this;
            f.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuontrasach f = new frmMuontrasach();
            f.MdiParent = this;
            f.Show();
        }

        private void cậpNhậtLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapnhatloaisach f = new frmCapnhatloaisach();
            f.MdiParent = this;
            f.Show();
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTIMKIEM f = new frmTIMKIEM();
            f.MdiParent = this;
            f.Show();
        }

        private void tKBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKBC f = new frmTKBC();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmQuanlykhoa f = new frmQuanlykhoa();
           // f.MdiParent = this;
           // f.Show();
        }

        private void quảnTrịNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuantringuoidung f = new frmQuantringuoidung();
            f.MdiParent = this;
            f.Show();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmphieumuon f = new frmphieumuon();
            f.MdiParent = this;
            f.Show();
        }
    }
}
