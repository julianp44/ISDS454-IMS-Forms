﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS454_IMS_Forms
{
    public partial class SuccessfulDeleteForm : Form
    {
        public SuccessfulDeleteForm()
        {
            InitializeComponent();
        }

        private void SuccessfulDeleteDone_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes this screen
        }
    }
}
