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
    public partial class ManageHotels : Form
    {
        localhost.RoomManagementService hms = new localhost.RoomManagementService();


        //SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Cardiff_Test1; Trusted_Connection=True;");
        public ManageHotels()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                string Address = txtAddress.Text;
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;
                
                if(hms.insertHotels(Name, Address, UserName, Password) > 0)
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
        public void clear()
        {
            txtHotelID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void ManageHotels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet9.tbl_Register2' table. You can move, or remove it, as needed.
            this.tbl_Register2TableAdapter.Fill(this.db_Cardiff_Test1DataSet9.tbl_Register2);
            // TODO: This line of code loads data into the 'db_Cardiff_Test1DataSet5.tbl_Register1' table. You can move, or remove it, as needed.
            this.tbl_Register1TableAdapter.Fill(this.db_Cardiff_Test1DataSet5.tbl_Register1);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtHotelID.Text);
                DataSet ds = hms.searchHotels(id);
                //string UserName = txtUserName.Text;
                //string sql = "SELECT * FROM tbl_Register1 User's_Username=@UserName";

                //SqlCommand com = new SqlCommand(sql, con);

                //com.Parameters.AddWithValue("@UserName", UserName);

                //SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                //DataSet ds = new DataSet();
                //con.Open();
                //sda.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtUserName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPassword.Text = ds.Tables[0].Rows[0][3].ToString();
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
            try
            {
                int id = Convert.ToInt32(txtHotelID.Text);
                string Name = txtName.Text;
                string Address = txtAddress.Text;
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;

                //string sql = "UPDATE tbl_Register2 SET Hotel_Name='" + Name + "', Hotel_Address='" + Address + "', Hotel_Username='" + UserName + "', Hotel_Password='" + Password + "' WHERE Hotel_ID=" + id;
                //string sql = "UPDATE tbl_Register2 SET Hotel_Name=@Name, Hotel_Address=@Address, Hotel_Username=UserName, Hotel_Password=@Password WHERE Hotel_ID=@id";

                //SqlCommand com = new SqlCommand(sql, con);

                //com.Parameters.AddWithValue("@Name", Name);
                //com.Parameters.AddWithValue("@Address", Address);
                //com.Parameters.AddWithValue("@Password", Password);
                //com.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;

                //con.Open();
                //if (com.ExecuteNonQuery() > 0)
                //{
                //    MessageBox.Show("Record Updated!");
                //    clear();
                //}

                if (hms.updateHotels(id, Name, Address, UserName, Password) > 0)
                {
                    MessageBox.Show("Data Updated");
                }
            }
            catch(Exception ex)
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
                int id = Convert.ToInt32(txtHotelID.Text);

                //string sql = "DELETE FROM tbl_Register1 WHERE [User's_UserName]=@UserName";

                //SqlCommand com = new SqlCommand(sql, con);

                //SqlParameter p1 = new SqlParameter();
                //p1.ParameterName = "@UserName";
                //p1.Value = UserName;

                //com.Parameters.Add(p1);
                //con.Open();

                //if (com.ExecuteNonQuery() > 0)
                //{
                //    MessageBox.Show("Record Deleted!");
                //    clear();
                //}
                if (hms.deleteHotels(id) > 0)
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
                //con.Close();
                clear();
            }
        }
    }
}
