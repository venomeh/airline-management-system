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
    public partial class AS_UpdateFlightStatus : Form
    {   
        private database _db;

        public AS_UpdateFlightStatus(database db)
        {
            InitializeComponent();
            _db = db;
        }

        private void AS_UpdateFlightStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
