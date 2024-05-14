using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Oracle.ManagedDataAccess.Client;
using System.Xml.Linq;
using System.Reflection;
namespace DATABASE_PROJECT
{
    public partial class AS_revenue : Form
    {
        private database _db;

        public AS_revenue(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_revenue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void revenueGeneratedOut_label_Click(object sender, EventArgs e)
        {
            // total revenue generated through bookings 
        }

        private void StatusOfFlightOut_label_Click(object sender, EventArgs e)
        {
            // either in profit or loss 
            // total revenue generated - cost
        }

        private void costOut_label_Click(object sender, EventArgs e)
        {
            // cost of flight 
        }

        private void flightID_label_Click(object sender, EventArgs e)
        {

        }

        private void maintainance_label_Click(object sender, EventArgs e)
        {

        }

        private void revenueGenerated_label_Click(object sender, EventArgs e)
        {

        }

        private void statusOfFlight_label_Click(object sender, EventArgs e)
        {

        }

        private void cost_label_Click(object sender, EventArgs e)
        {

        }

        private void aircraftId_label_Click(object sender, EventArgs e)
        {

        }

        private void airline_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aircraftID = aircraft_comboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(aircraftID)) { return; }

            flightid_comboBox.Items.Clear();

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT DISTINCT flight_id FROM FLIGHT where aircraft_id = '" + aircraftID + "'";

            try
            {

                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["flight_id"].ToString();
                        flightid_comboBox.Items.Add(id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void flightid_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string flight_id = flightid_comboBox.SelectedItem.ToString();
            string aircraft_id = aircraft_comboBox.SelectedItem.ToString();

            if (string.IsNullOrEmpty(flight_id)) { return; }
            if (string.IsNullOrEmpty(aircraft_id)) { return; }

            // Command to retrieve total revenue
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT SUM(ticket_price) AS total FROM BOOKING WHERE flight_id = '" + flight_id + "'";

            try
            {
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    showRevenue.Text = reader["total"].ToString();
                }
                else
                    showRevenue.Text = "0"; // i think this should be s

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Command to retrieve booking details
            OracleCommand oracleCommand2 = _db.con().CreateCommand();
            oracleCommand2.CommandText = "SELECT BOOKING_DATE, TICKET_PRICE, FLIGHT_ID, PASSENGER_ID, DEPARTURE_CITY, ARRIVAL_CITY, DEP_DATE FROM BOOKING WHERE flight_id = '" + flight_id + "'";

            try
            {
                OracleDataReader reader = oracleCommand2.ExecuteReader();

                if (reader.HasRows)
                {
                    //Add retrieved data to a DataGridView
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bookingGrid.DataSource = dataTable;
                    bookingGrid.Refresh();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void maintainance_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AirlineServices airlineServices = new AirlineServices(_db);
            airlineServices.Show();

            this.Hide();
        }

        private void AS_revenue_Load(object sender, EventArgs e)
        {
            showRevenue.Text = "";
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT DISTINCT aircraft_id FROM FLIGHT";

            try
            {

                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string id = reader["aircraft_id"].ToString();
                        aircraft_comboBox.Items.Add(id);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GenerateRevenuePDF()
        {
            // Create a Document object
            Document document = new Document();
            // Set the file path for the PDF
            string filePath = "RevenueReport.pdf";

            // Create a PdfWriter instance to write the PDF to the file system
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Open the document
            document.Open();

            // Add content to the document
            PdfPTable table = new PdfPTable(bookingGrid.ColumnCount);
            // Add columns
            for (int i = 0; i < bookingGrid.ColumnCount; i++)
            {
                table.AddCell(new Phrase(bookingGrid.Columns[i].HeaderText));
            }
            // Add rows
            for (int i = 0; i < bookingGrid.Rows.Count; i++)
            {
                for (int j = 0; j < bookingGrid.Columns.Count; j++)
                {
                    if (bookingGrid.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(bookingGrid.Rows[i].Cells[j].Value.ToString()));
                    }
                }
            }
            // Add average of total amount of revenue
            double totalRevenue = 0;
            foreach (DataRow row in ((DataTable)bookingGrid.DataSource).Rows)
            {
                totalRevenue += Convert.ToDouble(row["Amount"]);
            }
            double averageRevenue = totalRevenue / bookingGrid.Rows.Count;
            table.AddCell(new Phrase("Average Revenue: " + averageRevenue.ToString()));

            // Add the table to the document
            document.Add(table);

            // Close the document
            document.Close();

            MessageBox.Show("PDF generated successfully.");
        }
        private void button_generatePDF_Click(object sender, EventArgs e)
        {
            GenerateRevenuePDF();
        }


    }
}
