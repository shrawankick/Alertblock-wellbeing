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
    public partial class NotificationForm : Form
    {
        private Timer notificationTimer = new Timer();
        private int remainingSeconds = 120;

        public NotificationForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;

            //Add coundown Timer 

            // Create and configure a label to display the countdown timer
            Label lblTimer = new Label();
            lblTimer.AutoSize = true;
            lblTimer.Location = new System.Drawing.Point(12, 50); // Adjust the location
            lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTimer.ForeColor = System.Drawing.Color.Red;
            this.Controls.Add(lblTimer);

            // Set up the notification timer
            notificationTimer.Interval = 1000; // 1 second interval
            notificationTimer.Tick += (s, e) => UpdateTimerLabel(lblTimer);
            notificationTimer.Start(); // Start the notification timer

            //

            //notificationTimer.Interval = 120000;
            ////closeTimer.Tick += CloseTimer_Tick;
            //notificationTimer.Interval = 120000; // 2 minutes
            //notificationTimer.Tick += NotificationTimer_Tick;
            //notificationTimer.Start();
            btnClose.Enabled = false;
        }

        private void UpdateTimerLabel(Label lblTimer)
        {
            remainingSeconds--;
            if (remainingSeconds <= 0)
            {
                lblTimer.Text = "Time's up!";
                btnClose.Enabled = true; // Enable the "Close" button
                notificationTimer.Stop(); // Stop the notification timer
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(remainingSeconds);
                lblTimer.Text = string.Format("Time remaining: {0:D2}:{1:D2}", time.Minutes, time.Seconds);
            }
        }


        private void NotificationForm_Load(object sender, EventArgs e)
        {
            int screenRight = Screen.PrimaryScreen.WorkingArea.Right;
            int screenBottom = Screen.PrimaryScreen.WorkingArea.Bottom;
            this.Location = new System.Drawing.Point(screenRight - this.Width, screenBottom - this.Height);
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
        //private void CloseTimer_Tick(object sender, EventArgs e)
        //{
        //    // Close the notification form when the timer ticks
        //    closeTimer.Stop();
        //    this.Close();
        //}

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            //    // Display a message box when the notification timer ticks
            //    MessageBox.Show("Time to take a 2-minute break! Stand up and look around.");

            //    // Close the notification form after showing the message box
            //    this.Close();
            //

            //int elapsedMilliseconds = 0;
            //elapsedMilliseconds += 1000; // Increase elapsed time by 1 second

            //// Check if 2 minutes (120,000 milliseconds) have passed
            //if (elapsedMilliseconds >= 120000)
            //{
            //    btnClose.Enabled = true; // Enable the "Close" button
            //    notificationTimer.Stop(); // Stop the notification timer
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
