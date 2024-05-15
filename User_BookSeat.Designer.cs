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
            this.depDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_departure = new System.Windows.Forms.ComboBox();
            this.comboBox_Arrival = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_password = new System.Windows.Forms.Label();
            this.comboBox_selectflightId = new System.Windows.Forms.ComboBox();
            this.button_book = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton_NO = new System.Windows.Forms.RadioButton();
            this.radioButton_YES = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BaggageWeight = new System.Windows.Forms.ComboBox();
            this.label_BaggageWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Departure Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // depDate
            // 
            this.depDate.CalendarForeColor = System.Drawing.Color.Transparent;
            this.depDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.depDate.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.depDate.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.depDate.Location = new System.Drawing.Point(358, 347);
            this.depDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depDate.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.depDate.MinDate = new System.DateTime(2024, 4, 24, 0, 0, 0, 0);
            this.depDate.Name = "depDate";
            this.depDate.Size = new System.Drawing.Size(200, 22);
            this.depDate.TabIndex = 62;
            this.depDate.Value = new System.DateTime(2024, 5, 14, 0, 0, 0, 0);
            this.depDate.ValueChanged += new System.EventHandler(this.dateTimeDeparture_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 322);
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
            this.label7.Location = new System.Drawing.Point(195, 322);
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
            this.button_back.Location = new System.Drawing.Point(79, 503);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(123, 48);
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
            this.button_search.Location = new System.Drawing.Point(227, 503);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(123, 48);
            this.button_search.TabIndex = 54;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox_departure
            // 
            this.comboBox_departure.FormattingEnabled = true;
            this.comboBox_departure.Items.AddRange(new object[] {
            "ANKARA",
            "ISTANBUL",
            "LAHORE",
            "FAISALABAD",
            "KARACHI",
            "LOONAY WALA",
            "ISLAMABAD",
            "DUBAI",
            "NEW YORK",
            "LONDON",
            "MADINA",
            "JEDDAH",
            "DOHA"});
            this.comboBox_departure.Location = new System.Drawing.Point(29, 347);
            this.comboBox_departure.Name = "comboBox_departure";
            this.comboBox_departure.Size = new System.Drawing.Size(121, 24);
            this.comboBox_departure.TabIndex = 64;
            this.comboBox_departure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_Arrival
            // 
            this.comboBox_Arrival.FormattingEnabled = true;
            this.comboBox_Arrival.Items.AddRange(new object[] {
            "ANKARA",
            "ISTANBUL",
            "LAHORE",
            "FAISALABAD",
            "KARACHI",
            "LOONAY WALA",
            "ISLAMABAD",
            "DUBAI",
            "NEW YORK",
            "LONDON",
            "MADINA",
            "JEDDAH",
            "DOHA"});
            this.comboBox_Arrival.Location = new System.Drawing.Point(199, 347);
            this.comboBox_Arrival.Name = "comboBox_Arrival";
            this.comboBox_Arrival.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Arrival.TabIndex = 65;
            this.comboBox_Arrival.SelectedIndexChanged += new System.EventHandler(this.comboBox_Arrival_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 193);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(25, 387);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(142, 22);
            this.label_password.TabIndex = 95;
            this.label_password.Text = "Flight ID to Book";
            // 
            // comboBox_selectflightId
            // 
            this.comboBox_selectflightId.FormattingEnabled = true;
            this.comboBox_selectflightId.Location = new System.Drawing.Point(29, 412);
            this.comboBox_selectflightId.Name = "comboBox_selectflightId";
            this.comboBox_selectflightId.Size = new System.Drawing.Size(121, 24);
            this.comboBox_selectflightId.TabIndex = 96;
            this.comboBox_selectflightId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button_book
            // 
            this.button_book.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_book.BackgroundImage")));
            this.button_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book.Location = new System.Drawing.Point(373, 503);
            this.button_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(161, 48);
            this.button_book.TabIndex = 97;
            this.button_book.Text = "Confirm Seat";
            this.button_book.UseVisualStyleBackColor = false;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 100;
            this.label3.Text = "Got Baggage";
            // 
            // radioButton_NO
            // 
            this.radioButton_NO.AutoSize = true;
            this.radioButton_NO.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_NO.Location = new System.Drawing.Point(274, 416);
            this.radioButton_NO.Name = "radioButton_NO";
            this.radioButton_NO.Size = new System.Drawing.Size(48, 20);
            this.radioButton_NO.TabIndex = 119;
            this.radioButton_NO.TabStop = true;
            this.radioButton_NO.Text = "NO";
            this.radioButton_NO.UseVisualStyleBackColor = false;
            this.radioButton_NO.CheckedChanged += new System.EventHandler(this.radioButton_NO_CheckedChanged);
            // 
            // radioButton_YES
            // 
            this.radioButton_YES.AutoSize = true;
            this.radioButton_YES.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_YES.Location = new System.Drawing.Point(199, 416);
            this.radioButton_YES.Name = "radioButton_YES";
            this.radioButton_YES.Size = new System.Drawing.Size(55, 20);
            this.radioButton_YES.TabIndex = 118;
            this.radioButton_YES.TabStop = true;
            this.radioButton_YES.Text = "YES";
            this.radioButton_YES.UseVisualStyleBackColor = false;
            this.radioButton_YES.CheckedChanged += new System.EventHandler(this.radioButton_YES_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 120;
            this.label1.Text = "BOOK SEATS";
            // 
            // comboBox_BaggageWeight
            // 
            this.comboBox_BaggageWeight.FormattingEnabled = true;
            this.comboBox_BaggageWeight.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBox_BaggageWeight.Location = new System.Drawing.Point(358, 412);
            this.comboBox_BaggageWeight.Name = "comboBox_BaggageWeight";
            this.comboBox_BaggageWeight.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BaggageWeight.TabIndex = 122;
            // 
            // label_BaggageWeight
            // 
            this.label_BaggageWeight.AutoSize = true;
            this.label_BaggageWeight.BackColor = System.Drawing.Color.Transparent;
            this.label_BaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BaggageWeight.Location = new System.Drawing.Point(354, 387);
            this.label_BaggageWeight.Name = "label_BaggageWeight";
            this.label_BaggageWeight.Size = new System.Drawing.Size(143, 22);
            this.label_BaggageWeight.TabIndex = 121;
            this.label_BaggageWeight.Text = "Baggage Weight";
            // 
            // User_BookSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.comboBox_BaggageWeight);
            this.Controls.Add(this.label_BaggageWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_NO);
            this.Controls.Add(this.radioButton_YES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.comboBox_selectflightId);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Arrival);
            this.Controls.Add(this.comboBox_departure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_BookSeat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Flight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_BookSeat_FormClosing);
            this.Load += new System.EventHandler(this.User_BookSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker depDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_departure;
        private System.Windows.Forms.ComboBox comboBox_Arrival;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.ComboBox comboBox_selectflightId;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton_NO;
        private System.Windows.Forms.RadioButton radioButton_YES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BaggageWeight;
        private System.Windows.Forms.Label label_BaggageWeight;
    }
}