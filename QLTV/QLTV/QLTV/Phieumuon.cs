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
    public partial class frmphieumuon : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr;
        public frmphieumuon()
        {
            InitializeComponent();
        }

        public void Load_Dgr()
        {
            String sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon";
            try
            {
                Update_tt();
                Updatett();
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

        public void Updatett()
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE phieumuon SET trangthai = N'Hết hạn' WHERE ngaytra<GETDATE()";
                if (conn.ExecuteNonSQL(sql))
                {

                }
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
        public void Update_tt()
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE phieumuon SET trangthai = N'Đang mượn' WHERE ngaymuon<GETDATE() AND ngaytra>GETDATE()";
                if (conn.ExecuteNonSQL(sql))
                {

                }
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
        private void frmphieumuon_Load(object sender, EventArgs e)
        {
            Load_Dgr();
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            String sql = "";
            groupBox2.Enabled = false;
            try
            {
                conn.OpenConnect();
                sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon WHERE madocgia LIKE '" + txttk.Text + "%' OR masach LIKE '" + txttk.Text + "%' OR manhanvien LIKE '" + txttk.Text + "%'";
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

        private void lbht_Click(object sender, EventArgs e)
        {

        }

        private void lbnd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            String str1 = dataGridView1.Rows[current].Cells[2].Value.ToString();
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT pm.madocgia, pm.masach, dg.hoten, dg.diachi, dg.ngaysinh, s.nhande, s.tacgia FROM phieumuon as pm, docgia as dg, sach as s WHERE s.masach = pm.masach AND dg.madocgia = pm.madocgia AND pm.madocgia = '" + str + "' AND pm.masach = '" + str1 + "'";
                rdr = conn.ExecuteSQL(sql);
                groupBox2.Enabled = true;
                while (rdr.Read())
                {
                    lbdc.Text = rdr["diachi"].ToString();
                    lbht.Text = rdr["hoten"].ToString();
                    lbmdg.Text = rdr["madocgia"].ToString();
                    lbms.Text = rdr["masach"].ToString();
                    lbnd.Text = rdr["nhande"].ToString();
                    lbtg.Text = rdr["tacgia"].ToString();
                }

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

        private void btin_Click(object sender, EventArgs e)
        {
            frminpm frm = new frminpm();
            frm.madg = lbmdg.Text;
            frm.masach = lbms.Text;
            
            frm.ShowDialog();
        }
    }
}
