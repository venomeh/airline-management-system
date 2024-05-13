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
    public partial class AS_revenue : Form
    {
        public AS_revenue()
        {
            InitializeComponent();
        }

        private void AS_revenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void revenueGeneratedOut_label_Click(object sender, EventArgs e)
        {
            // total revenue generated through bookings 
        }

        private void StatusOfFlightOut_label_Click(object sender, EventArgs e)
        {
            // either in profit or loss 
            // total revenue generated - cost
        }

        private void costOut_label_Click(object sender, EventArgs e)
        {
            // cost of flight 
        }

        private void flightID_label_Click(object sender, EventArgs e)
        {

        }

        private void maintainance_label_Click(object sender, EventArgs e)
        {

        }

        private void revenueGenerated_label_Click(object sender, EventArgs e)
        {

        }

        private void statusOfFlight_label_Click(object sender, EventArgs e)
        {

        }

        private void cost_label_Click(object sender, EventArgs e)
        {

        }

        private void aircraftId_label_Click(object sender, EventArgs e)
        {

        }

        private void airline_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightid_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maintainance_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
