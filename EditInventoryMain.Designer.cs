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
            EditInventoryCancelButton = new Button();
            EditInventoryDataTable = new DataGridView();
            EditSearchLabel = new Label();
            EditSearchTextBox = new TextBox();
            addNewInventoryButton = new Button();
            refreshButton = new Button();
            editButton = new Button();
            delButton = new Button();
            ((System.ComponentModel.ISupportInitialize)EditInventoryDataTable).BeginInit();
            SuspendLayout();
            // 
            // EditIMSLabel
            // 
            EditIMSLabel.Anchor = AnchorStyles.Top;
            EditIMSLabel.AutoSize = true;
            EditIMSLabel.ForeColor = SystemColors.ControlText;
            EditIMSLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            EditIMSLabel.Location = new Point(276, 58);
            EditIMSLabel.Margin = new Padding(8, 0, 8, 0);
            EditIMSLabel.Name = "EditIMSLabel";
            EditIMSLabel.Size = new Size(563, 45);
            EditIMSLabel.TabIndex = 0;
            EditIMSLabel.Text = "Edit: Inventory Management System";
            // 
            // EditInventoryCancelButton
            // 
            EditInventoryCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditInventoryCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            EditInventoryCancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditInventoryCancelButton.Location = new Point(12, 545);
            EditInventoryCancelButton.Name = "EditInventoryCancelButton";
            EditInventoryCancelButton.Size = new Size(180, 47);
            EditInventoryCancelButton.TabIndex = 3;
            EditInventoryCancelButton.Text = "Cancel";
            EditInventoryCancelButton.UseVisualStyleBackColor = false;
            EditInventoryCancelButton.Click += CancelButton_Click;
            // 
            // EditInventoryDataTable
            // 
            EditInventoryDataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditInventoryDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EditInventoryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EditInventoryDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            EditInventoryDataTable.DefaultCellStyle = dataGridViewCellStyle2;
            EditInventoryDataTable.Location = new Point(12, 174);
            EditInventoryDataTable.Name = "EditInventoryDataTable";
            EditInventoryDataTable.Size = new Size(1047, 256);
            EditInventoryDataTable.TabIndex = 7;
            EditInventoryDataTable.CellContentClick += EditInventoryDataTable_CellContentClick;
            // 
            // EditSearchLabel
            // 
            EditSearchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditSearchLabel.AutoSize = true;
            EditSearchLabel.Font = new Font("Segoe UI", 9.75F);
            EditSearchLabel.Location = new Point(784, 146);
            EditSearchLabel.Name = "EditSearchLabel";
            EditSearchLabel.Size = new Size(50, 17);
            EditSearchLabel.TabIndex = 10;
            EditSearchLabel.Text = "Search:";
            // 
            // EditSearchTextBox
            // 
            EditSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditSearchTextBox.Font = new Font("Segoe UI", 9.75F);
            EditSearchTextBox.Location = new Point(840, 143);
            EditSearchTextBox.Name = "EditSearchTextBox";
            EditSearchTextBox.Size = new Size(219, 25);
            EditSearchTextBox.TabIndex = 9;
            EditSearchTextBox.Text = "Input SKU or product name";
            EditSearchTextBox.TextChanged += EditSearchTextBox_TextChanged;
            // 
            // addNewInventoryButton
            // 
            addNewInventoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addNewInventoryButton.Location = new Point(12, 457);
            addNewInventoryButton.Name = "addNewInventoryButton";
            addNewInventoryButton.Size = new Size(161, 47);
            addNewInventoryButton.TabIndex = 11;
            addNewInventoryButton.Text = "Add New Inventory";
            addNewInventoryButton.UseVisualStyleBackColor = true;
            addNewInventoryButton.Click += addNewInventoryButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            refreshButton.Location = new Point(12, 135);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            editButton.Location = new Point(179, 457);
            editButton.Name = "editButton";
            editButton.Size = new Size(161, 47);
            editButton.TabIndex = 13;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // delButton
            // 
            delButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            delButton.Location = new Point(346, 457);
            delButton.Name = "delButton";
            delButton.Size = new Size(161, 47);
            delButton.TabIndex = 14;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // EditInventoryMain
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1071, 604);
            Controls.Add(delButton);
            Controls.Add(editButton);
            Controls.Add(refreshButton);
            Controls.Add(addNewInventoryButton);
            Controls.Add(EditSearchLabel);
            Controls.Add(EditSearchTextBox);
            Controls.Add(EditInventoryDataTable);
            Controls.Add(EditInventoryCancelButton);
            Controls.Add(EditIMSLabel);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 9, 8, 9);
            Name = "EditInventoryMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit: Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)EditInventoryDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EditIMSLabel;
        private Button EditInventoryCancelButton;
        private DataGridView EditInventoryDataTable;
        private Label EditSearchLabel;
        private TextBox EditSearchTextBox;
        private Button addNewInventoryButton;
        private Button refreshButton;
        private Button editButton;
        private Button delButton;
    }
}