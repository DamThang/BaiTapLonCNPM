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
    public partial class frmthongke : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr;
        int count = 0;

        public frmthongke()
        {
            InitializeComponent();
        }

        public void Load_cbb()
        {
            String sql = "SELECT maloai FROM phanloai";
            try
            {
                conn.OpenConnect();
                if (count == 0)
                {
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                        cbbloai.Items.Add(rdr[0]);
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
        private void frmthongke_Load(object sender, EventArgs e)
        {
            Load_cbb();
            count++;
        }

        private void cbbloai_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void cbbloai_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void cbbloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbloai_TextChanged(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM phanloai WHERE maloai = '" + cbbloai.Text + "'";
            try
            {
                conn.OpenConnect();
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                    lbten.Text = rdr["tenloai"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
        }

        private void btchon_Click(object sender, EventArgs e)
        {
            String sql = "SELECT masach as 'Mã sách', nhande as 'Nhan đề', solanmuon as 'Số lần mượn' FROM sach WHERE maloai = '"+cbbloai.Text+"' ORDER BY solanmuon DESC" ;
            try
            {
                conn.OpenConnect();
                dataGridView1.DataSource = conn.Table(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
        }
    }
}
