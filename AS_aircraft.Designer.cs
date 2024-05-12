namespace DATABASE_PROJECT
{
    partial class AS_aircraft
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
            this.capacityRatio_label = new System.Windows.Forms.Label();
            this.CPH_label = new System.Windows.Forms.Label();
            this.model_label = new System.Windows.Forms.Label();
            this.totalCapacity_label = new System.Windows.Forms.Label();
            this.airline_label = new System.Windows.Forms.Label();
            this.aircraftID_label = new System.Windows.Forms.Label();
            this.capacityRatio_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.cph_textBox = new System.Windows.Forms.TextBox();
            this.totalcapacity_textBox = new System.Windows.Forms.TextBox();
            this.airline_textBox = new System.Windows.Forms.TextBox();
            this.idShow_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // capacityRatio_label
            // 
            this.capacityRatio_label.AutoSize = true;
            this.capacityRatio_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityRatio_label.Location = new System.Drawing.Point(77, 59);
            this.capacityRatio_label.Name = "capacityRatio_label";
            this.capacityRatio_label.Size = new System.Drawing.Size(152, 25);
            this.capacityRatio_label.TabIndex = 0;
            this.capacityRatio_label.Text = "Capacity Ratio";
            // 
            // CPH_label
            // 
            this.CPH_label.AutoSize = true;
            this.CPH_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPH_label.Location = new System.Drawing.Point(77, 121);
            this.CPH_label.Name = "CPH_label";
            this.CPH_label.Size = new System.Drawing.Size(206, 25);
            this.CPH_label.TabIndex = 1;
            this.CPH_label.Text = "Cost per hour (CPH)";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_label.Location = new System.Drawing.Point(77, 177);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(71, 25);
            this.model_label.TabIndex = 2;
            this.model_label.Text = "Model";
            // 
            // totalCapacity_label
            // 
            this.totalCapacity_label.AutoSize = true;
            this.totalCapacity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCapacity_label.Location = new System.Drawing.Point(77, 234);
            this.totalCapacity_label.Name = "totalCapacity_label";
            this.totalCapacity_label.Size = new System.Drawing.Size(156, 25);
            this.totalCapacity_label.TabIndex = 3;
            this.totalCapacity_label.Text = "Total Capacity ";
            // 
            // airline_label
            // 
            this.airline_label.AutoSize = true;
            this.airline_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airline_label.Location = new System.Drawing.Point(77, 293);
            this.airline_label.Name = "airline_label";
            this.airline_label.Size = new System.Drawing.Size(72, 25);
            this.airline_label.TabIndex = 4;
            this.airline_label.Text = "Airline";
            // 
            // aircraftID_label
            // 
            this.aircraftID_label.AutoSize = true;
            this.aircraftID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftID_label.Location = new System.Drawing.Point(77, 346);
            this.aircraftID_label.Name = "aircraftID_label";
            this.aircraftID_label.Size = new System.Drawing.Size(106, 25);
            this.aircraftID_label.TabIndex = 5;
            this.aircraftID_label.Text = "Aircraft ID";
            // 
            // capacityRatio_textBox
            // 
            this.capacityRatio_textBox.Location = new System.Drawing.Point(339, 64);
            this.capacityRatio_textBox.Name = "capacityRatio_textBox";
            this.capacityRatio_textBox.Size = new System.Drawing.Size(209, 20);
            this.capacityRatio_textBox.TabIndex = 6;
            this.capacityRatio_textBox.TextChanged += new System.EventHandler(this.capacityRatio_textBox_TextChanged);
            // 
            // model_textBox
            // 
            this.model_textBox.Location = new System.Drawing.Point(339, 182);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(209, 20);
            this.model_textBox.TabIndex = 7;
            this.model_textBox.TextChanged += new System.EventHandler(this.model_textBox_TextChanged);
            // 
            // cph_textBox
            // 
            this.cph_textBox.Location = new System.Drawing.Point(339, 126);
            this.cph_textBox.Name = "cph_textBox";
            this.cph_textBox.Size = new System.Drawing.Size(209, 20);
            this.cph_textBox.TabIndex = 8;
            this.cph_textBox.TextChanged += new System.EventHandler(this.cph_textBox_TextChanged);
            // 
            // totalcapacity_textBox
            // 
            this.totalcapacity_textBox.Location = new System.Drawing.Point(339, 239);
            this.totalcapacity_textBox.Name = "totalcapacity_textBox";
            this.totalcapacity_textBox.Size = new System.Drawing.Size(209, 20);
            this.totalcapacity_textBox.TabIndex = 9;
            this.totalcapacity_textBox.TextChanged += new System.EventHandler(this.totalcapacity_textBox_TextChanged);
            // 
            // airline_textBox
            // 
            this.airline_textBox.Location = new System.Drawing.Point(339, 298);
            this.airline_textBox.Name = "airline_textBox";
            this.airline_textBox.Size = new System.Drawing.Size(209, 20);
            this.airline_textBox.TabIndex = 10;
            this.airline_textBox.TextChanged += new System.EventHandler(this.airline_textBox_TextChanged);
            // 
            // idShow_label
            // 
            this.idShow_label.AutoSize = true;
            this.idShow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idShow_label.Location = new System.Drawing.Point(334, 346);
            this.idShow_label.Name = "idShow_label";
            this.idShow_label.Size = new System.Drawing.Size(38, 25);
            this.idShow_label.TabIndex = 11;
            this.idShow_label.Text = "ID:";
            this.idShow_label.Click += new System.EventHandler(this.idShow_label_Click);
            // 
            // AS_aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idShow_label);
            this.Controls.Add(this.airline_textBox);
            this.Controls.Add(this.totalcapacity_textBox);
            this.Controls.Add(this.cph_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.capacityRatio_textBox);
            this.Controls.Add(this.aircraftID_label);
            this.Controls.Add(this.airline_label);
            this.Controls.Add(this.totalCapacity_label);
            this.Controls.Add(this.model_label);
            this.Controls.Add(this.CPH_label);
            this.Controls.Add(this.capacityRatio_label);
            this.Name = "AS_aircraft";
            this.Text = "AS_aircraft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_aircraft_FormClosing);
            this.Load += new System.EventHandler(this.AS_aircraft_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label capacityRatio_label;
        private System.Windows.Forms.Label CPH_label;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.Label totalCapacity_label;
        private System.Windows.Forms.Label airline_label;
        private System.Windows.Forms.Label aircraftID_label;
        private System.Windows.Forms.TextBox capacityRatio_textBox;
        private System.Windows.Forms.TextBox model_textBox;
        private System.Windows.Forms.TextBox cph_textBox;
        private System.Windows.Forms.TextBox totalcapacity_textBox;
        private System.Windows.Forms.TextBox airline_textBox;
        private System.Windows.Forms.Label idShow_label;
    }
}