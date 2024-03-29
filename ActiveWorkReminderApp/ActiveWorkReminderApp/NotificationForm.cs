﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

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
            string randomMessage = GetRandomMessage();
            labelGenerateMessage.Text = randomMessage;

            //Add countdown Timer 
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

            btnClose.Enabled = false;
            linkLabelLearnMore.LinkClicked += linkLabelLearnMore_LinkClicked;
        }

        private void UpdateTimerLabel(Label lblTimer)
        {
            remainingSeconds--;
            if (remainingSeconds <= 0)
            {
                lblTimer.Text = "Back to Work!";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelLearnMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string learnMoreURL = ConfigurationManager.AppSettings["LearnMoreURL"];
            Process.Start(learnMoreURL);
            // Process.Start("https://github.com/shrawankick/Alertblock-wellbeing-/wikis");
        }

        private void labelGenerateMessage_Click(object sender, EventArgs e)
        {
            //string randomMessage = GetRandomMessage();
            //labelGenerateMessage.Text = randomMessage;
        }

        private static string GetRandomMessage()
        {
            string[] breakMessages = 
            {
                "Take a moment to stretch your legs and relax.",
                "Stand up and do a quick walk around the room. (lock your computer)",
                "Look away from the screen and rest your eyes.",
                "Stand up and look around."
            };
            Random random = new Random();
            int index = random.Next(breakMessages.Length);
            return breakMessages[index];
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //   var LogoImageURL =  ConfigurationManager.AppSettings["LogoImageURL"];
        //    Process.Start(LogoImageURL);
        //}
    }
}
