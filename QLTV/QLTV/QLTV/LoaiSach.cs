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
using System.Text.RegularExpressions;

namespace QLTV
{
    public partial class frmloaisach : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr;
        bool flag = false;
        String[] a1; String[] a2; String[] a3; String[] a4; String[] a5; String[] a6; String[] a7; String[] a8; String[] a9; String[] a10;
        int dem = 0;

        public frmloaisach()
        {
            InitializeComponent();
        }

        public void LuuInsert(String str)
        {
            a1 = new String[100]; a2 = new String[100]; a3 = new String[100]; a4 = new String[100]; a5 = new String[100]; a6 = new String[100]; a7 = new String[100]; a8 = new String[100]; a9 = new String[100]; a10 = new String[100];
            String sql = "";
            dem = 0;
            int i = 0;
            try
            {
                sql = "SELECT * FROM sach WHERE maloai = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                {
                    a1[i] = rdr[0].ToString();
                    a2[i] = rdr[1].ToString();
                    a3[i] = rdr[2].ToString();
                    a4[i] = rdr[3].ToString();
                    a5[i] = rdr[4].ToString();
                    a6[i] = rdr[5].ToString();
                    a7[i] = rdr[7].ToString();
                    a8[i] = rdr[8].ToString();
                    a9[i] = rdr[9].ToString();
                    a10[i] = rdr[10].ToString();
                    dem++;
                    i++;
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

        public void Insert(String str)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE sach SET maloai = '' WHERE maloai = '" + str + "'";
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

        public void Load_Dgr()
        {
            String sql = "SELECT maloai as 'Mã loại', tenloai as 'Tên loại' FROM phanloai";
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

        public static bool CheckName(string full_name)
        {

            if (string.IsNullOrEmpty(full_name))
            {
                return false;
            }
            else
            {
                string str = full_name.TrimEnd().TrimStart();
                string pattern = @"^[^0-9]+$";
                int i = str.IndexOf(" ");
                if (i == -1)
                    return true;
                else
                    if (Regex.IsMatch(str, pattern))
                    return true;
                else
                    return false;
            }
        }

        private void frmloaisach_Load(object sender, EventArgs e)
        {
            Load_Dgr();
            //conn.OpenConnect();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (flag == true)
            {
                String sql = "";
                if (!CheckName(txtmaloai.Text) || !CheckName(txtten.Text))
                    check = false;
                if (check == true)
                {
                    try
                    {
                        conn.OpenConnect();
                        sql = "INSERT INTO phanloai(maloai,tenloai) VALUES('" + txtmaloai.Text + "',N'" + txtten.Text + "')";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Thêm thành công!");
                            txtten.Clear();
                            txtmaloai.Clear();
                            txtmaloai.Focus();
                            //frmloaisach_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    finally
                    {
                        conn.CloseConnect();
                        frmloaisach_Load(sender, e);
                    }
                }
                else
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thông tin!");
            }
            else
            {
                txtmaloai.Focus();
                txtmaloai.Enabled = true;
                txtten.Enabled = true;
                txtmaloai.Clear();
                txtten.Clear();
                flag = true;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            try
            {
                Insert(str);
                conn.OpenConnect();
                sql = "DELETE FROM phanloai WHERE maloai = '" + str + "'";
                if (conn.ExecuteNonSQL(sql))
                {
                    MessageBox.Show("Xóa thành công!");
                    //frmloaisach_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa thất bại!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
                frmloaisach_Load(sender, e);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE phanloai SET maloai = '" + txtmaloai.Text + "', tenloai = N'" + txtten.Text + "' WHERE maloai = '" + str + "'";
                if (conn.ExecuteNonSQL(sql))
                {
                    MessageBox.Show("Sửa thành công!");
                    //frmloaisach_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
                frmloaisach_Load(sender, e);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            txtmaloai.Enabled = false;
            txtten.Enabled = true;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM phanloai WHERE maloai = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                {
                    txtmaloai.Text = rdr["maloai"].ToString();
                    txtten.Text = rdr["tenloai"].ToString();
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
    }
}
