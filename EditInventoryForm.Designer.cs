namespace ISDS454_IMS_Forms
{
    partial class EditInventoryForm
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
            EditItemLabel = new Label();
            editskuLabel = new Label();
            editwarehouseIDLabel = new Label();
            editwarehouseIDInput = new TextBox();
            editskuInput = new TextBox();
            editCategoryInput = new TextBox();
            editSellingPriceInput = new TextBox();
            editSellingPriceLabel = new Label();
            editCostInput = new TextBox();
            editSupplierInput = new TextBox();
            editExpirationDateInput = new TextBox();
            editDescriptionInput = new TextBox();
            editLocationInput = new TextBox();
            editQuantityInput = new TextBox();
            editCostLabel = new Label();
            editSupplierLabel = new Label();
            editCategoryLabel = new Label();
            editExpiratonDateLabel = new Label();
            editDescriptionLabel = new Label();
            editLocationLabel = new Label();
            editQuantityLabel = new Label();
            editItemNameLabel = new Label();
            editNameInput = new TextBox();
            editItemCancelButton = new Button();
            editItemConfirmButton = new Button();
            editDatagridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)editDatagridView).BeginInit();
            SuspendLayout();
            // 
            // EditItemLabel
            // 
            EditItemLabel.Anchor = AnchorStyles.Top;
            EditItemLabel.AutoSize = true;
            EditItemLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditItemLabel.Location = new Point(935, 21);
            EditItemLabel.Name = "EditItemLabel";
            EditItemLabel.Size = new Size(155, 45);
            EditItemLabel.TabIndex = 1;
            EditItemLabel.Text = "Edit Item";
            EditItemLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // editskuLabel
            // 
            editskuLabel.Anchor = AnchorStyles.None;
            editskuLabel.AutoSize = true;
            editskuLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editskuLabel.Location = new Point(605, 91);
            editskuLabel.Name = "editskuLabel";
            editskuLabel.Size = new Size(44, 21);
            editskuLabel.TabIndex = 47;
            editskuLabel.Text = "SKU:";
            editskuLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editwarehouseIDLabel
            // 
            editwarehouseIDLabel.Anchor = AnchorStyles.None;
            editwarehouseIDLabel.AutoSize = true;
            editwarehouseIDLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editwarehouseIDLabel.Location = new Point(605, 141);
            editwarehouseIDLabel.Name = "editwarehouseIDLabel";
            editwarehouseIDLabel.Size = new Size(115, 21);
            editwarehouseIDLabel.TabIndex = 46;
            editwarehouseIDLabel.Text = "Warehouse ID:";
            editwarehouseIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editwarehouseIDInput
            // 
            editwarehouseIDInput.Anchor = AnchorStyles.None;
            editwarehouseIDInput.Location = new Point(750, 141);
            editwarehouseIDInput.Name = "editwarehouseIDInput";
            editwarehouseIDInput.Size = new Size(560, 23);
            editwarehouseIDInput.TabIndex = 45;
            editwarehouseIDInput.Text = "Enter item name";
            // 
            // editskuInput
            // 
            editskuInput.Anchor = AnchorStyles.None;
            editskuInput.Location = new Point(750, 91);
            editskuInput.Name = "editskuInput";
            editskuInput.Size = new Size(560, 23);
            editskuInput.TabIndex = 44;
            editskuInput.Text = "Enter item name";
            // 
            // editCategoryInput
            // 
            editCategoryInput.Anchor = AnchorStyles.None;
            editCategoryInput.Location = new Point(750, 442);
            editCategoryInput.Name = "editCategoryInput";
            editCategoryInput.Size = new Size(560, 23);
            editCategoryInput.TabIndex = 43;
            editCategoryInput.Text = "Enter Items category";
            // 
            // editSellingPriceInput
            // 
            editSellingPriceInput.Anchor = AnchorStyles.None;
            editSellingPriceInput.Location = new Point(750, 595);
            editSellingPriceInput.Name = "editSellingPriceInput";
            editSellingPriceInput.Size = new Size(560, 23);
            editSellingPriceInput.TabIndex = 42;
            editSellingPriceInput.Text = "Enter items selling price per unit";
            // 
            // editSellingPriceLabel
            // 
            editSellingPriceLabel.Anchor = AnchorStyles.None;
            editSellingPriceLabel.AutoSize = true;
            editSellingPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSellingPriceLabel.Location = new Point(605, 597);
            editSellingPriceLabel.Name = "editSellingPriceLabel";
            editSellingPriceLabel.Size = new Size(103, 21);
            editSellingPriceLabel.TabIndex = 41;
            editSellingPriceLabel.Text = "Selling Price:";
            editSellingPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editCostInput
            // 
            editCostInput.Anchor = AnchorStyles.None;
            editCostInput.Location = new Point(750, 544);
            editCostInput.Name = "editCostInput";
            editCostInput.Size = new Size(560, 23);
            editCostInput.TabIndex = 40;
            editCostInput.Text = "Enter item cost per unit";
            // 
            // editSupplierInput
            // 
            editSupplierInput.Anchor = AnchorStyles.None;
            editSupplierInput.Location = new Point(750, 493);
            editSupplierInput.Name = "editSupplierInput";
            editSupplierInput.Size = new Size(560, 23);
            editSupplierInput.TabIndex = 39;
            editSupplierInput.Text = "Enter the name of the items supplier";
            // 
            // editExpirationDateInput
            // 
            editExpirationDateInput.Anchor = AnchorStyles.None;
            editExpirationDateInput.Location = new Point(750, 387);
            editExpirationDateInput.Name = "editExpirationDateInput";
            editExpirationDateInput.Size = new Size(560, 23);
            editExpirationDateInput.TabIndex = 38;
            editExpirationDateInput.Text = "Enter item expiration date if applicable";
            // 
            // editDescriptionInput
            // 
            editDescriptionInput.Anchor = AnchorStyles.None;
            editDescriptionInput.Location = new Point(750, 331);
            editDescriptionInput.Name = "editDescriptionInput";
            editDescriptionInput.Size = new Size(560, 23);
            editDescriptionInput.TabIndex = 37;
            editDescriptionInput.Text = "Enter item description";
            // 
            // editLocationInput
            // 
            editLocationInput.Anchor = AnchorStyles.None;
            editLocationInput.Location = new Point(750, 281);
            editLocationInput.Name = "editLocationInput";
            editLocationInput.Size = new Size(560, 23);
            editLocationInput.TabIndex = 36;
            editLocationInput.Text = "Enter item location";
            // 
            // editQuantityInput
            // 
            editQuantityInput.Anchor = AnchorStyles.None;
            editQuantityInput.Location = new Point(750, 231);
            editQuantityInput.Name = "editQuantityInput";
            editQuantityInput.Size = new Size(560, 23);
            editQuantityInput.TabIndex = 35;
            editQuantityInput.Text = "Enter item quantity";
            // 
            // editCostLabel
            // 
            editCostLabel.Anchor = AnchorStyles.None;
            editCostLabel.AutoSize = true;
            editCostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCostLabel.Location = new Point(605, 546);
            editCostLabel.Name = "editCostLabel";
            editCostLabel.Size = new Size(110, 21);
            editCostLabel.TabIndex = 34;
            editCostLabel.Text = "Cost per Unit:";
            editCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editSupplierLabel
            // 
            editSupplierLabel.Anchor = AnchorStyles.None;
            editSupplierLabel.AutoSize = true;
            editSupplierLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editSupplierLabel.Location = new Point(605, 495);
            editSupplierLabel.Name = "editSupplierLabel";
            editSupplierLabel.Size = new Size(76, 21);
            editSupplierLabel.TabIndex = 33;
            editSupplierLabel.Text = "Supplier:";
            editSupplierLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editCategoryLabel
            // 
            editCategoryLabel.Anchor = AnchorStyles.None;
            editCategoryLabel.AutoSize = true;
            editCategoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editCategoryLabel.Location = new Point(605, 440);
            editCategoryLabel.Name = "editCategoryLabel";
            editCategoryLabel.Size = new Size(82, 21);
            editCategoryLabel.TabIndex = 32;
            editCategoryLabel.Text = "Category:";
            editCategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editExpiratonDateLabel
            // 
            editExpiratonDateLabel.Anchor = AnchorStyles.None;
            editExpiratonDateLabel.AutoSize = true;
            editExpiratonDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editExpiratonDateLabel.Location = new Point(605, 387);
            editExpiratonDateLabel.Name = "editExpiratonDateLabel";
            editExpiratonDateLabel.Size = new Size(125, 21);
            editExpiratonDateLabel.TabIndex = 31;
            editExpiratonDateLabel.Text = "Expiration Date:";
            editExpiratonDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editDescriptionLabel
            // 
            editDescriptionLabel.Anchor = AnchorStyles.None;
            editDescriptionLabel.AutoSize = true;
            editDescriptionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDescriptionLabel.Location = new Point(605, 333);
            editDescriptionLabel.Name = "editDescriptionLabel";
            editDescriptionLabel.Size = new Size(98, 21);
            editDescriptionLabel.TabIndex = 30;
            editDescriptionLabel.Text = "Description:";
            editDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editLocationLabel
            // 
            editLocationLabel.Anchor = AnchorStyles.None;
            editLocationLabel.AutoSize = true;
            editLocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editLocationLabel.Location = new Point(605, 283);
            editLocationLabel.Name = "editLocationLabel";
            editLocationLabel.Size = new Size(77, 21);
            editLocationLabel.TabIndex = 29;
            editLocationLabel.Text = "Location:";
            editLocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editQuantityLabel
            // 
            editQuantityLabel.Anchor = AnchorStyles.None;
            editQuantityLabel.AutoSize = true;
            editQuantityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editQuantityLabel.Location = new Point(605, 233);
            editQuantityLabel.Name = "editQuantityLabel";
            editQuantityLabel.Size = new Size(76, 21);
            editQuantityLabel.TabIndex = 28;
            editQuantityLabel.Text = "Quantity:";
            editQuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editItemNameLabel
            // 
            editItemNameLabel.Anchor = AnchorStyles.None;
            editItemNameLabel.AutoSize = true;
            editItemNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editItemNameLabel.Location = new Point(605, 185);
            editItemNameLabel.Name = "editItemNameLabel";
            editItemNameLabel.Size = new Size(57, 21);
            editItemNameLabel.TabIndex = 27;
            editItemNameLabel.Text = "Name:";
            editItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editNameInput
            // 
            editNameInput.Anchor = AnchorStyles.None;
            editNameInput.Location = new Point(750, 187);
            editNameInput.Name = "editNameInput";
            editNameInput.Size = new Size(560, 23);
            editNameInput.TabIndex = 26;
            editNameInput.Text = "Enter item name";
            // 
            // editItemCancelButton
            // 
            editItemCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editItemCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            editItemCancelButton.Location = new Point(607, 657);
            editItemCancelButton.Name = "editItemCancelButton";
            editItemCancelButton.Size = new Size(120, 37);
            editItemCancelButton.TabIndex = 48;
            editItemCancelButton.Text = "Cancel";
            editItemCancelButton.UseVisualStyleBackColor = false;
            editItemCancelButton.Click += editItemCancelButton_Click;
            // 
            // editItemConfirmButton
            // 
            editItemConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editItemConfirmButton.BackColor = Color.Lime;
            editItemConfirmButton.Location = new Point(1190, 657);
            editItemConfirmButton.Name = "editItemConfirmButton";
            editItemConfirmButton.Size = new Size(120, 37);
            editItemConfirmButton.TabIndex = 49;
            editItemConfirmButton.Text = "Confirm Edit";
            editItemConfirmButton.UseVisualStyleBackColor = false;
            editItemConfirmButton.Click += editItemConfirmButton_Click;
            // 
            // editDatagridView
            // 
            editDatagridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            editDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            editDatagridView.Location = new Point(12, 56);
            editDatagridView.Name = "editDatagridView";
            editDatagridView.Size = new Size(576, 638);
            editDatagridView.TabIndex = 50;
            editDatagridView.CellClick += editDatagridView_CellClick;
            editDatagridView.CellContentClick += editDatagridView_CellContentClick;
            // 
            // EditInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 706);
            Controls.Add(editDatagridView);
            Controls.Add(editItemConfirmButton);
            Controls.Add(editItemCancelButton);
            Controls.Add(editskuLabel);
            Controls.Add(editwarehouseIDLabel);
            Controls.Add(editwarehouseIDInput);
            Controls.Add(editskuInput);
            Controls.Add(editCategoryInput);
            Controls.Add(editSellingPriceInput);
            Controls.Add(editSellingPriceLabel);
            Controls.Add(editCostInput);
            Controls.Add(editSupplierInput);
            Controls.Add(editExpirationDateInput);
            Controls.Add(editDescriptionInput);
            Controls.Add(editLocationInput);
            Controls.Add(editQuantityInput);
            Controls.Add(editCostLabel);
            Controls.Add(editSupplierLabel);
            Controls.Add(editCategoryLabel);
            Controls.Add(editExpiratonDateLabel);
            Controls.Add(editDescriptionLabel);
            Controls.Add(editLocationLabel);
            Controls.Add(editQuantityLabel);
            Controls.Add(editItemNameLabel);
            Controls.Add(editNameInput);
            Controls.Add(EditItemLabel);
            Name = "EditInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditInventoryForm";
            ((System.ComponentModel.ISupportInitialize)editDatagridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditItemLabel;
        private Label editskuLabel;
        private Label editwarehouseIDLabel;
        private TextBox editwarehouseIDInput;
        private TextBox editskuInput;
        private TextBox editCategoryInput;
        private TextBox editSellingPriceInput;
        private Label editSellingPriceLabel;
        private TextBox editCostInput;
        private TextBox editSupplierInput;
        private TextBox editExpirationDateInput;
        private TextBox editDescriptionInput;
        private TextBox editLocationInput;
        private TextBox editQuantityInput;
        private Label editCostLabel;
        private Label editSupplierLabel;
        private Label editCategoryLabel;
        private Label editExpiratonDateLabel;
        private Label editDescriptionLabel;
        private Label editLocationLabel;
        private Label editQuantityLabel;
        private Label editItemNameLabel;
        private TextBox editNameInput;
        private Button editItemCancelButton;
        private Button editItemConfirmButton;
        private DataGridView editDatagridView;
    }
}