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
            this.textBox_FlightId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_displayStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_FlightId
            // 
            this.textBox_FlightId.BackColor = System.Drawing.Color.LightGray;
            this.textBox_FlightId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FlightId.Location = new System.Drawing.Point(201, 309);
            this.textBox_FlightId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FlightId.Name = "textBox_FlightId";
            this.textBox_FlightId.Size = new System.Drawing.Size(225, 22);
            this.textBox_FlightId.TabIndex = 52;
            this.textBox_FlightId.TextChanged += new System.EventHandler(this.textBox_ticketno_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 284);
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
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(201, 390);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(227, 48);
            this.button_search.TabIndex = 50;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
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
            this.label_displayStatus.Location = new System.Drawing.Point(200, 180);
            this.label_displayStatus.Name = "label_displayStatus";
            this.label_displayStatus.Size = new System.Drawing.Size(70, 25);
            this.label_displayStatus.TabIndex = 86;
            this.label_displayStatus.Text = "status";
            // 
            // User_FlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_displayStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_FlightId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_FlightStatus";
            this.Text = "User_FlightStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FlightStatus_FormClosing);
            this.Load += new System.EventHandler(this.User_FlightStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_FlightId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_displayStatus;
    }
}