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
    public partial class frmDangnhap : Form
    {
        Connection cn = new Connection();
        SqlCommand cm;
        public static string quyenhan = "";
        public static string aidangdangnhap = "";
        public static string UsertName = "";
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            xuly xl = new xuly();
            Connection cn = new Connection();          
            string USER = txtuser.Text.Replace(" ", " ");
            string PASSWORD = txtpass.Text.Replace(" ", " ");

            if (USER == "" || PASSWORD == "")
            {
                MessageBox.Show("Thông tin đang nhập không hợp lệ!!!");
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }
            else
            if (cbquyenhan.Text.CompareTo("admin") == 0)
            {
                    string sql = "SELECT Count(*) FROM THUTHU WHERE MaThuThu='" + txtuser.Text + "'and MatKhau='" + txtpass.Text + "' and QuyenHan=N'" + cbquyenhan.Text + "'";
                    try
                    {
                        cn.OpenConn();
                        if (cn.executeScala(sql) == 1)
                        {
                            quyenhan = xl.quyenhan(cbquyenhan.Text);
                            aidangdangnhap = cbquyenhan.Text;
                            this.Hide();
                            frmHeThongQLTV f = new frmHeThongQLTV();
                            f.Show();
                            frmdoimk.UsertName = txtuser.Text;
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtuser.Clear();
                            txtpass.Clear();
                            txtuser.Focus();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            else if (cbquyenhan.Text.CompareTo("thuthu") == 0)
            {
                string sql = "SELECT Count(*) FROM THUTHU WHERE MaThuThu='" + txtuser.Text + "'and MatKhau='" + txtpass.Text + "' and QuyenHan=N'" + cbquyenhan.Text + "'";
                try
                {
                    cn.OpenConn();
                    if (cn.executeScala(sql) == 1)
                    {
                        quyenhan = xl.quyenhan(USER);
                        aidangdangnhap = USER;
                        this.Hide();
                        frmHeThongQLTV f = new frmHeThongQLTV();
                        f.MdiParent = this;
                        f.Show();
                        frmdoimk.UsertName = txtuser.Text;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtuser.Clear();
                        txtpass.Clear();
                        txtuser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

            else if (xl.KTdangnhap2(USER, PASSWORD) == 1)
            {
                quyenhan = cbquyenhan.Text;
                aidangdangnhap = USER;
                this.Hide();
                frmHeThongQLTV f = new frmHeThongQLTV();
                f.Show();
                frmdoimk.UsertName = txtuser.Text;
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Clear();
                txtpass.Clear();
                txtuser.Focus();
            }
        }


        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ckbHienpass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbHienpass.Checked)
            {
                txtuser.PasswordChar = '\0';
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtuser.PasswordChar = '\0';
                txtpass.PasswordChar = '*';
            }
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
           // txtuser.Text = "NV1";
           // txtpass.Text = "123";
           // cbquyenhan.Text = "thuthu";
        }
    }
}
