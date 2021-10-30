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
    public partial class frmmuontra : Form
    {
        Connect conn = new Connect();
        SqlDataReader rdr;
        public String manv = "";
        bool flagmuon = false;
        bool flagtra = false;
        int count = 0;
        public frmmuontra()
        {
            InitializeComponent();
        }

        private void frmmuontra_Load(object sender, EventArgs e)
        {
            Load_cbb();
            count++;
        }

        public bool CheckPM(String mdg, String ms)
        {
            bool check = true;
            String sql = "SELECT COUNT(*) FROM phieumuon WHERE madocgia ='" + mdg + "' AND masach = '" + ms + "'";
            conn.OpenConnect();

            int count = conn.CountExecuteSQL(sql);
            if (count == 0)
                check = true;
            else
                check = false;

            conn.CloseConnect();

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
                        cbbloai.Items.Add(rdr[0]);
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

        private void lbtenl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpbdocgia.Enabled = true;
            grpbphuongthuc.Enabled = true;
            bttra.Enabled = false;
            //btmuon.Enabled = true;
            lbthongbao.Text = "Hiển thị bảng chọn sách.";
            txttk.Enabled = true;
            flagmuon = true;
            flagtra = false;
        }

        private void bttrasach_Click(object sender, EventArgs e)
        {
            grpbdocgia.Enabled = true;
            grpbphuongthuc.Enabled = true;
            //bttra.Enabled = true;
            grpbloai.Enabled = false;
            btmuon.Enabled = false;
            lbthongbao.Text = "Hiển thị bảng sách đã mượn.";
            txttk.Enabled = false;
            flagtra = true;
            flagmuon = false;
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            String sql = "";
    
            try
            {
                if (flagmuon == true)
                {
                    conn.OpenConnect();
                    sql = "SELECT COUNT(*) FROM docgia WHERE madocgia = '" + txtmdg.Text + "'";
                    if (conn.CountExecuteSQL(sql) > 0)
                    {
                        sql = "SELECT * FROM docgia WHERE madocgia = '" + txtmdg.Text + "'";
                        rdr = conn.ExecuteSQL(sql);
                        rdr.Read();
                        lbms.Text = rdr["madocgia"].ToString();
                        lbdc.Text = rdr["diachi"].ToString();
                        lbht.Text = rdr["hoten"].ToString();
                        lbns.Text = rdr["ngaysinh"].ToString();
                        lbk.Text = rdr["makhoa"].ToString();
                        string str = rdr["makhoa"].ToString();
                        rdr.Close();
                        conn.CloseConnect();
                        conn.OpenConnect();
                        sql = "SELECT * FROM khoa WHERE makhoa = '" + str + "'";
                        rdr = conn.ExecuteSQL(sql);
                        rdr.Read();
                        lbk.Text = rdr["tenkhoa"].ToString();

                        grpbloai.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã đọc giả sai vui lòng kiểm tra lại!");
                        grpbloai.Enabled = false;
                    }
                }
                if (flagtra == true)
                {
                    conn.OpenConnect();
                    sql = "SELECT COUNT(*) FROM docgia WHERE madocgia = '" + txtmdg.Text + "'";
                    if (conn.CountExecuteSQL(sql) > 0)
                    {
                        sql = "SELECT * FROM docgia WHERE madocgia = '" + txtmdg.Text + "'";
                        rdr = conn.ExecuteSQL(sql);
                        rdr.Read();
                        lbms.Text = rdr["madocgia"].ToString();
                        lbdc.Text = rdr["diachi"].ToString();
                        lbht.Text = rdr["hoten"].ToString();
                        lbns.Text = rdr["ngaysinh"].ToString();
                        lbk.Text = rdr["makhoa"].ToString();
                        string str = rdr["makhoa"].ToString();
                        rdr.Close();
                        conn.CloseConnect();
                        conn.OpenConnect();
                        sql = "SELECT * FROM khoa WHERE makhoa = '" + str + "'";
                        rdr = conn.ExecuteSQL(sql);
                        rdr.Read();
                        lbk.Text = rdr["tenkhoa"].ToString();
                        conn.CloseConnect();
                        conn.OpenConnect();
                        sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon WHERE madocgia = '" + txtmdg.Text + "'";
                        dataGridView1.DataSource = conn.Table(sql);
                    }
                    else
                    {
                        MessageBox.Show("Mã đọc giả sai vui lòng kiểm tra lại!");
                        grpbloai.Enabled = false;
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
                    lbtenl.Text = rdr["tenloai"].ToString();
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
            String sql = "SELECT masach as 'Mã sách', nhande as 'Nhan đề', tacgia as 'Tác giả', solanmuon as 'Số lần mượn', soluong as 'Số lượng' FROM sach WHERE maloai = '" + cbbloai.Text + "' ORDER BY solanmuon DESC";
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flagmuon == true)
            {
                int current = dataGridView1.CurrentCell.RowIndex;
                String str = dataGridView1.Rows[current].Cells[0].Value.ToString();
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
                    btmuon.Enabled = true;

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
            if(flagtra==true)
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
                    bttra.Enabled = true;

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

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "SELECT masach as 'Mã sách', nhande as 'Nhan đề', tacgia as 'Tác giả', solanmuon as 'Số lần mượn', soluong as 'Số lượng' FROM sach WHERE masach LIKE '" + txttk.Text + "%' OR nhande LIKE '" + txttk.Text + "%' ORDER BY solanmuon DESC";
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

        private void btmuon_Click(object sender, EventArgs e)
        {
            bool check = true;
            String sql = "";
            if (CheckPM(txtmdg.Text, lbmasach.Text) == false)
                check = false;
            if (check == true)
            {
                try
                {
                    conn.OpenConnect();
                    sql = "SELECT soluong FROM sach WHERE masach = '" + lbmasach.Text + "'";
                    rdr = conn.ExecuteSQL(sql);
                    rdr.Read();
                    int count = Int32.Parse(rdr["soluong"].ToString());
                    if (count > 1)
                    {
                        conn.CloseConnect();
                        conn.OpenConnect();
                        sql = "INSERT INTO phieumuon VALUES('" + txtmdg.Text + "','" + DateTime.Today + "','" + lbmasach.Text + "','" + manv + "',1,N'Đang mượn','" + DateTime.Today.AddDays(7) + "')";
                        if (conn.ExecuteNonSQL(sql))
                        {
                            MessageBox.Show("" + lbht.Text + "\n Mượn thành công sách: " + lbnhande.Text +"\n Vui lòng trả sách trước ngày: "+ DateTime.Today.AddDays(7));
                            conn.CloseConnect();
                            conn.OpenConnect();
                            sql = "UPDATE sach SET solanmuon = solanmuon+1, soluong = soluong-1 WHERE masach = '" + lbmasach.Text + "'";
                            if (conn.ExecuteNonSQL(sql))
                            {
                                grpbloai.Enabled = false;
                                grpbphuongthuc.Enabled = false;
                                grpbdocgia.Enabled = false;
                                txtmdg.Clear();
                                lbdc.Text = "...........................................................";
                                lbht.Text = "...........................................................";
                                lbms.Text = "...........................................................";
                                lbns.Text = "...........................................................";
                                lbtenl.Text = "...........................................................";
                                lbk.Text = "...........................................................";
                                lbmasach.Text = "...........................................................";
                                lbnhande.Text = "...........................................................";
                                lbtacgia.Text = "...........................................................";
                                btmuon.Enabled = false;
                            }
                        }
                        else
                            MessageBox.Show("Mượn sách thất bại.");
                    }
                    else
                        MessageBox.Show("Mượn sách thất bại. Không đủ sách.");
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
            else
            {
                MessageBox.Show("Đọc giả đã mượn sách này. Không được phép mượn tiếp.");
            }
        }

        private void bttra_Click(object sender, EventArgs e)
        {
            String sql = "";
            try
            {
                conn.OpenConnect();
                sql = "DELETE FROM phieumuon WHERE masach = '" + lbmasach.Text + "' AND madocgia = '"+txtmdg.Text+"'";
                if (conn.ExecuteNonSQL(sql))
                {
                    MessageBox.Show("" + lbht.Text + "\n Trả sách thành công.");
                    conn.CloseConnect();
                    conn.OpenConnect();
                    sql = "UPDATE sach SET soluong = soluong+1 WHERE masach = '" + lbmasach.Text + "'";
                    if (conn.ExecuteNonSQL(sql))
                    {
                        grpbloai.Enabled = false;
                        grpbphuongthuc.Enabled = false;
                        grpbdocgia.Enabled = false;
                        txtmdg.Clear();
                        lbdc.Text = "...........................................................";
                        lbht.Text = "...........................................................";
                        lbms.Text = "...........................................................";
                        lbns.Text = "...........................................................";
                        lbtenl.Text = "...........................................................";
                        lbk.Text = "...........................................................";
                        lbmasach.Text = "...........................................................";
                        lbnhande.Text = "...........................................................";
                        lbtacgia.Text = "...........................................................";
                        bttra.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Trả sách thất bại.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                conn.CloseConnect();
                dataGridView1.ClearSelection();
                Load_Dgrmuon();
            }
        }

        public void Load_Dgrmuon()
        {
            String sql = "SELECT madocgia as 'Mã đọc giả', ngaymuon as 'Ngày mượn', masach as 'Mã sách', manhanvien as 'Mã nhân viên', soluong as 'Số lượng', trangthai as 'Trạng thái', ngaytra as 'Ngày trả' FROM phieumuon WHERE madocgia = '"+txtmdg.Text+"'";
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
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
