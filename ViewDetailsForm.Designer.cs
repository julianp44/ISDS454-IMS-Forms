namespace ISDS454_IMS_Forms
{
    partial class ViewDetailsForm
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
            label1 = new Label();
            ViewItemDetailsDataTable = new DataGridView();
            ItemDetailsExportButton = new Button();
            ItemDetailsCancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ViewItemDetailsDataTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(678, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 45);
            label1.TabIndex = 0;
            label1.Text = "Item Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewItemDetailsDataTable
            // 
            ViewItemDetailsDataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewItemDetailsDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewItemDetailsDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewItemDetailsDataTable.Location = new Point(12, 74);
            ViewItemDetailsDataTable.Name = "ViewItemDetailsDataTable";
            ViewItemDetailsDataTable.ReadOnly = true;
            ViewItemDetailsDataTable.Size = new Size(1501, 479);
            ViewItemDetailsDataTable.TabIndex = 1;
            // 
            // ItemDetailsExportButton
            // 
            ItemDetailsExportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ItemDetailsExportButton.BackColor = Color.CornflowerBlue;
            ItemDetailsExportButton.Location = new Point(1407, 572);
            ItemDetailsExportButton.Name = "ItemDetailsExportButton";
            ItemDetailsExportButton.Size = new Size(107, 33);
            ItemDetailsExportButton.TabIndex = 2;
            ItemDetailsExportButton.Text = "Export";
            ItemDetailsExportButton.UseVisualStyleBackColor = false;
            ItemDetailsExportButton.Click += ItemDetailsExportButton_Click;
            // 
            // ItemDetailsCancelButton
            // 
            ItemDetailsCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemDetailsCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            ItemDetailsCancelButton.Location = new Point(12, 572);
            ItemDetailsCancelButton.Name = "ItemDetailsCancelButton";
            ItemDetailsCancelButton.Size = new Size(107, 33);
            ItemDetailsCancelButton.TabIndex = 3;
            ItemDetailsCancelButton.Text = "Cancel";
            ItemDetailsCancelButton.UseVisualStyleBackColor = false;
            ItemDetailsCancelButton.Click += ItemDetailsCancelButton_Click;
            // 
            // ViewDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1525, 617);
            Controls.Add(ItemDetailsCancelButton);
            Controls.Add(ItemDetailsExportButton);
            Controls.Add(ViewItemDetailsDataTable);
            Controls.Add(label1);
            Name = "ViewDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDetailsForm";
            Load += ViewDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)ViewItemDetailsDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView ViewItemDetailsDataTable;
        private Button ItemDetailsExportButton;
        private Button ItemDetailsCancelButton;
    }
}