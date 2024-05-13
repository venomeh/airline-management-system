using DATABASE_PROJECT.Resources;
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
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DATABASE_PROJECT
{
    public partial class LOGIN : Form
    {
        private database _db;
        private string emailPlaceholder = "abc@gmail.com";
        private string passwordPlaceholder = "********";
        
        public LOGIN(database db)
        {
            _db = db;
            InitializeComponent();
            
            // Set the initial placeholder text for each TextBox
            SetPlaceholder(textBox_login_email, emailPlaceholder);
            SetPlaceholder(textBox_login_password, passwordPlaceholder);

            // Attach event handlers
            AttachEventHandlers(textBox_login_email, emailPlaceholder);
            AttachEventHandlers(textBox_login_password, passwordPlaceholder);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox_login_email.Text;
            string password = textBox_login_password.Text;
            string dbLoginId = "";
            string dbPassword = "";
            string dbEmail = "";
           
            OracleCommand query = _db.con().CreateCommand();
            query.CommandText = "SELECT login_id, email, password, user_typeno FROM LOGIN_DETAILS WHERE email = :e";
            query.Parameters.Add(new OracleParameter("e", email));

            OracleDataReader reader = query.ExecuteReader();
            if (reader.Read())
            {
                dbLoginId = reader["login_id"].ToString();
                dbPassword = reader["password"].ToString();
                dbEmail = reader["email"].ToString();
                if (dbPassword != password)
                {
                    MessageBox.Show("Incorrect Password");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Incorrect Email");
                return;
            }

            string userTypeNo = reader["user_typeno"].ToString();
            
            //if login is ADMIN
            if (userTypeNo == "3")
            {
                this.Hide();

                AirlineServices emp = new AirlineServices(_db);
                emp.Show();

            }
            query.CommandText = "SELECT type_name FROM LOGIN_TYPE WHERE type_no = '" + userTypeNo + "'";
            reader = query.ExecuteReader();
               
            
            if (reader.Read()) // Check if a row was returned
            {
                OracleDataReader cnicReader;
                query.CommandText = "SELECT cnic FROM USER_TABLE WHERE loginid = " + dbLoginId;
                cnicReader = query.ExecuteReader();
                
                if (reader["type_name"].ToString() == "EMPLOYEE")
                {
                    if (cnicReader.Read())
                    {
                        this.Hide();

                        Employee emp = new Employee(_db, cnicReader["cnic"].ToString());
                        emp.Show();
                    }
                }
                if (reader["type_name"].ToString() == "PASSENGER")
                {
                    if (cnicReader.Read())
                    {
                        this.Hide();

                        Main_UserView user = new Main_UserView(_db, cnicReader["cnic"].ToString());
                        user.Show();
                    }
                }
            }

            //Close the reader
            reader.Close();

         

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void TB_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void signUp_button_Click(object sender, EventArgs e)
        {
            SignUp user = new SignUp(_db);
            user.Show();

            this.Hide();
        }

        private void textBox_login_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox_login_password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    
    }
}
