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

namespace HotelManagementSystemProject
{
    public partial class ManageRooms : Form
    {

        localhost.RoomManagementService hms = new localhost.RoomManagementService();

        //SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Cardiff_Test1; Trusted_Connection=True;");
        //private object openFileDialog1;
        //private string sql;

        public ManageRooms()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet10.tbl_RoomManageFinal' table. You can move, or remove it, as needed.
            this.tbl_RoomManageFinalTableAdapter.Fill(this.db_Cardiff_Test1DataSet10.tbl_RoomManageFinal);
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet8.tbl_RoomManage1' table. You can move, or remove it, as needed.
            this.tbl_RoomManage1TableAdapter.Fill(this.db_Cardiff_Test1DataSet8.tbl_RoomManage1);
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet7.tbl_RoomManage' table. You can move, or remove it, as needed.
            this.tbl_RoomManageTableAdapter1.Fill(this.db_Cardiff_Test1DataSet7.tbl_RoomManage);
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet6.tbl_RoomManage' table. You can move, or remove it, as needed.
            this.tbl_RoomManageTableAdapter.Fill(this.db_Cardiff_Test1DataSet6.tbl_RoomManage);
            //// TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet4.tbl_Room3' table. You can move, or remove it, as needed.
            //this.tbl_Room3TableAdapter1.Fill(this.db_Cardiff_Test1DataSet4.tbl_Room3);
            //// TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet3.tbl_Room3' table. You can move, or remove it, as needed.
            //this.tbl_Room3TableAdapter.Fill(this.db_Cardiff_Test1DataSet3.tbl_Room3);
            //// TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet2.tbl_Room2' table. You can move, or remove it, as needed.
            //this.tbl_Room2TableAdapter1.Fill(this.db_Cardiff_Test1DataSet2.tbl_Room2);
            //// TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet1.tbl_Room2' table. You can move, or remove it, as needed.
            //this.tbl_Room2TableAdapter.Fill(this.db_Cardiff_Test1DataSet1.tbl_Room2);
            //// TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet.tbl_Room1' table. You can move, or remove it, as needed.
            //this.tbl_Room1TableAdapter.Fill(this.db_Cardiff_Test1DataSet.tbl_Room1);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string HotelName = txtHotelName.Text;
                int RID = Convert.ToInt32(txtRoomID.Text);
                string RType = txtRoomType.Text;
                string RCountry = txtCountry.Text;
                string RCity = txtCity.Text;
                string RDetails = txtRoomDetails.Text;
                string RContact = txtContact.Text;
                string RPrice = txtRoomPrice.Text;
                string RAvailble = txtRoomAvailability.Text;

                if (hms.insertRooms(HotelName, RID, RType, RCountry, RCity, RDetails, RContact, RPrice, RAvailble) > 0)
                {
                    MessageBox.Show("Data Added!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                clear();
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txtHotelName.Clear();
            txtRoomID.Clear();
            txtRoomType.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtRoomDetails.Clear();
            txtContact.Clear();
            txtRoomPrice.Clear();
            txtRoomAvailability.Clear();
            txtHotelName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                //String RID = txtRoomID.Text;
                int RID = Convert.ToInt32(txtRoomID.Text);
                DataSet ds = hms.searchRooms(RID);
                //string sql = "SELECT * FROM tbl_RoomManage1 WHERE Room_ID=@RID";

                //SqlCommand com = new SqlCommand(sql, con);

                //com.Parameters.AddWithValue("@RID", RID);

                //SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                //DataSet ds = new DataSet();
                //con.Open();
                //sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtHotelName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtRoomID.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomType.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtCountry.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtRoomDetails.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtRoomPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtRoomAvailability.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("Record not Found!");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try {
                string HotelName = txtHotelName.Text;
                int RID = Convert.ToInt32(txtRoomID.Text);
                string RType = txtRoomType.Text;
                string RCountry = txtCountry.Text;
                string RCity = txtCity.Text;
                string RDetails = txtRoomDetails.Text;
                string RContact = txtContact.Text;
                string RPrice = txtRoomPrice.Text;
                string RAvailble = txtRoomAvailability.Text;

                //string sql = "UPDATE tbl_RoomManage1 SET Hotel_Name=@HotelName, Room_Type=@RType, Country=@RCountry, City=@RCity, Room_Details=@RDetails, Room_contact_NO=@RContact, Room_Price=@RPrice, Room_Availability=@RAvailble WHERE Room_ID=@RID";

                //SqlCommand com = new SqlCommand(sql, con);

                //com.Parameters.AddWithValue("@HotelName", HotelName);
                //com.Parameters.AddWithValue("@RType", RType);
                //com.Parameters.AddWithValue("@RCountry", RCountry);
                //com.Parameters.AddWithValue("@RCity", RCity);
                //com.Parameters.AddWithValue("@RDetails", RDetails);
                //com.Parameters.AddWithValue("@RContact", RContact);
                //com.Parameters.AddWithValue("@RPrice", RPrice);
                //com.Parameters.AddWithValue("@RAvailble", RAvailble);
                //com.Parameters.Add("@RID", SqlDbType.VarChar).Value = RID;

                //con.Open();
                //if (com.ExecuteNonQuery() > 0)
                //{
                //    MessageBox.Show("Record Updated!");
                //    clear();
                //}

                if (hms.updateRooms(HotelName, RID, RType, RCountry, RCity, RDetails, RContact, RPrice, RAvailble) > 0)
                {
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                //con.Close();
                clear();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int RID = Convert.ToInt32(txtRoomID.Text);

                if (hms.deleteRooms(RID) > 0)
                {
                    MessageBox.Show("Data Deleted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                clear();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home gb = new Home();
            gb.Show();
        }
    }
}
