using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using sqlConnectionTest;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ISDS454_IMS_Forms
{
    public partial class ViewDetailsForm : Form
    {
        private string sku;
        private string warehouse;
        private string name;
        private string quantity;
        private string location;

        // This is the object that handles showing the item details and exporting them.
        DisplayItemInformation itemDetails = new DisplayItemInformation();

        public ViewDetailsForm(string sku, string warehouse, string name, string quantity, string location)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Makes sure the form opens in the center.

            // Assign the passed-in data to local variables.
            this.sku = sku;
            this.warehouse = warehouse;
            this.name = name;
            this.quantity = quantity;
            this.location = location;

            // Display the item details in the data grid view.
            ViewItemDetailsDataTable.DataSource = getItemInformation(sku);
        }

        private void ViewDetailsForm_Load(object sender, EventArgs e)
        {
            // Currently nothing to do here, but maybe we'll add some stuff later.
        }

        private void ItemDetailsCancelButton_Click(object sender, EventArgs e)
        {
            // Close this form and go back to the main inventory view.
            this.Close();
            ViewInventoryMain df = new ViewInventoryMain();
            df.Show();
        }

        // This is the object that connects to the database. It's used for running queries.
        DBconnect connect = new DBconnect();

        // This method gets all the item info from the database and puts it in a DataTable.
        public DataTable getItemInformation(string sku)
        {
            // SQL query to grab item info based on the passed SKU.
            MySqlCommand command = new MySqlCommand(
                "SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location, item_description AS Description, item_expirationdate AS Expiration, inventory_type AS Category, supplier_info AS Supplier, cost_per_unit AS Cost, sellingprice_per_unit AS Price " +
                "FROM inventory WHERE inventory_sku = @sku", connect.getconnection);

            // Add the SKU to the query to prevent SQL injection.
            command.Parameters.AddWithValue("@sku", sku);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); // Fill the table with the query results.
            return table;
        }

        private void ItemDetailsExportButton_Click(object sender, EventArgs e)
        {
            // When the export button is clicked, it exports the selected item's details to a PDF.
            ExportSelectedItemToPDF();
        }

        // This method handles exporting the item's details to a PDF file.
        public void ExportSelectedItemToPDF()
        {
            try
            {
                // Make sure the user actually selected something before continuing.
                if (ViewItemDetailsDataTable.SelectedCells.Count > 0)
                {
                    // Get the selected row from the data grid view.
                    int selectedRowIndex = ViewItemDetailsDataTable.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = ViewItemDetailsDataTable.Rows[selectedRowIndex];

                    // Grab the item's name (or use a default if it's missing).
                    string itemName = selectedRow.Cells["Name"].Value?.ToString() ?? "UnnamedItem";
                    itemName = RemoveInvalidFileNameChars(itemName); // Clean up the name for file safety.

                    // Collect all the item details into a string to add to the PDF.
                    StringBuilder itemDetails = new StringBuilder();
                    foreach (DataGridViewColumn column in ViewItemDetailsDataTable.Columns)
                    {
                        string columnName = column.HeaderText; // Column name like "SKU" or "Name".
                        string cellValue = selectedRow.Cells[column.Index].Value?.ToString() ?? "N/A"; // Cell value, default to "N/A" if it's empty.
                        itemDetails.AppendLine($"{columnName}: {cellValue}"); // Add each detail to the string.
                    }

                    // Open a SaveFileDialog so the user can name and save the file.
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF files (*.pdf)|*.pdf", // Only allow saving as a PDF.
                        Title = "Save PDF File",
                        FileName = $"{itemName}_Details.pdf" // Set the default file name.
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Create a new PDF document.
                        Document pdfDocument = new Document(PageSize.A4);

                        // Set up a writer to save the PDF to the specified path.
                        PdfWriter.GetInstance(pdfDocument, new FileStream(filePath, FileMode.Create));

                        // Open the document to start adding content.
                        pdfDocument.Open();

                        // Add the title and the item details to the PDF.
                        pdfDocument.Add(new Paragraph($"Details of {itemName}"));
                        pdfDocument.Add(new Paragraph(" ")); // Add some space.
                        pdfDocument.Add(new Paragraph(itemDetails.ToString())); // Add the collected details.

                        // Close the document once done.
                        pdfDocument.Close();

                        // Let the user know the export was successful.
                        MessageBox.Show("The selected item's details have been exported successfully to: " + filePath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // If no cell is selected, prompt the user to select one.
                    MessageBox.Show("Please select a cell first!");
                }
            }
            catch (Exception ex)
            {
                // Catch any errors and display them to the user.
                MessageBox.Show("An error occurred while exporting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to make sure the file name doesn't contain any invalid characters.
        private string RemoveInvalidFileNameChars(string input)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                input = input.Replace(c.ToString(), "_"); // Replace invalid chars with underscores.
            }
            return input;
        }
    }
}
