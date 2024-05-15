namespace DATABASE_PROJECT
{
    partial class AS_aircraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_aircraft));
            this.CPH_label = new System.Windows.Forms.Label();
            this.airline_label = new System.Windows.Forms.Label();
            this.aircraftID_label = new System.Windows.Forms.Label();
            this.cph_textBox = new System.Windows.Forms.TextBox();
            this.idShow_label = new System.Windows.Forms.Label();
            this.totalcapacity_textBox = new System.Windows.Forms.TextBox();
            this.totalCapacity_label = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button_Assign = new System.Windows.Forms.Button();
            this.comboBox_airline = new System.Windows.Forms.ComboBox();
            this.AIRCRAFT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPH_label
            // 
            this.CPH_label.AutoSize = true;
            this.CPH_label.BackColor = System.Drawing.Color.Transparent;
            this.CPH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPH_label.Location = new System.Drawing.Point(25, 109);
            this.CPH_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CPH_label.Name = "CPH_label";
            this.CPH_label.Size = new System.Drawing.Size(261, 31);
            this.CPH_label.TabIndex = 1;
            this.CPH_label.Text = "Cost per hour (CPH)";
            // 
            // airline_label
            // 
            this.airline_label.AutoSize = true;
            this.airline_label.BackColor = System.Drawing.Color.Transparent;
            this.airline_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airline_label.Location = new System.Drawing.Point(25, 252);
            this.airline_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.airline_label.Name = "airline_label";
            this.airline_label.Size = new System.Drawing.Size(89, 31);
            this.airline_label.TabIndex = 4;
            this.airline_label.Text = "Airline";
            // 
            // aircraftID_label
            // 
            this.aircraftID_label.AutoSize = true;
            this.aircraftID_label.BackColor = System.Drawing.Color.Transparent;
            this.aircraftID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftID_label.Location = new System.Drawing.Point(25, 317);
            this.aircraftID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aircraftID_label.Name = "aircraftID_label";
            this.aircraftID_label.Size = new System.Drawing.Size(136, 31);
            this.aircraftID_label.TabIndex = 5;
            this.aircraftID_label.Text = "Aircraft ID";
            // 
            // cph_textBox
            // 
            this.cph_textBox.Location = new System.Drawing.Point(314, 118);
            this.cph_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.cph_textBox.Name = "cph_textBox";
            this.cph_textBox.Size = new System.Drawing.Size(277, 22);
            this.cph_textBox.TabIndex = 8;
            this.cph_textBox.TextChanged += new System.EventHandler(this.cph_textBox_TextChanged);
            // 
            // idShow_label
            // 
            this.idShow_label.AutoSize = true;
            this.idShow_label.BackColor = System.Drawing.Color.Transparent;
            this.idShow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShow_label.Location = new System.Drawing.Point(307, 320);
            this.idShow_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idShow_label.Name = "idShow_label";
            this.idShow_label.Size = new System.Drawing.Size(50, 31);
            this.idShow_label.TabIndex = 11;
            this.idShow_label.Text = "ID:";
            this.idShow_label.Click += new System.EventHandler(this.idShow_label_Click);
            // 
            // totalcapacity_textBox
            // 
            this.totalcapacity_textBox.Location = new System.Drawing.Point(314, 188);
            this.totalcapacity_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalcapacity_textBox.Name = "totalcapacity_textBox";
            this.totalcapacity_textBox.Size = new System.Drawing.Size(277, 22);
            this.totalcapacity_textBox.TabIndex = 9;
            this.totalcapacity_textBox.TextChanged += new System.EventHandler(this.totalcapacity_textBox_TextChanged);
            // 
            // totalCapacity_label
            // 
            this.totalCapacity_label.AutoSize = true;
            this.totalCapacity_label.BackColor = System.Drawing.Color.Transparent;
            this.totalCapacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCapacity_label.Location = new System.Drawing.Point(25, 179);
            this.totalCapacity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCapacity_label.Name = "totalCapacity_label";
            this.totalCapacity_label.Size = new System.Drawing.Size(196, 31);
            this.totalCapacity_label.TabIndex = 3;
            this.totalCapacity_label.Text = "Total Capacity ";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(186, 469);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button_Assign
            // 
            this.button_Assign.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_Assign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Assign.BackgroundImage")));
            this.button_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Assign.Location = new System.Drawing.Point(186, 415);
            this.button_Assign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Assign.Name = "button_Assign";
            this.button_Assign.Size = new System.Drawing.Size(227, 48);
            this.button_Assign.TabIndex = 79;
            this.button_Assign.Text = "Enter";
            this.button_Assign.UseVisualStyleBackColor = false;
            this.button_Assign.Click += new System.EventHandler(this.button_Assign_Click);
            // 
            // comboBox_airline
            // 
            this.comboBox_airline.FormattingEnabled = true;
            this.comboBox_airline.Items.AddRange(new object[] {
            "PIA",
            "TURKISH AIRLINES",
            "QATAR AIRWAYS",
            "LOONA AIRWAYS",
            "EMIRATES",
            "ETIHAD"});
            this.comboBox_airline.Location = new System.Drawing.Point(313, 261);
            this.comboBox_airline.Name = "comboBox_airline";
            this.comboBox_airline.Size = new System.Drawing.Size(225, 24);
            this.comboBox_airline.TabIndex = 81;
            // 
            // AIRCRAFT
            // 
            this.AIRCRAFT.AutoSize = true;
            this.AIRCRAFT.BackColor = System.Drawing.Color.Transparent;
            this.AIRCRAFT.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIRCRAFT.Location = new System.Drawing.Point(166, 28);
            this.AIRCRAFT.Name = "AIRCRAFT";
            this.AIRCRAFT.Size = new System.Drawing.Size(298, 48);
            this.AIRCRAFT.TabIndex = 82;
            this.AIRCRAFT.Text = "SkyConnect ";
            // 
            // AS_aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(614, 554);
            this.Controls.Add(this.AIRCRAFT);
            this.Controls.Add(this.comboBox_airline);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button_Assign);
            this.Controls.Add(this.idShow_label);
            this.Controls.Add(this.totalcapacity_textBox);
            this.Controls.Add(this.cph_textBox);
            this.Controls.Add(this.aircraftID_label);
            this.Controls.Add(this.airline_label);
            this.Controls.Add(this.totalCapacity_label);
            this.Controls.Add(this.CPH_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AS_aircraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Aircraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_aircraft_FormClosing);
            this.Load += new System.EventHandler(this.AS_aircraft_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CPH_label;
        private System.Windows.Forms.Label airline_label;
        private System.Windows.Forms.Label aircraftID_label;
        private System.Windows.Forms.TextBox cph_textBox;
        private System.Windows.Forms.Label idShow_label;
        private System.Windows.Forms.TextBox totalcapacity_textBox;
        private System.Windows.Forms.Label totalCapacity_label;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button_Assign;
        private System.Windows.Forms.ComboBox comboBox_airline;
        private System.Windows.Forms.Label AIRCRAFT;
    }
}