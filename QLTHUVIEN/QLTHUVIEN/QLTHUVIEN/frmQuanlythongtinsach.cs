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
    public partial class frmQuanlythongtinsach : Form
    {
        SqlCommand cm;
        public frmQuanlythongtinsach()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string sqlht = "select * from SACH";            
            SqlDataAdapter da = new SqlDataAdapter(sqlht, cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvdsthongtinsach.DataSource = dt;
            cn.CloseConn();
            //CÓ 2 CÁCH HIỂN THỊ ^_^!!!!
            //SqlCommand cmd = new SqlCommand(sqlht, cn.con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
        }
        public void Loadcbmaloai()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            cm = new SqlCommand("select MaLoai from PHANLOAI",cn.con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbmaloai.DataSource = ds.Tables[0];
            cbmaloai.ValueMember = "MaLoai";
        }
        public DataTable danhsachsach()
        {
            Connection cn = new Connection();
            SqlDataAdapter da = new SqlDataAdapter("select MaSach as 'Mã Sách',TenSach as 'Tên Sách',SoTrang as 'Số trang',SoLuong as 'Số lượng',NamXB as 'Năm xuất bản',LanXB as 'Lần xuất bản',MaLoai as 'Mã loại',NXB as 'Nhà xuất bản',TacGia as 'Tác giả',NgayNhap as 'Ngày nhập' from SACH", cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void frmQuanlythongtinsach_Load(object sender, EventArgs e)
        {
            hienthi();
            Loadcbmaloai();
            dtpNgaynhap.Value = DateTime.Today;
            dgvdsthongtinsach.DataSource = danhsachsach();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string masach = txtms.Text;
            string tensach = txtnhande.Text;
            string soluong = txtsoluong.Text;
            string sotrang = txtsotrang.Text;
            string namxb = dtNamXB.Value.Year + "/" +dtNamXB.Value.Month + "/" +dtNamXB.Value.Day;
            string maloai = cbmaloai.Text;
            string nxb = txtnhaxb.Text;
            string tacgia = txttgia.Text;
            string ngaynhap = dtpNgaynhap.Value.Year + "/" + dtpNgaynhap.Value.Month + "/"+ dtpNgaynhap.Value.Day;
            string lanxb = txtlanxb.Text;
            cm = new SqlCommand("select MaSach from SACH where MaSach='" + masach + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (masach == "" || tensach == "" || soluong == "" || sotrang == "" ||  maloai == "" || nxb == "" || tacgia == ""  || lanxb == "")
            {
                MessageBox.Show("Thông tin sách không được bỏ trống!!!");
            }
            else
            if (masach == ma)
            {
                MessageBox.Show( "Trùng mã sách,thêm thất bại");
            }
            else
            {               
                string sqlthem = "insert into SACH values('" + masach + "',N'" + tensach + "','" + sotrang + "','" + soluong + "','" + namxb + "','" + lanxb + "','" + maloai + "',N'" + nxb + "',N'" + tacgia + "','" + Convert.ToDateTime(ngaynhap) + "')";
                SqlCommand cmd = new SqlCommand(sqlthem, cn.con);
                //MessageBox.Show("aaaa");
                try
                {
                    //MessageBox.Show("aaaa");
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cn.CloseConn();
                    MessageBox.Show( "Thêm thành công");
                }
                catch
                {
                    cmd.Dispose();
                    cn.CloseConn();
                    MessageBox.Show ("Thêm thất bại!");
                }
            }
            hienthi();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string masach = txtms.Text;
            string tensach = txtnhande.Text;
            string soluong = txtsoluong.Text;
            string sotrang = txtsotrang.Text;
            string namxb = dtNamXB.Text;
            string maloai = cbmaloai.Text;
            string nxb = txtnhaxb.Text;
            string tacgia = txttgia.Text;
            string ngaynhap = dtpNgaynhap.Text;
            string lanxb = txtlanxb.Text;
            cm = new SqlCommand("select MaSach from SACH where MaSach='" + masach + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (masach == ma)          
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlsua = "update SACH set TenSach ='" + tensach + "',SoTrang ='" + sotrang + "',SoLuong='" + soluong + "',NamXB ='" + namxb + "',LanXB ='" + lanxb + "',MaLoai ='" + maloai + "',NXB ='" + nxb + "',TacGia='" + tacgia + "',NgayNhap='" + ngaynhap + "' where MASACH ='" + masach + "'";
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
            {
                MessageBox.Show("Không được sửa mã sách !!!");
            }
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string masach = txtms.Text;
            cm = new SqlCommand("select MaSach from SACH where MaSach='" + masach + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (masach == ma)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlxoa = "delete SACH where MaSach ='" + masach + "'";
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
                string masach = txtTK.Text;
                string sqlTK = "select *from SACH where MaSach ='" + masach + "'";
                SqlCommand cmd = new SqlCommand(sqlTK, cn.con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvdsthongtinsach.DataSource = dt;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();            
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtms.Clear();
            txtnhande.Clear();
            txtnhaxb.Clear();
            txtsoluong.Clear();
            txtsotrang.Clear();
            txttgia.Clear();
            cbmaloai.Text = "ML1";
            dtpNgaynhap.Value = DateTime.Today;
            txtms.Focus();
            frmQuanlythongtinsach_Load( sender, e);
        }
      
        private void dgvdsthongtinsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvdsthongtinsach.Rows[e.RowIndex];

                txtms.Text = row.Cells[0].Value.ToString();               
                txtnhande.Text = row.Cells[1].Value.ToString();
                txtsotrang.Text = row.Cells[2].Value.ToString();                             
                txtsoluong.Text = row.Cells[3].Value.ToString();
                dtNamXB.Text = row.Cells[4].Value.ToString();
                txtlanxb.Text = row.Cells[5].Value.ToString();
                cbmaloai.Text = row.Cells[6].Value.ToString();
                txtnhaxb.Text = row.Cells[7].Value.ToString();
                txttgia.Text = row.Cells[8].Value.ToString();               
                dtpNgaynhap.Text = row.Cells[9].Value.ToString();               

            }
        }

    }
}
