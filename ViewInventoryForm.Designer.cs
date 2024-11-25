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
            ViewDetailsButton = new Button();
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
            ViewIMSLabel.Location = new Point(206, 9);
            ViewIMSLabel.Name = "ViewIMSLabel";
            ViewIMSLabel.Size = new Size(578, 45);
            ViewIMSLabel.TabIndex = 0;
            ViewIMSLabel.Text = "View: Inventory Management System";
            // 
            // ViewLastUpdatesButton
            // 
            ViewLastUpdatesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ViewLastUpdatesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ViewLastUpdatesButton.BackColor = Color.Cyan;
            ViewLastUpdatesButton.Location = new Point(786, 653);
            ViewLastUpdatesButton.Name = "ViewLastUpdatesButton";
            ViewLastUpdatesButton.Size = new Size(204, 45);
            ViewLastUpdatesButton.TabIndex = 3;
            ViewLastUpdatesButton.Text = "View Last Updates";
            ViewLastUpdatesButton.UseVisualStyleBackColor = false;
            ViewLastUpdatesButton.Click += ViewLastUpdatesButton_Click;
            // 
            // ViewDetailsButton
            // 
            ViewDetailsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ViewDetailsButton.BackColor = Color.CornflowerBlue;
            ViewDetailsButton.Location = new Point(786, 602);
            ViewDetailsButton.Name = "ViewDetailsButton";
            ViewDetailsButton.Size = new Size(204, 45);
            ViewDetailsButton.TabIndex = 5;
            ViewDetailsButton.Text = "View Details";
            ViewDetailsButton.UseVisualStyleBackColor = false;
            ViewDetailsButton.Click += ViewDetailsButton_Click;
            // 
            // ViewSearchTextBox
            // 
            ViewSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewSearchTextBox.Location = new Point(771, 150);
            ViewSearchTextBox.Name = "ViewSearchTextBox";
            ViewSearchTextBox.Size = new Size(219, 23);
            ViewSearchTextBox.TabIndex = 7;
            ViewSearchTextBox.TextChanged += ViewSearchTextBox_TextChanged;
            // 
            // ViewSearchLabel
            // 
            ViewSearchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ViewSearchLabel.AutoSize = true;
            ViewSearchLabel.Location = new Point(720, 153);
            ViewSearchLabel.Name = "ViewSearchLabel";
            ViewSearchLabel.Size = new Size(45, 15);
            ViewSearchLabel.TabIndex = 8;
            ViewSearchLabel.Text = "Search:";
            // 
            // ViewCancelButton
            // 
            ViewCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ViewCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            ViewCancelButton.Location = new Point(12, 658);
            ViewCancelButton.Name = "ViewCancelButton";
            ViewCancelButton.Size = new Size(204, 45);
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
            ViewInventoryDataTable.Location = new Point(12, 174);
            ViewInventoryDataTable.Name = "ViewInventoryDataTable";
            ViewInventoryDataTable.RowHeadersWidth = 51;
            ViewInventoryDataTable.Size = new Size(978, 367);
            ViewInventoryDataTable.TabIndex = 10;
            // 
            // ViewInventoryMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 715);
            Controls.Add(ViewInventoryDataTable);
            Controls.Add(ViewCancelButton);
            Controls.Add(ViewSearchLabel);
            Controls.Add(ViewSearchTextBox);
            Controls.Add(ViewDetailsButton);
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
        private Button ViewDetailsButton;
        private TextBox ViewSearchTextBox;
        private Label ViewSearchLabel;
        private Button ViewCancelButton;
        private DataGridView ViewInventoryDataTable;
    }
}