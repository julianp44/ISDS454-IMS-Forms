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
    public partial class EditInventoryMain : Form
    {
        public EditInventoryMain()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();//closes this page leaving the Main Menu visible
        }
    }
}
