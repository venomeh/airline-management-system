namespace DATABASE_PROJECT
{
    partial class User_BookSeat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_BookSeat));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_departure = new System.Windows.Forms.ComboBox();
            this.comboBox_Arrival = new System.Windows.Forms.ComboBox();
            this.comboBox_Airline = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Departure Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.Location = new System.Drawing.Point(27, 393);
            this.dateTimeDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeDeparture.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimeDeparture.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDeparture.TabIndex = 62;
            this.dateTimeDeparture.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateTimeDeparture.ValueChanged += new System.EventHandler(this.dateTimeDeparture_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Select Airline Company (Optional)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Departure";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Arrival";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_back.BackgroundImage")));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(184, 505);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(227, 48);
            this.button_back.TabIndex = 55;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(184, 451);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(227, 48);
            this.button_search.TabIndex = 54;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_departure
            // 
            this.comboBox_departure.FormattingEnabled = true;
            this.comboBox_departure.Items.AddRange(new object[] {
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
            this.comboBox_departure.Location = new System.Drawing.Point(27, 274);
            this.comboBox_departure.Name = "comboBox_departure";
            this.comboBox_departure.Size = new System.Drawing.Size(121, 24);
            this.comboBox_departure.TabIndex = 64;
            this.comboBox_departure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.comboBox_Arrival.Location = new System.Drawing.Point(225, 284);
            this.comboBox_Arrival.Name = "comboBox_Arrival";
            this.comboBox_Arrival.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Arrival.TabIndex = 65;
            // 
            // comboBox_Airline
            // 
            this.comboBox_Airline.FormattingEnabled = true;
            this.comboBox_Airline.Items.AddRange(new object[] {
            "PIA",
            "ETIHAD",
            "EMIRATES",
            "QATAR AIRWAYS",
            "TURKISH AIRLINES",
            "LOONAY WALA EXPRESS"});
            this.comboBox_Airline.Location = new System.Drawing.Point(27, 336);
            this.comboBox_Airline.Name = "comboBox_Airline";
            this.comboBox_Airline.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Airline.TabIndex = 66;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 193);
            this.dataGridView1.TabIndex = 67;
            // 
            // User_BookSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Airline);
            this.Controls.Add(this.comboBox_Arrival);
            this.Controls.Add(this.comboBox_departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeDeparture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_BookSeat";
            this.Text = "User_BookFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_BookSeat_FormClosing);
            this.Load += new System.EventHandler(this.User_BookSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDeparture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_departure;
        private System.Windows.Forms.ComboBox comboBox_Arrival;
        private System.Windows.Forms.ComboBox comboBox_Airline;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}