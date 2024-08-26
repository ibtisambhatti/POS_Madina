﻿using System;
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
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string type, string message)
        {
            InitializeComponent();
            IbType.Text = type;
            IbMessage.Text = message;
            switch (type)
            {
                case "SUCCESS":

                    ToastBorder.BackColor = Color.FromArgb(57, 155, 53);
                    picIcon.Image = Properties.Resources.tick;
                    break;
                case "ERROR":
                    ToastBorder.BackColor = Color.FromArgb(227, 50, 45);
                    picIcon.Image = Properties.Resources.Error_icon;
                    break;
                case "INFO":
                    ToastBorder.BackColor = Color.FromArgb(18, 136, 191);
                    picIcon.Image = Properties.Resources.Excalamation_mark;

                    break;
                case "WARNING":
                    ToastBorder.BackColor = Color.FromArgb(245, 171, 35);
                    picIcon.Image = Properties.Resources.false_icon;

                    break;


            }
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 750)
            {
                toastTimer.Stop();
                toastHide.Start();
            }
        }
        int y = 100;
        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY >= 800)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width;
            toastY = ScreenHeight - this.Height;

            this.Location = new Point(toastX, toastY);
        }
    }
}
