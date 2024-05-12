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
        string departure, arrival, bookingFlightID;
        System.DateTime date;
        public User_BookSeat(database db, string cnic)
        {

            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void User_BookSeat_Load(object sender, EventArgs e)
        {

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

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT f.flight_id, f.departure_city, f.arrival_city, f.dep_date, f.ticket_cost, ad.airline_company " +
                "FROM flight f " +
                "INNER JOIN aircraft_details ad ON f.aircraft_id = ad.aircraft_id ";

            oracleCommand.Parameters.Add(":departureCity", departure);
            oracleCommand.Parameters.Add(":arrivalCity", arrival);

            DataTable dataTable = new DataTable();

            try
            {
                OracleDataAdapter adapter = new OracleDataAdapter(oracleCommand);
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    comboBox_selectflightId.Items.Add(row["flight_id"].ToString());
                }

                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
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
            date = dateTimeDeparture.Value;
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
            //OracleCommand oracleCommand = _db.con().CreateCommand();
            //oracleCommand.CommandText = "SELECT f.departure_city, f.arrival_city" +
            //    "FROM flight f " +
            //    "WHERE TRUNC(CAST(f.departure_time AS DATE)) = TO_DATE(:departureDate, 'YYYY-MM-DD')";
           
            //string departureDateString = date.ToString("yyyy-MM-dd");


            //oracleCommand.Parameters.Add(":departureCity", OracleDbType.Varchar2).Value = departure;
            //oracleCommand.Parameters.Add(":arrivalCity", OracleDbType.Varchar2).Value = arrival;
            //// oracleCommand.Parameters.Add(":departureDate", OracleDbType.Date).Value = date;

            //DataTable dataTable = new DataTable();

            //OracleDataAdapter adapter = new OracleDataAdapter(oracleCommand);
            //adapter.Fill(dataTable);

            ////Add items to ComboBox
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    comboBox_selectflightId.Items.Add(row["flight_id"].ToString());
            //    //  comboBox_Airline.Items.Add(row["airline_company"].ToString());

            //}
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

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT f.flight_id, f.departure_city, f.arrival_city, f.dep_date, f.ticket_cost, ad.airline_company " +
                "FROM flight f " +
                "INNER JOIN aircraft_details ad ON f.aircraft_id = ad.aircraft_id " +
                "WHERE f.flight_id = :ID";

            oracleCommand.Parameters.Add(":ID", bookingFlightID);

            OracleDataReader reader = oracleCommand.ExecuteReader();

            try
            {
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

                OracleCommand query2 = _db.con().CreateCommand();
                query2.CommandText = "SELECT pass_id FROM passengers WHERE cnic = :NIC";
                query2.Parameters.Add(":NIC", cnic);

                OracleDataReader reader2 = query2.ExecuteReader();

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
                    insertBaggageCommand.CommandText = "INSERT INTO baggage (baggage_id, pass_id, flight_id) " +
                                                       "VALUES (:baggageID, :p_id, :bookingFlightID)";
                    insertBaggageCommand.Parameters.Add(":baggageID", baggageID);
                    insertBaggageCommand.Parameters.Add(":p_id", p_id);
                    insertBaggageCommand.Parameters.Add(":bookingFlightID", bookingFlightID);
                    insertBaggageCommand.ExecuteNonQuery();
                }

                //Insert data into  booking table
                OracleCommand insertBookingCommand = _db.con().CreateCommand();
                insertBookingCommand.CommandText = "INSERT INTO booking (BOOKING_DATE, TICKET_PRICE, FLIGHT_ID, PASSENGER_ID," +
                    " BAGGAGE_ID, DEPARTURE_CITY, ARRIVAL_CITY) " +
                    "VALUES (SYSDATE, :price, :f_id, :p_id, :b_id, :dep_city, :arr_city)";
                insertBookingCommand.Parameters.Add(":price", fare);
                insertBookingCommand.Parameters.Add(":f_id", bookingFlightID);
                insertBookingCommand.Parameters.Add(":p_id", p_id);
                insertBookingCommand.Parameters.Add(":b_id", baggageID); 
                insertBookingCommand.Parameters.Add(":dep_city", dCity);
                insertBookingCommand.Parameters.Add(":arr_city", aCity);
                int rowsaffected = insertBookingCommand.ExecuteNonQuery(); 
                if (rowsaffected > 0)
                {
                    MessageBox.Show("Ticket Booked");

                    Main_UserView user = new Main_UserView(_db, cnic);
                    user.Show();

                    this.Hide();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                reader.Close();
            }


        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bookingFlightID = comboBox_selectflightId.Text;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

