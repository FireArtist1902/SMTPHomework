namespace SMTPHomework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GmailIdTB = new TextBox();
            PasswordTB = new TextBox();
            ServerAddressTB = new TextBox();
            PortTB = new TextBox();
            SendToTB = new TextBox();
            SubjectTb = new TextBox();
            AttachmentTB = new TextBox();
            MessageTB = new TextBox();
            BrowseBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            SuspendLayout();
            // 
            // GmailIdTB
            // 
            GmailIdTB.Location = new Point(12, 12);
            GmailIdTB.Name = "GmailIdTB";
            GmailIdTB.Size = new Size(172, 27);
            GmailIdTB.TabIndex = 0;
            GmailIdTB.Text = "GmailId";
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(12, 45);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(172, 27);
            PasswordTB.TabIndex = 1;
            PasswordTB.Text = "Password";
            // 
            // ServerAddressTB
            // 
            ServerAddressTB.Location = new Point(413, 12);
            ServerAddressTB.Name = "ServerAddressTB";
            ServerAddressTB.Size = new Size(125, 27);
            ServerAddressTB.TabIndex = 2;
            ServerAddressTB.Text = "ServerAddress";
            // 
            // PortTB
            // 
            PortTB.Location = new Point(413, 45);
            PortTB.Name = "PortTB";
            PortTB.Size = new Size(125, 27);
            PortTB.TabIndex = 3;
            PortTB.Text = "ServerPort";
            // 
            // SendToTB
            // 
            SendToTB.Location = new Point(12, 118);
            SendToTB.Name = "SendToTB";
            SendToTB.Size = new Size(172, 27);
            SendToTB.TabIndex = 4;
            SendToTB.Text = "Send to";
            // 
            // SubjectTb
            // 
            SubjectTb.Location = new Point(12, 151);
            SubjectTb.Name = "SubjectTb";
            SubjectTb.Size = new Size(426, 27);
            SubjectTb.TabIndex = 5;
            SubjectTb.Text = "Subject";
            // 
            // AttachmentTB
            // 
            AttachmentTB.Location = new Point(12, 184);
            AttachmentTB.Name = "AttachmentTB";
            AttachmentTB.Size = new Size(426, 27);
            AttachmentTB.TabIndex = 6;
            AttachmentTB.Text = "Attachment";
            // 
            // MessageTB
            // 
            MessageTB.Location = new Point(12, 217);
            MessageTB.Multiline = true;
            MessageTB.Name = "MessageTB";
            MessageTB.Size = new Size(426, 221);
            MessageTB.TabIndex = 7;
            MessageTB.Text = "Message";
            // 
            // BrowseBtn
            // 
            BrowseBtn.Location = new Point(444, 182);
            BrowseBtn.Name = "BrowseBtn";
            BrowseBtn.Size = new Size(94, 29);
            BrowseBtn.TabIndex = 8;
            BrowseBtn.Text = "Browse";
            BrowseBtn.UseVisualStyleBackColor = true;
            BrowseBtn.Click += BrowseBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(12, 444);
            button1.Name = "button1";
            button1.Size = new Size(426, 29);
            button1.TabIndex = 9;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 477);
            Controls.Add(button1);
            Controls.Add(BrowseBtn);
            Controls.Add(MessageTB);
            Controls.Add(AttachmentTB);
            Controls.Add(SubjectTb);
            Controls.Add(SendToTB);
            Controls.Add(PortTB);
            Controls.Add(ServerAddressTB);
            Controls.Add(PasswordTB);
            Controls.Add(GmailIdTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GmailIdTB;
        private TextBox PasswordTB;
        private TextBox ServerAddressTB;
        private TextBox PortTB;
        private TextBox SendToTB;
        private TextBox SubjectTb;
        private TextBox AttachmentTB;
        private TextBox MessageTB;
        private Button BrowseBtn;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}