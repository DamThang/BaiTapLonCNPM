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
    public partial class frmsach : Form
    {
        Connect conn = new Connect();
        bool flag = false;
        SqlDataReader rdr;
        int count = 0;
        public frmsach()
        {
            InitializeComponent();
        }

        public void Load_Dgr()
        {
            String sql = "SELECT masach as 'Mã sách', nhande as 'Nhan đề', sotrang as 'Số trang', namxb as 'Năm xuất bản', lanxb as 'Lần xuất bản', solanmuon as 'Số lần mượn', maloai as 'Mã loại', nxb as 'Nhà xuất bản', tacgia as 'Tác giả', ngaynhap as 'Ngày nhập', soluong as 'Số lượng' FROM sach";
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

        public static bool CheckMS(string ms)
        {
            string pattern = @"^MS\d{4}$";
            if (!Regex.IsMatch(ms, pattern))
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

        public static bool CheckSo(String str)
        {
            int i;
            bool check = true;
            try
            {
                i = Int32.Parse(str);
                if(i>=0)
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

        public void Load_cbb()
        {
            String sql = "SELECT maloai FROM phanloai";
            try
            {
                if (count == 0)
                {
                    conn.OpenConnect();
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                        cbbmaloai.Items.Add(rdr[0]);
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
        private void frmsach_Load(object sender, EventArgs e)
        {
            Load_Dgr();
            Load_cbb();
            count++;
        }
        public bool Search_dg(String str)
        {
            bool check = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT COUNT(*) FROM phieumuon WHERE masach = '" + str + "'";
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
                    sql = "DELETE FROM sach WHERE masach = '" + str + "'";
                    if (conn.ExecuteNonSQL(sql))
                    {
                        MessageBox.Show("Xóa thành công!");

                    }
                }
                else
                    MessageBox.Show("Sách vẫn còn mượn. Xóa thất bại!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
                frmsach_Load(sender, e);
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM sach WHERE masach = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                txtlxb.Enabled = true;
                txtmasach.Enabled = false;
                txtnamxb.Enabled = true;
                txtnhande.Enabled = true;
                txtnhaxb.Enabled = true;
                txtsotrang.Enabled = true;
                txttacgia.Enabled = true;
                cbbmaloai.Enabled = true;
                txtsoluong.Enabled = true;
                while (rdr.Read())
                {
                    txttacgia.Text = rdr["tacgia"].ToString();
                    txtsotrang.Text = rdr["sotrang"].ToString();
                    txtnhaxb.Text = rdr["nxb"].ToString();
                    txtnhande.Text = rdr["nhande"].ToString();
                    txtnamxb.Text = rdr["namxb"].ToString();
                    txtmasach.Text = rdr["masach"].ToString();
                    txtlxb.Text = rdr["lanxb"].ToString();
                    String cbb = rdr["maloai"].ToString();
                    txtsoluong.Text = rdr["soluong"].ToString();
                    conn.CloseConnect();
                    conn.OpenConnect();
                    if (conn.CountExecuteSQL("SELECT COUNT(*) FROM phanloai WHERE maloai = '" + cbb + "'") > 0)
                    {
                        conn.CloseConnect();
                        conn.OpenConnect();
                        rdr = conn.ExecuteSQL("SELECT * FROM phanloai WHERE maloai = '" + cbb + "'");

                        rdr.Read();
                        lbtenloai.Text = rdr["tenloai"].ToString();
                        cbbmaloai.Text = rdr["maloai"].ToString();
                    }
                    else
                    {
                        cbbmaloai.Text = "";
                        lbtenloai.Text = ".......................................................";
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.CloseConnect();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (flag == true)
            {
                if (!CheckMS(txtmasach.Text))
                    check = false;
                if (!CheckName(txtnhande.Text))
                    check = false;
                if (CheckSo(txtlxb.Text) == false || CheckSo(txtnamxb.Text) == false || CheckSo(txtsoluong.Text) == false || CheckSo(txtsotrang.Text) == false)
                    check = false;
                if (txttacgia.Text.Trim() == "" || txtsotrang.Text.Trim() == "" | txtsoluong.Text.Trim() == "" || txtnhaxb.Text.Trim() == "" || txtnhande.Text.Trim() == "" || txtnamxb.Text.Trim() == "" || txtmasach.Text.Trim() == "" || txtlxb.Text.Trim() == "" || cbbmaloai.Text.Trim() == "")
                    check = false;
                if (txtnamxb.Text.Length < 3)
                    check = false;
                String sql = "";
                if (check == true)
                {
                    try
                    {
                        conn.OpenConnect();
                        sql = "INSERT INTO sach(masach, nhande, sotrang, namxb, lanxb, solanmuon, maloai, nxb, tacgia, ngaynhap, soluong) VALUES('" 
                            + txtmasach.Text + "',N'" 
                            + txtnhande.Text + "'," 
                            + txtsotrang.Text + "," 
                            + txtnamxb.Text + "," 
                            + txtlxb.Text + ",0,'" 
                            + cbbmaloai.Text + "',N'" 
                            + txtnhaxb.Text + "',N'" 
                            + txttacgia.Text + "','" 
                            + DateTime.Today + "'," 
                            + txtsoluong.Text + ")";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Thêm thành công!");
                            txttacgia.Clear();
                            txtsotrang.Clear();
                            txtnhaxb.Clear();
                            txtnhande.Clear();
                            txtnamxb.Clear();
                            txtmasach.Clear();
                            txtlxb.Clear();
                            txtsoluong.Clear();
                            txtmasach.Focus();
                        }
                        else
                            MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                        txtmasach.Focus();
                    }
                    finally
                    {
                        conn.CloseConnect();
                        frmsach_Load(sender, e);
                    }
                }
                else
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại!");
            }
            else
            {
                flag = true;
                txttacgia.Clear();
                txtsotrang.Clear();
                txtnhaxb.Clear();
                txtnhande.Clear();
                txtnamxb.Clear();
                txtmasach.Clear();
                txtlxb.Clear();
                txtmasach.Focus();
                txtsoluong.Clear();
                txtlxb.Enabled = true;
                txtmasach.Enabled = true;
                txtnamxb.Enabled = true;
                txtnhande.Enabled = true;
                txtnhaxb.Enabled = true;
                txtsotrang.Enabled = true;
                txttacgia.Enabled = true;
                cbbmaloai.Enabled = true;
                txtsoluong.Enabled = true;              
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
                sql = "UPDATE sach SET masach = '" 
                    + txtmasach.Text + "', nhande = N'" 
                    + txtnhande.Text + "', sotrang = " 
                    + txtsotrang.Text + ",namxb=" 
                    + txtnamxb.Text + ",lanxb=" 
                    + txtlxb.Text + ",maloai=N'" 
                    + cbbmaloai.Text + "',nxb=N'" 
                    + txtnhaxb.Text + "',tacgia=N'" 
                    + txttacgia.Text + "', soluong =" 
                    + txtsoluong.Text + " WHERE masach = '" 
                    + str + "'";
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
                frmsach_Load(sender, e);
            }
        }

        private void cbbmaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbmaloai_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cbbmaloai_TextChanged(object sender, EventArgs e)
        {
            if (flag == true)
            {
                String sql = "";
                try
                {
                    conn.OpenConnect();
                    sql = "SELECT * FROM phanloai WHERE maloai = '" + cbbmaloai.Text + "'";
                    rdr = conn.ExecuteSQL(sql);
                    while (rdr.Read())
                    {
                        lbtenloai.Text = rdr["tenloai"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.CloseConnect();
                    frmsach_Load(sender, e);
                }
            }
        }
    }
}
