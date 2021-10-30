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
    public partial class frmdg : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr = null;
        int count = 0;
        bool flag = false;
        public frmdg()
        {
            InitializeComponent();
        }
        public void Load_Dgr()
        {
            String sql = "SELECT madocgia as 'Mã đọc giả',hoten as 'Họ tên',ngaysinh as 'Ngày sinh',makhoa as 'Mã khoa',diachi as 'Địa chỉ',ngaylapthe as 'Ngày lập thẻ',matkhau as 'Mật khẩu'FROM docgia";
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

        public static bool CheckMDG(string mdg)
        {
            string pattern = @"^DG\d{4}$";
            if (!Regex.IsMatch(mdg, pattern))
                return false;
            return true;
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

        public void Load_cbb()
        {
            String sql = "SELECT makhoa FROM khoa";
            try
            {
                if (count == 0)
                {
                    conn.OpenConnect();
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                        cbbk.Items.Add(rdr[0]);
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

        private void frmdg_Load(object sender, EventArgs e)
        {
            Load_Dgr();
            Load_cbb();
            count++;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (flag == true)
            {
                String sql = "";
                if (!CheckMDG(txtmdg.Text) || !CheckName(txtten.Text))
                    check = false;
                if (txtten.Text.Trim() == "" || txtmk.Text.Trim() == "" || txtdc.Text.Trim() == "" || cbbk.Text.Trim() == "")
                    check = false;
                if (check == true)
                {
                    try
                    {
                        conn.OpenConnect();
                        sql = "INSERT INTO docgia(madocgia,hoten,ngaysinh,makhoa,diachi,ngaylapthe,matkhau) VALUES ('" + txtmdg.Text + "',N'" + txtten.Text + "','" + datengs.Text + "','" + cbbk.Text + "',N'" + txtdc.Text + "','" + DateTime.Today + "',HASHBYTES('MD5',N'" + txtmk.Text + "'))";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Thêm thành công!");
                            txtmk.Clear();
                            txtdc.Clear();
                            txtmdg.Clear();
                            txtmdg.Focus();
                            txtten.Clear();
                        }
                        else
                            MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                        txtmdg.Focus();
                    }
                    finally
                    {
                        conn.CloseConnect();
                        frmdg_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thông tin.");
                }
            }
            else
            {
                txtten.Enabled = true;
                txtmk.Enabled = true;
                txtmdg.Enabled = true;
                txtdc.Enabled = true;
                txtdc.Clear();
                txtmdg.Clear();
                txtmk.Clear();
                txtten.Clear();
                txtmdg.Focus();
                cbbk.Enabled = true;
                datengs.Enabled = true;
                flag = true;
            }
        }

        public bool Search_dg(String str)
        {
            bool check = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT COUNT(*) FROM phieumuon WHERE madocgia = '" + str + "'";
                if (conn.CountExecuteSQL(sql) >= 1)
                {
                    check = true;
                }
                else
                    check = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
            }
            return check;
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            String sql = "";
            try
            {
                if (Search_dg(str) == false)
                {
                    conn.OpenConnect();
                    sql = "DELETE FROM docgia WHERE madocgia = '" + str + "'";
                    if (conn.ExecuteNonSQL(sql))
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Đọc giả còn mượn sách. Không thể xóa!");
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
                frmdg_Load(sender, e);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            txtdc.Enabled = true;
            txtmdg.Enabled = false;
            txtmk.Enabled = false;
            txtten.Enabled = true;
            datengs.Enabled = true;
            cbbk.Enabled = true;
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM docgia WHERE madocgia = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                {
                    txtmdg.Text = rdr["madocgia"].ToString();
                    txtdc.Text = rdr["diachi"].ToString();
                    txtmk.Enabled = false;
                    txtten.Text = rdr["hoten"].ToString();
                    cbbk.Text = rdr["makhoa"].ToString();
                    datengs.Text = rdr["ngaysinh"].ToString();
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

        private void btsua_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "UPDATE docgia SET madocgia = '" + txtmdg.Text + "', hoten = N'" + txtten.Text + "', diachi = N'" + txtdc.Text + "', ngaysinh = '" + datengs.Text + "', makhoa = '" + cbbk.Text + "' WHERE madocgia = '" + str + "'";
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
                frmdg_Load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
