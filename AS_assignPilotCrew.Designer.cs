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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_assignPilotCrew));
            this.crew_combobox = new System.Windows.Forms.ComboBox();
            this.flight_id_combobox = new System.Windows.Forms.ComboBox();
            this.name_label = new System.Windows.Forms.Label();
            this.label_FID = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button_Assign = new System.Windows.Forms.Button();
            this.label_displayStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_displayDepDate = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label_displayArrCity = new System.Windows.Forms.Label();
            this.label_displayDepCity = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crew_combobox
            // 
            this.crew_combobox.FormattingEnabled = true;
            this.crew_combobox.Location = new System.Drawing.Point(251, 332);
            this.crew_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.crew_combobox.Name = "crew_combobox";
            this.crew_combobox.Size = new System.Drawing.Size(240, 24);
            this.crew_combobox.TabIndex = 4;
            this.crew_combobox.Text = "Pilot/Crew";
            this.crew_combobox.SelectedIndexChanged += new System.EventHandler(this.pilot_crew_combobox_SelectedIndexChanged);
            // 
            // flight_id_combobox
            // 
            this.flight_id_combobox.FormattingEnabled = true;
            this.flight_id_combobox.Location = new System.Drawing.Point(251, 381);
            this.flight_id_combobox.Margin = new System.Windows.Forms.Padding(4);
            this.flight_id_combobox.Name = "flight_id_combobox";
            this.flight_id_combobox.Size = new System.Drawing.Size(240, 24);
            this.flight_id_combobox.TabIndex = 6;
            this.flight_id_combobox.Text = "ID\'s";
            this.flight_id_combobox.SelectedIndexChanged += new System.EventHandler(this.flight_id_combobox_SelectedIndexChanged);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(124, 332);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(104, 22);
            this.name_label.TabIndex = 66;
            this.name_label.Text = "Assign Pilot";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // label_FID
            // 
            this.label_FID.AutoSize = true;
            this.label_FID.BackColor = System.Drawing.Color.Transparent;
            this.label_FID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FID.Location = new System.Drawing.Point(124, 383);
            this.label_FID.Name = "label_FID";
            this.label_FID.Size = new System.Drawing.Size(73, 22);
            this.label_FID.TabIndex = 76;
            this.label_FID.Text = "Flight Id";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(187, 498);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 78;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button_Assign
            // 
            this.button_Assign.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_Assign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Assign.BackgroundImage")));
            this.button_Assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Assign.Location = new System.Drawing.Point(187, 444);
            this.button_Assign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Assign.Name = "button_Assign";
            this.button_Assign.Size = new System.Drawing.Size(227, 48);
            this.button_Assign.TabIndex = 77;
            this.button_Assign.Text = "Assign";
            this.button_Assign.UseVisualStyleBackColor = false;
            this.button_Assign.Click += new System.EventHandler(this.button_Assign_Click);
            // 
            // label_displayStatus
            // 
            this.label_displayStatus.AutoSize = true;
            this.label_displayStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_displayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayStatus.Location = new System.Drawing.Point(246, 128);
            this.label_displayStatus.Name = "label_displayStatus";
            this.label_displayStatus.Size = new System.Drawing.Size(124, 25);
            this.label_displayStatus.TabIndex = 87;
            this.label_displayStatus.Text = "CrewStatus";
            this.label_displayStatus.Click += new System.EventHandler(this.label_displayStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 48);
            this.label1.TabIndex = 88;
            this.label1.Text = "ASSIGN PILOTS";
            // 
            // label_displayDepDate
            // 
            this.label_displayDepDate.AutoSize = true;
            this.label_displayDepDate.BackColor = System.Drawing.Color.Transparent;
            this.label_displayDepDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDepDate.Location = new System.Drawing.Point(348, 265);
            this.label_displayDepDate.Name = "label_displayDepDate";
            this.label_displayDepDate.Size = new System.Drawing.Size(66, 22);
            this.label_displayDepDate.TabIndex = 113;
            this.label_displayDepDate.Text = "display";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(180, 265);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 22);
            this.password_label.TabIndex = 112;
            this.password_label.Text = "Dep Date";
            // 
            // label_displayArrCity
            // 
            this.label_displayArrCity.AutoSize = true;
            this.label_displayArrCity.BackColor = System.Drawing.Color.Transparent;
            this.label_displayArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayArrCity.Location = new System.Drawing.Point(348, 220);
            this.label_displayArrCity.Name = "label_displayArrCity";
            this.label_displayArrCity.Size = new System.Drawing.Size(66, 22);
            this.label_displayArrCity.TabIndex = 111;
            this.label_displayArrCity.Text = "display";
            // 
            // label_displayDepCity
            // 
            this.label_displayDepCity.AutoSize = true;
            this.label_displayDepCity.BackColor = System.Drawing.Color.Transparent;
            this.label_displayDepCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDepCity.Location = new System.Drawing.Point(348, 174);
            this.label_displayDepCity.Name = "label_displayDepCity";
            this.label_displayDepCity.Size = new System.Drawing.Size(66, 22);
            this.label_displayDepCity.TabIndex = 110;
            this.label_displayDepCity.Text = "dispaly";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(180, 220);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(97, 22);
            this.phone_label.TabIndex = 109;
            this.phone_label.Text = "Arrival City";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(180, 174);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(79, 22);
            this.email_label.TabIndex = 108;
            this.email_label.Text = "Dep City";
            // 
            // AS_assignPilotCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_displayDepDate);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.label_displayArrCity);
            this.Controls.Add(this.label_displayDepCity);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_displayStatus);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button_Assign);
            this.Controls.Add(this.label_FID);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.flight_id_combobox);
            this.Controls.Add(this.crew_combobox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AS_assignPilotCrew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AS_assignPilotCrew";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_assignPilotCrew_FormClosing);
            this.Load += new System.EventHandler(this.AS_assignPilotCrew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox crew_combobox;
        private System.Windows.Forms.ComboBox flight_id_combobox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label_FID;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button button_Assign;
        private System.Windows.Forms.Label label_displayStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_displayDepDate;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label_displayArrCity;
        private System.Windows.Forms.Label label_displayDepCity;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label email_label;
    }
}