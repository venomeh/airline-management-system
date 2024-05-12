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
            this.button_schedule_flight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_schedule_flight
            // 
            this.button_schedule_flight.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_schedule_flight.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_schedule_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_schedule_flight.Location = new System.Drawing.Point(273, 280);
            this.button_schedule_flight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_schedule_flight.Name = "button_schedule_flight";
            this.button_schedule_flight.Size = new System.Drawing.Size(227, 48);
            this.button_schedule_flight.TabIndex = 11;
            this.button_schedule_flight.Text = "Schedule Flight";
            this.button_schedule_flight.UseVisualStyleBackColor = false;
            // 
            // AS_ScheduleFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.button_schedule_flight);
            this.Name = "AS_ScheduleFlight";
            this.Text = "AS_ScheduleFlight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_ScheduleFlight_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_schedule_flight;
    }
}