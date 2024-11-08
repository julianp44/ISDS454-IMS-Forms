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
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();
        }

        private void ItemNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void NewItemCancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); //cancels add new item and closes menu
        }

        private void AddItemConfirmButton_Click(object sender, EventArgs e)
        {
            //need to add code to collect all inputs and add them to corresponding areas in our sql database
            //button also needs to record interaction to logs
            //button also needs to open up successful item add page upon successfull add

        }
    }
}
