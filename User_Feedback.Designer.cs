namespace DATABASE_PROJECT
{
    partial class User_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Feedback));
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Feedback = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_charLeft = new System.Windows.Forms.Label();
            this.Feedback_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 48);
            this.label5.TabIndex = 89;
            this.label5.Text = "FEEDBACK";
            // 
            // textBox_Feedback
            // 
            this.textBox_Feedback.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Feedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Feedback.Location = new System.Drawing.Point(46, 178);
            this.textBox_Feedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Feedback.Multiline = true;
            this.textBox_Feedback.Name = "textBox_Feedback";
            this.textBox_Feedback.Size = new System.Drawing.Size(506, 145);
            this.textBox_Feedback.TabIndex = 87;
            this.textBox_Feedback.TextChanged += new System.EventHandler(this.textBox_Feedback_TextChanged);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_back.BackgroundImage")));
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(192, 475);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(227, 48);
            this.button_back.TabIndex = 88;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_submit.BackgroundImage")));
            this.button_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(192, 421);
            this.button_submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(227, 48);
            this.button_submit.TabIndex = 86;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_charLeft
            // 
            this.label_charLeft.BackColor = System.Drawing.Color.Transparent;
            this.label_charLeft.Location = new System.Drawing.Point(508, 325);
            this.label_charLeft.Name = "label_charLeft";
            this.label_charLeft.Size = new System.Drawing.Size(44, 16);
            this.label_charLeft.TabIndex = 0;
            this.label_charLeft.Click += new System.EventHandler(this.label_charLeft_Click);
            // 
            // Feedback_label
            // 
            this.Feedback_label.AutoSize = true;
            this.Feedback_label.BackColor = System.Drawing.Color.Transparent;
            this.Feedback_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback_label.Location = new System.Drawing.Point(42, 154);
            this.Feedback_label.Name = "Feedback_label";
            this.Feedback_label.Size = new System.Drawing.Size(95, 22);
            this.Feedback_label.TabIndex = 90;
            this.Feedback_label.Text = "Comments";
            // 
            // User_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.Feedback_label);
            this.Controls.Add(this.label_charLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_Feedback);
            this.Controls.Add(this.button_submit);
            this.Name = "User_Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_Feedback_FormClosing);
            this.Load += new System.EventHandler(this.User_Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_Feedback;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_charLeft;
        private System.Windows.Forms.Label Feedback_label;
    }
}