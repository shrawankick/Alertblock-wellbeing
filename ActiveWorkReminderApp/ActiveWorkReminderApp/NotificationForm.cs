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
        public NotificationForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
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
    }
}
