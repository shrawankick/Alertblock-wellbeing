using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveWorkReminderApp
{
    public partial class Form1 : Form
    {
        private Timer reminderTimer = new Timer();
        public Form1()
        {
            InitializeComponent();

            reminderTimer.Interval = 30000; // 1 hour in milliseconds
            reminderTimer.Tick += ReminderTimer_Tick;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (reminderTimer.Enabled)
            {
                reminderTimer.Stop();
                btnStartStop.Text = "Start";
            }
            else
            {
                reminderTimer.Start();
                btnStartStop.Text = "Stop";
            }
        }
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Time to take a 2-minute break! Stand up and look around.");
        }
    }
}
