namespace ISDS454_IMS_Forms
{
    partial class UpdateItemForm
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
            UpdateItemConfirmButton = new Button();
            UpdateCancelButton = new Button();
            UpdateCategoryInput = new TextBox();
            UpdateSellingPriceInput = new TextBox();
            UpdateSellingPriceLabel = new Label();
            UpdateCostInput = new TextBox();
            UpdateSupplierInput = new TextBox();
            UpdateExpirationDateInput = new TextBox();
            UpdateDescriptionInput = new TextBox();
            UpdateLocationInput = new TextBox();
            UpdateQuantityInput = new TextBox();
            UpdateCostLabel = new Label();
            UpdateSupplierLabel = new Label();
            UpdateCategoryLabel = new Label();
            UpdateExpiratonDateLabel = new Label();
            UpdateDescriptionLabel = new Label();
            UpdateLocationLabel = new Label();
            UpdateQuantityLabel = new Label();
            UpdateItemNameLabel = new Label();
            UpdateNameInput = new TextBox();
            UpdateItemLabel = new Label();
            SuspendLayout();
            // 
            // UpdateItemConfirmButton
            // 
            UpdateItemConfirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateItemConfirmButton.BackColor = Color.Lime;
            UpdateItemConfirmButton.Location = new Point(621, 666);
            UpdateItemConfirmButton.Name = "UpdateItemConfirmButton";
            UpdateItemConfirmButton.Size = new Size(120, 37);
            UpdateItemConfirmButton.TabIndex = 42;
            UpdateItemConfirmButton.Text = "Update Item";
            UpdateItemConfirmButton.UseVisualStyleBackColor = false;
            UpdateItemConfirmButton.Click += UpdateItemConfirmButton_Click;
            // 
            // UpdateCancelButton
            // 
            UpdateCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            UpdateCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            UpdateCancelButton.Location = new Point(71, 666);
            UpdateCancelButton.Name = "UpdateCancelButton";
            UpdateCancelButton.Size = new Size(120, 37);
            UpdateCancelButton.TabIndex = 41;
            UpdateCancelButton.Text = "Cancel";
            UpdateCancelButton.UseVisualStyleBackColor = false;
            UpdateCancelButton.Click += UpdateCancelButton_Click;
            // 
            // UpdateCategoryInput
            // 
            UpdateCategoryInput.Anchor = AnchorStyles.None;
            UpdateCategoryInput.Location = new Point(158, 330);
            UpdateCategoryInput.Name = "UpdateCategoryInput";
            UpdateCategoryInput.Size = new Size(560, 23);
            UpdateCategoryInput.TabIndex = 40;
            UpdateCategoryInput.Text = "Enter Items category";
            // 
            // UpdateSellingPriceInput
            // 
            UpdateSellingPriceInput.Anchor = AnchorStyles.None;
            UpdateSellingPriceInput.Location = new Point(158, 483);
            UpdateSellingPriceInput.Name = "UpdateSellingPriceInput";
            UpdateSellingPriceInput.Size = new Size(560, 23);
            UpdateSellingPriceInput.TabIndex = 39;
            UpdateSellingPriceInput.Text = "Enter items selling price per unit";
            // 
            // UpdateSellingPriceLabel
            // 
            UpdateSellingPriceLabel.Anchor = AnchorStyles.None;
            UpdateSellingPriceLabel.AutoSize = true;
            UpdateSellingPriceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateSellingPriceLabel.Location = new Point(13, 485);
            UpdateSellingPriceLabel.Name = "UpdateSellingPriceLabel";
            UpdateSellingPriceLabel.Size = new Size(103, 21);
            UpdateSellingPriceLabel.TabIndex = 38;
            UpdateSellingPriceLabel.Text = "Selling Price:";
            UpdateSellingPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateCostInput
            // 
            UpdateCostInput.Anchor = AnchorStyles.None;
            UpdateCostInput.Location = new Point(158, 432);
            UpdateCostInput.Name = "UpdateCostInput";
            UpdateCostInput.Size = new Size(560, 23);
            UpdateCostInput.TabIndex = 37;
            UpdateCostInput.Text = "Enter item cost per unit";
            // 
            // UpdateSupplierInput
            // 
            UpdateSupplierInput.Anchor = AnchorStyles.None;
            UpdateSupplierInput.Location = new Point(158, 381);
            UpdateSupplierInput.Name = "UpdateSupplierInput";
            UpdateSupplierInput.Size = new Size(560, 23);
            UpdateSupplierInput.TabIndex = 36;
            UpdateSupplierInput.Text = "Enter the name of the items supplier";
            // 
            // UpdateExpirationDateInput
            // 
            UpdateExpirationDateInput.Anchor = AnchorStyles.None;
            UpdateExpirationDateInput.Location = new Point(158, 275);
            UpdateExpirationDateInput.Name = "UpdateExpirationDateInput";
            UpdateExpirationDateInput.Size = new Size(560, 23);
            UpdateExpirationDateInput.TabIndex = 35;
            UpdateExpirationDateInput.Text = "Enter item expiration date if applicable";
            // 
            // UpdateDescriptionInput
            // 
            UpdateDescriptionInput.Anchor = AnchorStyles.None;
            UpdateDescriptionInput.Location = new Point(158, 219);
            UpdateDescriptionInput.Name = "UpdateDescriptionInput";
            UpdateDescriptionInput.Size = new Size(560, 23);
            UpdateDescriptionInput.TabIndex = 34;
            UpdateDescriptionInput.Text = "Enter item description";
            // 
            // UpdateLocationInput
            // 
            UpdateLocationInput.Anchor = AnchorStyles.None;
            UpdateLocationInput.Location = new Point(158, 169);
            UpdateLocationInput.Name = "UpdateLocationInput";
            UpdateLocationInput.Size = new Size(560, 23);
            UpdateLocationInput.TabIndex = 33;
            UpdateLocationInput.Text = "Enter item location";
            // 
            // UpdateQuantityInput
            // 
            UpdateQuantityInput.Anchor = AnchorStyles.None;
            UpdateQuantityInput.Location = new Point(158, 119);
            UpdateQuantityInput.Name = "UpdateQuantityInput";
            UpdateQuantityInput.Size = new Size(560, 23);
            UpdateQuantityInput.TabIndex = 32;
            UpdateQuantityInput.Text = "Enter item quantity";
            // 
            // UpdateCostLabel
            // 
            UpdateCostLabel.Anchor = AnchorStyles.None;
            UpdateCostLabel.AutoSize = true;
            UpdateCostLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateCostLabel.Location = new Point(13, 434);
            UpdateCostLabel.Name = "UpdateCostLabel";
            UpdateCostLabel.Size = new Size(110, 21);
            UpdateCostLabel.TabIndex = 31;
            UpdateCostLabel.Text = "Cost per Unit:";
            UpdateCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateSupplierLabel
            // 
            UpdateSupplierLabel.Anchor = AnchorStyles.None;
            UpdateSupplierLabel.AutoSize = true;
            UpdateSupplierLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateSupplierLabel.Location = new Point(13, 383);
            UpdateSupplierLabel.Name = "UpdateSupplierLabel";
            UpdateSupplierLabel.Size = new Size(76, 21);
            UpdateSupplierLabel.TabIndex = 30;
            UpdateSupplierLabel.Text = "Supplier:";
            UpdateSupplierLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateCategoryLabel
            // 
            UpdateCategoryLabel.Anchor = AnchorStyles.None;
            UpdateCategoryLabel.AutoSize = true;
            UpdateCategoryLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateCategoryLabel.Location = new Point(13, 328);
            UpdateCategoryLabel.Name = "UpdateCategoryLabel";
            UpdateCategoryLabel.Size = new Size(82, 21);
            UpdateCategoryLabel.TabIndex = 29;
            UpdateCategoryLabel.Text = "Category:";
            UpdateCategoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateExpiratonDateLabel
            // 
            UpdateExpiratonDateLabel.Anchor = AnchorStyles.None;
            UpdateExpiratonDateLabel.AutoSize = true;
            UpdateExpiratonDateLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateExpiratonDateLabel.Location = new Point(13, 275);
            UpdateExpiratonDateLabel.Name = "UpdateExpiratonDateLabel";
            UpdateExpiratonDateLabel.Size = new Size(125, 21);
            UpdateExpiratonDateLabel.TabIndex = 28;
            UpdateExpiratonDateLabel.Text = "Expiration Date:";
            UpdateExpiratonDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateDescriptionLabel
            // 
            UpdateDescriptionLabel.Anchor = AnchorStyles.None;
            UpdateDescriptionLabel.AutoSize = true;
            UpdateDescriptionLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateDescriptionLabel.Location = new Point(13, 221);
            UpdateDescriptionLabel.Name = "UpdateDescriptionLabel";
            UpdateDescriptionLabel.Size = new Size(98, 21);
            UpdateDescriptionLabel.TabIndex = 27;
            UpdateDescriptionLabel.Text = "Description:";
            UpdateDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateLocationLabel
            // 
            UpdateLocationLabel.Anchor = AnchorStyles.None;
            UpdateLocationLabel.AutoSize = true;
            UpdateLocationLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateLocationLabel.Location = new Point(13, 171);
            UpdateLocationLabel.Name = "UpdateLocationLabel";
            UpdateLocationLabel.Size = new Size(77, 21);
            UpdateLocationLabel.TabIndex = 26;
            UpdateLocationLabel.Text = "Location:";
            UpdateLocationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateQuantityLabel
            // 
            UpdateQuantityLabel.Anchor = AnchorStyles.None;
            UpdateQuantityLabel.AutoSize = true;
            UpdateQuantityLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateQuantityLabel.Location = new Point(13, 121);
            UpdateQuantityLabel.Name = "UpdateQuantityLabel";
            UpdateQuantityLabel.Size = new Size(76, 21);
            UpdateQuantityLabel.TabIndex = 25;
            UpdateQuantityLabel.Text = "Quantity:";
            UpdateQuantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateItemNameLabel
            // 
            UpdateItemNameLabel.Anchor = AnchorStyles.None;
            UpdateItemNameLabel.AutoSize = true;
            UpdateItemNameLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateItemNameLabel.Location = new Point(13, 73);
            UpdateItemNameLabel.Name = "UpdateItemNameLabel";
            UpdateItemNameLabel.Size = new Size(57, 21);
            UpdateItemNameLabel.TabIndex = 24;
            UpdateItemNameLabel.Text = "Name:";
            UpdateItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdateNameInput
            // 
            UpdateNameInput.Anchor = AnchorStyles.None;
            UpdateNameInput.Location = new Point(158, 75);
            UpdateNameInput.Name = "UpdateNameInput";
            UpdateNameInput.Size = new Size(560, 23);
            UpdateNameInput.TabIndex = 23;
            UpdateNameInput.Text = "Enter item name";
            // 
            // UpdateItemLabel
            // 
            UpdateItemLabel.Anchor = AnchorStyles.Top;
            UpdateItemLabel.AutoSize = true;
            UpdateItemLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateItemLabel.Location = new Point(235, 9);
            UpdateItemLabel.Name = "UpdateItemLabel";
            UpdateItemLabel.Size = new Size(317, 45);
            UpdateItemLabel.TabIndex = 22;
            UpdateItemLabel.Text = "Update Item Details";
            UpdateItemLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // UpdateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 719);
            Controls.Add(UpdateItemConfirmButton);
            Controls.Add(UpdateCancelButton);
            Controls.Add(UpdateCategoryInput);
            Controls.Add(UpdateSellingPriceInput);
            Controls.Add(UpdateSellingPriceLabel);
            Controls.Add(UpdateCostInput);
            Controls.Add(UpdateSupplierInput);
            Controls.Add(UpdateExpirationDateInput);
            Controls.Add(UpdateDescriptionInput);
            Controls.Add(UpdateLocationInput);
            Controls.Add(UpdateQuantityInput);
            Controls.Add(UpdateCostLabel);
            Controls.Add(UpdateSupplierLabel);
            Controls.Add(UpdateCategoryLabel);
            Controls.Add(UpdateExpiratonDateLabel);
            Controls.Add(UpdateDescriptionLabel);
            Controls.Add(UpdateLocationLabel);
            Controls.Add(UpdateQuantityLabel);
            Controls.Add(UpdateItemNameLabel);
            Controls.Add(UpdateNameInput);
            Controls.Add(UpdateItemLabel);
            Name = "UpdateItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Item Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateItemConfirmButton;
        private Button UpdateCancelButton;
        private TextBox UpdateCategoryInput;
        private TextBox UpdateSellingPriceInput;
        private Label UpdateSellingPriceLabel;
        private TextBox UpdateCostInput;
        private TextBox UpdateSupplierInput;
        private TextBox UpdateExpirationDateInput;
        private TextBox UpdateDescriptionInput;
        private TextBox UpdateLocationInput;
        private TextBox UpdateQuantityInput;
        private Label UpdateCostLabel;
        private Label UpdateSupplierLabel;
        private Label UpdateCategoryLabel;
        private Label UpdateExpiratonDateLabel;
        private Label UpdateDescriptionLabel;
        private Label UpdateLocationLabel;
        private Label UpdateQuantityLabel;
        private Label UpdateItemNameLabel;
        private TextBox UpdateNameInput;
        private Label UpdateItemLabel;
    }
}