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
    public partial class User_Booking : Form
    {
        private database _db;
        public string cnic;
        public User_Booking(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void User_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void User_Booking_Load(object sender, EventArgs e)
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
                    query2.CommandText = "SELECT flight_id, departure_city, arrival_city, ticket_price, booking_date " +
                        "FROM booking " +
                        "WHERE passenger_id = :P_id " +
                        "ORDER BY booking_date ASC";
                    query2.Parameters.Add("P_id", passengerId);
                    OracleDataAdapter adapter = new OracleDataAdapter(query2);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

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

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void dataGridView_flight_status_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
