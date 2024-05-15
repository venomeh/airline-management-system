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
    public partial class AS_UpdateFlightStatus : Form
    {   
        private database _db;

        public AS_UpdateFlightStatus(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_UpdateFlightStatus_Load(object sender, EventArgs e)
        {
            displayStatus.Text = "";
            label_displayDepCity.Text = "";
            label_displayArrCity.Text = "";
            label_displayDepDate.Text = "";
            combo_flightid.Items.Clear();

            //retrive flight id (can only change status of flight that are not completed
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT DISTINCT flight_id FROM flight " +
                "WHERE flight_status NOT IN ('COMPLETED') " +
                "ORDER BY flight_id";

            try
            {
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["flight_id"].ToString();
                        combo_flightid.Items.Add(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void combo_AircraftId_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_flightStatus.Items.Clear();
            //add status in the combobox that can be set
            comboBox_flightStatus.Items.Add("DELAYED");
            comboBox_flightStatus.Items.Add("ON TIME");
            comboBox_flightStatus.Items.Add("COMPLETED");
            comboBox_flightStatus.Items.Add("CANCELED");

            string flight_id = combo_flightid.SelectedItem.ToString();

            // Command to retrieve flight status for the selected flight_id
            string query = "SELECT flight_status FROM flight WHERE flight_id = :ID";
            OracleCommand command = new OracleCommand(query, _db.con());
            command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = flight_id;

            try
            {
                object status = command.ExecuteScalar();
                if (status != null)
                {
                    displayStatus.Text = status.ToString();
                    comboBox_flightStatus.Items.Remove(status.ToString());

                }
                else
                {
                    MessageBox.Show("Flight status not found for the selected flight ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            ///show flight details of selected flight 
            OracleCommand commandFlightDetails = _db.con().CreateCommand();
            commandFlightDetails.CommandText = "SELECT departure_city, arrival_city, dep_date " +
                                   "FROM FLIGHT " +
                                   "WHERE flight_id = :ID" +

            commandFlightDetails.Parameters.Add(new OracleParameter("ID", combo_flightid.SelectedItem.ToString()));

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
            
        
            reader.Close();
            commandFlightDetails.Dispose();
            command.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (combo_flightid.SelectedItem == null || comboBox_flightStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a flight ID and a new status.");
                return;
            }

            string flight_id = combo_flightid.SelectedItem.ToString();
            string newstatus = comboBox_flightStatus.SelectedItem.ToString();

            // Update flight status
            string query = "UPDATE FLIGHT SET flight_status = :NEWSTATUS WHERE flight_id = :ID";
            OracleCommand command = new OracleCommand(query, _db.con());
            command.Parameters.Add(":NEWSTATUS", OracleDbType.Varchar2).Value = newstatus;
            command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = flight_id;

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Flight status updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update flight status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            displayStatus.Text = "";
            label_displayDepCity.Text = "";
            label_displayArrCity.Text = "";
            label_displayDepDate.Text = "";
        }

        private void displayStatus_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_flightStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();

        }

        private void AS_UpdateFlightStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
