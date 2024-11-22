using MySql.Data.MySqlClient;
using sqlConnectionTest;
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
    public partial class EditInventoryForm : Form
    {
        DisplayItemInformation itemInfo = new DisplayItemInformation();
        DBconnect connect = new DBconnect();
        public EditInventoryForm()
        {
            InitializeComponent();
            editDatagridView.DataSource = itemInfo.getItemInformation();
        }

        private void editItemCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editItemConfirmButton_Click(object sender, EventArgs e)
        {
            connect.openConnnect();

            string updateQuery = "UPDATE inventory SET warehouse_id = '" + editwarehouseIDInput.Text + "',item_name = '" + editNameInput.Text + "', item_quantity = '" + editQuantityInput.Text + "', item_location = '" + editLocationInput.Text + "', item_description = '" + editDescriptionInput.Text + "', item_expirationdate = '" + editExpirationDateInput.Text + "', inventory_type = '" + editCategoryInput.Text + "', supplier_info = '" + editSupplierInput.Text + "', cost_per_unit = '" + double.Parse(editCostInput.Text) + "', sellingprice_per_unit = '" + double.Parse(editSellingPriceInput.Text) + "'WHERE inventory_sku = '"+editskuInput.Text+"'";


            try
            {
                MySqlCommand cmd = new MySqlCommand(updateQuery, connect.getconnection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Update success");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connect.closeConnect();
        }

        private void editDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                editskuInput.Text = editDatagridView.SelectedRows[0].Cells[0].Value.ToString();
                editwarehouseIDInput.Text = editDatagridView.SelectedRows[0].Cells[1].Value.ToString();
                editNameInput.Text = editDatagridView.SelectedRows[0].Cells[2].Value.ToString();
                editQuantityInput.Text = editDatagridView.SelectedRows[0].Cells[3].Value.ToString();
                editLocationInput.Text = editDatagridView.SelectedRows[0].Cells[4].Value.ToString();
                editDescriptionInput.Text = editDatagridView.SelectedRows[0].Cells[5].Value.ToString();
                editExpirationDateInput.Text = editDatagridView.SelectedRows[0].Cells[6].Value.ToString();
                editCategoryInput.Text = editDatagridView.SelectedRows[0].Cells[7].Value.ToString();
                editSupplierInput.Text = editDatagridView.SelectedRows[0].Cells[8].Value.ToString();
                editCostInput.Text = editDatagridView.SelectedRows[0].Cells[9].Value.ToString();
                editSellingPriceInput.Text = editDatagridView.SelectedRows[0].Cells[10].Value.ToString();
            }
        }
    }
}
