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
    public partial class frmthongtin : Form
    {
        public String ms = "";
        public int quyenhan = 0;
        Connect conn = new Connect();
        SqlDataReader rdr;

        public frmthongtin()
        {
            InitializeComponent();
        }

        public void Load_tt()
        {
            String sql = "";
            try
            {
                //MessageBox.Show(ms + " " + quyenhan);
                conn.OpenConnect();
                if(quyenhan==0)
                {
                    sql = "SELECT * FROM docgia WHERE madocgia ='" + ms + "'";
                    rdr = conn.ExecuteSQL(sql);
                    while(rdr.Read())
                    {
                        lbms.Text = ms;
                        lbht.Text = rdr["hoten"].ToString();
                        lbdc.Text = rdr["diachi"].ToString();
                        lbnlt.Text = rdr["ngaylapthe"].ToString();
                        lbqh.Text = "Đọc giả";
                        lbns.Text = rdr["ngaysinh"].ToString();
                    }
                }
                if(quyenhan==1)
                {
                    sql = "SELECT * FROM nhanvien WHERE manhanvien ='" + ms + "'";
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                    {
                        lbms.Text = ms;
                        lbht.Text = rdr["hoten"].ToString();
                        lbdc.Text = rdr["diachi"].ToString();
                        if (rdr["quyenhan"].ToString() == "1")
                        {
                            lbqh.Text = "Admin";
                        }
                    }
                }
                if(quyenhan==2)
                {
                    sql = "SELECT * FROM nhanvien WHERE manhanvien ='" + ms + "'";
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                    {
                        lbms.Text = ms;
                        lbht.Text = rdr["hoten"].ToString();
                        lbdc.Text = rdr["diachi"].ToString();
                        if (rdr["quyenhan"].ToString() == "2")
                        {
                            lbqh.Text = "Thủ thư";
                        }
                    }
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

        private void Thongtin_Load(object sender, EventArgs e)
        {
            Load_tt();
        }
    }
}
