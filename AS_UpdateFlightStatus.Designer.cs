namespace DATABASE_PROJECT
{
    partial class AS_UpdateFlightStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AS_UpdateFlightStatus));
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(189, 264);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(227, 48);
            this.btn_back.TabIndex = 80;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // AS_UpdateFlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.btn_back);
            this.Name = "AS_UpdateFlightStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AS_UpdateFlightStatus";
            this.Load += new System.EventHandler(this.AS_UpdateFlightStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
    }
}