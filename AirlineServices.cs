using System;
using System.Windows.Forms;

namespace DATABASE_PROJECT
{
    public partial class AirlineServices : Form
    {

        public AirlineServices()
        {
            InitializeComponent();
        }

        private void AirlineServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            // Logout functionality
        }

       


        private void AirlineServices_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
        }
    }
}
