using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace QLTHUVIEN
{
    class xuly
    {
        DataSet ds = new DataSet();
        Connection cn = new Connection();
        SqlCommand cm, cm1;
        SqlDataAdapter da;
        SqlDataReader dr;
        public int KTdangnhap(string USER, string PASSWORD)
        {

            cn.OpenConn();
            cm = new SqlCommand("select MaThuThu from THUTHU where MaThuThu='" + USER + "' and MatKhau='" + PASSWORD + "'", cn.con);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                return 1;
            }
            else
                return 0;
            cm.Dispose();
            dr.Dispose();
            cn.CloseConn();

        }
        public int KTdangnhap2(string USER, string PASSWORD)
        {

            cn.OpenConn();
            cm = new SqlCommand("select MaDocGia from DOCGIA where MaDocGia='" + USER + "' and NgaySinh='" + PASSWORD + "'", cn.con);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                return 1;
            }
            else
                return 0;
            cm.Dispose();
            dr.Dispose();
            cn.CloseConn();

        }
        public string quyenhan(string USER)
        {
            cn.OpenConn();
            string a = "select QuyenHan from THUTHU where MaThuThu='" + USER + "'";
            SqlDataReader dr = cn.executeSQL(a);
            string quyen = "";
            while (dr.Read())
            {
                quyen = dr[0].ToString();
            }
            cn.CloseConn();
            return quyen;
        }


        public DataTable thongtincanhan(string ai)
        {
            cn.OpenConn();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select MaThuThu as 'Mã thủ Thư',HoTen as 'Họ tên',DiaChi as 'Địa chỉ',TenDangNhap as 'Tên đăng nhập',MatKhau as 'Mật khẩu',QuyenHan as 'Quyền hạn' from THUTHU where MaThuThu='" + ai + "'", cn.con);
            da.Fill(dt);
            cn.CloseConn();
            return dt;
        }
        public DataTable thongtincanhan2(string ai)
        {
            cn.OpenConn();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select MaDocGia as 'Mã đọc giả',HoTen as 'Họ tên',NgaySinh as 'Ngày sinh',DiaChi as 'Địa chỉ',NgayLapThe as 'Ngày lập thẻ' from DOCGIA where MaDocGia='" + ai + "'", cn.con);
            da.Fill(dt);
            cn.CloseConn();
            return dt;
        }
        public string XinChao1(string mathuthu)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            SqlCommand cm = new SqlCommand("select HoTen from THUTHU where MaThuThu='" + mathuthu + "'", cn.con);
            string hoten = cm.ExecuteScalar() as string;
            cn.CloseConn();
            return hoten;
        }
        public string XinChao2(string madocgia)
        {
            Connection cn = new Connection();
            cn.OpenConn();
            SqlCommand cm = new SqlCommand("select HoTen from DOCGIA where MaDocGia='" + madocgia + "'", cn.con);
            string hoten = cm.ExecuteScalar() as string;
            cn.CloseConn();
            return hoten;
        }
        
    }
}
