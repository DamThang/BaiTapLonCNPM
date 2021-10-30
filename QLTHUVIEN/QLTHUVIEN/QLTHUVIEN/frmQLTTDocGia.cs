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
    public partial class frmQLTTDocGia : Form
    {
        SqlCommand cm;
        public frmQLTTDocGia()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string sqlht = "select * from DOCGIA";
            SqlCommand cmd = new SqlCommand(sqlht, cn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvDSTTdocgia.DataSource = dt;
            cn.CloseConn();            
        }
        public void Loadmakhoa()
        {
            /*Connection cn = new Connection();
            cn.OpenConn();
            cm = new SqlCommand("select makhoa from khoa", cn.con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbmakhoa.DataSource = ds.Tables[0];
            cbmakhoa.ValueMember = "makhoa";*/
        }
        public DataTable danhsachdocgia()
        {
            Connection cn = new Connection();
            SqlDataAdapter da = new SqlDataAdapter("select MaDocGia as 'Mã đọc giả',HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',DiaChi as 'Địa chỉ',NGAYLAPTHE as 'Ngày lập thẻ' from DOCGIA", cn.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtmdg.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            dtpngaylapthe.Value = DateTime.Today;
            dtpNgaysinh.Value = DateTime.Today;
            frmQLTTDocGia_Load(sender, e);
        }

        private void frmQLTTDocGia_Load(object sender, EventArgs e)
        {
            hienthi();
            dtpngaylapthe.Value = DateTime.Today;
            dtpNgaysinh.Value = DateTime.Today;
            dgvDSTTdocgia.DataSource = danhsachdocgia();
        }

        private void dgvDSTTdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSTTdocgia.Rows[e.RowIndex];

                txtmdg.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                dtpNgaysinh.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
                dtpngaylapthe.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string madocgia = txtmdg.Text;
            string hoten = txthoten.Text;
            string ngaysinh = dtpNgaysinh.Value.Year + "/" + dtpNgaysinh.Value.Month + "/" + dtpNgaysinh.Value.Day;

            DateTime ngaysinhcheck = Convert.ToDateTime( dtpNgaysinh.Value.ToString());
            DateTime ngaylapthecheck = Convert.ToDateTime(dtpngaylapthe.Value.ToString());

            string diachi = txtdiachi.Text;
            string ngaylapthe = dtpngaylapthe.Value.Year + "/" + dtpngaylapthe.Value.Month + "/"+dtpngaylapthe.Value.Day;
           

            DateTime nams = Convert.ToDateTime(dtpNgaysinh.Value.ToString());
            int Ngt = int.Parse(DateTime.Now.Year.ToString());
            int nn = int.Parse(nams.Year.ToString());
            int tuoi = Ngt - nn;

            cm = new SqlCommand("select MaDocGia from DOCGIA where MaDocGia='" + madocgia + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if(madocgia=="" || diachi == "")
            {
                MessageBox.Show("Thông tin đọc giả không được bỏ trống!!!");
            }
            if (tuoi < 18)
            {
                errorProvider1.SetError(dtpNgaysinh, "Đọc giả phải đủ 18 tuổi");
                return;
            }
            else
            if(tuoi > 100)
            {
                errorProvider1.SetError(dtpNgaysinh, "Đọc giả phải nhỏ hơn 100 tuổi");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (madocgia == ma)
            {
                MessageBox.Show("Trùng mã độc giả, thêm thất bại");
            }
            else
            if (ngaysinhcheck >= ngaylapthecheck)
            {
                MessageBox.Show("Ngày lập thẻ phải sau ngay sinh");
            }
           

            else
            {
                string sqlthem = "insert into DOCGIA values('" + madocgia + "',N'" + hoten + "','" + ngaysinh + "',N'" + diachi + "','" + ngaylapthe + "')";
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
            string madocgia = txtmdg.Text;
            string hoten = txthoten.Text;
            // DateTime ngaysinh = dtpNgaysinh.Value;
            string ngaysinh = dtpNgaysinh.Value.Year + "/" + dtpNgaysinh.Value.Month + "/" + dtpNgaysinh.Value.Day;
            string ngaylapthe = dtpngaylapthe.Value.Year + "/" + dtpngaylapthe.Value.Month + "/" + dtpngaylapthe.Value.Day;
            string diachi = txtdiachi.Text;
            DateTime ngaysinhcheck = Convert.ToDateTime(dtpNgaysinh.Value.ToString());
            DateTime ngaylapthecheck = Convert.ToDateTime(dtpngaylapthe.Value.ToString());
            //DateTime ngaylapthe = dtpngaylapthe.Value;

            cm = new SqlCommand("select MaDocGia from DOCGIA where MaDocGia='" + madocgia + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (ngaysinhcheck >= ngaylapthecheck)
            {
                MessageBox.Show("Ngày lập thẻ phải sau ngay sinh");
            }
            else
            if (madocgia == ma)          
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn sửa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlsua = "update DOCGIA set HoTen = N'" + hoten + "',NgaySinh='" + ngaysinh + "',DiaChi=N'" + diachi + "',NgayLapThe='" + ngaylapthe + "' where MaDocGia ='" + madocgia + "'";
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
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            string madocgia = txtmdg.Text;
            cm = new SqlCommand("select MaDocGia from DOCGIA where MaDocGia='" + madocgia + "'", cn.con);
            string ma = cm.ExecuteScalar() as string;
            if (madocgia == ma)
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == dlr)
                {
                    string sqlxoa = "delete DOCGIA where MaDocGia ='" + madocgia + "'";
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
                string madocgia = txtTK.Text;
                string sqltk = "select *from DocGia where MaDocGia ='" + madocgia + "'";
                SqlCommand cmd = new SqlCommand(sqltk, cn.con);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvDSTTdocgia.DataSource = dt;
            }
        }

        private void dtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {

            //DateTime nams = Convert.ToDateTime(dtpNgaysinh.Value.ToString());
            //int Ngt=int.Parse(DateTime.Now.Year.ToString());
            //int nn = int.Parse(nams.Year.ToString());
            //int tuoi = Ngt - nn;
            //if(tuoi<18)
            //{
            //    errorProvider1.SetError(dtpNgaysinh, "Đọc giả phải đủ 18 tuổi");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.Clear();
            //}
        }
    }
}
