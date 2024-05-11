using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DATABASE_PROJECT
{
    public partial class SignUp : Form
    {
        private database _db;
        
        private string phoneNoPlaceholder = "xxx-xxx-xxxxxx";
        private string emailPlaceholder = "abc@gmail.com";
        private string cnicPlaceholder = "xxxxx-xxx-xxxx-x";

        public string phone, email, cnic, pass, cpass; 


        public SignUp(database db)
        {

            InitializeComponent();

            SetPlaceholder(textBox_email, emailPlaceholder);
            SetPlaceholder(textBox_phoneNo, phoneNoPlaceholder);
            SetPlaceholder(cnic_txtbox, cnicPlaceholder);

            AttachEventHandlers(textBox_email, emailPlaceholder);
            AttachEventHandlers(textBox_phoneNo, phoneNoPlaceholder);
            AttachEventHandlers(cnic_txtbox, cnicPlaceholder);

            _db = db;
        }

        private void SetPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;
        }

        private void AttachEventHandlers(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            textBox.Enter += (sender, e) => TextBox_Enter(sender, e, placeholder);
            textBox.Leave += (sender, e) => TextBox_Leave(sender, e, placeholder);
        }

        private void TextBox_Enter(object sender, EventArgs e, string placeholder)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            // Clear the placeholder text when TextBox is focused
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.SystemColors.WindowText; // Restore default text color
            }
        }

        private void TextBox_Leave(object sender, EventArgs e, string placeholder)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            // Restore the placeholder text if TextBox is left empty
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox_phoneNo_TextChanged(object sender, EventArgs e)
        {
            phone = textBox_phoneNo.Text;
            
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            email= textBox_email.Text;

        }
       
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            pass = textBox_password.Text;
        }

        private void textBox_confirmPass_TextChanged(object sender, EventArgs e)
        {
            cpass = textBox_confirmPass.Text;
        }
        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            LOGIN user = new LOGIN(_db);
            user.Show();

            this.Hide();
        }

        // send data to the database form sign up
        private void signUp_button_Click(object sender, EventArgs e)
        {
            if(pass != cpass)
            {
                MessageBox.Show("please enter similar passwords");

            }

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label_OTPMsg_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_SMS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cnic_txtbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
