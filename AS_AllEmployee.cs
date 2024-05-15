using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DATABASE_PROJECT
{
    public partial class AS_AllEmployee : Form
    {
        private database _db;

        public AS_AllEmployee(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_AllEmployee_Load(object sender, EventArgs e)
        {
           
            OracleCommand countTotalEmp = _db.con().CreateCommand();
            // Count total employees that exist in the emp table
            countTotalEmp.CommandText = "SELECT COUNT(emp_id) as total FROM EMPLOYEE";

            try
            {
                int totalEmpCount = Convert.ToInt32(countTotalEmp.ExecuteScalar());
                label_TotalEmp.Text += totalEmpCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            OracleCommand countCurrEmp = _db.con().CreateCommand();
            // Count current employees from LOGIN_DETAILS where login_id = 2
            countCurrEmp.CommandText = "SELECT COUNT(login_id) as curr_emp FROM LOGIN_DETAILS WHERE USER_TYPENO = '2'";

            try
            {
                // Execute the command
                int currEmpCount = Convert.ToInt32(countCurrEmp.ExecuteScalar());
                // Display the result
                label_currEmp.Text += currEmpCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (OracleCommand cmd = _db.con().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM employee ORDER BY emp_id ASC"; 
                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading employee data: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();
            this.Hide();
        }

        private void textBox_EmpID_TextChanged(object sender, EventArgs e)
        {
            // Don't delete this function
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonDLT_Click(object sender, EventArgs e)
        {
            if (textBox_EmpID.Text == null)
            {
                MessageBox.Show("Select EMPLOYEE ID");
                return;
            }
            //delete selected employee
            try
            {
                using (OracleCommand cmd = _db.con().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM LOGIN_DETAILS " +
                                      "WHERE login_id IN (SELECT ld.login_id " +
                                                        "FROM EMPLOYEE e " +
                                                        "INNER JOIN USER_TABLE ut ON e.cnic = ut.cnic " +
                                                        "INNER JOIN LOGIN_DETAILS ld ON ld.login_id = ut.loginid " +
                                                        "WHERE e.EMP_ID = :id)";

                    cmd.Parameters.Add("id", OracleDbType.Int32).Value = textBox_EmpID.Text;

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee login details deleted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("No employee login details found for deletion.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting employee login details: " + ex.Message, "Error");
            }


            //calculate employee count again 
           
            OracleCommand countCurrEmp = _db.con().CreateCommand();
            // Count current employees from LOGIN_DETAILS where login_id = 2
            countCurrEmp.CommandText = "SELECT COUNT(login_id) as curr_emp FROM LOGIN_DETAILS WHERE USER_TYPENO = '2'";

            try
            {
                // Execute the command
                int currEmpCount = Convert.ToInt32(countCurrEmp.ExecuteScalar());
                // Display the result
                label_currEmp.Text += currEmpCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label_TotalEmp_Click(object sender, EventArgs e)
        {

        }

        private void AS_AllEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
