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
    public partial class frmnhanvien : Form
    {
        Connect conn = new Connect();
        bool flag = false;
        SqlDataReader rdr;
        int count = 0;
        public frmnhanvien()
        {
            InitializeComponent();
        }

        public void Load_Dgr()
        {
            String sql = "SELECT manhanvien as 'Mã nhân viên', hoten as 'Họ tên', diachi as 'Địa chỉ', matkhau as 'Mật khẩu', quyenhan as 'Quyền hạn' FROM nhanvien";
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

        public static bool CheckMNV(string mscb)
        {
            string pattern = @"^NV\d{3}$";
            if (!Regex.IsMatch(mscb, pattern))
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

        public int Chuyen_cbb1(String str)
        {
            int tam = 1;
            switch (str)
            {
                case "Admin": tam=1; break;
                case "Thủ thư": tam=2; break;
            }
            return tam;
        }

        public String Chuyen_cbb2(int x)
        {
            String tam = "";
            switch (x)
            {
                case 1: tam = "Admin"; break;
                case 2: tam = "Thủ thư"; break;
            }
            return tam;
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            Load_Dgr();
            count++;
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
                sql = "SELECT * FROM nhanvien WHERE manhanvien = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                txtht.Enabled = true;
                txtdc.Enabled = true;
                txtmanv.Enabled = false;
                txtmk.Enabled = false;
                cbbqh.Enabled = false;
                while (rdr.Read())
                {
                    txtmanv.Text = rdr["manhanvien"].ToString();
                    txtmk.Text = rdr["matkhau"].ToString();
                    txtht.Text = rdr["hoten"].ToString();
                    txtdc.Text = rdr["diachi"].ToString();
                    cbbqh.Text = Chuyen_cbb2(Int32.Parse(rdr["quyenhan"].ToString()));
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
                sql = "UPDATE nhanvien SET hoten = N'" + txtht.Text + "', diachi = N'" + txtdc.Text + "' WHERE manhanvien = '" + str + "'";
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
                frmnhanvien_Load(sender, e);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "DELETE FROM nhanvien WHERE manhanvien = '" + str + "'";
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
                frmnhanvien_Load(sender, e);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (flag == true)
            {
                if (txtmanv.Text.Trim() == "" || txtht.Text.Trim() == "" || txtdc.Text.Trim() == "" || txtmk.Text.Trim() == "" || cbbqh.Text.Trim() == "")
                {
                    check = false;
                }
                if (!CheckMNV(txtmanv.Text))
                    check = false;
                if (!CheckName(txtht.Text))
                    check = false;
                if (check == true)
                {
                    String sql = "";
                    try
                    {
                        conn.OpenConnect();
                        sql = "INSERT INTO nhanvien(manhanvien, hoten, diachi, matkhau, quyenhan) VALUES ('" + txtmanv.Text + "', N'" + txtht.Text + "', N'" + txtdc.Text + "', HASHBYTES('MD5',N'" + txtmk.Text + "'), " + Chuyen_cbb1(cbbqh.Text) + ")";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("Thêm thành công!");
                            txtmk.Clear();
                            txtmanv.Clear();
                            txtht.Clear();
                            txtdc.Clear();
                            txtmanv.Focus();
                        }
                        else
                            MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin!");
                        txtmanv.Focus();
                    }
                    finally
                    {
                        conn.CloseConnect();
                        frmnhanvien_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại thông tin!");
                }
            }
            else
            {
                flag = true;
                txtmk.Enabled = true;
                txtmanv.Enabled = true;
                txtht.Enabled = true;
                txtdc.Enabled = true;
                cbbqh.Enabled = true;
                txtmk.Clear();
                txtmanv.Clear();
                txtht.Clear();
                txtdc.Clear();
                txtmanv.Focus();

            }
        }

        private void grpbtt_Enter(object sender, EventArgs e)
        {

        }
    }
}
