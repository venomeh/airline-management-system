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

            OracleCommand command = _db.con().CreateCommand();
            command.CommandText = "SELECT email, password FROM USER_TABLE WHERE email = :e";
            command.Parameters.Add(new OracleParameter("e", email));

            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string dbEmail = reader["email"].ToString();
                string dbPassword = reader["password"].ToString();

                if (dbPassword == password)
                {
                    MessageBox.Show("Login Successful");
                }
                else
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

            //Close the reader
            reader.Close();


            //this.Hide();

            //Main_UserView user = new Main_UserView(_db);
            //user.Show();

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
