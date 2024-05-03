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
    public partial class User_Profile : Form
    {
        private database _db;
        public User_Profile(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void User_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db);
            user.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
