using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveWorkReminderApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Timer notificationTimer = new Timer();
            notificationTimer.Interval = 30000; // 30 seconds interval
            notificationTimer.Tick += (sender, e) =>
            {
                NotificationForm notificationForm = new NotificationForm("Time to take a 2-minute break! ");
                notificationForm.Closed += (s, args) =>
                {
                    notificationTimer.Start(); // Restart the timer after the previous notification is closed
                };
                notificationForm.Show();
                notificationTimer.Stop(); // Stop the timer to prevent overlapping notifications
            };   
            notificationTimer.Start();           
            Application.Run();
        }
    }
}
