namespace ActiveWorkReminderApp
{
    partial class NotificationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabelLearnMore = new System.Windows.Forms.LinkLabel();
            this.labelGenerateMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(51, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabelLearnMore
            // 
            this.linkLabelLearnMore.AutoSize = true;
            this.linkLabelLearnMore.Location = new System.Drawing.Point(12, 135);
            this.linkLabelLearnMore.Name = "linkLabelLearnMore";
            this.linkLabelLearnMore.Size = new System.Drawing.Size(242, 20);
            this.linkLabelLearnMore.TabIndex = 2;
            this.linkLabelLearnMore.TabStop = true;
            this.linkLabelLearnMore.Text = "Learn more about healthy breaks";
            this.linkLabelLearnMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLearnMore_LinkClicked);
            // 
            // labelGenerateMessage
            // 
            this.labelGenerateMessage.AutoSize = true;
            this.labelGenerateMessage.Location = new System.Drawing.Point(12, 40);
            this.labelGenerateMessage.Name = "labelGenerateMessage";
            this.labelGenerateMessage.Size = new System.Drawing.Size(42, 20);
            this.labelGenerateMessage.TabIndex = 3;
            this.labelGenerateMessage.Text = "label";
            this.labelGenerateMessage.Click += new System.EventHandler(this.labelGenerateMessage_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 208);
            this.ControlBox = false;
            this.Controls.Add(this.labelGenerateMessage);
            this.Controls.Add(this.linkLabelLearnMore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotificationForm";
            this.Text = "Break!!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabelLearnMore;
        private System.Windows.Forms.Label labelGenerateMessage;
    }
}