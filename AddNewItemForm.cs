using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISDS454_IMS_Forms
{
    public partial class AddNewItemForm : Form
    {
        public AddNewItemForm()
        {
            InitializeComponent();
            LoadComboBox();
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

            string skuinput = skuInput.Text;
            string warehouseidinput = warehouseIDComboBox.Text;
            string nameinput = NameInput.Text;
            string quantityinput = QuantityInput.Text;
            string locationinput = LocationInput.Text;
            string descriptioninput = DescriptionInput.Text;
            string expirationdateinput = ExpirationDateInput.Text;
            string categoryinput = CategoryInput.Text;
            string supplierinput = SupplierInput.Text;
            string costperunitinput = CostInput.Text;
            string sellingpriceinput = SellingPriceInput.Text;

            try
            {
                MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=inventorydatabase");
                connect.Open();
                string query = "INSERT INTO `inventory`(`inventory_sku`,`warehouse_id`,`item_name`, `item_quantity`, `item_location`, `item_description`, `item_expirationdate`, `inventory_type`, `supplier_info`, `cost_per_unit`, `sellingprice_per_unit`) " +
                    "VALUES ('" + skuinput + "','" + warehouseidinput + "','" + nameinput + "','" + quantityinput + "','" + locationinput + "','" + descriptioninput + "','" + expirationdateinput + "','" + categoryinput + "','" + supplierinput + "','" + costperunitinput + "','" + sellingpriceinput + "')";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connect);
                sda.SelectCommand.ExecuteNonQuery();


                connect.Close();
                MessageBox.Show("add item successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid warehouse ID");
            }
        }
        private void AddNewItemForm_Load(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void skuInput_TextChanged(object sender, EventArgs e)
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
                    string query = "SELECT DISTINCT warehouse_id FROM warehouse";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and read the results
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add each item to the ComboBox
                                warehouseIDComboBox.Items.Add(reader["warehouse_id"].ToString());
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
    }
}
