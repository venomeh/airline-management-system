using DATABASE_PROJECT.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.CodeDom;
namespace DATABASE_PROJECT
{
    public partial class User_CancelSeat : Form
    {
        private database _db;
        public string cnic;
        public User_CancelSeat(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_phoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_signup_email_TextChanged(object sender, EventArgs e)
        {

        }
        private void User_CancelSeat_Load(object sender, EventArgs e)
        {
            try
            {
                // Clear existing data from DataGridView
                dataGridView1.Rows.Clear();

                // Get passenger ID based on CNIC
                OracleCommand query1 = _db.con().CreateCommand();
                query1.CommandText = "SELECT pass_id FROM PASSENGERS where cnic = :NIC ";
                query1.Parameters.Add("NIC", cnic);
                OracleDataReader passReader = query1.ExecuteReader();

                if (passReader.Read())
                {
                    string passengerId = passReader["pass_id"].ToString();
                    passReader.Close();

                    // Create and execute the SQL command to fetch booking records for the passenger
                    OracleCommand query2 = _db.con().CreateCommand();
                    query2.CommandText = "SELECT b.flight_id, b.departure_city, b.arrival_city, b.ticket_price, b.booking_date " +
                        "FROM booking b " +
                        "INNER JOIN FLIGHT f ON b.flight_id = f.flight_id " +
                        "WHERE b.passenger_id = :P_id AND f.FLIGHT_STATUS IN ('DELAYED','ON TIME','CANCELED') " +
                        "ORDER BY b.booking_date DESC";
                    query2.Parameters.Add("P_id", passengerId);

                    // Execute the query
                    OracleDataReader reader = query2.ExecuteReader();

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Fill the combo box with flight IDs
                    foreach (DataRow row in dataTable.Rows)
                    {
                        comboBox_fightID.Items.Add(row["flight_id"].ToString());
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Refresh();
                }
                else
                {
                    passReader.Close();
                    MessageBox.Show("Passenger with provided CNIC not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void User_CancelSeat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_cancelSeat_Click(object sender, EventArgs e)
        {
            string f_id = comboBox_fightID.SelectedItem.ToString();

            try
            {
                DialogResult result = MessageBox.Show("Confirm Ticket Cancellation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete booking details
                    OracleCommand deleteBookingCommand = _db.con().CreateCommand();
                    deleteBookingCommand.CommandText = "DELETE FROM booking " +
                        "WHERE flight_id = :f_id " +
                        "AND passenger_ID = " +
                        "(SELECT pass_id FROM passengers WHERE cnic = :NIC)";
                    deleteBookingCommand.Parameters.Add(":f_id", f_id);
                    deleteBookingCommand.Parameters.Add(":NIC", cnic);
                    int bookingRowsAffected = deleteBookingCommand.ExecuteNonQuery();
                    if (bookingRowsAffected > 0)
                    {
                        MessageBox.Show("Ticket Deleted");
                    }
                    else
                    {
                        MessageBox.Show("The ticket is not yours");
                        return;
                    }

                    // Delete baggage details
                    OracleCommand deleteBaggageCommand = _db.con().CreateCommand();
                    deleteBaggageCommand.CommandText = "DELETE FROM baggage WHERE flight_id = :f_id " +
                        "AND pass_id = (SELECT pass_id FROM passengers WHERE cnic = :NIC)";
                    deleteBaggageCommand.Parameters.Add(":f_id", f_id);
                    deleteBaggageCommand.Parameters.Add(":NIC", cnic);
                    int baggageRowsAffected = deleteBaggageCommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
