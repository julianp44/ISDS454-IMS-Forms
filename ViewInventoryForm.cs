using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ISDS454_IMS_Forms
{
    public partial class ViewInventoryMain : Form
    {
        DisplayItemInformation itemInfo = new DisplayItemInformation();
        public ViewInventoryMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ViewInventoryDataTable.DataSource = itemInfo.getItemInformation();
        }

        private void InventoryDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes this window leaving the Main Menu visible
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            ViewDetailsForm details = new ViewDetailsForm();
            details.Show();
        }
    }
}
