using System;
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
    public partial class UpdateItemForm : Form
    {
        public UpdateItemForm()
        {
            InitializeComponent();
        }

        private void UpdateCancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this window
        }

        private void UpdateItemConfirmButton_Click(object sender, EventArgs e)
        {
            //needs code to update item
            //needs code to record interaction in logs

        }
    }
}
