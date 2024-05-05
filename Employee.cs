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
    public partial class Employee : Form
    {
        private database _db;
        public Employee(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN(_db);
            login.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is a demo button for checking comit in github
        }
    }
}
