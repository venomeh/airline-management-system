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
    public partial class AS_aircraft : Form
    {
        public AS_aircraft()
        {
            InitializeComponent();
        }

        private void AS_aircraft_Load(object sender, EventArgs e)
        {

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
    }
}
