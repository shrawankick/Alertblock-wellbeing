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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabelLearnMore = new System.Windows.Forms.LinkLabel();
            this.labelGenerateMessage = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
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
            this.btnClose.Location = new System.Drawing.Point(16, 106);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabelLearnMore
            // 
            this.linkLabelLearnMore.AutoSize = true;
            this.linkLabelLearnMore.Location = new System.Drawing.Point(12, 149);
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
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(332, 119);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(143, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 241);
            this.ControlBox = false;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.labelGenerateMessage);
            this.Controls.Add(this.linkLabelLearnMore);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NotificationForm";
            this.Text = "Break!!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabelLearnMore;
        private System.Windows.Forms.Label labelGenerateMessage;
        private System.Windows.Forms.PictureBox Logo;
    }
}