namespace DATABASE_PROJECT
{
    partial class AS_AllEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_AllEmployee));
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_EmpID = new System.Windows.Forms.TextBox();
            this.labelEMPID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDLT = new System.Windows.Forms.Button();
            this.label_TotalEmp = new System.Windows.Forms.Label();
            this.label_currEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(219, 506);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 310);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_EmpID
            // 
            this.textBox_EmpID.BackColor = System.Drawing.Color.LightGray;
            this.textBox_EmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EmpID.Location = new System.Drawing.Point(47, 440);
            this.textBox_EmpID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EmpID.Name = "textBox_EmpID";
            this.textBox_EmpID.Size = new System.Drawing.Size(225, 22);
            this.textBox_EmpID.TabIndex = 83;
            this.textBox_EmpID.TextChanged += new System.EventHandler(this.textBox_EmpID_TextChanged);
            // 
            // labelEMPID
            // 
            this.labelEMPID.AutoSize = true;
            this.labelEMPID.BackColor = System.Drawing.Color.Transparent;
            this.labelEMPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMPID.Location = new System.Drawing.Point(47, 415);
            this.labelEMPID.Name = "labelEMPID";
            this.labelEMPID.Size = new System.Drawing.Size(168, 22);
            this.labelEMPID.TabIndex = 82;
            this.labelEMPID.Text = "Delete Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 48);
            this.label1.TabIndex = 84;
            this.label1.Text = "ALL EMPLOYEE";
            // 
            // buttonDLT
            // 
            this.buttonDLT.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDLT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDLT.BackgroundImage")));
            this.buttonDLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDLT.Location = new System.Drawing.Point(299, 506);
            this.buttonDLT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDLT.Name = "buttonDLT";
            this.buttonDLT.Size = new System.Drawing.Size(85, 48);
            this.buttonDLT.TabIndex = 85;
            this.buttonDLT.Text = "Delete";
            this.buttonDLT.UseVisualStyleBackColor = false;
            this.buttonDLT.Click += new System.EventHandler(this.buttonDLT_Click);
            // 
            // label_TotalEmp
            // 
            this.label_TotalEmp.AutoSize = true;
            this.label_TotalEmp.BackColor = System.Drawing.Color.Transparent;
            this.label_TotalEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalEmp.Location = new System.Drawing.Point(310, 418);
            this.label_TotalEmp.Name = "label_TotalEmp";
            this.label_TotalEmp.Size = new System.Drawing.Size(195, 22);
            this.label_TotalEmp.TabIndex = 90;
            this.label_TotalEmp.Text = "Total Employee            ";
            // 
            // label_currEmp
            // 
            this.label_currEmp.AutoSize = true;
            this.label_currEmp.BackColor = System.Drawing.Color.Transparent;
            this.label_currEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currEmp.Location = new System.Drawing.Point(310, 440);
            this.label_currEmp.Name = "label_currEmp";
            this.label_currEmp.Size = new System.Drawing.Size(189, 22);
            this.label_currEmp.TabIndex = 91;
            this.label_currEmp.Text = "Current Employee       ";
            // 
            // AS_AllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_currEmp);
            this.Controls.Add(this.label_TotalEmp);
            this.Controls.Add(this.buttonDLT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_EmpID);
            this.Controls.Add(this.labelEMPID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Name = "AS_AllEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AS_AllEmployee_FormClosing);
            this.Load += new System.EventHandler(this.AS_AllEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_EmpID;
        private System.Windows.Forms.Label labelEMPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDLT;
        private System.Windows.Forms.Label label_TotalEmp;
        private System.Windows.Forms.Label label_currEmp;
    }
}