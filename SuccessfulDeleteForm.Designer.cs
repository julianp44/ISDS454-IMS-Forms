namespace ISDS454_IMS_Forms
{
    partial class SuccessfulDeleteForm
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
            dataGridView1 = new DataGridView();
            SuccessfulDeleteDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(410, 45);
            label1.TabIndex = 0;
            label1.Text = "Item Successfully Deleted!";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 299);
            dataGridView1.TabIndex = 1;
            // 
            // SuccessfulDeleteDone
            // 
            SuccessfulDeleteDone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SuccessfulDeleteDone.Location = new Point(666, 394);
            SuccessfulDeleteDone.Name = "SuccessfulDeleteDone";
            SuccessfulDeleteDone.Size = new Size(122, 49);
            SuccessfulDeleteDone.TabIndex = 2;
            SuccessfulDeleteDone.Text = "Done";
            SuccessfulDeleteDone.UseVisualStyleBackColor = true;
            SuccessfulDeleteDone.Click += SuccessfulDeleteDone_Click;
            // 
            // SuccessfulDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuccessfulDeleteDone);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "SuccessfulDeleteForm";
            Text = "Deleted Item Successfully";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button SuccessfulDeleteDone;
    }
}