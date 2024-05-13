namespace DATABASE_PROJECT.Resources
{
    partial class Main_UserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_UserView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_bookSeat = new System.Windows.Forms.Button();
            this.button_cancelSeat = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_bookedSeats = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_flight_status = new System.Windows.Forms.Button();
            this.label_displayName = new System.Windows.Forms.Label();
            this.button_Feedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "A.T Airlines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_bookSeat
            // 
            this.button_bookSeat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_bookSeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_bookSeat.BackgroundImage")));
            this.button_bookSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bookSeat.Location = new System.Drawing.Point(192, 144);
            this.button_bookSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_bookSeat.Name = "button_bookSeat";
            this.button_bookSeat.Size = new System.Drawing.Size(227, 48);
            this.button_bookSeat.TabIndex = 3;
            this.button_bookSeat.Text = "Book Seats";
            this.button_bookSeat.UseVisualStyleBackColor = false;
            this.button_bookSeat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancelSeat
            // 
            this.button_cancelSeat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_cancelSeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cancelSeat.BackgroundImage")));
            this.button_cancelSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelSeat.Location = new System.Drawing.Point(192, 199);
            this.button_cancelSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancelSeat.Name = "button_cancelSeat";
            this.button_cancelSeat.Size = new System.Drawing.Size(227, 48);
            this.button_cancelSeat.TabIndex = 4;
            this.button_cancelSeat.Text = "Cancel Seat";
            this.button_cancelSeat.UseVisualStyleBackColor = false;
            this.button_cancelSeat.Click += new System.EventHandler(this.button_cancelSeat_Click);
            // 
            // button_profile
            // 
            this.button_profile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_profile.BackgroundImage")));
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.Location = new System.Drawing.Point(192, 410);
            this.button_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(227, 48);
            this.button_profile.TabIndex = 5;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_bookedSeats
            // 
            this.button_bookedSeats.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_bookedSeats.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_bookedSeats.BackgroundImage")));
            this.button_bookedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bookedSeats.Location = new System.Drawing.Point(192, 252);
            this.button_bookedSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_bookedSeats.Name = "button_bookedSeats";
            this.button_bookedSeats.Size = new System.Drawing.Size(227, 48);
            this.button_bookedSeats.TabIndex = 6;
            this.button_bookedSeats.Text = "Bookings";
            this.button_bookedSeats.UseVisualStyleBackColor = false;
            this.button_bookedSeats.Click += new System.EventHandler(this.button_bookedSeats_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(192, 464);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(227, 48);
            this.button_logout.TabIndex = 7;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_flight_status
            // 
            this.button_flight_status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_flight_status.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_flight_status.BackgroundImage")));
            this.button_flight_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_flight_status.Location = new System.Drawing.Point(192, 306);
            this.button_flight_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_flight_status.Name = "button_flight_status";
            this.button_flight_status.Size = new System.Drawing.Size(227, 48);
            this.button_flight_status.TabIndex = 8;
            this.button_flight_status.Text = "Flight Status";
            this.button_flight_status.UseVisualStyleBackColor = false;
            this.button_flight_status.Click += new System.EventHandler(this.button_flight_status_Click);
            // 
            // label_displayName
            // 
            this.label_displayName.AutoSize = true;
            this.label_displayName.BackColor = System.Drawing.Color.Transparent;
            this.label_displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayName.Location = new System.Drawing.Point(327, 97);
            this.label_displayName.Name = "label_displayName";
            this.label_displayName.Size = new System.Drawing.Size(65, 25);
            this.label_displayName.TabIndex = 9;
            this.label_displayName.Text = "name";
            this.label_displayName.Click += new System.EventHandler(this.label_displayName_Click);
            // 
            // button_Feedback
            // 
            this.button_Feedback.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_Feedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Feedback.BackgroundImage")));
            this.button_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Feedback.Location = new System.Drawing.Point(192, 358);
            this.button_Feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Feedback.Name = "button_Feedback";
            this.button_Feedback.Size = new System.Drawing.Size(227, 48);
            this.button_Feedback.TabIndex = 10;
            this.button_Feedback.Text = "Feedback";
            this.button_Feedback.UseVisualStyleBackColor = false;
            this.button_Feedback.Click += new System.EventHandler(this.button_Feedback_Click);
            // 
            // Main_UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.button_Feedback);
            this.Controls.Add(this.label_displayName);
            this.Controls.Add(this.button_flight_status);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_bookedSeats);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_cancelSeat);
            this.Controls.Add(this.button_bookSeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main_UserView";
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserView_FormClosing);
            this.Load += new System.EventHandler(this.UserView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_bookSeat;
        private System.Windows.Forms.Button button_cancelSeat;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button button_bookedSeats;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_flight_status;
        private System.Windows.Forms.Label label_displayName;
        private System.Windows.Forms.Button button_Feedback;
    }
}