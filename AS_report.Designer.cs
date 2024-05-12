namespace DATABASE_PROJECT
{
    partial class AS_report
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
            this.aircraftId_label = new System.Windows.Forms.Label();
            this.aircraftID_combobox = new System.Windows.Forms.ComboBox();
            this.maintainanceCost_label = new System.Windows.Forms.Label();
            this.end_date_label = new System.Windows.Forms.Label();
            this.start_Date_label = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.yesRadio_btn = new System.Windows.Forms.RadioButton();
            this.no_radiobtn = new System.Windows.Forms.RadioButton();
            this.idFetch_label = new System.Windows.Forms.Label();
            this.maintainanceID_label = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.numericCostCounter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCostCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // aircraftId_label
            // 
            this.aircraftId_label.AutoSize = true;
            this.aircraftId_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aircraftId_label.Location = new System.Drawing.Point(174, 52);
            this.aircraftId_label.Name = "aircraftId_label";
            this.aircraftId_label.Size = new System.Drawing.Size(103, 25);
            this.aircraftId_label.TabIndex = 0;
            this.aircraftId_label.Text = "Aircraft Id";
            this.aircraftId_label.Click += new System.EventHandler(this.aircraftId_label_Click);
            // 
            // aircraftID_combobox
            // 
            this.aircraftID_combobox.FormattingEnabled = true;
            this.aircraftID_combobox.Location = new System.Drawing.Point(324, 52);
            this.aircraftID_combobox.Name = "aircraftID_combobox";
            this.aircraftID_combobox.Size = new System.Drawing.Size(226, 21);
            this.aircraftID_combobox.TabIndex = 1;
            this.aircraftID_combobox.Text = "ID\'s";
            this.aircraftID_combobox.SelectedIndexChanged += new System.EventHandler(this.aircraftID_combobox_SelectedIndexChanged);
            // 
            // maintainanceCost_label
            // 
            this.maintainanceCost_label.AutoSize = true;
            this.maintainanceCost_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainanceCost_label.Location = new System.Drawing.Point(41, 289);
            this.maintainanceCost_label.Name = "maintainanceCost_label";
            this.maintainanceCost_label.Size = new System.Drawing.Size(56, 25);
            this.maintainanceCost_label.TabIndex = 2;
            this.maintainanceCost_label.Text = "Cost";
            // 
            // end_date_label
            // 
            this.end_date_label.AutoSize = true;
            this.end_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date_label.Location = new System.Drawing.Point(369, 170);
            this.end_date_label.Name = "end_date_label";
            this.end_date_label.Size = new System.Drawing.Size(101, 25);
            this.end_date_label.TabIndex = 3;
            this.end_date_label.Text = "End Date";
            // 
            // start_Date_label
            // 
            this.start_Date_label.AutoSize = true;
            this.start_Date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_Date_label.Location = new System.Drawing.Point(21, 172);
            this.start_Date_label.Name = "start_Date_label";
            this.start_Date_label.Size = new System.Drawing.Size(108, 25);
            this.start_Date_label.TabIndex = 4;
            this.start_Date_label.Text = "Start Date";
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_label.Location = new System.Drawing.Point(319, 289);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(73, 25);
            this.Status_label.TabIndex = 5;
            this.Status_label.Text = "Status";
            // 
            // yesRadio_btn
            // 
            this.yesRadio_btn.AutoSize = true;
            this.yesRadio_btn.Location = new System.Drawing.Point(412, 296);
            this.yesRadio_btn.Name = "yesRadio_btn";
            this.yesRadio_btn.Size = new System.Drawing.Size(32, 17);
            this.yesRadio_btn.TabIndex = 6;
            this.yesRadio_btn.TabStop = true;
            this.yesRadio_btn.Text = "Y";
            this.yesRadio_btn.UseVisualStyleBackColor = true;
            // 
            // no_radiobtn
            // 
            this.no_radiobtn.AutoSize = true;
            this.no_radiobtn.Location = new System.Drawing.Point(450, 296);
            this.no_radiobtn.Name = "no_radiobtn";
            this.no_radiobtn.Size = new System.Drawing.Size(33, 17);
            this.no_radiobtn.TabIndex = 7;
            this.no_radiobtn.TabStop = true;
            this.no_radiobtn.Text = "N";
            this.no_radiobtn.UseVisualStyleBackColor = true;
            // 
            // idFetch_label
            // 
            this.idFetch_label.AutoSize = true;
            this.idFetch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFetch_label.Location = new System.Drawing.Point(363, 365);
            this.idFetch_label.Name = "idFetch_label";
            this.idFetch_label.Size = new System.Drawing.Size(29, 25);
            this.idFetch_label.TabIndex = 8;
            this.idFetch_label.Text = "id";
            // 
            // maintainanceID_label
            // 
            this.maintainanceID_label.AutoSize = true;
            this.maintainanceID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintainanceID_label.Location = new System.Drawing.Point(174, 365);
            this.maintainanceID_label.Name = "maintainanceID_label";
            this.maintainanceID_label.Size = new System.Drawing.Size(167, 25);
            this.maintainanceID_label.TabIndex = 9;
            this.maintainanceID_label.Text = "Maintainance ID";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(135, 175);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 10;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(476, 175);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 20);
            this.endTime.TabIndex = 11;
            // 
            // numericCostCounter
            // 
            this.numericCostCounter.Location = new System.Drawing.Point(115, 289);
            this.numericCostCounter.Name = "numericCostCounter";
            this.numericCostCounter.Size = new System.Drawing.Size(120, 20);
            this.numericCostCounter.TabIndex = 12;
            this.numericCostCounter.ValueChanged += new System.EventHandler(this.numericCostCounter_ValueChanged);
            // 
            // AS_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.numericCostCounter);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.maintainanceID_label);
            this.Controls.Add(this.idFetch_label);
            this.Controls.Add(this.no_radiobtn);
            this.Controls.Add(this.yesRadio_btn);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.start_Date_label);
            this.Controls.Add(this.end_date_label);
            this.Controls.Add(this.maintainanceCost_label);
            this.Controls.Add(this.aircraftID_combobox);
            this.Controls.Add(this.aircraftId_label);
            this.Name = "AS_report";
            this.Text = "AS_report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_report_FormClosing);
            this.Load += new System.EventHandler(this.AS_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCostCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aircraftId_label;
        private System.Windows.Forms.ComboBox aircraftID_combobox;
        private System.Windows.Forms.Label maintainanceCost_label;
        private System.Windows.Forms.Label end_date_label;
        private System.Windows.Forms.Label start_Date_label;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.RadioButton yesRadio_btn;
        private System.Windows.Forms.RadioButton no_radiobtn;
        private System.Windows.Forms.Label idFetch_label;
        private System.Windows.Forms.Label maintainanceID_label;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.NumericUpDown numericCostCounter;
    }
}