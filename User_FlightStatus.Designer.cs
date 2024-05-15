namespace DATABASE_PROJECT
{
    partial class User_FlightStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_FlightStatus));
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_displayStatus = new System.Windows.Forms.Label();
            this.comboBox_flightID = new System.Windows.Forms.ComboBox();
            this.label_displayDepDate = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label_displayArrCity = new System.Windows.Forms.Label();
            this.label_displayDepCity = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Flight No";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_back.BackgroundImage")));
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(201, 444);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(227, 48);
            this.button_back.TabIndex = 53;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 48);
            this.label5.TabIndex = 85;
            this.label5.Text = "FLIGHT STATUS";
            // 
            // label_displayStatus
            // 
            this.label_displayStatus.AutoSize = true;
            this.label_displayStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_displayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayStatus.Location = new System.Drawing.Point(345, 256);
            this.label_displayStatus.Name = "label_displayStatus";
            this.label_displayStatus.Size = new System.Drawing.Size(70, 25);
            this.label_displayStatus.TabIndex = 86;
            this.label_displayStatus.Text = "status";
            // 
            // comboBox_flightID
            // 
            this.comboBox_flightID.FormattingEnabled = true;
            this.comboBox_flightID.Location = new System.Drawing.Point(201, 381);
            this.comboBox_flightID.Name = "comboBox_flightID";
            this.comboBox_flightID.Size = new System.Drawing.Size(223, 24);
            this.comboBox_flightID.TabIndex = 87;
            this.comboBox_flightID.SelectedIndexChanged += new System.EventHandler(this.comboBox_flightID_SelectedIndexChanged);
            // 
            // label_displayDepDate
            // 
            this.label_displayDepDate.AutoSize = true;
            this.label_displayDepDate.BackColor = System.Drawing.Color.Transparent;
            this.label_displayDepDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDepDate.Location = new System.Drawing.Point(346, 218);
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
            this.password_label.Location = new System.Drawing.Point(178, 218);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 22);
            this.password_label.TabIndex = 112;
            this.password_label.Text = "Dep Date";
            this.password_label.Click += new System.EventHandler(this.password_label_Click);
            // 
            // label_displayArrCity
            // 
            this.label_displayArrCity.AutoSize = true;
            this.label_displayArrCity.BackColor = System.Drawing.Color.Transparent;
            this.label_displayArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayArrCity.Location = new System.Drawing.Point(346, 173);
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
            this.label_displayDepCity.Location = new System.Drawing.Point(346, 127);
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
            this.phone_label.Location = new System.Drawing.Point(178, 173);
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
            this.email_label.Location = new System.Drawing.Point(178, 127);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(79, 22);
            this.email_label.TabIndex = 108;
            this.email_label.Text = "Dep City";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(178, 259);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(61, 22);
            this.label_status.TabIndex = 114;
            this.label_status.Text = "Status";
            // 
            // User_FlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_displayDepDate);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.label_displayArrCity);
            this.Controls.Add(this.label_displayDepCity);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.comboBox_flightID);
            this.Controls.Add(this.label_displayStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_FlightStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_FlightStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FlightStatus_FormClosing);
            this.Load += new System.EventHandler(this.User_FlightStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_displayStatus;
        private System.Windows.Forms.ComboBox comboBox_flightID;
        private System.Windows.Forms.Label label_displayDepDate;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label_displayArrCity;
        private System.Windows.Forms.Label label_displayDepCity;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label label_status;
    }
}