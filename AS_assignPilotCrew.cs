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
    public partial class AS_assignPilotCrew : Form
    {
        private database _db;

        public AS_assignPilotCrew(database db)

        {
            this._db = db;    
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pilots_label_Click(object sender, EventArgs e)
        {

        }

        private void pilot_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            //this can either be pilot or crew , select one
        }

        private void crew_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void pilot_crew_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void flight_id_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///show flight details of selected flight 
            OracleCommand commandFlightDetails = _db.con().CreateCommand();
            commandFlightDetails.CommandText = "SELECT departure_city, arrival_city, dep_date " +
                                   "FROM FLIGHT " +
                                   "WHERE flight_id = :ID" +

            commandFlightDetails.Parameters.Add(new OracleParameter("ID", flight_id_combobox.SelectedItem.ToString()));

            OracleDataReader reader = commandFlightDetails.ExecuteReader();

            if (reader.Read())
            {
                // Display values in labels
                label_displayDepCity.Text = reader["departure_city"].ToString();
                label_displayArrCity.Text = reader["arrival_city"].ToString();
                label_displayDepDate.Text = reader["dep_date"].ToString();
            }


            reader.Close();
            commandFlightDetails.Dispose();
            
        }

        private void AS_assignPilotCrew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void button_Assign_Click(object sender, EventArgs e)
        {
            try
            {

                string crew_id = crew_combobox.Text;
                string flight_id = flight_id_combobox.Text;

                OracleCommand oracleCommand = _db.con().CreateCommand();
                oracleCommand.CommandText = "UPDATE CREW SET FLIGHT_ID = :fid " +
                    "WHERE crew_id = :cid";
                
                oracleCommand.Parameters.Add(":fid", flight_id);
                oracleCommand.Parameters.Add(":cid", crew_id);
                int rowsAffected = oracleCommand.ExecuteNonQuery();
                if (rowsAffected > 0) 
                {
                    label_displayStatus.Text = "ASSIGNED";
                    return;
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }

        private void AS_assignPilotCrew_Load(object sender, EventArgs e)
        {
            label_displayStatus.Text = "";
            label_displayDepCity.Text = "";
            label_displayArrCity.Text = "";
            label_displayDepDate.Text = "";

            crew_combobox.Items.Clear();

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT CREW_ID FROM CREW WHERE FLIGHT_ID IS NULL";

            OracleDataReader reader = null;
            try
            {
                reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int crewId = reader.GetInt32(reader.GetOrdinal("CREW_ID"));
                        crew_combobox.Items.Add(crewId);
                    }
                }
                else
                {
                    label_displayStatus.Text = "No crew IDs found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            // Second Oracle command to select flight IDs not present in the CREW table
            flight_id_combobox.Items.Clear();
            OracleCommand oracleCommand1 = _db.con().CreateCommand();
            oracleCommand1.CommandText = "SELECT FLIGHT_ID FROM FLIGHT WHERE FLIGHT_STATUS NOT IN ('CANCELED')" +
                "MINUS " +
                "SELECT FLIGHT_ID FROM CREW";

            OracleDataReader reader1 = null;
            try
            {
                reader1 = oracleCommand1.ExecuteReader();

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        int flightId = reader1.GetInt32(reader1.GetOrdinal("FLIGHT_ID"));
                        flight_id_combobox.Items.Add(flightId);
                    }
                }
                else
                {
                    label_displayStatus.Text = "No flights IDs found";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (reader1 != null)
                {
                    reader1.Close();
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();

        }

        private void label_displayStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
