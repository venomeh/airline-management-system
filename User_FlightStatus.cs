using DATABASE_PROJECT.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DATABASE_PROJECT
{
    public partial class User_FlightStatus : Form
    {
        private database _db;
        public string cnic, flightId;
        public User_FlightStatus(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void User_FlightStatus_Load(object sender, EventArgs e)
        {
            label_displayStatus.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_flight_status_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FILLDGV()
        {

        }

        private void User_FlightStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string status = "O";
            try
            {
                flightId = textBox_FlightId.Text;

                OracleCommand query1 = _db.con().CreateCommand();
                query1.CommandText = "SELECT flight_status FROM FLIGHT where flight_id = :id ";
                query1.Parameters.Add("id", flightId);
                OracleDataReader passReader = query1.ExecuteReader();

                if (passReader.Read())
                {
                     status = passReader["flight_status"].ToString();
                    passReader.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            if (status == "Y" || status == "y")
                label_displayStatus.Text = "FLIGHT ON TIME";
            else
                label_displayStatus.Text = "FLIGHT DELAYED";

        }

        private void textBox_ticketno_TextChanged(object sender, EventArgs e)
        {
            flightId = textBox_FlightId.Text;
        }
    }
}
