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
            "COMPLETED"});
            this.comboBox_flightStatus.Location = new System.Drawing.Point(337, 322);
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
            this.label3.Location = new System.Drawing.Point(93, 279);
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
            this.label_flightStatus.Location = new System.Drawing.Point(93, 320);
            this.label_flightStatus.Name = "label_flightStatus";
            this.label_flightStatus.Size = new System.Drawing.Size(124, 22);
            this.label_flightStatus.TabIndex = 96;
            this.label_flightStatus.Text = "Update Status";
            // 
            // combo_flightid
            // 
            this.combo_flightid.FormattingEnabled = true;
            this.combo_flightid.Location = new System.Drawing.Point(337, 281);
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
            this.label_displayStatus.Location = new System.Drawing.Point(125, 184);
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
            this.displayStatus.Location = new System.Drawing.Point(283, 184);
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
            // AS_UpdateFlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
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
    }
}