using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.ManagedDataAccess.Client;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Reflection.Emit;

namespace DATABASE_PROJECT
{
    public partial class SignUp : Form
    {
        private database _db;
        
        private string phoneNoPlaceholder = "03001234567";
        private string emailPlaceholder = "abc@gmail.com";
        private string cnicPlaceholder = "0123456789123";

        public string phoneNumber, signUpEmail, OTPGeneratedForEmail = "", cnic, pass, confirmPass, firstName, lastName, generatedOTP, emergencyContact;
        int disability;

        public SignUp(database db)
        {
            InitializeComponent();

            SetPlaceholder(textBox_email, emailPlaceholder);
            SetPlaceholder(textBox_phoneNo, phoneNoPlaceholder);
            SetPlaceholder(cnic_txtbox, cnicPlaceholder);

            AttachEventHandlers(textBox_email, emailPlaceholder);
            AttachEventHandlers(textBox_phoneNo, phoneNoPlaceholder);
            AttachEventHandlers(cnic_txtbox, cnicPlaceholder);

            _db = db;

            // Check if the database connection is open
            if (_db.con().State != ConnectionState.Open)
            {
                _db.con().Open(); // Open the connection if it's not already open
            }
        }
        

        bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|hotmail\.com|yahoo\.com|icloud\.com|cfd.nu.edu\.pk)$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }   

        private void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
        }

        private void AttachEventHandlers(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Enter += (sender, e) => TextBox_Enter(sender, e, placeholder);
            textBox.Leave += (sender, e) => TextBox_Leave(sender, e, placeholder);
        }

        private void TextBox_Enter(object sender, EventArgs e, string placeholder)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            // Clear the placeholder text when TextBox is focused
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText; // Restore default text color
            }
        }

        private void TextBox_Leave(object sender, EventArgs e, string placeholder)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            // Restore the placeholder text if TextBox is left empty
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox_phoneNo_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = textBox_phoneNo.Text;
            
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            signUpEmail = textBox_email.Text;
            
        }
       
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            pass = textBox_password.Text;

            if (pass.Length < 8)
                label_passwordCheck.Text = "Enter 8 Char";
            if (string.IsNullOrEmpty(textBox_password.Text) || pass.Length >= 8)
                label_passwordCheck.Text = "";
            
            //label msg to see if passwword is mathced with confirm Password textbox
            if (confirmPass != pass)
                label_passwordNotMatch.Text = "Not match";
            else if (confirmPass == pass)
            {
                label_passwordNotMatch.Text = "Matched";
                ResetLabelAfterDelay(label_passwordNotMatch, 3000); //resets label after 3 seconds if matched
            }
            if (string.IsNullOrEmpty(textBox_confirmPass.Text))
                label_passwordNotMatch.Text = "";
        }

        private async void ResetLabelAfterDelay(System.Windows.Forms.Label label, int delay)
        {
            await Task.Delay(delay);
            label.Text = "";
        }

        private void textBox_confirmPass_TextChanged(object sender, EventArgs e)
        {
            confirmPass = textBox_confirmPass.Text;

            if (confirmPass != pass)
                label_passwordNotMatch.Text = "Not match";
            else if (confirmPass == pass)
            {
                label_passwordNotMatch.Text = "Matched";
                ResetLabelAfterDelay(label_passwordNotMatch, 3000); //resets label after 3 seconds if matched
            }
            if (string.IsNullOrEmpty(textBox_confirmPass.Text))
                label_passwordNotMatch.Text = "";


        }
        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LOGIN user = new LOGIN(_db);
            user.Show();

            this.Hide();
        }
        
        private string GenerateRandomNumber(int digits = 5)
        {
            // Generate a random OTP (you can customize the length and characters as needed)
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, digits).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendOTPEmail(string recipientEmail, string otp)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("f223277@cfd.nu.edu.pk");
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = "OTP - AIRLINE MANAGEMENT SYSTEM";
                mailMessage.Body = $"Your OTP for account verification is: {otp}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("f223277@cfd.nu.edu.pk", "PTMF2723e!"); //SENDER email,password
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; 
                smtpClient.Port = 587;
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("An OTP has been sent to your email. Please verify your account.");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send OTP email: " + ex.Message);
            }
        }

        // send data to the database form sign up
        private void signUp_button_Click(object sender, EventArgs e)
        {
            string fullName = firstName + " " + lastName;

            try
            {
                if (string.IsNullOrEmpty(textBox_firstName.Text) || string.IsNullOrEmpty(textBox_lastName.Text) ||
                    string.IsNullOrEmpty(textBox_phoneNo.Text) || string.IsNullOrEmpty(textBox_email.Text) ||
                    string.IsNullOrEmpty(textBox_password.Text) || string.IsNullOrEmpty(textBox_confirmPass.Text) ||
                    string.IsNullOrEmpty(cnic_txtbox.Text) || string.IsNullOrEmpty(textBox_emergencyNo.Text)
                    || (!radioButton_NO.Checked && !radioButton_YES.Checked))
                {
                    MessageBox.Show("Insert complete data");
                    return;
                }

                if (string.IsNullOrEmpty(textBox_confirmOTP.Text))
                {
                    MessageBox.Show("Generate and Confirm OTP");
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
                if (phoneNumber.Length != 11 || phoneNumber[0] != '0' || phoneNumber[1] != '3' || !phoneNumber.All(char.IsDigit))
                {
                    MessageBox.Show("Enter valid phone number");
                    return;
                }
                if (emergencyContact.Length != 11 || emergencyContact[0] != '0' || emergencyContact[1] != '3' || !emergencyContact.All(char.IsDigit))
                {
                    MessageBox.Show("Enter valid emergency contact");
                    return;
                }
                if (emergencyContact == phoneNumber)
                {
                    MessageBox.Show("Phone Number and Emergency Contact can't be same");
                    return;
                }
                //check for valid email 
                if (!IsValidEmail(signUpEmail))
                {
                    MessageBox.Show("Enter valid email address");
                    return;
                }

                if (cnic.Length != 13 || !cnic.All(char.IsDigit))
                {
                    MessageBox.Show("Enter a valid 13-digit CNIC containing only digits.");
                    return;
                }

                if (pass.Length < 8)
                {
                    MessageBox.Show("Enter atleast 8 char password");
                    return;
                }

                if (pass != confirmPass)
                {
                    MessageBox.Show("Password does not match");
                    return;
                }

                OracleCommand command = _db.con().CreateCommand();
                OracleDataReader reader = null;
                bool cnicAlreadyExists = false;
                //checks if the cnic is already registered
                command.CommandText = "SELECT loginid FROM USER_TABLE WHERE CNIC = '" + cnic + "'";
                reader = command.ExecuteReader();
                // Check if any rows are returned
                if (reader.HasRows)
                {
                    // Read the first row to check the loginid
                    reader.Read();

                    // Check if loginid is not null
                    if (!reader.IsDBNull(0))
                    {
                        MessageBox.Show("CNIC is already used.");
                        return;
                    }
                    else
                    {
                        cnicAlreadyExists = true;
                        MessageBox.Show("CNIC exists but can be used.");
                    }
                }
                else
                {
                    MessageBox.Show("CNIC can be used.");
                }

                // Check if the email is already registered
                command.CommandText = "SELECT * FROM LOGIN_DETAILS WHERE email = '" + OTPGeneratedForEmail + "'";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Email is already used");
                    return;
                }
                command.Dispose();

                // This checks for that user shoud not be allowed to change the email after putting OTP, means to check weather the otp was generated for that email 
                if (signUpEmail != OTPGeneratedForEmail)
                {
                    MessageBox.Show("OTP was not confirmed for " + signUpEmail);
                    return;

                }
                if (generatedOTP == textBox_confirmOTP.Text)
                    MessageBox.Show("OTP Verified!");
                else
                {
                    MessageBox.Show("Wrong OTP!");
                    return;
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
                    
                    selectQuery.CommandText = "SELECT type_no FROM LOGIN_TYPE WHERE type_name = 'PASSENGER'";
                    reader = selectQuery.ExecuteReader();

                    int userTypeNo = 1;
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
                    insertQuery1.Parameters.Add(new OracleParameter("Email", signUpEmail));
                    insertQuery1.Parameters.Add(new OracleParameter("Password", pass));
                    insertQuery1.Parameters.Add(new OracleParameter("UserType", userTypeNo));

                    int rowsAffected = insertQuery1.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                        MessageBox.Show("Failed to insert login details.");

                    if (!cnicAlreadyExists)
                    {
                        //insert in user_table
                        string sqlQuery1 = "INSERT INTO USER_TABLE (person_name, cnic, email, phone_num, loginid) " +
                                            "VALUES (:Name, :CNIC, :Email, :PhoneNum, :LoginID)";

                        insertQuery2.CommandText = sqlQuery1;
                        insertQuery2.Parameters.Add(new OracleParameter("Name", fullName));
                        insertQuery2.Parameters.Add(new OracleParameter("CNIC", cnic));
                        insertQuery2.Parameters.Add(new OracleParameter("Email", signUpEmail));
                        insertQuery2.Parameters.Add(new OracleParameter("PhoneNum", phoneNumber));
                        insertQuery2.Parameters.Add(new OracleParameter("LoginID", randomLoginID));

                        rowsAffected = insertQuery2.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                            MessageBox.Show("Failed to insert user details.");
                        
                        //insert in Passenger table
                        string sqlQuery = "INSERT INTO PASSENGERS (disability, EMERGENCY_CONTACT, cnic) " +
                                          "VALUES (:Disability, :EmergencyContact, :CNIC)";

                        insertQuery3.CommandText = sqlQuery;
                        insertQuery3.Parameters.Add(new OracleParameter("Disability", disability));
                        insertQuery3.Parameters.Add(new OracleParameter("EmergencyContact", emergencyContact));
                        insertQuery3.Parameters.Add(new OracleParameter("CNIC", cnic));

                        rowsAffected = insertQuery3.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Account Created");
                        else
                            MessageBox.Show("Data Insertion Failed! Account Not Created");

                    }
                    else if (cnicAlreadyExists) //if cnic exists but the account does not means previously account existed but than deleted than update data
                    {
                        //update data in user_table

                        string sqlQuery1 = "UPDATE USER_TABLE SET loginid = " + randomLoginID + ", person_name = '" + fullName + 
                            "',email = '" + signUpEmail +"', phone_num = " + phoneNumber + " WHERE cnic = '" + cnic + "'";

                        insertQuery2.CommandText = sqlQuery1;
                        insertQuery2.ExecuteNonQuery();
                        rowsAffected = insertQuery2.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                            MessageBox.Show("Failed to update user details with previous account");


                        string sqlQuery = "UPDATE PASSENGERS SET disability = " + disability + ", emergency_contact = " + emergencyContact + " WHERE cnic = '" + cnic +"'";

                        insertQuery3.CommandText = sqlQuery;
                        insertQuery3.ExecuteNonQuery();

                        rowsAffected = insertQuery3.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Account Created");
                        else
                            MessageBox.Show("Data Insertion Failed! Account Not Created");

                    }

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
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void radioButtion_email_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_OTP_Click(object sender, EventArgs e)
        {

        }

        private void label_confirmPass_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label2_phoneNO_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void label_FNameCheck_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label1_Click_5(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            emergencyContact = textBox_emergencyNo.Text;
        }

        private void radioButton_NO_CheckedChanged(object sender, EventArgs e)
        {
            disability = 0;
        }

        private void radioButton_YES_CheckedChanged(object sender, EventArgs e)
        {
            disability = 1;
        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox_lastName.Text;
        }

        private void button_getOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_email.Text) || textBox_email.Text == emailPlaceholder)
            {
                MessageBox.Show("Enter email");
                return;
            }    

            OTPGeneratedForEmail = textBox_email.Text;

            OracleCommand command = _db.con().CreateCommand();
            OracleDataReader reader = null;

            // Check if the email is already registered
            command.CommandText = "SELECT * FROM USER_TABLE WHERE email = :Email";
            command.Parameters.Add(new OracleParameter("Email", OTPGeneratedForEmail)); 
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Email is already used");
                return;
            }

            generatedOTP = GenerateRandomNumber();
           
                MessageBox.Show(generatedOTP);
            // Send OTP via email
            SendOTPEmail(OTPGeneratedForEmail, generatedOTP);
        }

        private void textBox_confirmOTP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox_firstName.Text;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
    

        private void label_OTPMsg_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_SMS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cnic_txtbox_TextChanged(object sender, EventArgs e)
        {
            cnic = cnic_txtbox.Text;
        }
    }
}
