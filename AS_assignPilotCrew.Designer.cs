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
            this.SuspendLayout();
            // 
            // crew_combobox
            // 
            this.crew_combobox.FormattingEnabled = true;
            this.crew_combobox.Location = new System.Drawing.Point(208, 103);
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
            this.flight_id_combobox.Location = new System.Drawing.Point(208, 152);
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
            this.name_label.Location = new System.Drawing.Point(81, 103);
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
            this.label_FID.Location = new System.Drawing.Point(81, 154);
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
            this.label_displayStatus.Location = new System.Drawing.Point(254, 265);
            this.label_displayStatus.Name = "label_displayStatus";
            this.label_displayStatus.Size = new System.Drawing.Size(0, 25);
            this.label_displayStatus.TabIndex = 87;
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
            // AS_assignPilotCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
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
    }
}