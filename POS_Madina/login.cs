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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Assuming 'this' refers to the current form you want to close
            this.Hide(); // Hide the current form instead of closing it

            Signup f2 = new Signup();
            f2.Show(); // Show the new Signup form

            // Optionally, you can close the current form after the new one is shown
            //this.Close();
        }
    }
}
