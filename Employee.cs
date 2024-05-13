using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DATABASE_PROJECT
{
    public partial class Employee : Form
    {
        private database _db;
        public string cnic;
        public Employee(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            label_displayName.Text = "";


            OracleCommand command = _db.con().CreateCommand();
            command.CommandText = "SELECT person_name FROM user_table WHERE cnic = :CNIC";
            command.Parameters.Add(new OracleParameter("CNIC", this.cnic));

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label_displayName.Text = reader["person_name"].ToString();

            }
            else
            {
                MessageBox.Show("User not found.");
                this.Hide();
                LOGIN login = new LOGIN(_db);
                login.Show();
            }

            reader.Close();
            command.Dispose();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN(_db);
            login.Show();

            this.Hide();
        }

        private void label_displayName_Click(object sender, EventArgs e)
        {

        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            Employee_Profile emp = new Employee_Profile(_db, cnic);
            emp.Show();

            this.Hide();
        }

        private void button_assignments_Click(object sender, EventArgs e)
        {
            Employee_Assignments employee_Assignments = new Employee_Assignments(_db, cnic);
            this.Hide();
            employee_Assignments.Show();
        }
    }
}
