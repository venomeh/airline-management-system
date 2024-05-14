namespace DATABASE_PROJECT
{
    partial class ControlCenter
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
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_logout.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._52;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Location = new System.Drawing.Point(192, 421);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(227, 48);
            this.button_logout.TabIndex = 22;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 23;
            this.label1.Text = "A.T Airlines";
            // 
            // ControlCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(606, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Name = "ControlCenter";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlCenter_FormClosing);
            this.Load += new System.EventHandler(this.ControlCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
    }
}