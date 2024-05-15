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
using System.Reflection;
using System.Data.Common;
namespace DATABASE_PROJECT
{
    public partial class User_BookSeat : Form
    {
        private database _db;
        public string cnic;
        string arrival, bookingFlightID;
        System.DateTime date;
        public User_BookSeat(database db, string cnic)
        {

            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void User_BookSeat_Load(object sender, EventArgs e)
        {

            label_BaggageWeight.Hide();
            comboBox_BaggageWeight.Hide(); 
            dataGridView1.Refresh();

        }

        private void User_BookSeat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db, cnic);
            user.Show();

            this.Hide();
        }

      
        private void button_search_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (comboBox_departure.SelectedItem == null ||
                comboBox_Arrival.SelectedItem == null || depDate.Value == null)
            {
                MessageBox.Show("Fill departure, arrival, and date");
                return;
            }

            //clear previous id's
            comboBox_selectflightId.Items.Clear();

            // Retrieve selected values from combo boxes
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT f.flight_id, ad.airline_company, f.departure_city, f.arrival_city, f.dep_date, f.dep_time, f.ticket_cost " +
                "FROM flight f " +
                "INNER JOIN aircraft ad ON f.aircraft_id = ad.aircraft_id AND f.FLIGHT_STATUS IN ('DELAYED','ON TIME') " +
              //  "WHERE TO_DATE(f.DEP_DATE,'MM/DD/YYYY') = TO_DATE(:depDate, 'MM/DD/YYYY') " +
                "AND f.departure_city = :departureCity " +
                "AND f.arrival_city = :arrivalCity";

