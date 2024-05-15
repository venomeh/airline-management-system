namespace DATABASE_PROJECT
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.button_assignments = new System.Windows.Forms.Button();
            this.label_displayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Welcome,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "A.T Airlines";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(189, 423);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(227, 48);
            this.button_logout.TabIndex = 15;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_profile
            // 
            this.button_profile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_profile.BackgroundImage")));
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.Location = new System.Drawing.Point(189, 370);
            this.button_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(227, 48);
            this.button_profile.TabIndex = 13;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_assignments
            // 
            this.button_assignments.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_assignments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_assignments.BackgroundImage")));
            this.button_assignments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_assignments.Location = new System.Drawing.Point(189, 316);
            this.button_assignments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_assignments.Name = "button_assignments";
            this.button_assignments.Size = new System.Drawing.Size(227, 48);
            this.button_assignments.TabIndex = 14;
            this.button_assignments.Text = "Assignments";
            this.button_assignments.UseVisualStyleBackColor = false;
            this.button_assignments.Click += new System.EventHandler(this.button_assignments_Click);
            // 
            // label_displayName
            // 
            this.label_displayName.AutoSize = true;
            this.label_displayName.BackColor = System.Drawing.Color.Transparent;
            this.label_displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayName.Location = new System.Drawing.Point(293, 165);
            this.label_displayName.Name = "label_displayName";
            this.label_displayName.Size = new System.Drawing.Size(65, 25);
            this.label_displayName.TabIndex = 16;
            this.label_displayName.Text = "name";
            this.label_displayName.Click += new System.EventHandler(this.label_displayName_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_displayName);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_assignments);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_assignments;
        private System.Windows.Forms.Label label_displayName;
    }
}