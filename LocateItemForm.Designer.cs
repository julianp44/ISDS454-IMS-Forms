namespace ISDS454_IMS_Forms
{
    partial class LocateItemForm
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
            LocateItemFormLabel = new Label();
            LocationDetailsDataGrid = new DataGridView();
            ItemLocationDoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LocationDetailsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // LocateItemFormLabel
            // 
            LocateItemFormLabel.Anchor = AnchorStyles.Top;
            LocateItemFormLabel.AutoSize = true;
            LocateItemFormLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LocateItemFormLabel.Location = new Point(237, 9);
            LocateItemFormLabel.Name = "LocateItemFormLabel";
            LocateItemFormLabel.Size = new Size(336, 45);
            LocateItemFormLabel.TabIndex = 0;
            LocateItemFormLabel.Text = "Item Location Details";
            LocateItemFormLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // LocationDetailsDataGrid
            // 
            LocationDetailsDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LocationDetailsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationDetailsDataGrid.Location = new Point(12, 78);
            LocationDetailsDataGrid.Name = "LocationDetailsDataGrid";
            LocationDetailsDataGrid.Size = new Size(776, 292);
            LocationDetailsDataGrid.TabIndex = 1;
            // 
            // ItemLocationDoneButton
            // 
            ItemLocationDoneButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ItemLocationDoneButton.Location = new Point(680, 404);
            ItemLocationDoneButton.Name = "ItemLocationDoneButton";
            ItemLocationDoneButton.Size = new Size(108, 34);
            ItemLocationDoneButton.TabIndex = 2;
            ItemLocationDoneButton.Text = "Done";
            ItemLocationDoneButton.UseVisualStyleBackColor = true;
            ItemLocationDoneButton.Click += ItemLocationDoneButton_Click;
            // 
            // LocateItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ItemLocationDoneButton);
            Controls.Add(LocationDetailsDataGrid);
            Controls.Add(LocateItemFormLabel);
            Name = "LocateItemForm";
            Text = "Locate Item";
            ((System.ComponentModel.ISupportInitialize)LocationDetailsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LocateItemFormLabel;
        private DataGridView LocationDetailsDataGrid;
        private Button ItemLocationDoneButton;
    }
}