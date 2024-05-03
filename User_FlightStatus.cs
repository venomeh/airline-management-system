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

namespace DATABASE_PROJECT
{
    public partial class User_FlightStatus : Form
    {
        private database _db;
        public User_FlightStatus(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void User_FlightStatus_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_flight_status_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FILLDGV()
        {

        }

        private void User_FlightStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db);
            user.Show();

            this.Hide();
        }
    }
}
