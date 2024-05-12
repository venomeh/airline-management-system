using DATABASE_PROJECT.Resources;
using Microsoft.Office.Interop.Excel;
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
    public partial class User_Booking : Form
    {
        private database _db;

        public User_Booking(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void User_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void User_Booking_Load(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
         //   Main_UserView user = new Main_UserView(_db);
          //  user.Show();

            this.Hide();
        }

        private void dataGridView_flight_status_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
