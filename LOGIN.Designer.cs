namespace DATABASE_PROJECT
{
    partial class LOGIN
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
            this.login_headline_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox_login_email = new System.Windows.Forms.TextBox();
            this.textBox_login_password = new System.Windows.Forms.TextBox();
            this.signUp_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_headline_label
            // 
            this.login_headline_label.AutoSize = true;
            this.login_headline_label.BackColor = System.Drawing.Color.Transparent;
            this.login_headline_label.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_headline_label.Location = new System.Drawing.Point(118, 28);
            this.login_headline_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.login_headline_label.Name = "login_headline_label";
            this.login_headline_label.Size = new System.Drawing.Size(224, 38);
            this.login_headline_label.TabIndex = 0;
            this.login_headline_label.Text = "A.T Airlines";
            this.login_headline_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.Location = new System.Drawing.Point(135, 178);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(45, 18);
            this.email_label.TabIndex = 1;
            this.email_label.Text = "Email";
            this.email_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(135, 229);
            this.password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 18);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_login_email
            // 
            this.textBox_login_email.BackColor = System.Drawing.Color.White;
            this.textBox_login_email.Location = new System.Drawing.Point(138, 198);
            this.textBox_login_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_login_email.Multiline = true;
            this.textBox_login_email.Name = "textBox_login_email";
            this.textBox_login_email.Size = new System.Drawing.Size(170, 19);
            this.textBox_login_email.TabIndex = 3;
            this.textBox_login_email.TextChanged += new System.EventHandler(this.TB_email_TextChanged);
            // 
            // textBox_login_password
            // 
            this.textBox_login_password.BackColor = System.Drawing.Color.White;
            this.textBox_login_password.Location = new System.Drawing.Point(138, 249);
            this.textBox_login_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_login_password.Name = "textBox_login_password";
            this.textBox_login_password.Size = new System.Drawing.Size(170, 20);
            this.textBox_login_password.TabIndex = 4;
            this.textBox_login_password.TextChanged += new System.EventHandler(this.textBox_login_password_TextChanged);
            this.textBox_login_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_login_password_KeyPress);
            // 
            // signUp_button
            // 
            this.signUp_button.BackColor = System.Drawing.Color.White;
            this.signUp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signUp_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(229, 297);
            this.signUp_button.Margin = new System.Windows.Forms.Padding(2);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(78, 28);
            this.signUp_button.TabIndex = 6;
            this.signUp_button.Text = "SIGN UP";
            this.signUp_button.UseVisualStyleBackColor = false;
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(138, 297);
            this.login_button.Margin = new System.Windows.Forms.Padding(2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(78, 28);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "LOG IN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(454, 468);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.textBox_login_password);
            this.Controls.Add(this.textBox_login_email);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.login_headline_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LOGIN";
            this.Text = "A.T Airline";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_headline_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox_login_email;
        private System.Windows.Forms.TextBox textBox_login_password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signUp_button;
    }
}

