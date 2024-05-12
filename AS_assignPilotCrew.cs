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
    public partial class AS_assignPilotCrew : Form
    {
        public AS_assignPilotCrew()
        {
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
            //this can either be pilot or crew , select one
        }

        private void pilot_crew_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // based on above selection of radio button , show pilot or crew ID's
        }

        private void flight_id_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // show all available flight ids
        }

        private void AS_assignPilotCrew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
