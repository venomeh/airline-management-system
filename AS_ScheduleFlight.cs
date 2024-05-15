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
        public string depCity, arrCity, depDate, depHr, arrDate, arrHr, flightStatus, flightHours, aircraftId ,ticketCost;
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

        int updateFlightHoursAndTicketCost()
        {
            decimal departureTime = ncDEPtime.Value;
            decimal arrivalTime = ncARRtime.Value;

            // Get the date part of departure and arrival
            DateTime departureDate = dateDeparture.Value.Date;
            DateTime arrivalDate = dateArrival.Value.Date;

            // Combine date and time for departure and arrival
            DateTime departureDateTime = departureDate.AddHours((double)departureTime);
            DateTime arrivalDateTime = arrivalDate.AddHours((double)arrivalTime);

            // If arrival time is before departure time, add one day to arrival date
            if (arrivalDateTime < departureDateTime)
            {
                arrivalDateTime = arrivalDateTime.AddDays(1);
            }

            // Calculate the flight duration
            TimeSpan flightDuration = arrivalDateTime - departureDateTime;

            // Calculate the total hours
            int hourDifference = (int)Math.Ceiling((decimal)flightDuration.TotalHours);

            // Update the label to display the difference in hours
            displayHours.Text = hourDifference.ToString();


            // Check if aircraft id is not selected or if default option is selected
            if (combo_AircraftId.SelectedItem != null && combo_AircraftId.SelectedItem.ToString() != "Select Airline First")
            {
                OracleCommand oracleCommand = _db.con().CreateCommand();
                oracleCommand.CommandText = "SELECT cost_per_hour FROM aircraft WHERE aircraft_id = :aircraftId";

                // Get the selected aircraft id
                int aircraftId = Convert.ToInt32(combo_AircraftId.SelectedItem);

                // Add the aircraftId parameter
                oracleCommand.Parameters.Add("aircraftId", aircraftId);

                try
                {
                    OracleDataReader reader = oracleCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        costPerHour = reader.GetInt32(0);
                        reader.Close();

                        labelCost.Text = (costPerHour * hourDifference).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }





            return hourDifference;
        }
        private void AS_ScheduleFlight_Load(object sender, EventArgs e)
        {
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT a.airline_company " +
                "FROM AIRCRAFT a " +
                "LEFT OUTER JOIN FLIGHT f ON f.aircraft_id = a.aircraft_id " +
                "WHERE f.FLIGHT_STATUS = 'COMPLETED' " +
                "UNION " +
                "SELECT a.airline_company " +
                "FROM AIRCRAFT a " +
                "WHERE NOT EXISTS (SELECT 1 FROM FLIGHT f WHERE f.AIRCRAFT_ID = a.AIRCRAFT_ID)";

            try
            {

                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string airline = reader["airline_company"].ToString();
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

            updateFlightHoursAndTicketCost();

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
            updateFlightHoursAndTicketCost();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_flightStatus_Click(object sender, EventArgs e)
        {

        }

        private void dateArrival_ValueChanged(object sender, EventArgs e)
        {
            updateFlightHoursAndTicketCost();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateFlightHoursAndTicketCost();


        }

        private void labelCost_Click(object sender, EventArgs e)
        {
        
        }

        private void button_Assign_Click(object sender, EventArgs e)
        {

            if (comboBox_DEPARTURE.SelectedItem == null || comboBox_Arrival.SelectedItem == null || dateArrival.Value == null
                || dateDeparture.Value == null || combo_AircraftId.SelectedItem == null || comboBox_Airline.SelectedItem == null
                || comboBox_flightStatus.SelectedItem == null  )
            {
                MessageBox.Show("Select all options");
                return;
            }

            depHr = ncDEPtime.Value.ToString();
            arrHr = ncARRtime.Value.ToString();

            if (string.IsNullOrEmpty(arrHr) || string.IsNullOrEmpty(depHr))
            {
               
                MessageBox.Show("Select Departure and Arrival Hours");
                return;
            }
            
            //if flight hours are negative or 0
            if (updateFlightHoursAndTicketCost() <= 0)
            {
                MessageBox.Show("Flight Hours can't be negative or zero");
                return;

            }
            
            if (comboBox_DEPARTURE.Text == comboBox_Arrival.Text)
            {
                MessageBox.Show("Dep and Arr city can't be same");
                return;
            }


            DateTime departureDate = dateDeparture.Value.Date;
            DateTime arrivalDate = dateArrival.Value.Date;

         
            // If arrival time is before departure time, add one day to arrival date
            if (arrivalDate < departureDate)
            {
                MessageBox.Show("Arrival Date should be after Departure Date");
                return;
            }

            depCity = comboBox_DEPARTURE.Text;
            arrCity = comboBox_Arrival.Text;
            flightStatus = comboBox_flightStatus.Text;
            ticketCost = labelCost.Text;
            aircraftId = combo_AircraftId.Text; 

            try
            {
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
                int rowsAffected = insertDataCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {

                    MessageBox.Show("Flight Scheduled");

                    comboBox_DEPARTURE.Text = "";
                    comboBox_Arrival.Text = "";
                    comboBox_flightStatus.Text = "";
                    labelCost.Text = "";
                    combo_AircraftId.Text = "";
                    comboBox_Airline.Text = "";
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }


        }

        private void comboBox_Airline_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_AircraftId.Items.Clear();
            combo_AircraftId.Text = "Aircraft_ID"; 

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT DISTINCT a.AIRCRAFT_ID " +
                                        "FROM AIRCRAFT a " +
                                        "LEFT OUTER JOIN FLIGHT f ON f.aircraft_id = a.aircraft_id " +
                                        "WHERE (f.FLIGHT_STATUS = 'COMPLETED' OR f.FLIGHT_STATUS IS NULL) AND a.airline_company = :COM " +
                                        "UNION " +
                                        "SELECT DISTINCT a.AIRCRAFT_ID " +
                                        "FROM AIRCRAFT a " +
                                        "WHERE NOT EXISTS (SELECT 1 FROM FLIGHT f WHERE f.AIRCRAFT_ID = a.AIRCRAFT_ID) AND a.airline_company = :COM";

            oracleCommand.Parameters.Add(":COM", comboBox_Airline.SelectedItem.ToString());

            try
            {
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("aircraft_id"));
                        combo_AircraftId.Items.Add(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            updateFlightHoursAndTicketCost();    
        }
 
        private void comboBox_DEPARTURE_SelectedIndexChanged(object sender, EventArgs e)
        {
            depCity = comboBox_DEPARTURE.SelectedItem.ToString(); ;
        }
    }
}
