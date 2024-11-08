namespace ISDS454_IMS_Forms
{
    partial class EditInventoryMain
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            EditIMSLabel = new Label();
            AddItemButton = new Button();
            EditInventoryCancelButton = new Button();
            NextButton = new Button();
            UpdateItemCheck = new CheckBox();
            DeleteItemCheck = new CheckBox();
            EditInventoryDataTable = new DataGridView();
            InventorySKU = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            ItemQuantity = new DataGridViewTextBoxColumn();
            ItemLocation = new DataGridViewTextBoxColumn();
            EditSearchLabel = new Label();
            EditSearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EditInventoryDataTable).BeginInit();
            SuspendLayout();
            // 
            // EditIMSLabel
            // 
            EditIMSLabel.AutoSize = true;
            EditIMSLabel.ForeColor = SystemColors.ControlText;
            EditIMSLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            EditIMSLabel.Location = new Point(653, 58);
            EditIMSLabel.Margin = new Padding(8, 0, 8, 0);
            EditIMSLabel.Name = "EditIMSLabel";
            EditIMSLabel.Size = new Size(563, 45);
            EditIMSLabel.TabIndex = 0;
            EditIMSLabel.Text = "Edit: Inventory Management System";
            // 
            // AddItemButton
            // 
            AddItemButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddItemButton.Location = new Point(12, 998);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(161, 35);
            AddItemButton.TabIndex = 2;
            AddItemButton.Text = "Add New Inventory Item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // EditInventoryCancelButton
            // 
            EditInventoryCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            EditInventoryCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditInventoryCancelButton.Location = new Point(12, 1096);
            EditInventoryCancelButton.Name = "EditInventoryCancelButton";
            EditInventoryCancelButton.Size = new Size(180, 47);
            EditInventoryCancelButton.TabIndex = 3;
            EditInventoryCancelButton.Text = "Cancel";
            EditInventoryCancelButton.UseVisualStyleBackColor = false;
            EditInventoryCancelButton.Click += CancelButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.CornflowerBlue;
            NextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButton.Location = new Point(1633, 1096);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(180, 47);
            NextButton.TabIndex = 4;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // UpdateItemCheck
            // 
            UpdateItemCheck.AutoSize = true;
            UpdateItemCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateItemCheck.Location = new Point(196, 1008);
            UpdateItemCheck.Name = "UpdateItemCheck";
            UpdateItemCheck.Size = new Size(114, 25);
            UpdateItemCheck.TabIndex = 5;
            UpdateItemCheck.Text = "Update Item";
            UpdateItemCheck.UseVisualStyleBackColor = true;
            // 
            // DeleteItemCheck
            // 
            DeleteItemCheck.AutoSize = true;
            DeleteItemCheck.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteItemCheck.Location = new Point(327, 1008);
            DeleteItemCheck.Name = "DeleteItemCheck";
            DeleteItemCheck.Size = new Size(108, 25);
            DeleteItemCheck.TabIndex = 6;
            DeleteItemCheck.Text = "Delete Item";
            DeleteItemCheck.UseVisualStyleBackColor = true;
            // 
            // EditInventoryDataTable
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EditInventoryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EditInventoryDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditInventoryDataTable.Columns.AddRange(new DataGridViewColumn[] { InventorySKU, ItemName, ItemQuantity, ItemLocation });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EditInventoryDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            EditInventoryDataTable.Location = new Point(12, 174);
            EditInventoryDataTable.Name = "EditInventoryDataTable";
            EditInventoryDataTable.Size = new Size(1801, 807);
            EditInventoryDataTable.TabIndex = 7;
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
            // EditSearchLabel
            // 
            EditSearchLabel.AutoSize = true;
            EditSearchLabel.Font = new Font("Segoe UI", 9.75F);
            EditSearchLabel.Location = new Point(1543, 146);
            EditSearchLabel.Name = "EditSearchLabel";
            EditSearchLabel.Size = new Size(50, 17);
            EditSearchLabel.TabIndex = 10;
            EditSearchLabel.Text = "Search:";
            // 
            // EditSearchTextBox
            // 
            EditSearchTextBox.Font = new Font("Segoe UI", 9.75F);
            EditSearchTextBox.Location = new Point(1594, 143);
            EditSearchTextBox.Name = "EditSearchTextBox";
            EditSearchTextBox.Size = new Size(219, 25);
            EditSearchTextBox.TabIndex = 9;
            EditSearchTextBox.Text = "Input SKU or product name";
            // 
            // EditInventoryMain
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1825, 1155);
            Controls.Add(EditSearchLabel);
            Controls.Add(EditSearchTextBox);
            Controls.Add(EditInventoryDataTable);
            Controls.Add(DeleteItemCheck);
            Controls.Add(UpdateItemCheck);
            Controls.Add(NextButton);
            Controls.Add(EditInventoryCancelButton);
            Controls.Add(AddItemButton);
            Controls.Add(EditIMSLabel);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "EditInventoryMain";
            Text = "Edit: Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)EditInventoryDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditIMSLabel;
        private Button AddItemButton;
        private Button EditInventoryCancelButton;
        private Button NextButton;
        private CheckBox UpdateItemCheck;
        private CheckBox DeleteItemCheck;
        private DataGridView EditInventoryDataTable;
        private Label EditSearchLabel;
        private TextBox EditSearchTextBox;
        private DataGridViewTextBoxColumn InventorySKU;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemQuantity;
        private DataGridViewTextBoxColumn ItemLocation;
    }
}