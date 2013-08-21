using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Chatinator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        CUsername EnteredName = new CUsername();
        /// <summary>
        /// Takes the user to Chat.cs after data validation.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //string UserInput = "";
            
            //check if chat already exists or not 
            if (lsbOpenPublicChats.Items.Contains(txbChat.Text) == true)//chat exists join it
            {
                //EnteredName.Username(txbUsername.Text);//gives entered username to CUsername.cs               
                //UserInput = EnteredName.Username(txbUsername.Text);
                //
                Form FrmChat = new frmChat();
                FrmChat.Show();
                FrmChat.Activate();
                this.Dispose(false);
            }
            else if (lsbOpenPublicChats.Items.Contains(txbChat.Text) != true)//chat doesn't exist create it.
            {
                lsbOpenPublicChats.Items.Add(txbChat.Text);//adds new chat.
                //UserInput = EnteredName.Username(txbUsername.Text);
                //
                Form FrmChat = new frmChat();
                FrmChat.Show();
                FrmChat.Activate();
                this.Dispose(false);
            }            
        }
    }
}
