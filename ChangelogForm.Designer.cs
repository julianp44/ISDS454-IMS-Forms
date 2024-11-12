namespace ISDS454_IMS_Forms
{
    partial class ChangelogForm
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
            ChangelogLabel = new Label();
            dataGridView1 = new DataGridView();
            ChangelogDoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ChangelogLabel
            // 
            ChangelogLabel.Anchor = AnchorStyles.Top;
            ChangelogLabel.AutoSize = true;
            ChangelogLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangelogLabel.Location = new Point(504, 45);
            ChangelogLabel.Name = "ChangelogLabel";
            ChangelogLabel.Size = new Size(181, 45);
            ChangelogLabel.TabIndex = 0;
            ChangelogLabel.Text = "Changelog";
            ChangelogLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1129, 667);
            dataGridView1.TabIndex = 1;
            // 
            // ChangelogDoneButton
            // 
            ChangelogDoneButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ChangelogDoneButton.Location = new Point(1018, 846);
            ChangelogDoneButton.Name = "ChangelogDoneButton";
            ChangelogDoneButton.Size = new Size(123, 42);
            ChangelogDoneButton.TabIndex = 2;
            ChangelogDoneButton.Text = "Done";
            ChangelogDoneButton.UseVisualStyleBackColor = true;
            ChangelogDoneButton.Click += ChangelogDoneButton_Click;
            // 
            // ChangelogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 900);
            Controls.Add(ChangelogDoneButton);
            Controls.Add(dataGridView1);
            Controls.Add(ChangelogLabel);
            Name = "ChangelogForm";
            Text = "Changelog";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChangelogLabel;
        private DataGridView dataGridView1;
        private Button ChangelogDoneButton;
    }
}