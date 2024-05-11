namespace DATABASE_PROJECT
{
    partial class SignUp
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
            this.textBox_confirmPass = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_confirmPass = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_phoneNo = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label2_phoneNO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signUp_button = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.CNIC_label = new System.Windows.Forms.Label();
            this.cnic_txtbox = new System.Windows.Forms.TextBox();
            this.label_firstName = new System.Windows.Forms.Label();
            this.labl_lastName = new System.Windows.Forms.Label();
            this.textBox_confirmOTP = new System.Windows.Forms.TextBox();
            this.label_OTP = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.button_getOTP = new System.Windows.Forms.Button();
            this.label_passwordNotMatch = new System.Windows.Forms.Label();
            this.label_passwordCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_confirmPass
            // 
            this.textBox_confirmPass.BackColor = System.Drawing.Color.LightGray;
            this.textBox_confirmPass.Location = new System.Drawing.Point(61, 410);
            this.textBox_confirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_confirmPass.Name = "textBox_confirmPass";
            this.textBox_confirmPass.Size = new System.Drawing.Size(225, 22);
            this.textBox_confirmPass.TabIndex = 93;
            this.textBox_confirmPass.TextChanged += new System.EventHandler(this.textBox_confirmPass_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.BackColor = System.Drawing.Color.LightGray;
            this.textBox_email.Location = new System.Drawing.Point(320, 232);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(225, 22);
            this.textBox_email.TabIndex = 91;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_confirmPass
            // 
            this.label_confirmPass.AutoSize = true;
            this.label_confirmPass.BackColor = System.Drawing.Color.Transparent;
            this.label_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirmPass.Location = new System.Drawing.Point(57, 385);
            this.label_confirmPass.Name = "label_confirmPass";
            this.label_confirmPass.Size = new System.Drawing.Size(156, 22);
            this.label_confirmPass.TabIndex = 90;
            this.label_confirmPass.Text = "Confirm Password";
            this.label_confirmPass.Click += new System.EventHandler(this.label_confirmPass_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(316, 296);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(89, 22);
            this.label_password.TabIndex = 89;
            this.label_password.Text = "Password";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // textBox_phoneNo
            // 
            this.textBox_phoneNo.BackColor = System.Drawing.Color.LightGray;
            this.textBox_phoneNo.Location = new System.Drawing.Point(61, 232);
            this.textBox_phoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_phoneNo.Name = "textBox_phoneNo";
            this.textBox_phoneNo.Size = new System.Drawing.Size(225, 22);
            this.textBox_phoneNo.TabIndex = 87;
            this.textBox_phoneNo.TextChanged += new System.EventHandler(this.textBox_phoneNo_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Transparent;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(316, 207);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(54, 22);
            this.label_email.TabIndex = 86;
            this.label_email.Text = "Email";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // label2_phoneNO
            // 
            this.label2_phoneNO.AutoSize = true;
            this.label2_phoneNO.BackColor = System.Drawing.Color.Transparent;
            this.label2_phoneNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_phoneNO.Location = new System.Drawing.Point(57, 207);
            this.label2_phoneNO.Name = "label2_phoneNO";
            this.label2_phoneNO.Size = new System.Drawing.Size(130, 22);
            this.label2_phoneNO.TabIndex = 85;
            this.label2_phoneNO.Text = "Phone Number";
            this.label2_phoneNO.Click += new System.EventHandler(this.label2_phoneNO_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 48);
            this.label5.TabIndex = 84;
            this.label5.Text = "A.T Airlines";
            // 
            // signUp_button
            // 
            this.signUp_button.BackColor = System.Drawing.Color.Transparent;
            this.signUp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signUp_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.signUp_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(189, 519);
            this.signUp_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(107, 34);
            this.signUp_button.TabIndex = 88;
            this.signUp_button.Text = "SIGN UP";
            this.signUp_button.UseVisualStyleBackColor = false;
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(320, 519);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(107, 34);
            this.button_back.TabIndex = 94;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.LightGray;
            this.textBox_password.Location = new System.Drawing.Point(320, 322);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(225, 22);
            this.textBox_password.TabIndex = 92;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // CNIC_label
            // 
            this.CNIC_label.AutoSize = true;
            this.CNIC_label.BackColor = System.Drawing.Color.Transparent;
            this.CNIC_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNIC_label.Location = new System.Drawing.Point(57, 298);
            this.CNIC_label.Name = "CNIC_label";
            this.CNIC_label.Size = new System.Drawing.Size(53, 22);
            this.CNIC_label.TabIndex = 95;
            this.CNIC_label.Text = "CNIC";
            this.CNIC_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // cnic_txtbox
            // 
            this.cnic_txtbox.BackColor = System.Drawing.Color.LightGray;
            this.cnic_txtbox.Location = new System.Drawing.Point(61, 322);
            this.cnic_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnic_txtbox.Name = "cnic_txtbox";
            this.cnic_txtbox.Size = new System.Drawing.Size(225, 22);
            this.cnic_txtbox.TabIndex = 96;
            this.cnic_txtbox.TextChanged += new System.EventHandler(this.cnic_txtbox_TextChanged);
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.BackColor = System.Drawing.Color.Transparent;
            this.label_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(57, 119);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(97, 22);
            this.label_firstName.TabIndex = 97;
            this.label_firstName.Text = "First Name";
            this.label_firstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labl_lastName
            // 
            this.labl_lastName.AutoSize = true;
            this.labl_lastName.BackColor = System.Drawing.Color.Transparent;
            this.labl_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_lastName.Location = new System.Drawing.Point(316, 119);
            this.labl_lastName.Name = "labl_lastName";
            this.labl_lastName.Size = new System.Drawing.Size(96, 22);
            this.labl_lastName.TabIndex = 100;
            this.labl_lastName.Text = "Last Name";
            // 
            // textBox_confirmOTP
            // 
            this.textBox_confirmOTP.BackColor = System.Drawing.Color.LightGray;
            this.textBox_confirmOTP.Location = new System.Drawing.Point(320, 410);
            this.textBox_confirmOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_confirmOTP.Name = "textBox_confirmOTP";
            this.textBox_confirmOTP.Size = new System.Drawing.Size(225, 22);
            this.textBox_confirmOTP.TabIndex = 103;
            this.textBox_confirmOTP.TextChanged += new System.EventHandler(this.textBox_confirmOTP_TextChanged);
            // 
            // label_OTP
            // 
            this.label_OTP.AutoSize = true;
            this.label_OTP.BackColor = System.Drawing.Color.Transparent;
            this.label_OTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OTP.Location = new System.Drawing.Point(316, 386);
            this.label_OTP.Name = "label_OTP";
            this.label_OTP.Size = new System.Drawing.Size(115, 22);
            this.label_OTP.TabIndex = 102;
            this.label_OTP.Text = "Confirm OTP";
            this.label_OTP.Click += new System.EventHandler(this.label_OTP_Click);
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.BackColor = System.Drawing.Color.LightGray;
            this.textBox_firstName.Location = new System.Drawing.Point(61, 144);
            this.textBox_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(225, 22);
            this.textBox_firstName.TabIndex = 104;
            this.textBox_firstName.TextChanged += new System.EventHandler(this.textBox_firstName_TextChanged);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.BackColor = System.Drawing.Color.LightGray;
            this.textBox_lastName.Location = new System.Drawing.Point(320, 144);
            this.textBox_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(225, 22);
            this.textBox_lastName.TabIndex = 105;
            this.textBox_lastName.TextChanged += new System.EventHandler(this.textBox_lastName_TextChanged);
            // 
            // button_getOTP
            // 
            this.button_getOTP.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._7;
            this.button_getOTP.Location = new System.Drawing.Point(470, 437);
            this.button_getOTP.Name = "button_getOTP";
            this.button_getOTP.Size = new System.Drawing.Size(75, 23);
            this.button_getOTP.TabIndex = 106;
            this.button_getOTP.Text = "Get OTP";
            this.button_getOTP.UseVisualStyleBackColor = true;
            this.button_getOTP.Click += new System.EventHandler(this.button_getOTP_Click);
            // 
            // label_passwordNotMatch
            // 
            this.label_passwordNotMatch.AutoSize = true;
            this.label_passwordNotMatch.Location = new System.Drawing.Point(67, 437);
            this.label_passwordNotMatch.Name = "label_passwordNotMatch";
            this.label_passwordNotMatch.Size = new System.Drawing.Size(10, 16);
            this.label_passwordNotMatch.TabIndex = 107;
            this.label_passwordNotMatch.Text = ".";
            this.label_passwordNotMatch.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label_passwordCheck
            // 
            this.label_passwordCheck.AutoSize = true;
            this.label_passwordCheck.Location = new System.Drawing.Point(411, 301);
            this.label_passwordCheck.Name = "label_passwordCheck";
            this.label_passwordCheck.Size = new System.Drawing.Size(10, 16);
            this.label_passwordCheck.TabIndex = 113;
            this.label_passwordCheck.Text = ".";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.label_passwordCheck);
            this.Controls.Add(this.label_passwordNotMatch);
            this.Controls.Add(this.button_getOTP);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.textBox_confirmOTP);
            this.Controls.Add(this.label_OTP);
            this.Controls.Add(this.labl_lastName);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.cnic_txtbox);
            this.Controls.Add(this.CNIC_label);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_confirmPass);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_confirmPass);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.textBox_phoneNo);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label2_phoneNO);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.Text = "User_SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_confirmPass;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_confirmPass;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.TextBox textBox_phoneNo;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label2_phoneNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label CNIC_label;
        private System.Windows.Forms.TextBox cnic_txtbox;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label labl_lastName;
        private System.Windows.Forms.TextBox textBox_confirmOTP;
        private System.Windows.Forms.Label label_OTP;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Button button_getOTP;
        private System.Windows.Forms.Label label_passwordNotMatch;
        private System.Windows.Forms.Label label_passwordCheck;
    }
}