namespace ISDS454_IMS_Forms
{
    partial class ViewInventoryMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ViewIMSLabel = new Label();
            ViewLastUpdatesButton = new Button();
            LocateButton = new Button();
            ViewDetailsButton = new Button();
            ExportDataCheck = new CheckBox();
            ViewSearchTextBox = new TextBox();
            ViewSearchLabel = new Label();
            ViewCancelButton = new Button();
            ViewInventoryDataTable = new DataGridView();
            InventorySKU = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            ItemLocation = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ViewInventoryDataTable).BeginInit();
            SuspendLayout();
            // 
            // ViewIMSLabel
            // 
            ViewIMSLabel.AutoSize = true;
            ViewIMSLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewIMSLabel.Location = new Point(655, 70);
            ViewIMSLabel.Name = "ViewIMSLabel";
            ViewIMSLabel.Size = new Size(578, 45);
            ViewIMSLabel.TabIndex = 0;
            ViewIMSLabel.Text = "View: Inventory Management System";
            // 
            // ViewLastUpdatesButton
            // 
            ViewLastUpdatesButton.BackColor = Color.Cyan;
            ViewLastUpdatesButton.Location = new Point(1609, 1093);
            ViewLastUpdatesButton.Name = "ViewLastUpdatesButton";
            ViewLastUpdatesButton.Size = new Size(204, 45);
            ViewLastUpdatesButton.TabIndex = 3;
            ViewLastUpdatesButton.Text = "View Last  Updates";
            ViewLastUpdatesButton.UseVisualStyleBackColor = false;
            // 
            // LocateButton
            // 
            LocateButton.BackColor = Color.Coral;
            LocateButton.Location = new Point(1609, 1042);
            LocateButton.Name = "LocateButton";
            LocateButton.Size = new Size(204, 45);
            LocateButton.TabIndex = 4;
            LocateButton.Text = "Locate";
            LocateButton.UseVisualStyleBackColor = false;
            // 
            // ViewDetailsButton
            // 
            ViewDetailsButton.BackColor = Color.CornflowerBlue;
            ViewDetailsButton.Location = new Point(1609, 991);
            ViewDetailsButton.Name = "ViewDetailsButton";
            ViewDetailsButton.Size = new Size(204, 45);
            ViewDetailsButton.TabIndex = 5;
            ViewDetailsButton.Text = "View Details";
            ViewDetailsButton.UseVisualStyleBackColor = false;
            // 
            // ExportDataCheck
            // 
            ExportDataCheck.AutoSize = true;
            ExportDataCheck.Location = new Point(1505, 1119);
            ExportDataCheck.Name = "ExportDataCheck";
            ExportDataCheck.Size = new Size(87, 19);
            ExportDataCheck.TabIndex = 6;
            ExportDataCheck.Text = "Export Data";
            ExportDataCheck.UseVisualStyleBackColor = true;
            // 
            // ViewSearchTextBox
            // 
            ViewSearchTextBox.Location = new Point(1594, 150);
            ViewSearchTextBox.Name = "ViewSearchTextBox";
            ViewSearchTextBox.Size = new Size(219, 23);
            ViewSearchTextBox.TabIndex = 7;
            ViewSearchTextBox.Text = "Input SKU or product name";
            // 
            // ViewSearchLabel
            // 
            ViewSearchLabel.AutoSize = true;
            ViewSearchLabel.Location = new Point(1543, 153);
            ViewSearchLabel.Name = "ViewSearchLabel";
            ViewSearchLabel.Size = new Size(45, 15);
            ViewSearchLabel.TabIndex = 8;
            ViewSearchLabel.Text = "Search:";
            // 
            // ViewCancelButton
            // 
            ViewCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            ViewCancelButton.Location = new Point(12, 1098);
            ViewCancelButton.Name = "ViewCancelButton";
            ViewCancelButton.Size = new Size(204, 45);
            ViewCancelButton.TabIndex = 9;
            ViewCancelButton.Text = "Cancel";
            ViewCancelButton.UseVisualStyleBackColor = false;
            ViewCancelButton.Click += ViewCancelButton_Click;
            // 
            // ViewInventoryDataTable
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewInventoryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewInventoryDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewInventoryDataTable.Columns.AddRange(new DataGridViewColumn[] { InventorySKU, ItemName, ItemQuantity, ItemLocation });
            ViewInventoryDataTable.Location = new Point(12, 174);
            ViewInventoryDataTable.Name = "ViewInventoryDataTable";
            ViewInventoryDataTable.Size = new Size(1801, 807);
            ViewInventoryDataTable.TabIndex = 10;
            // 
            // InventorySKU
            // 
            InventorySKU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            InventorySKU.HeaderText = "Inventory SKU";
            InventorySKU.Name = "InventorySKU";
            // 
            // ItemName
            // 
            ItemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemName.HeaderText = "Item Name";
            ItemName.Name = "ItemName";
            // 
            // ItemQuantity
            // 
            ItemQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemQuantity.HeaderText = "Quantity";
            ItemQuantity.Name = "ItemQuantity";
            // 
            // ItemLocation
            // 
            ItemLocation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemLocation.HeaderText = "Location";
            ItemLocation.Name = "ItemLocation";
            // 
            // ViewInventoryMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 1155);
            Controls.Add(ViewInventoryDataTable);
            Controls.Add(ViewCancelButton);
            Controls.Add(ViewSearchLabel);
            Controls.Add(ViewSearchTextBox);
            Controls.Add(ExportDataCheck);
            Controls.Add(ViewDetailsButton);
            Controls.Add(LocateButton);
            Controls.Add(ViewLastUpdatesButton);
            Controls.Add(ViewIMSLabel);
            Name = "ViewInventoryMain";
            Text = "View: Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)ViewInventoryDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ViewIMSLabel;
        private Button ViewLastUpdatesButton;
        private Button LocateButton;
        private Button ViewDetailsButton;
        private CheckBox ExportDataCheck;
        private TextBox ViewSearchTextBox;
        private Label ViewSearchLabel;
        private Button ViewCancelButton;
        private DataGridView ViewInventoryDataTable;
        private DataGridViewTextBoxColumn InventorySKU;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn ItemLocation;
    }
}