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
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (OracleCommand cmd = _db.con().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM employee"; 
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
            if (textBox_EmpID.Text != null)
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
                        MessageBox.Show("No employee login details found for deletion.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting employee login details: " + ex.Message, "Error");
            }
        }


    }
}
