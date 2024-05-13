namespace DATABASE_PROJECT
{
    partial class ControlCenter
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
            this.button_logout = new System.Windows.Forms.Button();
            this.button_update_flight_status = new System.Windows.Forms.Button();
            this.button_logistics = new System.Windows.Forms.Button();
            this.button_cancel_flight = new System.Windows.Forms.Button();
            this.button_weather_report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_logout.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(192, 421);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(227, 48);
            this.button_logout.TabIndex = 22;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // button_update_flight_status
            // 
            this.button_update_flight_status.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_update_flight_status.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_update_flight_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_flight_status.Location = new System.Drawing.Point(192, 313);
            this.button_update_flight_status.Name = "button_update_flight_status";
            this.button_update_flight_status.Size = new System.Drawing.Size(227, 48);
            this.button_update_flight_status.TabIndex = 20;
            this.button_update_flight_status.Text = "Update Flight Status";
            this.button_update_flight_status.UseVisualStyleBackColor = false;
            this.button_update_flight_status.Click += new System.EventHandler(this.button_update_flight_status_Click);
            // 
            // button_logistics
            // 
            this.button_logistics.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_logistics.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_logistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logistics.Location = new System.Drawing.Point(192, 367);
            this.button_logistics.Name = "button_logistics";
            this.button_logistics.Size = new System.Drawing.Size(227, 48);
            this.button_logistics.TabIndex = 19;
            this.button_logistics.Text = "Logistics";
            this.button_logistics.UseVisualStyleBackColor = false;
            // 
            // button_cancel_flight
            // 
            this.button_cancel_flight.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_cancel_flight.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_cancel_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel_flight.Location = new System.Drawing.Point(192, 259);
            this.button_cancel_flight.Name = "button_cancel_flight";
            this.button_cancel_flight.Size = new System.Drawing.Size(227, 48);
            this.button_cancel_flight.TabIndex = 18;
            this.button_cancel_flight.Text = "Cancel Flight";
            this.button_cancel_flight.UseVisualStyleBackColor = false;
            // 
            // button_weather_report
            // 
            this.button_weather_report.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_weather_report.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_weather_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_weather_report.Location = new System.Drawing.Point(192, 205);
            this.button_weather_report.Name = "button_weather_report";
            this.button_weather_report.Size = new System.Drawing.Size(227, 48);
            this.button_weather_report.TabIndex = 17;
            this.button_weather_report.Text = "Weather Report";
            this.button_weather_report.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 23;
            this.label1.Text = "A.T Airlines";
            // 
            // ControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(606, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_update_flight_status);
            this.Controls.Add(this.button_logistics);
            this.Controls.Add(this.button_cancel_flight);
            this.Controls.Add(this.button_weather_report);
            this.Name = "ControlCenter";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlCenter_FormClosing);
            this.Load += new System.EventHandler(this.ControlCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_update_flight_status;
        private System.Windows.Forms.Button button_logistics;
        private System.Windows.Forms.Button button_cancel_flight;
        private System.Windows.Forms.Button button_weather_report;
        private System.Windows.Forms.Label label1;
    }
}