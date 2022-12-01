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
    public partial class Signup : Form
    {

        localhost.RoomManagementService hms = new localhost.RoomManagementService();

        //SqlConnection con = new SqlConnection("server = DESKTOP-C3CU2KB\\SQLEXPRESS; Database=db_Cardiff_Test1; Trusted_Connection=True;");

        public Signup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin gb = new Signin();
            gb.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(txtName.TextLength == 0)
                {
                    MessageBox.Show("Please enter your name");
                }
                else if (txtUserName.TextLength == 0)
                {
                    MessageBox.Show("Your must enter a unique username for you");
                }
                else if (txtPassword.TextLength == 0)
                {
                    MessageBox.Show("Your must enter a unique password for you");
                }
                else if (txtAddress.TextLength == 0)
                {
                    MessageBox.Show("Your must enter your address properly");
                }
                else
                {
                    string Name = txtName.Text;
                    string Address = txtAddress.Text;
                    string UserName = txtUserName.Text;
                    string Password = txtPassword.Text;

                    if (hms.insertHotels(Name, Address, UserName, Password) > 0)
                    {
                        MessageBox.Show("Registration Successful!");
                    }
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
            txtName.Clear();
            txtAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
