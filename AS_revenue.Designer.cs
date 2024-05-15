namespace DATABASE_PROJECT
{
    partial class AS_revenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_revenue));
            this.aircraft_comboBox = new System.Windows.Forms.ComboBox();
            this.flightid_comboBox = new System.Windows.Forms.ComboBox();
            this.showRevenue = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.bookingGrid = new System.Windows.Forms.DataGridView();
            this.button_generatePDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showStatus = new System.Windows.Forms.Label();
            this.label_FlightStatus = new System.Windows.Forms.Label();
            this.label_revenueGenerated = new System.Windows.Forms.Label();
            this.label_FlightID = new System.Windows.Forms.Label();
            this.label_AircraftID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // aircraft_comboBox
            // 
            this.aircraft_comboBox.FormattingEnabled = true;
            this.aircraft_comboBox.Location = new System.Drawing.Point(331, 276);
            this.aircraft_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aircraft_comboBox.Name = "aircraft_comboBox";
            this.aircraft_comboBox.Size = new System.Drawing.Size(248, 24);
            this.aircraft_comboBox.TabIndex = 7;
            this.aircraft_comboBox.SelectedIndexChanged += new System.EventHandler(this.airline_comboBox_SelectedIndexChanged);
            // 
            // flightid_comboBox
            // 
            this.flightid_comboBox.FormattingEnabled = true;
            this.flightid_comboBox.Items.AddRange(new object[] {
            "SELECT AIRCRAFT ID FIRST"});
            this.flightid_comboBox.Location = new System.Drawing.Point(331, 323);
            this.flightid_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.flightid_comboBox.Name = "flightid_comboBox";
            this.flightid_comboBox.Size = new System.Drawing.Size(248, 24);
            this.flightid_comboBox.TabIndex = 9;
            this.flightid_comboBox.SelectedIndexChanged += new System.EventHandler(this.flightid_comboBox_SelectedIndexChanged);
            // 
            // showRevenue
            // 
            this.showRevenue.AutoSize = true;
            this.showRevenue.BackColor = System.Drawing.Color.Transparent;
            this.showRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRevenue.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.showRevenue.Location = new System.Drawing.Point(325, 369);
            this.showRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showRevenue.Name = "showRevenue";
            this.showRevenue.Size = new System.Drawing.Size(29, 31);
            this.showRevenue.TabIndex = 10;
            this.showRevenue.Text = "0";
            this.showRevenue.Click += new System.EventHandler(this.revenueGeneratedOut_label_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(188, 513);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // bookingGrid
            // 
            this.bookingGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.bookingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGrid.Location = new System.Drawing.Point(27, 80);
            this.bookingGrid.Name = "bookingGrid";
            this.bookingGrid.RowHeadersWidth = 51;
            this.bookingGrid.RowTemplate.Height = 24;
            this.bookingGrid.Size = new System.Drawing.Size(552, 186);
            this.bookingGrid.TabIndex = 82;
            // 
            // button_generatePDF
            // 
            this.button_generatePDF.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_generatePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_generatePDF.BackgroundImage")));
            this.button_generatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generatePDF.Location = new System.Drawing.Point(188, 464);
            this.button_generatePDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_generatePDF.Name = "button_generatePDF";
            this.button_generatePDF.Size = new System.Drawing.Size(227, 48);
            this.button_generatePDF.TabIndex = 83;
            this.button_generatePDF.Text = "PDF";
            this.button_generatePDF.UseVisualStyleBackColor = false;
            this.button_generatePDF.Click += new System.EventHandler(this.button_generatePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 48);
            this.label1.TabIndex = 84;
            this.label1.Text = "REVENUE";
            // 
            // showStatus
            // 
            this.showStatus.AutoSize = true;
            this.showStatus.BackColor = System.Drawing.Color.Transparent;
            this.showStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStatus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.showStatus.Location = new System.Drawing.Point(325, 415);
            this.showStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showStatus.Name = "showStatus";
            this.showStatus.Size = new System.Drawing.Size(29, 31);
            this.showStatus.TabIndex = 85;
            this.showStatus.Text = "0";
            // 
            // label_FlightStatus
            // 
            this.label_FlightStatus.AutoSize = true;
            this.label_FlightStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_FlightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FlightStatus.Location = new System.Drawing.Point(23, 422);
            this.label_FlightStatus.Name = "label_FlightStatus";
            this.label_FlightStatus.Size = new System.Drawing.Size(110, 22);
            this.label_FlightStatus.TabIndex = 89;
            this.label_FlightStatus.Text = "Flight Status";
            // 
            // label_revenueGenerated
            // 
            this.label_revenueGenerated.AutoSize = true;
            this.label_revenueGenerated.BackColor = System.Drawing.Color.Transparent;
            this.label_revenueGenerated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_revenueGenerated.Location = new System.Drawing.Point(23, 376);
            this.label_revenueGenerated.Name = "label_revenueGenerated";
            this.label_revenueGenerated.Size = new System.Drawing.Size(172, 22);
            this.label_revenueGenerated.TabIndex = 88;
            this.label_revenueGenerated.Text = "Revenue Generated";
            // 
            // label_FlightID
            // 
            this.label_FlightID.AutoSize = true;
            this.label_FlightID.BackColor = System.Drawing.Color.Transparent;
            this.label_FlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FlightID.Location = new System.Drawing.Point(23, 325);
            this.label_FlightID.Name = "label_FlightID";
            this.label_FlightID.Size = new System.Drawing.Size(76, 22);
            this.label_FlightID.TabIndex = 87;
            this.label_FlightID.Text = "Flight ID";
            // 
            // label_AircraftID
            // 
            this.label_AircraftID.AutoSize = true;
            this.label_AircraftID.BackColor = System.Drawing.Color.Transparent;
            this.label_AircraftID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AircraftID.Location = new System.Drawing.Point(23, 278);
            this.label_AircraftID.Name = "label_AircraftID";
            this.label_AircraftID.Size = new System.Drawing.Size(89, 22);
            this.label_AircraftID.TabIndex = 86;
            this.label_AircraftID.Text = "Aircraft ID";
            // 
            // AS_revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_FlightStatus);
            this.Controls.Add(this.label_revenueGenerated);
            this.Controls.Add(this.label_FlightID);
            this.Controls.Add(this.label_AircraftID);
            this.Controls.Add(this.showStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_generatePDF);
            this.Controls.Add(this.bookingGrid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.showRevenue);
            this.Controls.Add(this.flightid_comboBox);
            this.Controls.Add(this.aircraft_comboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AS_revenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_revenue_FormClosing);
            this.Load += new System.EventHandler(this.AS_revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox aircraft_comboBox;
        private System.Windows.Forms.ComboBox flightid_comboBox;
        private System.Windows.Forms.Label showRevenue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView bookingGrid;
        private System.Windows.Forms.Button button_generatePDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label showStatus;
        private System.Windows.Forms.Label label_FlightStatus;
        private System.Windows.Forms.Label label_revenueGenerated;
        private System.Windows.Forms.Label label_FlightID;
        private System.Windows.Forms.Label label_AircraftID;
    }
}