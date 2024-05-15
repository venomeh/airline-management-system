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
            label_displayDepCity.Text = "";
            label_displayArrCity.Text = "";
            label_displayDepDate.Text = "";

            // Get flight IDs and fill the combo box
            OracleCommand query1 = _db.con().CreateCommand();
            query1.CommandText = "SELECT flight_id FROM flight ORDER BY flight_id";
            OracleDataReader reader = query1.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    // Add each flight ID to the combo box
                    comboBox_flightID.Items.Add(reader["flight_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Always close the reader when done
                reader.Close();
            }

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
          

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_flightID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///show flight details of selected flight 
            OracleCommand commandFlightDetails = _db.con().CreateCommand();
            commandFlightDetails.CommandText = "SELECT departure_city, arrival_city, dep_date " +
                                   "FROM FLIGHT " +
                                   "WHERE flight_id = :ID" +

            commandFlightDetails.Parameters.Add(new OracleParameter("ID", comboBox_flightID.SelectedItem.ToString()));

            OracleDataReader reader = commandFlightDetails.ExecuteReader();

            if (reader.Read())
            {
                // Display values in labels
                label_displayDepCity.Text = reader["departure_city"].ToString();
                label_displayArrCity.Text = reader["arrival_city"].ToString();
               
                
                // Get the departure date from the reader
                DateTime depDate = Convert.ToDateTime(reader["dep_date"]);

                // Format the date to display only the date part
                string formattedDate = depDate.ToString("yyyy-MM-dd"); // Change the format as per your requirement

                // Display the formatted date in the label
                label_displayDepDate.Text = formattedDate;
            }

            string status = "";
            try
            {
                flightId = comboBox_flightID.SelectedItem.ToString();

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
            label_displayStatus.Text = status;
        }

        private void textBox_ticketno_TextChanged(object sender, EventArgs e)
        {
            flightId = comboBox_flightID.SelectedItem.ToString();
        }
    }
}
