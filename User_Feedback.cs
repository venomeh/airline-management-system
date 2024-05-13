using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATABASE_PROJECT.Resources;
using Oracle.ManagedDataAccess.Client;
namespace DATABASE_PROJECT
{
    public partial class User_Feedback : Form
    {
        private database _db;
        public string cnic;
        public User_Feedback(database db, string cnic)
        {
            InitializeComponent();
            _db = db;
            this.cnic = cnic;
        }

        private void User_Feedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void User_Feedback_Load(object sender, EventArgs e)
        {
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main_UserView user = new Main_UserView(_db, cnic);
            user.Show();

            this.Hide();
        }

        private void label_charLeft_Click(object sender, EventArgs e)
        {
        
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Feedback.Text.Length > 500)
                {
                    MessageBox.Show("Feedback message exceeds the maximum allowed length of 500 characters.");
                    return;
                }

               
                OracleCommand sql = _db.con().CreateCommand(); 
                sql.CommandText = "INSERT INTO FEEDBACK (MSG, CNIC) VALUES (:message, :cnic)";


                sql.Parameters.Add(":message", OracleDbType.Varchar2).Value = textBox_Feedback.Text;
                sql.Parameters.Add(":cnic", OracleDbType.Int32).Value = cnic;

                int rowsInserted = sql.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    MessageBox.Show("Feedback inserted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to insert feedback.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void textBox_Feedback_TextChanged(object sender, EventArgs e)
        {

            label_charLeft.Text = (500 - textBox_Feedback.Text.Length).ToString();

        }
    }
}
