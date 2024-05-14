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
    public partial class AS_report : Form
    {
        private database _db;
        public AS_report(database db)
        {
            InitializeComponent();
            _db = db;   
        }

        private void aircraftId_label_Click(object sender, EventArgs e)
        {

        }

        private void aircraftID_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show from available aircraft id's that are out of order based on N in scheduleFlight form
            // after every specific interval of airtime say 48 flight hours , it goes to N state

        }

        private void numericCostCounter_ValueChanged(object sender, EventArgs e)
        {
            // cost per hour * number of hours in N state
        }

        private void AS_report_Load(object sender, EventArgs e)
        {

        }

        private void AS_report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();
        }
    }
}
