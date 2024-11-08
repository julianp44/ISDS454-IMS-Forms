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
            SuspendLayout();
            // 
            // AddNewItemLabel
            // 
            AddNewItemLabel.AutoSize = true;
            AddNewItemLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewItemLabel.Location = new Point(354, 29);
            AddNewItemLabel.Name = "AddNewItemLabel";
            AddNewItemLabel.Size = new Size(237, 45);
            AddNewItemLabel.TabIndex = 0;
            AddNewItemLabel.Text = "Add New Item";
            AddNewItemLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(220, 163);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(560, 23);
            NameInput.TabIndex = 1;
            NameInput.Text = "Enter item name";
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemNameLabel.Location = new Point(75, 161);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(57, 21);
            ItemNameLabel.TabIndex = 2;
            ItemNameLabel.Text = "Name:";
            ItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            ItemNameLabel.Click += ItemNameLabel_Click;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(75, 209);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(76, 21);
            QuantityLabel.TabIndex = 3;
            QuantityLabel.Text = "Quantity:";
            QuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocationLabel.Location = new Point(75, 259);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(77, 21);
            LocationLabel.TabIndex = 4;
            LocationLabel.Text = "Location:";
            LocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DescriptionLabel.Location = new Point(75, 309);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(98, 21);
            DescriptionLabel.TabIndex = 5;
            DescriptionLabel.Text = "Description:";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExpiratonDateLabel
            // 
            ExpiratonDateLabel.AutoSize = true;
            ExpiratonDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiratonDateLabel.Location = new Point(75, 363);
            ExpiratonDateLabel.Name = "ExpiratonDateLabel";
            ExpiratonDateLabel.Size = new Size(125, 21);
            ExpiratonDateLabel.TabIndex = 6;
            ExpiratonDateLabel.Text = "Expiration Date:";
            ExpiratonDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.Location = new Point(75, 416);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(82, 21);
            CategoryLabel.TabIndex = 7;
            CategoryLabel.Text = "Category:";
            CategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SupplierLabel
            // 
            SupplierLabel.AutoSize = true;
            SupplierLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierLabel.Location = new Point(81, 471);
            SupplierLabel.Name = "SupplierLabel";
            SupplierLabel.Size = new Size(76, 21);
            SupplierLabel.TabIndex = 8;
            SupplierLabel.Text = "Supplier:";
            SupplierLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CostLabel.Location = new Point(75, 522);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(110, 21);
            CostLabel.TabIndex = 9;
            CostLabel.Text = "Cost per Unit:";
            CostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuantityInput
            // 
            QuantityInput.Location = new Point(220, 207);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(560, 23);
            QuantityInput.TabIndex = 10;
            QuantityInput.Text = "Enter item quantity";
            // 
            // LocationInput
            // 
            LocationInput.Location = new Point(220, 257);
            LocationInput.Name = "LocationInput";
            LocationInput.Size = new Size(560, 23);
            LocationInput.TabIndex = 11;
            LocationInput.Text = "Enter item location";
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(220, 307);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(560, 23);
            DescriptionInput.TabIndex = 12;
            DescriptionInput.Text = "Enter item description";
            // 
            // ExpirationDateInput
            // 
            ExpirationDateInput.Location = new Point(220, 363);
            ExpirationDateInput.Name = "ExpirationDateInput";
            ExpirationDateInput.Size = new Size(560, 23);
            ExpirationDateInput.TabIndex = 13;
            ExpirationDateInput.Text = "Enter item expiration date if applicable";
            // 
            // SupplierInput
            // 
            SupplierInput.Location = new Point(220, 469);
            SupplierInput.Name = "SupplierInput";
            SupplierInput.Size = new Size(560, 23);
            SupplierInput.TabIndex = 15;
            SupplierInput.Text = "Enter the name of the items supplier";
            // 
            // CostInput
            // 
            CostInput.Location = new Point(220, 520);
            CostInput.Name = "CostInput";
            CostInput.Size = new Size(560, 23);
            CostInput.TabIndex = 16;
            CostInput.Text = "Enter item cost per unit";
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellingPriceLabel.Location = new Point(75, 573);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(103, 21);
            SellingPriceLabel.TabIndex = 17;
            SellingPriceLabel.Text = "Selling Price:";
            SellingPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SellingPriceInput
            // 
            SellingPriceInput.Location = new Point(220, 571);
            SellingPriceInput.Name = "SellingPriceInput";
            SellingPriceInput.Size = new Size(560, 23);
            SellingPriceInput.TabIndex = 18;
            SellingPriceInput.Text = "Enter items selling price per unit";
            // 
            // CategoryInput
            // 
            CategoryInput.Location = new Point(220, 418);
            CategoryInput.Name = "CategoryInput";
            CategoryInput.Size = new Size(560, 23);
            CategoryInput.TabIndex = 19;
            CategoryInput.Text = "Enter Items category";
            // 
            // AddNewItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 875);
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
            Name = "AddNewItemForm";
            Text = "New Item Form";
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
    }
}