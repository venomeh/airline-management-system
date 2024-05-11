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
using Oracle.ManagedDataAccess.Client;

namespace DATABASE_PROJECT.Resources
{
    public partial class Main_UserView : Form
    {
        private database _db;

        public Main_UserView(database db)
        {
            _db = db;
            InitializeComponent();
            
            // Check if the database connection is open
            if (_db.con().State != ConnectionState.Open)
            {
                _db.con().Open(); // Open the connection if it's not already open
            }

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
            //OracleCommand getEmps = _db.con().CreateCommand();
            //getEmps.CommandText = "SELECT email FROM login";
            //getEmps.CommandType = CommandType.Text;
            //OracleDataReader empDR = getEmps.ExecuteReader();

            //if (empDR.Read()) // Check if there are rows in the result set
            //{
            //    string userEmail = empDR.GetString(0); // Assuming the email is in the first column
            //    label_name.Text = userEmail;
            //    label_name.Font = new System.Drawing.Font("Segoe Script", 11, FontStyle.Bold);
            //}

            //empDR.Close(); // Close the data reader to release resources
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
