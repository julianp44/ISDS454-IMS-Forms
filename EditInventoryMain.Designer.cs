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
            EditIMSLabel = new Label();
            InventoryDataTable = new DataGridView();
            AddItemButton = new Button();
            CancelButton = new Button();
            NextButton = new Button();
            UpdateItemCheck = new CheckBox();
            DeleteItemCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)InventoryDataTable).BeginInit();
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
            // InventoryDataTable
            // 
            InventoryDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryDataTable.Location = new Point(12, 185);
            InventoryDataTable.Name = "InventoryDataTable";
            InventoryDataTable.Size = new Size(1801, 807);
            InventoryDataTable.TabIndex = 1;
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
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(255, 128, 128);
            CancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(1428, 1096);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 47);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            // EditInventoryMain
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1825, 1155);
            Controls.Add(DeleteItemCheck);
            Controls.Add(UpdateItemCheck);
            Controls.Add(NextButton);
            Controls.Add(CancelButton);
            Controls.Add(AddItemButton);
            Controls.Add(InventoryDataTable);
            Controls.Add(EditIMSLabel);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "EditInventoryMain";
            Text = "Edit: Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)InventoryDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditIMSLabel;
        private DataGridView InventoryDataTable;
        private Button AddItemButton;
        private Button CancelButton;
        private Button NextButton;
        private CheckBox UpdateItemCheck;
        private CheckBox DeleteItemCheck;
    }
}