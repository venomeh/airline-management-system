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
    public partial class Employee_Profile : Form
    {
        private database _db;
        public string cnic;

        public Employee_Profile(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void Employee_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Profile_Load(object sender, EventArgs e)
        {
            label_displayName.Text = "";
            label_displayCNIC.Text = "";
            label_displayEmail.Text = "";
            label_displayPhoneNo.Text = "";
            label_displayPassword.Text = "";
            label_displaySalary.Text = "";
            label_displayPerformance.Text = "";
            label_displayAge.Text = "";


            OracleCommand command = _db.con().CreateCommand();
            command.CommandText = "SELECT DISTINCT ut.person_name, ut.cnic, ut.email, ut.phone_num, ld.password, " +
                "e.performance, e.age, e.salary " +
                       "FROM user_table ut " +
                       "INNER JOIN LOGIN_DETAILS ld ON ut.loginid = ld.login_id " +
                       "INNER JOIN EMPLOYEE e ON e.cnic = ut.cnic " +
                       "WHERE ut.cnic = :CNIC";

            command.Parameters.Add(new OracleParameter("CNIC", this.cnic));

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label_displayName.Text = reader["person_name"].ToString();
                label_displayCNIC.Text = reader["cnic"].ToString();
                label_displayEmail.Text = reader["email"].ToString();
                label_displayPhoneNo.Text = reader["phone_num"].ToString();
                label_displayPassword.Text = reader["password"].ToString();
                label_displaySalary.Text = reader["salary"].ToString();
                label_displayPerformance.Text = reader["performance"].ToString();
                label_displayAge.Text = reader["age"].ToString();

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

        private void btn_del_profile_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(_db, cnic);
            emp.Show();

            this.Hide();

        }

        private void label_displayPhoneNo_Click(object sender, EventArgs e)
        {

        }

        private void label_displayPassword_Click(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void name_label_Click(object sender, EventArgs e)
        {

        }

        private void label_displayEmail_Click(object sender, EventArgs e)
        {

        }

        private void label_displayCNIC_Click(object sender, EventArgs e)
        {

        }

        private void label_displayName_Click(object sender, EventArgs e)
        {

        }

        private void phone_label_Click(object sender, EventArgs e)
        {

        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void cnic_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
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
