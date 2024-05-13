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
            this.departure_label = new System.Windows.Forms.Label();
            this.arrival_label = new System.Windows.Forms.Label();
            this.arrivalTime_label = new System.Windows.Forms.Label();
            this.departureTime_label = new System.Windows.Forms.Label();
            this.flightHours_label = new System.Windows.Forms.Label();
            this.flightStatus_label = new System.Windows.Forms.Label();
            this.revenue_label = new System.Windows.Forms.Label();
            this.airline_combobox = new System.Windows.Forms.ComboBox();
            this.aircraftID_combobox = new System.Windows.Forms.ComboBox();
            this.flightID_label = new System.Windows.Forms.Label();
            this.departure_textBox = new System.Windows.Forms.TextBox();
            this.arrival_textBox = new System.Windows.Forms.TextBox();
            this.arrivalTime_textBox = new System.Windows.Forms.TextBox();
            this.departureTime_textBox = new System.Windows.Forms.TextBox();
            this.flightHour_textBox = new System.Windows.Forms.TextBox();
            this.revenue_textBox = new System.Windows.Forms.TextBox();
            this.yes_radioBtn = new System.Windows.Forms.RadioButton();
            this.no_radiobtn = new System.Windows.Forms.RadioButton();
            this.flightid_textbox = new System.Windows.Forms.TextBox();
            this.flightID_get_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // departure_label
            // 
            this.departure_label.AutoSize = true;
            this.departure_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_label.Location = new System.Drawing.Point(41, 69);
            this.departure_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departure_label.Name = "departure_label";
            this.departure_label.Size = new System.Drawing.Size(135, 31);
            this.departure_label.TabIndex = 0;
            this.departure_label.Text = "Departure";
            // 
            // arrival_label
            // 
            this.arrival_label.AutoSize = true;
            this.arrival_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrival_label.Location = new System.Drawing.Point(41, 140);
            this.arrival_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrival_label.Name = "arrival_label";
            this.arrival_label.Size = new System.Drawing.Size(91, 31);
            this.arrival_label.TabIndex = 1;
            this.arrival_label.Text = "Arrival";
            // 
            // arrivalTime_label
            // 
            this.arrivalTime_label.AutoSize = true;
            this.arrivalTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTime_label.Location = new System.Drawing.Point(41, 221);
            this.arrivalTime_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrivalTime_label.Name = "arrivalTime_label";
            this.arrivalTime_label.Size = new System.Drawing.Size(149, 31);
            this.arrivalTime_label.TabIndex = 2;
            this.arrivalTime_label.Text = "Arrival time";
            // 
            // departureTime_label
            // 
            this.departureTime_label.AutoSize = true;
            this.departureTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTime_label.Location = new System.Drawing.Point(41, 298);
            this.departureTime_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departureTime_label.Name = "departureTime_label";
            this.departureTime_label.Size = new System.Drawing.Size(202, 31);
            this.departureTime_label.TabIndex = 3;
            this.departureTime_label.Text = "Departure Time";
            this.departureTime_label.Click += new System.EventHandler(this.departureTime_label_Click);
            // 
            // flightHours_label
            // 
            this.flightHours_label.AutoSize = true;
            this.flightHours_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightHours_label.Location = new System.Drawing.Point(41, 374);
            this.flightHours_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flightHours_label.Name = "flightHours_label";
            this.flightHours_label.Size = new System.Drawing.Size(161, 31);
            this.flightHours_label.TabIndex = 4;
            this.flightHours_label.Text = "Flight Hours";
            // 
            // flightStatus_label
            // 
            this.flightStatus_label.AutoSize = true;
            this.flightStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightStatus_label.Location = new System.Drawing.Point(41, 450);
            this.flightStatus_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flightStatus_label.Name = "flightStatus_label";
            this.flightStatus_label.Size = new System.Drawing.Size(166, 31);
            this.flightStatus_label.TabIndex = 5;
            this.flightStatus_label.Text = "Flight Status";
            this.flightStatus_label.Click += new System.EventHandler(this.flightStatus_label_Click);
            // 
            // revenue_label
            // 
            this.revenue_label.AutoSize = true;
            this.revenue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue_label.Location = new System.Drawing.Point(41, 524);
            this.revenue_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenue_label.Name = "revenue_label";
            this.revenue_label.Size = new System.Drawing.Size(123, 31);
            this.revenue_label.TabIndex = 6;
            this.revenue_label.Text = "Revenue";
            // 
            // airline_combobox
            // 
            this.airline_combobox.FormattingEnabled = true;
            this.airline_combobox.Location = new System.Drawing.Point(623, 76);
            this.airline_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.airline_combobox.Name = "airline_combobox";
            this.airline_combobox.Size = new System.Drawing.Size(225, 24);
            this.airline_combobox.TabIndex = 7;
            this.airline_combobox.Text = "Airline";
            this.airline_combobox.SelectedIndexChanged += new System.EventHandler(this.airline_combobox_SelectedIndexChanged);
            // 
            // aircraftID_combobox
            // 
            this.aircraftID_combobox.FormattingEnabled = true;
            this.aircraftID_combobox.Location = new System.Drawing.Point(623, 298);
            this.aircraftID_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aircraftID_combobox.Name = "aircraftID_combobox";
            this.aircraftID_combobox.Size = new System.Drawing.Size(225, 24);
            this.aircraftID_combobox.TabIndex = 8;
            this.aircraftID_combobox.Text = "Aircraft_ID";
            this.aircraftID_combobox.SelectedIndexChanged += new System.EventHandler(this.aircraftID_combobox_SelectedIndexChanged);
            // 
            // flightID_label
            // 
            this.flightID_label.AutoSize = true;
            this.flightID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightID_label.Location = new System.Drawing.Point(617, 459);
            this.flightID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flightID_label.Name = "flightID_label";
            this.flightID_label.Size = new System.Drawing.Size(124, 31);
            this.flightID_label.TabIndex = 9;
            this.flightID_label.Text = "Flight_ID";
            // 
            // departure_textBox
            // 
            this.departure_textBox.Location = new System.Drawing.Point(287, 75);
            this.departure_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departure_textBox.Name = "departure_textBox";
            this.departure_textBox.Size = new System.Drawing.Size(197, 22);
            this.departure_textBox.TabIndex = 10;
            this.departure_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // arrival_textBox
            // 
            this.arrival_textBox.Location = new System.Drawing.Point(287, 146);
            this.arrival_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrival_textBox.Name = "arrival_textBox";
            this.arrival_textBox.Size = new System.Drawing.Size(197, 22);
            this.arrival_textBox.TabIndex = 11;
            this.arrival_textBox.TextChanged += new System.EventHandler(this.arrival_textBox_TextChanged);
            // 
            // arrivalTime_textBox
            // 
            this.arrivalTime_textBox.Location = new System.Drawing.Point(287, 228);
            this.arrivalTime_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrivalTime_textBox.Name = "arrivalTime_textBox";
            this.arrivalTime_textBox.Size = new System.Drawing.Size(197, 22);
            this.arrivalTime_textBox.TabIndex = 12;
            this.arrivalTime_textBox.TextChanged += new System.EventHandler(this.arrivalTime_textBox_TextChanged);
            // 
            // departureTime_textBox
            // 
            this.departureTime_textBox.Location = new System.Drawing.Point(287, 304);
            this.departureTime_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departureTime_textBox.Name = "departureTime_textBox";
            this.departureTime_textBox.Size = new System.Drawing.Size(197, 22);
            this.departureTime_textBox.TabIndex = 13;
            this.departureTime_textBox.TextChanged += new System.EventHandler(this.departureTime_textBox_TextChanged);
            // 
            // flightHour_textBox
            // 
            this.flightHour_textBox.Location = new System.Drawing.Point(287, 380);
            this.flightHour_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightHour_textBox.Name = "flightHour_textBox";
            this.flightHour_textBox.Size = new System.Drawing.Size(197, 22);
            this.flightHour_textBox.TabIndex = 14;
            this.flightHour_textBox.TextChanged += new System.EventHandler(this.flightHour_textBox_TextChanged);
            // 
            // revenue_textBox
            // 
            this.revenue_textBox.Location = new System.Drawing.Point(287, 530);
            this.revenue_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.revenue_textBox.Name = "revenue_textBox";
            this.revenue_textBox.Size = new System.Drawing.Size(197, 22);
            this.revenue_textBox.TabIndex = 15;
            this.revenue_textBox.TextChanged += new System.EventHandler(this.revenue_textBox_TextChanged);
            // 
            // yes_radioBtn
            // 
            this.yes_radioBtn.AutoSize = true;
            this.yes_radioBtn.Location = new System.Drawing.Point(327, 460);
            this.yes_radioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yes_radioBtn.Name = "yes_radioBtn";
            this.yes_radioBtn.Size = new System.Drawing.Size(37, 20);
            this.yes_radioBtn.TabIndex = 16;
            this.yes_radioBtn.TabStop = true;
            this.yes_radioBtn.Text = "Y";
            this.yes_radioBtn.UseVisualStyleBackColor = true;
            this.yes_radioBtn.CheckedChanged += new System.EventHandler(this.yes_radioBtn_CheckedChanged);
            // 
            // no_radiobtn
            // 
            this.no_radiobtn.AutoSize = true;
            this.no_radiobtn.Location = new System.Drawing.Point(378, 459);
            this.no_radiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.no_radiobtn.Name = "no_radiobtn";
            this.no_radiobtn.Size = new System.Drawing.Size(38, 20);
            this.no_radiobtn.TabIndex = 17;
            this.no_radiobtn.TabStop = true;
            this.no_radiobtn.Text = "N";
            this.no_radiobtn.UseVisualStyleBackColor = true;
            this.no_radiobtn.CheckedChanged += new System.EventHandler(this.no_radiobtn_CheckedChanged);
            // 
            // flightid_textbox
            // 
            this.flightid_textbox.Location = new System.Drawing.Point(769, 465);
            this.flightid_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightid_textbox.Name = "flightid_textbox";
            this.flightid_textbox.Size = new System.Drawing.Size(197, 22);
            this.flightid_textbox.TabIndex = 18;
            this.flightid_textbox.TextChanged += new System.EventHandler(this.flightid_textbox_TextChanged);
            // 
            // flightID_get_checkbox
            // 
            this.flightID_get_checkbox.AutoSize = true;
            this.flightID_get_checkbox.Location = new System.Drawing.Point(623, 534);
            this.flightID_get_checkbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightID_get_checkbox.Name = "flightID_get_checkbox";
            this.flightID_get_checkbox.Size = new System.Drawing.Size(123, 20);
            this.flightID_get_checkbox.TabIndex = 19;
            this.flightID_get_checkbox.Text = "GET FLIGHT ID";
            this.flightID_get_checkbox.UseVisualStyleBackColor = true;
            this.flightID_get_checkbox.CheckedChanged += new System.EventHandler(this.flightID_get_checkbox_CheckedChanged);
            // 
            // AS_ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 634);
            this.Controls.Add(this.flightID_get_checkbox);
            this.Controls.Add(this.flightid_textbox);
            this.Controls.Add(this.no_radiobtn);
            this.Controls.Add(this.yes_radioBtn);
            this.Controls.Add(this.revenue_textBox);
            this.Controls.Add(this.flightHour_textBox);
            this.Controls.Add(this.departureTime_textBox);
            this.Controls.Add(this.arrivalTime_textBox);
            this.Controls.Add(this.arrival_textBox);
            this.Controls.Add(this.departure_textBox);
            this.Controls.Add(this.flightID_label);
            this.Controls.Add(this.aircraftID_combobox);
            this.Controls.Add(this.airline_combobox);
            this.Controls.Add(this.revenue_label);
            this.Controls.Add(this.flightStatus_label);
            this.Controls.Add(this.flightHours_label);
            this.Controls.Add(this.departureTime_label);
            this.Controls.Add(this.arrivalTime_label);
            this.Controls.Add(this.arrival_label);
            this.Controls.Add(this.departure_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AS_ScheduleFlight";
            this.Text = "AS_ScheduleFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_ScheduleFlight_FormClosing);
            this.Load += new System.EventHandler(this.AS_ScheduleFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label departure_label;
        private System.Windows.Forms.Label arrival_label;
        private System.Windows.Forms.Label arrivalTime_label;
        private System.Windows.Forms.Label departureTime_label;
        private System.Windows.Forms.Label flightHours_label;
        private System.Windows.Forms.Label flightStatus_label;
        private System.Windows.Forms.Label revenue_label;
        private System.Windows.Forms.ComboBox airline_combobox;
        private System.Windows.Forms.ComboBox aircraftID_combobox;
        private System.Windows.Forms.Label flightID_label;
        private System.Windows.Forms.TextBox departure_textBox;
        private System.Windows.Forms.TextBox arrival_textBox;
        private System.Windows.Forms.TextBox arrivalTime_textBox;
        private System.Windows.Forms.TextBox departureTime_textBox;
        private System.Windows.Forms.TextBox flightHour_textBox;
        private System.Windows.Forms.TextBox revenue_textBox;
        private System.Windows.Forms.RadioButton yes_radioBtn;
        private System.Windows.Forms.RadioButton no_radiobtn;
        private System.Windows.Forms.TextBox flightid_textbox;
        private System.Windows.Forms.CheckBox flightID_get_checkbox;
    }
}