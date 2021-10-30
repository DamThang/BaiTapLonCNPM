using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTV
{
    class Connect
    {
        public SqlConnection conn { get; set; }
        public SqlCommand comm { get; set; }
        public SqlDataReader rdr { get; set; }
        
        public SqlDataAdapter adr { get; set; }
        public DataTable table { get; set; }
        //Hàm kết nối.
        public Connect()
        {
            this.conn = new SqlConnection("server=.\\SQLEXPRESS;database=quanlythuvien;uid=sa;pwd=system");
            this.comm = null;
            this.rdr = null;
        }
        //Mở kết nối.
        public void OpenConnect()
        {
            try
            {
                this.conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
        //Đóng kết nối.
        public void CloseConnect()
        {
            this.conn.Close();
        }
        //Đóng truy xuất.
        public void CloseRDR()
        {
            this.rdr.Close();
        }
        //Lệnh truy vấn.
        public SqlDataReader ExecuteSQL(string sql)
        {
            this.comm = new SqlCommand(sql, this.conn);
            this.rdr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            return this.rdr;
        }
        //Đếm giá trị truy vấn.
        public int CountExecuteSQL(string sql)
        {
            this.comm = new SqlCommand(sql, this.conn);
            int count = (int)comm.ExecuteScalar();
            return count;
        }
        //Thêm, sửa, xóa.
        public bool ExecuteNonSQL(string sql)
        {
            this.comm = new SqlCommand(sql, this.conn);
            int count = (int)comm.ExecuteNonQuery();
            if (count >= 1)
                return true;
            else
                return false;
        } 
        //Truy vấn dữ liệu thành bảng.
        public DataTable Table(String sql)
        {
            adr = new SqlDataAdapter(sql, this.conn);
            table = new DataTable();
            adr.Fill(table);
            return table;
        }

    }
}
