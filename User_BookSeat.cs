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
    public partial class User_BookSeat : Form
    {
        private database _db;

        public User_BookSeat(database db)
        {

            InitializeComponent();
            _db = db;
        }

        private void User_BookSeat_Load(object sender, EventArgs e)
        {

        }

        private void User_BookSeat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db);
            user.Show();

            this.Hide();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimeDeparture_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_departure_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_arrival_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
