using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystemProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomViewer S = new RoomViewer();
            S.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin S = new Signin();
            S.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin S = new Signin();
            S.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin S = new Signin();
            S.Show();
        }
    }
}
