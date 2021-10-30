using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace QLTHUVIEN
{
    public partial class frmQuantringuoidung : Form
    {
        SqlCommand cm;

        public frmQuantringuoidung()
        {
            InitializeComponent();
        }
        private void hienthi()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string sqlht = "select * from THUTHU";
            SqlCommand cmd = new SqlCommand(sqlht, cn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDSthuthu.DataSource = dt;
            cn.CloseConn();
        }
        public DataTable danhsachthuthu()
        {
            Connection cn = new Connection();
            SqlDataAdapter da = new SqlDataAdapter("select MaThuThu as 'Mã Thủ Thư',HoTen as 'Họ tên',DiaChi as 'Địa chỉ',TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',QuyenHan as 'Quyền hạn' from THUTHU", cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmnv.Clear();
            txthoten.Clear();
            txtmatkhau.Clear();
            txttendn.Clear();
            txtdiachi.Clear();
        }

        private void frmQuantringuoidung_Load(object sender, EventArgs e)
        {
            hienthi();
            dgvDSthuthu.DataSource = danhsachthuthu();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            xuly xl = new xuly();
            Connection cn = new Connection();
            cn.OpenConn();
            string mathuthu = txtmnv.Text;
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string tendangnhap = txttendn.Text;
            string matkhau = txtmatkhau.Text;
            string quyenhan = cbquyenhan.Text;
            cm = new SqlCommand("select MaThuThu from THUTHU where MaThuThu='" + mathuthu + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (mathuthu == "" || hoten == "" || diachi == "" || tendangnhap == "" || matkhau == "" || quyenhan == "")
            {
                MessageBox.Show("Thông tin nhân viên không được bỏ trống!!!");
            }
            else
            if (mathuthu == ma)
            {
                MessageBox.Show("Trùng mã nhân viên, thêm thất bại");
            }
            else
            {
                string sqlthem = "insert into THUTHU values('" + mathuthu + "',N'" + hoten + "',N'" + diachi + "','" + tendangnhap + "','" + matkhau + "','" + quyenhan + "')";
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string mathuthu = txtmnv.Text;
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string tendangnhap = txttendn.Text;
            string matkhau = txtmatkhau.Text;
            string quyenhan = cbquyenhan.Text;
            cm = new SqlCommand("select MaThuThu from THUTHU where MaThuThu='" + mathuthu + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (mathuthu == ma)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlsua = "update THUTHU set HoTen =N'" + hoten + "',DiaChi=N'" + diachi + "',TenDangNhap='" + tendangnhap + "',MatKhau='" + matkhau + "', QuyenHan='" + quyenhan + "' where  MaThuthu='" + mathuthu + "'";
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
                //if(manhanvien != ma)
                //MessageBox.Show("Không được thay đổi mã nhân viên!");
            
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string manhanvien = txtmnv.Text;
            cm = new SqlCommand("select MaThuThu from THUTHU where MaThuThu='" + manhanvien + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (manhanvien == ma)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlxoa = "delete nhanvien where manhanvien='" + manhanvien + "'";
                    SqlCommand cmd = new SqlCommand(sqlxoa, cn.con);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Xóa thành công");
                        btnLammoi_Click(sender, e);
                    }
                    catch
                    {
                        cmd.Dispose();
                        cn.CloseConn();
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            hienthi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm!");
            }
            else
            {
                Connection cn = new Connection();
                cn.OpenConn();
                string manhanvien = txtTK.Text;
                string sqltk = "select *from nhanvien where manhanvien ='" + manhanvien + "'";
                SqlCommand cmd = new SqlCommand(sqltk, cn.con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvDSthuthu.DataSource = dt;
            }
        }

        private void dgvDSnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSthuthu.Rows[e.RowIndex];

                txtmnv.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                txtdiachi.Text = row.Cells[2].Value.ToString();
                txttendn.Text = row.Cells[3].Value.ToString();
                txtmatkhau.Text = row.Cells[4].Value.ToString();
                cbquyenhan.Text = row.Cells[5].Value.ToString();
            }
        }

    }
}
