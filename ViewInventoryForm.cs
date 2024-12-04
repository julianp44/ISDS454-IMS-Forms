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
            ViewInventoryDataTable.DataSource = itemInfo.getItemDetails();
        }

        private void ViewCancelButton_Click(object sender, EventArgs e)
        {
            MainMenuForm df = new MainMenuForm();
            this.Close();   //Closes this window leaving the Main Menu visible
            df.Show();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            ViewDetailsForm details = new ViewDetailsForm();
            this.Close();
            details.Show();
        }

        private void ViewLastUpdatesButton_Click(object sender, EventArgs e)
        {
            ViewLastUpdatesForm viewLastUpdates = new ViewLastUpdatesForm();
            this.Close();
            viewLastUpdates.Show();
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
                            ViewInventoryDataTable.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ViewSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = ViewSearchTextBox.Text.Trim();
            LoadData(searchText);
        }

        private void ViewInventoryDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewInventoryDataTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
