namespace ISDS454_IMS_Forms
{
    partial class DeleteItemConfirmationForm
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
            ConfirmDeleteLabel = new Label();
            DeleteItemDataGrid = new DataGridView();
            ConfirmDeleteButton = new Button();
            DeleteCancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DeleteItemDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ConfirmDeleteLabel
            // 
            ConfirmDeleteLabel.Anchor = AnchorStyles.Top;
            ConfirmDeleteLabel.AutoSize = true;
            ConfirmDeleteLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmDeleteLabel.Location = new Point(235, 9);
            ConfirmDeleteLabel.Name = "ConfirmDeleteLabel";
            ConfirmDeleteLabel.Size = new Size(338, 45);
            ConfirmDeleteLabel.TabIndex = 0;
            ConfirmDeleteLabel.Text = "Confirm Delete Item?";
            // 
            // DeleteItemDataGrid
            // 
            DeleteItemDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteItemDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DeleteItemDataGrid.Location = new Point(12, 69);
            DeleteItemDataGrid.Name = "DeleteItemDataGrid";
            DeleteItemDataGrid.Size = new Size(776, 298);
            DeleteItemDataGrid.TabIndex = 1;
            // 
            // ConfirmDeleteButton
            // 
            ConfirmDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ConfirmDeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            ConfirmDeleteButton.Location = new Point(667, 394);
            ConfirmDeleteButton.Name = "ConfirmDeleteButton";
            ConfirmDeleteButton.Size = new Size(121, 44);
            ConfirmDeleteButton.TabIndex = 2;
            ConfirmDeleteButton.Text = "Confirm Delete";
            ConfirmDeleteButton.UseVisualStyleBackColor = false;
            ConfirmDeleteButton.Click += ConfirmDeleteButton_Click;
            // 
            // DeleteCancelButton
            // 
            DeleteCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteCancelButton.BackColor = SystemColors.Control;
            DeleteCancelButton.Location = new Point(540, 394);
            DeleteCancelButton.Name = "DeleteCancelButton";
            DeleteCancelButton.Size = new Size(121, 44);
            DeleteCancelButton.TabIndex = 3;
            DeleteCancelButton.Text = "Cancel";
            DeleteCancelButton.UseVisualStyleBackColor = false;
            DeleteCancelButton.Click += DeleteCancelButton_Click;
            // 
            // DeleteItemConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteCancelButton);
            Controls.Add(ConfirmDeleteButton);
            Controls.Add(DeleteItemDataGrid);
            Controls.Add(ConfirmDeleteLabel);
            Name = "DeleteItemConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Delete Confirmation";
            ((System.ComponentModel.ISupportInitialize)DeleteItemDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConfirmDeleteLabel;
        private DataGridView DeleteItemDataGrid;
        private Button ConfirmDeleteButton;
        private Button DeleteCancelButton;
    }
}