            oracleCommand.Parameters.Add(":departureCity", OracleDbType.Varchar2).Value = comboBox_departure.SelectedItem.ToString();
            oracleCommand.Parameters.Add(":arrivalCity", OracleDbType.Varchar2).Value = comboBox_Arrival.SelectedItem.ToString();
            //oracleCommand.Parameters.Add(":depDate", OracleDbType.Date).Value = depDate.Value.Date;


            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter(oracleCommand);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No flights found for the selected criteria.");
                }
                else
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        comboBox_selectflightId.Items.Add(row["flight_id"].ToString());
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeDeparture_ValueChanged(object sender, EventArgs e)
        {
            date = depDate.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_departure_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_arrival_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Arrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrival = comboBox_Arrival.Text;
        }

        private void button_book_Click(object sender, EventArgs e)
        {
            string fare, dCity, aCity;
            string p_id;
            int baggageID = 0;

            // Check if all fields are filled
            if (comboBox_selectflightId.SelectedItem == null || comboBox_departure.SelectedItem == null ||
                comboBox_Arrival.SelectedItem == null|| depDate.Value == null || comboBox_selectflightId.SelectedItem == null
                    || (!radioButton_YES.Checked && !radioButton_NO.Checked))
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            if (radioButton_YES.Checked && comboBox_BaggageWeight.SelectedItem == null)
            {
                MessageBox.Show("Select baggage weight");
                return;

            }

            //selecting the data of the booking done to put in the booking table
            OracleCommand oracleCommandBookingInfo = _db.con().CreateCommand();
            oracleCommandBookingInfo.CommandText = "SELECT f.ticket_cost, f.flight_id, f.departure_city, f.arrival_city, f.dep_date " +
                "FROM flight f " +
                "WHERE f.flight_id = :ID";

            oracleCommandBookingInfo.Parameters.Add(":ID", comboBox_selectflightId.SelectedItem);

            OracleCommand queryPassengerID = _db.con().CreateCommand();
            queryPassengerID.CommandText = "SELECT pass_id FROM passengers WHERE cnic = :NIC";
            queryPassengerID.Parameters.Add(":NIC", cnic);

            OracleDataReader reader = null;
            OracleDataReader reader2 = null;

            try
            {
                // Execute command to get flight information
                reader = oracleCommandBookingInfo.ExecuteReader();
                if (reader.Read())
                {
                    fare = reader["ticket_cost"].ToString();
                    dCity = reader["departure_city"].ToString();
                    aCity = reader["arrival_city"].ToString();
                }
                else
                {
                    MessageBox.Show("Flight information not found for the provided ID.");
                    return;
                }

                reader.Close();

                // Execute command to get passenger ID
                reader2 = queryPassengerID.ExecuteReader();
                if (reader2.Read())
                {
                    p_id = reader2["pass_id"].ToString();
                }
                else
                {
                    MessageBox.Show("Passenger ID not found for the provided CNIC.");
                    return;
                }

                reader2.Close();

                if (radioButton_YES.Checked)
                {
                    //Generate a 4-digit baggage ID if the radioButton_YES is checked
                    Random rnd = new Random();
                    baggageID = rnd.Next(1000, 9999);

                    //Insert data into baggage table
                    OracleCommand insertBaggageCommand = _db.con().CreateCommand();
                    insertBaggageCommand.CommandText = "INSERT INTO baggage (baggage_id, pass_id, flight_id, weight) " +
                                                       "VALUES (:baggageID, :p_id, :bookingFlightID, :Weight)";
                    insertBaggageCommand.Parameters.Add(":baggageID", baggageID);
                    insertBaggageCommand.Parameters.Add(":p_id", p_id);
                    insertBaggageCommand.Parameters.Add(":bookingFlightID", bookingFlightID);
                    insertBaggageCommand.Parameters.Add(":weight", comboBox_BaggageWeight.SelectedItem.ToString());
                    insertBaggageCommand.ExecuteNonQuery();

                    //Insert data into booking table
                    OracleCommand insertBookingCommand = _db.con().CreateCommand();
                    insertBookingCommand.CommandText = "INSERT INTO booking (BOOKING_DATE, TICKET_PRICE, FLIGHT_ID, PASSENGER_ID," +
                        " BAGGAGE_ID, DEPARTURE_CITY, ARRIVAL_CITY, DEP_DATE) " +
                        "VALUES (SYSDATE, :price, :f_id, :p_id, :b_id, :dep_city, :arr_city, TO_DATE(:depDate, 'DD-MM-YY'))";
                    insertBookingCommand.Parameters.Add(":price", fare);
                    insertBookingCommand.Parameters.Add(":f_id", bookingFlightID);
                    insertBookingCommand.Parameters.Add(":p_id", p_id);
                    insertBookingCommand.Parameters.Add(":b_id", baggageID);
                    insertBookingCommand.Parameters.Add(":dep_city", dCity);
                    insertBookingCommand.Parameters.Add(":arr_city", aCity);
                    insertBookingCommand.Parameters.Add(":depDate", OracleDbType.Date).Value = depDate.Value.Date;

                    int rowsaffected = insertBookingCommand.ExecuteNonQuery();
                    if (rowsaffected > 0)
                    {
                        MessageBox.Show("Ticket Booked");

                        Main_UserView user = new Main_UserView(_db, cnic);
                        user.Show();

                        this.Hide();
                    }
                }
                
                if (radioButton_NO.Checked) //not working error - not all variabels bound
                {
                    //Insert data into booking table
                    OracleCommand insertBookingCommand = _db.con().CreateCommand();
                    insertBookingCommand.CommandText = "INSERT INTO booking (BOOKING_DATE, TICKET_PRICE, FLIGHT_ID, PASSENGER_ID, " +
                        "DEPARTURE_CITY, ARRIVAL_CITY, DEP_DATE) " +
                        "VALUES (SYSDATE, :price, :f_id, :p_id, :b_id, :dep_city, :arr_city, TO_DATE(:depDate, 'DD-MM-YY'))";
                    insertBookingCommand.Parameters.Add(":price", fare);
                    insertBookingCommand.Parameters.Add(":f_id", bookingFlightID);
                    insertBookingCommand.Parameters.Add(":p_id", p_id);
                    insertBookingCommand.Parameters.Add(":dep_city", dCity);
                    insertBookingCommand.Parameters.Add(":arr_city", aCity);
                    insertBookingCommand.Parameters.Add(":depDate", OracleDbType.Date).Value = depDate.Value.Date;

                    int rowsaffected = insertBookingCommand.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Ticket Booked");

                            Main_UserView user = new Main_UserView(_db, cnic);
                            user.Show();

                            this.Hide();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the readers if they are open
                reader?.Close();
                reader2?.Close();
            }



        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bookingFlightID = comboBox_selectflightId.Text;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton_YES_CheckedChanged(object sender, EventArgs e)
        {
            label_BaggageWeight.Show();
            comboBox_BaggageWeight.Show();
        }

        private void radioButton_NO_CheckedChanged(object sender, EventArgs e)
        {

            label_BaggageWeight.Hide();
            comboBox_BaggageWeight.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

