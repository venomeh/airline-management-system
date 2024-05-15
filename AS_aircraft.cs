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
    public partial class AS_aircraft : Form
    {
        private database _db;

        public AS_aircraft(database _db)
        {
            InitializeComponent();
            this._db = _db; 
        }

        private void AS_aircraft_Load(object sender, EventArgs e)
        {
            OracleCommand maxIdCommand = _db.con().CreateCommand();
            maxIdCommand.CommandText = "SELECT MAX(AIRCRAFT_ID)+1 FROM AIRCRAFT";

            object maxId = maxIdCommand.ExecuteScalar();
            if (maxId != DBNull.Value)
            {
                idShow_label.Text = maxId.ToString();
            }
            else
            {
                idShow_label.Text = "-";
            }
        }

        private void AS_aircraft_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void capacityRatio_textBox_TextChanged(object sender, EventArgs e)
        {
            //just enter from user on form and get to data base

        }

        private void cph_textBox_TextChanged(object sender, EventArgs e)
        {
            //just enter from user on form and get to data base
        }

        private void model_textBox_TextChanged(object sender, EventArgs e)
        {
            //just enter from user on form and get to data base
        }

        private void totalcapacity_textBox_TextChanged(object sender, EventArgs e)
        {
            //just enter from user on form and get to data base
        }

        private void airline_textBox_TextChanged(object sender, EventArgs e)
        {
            //just enter from user on form and get to data base
        }

        private void idShow_label_Click(object sender, EventArgs e)
        {
            // after all above data is entered , just pass all values to
            // data base and fetch the id auto generated from their into this
            // label
        }

        private void button_Assign_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (comboBox_airline.Text == "" || cph_textBox.Text == "" || totalcapacity_textBox.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string airline, cph, totalCapacity;

            airline = comboBox_airline.Text;
            cph = cph_textBox.Text;
            totalCapacity = totalcapacity_textBox.Text;

            // Insert data into the AIRCRAFT table
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "INSERT INTO AIRCRAFT(TOTAL_CAPACITY, airline_company, cost_per_hour) " +
                "VALUES (:totalCapacity, :company, :cph)";
            oracleCommand.Parameters.Add(":totalCapacity", totalCapacity);
            oracleCommand.Parameters.Add(":company", airline);
            oracleCommand.Parameters.Add(":cph", cph);

            int rowAffected = oracleCommand.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                MessageBox.Show("Aircraft Added successfully.");

                //clear input
                comboBox_airline.Text = "";
                cph_textBox.Text = "";
                totalcapacity_textBox.Text = "";
                idShow_label.Text = "-";
            }
           
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            this.Hide();
            airlineServices.Show();

        }
    }
}
