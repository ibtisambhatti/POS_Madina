using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Madina
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Assuming 'this' refers to the current form you want to close
            this.Hide(); // Hide the current form instead of closing it

            login f2 = new login();
            f2.Show(); // Show the new Signup form
        }
    }
}
