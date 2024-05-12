using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_PROJECT
{
    public partial class AS_ScheduleFlight : Form
    {
        public AS_ScheduleFlight()
        {
            InitializeComponent();
        }

        private void AS_ScheduleFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
