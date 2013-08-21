using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//**

namespace Chatinator
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }

        CUsername Username = new CUsername();//!find a way to use an existing instancs so that the values don't get reset to null.   
        int anonFlag = 0;
        int unlurkFlag = 0;
        /// <summary>
        /// Clicking this button adds the text in txbInput to lsbOutput.
        /// </summary>
        private void btnPost_Click(object sender, EventArgs e)
        {
            //UserInput  
            if (anonFlag == 1)
            {
                lbxOutput.Items.Add("Anonamous Coward" + ": " + txbInput.Text);//posting anonamously.
            }
            else if (anonFlag == 0)//not anon
            {
                //TODO: make the commands into a class.
                if ((txbInput.Text == "/unlurk") || (txbInput.Text == "/Unlurk"))
                {
                    //lbxOutput.Items.Add(User.Username() + " has stopped lurking.");//user has become active
                    //lbxActiveUser.Items.Add(User.Username());//add user to active users listbox.
                    unlurkFlag = 1;//no longer lurking
                }
                else if ((txbInput.Text != "/unlurk") || (txbInput.Text != "/Unlurk"))//posts normally
                {//non comand posting starts here***
                    if (unlurkFlag == 0)//forced to unlurk
                    {
                        string a = Username.setUser;//wtf is automatic step over.

                        lbxOutput.Items.Add(Username.setUser + " has stopped lurking.");
                        //lbxActiveUser.Items.Add(User.Username());
                        ////!Username doesn't get displayed only : message.
                        //lbxOutput.Items.Add(User.Username() + ": " + txbInput.Text);//adds username: before post. 
                    }
                    if (unlurkFlag == 1)//already active
                    {
                        //lbxOutput.Items.Add(User.Username() + ": " + txbInput.Text);//adds username: before post. 
                    }
                }//non comand posting ends here***
            }
        }
        /// <summary>
        /// Clicking this button takes you back to the Login screen.
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FrmLogin = new frmLogin();
            FrmLogin.Show();
            FrmLogin.Activate();
            this.Dispose(false);
        }

        private void cbxAnon_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxAnon.Checked == true)
            {
                anonFlag = 1;//user wants to post anonamously
            }
            else if (cbxAnon.Checked != true)
            {
                anonFlag = 0;//user wants to post under their username.
            }
        }
    }
}
//!Username doesn't get displayed only : message.
//!find a way to use an existing instancs so that the values don't get reset to null.  
//TODO: make the commands into a class.
//
//Outline