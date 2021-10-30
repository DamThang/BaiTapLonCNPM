using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLTHUVIEN
{
    class Connection
    {
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTV;Integrated Security=True";
        public SqlConnection con { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlCommand cmd { get; set; }
        SqlDataAdapter dar;
        DataTable table;
        //KẾT NOI
        public Connection()
        {
            con = new SqlConnection(strConn);
            drd = null;
            cmd = null;
        }
        public bool OpenConn()
        {
            try
            {
                this.con.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool CloseConn()
        {
            try

            {
         //       this.drd.Close();
                this.con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //GỌI HÀM
        public SqlDataReader executeSQL(string strSQL)
        {

            this.cmd = new SqlCommand(strSQL, this.con);
            this.drd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return this.drd;
        }

        public bool executeUpdate(string strUpdate)
        {
            this.cmd = new SqlCommand(strUpdate, this.con);
            int a = cmd.ExecuteNonQuery();
            if (a >= 1)
                return true;
            return false;
        }
        public int executeScala(string strSQL)
        {
            this.cmd = new SqlCommand(strSQL, this.con);
            int temp = (int)cmd.ExecuteScalar();
            return temp;
        }
    }
}
