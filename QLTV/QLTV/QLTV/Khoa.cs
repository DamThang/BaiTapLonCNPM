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
    public partial class frmkhoa : Form
    {
        Connect conn = new Connect();
        SqlCommand comm = null;
        SqlDataReader rdr;
        bool flag = false;
        public frmkhoa()
        {
            InitializeComponent();
        }

        public void Load_Dgr()
        {
            String sql = "SELECT makhoa as 'Mã khoa', tenkhoa as 'Tên khoa', diachi as 'Địa chỉ', sdt as 'Số điện thoại' FROM khoa";
            try
            {
                conn.OpenConnect();
                dataGridView1.DataSource = conn.Table(sql);
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

        public static bool CheckSo(String str)
        {
            int i;
            bool check = true;
            try
            {
                i = Int32.Parse(str);
                if (i >= 0)
                {
                    check = true;
                }
            }
            catch
            {
                check = false;
            }
            return check;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (flag == true)
            {
                String sql = "";
                if (!CheckName(txtdc.Text) || !CheckName(txtmakhoa.Text) || !CheckName(txtten.Text))
                    check = false;
                if (CheckSo(txtsdt.Text) == false)
                    check = false;
                if (txtsdt.Text.Length < 10 || txtsdt.Text.Length > 11)
                    check = false;
                if (check == true)
                {
                    try
                    {
                        conn.OpenConnect();
                        sql = "INSERT INTO khoa(makhoa,tenkhoa,diachi,sdt) VALUES ('" + txtmakhoa.Text + "',N'" + txtten.Text + "',N'" + txtdc.Text + "'," + txtsdt.Text + ")";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Thêm thành công!");
                            txtmakhoa.Clear();
                            txtdc.Clear();
                            txtsdt.Clear();
                            txtten.Clear();
                            txtmakhoa.Focus();
                        }
                        else
                            MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                        txtmakhoa.Focus();
                    }
                    finally
                    {
                        conn.CloseConnect();
                        frmkhoa_Load(sender, e);
                    }
                }
                else
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thông tin!");
            }
            else
            {
                txtmakhoa.Clear();
                txtdc.Clear();
                txtsdt.Clear();
                txtten.Clear();
                txtmakhoa.Focus();
                txtdc.Enabled = true;
                txtmakhoa.Enabled = true;
                txtsdt.Enabled = true;
                txtten.Enabled = true;
                flag = true;
            }
        }

        public void Insert(String str)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE docgia SET makhoa = '' WHERE makhoa = '" + str + "'";
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

        private void frmkhoa_Load(object sender, EventArgs e)
        {
            Load_Dgr();
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
                sql = "DELETE FROM khoa WHERE makhoa = '" + str + "'";
                if (conn.ExecuteNonSQL(sql))
                {
                    MessageBox.Show("Xóa thành công!");
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
                frmkhoa_Load(sender, e);
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
                sql = "UPDATE khoa SET makhoa = '" + txtmakhoa.Text + "', tenkhoa = N'" + txtten.Text + "', diachi = N'"+txtdc.Text+"', sdt = '"+txtsdt.Text+"' WHERE makhoa = '" + str + "'";
                if (conn.ExecuteNonSQL(sql))
                {
                    MessageBox.Show("Sửa thành công!");
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
                frmkhoa_Load(sender, e);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            txtmakhoa.Enabled = false;
            txtdc.Enabled = true;
            txtsdt.Enabled = true;
            txtten.Enabled = true;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM khoa WHERE makhoa = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                {
                    txtmakhoa.Text = rdr["makhoa"].ToString();
                    txtdc.Text = rdr["diachi"].ToString();
                    txtsdt.Text = rdr["sdt"].ToString();
                    txtten.Text = rdr["tenkhoa"].ToString();
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
