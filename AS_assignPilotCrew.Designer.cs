namespace DATABASE_PROJECT
{
    partial class AS_assignPilotCrew
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
            this.Pilot_Crew_label = new System.Windows.Forms.Label();
            this.pilot_radiobtn = new System.Windows.Forms.RadioButton();
            this.crew_radio_btn = new System.Windows.Forms.RadioButton();
            this.pilot_crew_combobox = new System.Windows.Forms.ComboBox();
            this.Flight_id_lable = new System.Windows.Forms.Label();
            this.flight_id_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Pilot_Crew_label
            // 
            this.Pilot_Crew_label.AutoSize = true;
            this.Pilot_Crew_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pilot_Crew_label.Location = new System.Drawing.Point(13, 86);
            this.Pilot_Crew_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pilot_Crew_label.Name = "Pilot_Crew_label";
            this.Pilot_Crew_label.Size = new System.Drawing.Size(253, 39);
            this.Pilot_Crew_label.TabIndex = 0;
            this.Pilot_Crew_label.Text = "PILOTS/CREW";
            this.Pilot_Crew_label.Click += new System.EventHandler(this.Pilots_label_Click);
            // 
            // pilot_radiobtn
            // 
            this.pilot_radiobtn.AutoSize = true;
            this.pilot_radiobtn.Location = new System.Drawing.Point(283, 103);
            this.pilot_radiobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pilot_radiobtn.Name = "pilot_radiobtn";
            this.pilot_radiobtn.Size = new System.Drawing.Size(54, 20);
            this.pilot_radiobtn.TabIndex = 2;
            this.pilot_radiobtn.TabStop = true;
            this.pilot_radiobtn.Text = "Pilot";
            this.pilot_radiobtn.UseVisualStyleBackColor = true;
            this.pilot_radiobtn.CheckedChanged += new System.EventHandler(this.pilot_radiobtn_CheckedChanged);
            // 
            // crew_radio_btn
            // 
            this.crew_radio_btn.AutoSize = true;
            this.crew_radio_btn.Location = new System.Drawing.Point(351, 103);
            this.crew_radio_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crew_radio_btn.Name = "crew_radio_btn";
            this.crew_radio_btn.Size = new System.Drawing.Size(58, 20);
            this.crew_radio_btn.TabIndex = 3;
            this.crew_radio_btn.TabStop = true;
            this.crew_radio_btn.Text = "Crew";
            this.crew_radio_btn.UseVisualStyleBackColor = true;
            this.crew_radio_btn.CheckedChanged += new System.EventHandler(this.crew_radio_btn_CheckedChanged);
            // 
            // pilot_crew_combobox
            // 
            this.pilot_crew_combobox.FormattingEnabled = true;
            this.pilot_crew_combobox.Location = new System.Drawing.Point(26, 142);
            this.pilot_crew_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pilot_crew_combobox.Name = "pilot_crew_combobox";
            this.pilot_crew_combobox.Size = new System.Drawing.Size(240, 24);
            this.pilot_crew_combobox.TabIndex = 4;
            this.pilot_crew_combobox.Text = "Pilot/Crew";
            this.pilot_crew_combobox.SelectedIndexChanged += new System.EventHandler(this.pilot_crew_combobox_SelectedIndexChanged);
            // 
            // Flight_id_lable
            // 
            this.Flight_id_lable.AutoSize = true;
            this.Flight_id_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flight_id_lable.Location = new System.Drawing.Point(19, 234);
            this.Flight_id_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Flight_id_lable.Name = "Flight_id_lable";
            this.Flight_id_lable.Size = new System.Drawing.Size(147, 39);
            this.Flight_id_lable.TabIndex = 5;
            this.Flight_id_lable.Text = "Flight_id";
            // 
            // flight_id_combobox
            // 
            this.flight_id_combobox.FormattingEnabled = true;
            this.flight_id_combobox.Location = new System.Drawing.Point(185, 234);
            this.flight_id_combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flight_id_combobox.Name = "flight_id_combobox";
            this.flight_id_combobox.Size = new System.Drawing.Size(240, 24);
            this.flight_id_combobox.TabIndex = 6;
            this.flight_id_combobox.Text = "ID\'s";
            this.flight_id_combobox.SelectedIndexChanged += new System.EventHandler(this.flight_id_combobox_SelectedIndexChanged);
            // 
            // AS_assignPilotCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.flight_id_combobox);
            this.Controls.Add(this.Flight_id_lable);
            this.Controls.Add(this.pilot_crew_combobox);
            this.Controls.Add(this.crew_radio_btn);
            this.Controls.Add(this.pilot_radiobtn);
            this.Controls.Add(this.Pilot_Crew_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AS_assignPilotCrew";
            this.Text = "AS_assignPilotCrew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_assignPilotCrew_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Pilot_Crew_label;
        private System.Windows.Forms.RadioButton pilot_radiobtn;
        private System.Windows.Forms.RadioButton crew_radio_btn;
        private System.Windows.Forms.ComboBox pilot_crew_combobox;
        private System.Windows.Forms.Label Flight_id_lable;
        private System.Windows.Forms.ComboBox flight_id_combobox;
    }
}