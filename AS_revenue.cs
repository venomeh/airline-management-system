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
            showStatus.Text = "";


            /////////////selecting flight id where fligh status is not canceled
            OracleCommand oracleCommand1 = _db.con().CreateCommand();
            oracleCommand1.CommandText = "SELECT DISTINCT flight_id FROM FLIGHT WHERE aircraft_id = '" + aircraftID + "' " +
                "AND FLIGHT_STATUS NOT IN ('CANCELED') " +
                "ORDER BY flight_id ASC";

            try
            {
                OracleDataReader reader = oracleCommand1.ExecuteReader();

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


            ////////////displaying revenue generated according to that aircraft id that was selected

            string aircraft_id = aircraft_comboBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(aircraft_id)) { return; }

            showRevenue.Text = "0";
            showStatus.Text = "-";

            //Command to retrieve total revenue
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT SUM(b.ticket_price) AS total " +
                "FROM BOOKING b " +
                "INNER JOIN FLIGHT f ON f.flight_id = b.flight_id " +
                "WHERE f.aircraft_id = '" + aircraft_id + "' AND f.flight_status NOT IN ('CANCELED')";
                


            try
            {
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    showRevenue.Text = reader["total"].ToString();
                    label_revenueGenerated.Text = "Revenue Generated (Aircraft)";
                }
                

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Command to retrieve booking details against the selected aircraft to show in data grid view 
            OracleCommand oracleCommand2 = _db.con().CreateCommand();
            oracleCommand2.CommandText = "SELECT b.BOOKING_DATE, b.TICKET_PRICE, b.FLIGHT_ID, b.PASSENGER_ID, b.DEPARTURE_CITY, b.ARRIVAL_CITY, " +
                "b.DEP_DATE " +
                "FROM BOOKING b " +
                "INNER JOIN FLIGHT f ON f.flight_id = b.flight_id " +
                "WHERE f.aircraft_id = '" + aircraft_id + "' AND f.flight_status NOT IN ('CANCELED') " +
                "ORDER BY b.booking_date DESC";
           
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
                else
                    showRevenue.Text = "No bookings Found";
                   
                reader.Close();
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

            // Command to retrieve total revenue according to flight id 
            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT SUM(b.ticket_price) AS total, f.flight_status " +
                "FROM BOOKING b " +
                "INNER JOIN FLIGHT f ON f.flight_id = b.flight_id " +
                "WHERE f.flight_id = '" + flight_id + "' AND f.flight_status NOT IN 'CANCELED'" +
                "GROUP BY F.flight_status";
               

            try
            {
                showRevenue.Text = "0"; 
                showStatus.Text = "-";
                OracleDataReader reader = oracleCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    showRevenue.Text = reader["total"].ToString();
                    showStatus.Text = reader["flight_status"].ToString();
                    label_revenueGenerated.Text = "Revenue Generated (Flight)";

                }
                else
                {
                    showRevenue.Text = "No bookings Found";

                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Command to retrieve booking details against flight id to show in data grid view
            OracleCommand oracleCommand2 = _db.con().CreateCommand();
            oracleCommand2.CommandText = "SELECT b.BOOKING_DATE, b.TICKET_PRICE, b.FLIGHT_ID, b.PASSENGER_ID, b.DEPARTURE_CITY, b.ARRIVAL_CITY, " +
                "b.DEP_DATE " +
                "FROM BOOKING b " +
                "INNER JOIN FLIGHT f ON f.flight_id = b.flight_id " +
                "WHERE b.flight_id = '" + flight_id + "' AND f.flight_status NOT IN ('CANCELED') " +
                "ORDER BY b.booking_date DESC";

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
                else
                {
                    showStatus.Text = "No bookings Found";

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
            showRevenue.Text = "0";
            showStatus.Text = "-";

            OracleCommand oracleCommand = _db.con().CreateCommand();
            oracleCommand.CommandText = "SELECT DISTINCT aircraft_id FROM FLIGHT " +
                "WHERE FLIGHT_STATUS NOT IN ('CANCELED') " +
                "ORDER BY aircraft_id";

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

        void pdf()
        {
            string connectionString = "DATA SOURCE=localhost:1521/xe;USER ID=AirlineSystem;PASSWORD=12345";
            string query = "SELECT BOOKING_DATE, TICKET_PRICE, FLIGHT_ID, PASSENGER_ID, DEPARTURE_CITY, ARRIVAL_CITY, DEP_DATE FROM BOOKING WHERE flight_id = '" + flightid_comboBox.SelectedItem.ToString() + "'";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Generate PDF
                        using (FileStream stream = new FileStream("output.pdf", FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            PdfPTable table = new PdfPTable(dataTable.Columns.Count);

                            // Add table headers
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                table.AddCell(new Phrase(dataTable.Columns[i].ColumnName));
                            }

                            // Add table rows
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataTable.Columns.Count; j++)
                                {
                                    table.AddCell(new Phrase(dataTable.Rows[i][j].ToString()));
                                }
                            }

                            pdfDoc.Add(table);
                            pdfDoc.Close();
                        }

                        MessageBox.Show("PDF generated successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void button_generatePDF_Click(object sender, EventArgs e)
        {
            //GenerateRevenuePDF();
            pdf();
        }


    }
}
