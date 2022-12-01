using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementWebClientapplication
{
    public partial class InterfaceForClient : System.Web.UI.Page
    {

        RoomManagementService hms = new RoomManagementService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFillByCountry_Click(object sender, EventArgs e)
        {
                string Country = txtFillByCountry.Text;

                SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE Country LIKE CONCAT('%', '" + Country + "', '%')";
                SqlDataSource2.DataBind();
                grd1.DataBind();
            
        }

        protected void txtFillByCountry_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnFillByCity_Click(object sender, EventArgs e)
        {
            string City = txtFillByCity.Text;

            SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE City LIKE CONCAT('%', '" + City + "', '%')";
            SqlDataSource2.DataBind();
            grd1.DataBind();
        }

        protected void btnFillByName_Click(object sender, EventArgs e)
        {
            string HName = txtFillByName.Text;

            SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE Hotel_Name LIKE CONCAT('%', '" + HName + "', '%')";
            SqlDataSource2.DataBind();
            grd1.DataBind();
        }

        protected void btnFillByPrice_Click(object sender, EventArgs e)
        {
            string RPrice = txtFillByPrice.Text;

            SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE Room_Price LIKE CONCAT('%', '" + RPrice + "', '%')";
            SqlDataSource2.DataBind();
            grd1.DataBind();
        }

        protected void btnFillByType_Click(object sender, EventArgs e)
        {
            string RType = txtFillByType.Text;

            SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE Room_Type LIKE CONCAT('%', '" + RType + "', '%')";
            SqlDataSource2.DataBind();
            grd1.DataBind();
        }

        protected void btnFillByRAvailability_Click(object sender, EventArgs e)
        {
            string rAvailability = txtFillByRAvailability.Text;

            SqlDataSource2.SelectCommand = "SELECT  * FROM tbl_RoomManageFinal WHERE Room_Availability LIKE CONCAT('%', '" + rAvailability + "', '%')";
            SqlDataSource2.DataBind();
            grd1.DataBind();
        }
    }
}