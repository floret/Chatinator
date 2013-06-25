using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatinator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string UserInput = "";
            CUsername Username = new CUsername();
            //check if chat already name exists or not 
            if (lsbOpenPublicChats.Items.Contains(txbChat.Text) == true)
            {
                UserInput = Username.Username(txbUsername.Text);
                //
                Form FrmChat = new frmChat();//create a new instance of the form
                FrmChat.Show();//shows the form
                FrmChat.Activate();//activates the form
                this.Dispose(false);//disposes the current form
            }
            else if (lsbOpenPublicChats.Items.Contains(txbChat.Text) != true)
            {
                lsbOpenPublicChats.Items.Add(txbChat.Text);
                UserInput = Username.Username(txbUsername.Text);
                //
                Form FrmChat = new frmChat();//create a new instance of the form
                FrmChat.Show();//shows the form
                FrmChat.Activate();//activates the form
                this.Dispose(false);//disposes the current form
            }            
        }
    }
}
