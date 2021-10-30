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
    public partial class frmquyenhan : Form
    {
        Connect conn = new Connect();
        bool flag = false;
        SqlDataReader rdr;
        int count = 0;
        public frmquyenhan()
        {
            InitializeComponent();
        }

        public int Chuyen_cbb1(String str)
        {
            int tam = 1;
            switch (str)
            {
                case "Admin": tam = 1; break;
                case "Thủ thư": tam = 2; break;
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

        public void Load_Dgr()
        {
            String sql = "SELECT manhanvien as 'Mã nhân viên', hoten as 'Họ tên', quyenhan as 'Quyền hạn' FROM nhanvien";
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

        private void frmquyenhan_Load(object sender, EventArgs e)
        {
            Load_Dgr();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            String sql = "";
            grbqh.Enabled = true;
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM nhanvien WHERE manhanvien = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                
                while (rdr.Read())
                {
                    lbqh.Text = Chuyen_cbb2(Int32.Parse(rdr["quyenhan"].ToString()));
                    lbmnv.Text = rdr["manhanvien"].ToString();
                    lbhten.Text = rdr["hoten"].ToString();
                    lbdc.Text = rdr["diachi"].ToString();
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

        private void btchon_Click(object sender, EventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
            flag = false;
            bool check = true;
            String sql = "";
            if (txttk.Text.Trim() == "")
                check = false;
            if (check == true)
            {
                try
                {
                    conn.OpenConnect();
                    sql = "UPDATE nhanvien SET quyenhan = " + Chuyen_cbb1(cbbqh.Text) + " WHERE manhanvien = '" + str + "'";
                    if (conn.ExecuteNonSQL(sql))
                    {
                        MessageBox.Show("Thay đổi thành công!");
                    }
                    else
                        MessageBox.Show("Thay đổi thất bại!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    conn.CloseConnect();
                    frmquyenhan_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Cập nhật quyền hạn thất bại. Vui lòng kiểm tra lại thông tin!");
            }
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT manhanvien as 'Mã nhân viên', hoten as 'Họ tên', quyenhan as 'Quyền hạn' FROM nhanvien WHERE manhanvien LIKE '" + txttk.Text + "%' OR hoten LIKE '" + txttk.Text + "%'";
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
