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
            ((System.ComponentModel.ISupportInitialize)ViewInventoryDataTable).BeginInit();
            SuspendLayout();
            // 
            // ViewIMSLabel
            // 
            ViewIMSLabel.Anchor = AnchorStyles.Top;
            ViewIMSLabel.AutoSize = true;
            ViewIMSLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewIMSLabel.Location = new Point(235, 12);
            ViewIMSLabel.Name = "ViewIMSLabel";
            ViewIMSLabel.Size = new Size(732, 54);
            ViewIMSLabel.TabIndex = 0;
            ViewIMSLabel.Text = "View: Inventory Management System";
            // 
            // ViewLastUpdatesButton
            // 
            ViewLastUpdatesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ViewLastUpdatesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ViewLastUpdatesButton.BackColor = Color.Cyan;
            ViewLastUpdatesButton.Location = new Point(898, 871);
            ViewLastUpdatesButton.Margin = new Padding(3, 4, 3, 4);
            ViewLastUpdatesButton.Name = "ViewLastUpdatesButton";
            ViewLastUpdatesButton.Size = new Size(233, 60);
            ViewLastUpdatesButton.TabIndex = 3;
            ViewLastUpdatesButton.Text = "View Last Updates";
            ViewLastUpdatesButton.UseVisualStyleBackColor = false;
            ViewLastUpdatesButton.Click += ViewLastUpdatesButton_Click;
            // 
            // LocateButton
            // 
            LocateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LocateButton.BackColor = Color.Coral;
            LocateButton.Location = new Point(898, 803);
            LocateButton.Margin = new Padding(3, 4, 3, 4);
            LocateButton.Name = "LocateButton";
            LocateButton.Size = new Size(233, 60);
            LocateButton.TabIndex = 4;
            LocateButton.Text = "Locate";
            LocateButton.UseVisualStyleBackColor = false;
            // 
            // ViewDetailsButton
            // 
            ViewDetailsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ViewDetailsButton.BackColor = Color.CornflowerBlue;
            ViewDetailsButton.Location = new Point(898, 735);
            ViewDetailsButton.Margin = new Padding(3, 4, 3, 4);
            ViewDetailsButton.Name = "ViewDetailsButton";
            ViewDetailsButton.Size = new Size(233, 60);
            ViewDetailsButton.TabIndex = 5;
            ViewDetailsButton.Text = "View Details";
            ViewDetailsButton.UseVisualStyleBackColor = false;
            ViewDetailsButton.Click += ViewDetailsButton_Click;
            // 
            // ExportDataCheck
            // 
            ExportDataCheck.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExportDataCheck.AutoSize = true;
            ExportDataCheck.Location = new Point(768, 906);
            ExportDataCheck.Margin = new Padding(3, 4, 3, 4);
            ExportDataCheck.Name = "ExportDataCheck";
            ExportDataCheck.Size = new Size(110, 24);
            ExportDataCheck.TabIndex = 6;
            ExportDataCheck.Text = "Export Data";
            ExportDataCheck.UseVisualStyleBackColor = true;
            // 
            // ViewSearchTextBox
            // 
            ViewSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewSearchTextBox.Location = new Point(881, 200);
            ViewSearchTextBox.Margin = new Padding(3, 4, 3, 4);
            ViewSearchTextBox.Name = "ViewSearchTextBox";
            ViewSearchTextBox.Size = new Size(250, 27);
            ViewSearchTextBox.TabIndex = 7;
            ViewSearchTextBox.Text = "Input SKU or product name";
            // 
            // ViewSearchLabel
            // 
            ViewSearchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewSearchLabel.AutoSize = true;
            ViewSearchLabel.Location = new Point(823, 204);
            ViewSearchLabel.Name = "ViewSearchLabel";
            ViewSearchLabel.Size = new Size(56, 20);
            ViewSearchLabel.TabIndex = 8;
            ViewSearchLabel.Text = "Search:";
            // 
            // ViewCancelButton
            // 
            ViewCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ViewCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            ViewCancelButton.Location = new Point(14, 877);
            ViewCancelButton.Margin = new Padding(3, 4, 3, 4);
            ViewCancelButton.Name = "ViewCancelButton";
            ViewCancelButton.Size = new Size(233, 60);
            ViewCancelButton.TabIndex = 9;
            ViewCancelButton.Text = "Cancel";
            ViewCancelButton.UseVisualStyleBackColor = false;
            ViewCancelButton.Click += ViewCancelButton_Click;
            // 
            // ViewInventoryDataTable
            // 
            ViewInventoryDataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewInventoryDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewInventoryDataTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ViewInventoryDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ViewInventoryDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewInventoryDataTable.Location = new Point(14, 232);
            ViewInventoryDataTable.Margin = new Padding(3, 4, 3, 4);
            ViewInventoryDataTable.Name = "ViewInventoryDataTable";
            ViewInventoryDataTable.RowHeadersWidth = 51;
            ViewInventoryDataTable.Size = new Size(1118, 489);
            ViewInventoryDataTable.TabIndex = 10;
            // 
            // ViewInventoryMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 953);
            Controls.Add(ViewInventoryDataTable);
            Controls.Add(ViewCancelButton);
            Controls.Add(ViewSearchLabel);
            Controls.Add(ViewSearchTextBox);
            Controls.Add(ExportDataCheck);
            Controls.Add(ViewDetailsButton);
            Controls.Add(LocateButton);
            Controls.Add(ViewLastUpdatesButton);
            Controls.Add(ViewIMSLabel);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}