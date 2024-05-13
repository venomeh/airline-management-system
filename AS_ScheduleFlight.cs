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
    public partial class AS_ScheduleFlight : Form
    {
        private database _db;
        public string depCity, arrCity, depDate, depHr, arrDate, arrHr, flightStatus, flightHours, aircraftId ;
        public int ticketCost;
        public int costPerHour;
        public AS_ScheduleFlight(database db)
        {
            this._db = db;
            InitializeComponent();
        }

        private void AS_ScheduleFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AS_ScheduleFlight_Load(object sender, EventArgs e)
        {
            combo_AircraftId.Items.Clear();

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT a.AIRCRAFT_ID, a.airline_company " +
                "FROM AIRCRAFT a " +
                "LEFT OUTER JOIN FLIGHT f ON f.aircraft_id = a.aircraft_id " +
                "WHERE f.FLIGHT_STATUS = 'COMPLETED' " +
                "UNION " +
                "SELECT a.AIRCRAFT_ID, a.airline_company " +
                "FROM AIRCRAFT a " +
                "WHERE a.AIRCRAFT_ID NOT IN(SELECT f.AIRCRAFT_ID FROM FLIGHT f)";

;           try
            {
                
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("aircraft_id"));
                        string airline = reader["airline_company"].ToString();
                        combo_AircraftId.Items.Add(id);
                        comboBox_Airline.Items.Add(airline);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           


        }


        private void aircraftID_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            aircraftId = combo_AircraftId.SelectedItem.ToString();
        }

        private void comboBox_flightStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            flightStatus = comboBox_flightStatus.SelectedItem.ToString();
        }

        private void comboBox_Arrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrCity = comboBox_Arrival.SelectedItem.ToString();
        }

        private void displayHours_Click(object sender, EventArgs e)
        {
           


        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
             }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void labelCost_Click(object sender, EventArgs e)
        {
         //   OracleCommand command = _db.con().CreateCommand();
            //command.CommandText = 
           // labelCost.Text = flightHours * 
        }

        private void button_Assign_Click(object sender, EventArgs e)
        {
          
            depHr = ncDEPtime.Value.ToString();
            arrHr = ncARRtime.Value.ToString();

            int hourDifference = 0 ;
            if (!string.IsNullOrEmpty(arrHr) && !string.IsNullOrEmpty(depHr))
            {
                // Parse the departure and arrival hours
                int departureHour = int.Parse(depHr);
                int arrivalHour = int.Parse(arrHr);

                // Calculate the difference in hours
                hourDifference = Math.Abs(arrivalHour - departureHour);

                // Update the label to display the difference in hours
                displayHours.Text = hourDifference.ToString();



            }


            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT cost_per_hour FROM aircraft WHERE aircraft_id = :aircraftId";

            // Add the aircraftId parameter
            oracleCommand.Parameters.Add("aircraftId", aircraftId);

            OracleDataReader reader = oracleCommand.ExecuteReader();

            if (reader.Read())
            {
                costPerHour = reader.GetInt32(0);

            }

            // Close the reader
            reader.Close();


            labelCost.Text = (costPerHour * hourDifference).ToString(); 

            ticketCost = costPerHour * hourDifference;


            // Create the command object for inserting data
            OracleCommand insertDataCommand = _db.con().CreateCommand();
            

            insertDataCommand.CommandText = "INSERT INTO FLIGHT (departure_city, arrival_city, flight_status, " +
    "aircraft_id, dep_date, ticket_cost, arr_date, arr_time, dep_time) " +
    "VALUES (:DEP_CITY, :ARR_CITY, :FLIGHT_STATUS, :AIRCRAFT_ID, TO_DATE(:DEP_DATE, 'DD-MM-YY')," +
    " :TICKET_COST, TO_DATE(:ARR_DATE, 'DD-MM-YY'), :ARR_TIME, :DEP_TIME)";

            // Add the parameter for the date
            insertDataCommand.Parameters.Add("DEP_CITY", depCity);
            insertDataCommand.Parameters.Add("ARR_CITY", arrCity);
            insertDataCommand.Parameters.Add("FLIGHT_STATUS",flightStatus);
            insertDataCommand.Parameters.Add("AIRCRAFT_ID", aircraftId);
            insertDataCommand.Parameters.Add("DEP_DATE", OracleDbType.Date).Value = dateDeparture.Value.Date;
            insertDataCommand.Parameters.Add("TICKET_COST", ticketCost);
            insertDataCommand.Parameters.Add("ARR_DATE", OracleDbType.Date).Value = dateArrival.Value.Date; 
            insertDataCommand.Parameters.Add("ARR_TIME", OracleDbType.Decimal).Value = decimal.Parse(ncARRtime.Value.ToString());
            insertDataCommand.Parameters.Add("DEP_TIME", OracleDbType.Decimal).Value = decimal.Parse(ncDEPtime.Value.ToString());
            
            // Execute the command
            insertDataCommand.ExecuteNonQuery();


        }

        private void comboBox_Airline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();

        }

        private void dateTimeDeparture_ValueChanged(object sender, EventArgs e)
        {
           //flightCmd.Parameters.Add("ArrivalTime", OracleDbType.Date).Value = dateTimePicker1.Value.Date;
        }
 
        private void comboBox_DEPARTURE_SelectedIndexChanged(object sender, EventArgs e)
        {
            depCity = comboBox_DEPARTURE.SelectedItem.ToString(); ;
        }
    }
}
