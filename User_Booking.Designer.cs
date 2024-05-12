namespace DATABASE_PROJECT
{
    partial class User_Booking
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
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_flight_status = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flight_status)).BeginInit();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._53;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(189, 494);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(227, 48);
            this.button_back.TabIndex = 54;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView_flight_status
            // 
            this.dataGridView_flight_status.AllowUserToAddRows = false;
            this.dataGridView_flight_status.AllowUserToDeleteRows = false;
            this.dataGridView_flight_status.AllowUserToResizeColumns = false;
            this.dataGridView_flight_status.AllowUserToResizeRows = false;
            this.dataGridView_flight_status.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_flight_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_flight_status.Location = new System.Drawing.Point(22, 51);
            this.dataGridView_flight_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_flight_status.Name = "dataGridView_flight_status";
            this.dataGridView_flight_status.RowHeadersWidth = 51;
            this.dataGridView_flight_status.RowTemplate.Height = 24;
            this.dataGridView_flight_status.Size = new System.Drawing.Size(556, 426);
            this.dataGridView_flight_status.TabIndex = 55;
            this.dataGridView_flight_status.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_flight_status_CellContentClick);
            // 
            // User_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.dataGridView_flight_status);
            this.Controls.Add(this.button_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Booking";
            this.Text = "User_Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Booking_FormClosing);
            this.Load += new System.EventHandler(this.User_Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_flight_status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_flight_status;
    }
}