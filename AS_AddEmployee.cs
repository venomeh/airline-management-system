using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE_PROJECT.Resources;
using Oracle.ManagedDataAccess.Client;
namespace DATABASE_PROJECT
{
    public partial class AS_AddEmployee : Form
    {
        private database _db;
        public string firstName, lastName, phoneNo, email, cnic, password, salary, experience, age, performance, occupation;

        private void label_passwordCheck_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length < 8)
                label_passwordCheck.Text = "Enter 8 chars";
            else
                label_passwordCheck.Text = "";
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox_firstName.Text;
        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox_lastName.Text;
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            email = textBox_email.Text;
        }

        private void textBox_phoneNo_TextChanged(object sender, EventArgs e)
        {
            phoneNo = textBox_phoneNo.Text;
        }

        private void textBox_Salary_TextChanged(object sender, EventArgs e)
        {
            salary = textBox_Salary.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            experience = textBox_Experience.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            performance = textBox_performance.Text;
        }

        

        private void radioButton_Crew_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "C";
        }

        private void radioButton_Staff_CheckedChanged(object sender, EventArgs e)
        {
            occupation = "S";
        }

        public string passwordLenth;
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            password = textBox_password.Text;
        }

        private void cnic_txtbox_TextChanged(object sender, EventArgs e)
        {
            cnic = cnic_txtbox.Text;
        }

        public AS_AddEmployee(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            age = textBox_age.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AS_AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();
        }
        bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|hotmail\.com|yahoo\.com|icloud\.com|cfd.nu.edu\.pk)$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
        private void signUp_button_Click(object sender, EventArgs e)
        {
            string fullName = firstName + " " + lastName;

            try
            {
                if (string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) ||
                    string.IsNullOrEmpty(textBox_phoneNo.Text) || string.IsNullOrEmpty(textBox_email.Text) ||
                    string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_Salary.Text) ||
                    string.IsNullOrEmpty(cnic_txtbox.Text) || string.IsNullOrEmpty(textBox_Experience.Text) ||
                    string.IsNullOrEmpty(textBox_age.Text)
                    || (!radioButton_Staff.Checked && !radioButton_Crew.Checked))
                {
                    MessageBox.Show("Insert complete data");
                    return;
                }

                //check if both first name and last name contain only letters
                Regex regex = new Regex("^[a-zA-Z]+$");

                if (!regex.IsMatch(lastName))
                {
                    MessageBox.Show("First Name should contain only letters");
                    return;
                }
                if (!regex.IsMatch(firstName))
                {
                    MessageBox.Show("First Name should contain only letters");
                    return;
                }

                //check for valid phone number to start with 03 with 11 digits
                if (phoneNo.Length != 11 || phoneNo[0] != '0' || phoneNo[1] != '3' || !phoneNo.All(char.IsDigit))
                {
                    MessageBox.Show("Enter valid phone number");
                    return;
                }
                //check for valid email 
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Enter valid email address");
                    return;
                }

                if (cnic.Length != 13 || !cnic.All(char.IsDigit))
                {
                    MessageBox.Show("Enter a valid 13-digit CNIC containing only digits.");
                    return;
                }

                if (password.Length < 8)
                {
                    MessageBox.Show("Enter atleast 8 char password");
                    return;
                }

                if (!salary.All(char.IsDigit))
                {
                    MessageBox.Show("Salary should contain only numbers");
                    return;
                }

                if (!age.All(char.IsDigit) || !experience.All(char.IsDigit) || !performance.All(char.IsDigit))
                {
                    MessageBox.Show("Age, experience, and performance should be numeric values.");
                    return;
                }

                int ageValue = int.Parse(age);
                int experienceValue = int.Parse(experience);
                int performanceValue = int.Parse(performance);

                if (ageValue < 18 || ageValue > 100)
                {
                    MessageBox.Show("Age should be between 18 and 100.");
                    return;
                }

                if (experienceValue < 0 || experienceValue > 35)
                {
                    MessageBox.Show("Experience should be between 0 and 35.");
                    return;
                }

                if (performanceValue < 10 || performanceValue > 100)
                {
                    MessageBox.Show("Performance should be between 10 and 100.");
                    return;
                }


                OracleCommand command = _db.con().CreateCommand();
                OracleCommand command2 = _db.con().CreateCommand();
                OracleDataReader reader = null;
                OracleDataReader reader2 = null;
                //checks if the cnic is already registered for USER
                command.CommandText = "SELECT * FROM USER_TABLE WHERE CNIC = '" + cnic + "'";
                reader = command.ExecuteReader();

                //check if cnic is already used by as an EMPLOYEE
                command2.CommandText = "SELECT * FROM EMPLOYEE WHERE CNIC = '" + cnic + "'";
                reader2 = command2.ExecuteReader();
               
                // Check if any rows are returned
                if (reader.HasRows || reader2.HasRows)
                {
                    MessageBox.Show("CNIC is already used.");
                    return;
                }
                else
                {
                    MessageBox.Show("CNIC can be used.");
                }


                try
                {
                    Random random = new Random();
                    int randomLoginID;

                    OracleCommand selectQuery = _db.con().CreateCommand();

                    do
                    {
                        randomLoginID = random.Next(1000, 10000); // Generate a 4-digit random number
                        selectQuery.CommandText = "SELECT COUNT(*) FROM LOGIN_DETAILS WHERE login_id = " + randomLoginID;

                        int count = Convert.ToInt32(selectQuery.ExecuteScalar());

                        // If count is 0, the login ID doesn't exist in the database, so break the loop
                        if (count == 0)
                        {
                            break;
                        }
                    } while (true);

                    selectQuery.CommandText = "SELECT type_no FROM LOGIN_TYPE WHERE type_name = 'EMPLOYEE'";
                    reader = selectQuery.ExecuteReader();

                    int userTypeNo = 3;
                    if (reader.Read())
                    {
                        userTypeNo = reader.GetInt32(0);
                    }
                    reader.Close();

                    OracleCommand insertQuery1 = _db.con().CreateCommand();
                    OracleCommand insertQuery2 = _db.con().CreateCommand();
                    OracleCommand insertQuery3 = _db.con().CreateCommand();

                    //insert in login_details table
                    insertQuery1.CommandText = "INSERT INTO LOGIN_DETAILS (login_id, email, password, user_typeno) VALUES (:LoginId, :Email, :Password, :UserType)";
                    insertQuery1.Parameters.Add(new OracleParameter("LoginId", randomLoginID));
                    insertQuery1.Parameters.Add(new OracleParameter("Email", email));
                    insertQuery1.Parameters.Add(new OracleParameter("Password", password));
                    insertQuery1.Parameters.Add(new OracleParameter("UserType", userTypeNo));

                    int rowsAffected = insertQuery1.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                        MessageBox.Show("Failed to insert login details.");


                    //insert in user_table
                    string sqlQuery1 = "INSERT INTO USER_TABLE (person_name, cnic, email, phone_num, loginid) " +
                                        "VALUES (:Name, :CNIC, :Email, :PhoneNum, :LoginID)";

                    insertQuery2.CommandText = sqlQuery1;
                    insertQuery2.Parameters.Add(new OracleParameter("Name", fullName));
                    insertQuery2.Parameters.Add(new OracleParameter("CNIC", cnic));
                    insertQuery2.Parameters.Add(new OracleParameter("Email", email));
                    insertQuery2.Parameters.Add(new OracleParameter("PhoneNum", phoneNo));
                    insertQuery2.Parameters.Add(new OracleParameter("LoginID", randomLoginID));

                    rowsAffected = insertQuery2.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                        MessageBox.Show("Failed to insert user details.");
                   
                    
                   

                    //insert in employee table
                    string sqlQuery = "INSERT INTO EMPLOYEE (performance, experience, occupation, salary, age, cnic) " +
                    "VALUES (:Performance, :EXP, :Occupation, :SAL, :AGE, :CNIC)";

                    insertQuery3.CommandText = sqlQuery;
                    insertQuery3.Parameters.Add(new OracleParameter("Performance", performance));
                    insertQuery3.Parameters.Add(new OracleParameter("EXP", experience));
                    insertQuery3.Parameters.Add(new OracleParameter("Occupation", occupation));
                    insertQuery3.Parameters.Add(new OracleParameter("SAL", salary));
                    insertQuery3.Parameters.Add(new OracleParameter("AGE", age));
                    insertQuery3.Parameters.Add(new OracleParameter("CNIC", cnic));
                    rowsAffected = insertQuery3.ExecuteNonQuery();
                    
                   // if (occupation == "C")
                    {
                        string empIdQuery = "SELECT emp_id FROM EMPLOYEE WHERE cnic = :CNIC";
                        OracleCommand empIdCommand = _db.con().CreateCommand();
                        empIdCommand.CommandText = empIdQuery;
                        empIdCommand.Parameters.Add(":CNIC", cnic);

                        int empId = Convert.ToInt32(empIdCommand.ExecuteScalar());
                        empIdCommand.Dispose();

                        string insertCrewQuery = "INSERT INTO CREW (emp_id) VALUES (:EMP_ID)";
                        OracleCommand insertCrewCommand = _db.con().CreateCommand();
                        insertCrewCommand.CommandText = insertCrewQuery;
                        insertCrewCommand.Parameters.Add(":EMP_ID", empId);
                        insertCrewCommand.ExecuteNonQuery();

                        insertCrewCommand.Dispose();

                    }
                   // else

                    {
                        
                    }
                    if (rowsAffected > 0)
                        MessageBox.Show("Employee Account Created");
                    else
                        MessageBox.Show("Data Insertion Failed! Account Not Created");


                    insertQuery1.Dispose();
                    insertQuery2.Dispose();
                    insertQuery3.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    command.Dispose();
                    command2.Dispose();
                    reader.Close();
                    reader2.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
