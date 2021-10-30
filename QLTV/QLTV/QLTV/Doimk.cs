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

namespace QLTV
{
    public partial class frmdoimk : Form
    {
        public String ms = "";
        public int quyenhan = 0;
        Connect conn = new Connect();
        SqlDataReader rdr;

        public frmdoimk()
        {
            InitializeComponent();
        }

        public void Load_gr()
        {
            grbms.Text = ms;
           // MessageBox.Show(ms + " " + quyenhan);
        }

        public bool ktra_mk(String mkm, String nlmk)
        {
            if (mkm == nlmk)
                return true;
            else
                return false;
        }
        private void frmdoimk_Load(object sender, EventArgs e)
        {
            Load_gr();
        }

        private void btrs_Click(object sender, EventArgs e)
        {
            txtmkc.Clear();
            txtmkm.Clear();
            txtnlmk.Clear();
            txtmkc.Focus();
        }

        private void btchon_Click(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                if (ktra_mk(txtmkm.Text, txtnlmk.Text))
                {
                    if (quyenhan <= 0)
                    {
                        sql = "UPDATE docgia SET matkhau = HASHBYTES('MD5',N'" + txtmkm.Text + "') WHERE madocgia='" + ms + "' AND matkhau = HASHBYTES('MD5',N'" + txtmkc.Text + "')";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            txtmkc.Clear();
                            txtmkm.Clear();
                            txtnlmk.Clear();
                            txtmkc.Focus();
                        }
                        else
                            MessageBox.Show("Mật khẩu củ không đúng. Vui lòng kiểm tra lại!");
                    }
                    if (quyenhan > 0)
                    {
                        sql = "UPDATE nhanvien SET matkhau = HASHBYTES('MD5',N'" + txtmkm.Text + "') WHERE manhanvien='" + ms + "' AND matkhau = HASHBYTES('MD5',N'" + txtmkc.Text + "')";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            txtmkc.Clear();
                            txtmkm.Clear();
                            txtnlmk.Clear();
                            txtmkc.Focus();
                        }
                        else
                            MessageBox.Show("Mật khẩu củ không đúng. Vui lòng kiểm tra lại!");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại không trùng nhau. Vui lòng kiểm tra lại!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
