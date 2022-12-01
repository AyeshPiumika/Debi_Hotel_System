using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DB_Operations
    {
        private SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Cardiff_Test1; Trusted_Connection=True;");

        public int exeQuery(string sql)
        {
            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                return com.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet exeSearchQuery(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
