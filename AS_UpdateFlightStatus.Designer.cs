namespace DATABASE_PROJECT
{
    partial class AS_UpdateFlightStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_UpdateFlightStatus));
            this.btn_back = new System.Windows.Forms.Button();
            this.login_headline_label = new System.Windows.Forms.Label();
            this.comboBox_flightStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_flightStatus = new System.Windows.Forms.Label();
            this.combo_flightid = new System.Windows.Forms.ComboBox();
            this.label_displayStatus = new System.Windows.Forms.Label();
            this.displayStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_displayDepDate = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label_displayArrCity = new System.Windows.Forms.Label();
            this.label_displayDepCity = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(184, 471);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // login_headline_label
            // 
            this.login_headline_label.AutoSize = true;
            this.login_headline_label.BackColor = System.Drawing.Color.Transparent;
            this.login_headline_label.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_headline_label.Location = new System.Drawing.Point(111, 46);
            this.login_headline_label.Name = "login_headline_label";
            this.login_headline_label.Size = new System.Drawing.Size(373, 48);
            this.login_headline_label.TabIndex = 81;
            this.login_headline_label.Text = "FLIGHT STATUS";
            // 
            // comboBox_flightStatus
            // 
            this.comboBox_flightStatus.FormattingEnabled = true;
            this.comboBox_flightStatus.Items.AddRange(new object[] {
            "DELAYED",
            "ON TIME",
            "COMPLETED",
            "CANCELED"});
            this.comboBox_flightStatus.Location = new System.Drawing.Point(337, 363);
            this.comboBox_flightStatus.Name = "comboBox_flightStatus";
            this.comboBox_flightStatus.Size = new System.Drawing.Size(147, 24);
            this.comboBox_flightStatus.TabIndex = 98;
            this.comboBox_flightStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox_flightStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 97;
            this.label3.Text = "Flight ID";
            // 
            // label_flightStatus
            // 
            this.label_flightStatus.AutoSize = true;
            this.label_flightStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_flightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_flightStatus.Location = new System.Drawing.Point(93, 361);
            this.label_flightStatus.Name = "label_flightStatus";
            this.label_flightStatus.Size = new System.Drawing.Size(124, 22);
            this.label_flightStatus.TabIndex = 96;
            this.label_flightStatus.Text = "Update Status";
            // 
            // combo_flightid
            // 
            this.combo_flightid.FormattingEnabled = true;
            this.combo_flightid.Location = new System.Drawing.Point(337, 322);
            this.combo_flightid.Margin = new System.Windows.Forms.Padding(4);
            this.combo_flightid.Name = "combo_flightid";
            this.combo_flightid.Size = new System.Drawing.Size(147, 24);
            this.combo_flightid.TabIndex = 95;
            this.combo_flightid.Text = "Flight ID";
            this.combo_flightid.SelectedIndexChanged += new System.EventHandler(this.combo_AircraftId_SelectedIndexChanged);
            // 
            // label_displayStatus
            // 
            this.label_displayStatus.AutoSize = true;
            this.label_displayStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_displayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayStatus.Location = new System.Drawing.Point(130, 264);
            this.label_displayStatus.Name = "label_displayStatus";
            this.label_displayStatus.Size = new System.Drawing.Size(152, 25);
            this.label_displayStatus.TabIndex = 99;
            this.label_displayStatus.Text = "Current Status";
            // 
            // displayStatus
            // 
            this.displayStatus.AutoSize = true;
            this.displayStatus.BackColor = System.Drawing.Color.Transparent;
            this.displayStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStatus.Location = new System.Drawing.Point(337, 264);
            this.displayStatus.Name = "displayStatus";
            this.displayStatus.Size = new System.Drawing.Size(45, 25);
            this.displayStatus.TabIndex = 100;
            this.displayStatus.Text = "NIL";
            this.displayStatus.Click += new System.EventHandler(this.displayStatus_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(184, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 48);
            this.button1.TabIndex = 101;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_displayDepDate
            // 
            this.label_displayDepDate.AutoSize = true;
            this.label_displayDepDate.BackColor = System.Drawing.Color.Transparent;
            this.label_displayDepDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDepDate.Location = new System.Drawing.Point(299, 217);
            this.label_displayDepDate.Name = "label_displayDepDate";
            this.label_displayDepDate.Size = new System.Drawing.Size(66, 22);
            this.label_displayDepDate.TabIndex = 107;
            this.label_displayDepDate.Text = "display";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(131, 217);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 22);
            this.password_label.TabIndex = 106;
            this.password_label.Text = "Dep Date";
            // 
            // label_displayArrCity
            // 
            this.label_displayArrCity.AutoSize = true;
            this.label_displayArrCity.BackColor = System.Drawing.Color.Transparent;
            this.label_displayArrCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayArrCity.Location = new System.Drawing.Point(299, 172);
            this.label_displayArrCity.Name = "label_displayArrCity";
            this.label_displayArrCity.Size = new System.Drawing.Size(66, 22);
            this.label_displayArrCity.TabIndex = 105;
            this.label_displayArrCity.Text = "display";
            // 
            // label_displayDepCity
            // 
            this.label_displayDepCity.AutoSize = true;
            this.label_displayDepCity.BackColor = System.Drawing.Color.Transparent;
            this.label_displayDepCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDepCity.Location = new System.Drawing.Point(299, 126);
            this.label_displayDepCity.Name = "label_displayDepCity";
            this.label_displayDepCity.Size = new System.Drawing.Size(66, 22);
            this.label_displayDepCity.TabIndex = 104;
            this.label_displayDepCity.Text = "dispaly";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(131, 172);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(97, 22);
            this.phone_label.TabIndex = 103;
            this.phone_label.Text = "Arrival City";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(131, 126);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(79, 22);
            this.email_label.TabIndex = 102;
            this.email_label.Text = "Dep City";
            // 
            // AS_UpdateFlightStatus
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayStatus);
            this.Controls.Add(this.label_displayStatus);
            this.Controls.Add(this.comboBox_flightStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_flightStatus);
            this.Controls.Add(this.combo_flightid);
            this.Controls.Add(this.login_headline_label);
            this.Controls.Add(this.btn_back);
            this.Name = "AS_UpdateFlightStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AS_UpdateFlightStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_UpdateFlightStatus_FormClosing);
            this.Load += new System.EventHandler(this.AS_UpdateFlightStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label login_headline_label;
        private System.Windows.Forms.ComboBox comboBox_flightStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_flightStatus;
        private System.Windows.Forms.ComboBox combo_flightid;
        private System.Windows.Forms.Label label_displayStatus;
        private System.Windows.Forms.Label displayStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_displayDepDate;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label_displayArrCity;
        private System.Windows.Forms.Label label_displayDepCity;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label email_label;
    }
}