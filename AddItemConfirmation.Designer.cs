namespace ISDS454_IMS_Forms
{
    partial class AddItemConfirmation
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
            SuccessfullItemAddLabel = new Label();
            dataGridView1 = new DataGridView();
            AddItemConfirmationDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SuccessfullItemAddLabel
            // 
            SuccessfullItemAddLabel.Anchor = AnchorStyles.Top;
            SuccessfullItemAddLabel.AutoSize = true;
            SuccessfullItemAddLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuccessfullItemAddLabel.Location = new Point(175, 9);
            SuccessfullItemAddLabel.Name = "SuccessfullItemAddLabel";
            SuccessfullItemAddLabel.Size = new Size(394, 45);
            SuccessfullItemAddLabel.TabIndex = 0;
            SuccessfullItemAddLabel.Text = "Item Successfully Added!";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(708, 342);
            dataGridView1.TabIndex = 1;
            // 
            // AddItemConfirmationDone
            // 
            AddItemConfirmationDone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddItemConfirmationDone.Location = new Point(600, 434);
            AddItemConfirmationDone.Name = "AddItemConfirmationDone";
            AddItemConfirmationDone.Size = new Size(120, 43);
            AddItemConfirmationDone.TabIndex = 2;
            AddItemConfirmationDone.Text = "Done";
            AddItemConfirmationDone.UseVisualStyleBackColor = true;
            AddItemConfirmationDone.Click += AddItemConfirmationDone_Click;
            // 
            // AddItemConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 489);
            Controls.Add(AddItemConfirmationDone);
            Controls.Add(dataGridView1);
            Controls.Add(SuccessfullItemAddLabel);
            Name = "AddItemConfirmation";
            Text = "Successfull Add Item Confirmation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SuccessfullItemAddLabel;
        private DataGridView dataGridView1;
        private Button AddItemConfirmationDone;
    }
}