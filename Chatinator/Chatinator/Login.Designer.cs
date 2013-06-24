namespace Chatinator
{
    partial class frmLogin
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txbChat = new System.Windows.Forms.TextBox();
            this.lsbOpenPublicChats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(186, 187);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(156, 20);
            this.txbUsername.TabIndex = 0;
            this.txbUsername.Text = "Username";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(385, 187);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Go!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(186, 145);
            this.txbChat.Name = "txbChat";
            this.txbChat.Size = new System.Drawing.Size(274, 20);
            this.txbChat.TabIndex = 2;
            this.txbChat.Text = "Enter chat name here";
            // 
            // lsbOpenPublicChats
            // 
            this.lsbOpenPublicChats.FormattingEnabled = true;
            this.lsbOpenPublicChats.Items.AddRange(new object[] {
            "Open Public Chats:",
            "================"});
            this.lsbOpenPublicChats.Location = new System.Drawing.Point(498, 145);
            this.lsbOpenPublicChats.Name = "lsbOpenPublicChats";
            this.lsbOpenPublicChats.Size = new System.Drawing.Size(120, 212);
            this.lsbOpenPublicChats.TabIndex = 3;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.lsbOpenPublicChats);
            this.Controls.Add(this.txbChat);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbUsername);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txbChat;
        private System.Windows.Forms.ListBox lsbOpenPublicChats;
    }
}