namespace DATABASE_PROJECT
{
    partial class User_CancelSeat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_CancelSeat));
            this.button_cancelSeat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ticketno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancelSeat
            // 
            this.button_cancelSeat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_cancelSeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_cancelSeat.BackgroundImage")));
            this.button_cancelSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelSeat.Location = new System.Drawing.Point(179, 406);
            this.button_cancelSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancelSeat.Name = "button_cancelSeat";
            this.button_cancelSeat.Size = new System.Drawing.Size(227, 48);
            this.button_cancelSeat.TabIndex = 11;
            this.button_cancelSeat.Text = "Cancel Seat";
            this.button_cancelSeat.UseVisualStyleBackColor = false;
            this.button_cancelSeat.Click += new System.EventHandler(this.button_cancelSeat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "A.T Airlines";
            // 
            // textBox_ticketno
            // 
            this.textBox_ticketno.BackColor = System.Drawing.Color.White;
            this.textBox_ticketno.Location = new System.Drawing.Point(179, 325);
            this.textBox_ticketno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ticketno.Name = "textBox_ticketno";
            this.textBox_ticketno.Size = new System.Drawing.Size(225, 22);
            this.textBox_ticketno.TabIndex = 48;
            this.textBox_ticketno.TextChanged += new System.EventHandler(this.textBox_signup_email_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ticket No";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_back.BackgroundImage")));
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(179, 460);
            this.button_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(227, 48);
            this.button_back.TabIndex = 49;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 117);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // User_CancelSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::DATABASE_PROJECT.Properties.Resources._new;
            this.ClientSize = new System.Drawing.Size(605, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_ticketno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_cancelSeat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_CancelSeat";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_CancelSeat_FormClosing);
            this.Load += new System.EventHandler(this.User_CancelSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cancelSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ticketno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}