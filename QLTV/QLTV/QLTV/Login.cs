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
    public partial class Login : Form
    {
        Connect conn = new Connect();
        public String tktam = "";
        public String mktam = "";
        public bool flag = false;
        SqlDataReader rdr = null;

        public Login()
        {
            InitializeComponent();
        }

        public int docgia()
        {
            String sql = "";
            int count = 0;
            try
            {
                conn.OpenConnect();
                sql = "SELECT COUNT(madocgia) FROM docgia WHERE madocgia = '" + txttk.Text + "' AND matkhau = HASHBYTES('MD5',N'" + txtmk.Text + "')";
                count = conn.CountExecuteSQL(sql);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
            return count;
        }

        public int nhanvien()
        {
            String sql = "";
            int count = 0;
            try
            {
                conn.OpenConnect();
                sql = "SELECT COUNT(manhanvien) FROM nhanvien WHERE manhanvien = '" + txttk.Text + "' AND matkhau = HASHBYTES('MD5',N'" + txtmk.Text + "')";
                count = conn.CountExecuteSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
            return count;
        }

        public int quyenhan()
        {
            String sql = "";
            int count = 0;
            try
            {
                conn.OpenConnect();
                sql = "SELECT quyenhan FROM nhanvien WHERE manhanvien = '" + txttk.Text + "'";
                rdr = conn.ExecuteSQL(sql);
                rdr.Read();
                count = Int32.Parse(rdr["quyenhan"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
            return count;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txttk.Text = tktam;
            txtmk.Text = mktam;
            chbrm.Checked = flag;
        }

        private void btlg_Click(object sender, EventArgs e)
        {
            //int dg = docgia();
            //int nv = nhanvien();
            String sql = "";
            if (chbqh.Checked == false)
            {
                if (docgia() >= 1)
                {
                    QLTV frm = new QLTV();
                    frm.Show();
                    frm.qh = 0;
                    frm.ms = txttk.Text;
                    if (chbrm.Checked == true)
                    {
                        frm.tktam = txttk.Text;
                        frm.mktam = txtmk.Text;
                        frm.flag = true;
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
                    txttk.Clear();
                    txttk.Focus();
                    txtmk.Clear();
                }
            }
            else
            if (chbqh.Checked == true)
            {
                if (nhanvien() >= 1)
                {
                    QLTV frm = new QLTV();
                    try
                    {
                        conn.OpenConnect();
                        sql = "SELECT quyenhan FROM nhanvien WHERE manhanvien = '" + txttk.Text + "'";
                        rdr = conn.ExecuteSQL(sql);
                        frm.ms = txttk.Text;
                        rdr.Read();

                        frm.qh = Int32.Parse(rdr["quyenhan"].ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    finally
                    {
                        conn.CloseConnect();
                    }
                    frm.Show();
                    if (chbrm.Checked == true)
                    {
                        frm.tktam = txttk.Text;
                        frm.mktam = txtmk.Text;
                        frm.flag = true;
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại.");
                    txttk.Clear();
                    txttk.Focus();
                    txtmk.Clear();
                }
            }
        }

        private void btrs_Click(object sender, EventArgs e)
        {
            txttk.Clear();
            txtmk.Clear();
            txttk.Focus();
            chbrm.Checked = false;
        }

        private void chbrm_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
