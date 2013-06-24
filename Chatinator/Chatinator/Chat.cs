﻿using System;
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
    public partial class frmChat : Form
    {
        public frmChat()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clicking this button adds the text in txbInput to lsbOutput.
        /// </summary>
        private void btnPost_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Add(txbInput.Text);
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