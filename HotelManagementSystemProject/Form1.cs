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
    public partial class Signin : Form
    {

        SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Cardiff_Test1; Trusted_Connection=True;");
        SqlCommand cmd;
        SqlDataReader dr;

        public Signin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup Su = new Signup();
            Su.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.TextLength == 0)
                {
                    MessageBox.Show("Please enter your Username");
                }
                else if (txtPassword.TextLength == 0)
                {
                    MessageBox.Show("Please enter your password");
                }
                else
                {
                    string UserName = txtUserName.Text;
                    string Password = txtPassword.Text;

                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM tbl_Register2 WHERE Hotel_Username='" + txtUserName.Text + "' AND Hotel_Password='" + txtPassword.Text + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        this.Hide();
                        ManageRooms MR = new ManageRooms();
                        MR.Show();
                    }
                    else if (UserName.Equals("Admin4567") && Password.Equals("AdminPas4567"))
                    {
                        this.Hide();
                        ManageRooms MR = new ManageRooms();
                        MR.Show();
                    }
                    else if (UserName.Equals("Admin1234") && Password.Equals("AdminPas1234"))
                    {
                        this.Hide();
                        ManageHotels MH = new ManageHotels();
                        MH.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login please check username and password");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}
