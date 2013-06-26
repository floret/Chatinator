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

        CUsername User = new CUsername();//!find a way to use an existing instancs so that the values don't get reset to null.   

        /// <summary>
        /// Clicking this button adds the text in txbInput to lsbOutput.
        /// </summary>
        private void btnPost_Click(object sender, EventArgs e)
        {
            //test variables
            string luser;
            //tv
            //test
            //Square mySquare = new Square(100);
            CUsername mySquare = new CUsername();

            if (mySquare is ICryoStasis)
            {
                ICryoStasis drawSquare = mySquare;               
                drawSquare.UserSave(User.Username()/*luser*/);
                //luser = drawSquare.UserSave(User.Username()/*luser*/);
                lbxOutput.Items.Add(/*luser*//*drawSquare.UserSave(User.Username())*/ /*User.Username()*/ /*+*/ ": " + txbInput.Text);//adds username: before post.   
            }

            ////if (mySquare is ICryoStasis)
            //// {
            //ICryoStasis drawSquare = mySquare;
            ////IDraw drawSquare = mySquare;
            //drawSquare.UserSave(User.Username()/*luser*/);
            //// }
            //t

            //UserInput                            
            //lbxOutput.Items.Add( drawSquare.UserSave(User.Username()/*luser*/)/*User.Username()*/ + ": " + txbInput.Text);//adds username: before post.   
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
    }
}
//!find a way to use an existing instancs so that the values don't get reset to null. 