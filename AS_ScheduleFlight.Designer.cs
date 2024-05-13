namespace DATABASE_PROJECT
{
    partial class AS_ScheduleFlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_ScheduleFlight));
            this.comboBox_DEPARTURE = new System.Windows.Forms.ComboBox();
            this.comboBox_Arrival = new System.Windows.Forms.ComboBox();
            this.combo_AircraftId = new System.Windows.Forms.ComboBox();
            this.label_FID = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_arrival = new System.Windows.Forms.Label();
            this.label_flightStatus = new System.Windows.Forms.Label();
            this.label_flightHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button_Assign = new System.Windows.Forms.Button();
            this.displayHours = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.ncARRtime = new System.Windows.Forms.NumericUpDown();
            this.ncDEPtime = new System.Windows.Forms.NumericUpDown();
            this.dateDeparture = new System.Windows.Forms.DateTimePicker();
            this.dateArrival = new System.Windows.Forms.DateTimePicker();
            this.comboBox_flightStatus = new System.Windows.Forms.ComboBox();
            this.label_airline = new System.Windows.Forms.Label();
            this.comboBox_Airline = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ncARRtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncDEPtime)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_DEPARTURE
            // 
            this.comboBox_DEPARTURE.FormattingEnabled = true;
            this.comboBox_DEPARTURE.Items.AddRange(new object[] {
            "Ankara",
            "Istanbul",
            "Lahore",
            "Faisalabad",
            "Karachi",
            "Loonay Wala",
            "Islamabad",
            "Dubai",
            "New York",
            "London",
            "Madina",
            "Jeddah",
            "Doha"});
            this.comboBox_DEPARTURE.Location = new System.Drawing.Point(342, 64);
            this.comboBox_DEPARTURE.Name = "comboBox_DEPARTURE";
            this.comboBox_DEPARTURE.Size = new System.Drawing.Size(147, 24);
            this.comboBox_DEPARTURE.TabIndex = 20;
            this.comboBox_DEPARTURE.SelectedIndexChanged += new System.EventHandler(this.comboBox_DEPARTURE_SelectedIndexChanged);
            // 
            // comboBox_Arrival
            // 
            this.comboBox_Arrival.FormattingEnabled = true;
            this.comboBox_Arrival.Items.AddRange(new object[] {
            "Ankara",
            "Istanbul",
            "Lahore",
            "Faisalabad",
            "Karachi",
            "Loonay Wala",
            "Islamabad",
            "Dubai",
            "New York",
            "London",
            "Madina",
            "Jeddah",
            "Doha"});
            this.comboBox_Arrival.Location = new System.Drawing.Point(342, 110);
            this.comboBox_Arrival.Name = "comboBox_Arrival";
            this.comboBox_Arrival.Size = new System.Drawing.Size(147, 24);
            this.comboBox_Arrival.TabIndex = 21;
            this.comboBox_Arrival.SelectedIndexChanged += new System.EventHandler(this.comboBox_Arrival_SelectedIndexChanged);
            // 
            // combo_AircraftId
            // 
            this.combo_AircraftId.FormattingEnabled = true;
            this.combo_AircraftId.Location = new System.Drawing.Point(342, 430);
            this.combo_AircraftId.Margin = new System.Windows.Forms.Padding(4);
            this.combo_AircraftId.Name = "combo_AircraftId";
            this.combo_AircraftId.Size = new System.Drawing.Size(147, 24);
            this.combo_AircraftId.TabIndex = 8;
            this.combo_AircraftId.Text = "Aircraft_ID";
            this.combo_AircraftId.SelectedIndexChanged += new System.EventHandler(this.aircraftID_combobox_SelectedIndexChanged);
            // 
            // label_FID
            // 
            this.label_FID.AutoSize = true;
            this.label_FID.BackColor = System.Drawing.Color.Transparent;
            this.label_FID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FID.Location = new System.Drawing.Point(98, 112);
            this.label_FID.Name = "label_FID";
            this.label_FID.Size = new System.Drawing.Size(61, 22);
            this.label_FID.TabIndex = 78;
            this.label_FID.Text = "Arrival";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(98, 68);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(90, 22);
            this.name_label.TabIndex = 77;
            this.name_label.Text = "Departure";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "Departure Date/Time";
            // 
            // label_arrival
            // 
            this.label_arrival.AutoSize = true;
            this.label_arrival.BackColor = System.Drawing.Color.Transparent;
            this.label_arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_arrival.Location = new System.Drawing.Point(98, 207);
            this.label_arrival.Name = "label_arrival";
            this.label_arrival.Size = new System.Drawing.Size(149, 22);
            this.label_arrival.TabIndex = 80;
            this.label_arrival.Text = "Arrival Date/Time";
            // 
            // label_flightStatus
            // 
            this.label_flightStatus.AutoSize = true;
            this.label_flightStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_flightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flightStatus.Location = new System.Drawing.Point(98, 251);
            this.label_flightStatus.Name = "label_flightStatus";
            this.label_flightStatus.Size = new System.Drawing.Size(110, 22);
            this.label_flightStatus.TabIndex = 81;
            this.label_flightStatus.Text = "Flight Status";
            // 
            // label_flightHours
            // 
            this.label_flightHours.AutoSize = true;
            this.label_flightHours.BackColor = System.Drawing.Color.Transparent;
            this.label_flightHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flightHours.Location = new System.Drawing.Point(98, 300);
            this.label_flightHours.Name = "label_flightHours";
            this.label_flightHours.Size = new System.Drawing.Size(107, 22);
            this.label_flightHours.TabIndex = 82;
            this.label_flightHours.Text = "Flight Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Ticket Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Select Aircraft";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(175, 517);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 86;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button_Assign
            // 
            this.button_Assign.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_Assign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Assign.BackgroundImage")));
            this.button_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Assign.Location = new System.Drawing.Point(175, 466);
            this.button_Assign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Assign.Name = "button_Assign";
            this.button_Assign.Size = new System.Drawing.Size(227, 48);
            this.button_Assign.TabIndex = 85;
            this.button_Assign.Text = "Schedule";
            this.button_Assign.UseVisualStyleBackColor = false;
            this.button_Assign.Click += new System.EventHandler(this.button_Assign_Click);
            // 
            // displayHours
            // 
            this.displayHours.AutoSize = true;
            this.displayHours.BackColor = System.Drawing.Color.Transparent;
            this.displayHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayHours.Location = new System.Drawing.Point(338, 300);
            this.displayHours.Name = "displayHours";
            this.displayHours.Size = new System.Drawing.Size(114, 22);
            this.displayHours.TabIndex = 87;
            this.displayHours.Text = "displayHours";
            this.displayHours.Click += new System.EventHandler(this.displayHours_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(338, 347);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(103, 22);
            this.labelCost.TabIndex = 88;
            this.labelCost.Text = "displayCost";
            this.labelCost.Click += new System.EventHandler(this.labelCost_Click);
            // 
            // ncARRtime
            // 
            this.ncARRtime.Location = new System.Drawing.Point(495, 207);
            this.ncARRtime.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ncARRtime.Name = "ncARRtime";
            this.ncARRtime.Size = new System.Drawing.Size(61, 22);
            this.ncARRtime.TabIndex = 90;
            this.ncARRtime.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ncARRtime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ncDEPtime
            // 
            this.ncDEPtime.Location = new System.Drawing.Point(495, 161);
            this.ncDEPtime.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ncDEPtime.Name = "ncDEPtime";
            this.ncDEPtime.Size = new System.Drawing.Size(61, 22);
            this.ncDEPtime.TabIndex = 91;
            this.ncDEPtime.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ncDEPtime.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // dateDeparture
            // 
            this.dateDeparture.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateDeparture.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateDeparture.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateDeparture.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateDeparture.Location = new System.Drawing.Point(341, 161);
            this.dateDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDeparture.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateDeparture.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateDeparture.Name = "dateDeparture";
            this.dateDeparture.Size = new System.Drawing.Size(148, 22);
            this.dateDeparture.TabIndex = 92;
            this.dateDeparture.Value = new System.DateTime(2024, 5, 13, 0, 0, 0, 0);
            this.dateDeparture.ValueChanged += new System.EventHandler(this.dateTimeDeparture_ValueChanged);
            // 
            // dateArrival
            // 
            this.dateArrival.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dateArrival.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateArrival.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateArrival.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateArrival.Location = new System.Drawing.Point(341, 207);
            this.dateArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateArrival.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateArrival.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateArrival.Name = "dateArrival";
            this.dateArrival.Size = new System.Drawing.Size(148, 22);
            this.dateArrival.TabIndex = 93;
            this.dateArrival.Value = new System.DateTime(2024, 5, 13, 0, 0, 0, 0);
            // 
            // comboBox_flightStatus
            // 
            this.comboBox_flightStatus.FormattingEnabled = true;
            this.comboBox_flightStatus.Items.AddRange(new object[] {
            "DELAYED",
            "ON TIME"});
            this.comboBox_flightStatus.Location = new System.Drawing.Point(342, 253);
            this.comboBox_flightStatus.Name = "comboBox_flightStatus";
            this.comboBox_flightStatus.Size = new System.Drawing.Size(147, 24);
            this.comboBox_flightStatus.TabIndex = 94;
            this.comboBox_flightStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_flightStatus_SelectedIndexChanged);
            // 
            // label_airline
            // 
            this.label_airline.AutoSize = true;
            this.label_airline.BackColor = System.Drawing.Color.Transparent;
            this.label_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_airline.Location = new System.Drawing.Point(98, 387);
            this.label_airline.Name = "label_airline";
            this.label_airline.Size = new System.Drawing.Size(115, 22);
            this.label_airline.TabIndex = 96;
            this.label_airline.Text = "Select Airline";
            // 
            // comboBox_Airline
            // 
            this.comboBox_Airline.FormattingEnabled = true;
            this.comboBox_Airline.Location = new System.Drawing.Point(342, 385);
            this.comboBox_Airline.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Airline.Name = "comboBox_Airline";
            this.comboBox_Airline.Size = new System.Drawing.Size(147, 24);
            this.comboBox_Airline.TabIndex = 95;
            this.comboBox_Airline.Text = "Airline";
            this.comboBox_Airline.SelectedIndexChanged += new System.EventHandler(this.comboBox_Airline_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(435, 48);
            this.label4.TabIndex = 97;
            this.label4.Text = "SCHEDULE FLIGHT";
            // 
            // AS_ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_airline);
            this.Controls.Add(this.comboBox_Airline);
            this.Controls.Add(this.comboBox_flightStatus);
            this.Controls.Add(this.dateArrival);
            this.Controls.Add(this.dateDeparture);
            this.Controls.Add(this.ncDEPtime);
            this.Controls.Add(this.ncARRtime);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.displayHours);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button_Assign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_flightHours);
            this.Controls.Add(this.label_flightStatus);
            this.Controls.Add(this.label_arrival);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_FID);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.comboBox_Arrival);
            this.Controls.Add(this.comboBox_DEPARTURE);
            this.Controls.Add(this.combo_AircraftId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AS_ScheduleFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AS_ScheduleFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_ScheduleFlight_FormClosing);
            this.Load += new System.EventHandler(this.AS_ScheduleFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ncARRtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncDEPtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_DEPARTURE;
        private System.Windows.Forms.ComboBox comboBox_Arrival;
        private System.Windows.Forms.ComboBox combo_AircraftId;
        private System.Windows.Forms.Label label_FID;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_arrival;
        private System.Windows.Forms.Label label_flightStatus;
        private System.Windows.Forms.Label label_flightHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button_Assign;
        private System.Windows.Forms.Label displayHours;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.NumericUpDown ncARRtime;
        private System.Windows.Forms.NumericUpDown ncDEPtime;
        private System.Windows.Forms.DateTimePicker dateDeparture;
        private System.Windows.Forms.DateTimePicker dateArrival;
        private System.Windows.Forms.ComboBox comboBox_flightStatus;
        private System.Windows.Forms.Label label_airline;
        private System.Windows.Forms.ComboBox comboBox_Airline;
        private System.Windows.Forms.Label label4;
    }
}