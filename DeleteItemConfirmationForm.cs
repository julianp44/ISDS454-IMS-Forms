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
    public partial class DeleteItemConfirmationForm : Form
    {
        public DeleteItemConfirmationForm()
        {
            InitializeComponent();
        }

        private void DeleteCancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes this window
        }

        private void ConfirmDeleteButton_Click(object sender, EventArgs e)
        {
            //needs code to delete selected item from sql database
            //needs code to open Delete Success page upon successfull delete
        }
    }
}
