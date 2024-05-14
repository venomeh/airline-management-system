using Oracle.ManagedDataAccess.Client;
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
    public partial class AirlineServices : Form
    {
        private database _db;
        public AirlineServices(database db)
        {
            this._db = db;
            InitializeComponent();
        }

        private void AirlineServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LOGIN login = new LOGIN(_db);
            login.Show();
        }




        private void AirlineServices_Load(object sender, EventArgs e)
        {
          
        }


        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            AS_AddEmployee aS_AddEmployee = new AS_AddEmployee(_db);
            this.Hide();
            aS_AddEmployee.Show();
        }

        private void button_schedule_flight_Click(object sender, EventArgs e)
        {
            AS_ScheduleFlight aS_ScheduleFlight = new AS_ScheduleFlight(_db);
            this.Hide();
            aS_ScheduleFlight.Show();
        }

        private void button_assign_pilot_crew_Click(object sender, EventArgs e)
        {
            AS_assignPilotCrew aS_AssignPilotCrew = new AS_assignPilotCrew(_db);
            this.Hide();
            aS_AssignPilotCrew.Show();
        }

        private void button_manage_aircraft_Click(object sender, EventArgs e)
        {
            AS_aircraft aS_Aircraft = new AS_aircraft(_db);
            this.Hide();

            aS_Aircraft.Show(); 
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            AS_Feedback feedback = new AS_Feedback(_db);
            this.Hide();
            feedback.Show();
        }

        private void button_revenue_Click(object sender, EventArgs e)
        {
            AS_revenue aS_Revenue = new AS_revenue(_db);
            this.Hide();
            aS_Revenue.Show();
        }

        private void button_allEmp_Click(object sender, EventArgs e)
        {
            AS_AllEmployee emp = new AS_AllEmployee(_db);
            this.Hide();
            emp.Show();
        }

        private void button_update_flight_status_Click(object sender, EventArgs e)
        {

        }
    }
}
