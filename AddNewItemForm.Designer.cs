namespace ISDS454_IMS_Forms
{
    partial class AddNewItemForm
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
            AddNewItemLabel = new Label();
            NameInput = new TextBox();
            ItemNameLabel = new Label();
            QuantityLabel = new Label();
            LocationLabel = new Label();
            DescriptionLabel = new Label();
            ExpiratonDateLabel = new Label();
            CategoryLabel = new Label();
            SupplierLabel = new Label();
            CostLabel = new Label();
            QuantityInput = new TextBox();
            LocationInput = new TextBox();
            DescriptionInput = new TextBox();
            ExpirationDateInput = new TextBox();
            SupplierInput = new TextBox();
            CostInput = new TextBox();
            SellingPriceLabel = new Label();
            SellingPriceInput = new TextBox();
            CategoryInput = new TextBox();
            NewItemCancelButton = new Button();
            AddItemConfirmButton = new Button();
            skuInput = new TextBox();
            warehouseIDInput = new TextBox();
            warehouseIDLabel = new Label();
            skuLabel = new Label();
            SuspendLayout();
            // 
            // AddNewItemLabel
            // 
            AddNewItemLabel.Anchor = AnchorStyles.Top;
            AddNewItemLabel.AutoSize = true;
            AddNewItemLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewItemLabel.Location = new Point(330, 39);
            AddNewItemLabel.Name = "AddNewItemLabel";
            AddNewItemLabel.Size = new Size(297, 54);
            AddNewItemLabel.TabIndex = 0;
            AddNewItemLabel.Text = "Add New Item";
            AddNewItemLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameInput
            // 
            NameInput.Anchor = AnchorStyles.None;
            NameInput.Location = new Point(227, 225);
            NameInput.Margin = new Padding(3, 4, 3, 4);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(639, 27);
            NameInput.TabIndex = 1;
            NameInput.Text = "Enter item name";
            NameInput.TextChanged += NameInput_TextChanged;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.Anchor = AnchorStyles.None;
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNameLabel.Location = new Point(62, 223);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(71, 28);
            ItemNameLabel.TabIndex = 2;
            ItemNameLabel.Text = "Name:";
            ItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            ItemNameLabel.Click += ItemNameLabel_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.Anchor = AnchorStyles.None;
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(62, 287);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(95, 28);
            QuantityLabel.TabIndex = 3;
            QuantityLabel.Text = "Quantity:";
            QuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LocationLabel
            // 
            LocationLabel.Anchor = AnchorStyles.None;
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(62, 353);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(94, 28);
            LocationLabel.TabIndex = 4;
            LocationLabel.Text = "Location:";
            LocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.None;
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DescriptionLabel.Location = new Point(62, 420);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(120, 28);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExpiratonDateLabel
            // 
            ExpiratonDateLabel.Anchor = AnchorStyles.None;
            ExpiratonDateLabel.AutoSize = true;
            ExpiratonDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiratonDateLabel.Location = new Point(62, 492);
            ExpiratonDateLabel.Name = "ExpiratonDateLabel";
            ExpiratonDateLabel.Size = new Size(155, 28);
            ExpiratonDateLabel.TabIndex = 6;
            ExpiratonDateLabel.Text = "Expiration Date:";
            ExpiratonDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.None;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(62, 563);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(99, 28);
            CategoryLabel.TabIndex = 7;
            CategoryLabel.Text = "Category:";
            CategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplierLabel
            // 
            SupplierLabel.Anchor = AnchorStyles.None;
            SupplierLabel.AutoSize = true;
            SupplierLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierLabel.Location = new Point(62, 636);
            SupplierLabel.Name = "SupplierLabel";
            SupplierLabel.Size = new Size(93, 28);
            SupplierLabel.TabIndex = 8;
            SupplierLabel.Text = "Supplier:";
            SupplierLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CostLabel
            // 
            CostLabel.Anchor = AnchorStyles.None;
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CostLabel.Location = new Point(62, 704);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(137, 28);
            CostLabel.TabIndex = 9;
            CostLabel.Text = "Cost per Unit:";
            CostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuantityInput
            // 
            QuantityInput.Anchor = AnchorStyles.None;
            QuantityInput.Location = new Point(227, 284);
            QuantityInput.Margin = new Padding(3, 4, 3, 4);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(639, 27);
            QuantityInput.TabIndex = 10;
            QuantityInput.Text = "Enter item quantity";
            // 
            // LocationInput
            // 
            LocationInput.Anchor = AnchorStyles.None;
            LocationInput.Location = new Point(227, 351);
            LocationInput.Margin = new Padding(3, 4, 3, 4);
            LocationInput.Name = "LocationInput";
            LocationInput.Size = new Size(639, 27);
            LocationInput.TabIndex = 11;
            LocationInput.Text = "Enter item location";
            // 
            // DescriptionInput
            // 
            DescriptionInput.Anchor = AnchorStyles.None;
            DescriptionInput.Location = new Point(227, 417);
            DescriptionInput.Margin = new Padding(3, 4, 3, 4);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(639, 27);
            DescriptionInput.TabIndex = 12;
            DescriptionInput.Text = "Enter item description";
            // 
            // ExpirationDateInput
            // 
            ExpirationDateInput.Anchor = AnchorStyles.None;
            ExpirationDateInput.Location = new Point(227, 492);
            ExpirationDateInput.Margin = new Padding(3, 4, 3, 4);
            ExpirationDateInput.Name = "ExpirationDateInput";
            ExpirationDateInput.Size = new Size(639, 27);
            ExpirationDateInput.TabIndex = 13;
            ExpirationDateInput.Text = "Enter item expiration date if applicable";
            // 
            // SupplierInput
            // 
            SupplierInput.Anchor = AnchorStyles.None;
            SupplierInput.Location = new Point(227, 633);
            SupplierInput.Margin = new Padding(3, 4, 3, 4);
            SupplierInput.Name = "SupplierInput";
            SupplierInput.Size = new Size(639, 27);
            SupplierInput.TabIndex = 15;
            SupplierInput.Text = "Enter the name of the items supplier";
            // 
            // CostInput
            // 
            CostInput.Anchor = AnchorStyles.None;
            CostInput.Location = new Point(227, 701);
            CostInput.Margin = new Padding(3, 4, 3, 4);
            CostInput.Name = "CostInput";
            CostInput.Size = new Size(639, 27);
            CostInput.TabIndex = 16;
            CostInput.Text = "Enter item cost per unit";
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.Anchor = AnchorStyles.None;
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellingPriceLabel.Location = new Point(62, 772);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(128, 28);
            SellingPriceLabel.TabIndex = 17;
            SellingPriceLabel.Text = "Selling Price:";
            SellingPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SellingPriceInput
            // 
            SellingPriceInput.Anchor = AnchorStyles.None;
            SellingPriceInput.Location = new Point(227, 769);
            SellingPriceInput.Margin = new Padding(3, 4, 3, 4);
            SellingPriceInput.Name = "SellingPriceInput";
            SellingPriceInput.Size = new Size(639, 27);
            SellingPriceInput.TabIndex = 18;
            SellingPriceInput.Text = "Enter items selling price per unit";
            // 
            // CategoryInput
            // 
            CategoryInput.Anchor = AnchorStyles.None;
            CategoryInput.Location = new Point(227, 565);
            CategoryInput.Margin = new Padding(3, 4, 3, 4);
            CategoryInput.Name = "CategoryInput";
            CategoryInput.Size = new Size(639, 27);
            CategoryInput.TabIndex = 19;
            CategoryInput.Text = "Enter Items category";
            // 
            // NewItemCancelButton
            // 
            NewItemCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            NewItemCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            NewItemCancelButton.Location = new Point(14, 871);
            NewItemCancelButton.Margin = new Padding(3, 4, 3, 4);
            NewItemCancelButton.Name = "NewItemCancelButton";
            NewItemCancelButton.Size = new Size(137, 49);
            NewItemCancelButton.TabIndex = 20;
            NewItemCancelButton.Text = "Cancel";
            NewItemCancelButton.UseVisualStyleBackColor = false;
            NewItemCancelButton.Click += NewItemCancelButton_Click;
            // 
            // AddItemConfirmButton
            // 
            AddItemConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemConfirmButton.BackColor = Color.Lime;
            AddItemConfirmButton.Location = new Point(770, 871);
            AddItemConfirmButton.Margin = new Padding(3, 4, 3, 4);
            AddItemConfirmButton.Name = "AddItemConfirmButton";
            AddItemConfirmButton.Size = new Size(137, 49);
            AddItemConfirmButton.TabIndex = 21;
            AddItemConfirmButton.Text = "Add Item";
            AddItemConfirmButton.UseVisualStyleBackColor = false;
            AddItemConfirmButton.Click += AddItemConfirmButton_Click;
            // 
            // skuInput
            // 
            skuInput.Anchor = AnchorStyles.None;
            skuInput.Location = new Point(227, 97);
            skuInput.Margin = new Padding(3, 4, 3, 4);
            skuInput.Name = "skuInput";
            skuInput.Size = new Size(639, 27);
            skuInput.TabIndex = 22;
            skuInput.Text = "Enter item name";
            skuInput.TextChanged += skuInput_TextChanged;
            // 
            // warehouseIDInput
            // 
            warehouseIDInput.Anchor = AnchorStyles.None;
            warehouseIDInput.Location = new Point(227, 164);
            warehouseIDInput.Margin = new Padding(3, 4, 3, 4);
            warehouseIDInput.Name = "warehouseIDInput";
            warehouseIDInput.Size = new Size(639, 27);
            warehouseIDInput.TabIndex = 23;
            warehouseIDInput.Text = "Enter item name";
            // 
            // warehouseIDLabel
            // 
            warehouseIDLabel.Anchor = AnchorStyles.None;
            warehouseIDLabel.AutoSize = true;
            warehouseIDLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            warehouseIDLabel.Location = new Point(62, 164);
            warehouseIDLabel.Name = "warehouseIDLabel";
            warehouseIDLabel.Size = new Size(145, 28);
            warehouseIDLabel.TabIndex = 24;
            warehouseIDLabel.Text = "Warehouse ID:";
            warehouseIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // skuLabel
            // 
            skuLabel.Anchor = AnchorStyles.None;
            skuLabel.AutoSize = true;
            skuLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skuLabel.Location = new Point(62, 97);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new Size(54, 28);
            skuLabel.TabIndex = 25;
            skuLabel.Text = "SKU:";
            skuLabel.TextAlign = ContentAlignment.MiddleLeft;
            skuLabel.Click += label2_Click;
            // 
            // AddNewItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(921, 941);
            Controls.Add(skuLabel);
            Controls.Add(warehouseIDLabel);
            Controls.Add(warehouseIDInput);
            Controls.Add(skuInput);
            Controls.Add(AddItemConfirmButton);
            Controls.Add(NewItemCancelButton);
            Controls.Add(CategoryInput);
            Controls.Add(SellingPriceInput);
            Controls.Add(SellingPriceLabel);
            Controls.Add(CostInput);
            Controls.Add(SupplierInput);
            Controls.Add(ExpirationDateInput);
            Controls.Add(DescriptionInput);
            Controls.Add(LocationInput);
            Controls.Add(QuantityInput);
            Controls.Add(CostLabel);
            Controls.Add(SupplierLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(ExpiratonDateLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(LocationLabel);
            Controls.Add(QuantityLabel);
            Controls.Add(ItemNameLabel);
            Controls.Add(NameInput);
            Controls.Add(AddNewItemLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddNewItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Item Form";
            Load += AddNewItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewItemLabel;
        private TextBox NameInput;
        private Label ItemNameLabel;
        private Label QuantityLabel;
        private Label LocationLabel;
        private Label DescriptionLabel;
        private Label ExpiratonDateLabel;
        private Label CategoryLabel;
        private Label SupplierLabel;
        private Label CostLabel;
        private TextBox QuantityInput;
        private TextBox LocationInput;
        private TextBox DescriptionInput;
        private TextBox ExpirationDateInput;
        private TextBox SupplierInput;
        private TextBox CostInput;
        private Label SellingPriceLabel;
        private TextBox SellingPriceInput;
        private TextBox CategoryInput;
        private Button NewItemCancelButton;
        private Button AddItemConfirmButton;
        private TextBox skuInput;
        private TextBox warehouseIDInput;
        private Label warehouseIDLabel;
        private Label skuLabel;
    }
}