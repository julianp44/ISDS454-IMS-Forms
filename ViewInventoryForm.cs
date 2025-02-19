﻿using System;
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
            LoadComboBox();
        }

        private void ViewCancelButton_Click(object sender, EventArgs e)
        {
            MainMenuForm df = new MainMenuForm();
            this.Close();   //Closes this window leaving the Main Menu visible
            df.Show();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected
            if (ViewInventoryDataTable.SelectedRows.Count > 0)
            {
                // Get the selected row (first selected row)
                DataGridViewRow selectedRow = ViewInventoryDataTable.SelectedRows[0];

                // Create a new instance of ViewDetailsForm and pass the selected row's data
                ViewDetailsForm details = new ViewDetailsForm(
                    selectedRow.Cells["SKU"].Value.ToString(),
                    selectedRow.Cells["Warehouse"].Value.ToString(),
                    selectedRow.Cells["Name"].Value.ToString(),
                    selectedRow.Cells["Quantity"].Value.ToString(),
                    selectedRow.Cells["Location"].Value.ToString()
                );

                // Close this form and show the next form
                this.Close();
                details.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to view details.");
            }
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

        private void LoadDataCategory(string searchQuery)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase;Convert Zero Datetime=True"))
                {
                    conn.Open();

                    string query = string.IsNullOrEmpty(searchQuery)
                        ? "SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location FROM inventory;"
                        : "SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location FROM inventory WHERE inventory_type LIKE @Search OR item_name LIKE @Search;";

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

        private void LoadComboBox()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase"))
                {
                    // Open the connection
                    connection.Open();

                    // Define your query
                    string query = "SELECT DISTINCT inventory_type FROM inventory";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and read the results
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each item to the ComboBox
                                viewInventoryComboBox.Items.Add(reader["inventory_type"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void viewInventoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryText = viewInventoryComboBox.Text.Trim();
            LoadDataCategory(categoryText);
        }
    }
}
