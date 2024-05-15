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
    public partial class Employee_Assignments : Form
    {
        private database _db;
        public string cnic;
        public Employee_Assignments(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void Employee_Assignments_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Assignments_Load(object sender, EventArgs e)
        {
            label_displapcrewId.Text = "";
            label_displayflightID.Text = "";
            label_displayDepCity.Text = "";
            label_displayArrCity.Text = "";
            label_displayDepDate.Text = "";

            OracleCommand command = _db.con().CreateCommand();
            command.CommandText = "SELECT c.crew_ID, f.flight_id, f.departure_city, f.arrival_city, f.dep_date " +
                                   "FROM CREW c " +
                                   "INNER JOIN FLIGHT f ON f.flight_id = c.flight_id " +
                                   "INNER JOIN EMPLOYEE e ON e.emp_id = c.emp_id " +
                                   "WHERE e.cnic = :CNIC";

            command.Parameters.Add(new OracleParameter("CNIC", this.cnic));

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Display values in labels
                label_displapcrewId.Text = reader["crew_ID"].ToString();
                label_displayflightID.Text = reader["flight_id"].ToString();
                label_displayDepCity.Text = reader["departure_city"].ToString();
                label_displayArrCity.Text = reader["arrival_city"].ToString();
                label_displayDepDate.Text = reader["dep_date"].ToString();
            }
            else
            {
                OracleCommand commandCrewID = _db.con().CreateCommand();
                commandCrewID.CommandText = "SELECT c.crew_ID " +
                                       "FROM CREW c " +
                                       "INNER JOIN EMPLOYEE e ON e.emp_id = c.emp_id " +
                                       "WHERE e.cnic = :CNIC";

                commandCrewID.Parameters.Add(new OracleParameter("CNIC", this.cnic));

                OracleDataReader readerCrew = commandCrewID.ExecuteReader();

                if (readerCrew.Read())
                {
                    label_displapcrewId.Text = readerCrew["crew_ID"].ToString();
                }
                
                label_displayflightID.Text = "NOT ASSIGNED";
                label_displayDepCity.Text = "NOT ASSIGNED";
                label_displayArrCity.Text = "NOT ASSIGNED";
                label_displayDepDate.Text = "NOT ASSIGNED";
            }

            reader.Close();
            command.Dispose();


        }

        private void label_displayName_Click(object sender, EventArgs e)
        {

        }

        private void cnic_label_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(_db, cnic);
            emp.Show();

            this.Hide();
        }
    }
}
