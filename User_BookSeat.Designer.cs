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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_departure = new System.Windows.Forms.TextBox();
            this.textBox_arrival = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Departure Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dateTimeDeparture.Location = new System.Drawing.Point(138, 227);
            this.dateTimeDeparture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeDeparture.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dateTimeDeparture.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(151, 20);
            this.dateTimeDeparture.TabIndex = 62;
            this.dateTimeDeparture.Value = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.dateTimeDeparture.ValueChanged += new System.EventHandler(this.dateTimeDeparture_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(138, 171);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Select Airline Company (Optional)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_departure
            // 
            this.textBox_departure.BackColor = System.Drawing.Color.LightGray;
            this.textBox_departure.Location = new System.Drawing.Point(138, 73);
            this.textBox_departure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_departure.Name = "textBox_departure";
            this.textBox_departure.Size = new System.Drawing.Size(170, 20);
            this.textBox_departure.TabIndex = 59;
            this.textBox_departure.TextChanged += new System.EventHandler(this.textBox_departure_TextChanged);
            // 
            // textBox_arrival
            // 
            this.textBox_arrival.BackColor = System.Drawing.Color.LightGray;
            this.textBox_arrival.Location = new System.Drawing.Point(138, 120);
            this.textBox_arrival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_arrival.Name = "textBox_arrival";
            this.textBox_arrival.Size = new System.Drawing.Size(170, 20);
            this.textBox_arrival.TabIndex = 58;
            this.textBox_arrival.TextChanged += new System.EventHandler(this.textBox_arrival_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Departure";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(135, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Arrival";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(138, 387);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(170, 39);
            this.button_back.TabIndex = 55;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(138, 343);
            this.button_search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(170, 39);
            this.button_search.TabIndex = 54;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // User_BookSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeDeparture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_departure);
            this.Controls.Add(this.textBox_arrival);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User_BookSeat";
            this.Text = "User_BookFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_BookSeat_FormClosing);
            this.Load += new System.EventHandler(this.User_BookSeat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDeparture;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_departure;
        private System.Windows.Forms.TextBox textBox_arrival;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_search;
    }
}