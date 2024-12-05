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
        // This is the class that handles displaying and exporting item details.
        DisplayItemInformation itemDetails = new DisplayItemInformation();

        public ViewDetailsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Makes the form open in the middle of the screen.
            ViewItemDetailsDataTable.DataSource = itemDetails.getItemInformation(); // Load item info into the data grid.
        }

        private void ViewDetailsForm_Load(object sender, EventArgs e)
        {
            // Nothing to do here for now, but we might add stuff later.
        }

        private void ItemDetailsCancelButton_Click(object sender, EventArgs e)
        {
            // Close this form and reopen the main inventory view.
            this.Close();
            ViewInventoryMain df = new ViewInventoryMain();
            df.Show();
        }

        // This connects to the database. Reusable for queries.
        DBconnect connect = new DBconnect();

        // This method gets all item details from the database and puts them in a DataTable.
        public DataTable getItemInformation()
        {
            // SQL query to fetch all the inventory details. Adjust the column names if needed.
            MySqlCommand command = new MySqlCommand("SELECT inventory_sku AS SKU, warehouse_id AS Warehouse, item_name AS Name, item_quantity AS Quantity, item_location AS Location, item_description AS Description, item_expirationdate AS Expiration, inventory_type AS Category, supplier_info AS Supplier, cost_per_unit AS Cost, sellingprice_per_unit AS Price FROM inventory", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); // Fills the table with query results.
            return table;
        }

        private void ItemDetailsExportButton_Click(object sender, EventArgs e)
        {
            // When the user clicks the export button, we export the selected item's details to a PDF.
            ExportSelectedItemToPDF();
        }

        // This method exports all the details of the selected item to a PDF file.
        public void ExportSelectedItemToPDF()
        {
            try
            {
                // Make sure the user actually selected a cell before doing anything.
                if (ViewItemDetailsDataTable.SelectedCells.Count > 0)
                {
                    // Get the selected row from the data grid.
                    int selectedRowIndex = ViewItemDetailsDataTable.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = ViewItemDetailsDataTable.Rows[selectedRowIndex];

                    // Grab the item's name (or whatever identifier we need). Default to "UnnamedItem" if it's empty.
                    string itemName = selectedRow.Cells["Name"].Value?.ToString() ?? "UnnamedItem"; // Replace "Name" with your column name for item name.
                    itemName = RemoveInvalidFileNameChars(itemName); // Clean up the name to make it safe for file saving.

                    // Collect all the item's details into a string. This will go in the PDF.
                    StringBuilder itemDetails = new StringBuilder();
                    foreach (DataGridViewColumn column in ViewItemDetailsDataTable.Columns)
                    {
                        string columnName = column.HeaderText; // Column name (e.g., "SKU", "Name").
                        string cellValue = selectedRow.Cells[column.Index].Value?.ToString() ?? "N/A"; // Value in the cell.
                        itemDetails.AppendLine($"{columnName}: {cellValue}"); // Add it to the details string.
                    }

                    // Open a SaveFileDialog so the user can name the file and choose where to save it.
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF files (*.pdf)|*.pdf", // Only show PDF as the save option.
                        Title = "Save PDF File",
                        FileName = $"{itemName}_Details.pdf" // Default file name based on the item name.
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Create a new PDF document.
                        Document pdfDocument = new Document(PageSize.A4);

                        // Set up a writer to save the PDF to the specified file path.
                        PdfWriter.GetInstance(pdfDocument, new FileStream(filePath, FileMode.Create));

                        // Open the document so we can start adding content.
                        pdfDocument.Open();

                        // Add some text to the PDF.
                        pdfDocument.Add(new Paragraph($"Details of {itemName}")); // Title with the item's name.
                        pdfDocument.Add(new Paragraph(" ")); // Blank line for spacing.

                        // Add all the item details we collected earlier.
                        pdfDocument.Add(new Paragraph(itemDetails.ToString()));

                        // Done writing, so close the document.
                        pdfDocument.Close();

                        // Let the user know it worked.
                        MessageBox.Show("The selected item's details have been exported successfully to: " + filePath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // If nothing is selected, tell the user to pick something.
                    MessageBox.Show("Please select a cell first!");
                }
            }
            catch (Exception ex)
            {
                // Catch any errors and show a message to the user.
                MessageBox.Show("An error occurred while exporting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to make sure the file name doesn't contain any illegal characters.
        private string RemoveInvalidFileNameChars(string input)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                input = input.Replace(c.ToString(), "_"); // Replace illegal chars with underscores.
            }
            return input;
        }
    }
}
