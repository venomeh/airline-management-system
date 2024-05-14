namespace DATABASE_PROJECT
{
    partial class AS_revenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_revenue));
            this.aircraftId_label = new System.Windows.Forms.Label();
            this.flightID_label = new System.Windows.Forms.Label();
            this.revenueGenerated_label = new System.Windows.Forms.Label();
            this.aircraft_comboBox = new System.Windows.Forms.ComboBox();
            this.flightid_comboBox = new System.Windows.Forms.ComboBox();
            this.showRevenue = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.bookingGrid = new System.Windows.Forms.DataGridView();
            this.button_generatePDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // aircraftId_label
            // 
            this.aircraftId_label.AutoSize = true;
            this.aircraftId_label.BackColor = System.Drawing.Color.Transparent;
            this.aircraftId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftId_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.aircraftId_label.Location = new System.Drawing.Point(23, 307);
            this.aircraftId_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aircraftId_label.Name = "aircraftId_label";
            this.aircraftId_label.Size = new System.Drawing.Size(136, 31);
            this.aircraftId_label.TabIndex = 1;
            this.aircraftId_label.Text = "Aircraft ID";
            this.aircraftId_label.Click += new System.EventHandler(this.aircraftId_label_Click);
            // 
            // flightID_label
            // 
            this.flightID_label.AutoSize = true;
            this.flightID_label.BackColor = System.Drawing.Color.Transparent;
            this.flightID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightID_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.flightID_label.Location = new System.Drawing.Point(23, 363);
            this.flightID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flightID_label.Name = "flightID_label";
            this.flightID_label.Size = new System.Drawing.Size(116, 31);
            this.flightID_label.TabIndex = 2;
            this.flightID_label.Text = "Flight ID";
            this.flightID_label.Click += new System.EventHandler(this.flightID_label_Click);
            // 
            // revenueGenerated_label
            // 
            this.revenueGenerated_label.AutoSize = true;
            this.revenueGenerated_label.BackColor = System.Drawing.Color.Transparent;
            this.revenueGenerated_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueGenerated_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.revenueGenerated_label.Location = new System.Drawing.Point(23, 413);
            this.revenueGenerated_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.revenueGenerated_label.Name = "revenueGenerated_label";
            this.revenueGenerated_label.Size = new System.Drawing.Size(258, 31);
            this.revenueGenerated_label.TabIndex = 5;
            this.revenueGenerated_label.Text = "Revenue Generated";
            this.revenueGenerated_label.Click += new System.EventHandler(this.revenueGenerated_label_Click);
            // 
            // aircraft_comboBox
            // 
            this.aircraft_comboBox.FormattingEnabled = true;
            this.aircraft_comboBox.Location = new System.Drawing.Point(331, 309);
            this.aircraft_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.aircraft_comboBox.Name = "aircraft_comboBox";
            this.aircraft_comboBox.Size = new System.Drawing.Size(248, 24);
            this.aircraft_comboBox.TabIndex = 7;
            this.aircraft_comboBox.SelectedIndexChanged += new System.EventHandler(this.airline_comboBox_SelectedIndexChanged);
            // 
            // flightid_comboBox
            // 
            this.flightid_comboBox.FormattingEnabled = true;
            this.flightid_comboBox.Items.AddRange(new object[] {
            "SELECT AIRCRAFT ID FIRST"});
            this.flightid_comboBox.Location = new System.Drawing.Point(331, 365);
            this.flightid_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.flightid_comboBox.Name = "flightid_comboBox";
            this.flightid_comboBox.Size = new System.Drawing.Size(248, 24);
            this.flightid_comboBox.TabIndex = 9;
            this.flightid_comboBox.SelectedIndexChanged += new System.EventHandler(this.flightid_comboBox_SelectedIndexChanged);
            // 
            // showRevenue
            // 
            this.showRevenue.AutoSize = true;
            this.showRevenue.BackColor = System.Drawing.Color.Transparent;
            this.showRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRevenue.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.showRevenue.Location = new System.Drawing.Point(344, 413);
            this.showRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showRevenue.Name = "showRevenue";
            this.showRevenue.Size = new System.Drawing.Size(29, 31);
            this.showRevenue.TabIndex = 10;
            this.showRevenue.Text = "0";
            this.showRevenue.Click += new System.EventHandler(this.revenueGeneratedOut_label_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(188, 505);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // bookingGrid
            // 
            this.bookingGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.bookingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGrid.Location = new System.Drawing.Point(27, 93);
            this.bookingGrid.Name = "bookingGrid";
            this.bookingGrid.RowHeadersWidth = 51;
            this.bookingGrid.RowTemplate.Height = 24;
            this.bookingGrid.Size = new System.Drawing.Size(552, 186);
            this.bookingGrid.TabIndex = 82;
            // 
            // button_generatePDF
            // 
            this.button_generatePDF.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_generatePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_generatePDF.BackgroundImage")));
            this.button_generatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generatePDF.Location = new System.Drawing.Point(188, 456);
            this.button_generatePDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_generatePDF.Name = "button_generatePDF";
            this.button_generatePDF.Size = new System.Drawing.Size(227, 48);
            this.button_generatePDF.TabIndex = 83;
            this.button_generatePDF.Text = "PDF";
            this.button_generatePDF.UseVisualStyleBackColor = false;
            this.button_generatePDF.Click += new System.EventHandler(this.button_generatePDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 48);
            this.label1.TabIndex = 84;
            this.label1.Text = "REVENUE";
            // 
            // AS_revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_generatePDF);
            this.Controls.Add(this.bookingGrid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.showRevenue);
            this.Controls.Add(this.flightid_comboBox);
            this.Controls.Add(this.aircraft_comboBox);
            this.Controls.Add(this.revenueGenerated_label);
            this.Controls.Add(this.flightID_label);
            this.Controls.Add(this.aircraftId_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AS_revenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AS_revenue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_revenue_FormClosing);
            this.Load += new System.EventHandler(this.AS_revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aircraftId_label;
        private System.Windows.Forms.Label flightID_label;
        private System.Windows.Forms.Label revenueGenerated_label;
        private System.Windows.Forms.ComboBox aircraft_comboBox;
        private System.Windows.Forms.ComboBox flightid_comboBox;
        private System.Windows.Forms.Label showRevenue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView bookingGrid;
        private System.Windows.Forms.Button button_generatePDF;
        private System.Windows.Forms.Label label1;
    }
}