using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_PROJECT
{
    public partial class AS_ScheduleFlight : Form
    {
        public AS_ScheduleFlight()
        {
            InitializeComponent();
        }

        private void AS_ScheduleFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AS_ScheduleFlight_Load(object sender, EventArgs e)
        {

        }

        private void departureTime_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //departure location here

        }

        private void arrival_textBox_TextChanged(object sender, EventArgs e)
        {
            //arrival location here

        }

        private void arrivalTime_textBox_TextChanged(object sender, EventArgs e)
        {
            //arrival time here

        }

        private void departureTime_textBox_TextChanged(object sender, EventArgs e)
        {
            //departure time here

        }

        private void flightHour_textBox_TextChanged(object sender, EventArgs e)
        {
            // calculate by arrival time - departure time

        }

        private void yes_radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //check from maintainance
            // if not found in maintainance then YES

        }

        private void no_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            // check from maintainance
            // if found in maintainance then NO

        }

        private void revenue_textBox_TextChanged(object sender, EventArgs e)
        {
            // check cost per hour from GENERATED REVENUE
            // calculate through FLIGHT_HOURS * COST PER HOUR

        }

        private void airline_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add all airlines here 
            // that are explicitly setted by us in the database

        }

        private void aircraftID_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check which airline is selected and show its corresponding aircraft ids here

        }

        private void flightid_textbox_TextChanged(object sender, EventArgs e)
        {
            // get from data base table after everthing is entered
        }

        private void flightID_get_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            // if checked then diplay flight ID
        }

        private void flightStatus_label_Click(object sender, EventArgs e)
        {

        }
    }
}
