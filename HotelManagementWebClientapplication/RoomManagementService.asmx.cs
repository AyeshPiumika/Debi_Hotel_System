using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Business;
using System.Data;

namespace HotelManagementWebClientapplication
{
    /// <summary>
    /// Summary description for RoomManagementService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RoomManagementService : System.Web.Services.WebService
    {
    
        // For Hotel Managing --------------------------------------------------------------------------
        [WebMethod]
        public int insertHotels(string Name, string Address, string UserName, string Password)
        {
            try
            {
                Hotel hotel = new Hotel();
                hotel.Name = Name;
                hotel.Address = Address;
                hotel.UserName = UserName;
                hotel.Password = Password;

                return hotel.insert();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int updateHotels(int id, string Name, string Address, string UserName, string Password)
        {
            try
            {
                Hotel hotel = new Hotel();
                hotel.id = id;
                hotel.Name = Name;
                hotel.Address = Address;
                hotel.UserName = UserName;
                hotel.Password = Password;

                return hotel.update();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int deleteHotels(int id)
        {
            try
            {
                Hotel hotel = new Hotel();
                hotel.id = id;

                return hotel.delete();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet searchHotels(int id)
        {
            try
            {
                Hotel hotel = new Hotel();
                hotel.id = id;

                return hotel.search();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet searchAllHotels()
        {
            try
            {
                return new Hotel().searchAll();
            }
            catch
            {
                throw;
            }
        }

        // For Room Managing ---------------------------------------------------------------------------------

        [WebMethod]
        public int insertRooms(string HotelName, int RID, string RType, string RCountry, string RCity, string RDetails, string RContact, string RPrice, string RAvailble)
        {
            try
            {
                Room room = new Room();
                room.HotelName = HotelName;
                room.RID = RID;
                room.RType = RType;
                room.RCountry = RCountry;
                room.RCity = RCity;
                room.RDetails = RDetails;
                room.RContact = RContact;
                room.RPrice = RPrice;
                room.RAvailble = RAvailble;

                return room.insert();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int updateRooms(string HotelName, int RID, string RType, string RCountry, string RCity, string RDetails, string RContact, string RPrice, string RAvailble)
        {
            try
            {
                Room room = new Room();
                room.HotelName = HotelName;
                room.RID = RID;
                room.RType = RType;
                room.RCountry = RCountry;
                room.RCity = RCity;
                room.RDetails = RDetails;
                room.RContact = RContact;
                room.RPrice = RPrice;
                room.RAvailble = RAvailble;

                return room.Update();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public int deleteRooms(int RID)
        {
            try
            {
                Room room = new Room();
                room.RID = RID;

                return room.Delete();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet searchRooms(int RID)
        {
            try
            {
                Room room = new Room();
                room.RID = RID;

                return room.Find();
            }
            catch
            {
                throw;
            }
        }

        [WebMethod]
        public DataSet SearchAllRooms()
        {
            try
            {
                return new Room().FindAll();
            }
            catch
            {
                throw;
            }
        }

    }
}
