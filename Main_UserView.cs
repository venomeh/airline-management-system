using System;
using System.CodeDom;
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
        public string loginid;
        public string cnic;

        public Main_UserView(database db, string cnic)
        {
            _db = db;
            this.cnic = cnic;
            InitializeComponent();
            
            // Check if the database connection is open
            if (_db.con().State != ConnectionState.Open)
            {
                _db.con().Open(); // Open the connection if it's not already open
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_BookSeat user = new User_BookSeat(_db, this.cnic);
            user.Show();

            this.Hide();

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            User_Profile user = new User_Profile(_db, cnic);
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
            label_displayName.Text = "";


            OracleCommand command = _db.con().CreateCommand();
            command.CommandText = "SELECT person_name FROM user_table WHERE cnic = :CNIC";
            command.Parameters.Add(new OracleParameter("CNIC", this.cnic));

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label_displayName.Text = reader["person_name"].ToString();

            }
            else
            {
                MessageBox.Show("User not found.");
                this.Hide(); 
                LOGIN login = new LOGIN(_db); 
                login.Show();
            }

            reader.Close();
            command.Dispose();
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
            User_FlightStatus user = new User_FlightStatus(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void button_bookedSeats_Click(object sender, EventArgs e)
        {
            User_Booking user = new User_Booking(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void button_cancelSeat_Click(object sender, EventArgs e)
        {
            User_CancelSeat user = new User_CancelSeat(_db, cnic);   
            user.Show();    

            this.Hide();    
        }

        private void label_displayName_Click(object sender, EventArgs e)
        {

        }

        private void button_Feedback_Click(object sender, EventArgs e)
        {
            User_Feedback feedback = new User_Feedback(_db,cnic);
            this.Hide();
            feedback.Show();
        }
    }
}
