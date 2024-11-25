using MySql.Data.MySqlClient;
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
        DisplayItemInformation itemInfo = new DisplayItemInformation();
        public EditInventoryMain()
        {
            InitializeComponent();
            EditInventoryDataTable.DataSource = itemInfo.getItemDetails();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();//closes this page leaving the Main Menu visible
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewInventoryButton_Click(object sender, EventArgs e)
        {
            AddNewItemForm frm = new AddNewItemForm();
            frm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            EditInventoryDataTable.DataSource = itemInfo.getItemDetails();
        }

        private void EditInventoryDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditInventoryForm frm = new EditInventoryForm();
            frm.Show();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (EditInventoryDataTable.SelectedRows.Count > 0)
                {
                    // Get the primary key (e.g., "ID") from the selected row
                    string selectedItem = EditInventoryDataTable.SelectedRows[0].Cells["SKU"].Value.ToString();

                    // Confirm deletion
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this record?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Delete from the database
                        DeleteRecordFromDatabase(selectedItem);

                        // Remove the row from the DataGridView
                        EditInventoryDataTable.Rows.RemoveAt(EditInventoryDataTable.SelectedRows[0].Index);
                        MessageBox.Show("Record deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a row to delete." + MessageBox.Show(ex.Message));
            }

        }

        private void DeleteRecordFromDatabase(string sku)
        {
            using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase"))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM inventory WHERE inventory_sku = @inventory_sku";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@inventory_sku", sku);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void EditSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = EditSearchTextBox.Text.Trim();
            LoadData(searchText);
        }

        private void LoadData(string searchQuery)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase;Convert Zero Datetime=True"))
                {
                    conn.Open();

                    string query = string.IsNullOrEmpty(searchQuery)
                        ? "SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location FROM inventory;"
                        : "SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location FROM inventory WHERE inventory_sku LIKE @Search OR item_name LIKE @Search;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchQuery + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            EditInventoryDataTable.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
