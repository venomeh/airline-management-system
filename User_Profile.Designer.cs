namespace DATABASE_PROJECT
{
    partial class User_Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.cnic_label = new System.Windows.Forms.Label();
            this.btn_edit_profile = new System.Windows.Forms.Button();
            this.btn_del_profile = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label_displayName = new System.Windows.Forms.Label();
            this.label_displayCNIC = new System.Windows.Forms.Label();
            this.label_displayEmail = new System.Windows.Forms.Label();
            this.label_displayPhoneNo = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label_displayPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 49;
            this.label1.Text = "A.T Airlines";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(153, 144);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(62, 22);
            this.name_label.TabIndex = 52;
            this.name_label.Text = "Name:";
            this.name_label.Click += new System.EventHandler(this.name_label_Click);
            // 
            // cnic_label
            // 
            this.cnic_label.AutoSize = true;
            this.cnic_label.BackColor = System.Drawing.Color.Transparent;
            this.cnic_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnic_label.Location = new System.Drawing.Point(153, 191);
            this.cnic_label.Name = "cnic_label";
            this.cnic_label.Size = new System.Drawing.Size(58, 22);
            this.cnic_label.TabIndex = 53;
            this.cnic_label.Text = "CNIC:";
            this.cnic_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_edit_profile
            // 
            this.btn_edit_profile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_edit_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_profile.Location = new System.Drawing.Point(179, 384);
            this.btn_edit_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit_profile.Name = "btn_edit_profile";
            this.btn_edit_profile.Size = new System.Drawing.Size(227, 48);
            this.btn_edit_profile.TabIndex = 51;
            this.btn_edit_profile.Text = "Edit Profile";
            this.btn_edit_profile.UseVisualStyleBackColor = false;
            // 
            // btn_del_profile
            // 
            this.btn_del_profile.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_del_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del_profile.Location = new System.Drawing.Point(179, 438);
            this.btn_del_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_del_profile.Name = "btn_del_profile";
            this.btn_del_profile.Size = new System.Drawing.Size(227, 48);
            this.btn_del_profile.TabIndex = 56;
            this.btn_del_profile.Text = "Delete Profile";
            this.btn_del_profile.UseVisualStyleBackColor = false;
            this.btn_del_profile.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(153, 236);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(59, 22);
            this.email_label.TabIndex = 57;
            this.email_label.Text = "Email:";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(153, 284);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(77, 22);
            this.phone_label.TabIndex = 58;
            this.phone_label.Text = "Phone #";
            this.phone_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(179, 492);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 59;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_displayName
            // 
            this.label_displayName.AutoSize = true;
            this.label_displayName.BackColor = System.Drawing.Color.Transparent;
            this.label_displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayName.Location = new System.Drawing.Point(253, 144);
            this.label_displayName.Name = "label_displayName";
            this.label_displayName.Size = new System.Drawing.Size(66, 22);
            this.label_displayName.TabIndex = 60;
            this.label_displayName.Text = "display";
            this.label_displayName.Click += new System.EventHandler(this.label_displayName_Click);
            // 
            // label_displayCNIC
            // 
            this.label_displayCNIC.AutoSize = true;
            this.label_displayCNIC.BackColor = System.Drawing.Color.Transparent;
            this.label_displayCNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayCNIC.Location = new System.Drawing.Point(253, 191);
            this.label_displayCNIC.Name = "label_displayCNIC";
            this.label_displayCNIC.Size = new System.Drawing.Size(66, 22);
            this.label_displayCNIC.TabIndex = 61;
            this.label_displayCNIC.Text = "display";
            this.label_displayCNIC.Click += new System.EventHandler(this.label_displayCNIC_Click);
            // 
            // label_displayEmail
            // 
            this.label_displayEmail.AutoSize = true;
            this.label_displayEmail.BackColor = System.Drawing.Color.Transparent;
            this.label_displayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayEmail.Location = new System.Drawing.Point(253, 236);
            this.label_displayEmail.Name = "label_displayEmail";
            this.label_displayEmail.Size = new System.Drawing.Size(66, 22);
            this.label_displayEmail.TabIndex = 62;
            this.label_displayEmail.Text = "dispaly";
            this.label_displayEmail.Click += new System.EventHandler(this.label_displayEmail_Click);
            // 
            // label_displayPhoneNo
            // 
            this.label_displayPhoneNo.AutoSize = true;
            this.label_displayPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.label_displayPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayPhoneNo.Location = new System.Drawing.Point(253, 284);
            this.label_displayPhoneNo.Name = "label_displayPhoneNo";
            this.label_displayPhoneNo.Size = new System.Drawing.Size(66, 22);
            this.label_displayPhoneNo.TabIndex = 63;
            this.label_displayPhoneNo.Text = "display";
            this.label_displayPhoneNo.Click += new System.EventHandler(this.label_displayPhoneNo_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(153, 327);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(94, 22);
            this.password_label.TabIndex = 64;
            this.password_label.Text = "Password:";
            // 
            // label_displayPassword
            // 
            this.label_displayPassword.AutoSize = true;
            this.label_displayPassword.BackColor = System.Drawing.Color.Transparent;
            this.label_displayPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayPassword.Location = new System.Drawing.Point(253, 327);
            this.label_displayPassword.Name = "label_displayPassword";
            this.label_displayPassword.Size = new System.Drawing.Size(66, 22);
            this.label_displayPassword.TabIndex = 65;
            this.label_displayPassword.Text = "display";
            this.label_displayPassword.Click += new System.EventHandler(this.label_displayPassword_Click);
            // 
            // User_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_displayPassword);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.label_displayPhoneNo);
            this.Controls.Add(this.label_displayEmail);
            this.Controls.Add(this.label_displayCNIC);
            this.Controls.Add(this.label_displayName);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.btn_del_profile);
            this.Controls.Add(this.cnic_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.btn_edit_profile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Profile";
            this.Text = "User_Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Profile_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label cnic_label;
        private System.Windows.Forms.Button btn_edit_profile;
        private System.Windows.Forms.Button btn_del_profile;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label_displayName;
        private System.Windows.Forms.Label label_displayCNIC;
        private System.Windows.Forms.Label label_displayEmail;
        private System.Windows.Forms.Label label_displayPhoneNo;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label_displayPassword;
    }
}