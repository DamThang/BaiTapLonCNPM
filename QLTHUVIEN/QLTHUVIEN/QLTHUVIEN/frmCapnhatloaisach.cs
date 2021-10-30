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

namespace QLTHUVIEN
{
    public partial class frmCapnhatloaisach : Form
    {
        SqlCommand cm;
        public frmCapnhatloaisach()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string sqlht = "select * from phanloai";
            SqlCommand cmd = new SqlCommand(sqlht, cn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvloaisach.DataSource = dt;
            cn.CloseConn();
        }
        public DataTable danhsachloaisach()
        {
            Connection cn = new Connection();
            SqlDataAdapter da = new SqlDataAdapter("select maloai as 'Mã Loại',tenloai as 'Tên loại' from phanloai", cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void frmCapnhatloaisach_Load(object sender, EventArgs e)
        {
            hienthi();
            dgvloaisach.DataSource = danhsachloaisach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            cm = new SqlCommand("select maloai from phanloai where maloai='" + maloai + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (maloai == ma)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlsua = "update phanloai set MALOAI='" + maloai + "',TENLOAI='" + tenloai + "' where  MALOAI='" + maloai + "'";
                    SqlCommand cmd = new SqlCommand(sqlsua, cn.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Sửa thành công");
                    }
                    catch
                    {
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
            }
            else
                MessageBox.Show("Không trùng mã loại!");
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maloai = txtmaloai.Text;
            Connection cn = new Connection();
            cn.OpenConn();
            if(maloai == "")
            {
                MessageBox.Show("Thông tin cần xóa hiện không tồn tại! ");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlxoa = "delete phanloai where  MALOAI='" + maloai + "'";
                    SqlCommand cmd = new SqlCommand(sqlxoa, cn.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Xóa thành công");
                        txtmaloai.Clear();
                        txttenloai.Clear();
                    }
                    catch
                    {
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                hienthi();
            }
        }

        private void dgvloaisach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvloaisach.Rows[e.RowIndex];

                txtmaloai.Text = row.Cells[0].Value.ToString();
                txttenloai.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string maloai = txtmaloai.Text;
            string tenloai = txttenloai.Text;
            cm = new SqlCommand("select maloai from phanloai where maloai='" + maloai + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (maloai == "" || tenloai == "")
            {
                MessageBox.Show("Thông tin loại không được bỏ trống!!!");
            }
            else
            if (maloai == ma)
            {
                MessageBox.Show("Trùng mã loại, thêm thất bại");
            }
            else
            {
                string sqlthem = "insert into phanloai values('" + maloai + "',N'" + tenloai + "')";
                SqlCommand cmd = new SqlCommand(sqlthem, cn.con);
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cn.CloseConn();
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    cmd.Dispose();
                    cn.CloseConn();
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            hienthi();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if(txtTK.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm!");
            }
            else
            {
                Connection cn = new Connection();
                cn.OpenConn();
                string maloai = txtTK.Text;
                string sqltk = "select *from phanloai where maloai ='" + maloai + "'";
                SqlCommand cmd = new SqlCommand(sqltk, cn.con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvloaisach.DataSource = dt;
            }
        }
    }
}
