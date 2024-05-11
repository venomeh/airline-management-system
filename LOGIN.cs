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
        private string passwordPlaceholder = "...";
        private void updateGrid()
        {
            try
            {
            
                OracleCommand getEmps = _db.con().CreateCommand();
                getEmps.CommandText = "SELECT * FROM login";
                getEmps.CommandType = CommandType.Text;
                OracleDataReader empDR = getEmps.ExecuteReader();
                System.Data.DataTable empDT = new System.Data.DataTable();
                empDT.Load(empDR);
                dataGridView1.DataSource = empDT;
               
                dataGridView1.Refresh(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
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

            try
            {
              

                OracleCommand command = _db.con().CreateCommand();
                command.CommandText = "INSERT INTO LOGIN (email, password) VALUES (:Email, :Password)";

                // Create and add parameters manually
                command.Parameters.Add(new OracleParameter("Email", textBox_login_email.Text));
                command.Parameters.Add(new OracleParameter("Password", textBox_login_password.Text));

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Inserted Successfully!");
                    updateGrid();
                    dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed!");
                }

                       
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();

            Main_UserView user = new Main_UserView(_db);
            user.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            updateGrid();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
