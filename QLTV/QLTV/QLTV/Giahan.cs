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
    public partial class frmgiahan : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr;
        public frmgiahan()
        {
            InitializeComponent();
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT COUNT(*) FROM phieumuon WHERE madocgia = '" + txtmadg.Text + "'";
                if (conn.CountExecuteSQL(sql) > 0)
                {
                    sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon WHERE madocgia = '" + txtmadg.Text + "'";
                    dataGridView1.DataSource = conn.Table(sql);
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã đọc giả sai hoặc chưa từng mượn sách. Vui lòng kiểm tra lại!");
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int current = dataGridView1.CurrentCell.RowIndex;
            String str = dataGridView1.Rows[current].Cells[2].Value.ToString();
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT * FROM sach WHERE masach = '" + str + "'";
                rdr = conn.ExecuteSQL(sql);
                while (rdr.Read())
                {
                    lbmasach.Text = rdr["masach"].ToString();
                    lbnhande.Text = rdr["nhande"].ToString();
                    lbtacgia.Text = rdr["tacgia"].ToString();
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

        public bool Check_gh()
        {
            bool check = false;
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT trangthai FROM phieumuon WHERE madocgia = '" + txtmadg.Text + "' AND masach = '" + lbmasach.Text + "'";
                rdr = conn.ExecuteSQL(sql);
                rdr.Read();
                if (rdr["trangthai"].ToString() == "Hết hạn")
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
        private void button2_Click(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                if (Check_gh() == false)
                {
                    conn.OpenConnect();
                    sql = "UPDATE phieumuon SET ngaytra = '" + DateTime.Today.AddDays(7) + "' WHERE madocgia = '" + txtmadg.Text + "' AND masach = '" + lbmasach.Text + "'";
                    if (conn.ExecuteNonSQL(sql))
                    {
                        MessageBox.Show("Gia hạn thành công.\nVui lòng trả trước ngày: " + DateTime.Today.AddDays(7));
                        txtmadg.Focus();
                        txtmadg.Clear();
                        lbmasach.Text = ".............................................................................";
                        lbnhande.Text = ".............................................................................";
                        lbtacgia.Text = ".............................................................................";
                        groupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon WHERE madocgia = '" + txtmadg.Text + "'";
                        dataGridView1.DataSource = conn.Table(sql);
                    }

                }
                else
                {
                    MessageBox.Show("Gia hạn thất bại. Đọc giả đã hết hạn mượn. \n ---YÊU CẦU TRẢ SÁCH---");
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
