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
            this.yes_radioBtn = new System.Windows.Forms.RadioButton();
            this.no_radiobtn = new System.Windows.Forms.RadioButton();
            this.comboBox_DEPARTURE = new System.Windows.Forms.ComboBox();
            this.comboBox_Arrival = new System.Windows.Forms.ComboBox();
            this.aircraftID_combobox = new System.Windows.Forms.ComboBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes_radioBtn
            // 
            this.yes_radioBtn.AutoSize = true;
            this.yes_radioBtn.BackColor = System.Drawing.Color.Transparent;
            this.yes_radioBtn.Location = new System.Drawing.Point(342, 264);
            this.yes_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.yes_radioBtn.Name = "yes_radioBtn";
            this.yes_radioBtn.Size = new System.Drawing.Size(37, 20);
            this.yes_radioBtn.TabIndex = 16;
            this.yes_radioBtn.TabStop = true;
            this.yes_radioBtn.Text = "Y";
            this.yes_radioBtn.UseVisualStyleBackColor = false;
            this.yes_radioBtn.CheckedChanged += new System.EventHandler(this.yes_radioBtn_CheckedChanged);
            // 
            // no_radiobtn
            // 
            this.no_radiobtn.AutoSize = true;
            this.no_radiobtn.BackColor = System.Drawing.Color.Transparent;
            this.no_radiobtn.Location = new System.Drawing.Point(393, 263);
            this.no_radiobtn.Margin = new System.Windows.Forms.Padding(4);
            this.no_radiobtn.Name = "no_radiobtn";
            this.no_radiobtn.Size = new System.Drawing.Size(38, 20);
            this.no_radiobtn.TabIndex = 17;
            this.no_radiobtn.TabStop = true;
            this.no_radiobtn.Text = "N";
            this.no_radiobtn.UseVisualStyleBackColor = false;
            this.no_radiobtn.CheckedChanged += new System.EventHandler(this.no_radiobtn_CheckedChanged);
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
            this.comboBox_DEPARTURE.Location = new System.Drawing.Point(342, 74);
            this.comboBox_DEPARTURE.Name = "comboBox_DEPARTURE";
            this.comboBox_DEPARTURE.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DEPARTURE.TabIndex = 20;
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
            this.comboBox_Arrival.Location = new System.Drawing.Point(342, 120);
            this.comboBox_Arrival.Name = "comboBox_Arrival";
            this.comboBox_Arrival.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Arrival.TabIndex = 21;
            // 
            // aircraftID_combobox
            // 
            this.aircraftID_combobox.FormattingEnabled = true;
            this.aircraftID_combobox.Location = new System.Drawing.Point(342, 395);
            this.aircraftID_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.aircraftID_combobox.Name = "aircraftID_combobox";
            this.aircraftID_combobox.Size = new System.Drawing.Size(102, 24);
            this.aircraftID_combobox.TabIndex = 8;
            this.aircraftID_combobox.Text = "Aircraft_ID";
            this.aircraftID_combobox.SelectedIndexChanged += new System.EventHandler(this.aircraftID_combobox_SelectedIndexChanged);
            // 
            // label_FID
            // 
            this.label_FID.AutoSize = true;
            this.label_FID.BackColor = System.Drawing.Color.Transparent;
            this.label_FID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FID.Location = new System.Drawing.Point(98, 122);
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
            this.name_label.Location = new System.Drawing.Point(98, 78);
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
            this.label1.Location = new System.Drawing.Point(98, 171);
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
            this.label_arrival.Location = new System.Drawing.Point(98, 217);
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
            this.label_flightStatus.Location = new System.Drawing.Point(98, 261);
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
            this.label_flightHours.Location = new System.Drawing.Point(98, 310);
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
            this.label2.Location = new System.Drawing.Point(98, 357);
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
            this.label3.Location = new System.Drawing.Point(98, 397);
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
            this.btn_back.Location = new System.Drawing.Point(175, 520);
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
            this.button_Assign.Text = "Enter";
            this.button_Assign.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 87;
            this.label4.Text = "displayHours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 88;
            this.label5.Text = "displayCost";
            // 
            // AS_ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Controls.Add(this.no_radiobtn);
            this.Controls.Add(this.yes_radioBtn);
            this.Controls.Add(this.aircraftID_combobox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AS_ScheduleFlight";
            this.Text = "AS_ScheduleFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_ScheduleFlight_FormClosing);
            this.Load += new System.EventHandler(this.AS_ScheduleFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton yes_radioBtn;
        private System.Windows.Forms.RadioButton no_radiobtn;
        private System.Windows.Forms.ComboBox comboBox_DEPARTURE;
        private System.Windows.Forms.ComboBox comboBox_Arrival;
        private System.Windows.Forms.ComboBox aircraftID_combobox;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}