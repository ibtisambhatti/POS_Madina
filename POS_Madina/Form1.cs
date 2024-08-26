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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowToast("INFO", "This is an info toast");
        }

        public void ShowToast (string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowToast("SUCCESS", "This is a success toast");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowToast("ERROR", "This is an error toast");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowToast("WARNING", "This is a warning toast");
        }
    }
}
