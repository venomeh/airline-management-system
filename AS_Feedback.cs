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
    public partial class AS_Feedback : Form
    {
        private database _db;
        private int currentIndex = 0;
        private List<string> feedbackMessages = new List<string>();

        public AS_Feedback(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_Feedback_Load(object sender, EventArgs e)
        {
            LoadFeedbackMessages();
        }

        private void LoadFeedbackMessages()
        {
            try
            {
                using (OracleCommand cmd = _db.con().CreateCommand())
                {
                    cmd.CommandText = "SELECT MSG FROM Feedback"; 
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        feedbackMessages.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading feedback messages: " + ex.Message);
            }
        }

        private void DisplayFeedbackMessage(int index)
        {
            if (index >= 0 && index < feedbackMessages.Count)
            {
                textBox.Text = feedbackMessages[index];
            }
            else
            {
                MessageBox.Show("No more feedback messages available.");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentIndex++;
            DisplayFeedbackMessage(currentIndex);
        }
    }
}
