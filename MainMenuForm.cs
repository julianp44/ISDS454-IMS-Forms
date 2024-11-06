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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // This is the Edit Inventory Button
        {
            // Create an instance of EditInventoryForm
            EditInventoryMain editInventoryMain = new EditInventoryMain();

            // Show the EditInventoryForm
            editInventoryMain.Show();
        }

        private void button2_Click(object sender, EventArgs e) //This it the View Inventory Button
        {
            // Create an instance of ViewInventoryForm
            ViewInventoryMain viewInventoryMain = new ViewInventoryMain();

            // Show the ViewInventoryForm
            viewInventoryMain.Show();
        }
    }
}
