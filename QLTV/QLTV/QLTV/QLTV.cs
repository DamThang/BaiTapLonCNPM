using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class QLTV : Form
    {
        public String tktam;
        public String mktam;
        public String ms = "";
        public bool flag = false;
        public int qh = 0;

        public void close_frm()
        {
            if (!(this.ActiveMdiChild == null))
            {
                this.ActiveMdiChild.Close();
            }
        }
        public QLTV()
        {
            InitializeComponent();

            //this.IsMdiContainer = true;
        }
        
        public void Load_qh()
        {
            if(qh==0)
            {
                ndToolStripMenuItem.Visible = true;
                ttcnToolStripMenuItem.Visible = true;
                dmkToolStripMenuItem.Visible = true;
                dxToolStripMenuItem.Visible = true;
                tkbkToolStripMenuItem.Visible = true;
                tkToolStripMenuItem.Visible = true;
            }
            else
                if(qh==1)
            {
                ndToolStripMenuItem.Visible = true;
                ttcnToolStripMenuItem.Visible = true;
                dmkToolStripMenuItem.Visible = true;
                dxToolStripMenuItem.Visible = true;
                tkbkToolStripMenuItem.Visible = true;
                tkToolStripMenuItem.Visible = true;
                qthtToolStripMenuItem.Visible = true;
                qtndToolStripMenuItem.Visible = true;
                pqToolStripMenuItem.Visible = true;
            }
            else
                if(qh==2)
            {
                ndToolStripMenuItem.Visible = true;
                ttcnToolStripMenuItem.Visible = true;
                dmkToolStripMenuItem.Visible = true;
                dxToolStripMenuItem.Visible = true;
                tkbkToolStripMenuItem.Visible = true;
                tkToolStripMenuItem.Visible = true;
                qlsToolStripMenuItem.Visible = true;
                qldgToolStripMenuItem.Visible = true;
                qlmtToolStripMenuItem.Visible = true;
                cnlsToolStripMenuItem.Visible = true;
                cnttsToolStripMenuItem.Visible = true;
                cnttdgToolStripMenuItem.Visible = true;
                cnkToolStripMenuItem.Visible = true;
                pmToolStripMenuItem.Visible = true;
                mtsToolStripMenuItem.Visible = true;
                ghsToolStripMenuItem.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_qh();
        }


        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.tktam = tktam;
            lg.mktam = mktam;
            lg.flag = flag;
            lg.Show();
            this.Close();
        }

        private void cậpNhậtLoạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmloaisach frm = new frmloaisach();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void cậpNhậtTTSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmsach frm = new frmsach();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void cậpNhậtTTĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmdg frm = new frmdg();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void cậpNhậtKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmkhoa frm = new frmkhoa();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void qlsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ttcnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmthongtin frm = new frmthongtin();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);
            frm.quyenhan = qh;
            frm.ms = this.ms;

            frm.Show();         
        }

        private void dmkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmdoimk frm = new frmdoimk();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);
            frm.quyenhan = qh;
            frm.ms = this.ms;

            frm.Show();

        }

        private void tkbkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmthongke frm = new frmthongke();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void qtndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmnhanvien frm = new frmnhanvien();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void pqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmquyenhan frm = new frmquyenhan();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void mtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmmuontra frm = new frmmuontra();
            frm.MdiParent = this;
            frm.manv = ms;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void pmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmphieumuon frm = new frmphieumuon();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }

        private void ghsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            close_frm();
            frmgiahan frm = new frmgiahan();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((this.ClientSize.Width - frm.Width) / 2,
                                       (this.ClientSize.Height - frm.Height) / 2);

            frm.Show();
        }
    }
}

