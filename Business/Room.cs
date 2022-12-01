using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;


namespace Business
{
    public class Room
    {
        public string HotelName { set; get; }

        public int RID { set; get; }

        public string RType { set; get; }

        public string RCountry { set; get; }

        public string RCity { set; get; }

        public string RDetails { set; get; }

        public string RContact { set; get; }

        public string RPrice { set; get; }

        public string RAvailble { set; get; }

        public int insert()
        {
            try
            {
                string sql = "INSERT INTO tbl_RoomManageFinal VALUES ('" + HotelName + "'," + RID + ",'" + RType + "','" + RCountry + "','" + RCity + "','" + RDetails + "','" + RContact + "','" + RPrice + "','" + RAvailble + "')";
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet Find()
        {
            try
            {
                string sql = "SELECT * FROM tbl_RoomManageFinal WHERE Room_ID=" + RID;
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public DataSet FindAll()
        {
            try
            {
                string sql = "SELECT * FROM tbl_RoomManageFinal";
                return new DB_Operations().exeSearchQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Update()
        {
            try
            {
                string sql = "UPDATE tbl_RoomManageFinal SET Hotel_Name='"+ HotelName+ "', Room_Type='"+ RType+ "', Country='"+ RCountry+ "', City='"+ RCity+ "', Room_Details='"+ RDetails + "', Room_contact_NO='"+ RContact+ "', Room_Price='"+ RPrice+ "', Room_Availability='"+ RAvailble+"' WHERE Room_ID=" + RID;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }

        public int Delete()
        {
            try
            {
                string sql = "DELETE FROM tbl_RoomManageFinal WHERE Room_ID=" + RID;
                return new DB_Operations().exeQuery(sql);
            }
            catch
            {
                throw;
            }
        }
    }
}
