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
    public partial class ViewDetailsForm : Form
    {
        DisplayItemInformation itemDetails = new DisplayItemInformation();
        public ViewDetailsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ViewItemDetailsDataTable.DataSource = itemDetails.getItemInformation();
        }

        private void ViewDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemDetailsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes current details page.
        }
    }
}
