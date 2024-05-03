using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Npgsql;

namespace DATABASE_PROJECT.Resources
{
    public partial class Main_UserView : Form
    {
        private database _db;

        public Main_UserView(database db)
        {
            _db = db;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_BookSeat user = new User_BookSeat(_db);
            user.Show();

            this.Hide();

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            User_Profile user = new User_Profile(_db);
            user.Show();

            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LOGIN login = new LOGIN(_db);
            login.Show();

        }

        private void UserView_Load(object sender, EventArgs e)
        {
            //get name from database
            string userName = "Taha";

            //Update the label text with the user's name
            label_name.Text = userName;
            label_name.Font = new System.Drawing.Font("Segoe Script", 11, FontStyle.Bold);

           

        }

        private void UserView_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_flight_status_Click(object sender, EventArgs e)
        {
            User_FlightStatus user = new User_FlightStatus(_db);
            user.Show();

            this.Hide();
        }

        private void button_bookedSeats_Click(object sender, EventArgs e)
        {
            User_Booking user = new User_Booking(_db);
            user.Show();

            this.Hide();
        }

        private void button_cancelSeat_Click(object sender, EventArgs e)
        {
            User_CancelSeat user = new User_CancelSeat(_db);   
            user.Show();    

            this.Hide();    
        }
    }
}
