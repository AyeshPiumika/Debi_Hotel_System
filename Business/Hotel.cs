using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Business
{
    public class Hotel
    {
        public int id { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public string UserName { set; get; }

        public string Password { set; get; }

        public int insert()
        {
            try
            {
                string sql = "INSERT INTO tbl_Register2 (Hotel_Name,Hotel_Address,Hotel_Username,Hotel_Password) VALUES ('" + Name + "','" + Address + "','" + UserName + "','" + Password + "')";
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int update()
        {
            try
            {
                string sql = "UPDATE tbl_Register2 SET Hotel_Name='" + Name + "', Hotel_Address='" + Address + "', Hotel_Username='" + UserName + "', Hotel_Password='" + Password + "' WHERE Hotel_ID=" + id;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int delete()
        {
            try
            {
                string sql = "DELETE FROM tbl_Register2 WHERE Hotel_ID=" + id;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet search()
        {
            try
            {
                string sql = "SELECT * FROM tbl_Register2 WHERE Hotel_ID=" + id;
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet searchAll()
        {
            try
            {
                string sql = "SELECT * FROM tbl_Register2";
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}
