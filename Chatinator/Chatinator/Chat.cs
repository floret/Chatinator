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
     
        /// <summary>
        /// Clicking this button adds the text in txbInput to lsbOutput.
        /// </summary>
        private void btnPost_Click(object sender, EventArgs e)
        {
            //UserInput                            
            lbxOutput.Items.Add(Username.Username() + ": "  + txbInput.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FrmLogin = new frmLogin();//create a new instance of the form
            FrmLogin.Show();//shows the form
            FrmLogin.Activate();//activates the form
            this.Dispose(false);//disposes the current form
        }
    }
}
