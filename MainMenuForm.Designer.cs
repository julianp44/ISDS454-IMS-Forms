namespace ISDS454_IMS_Forms
{
    partial class MainMenuForm
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
            EditInventoryMenuButton = new Button();
            ViewInventoryMenuButton = new Button();
            SuspendLayout();
            // 
            // EditInventoryMenuButton
            // 
            EditInventoryMenuButton.BackColor = Color.FromArgb(255, 128, 128);
            EditInventoryMenuButton.Location = new Point(244, 240);
            EditInventoryMenuButton.Name = "EditInventoryMenuButton";
            EditInventoryMenuButton.Size = new Size(328, 61);
            EditInventoryMenuButton.TabIndex = 0;
            EditInventoryMenuButton.Text = "Edit Inventory";
            EditInventoryMenuButton.UseVisualStyleBackColor = false;
            EditInventoryMenuButton.Click += button1_Click;
            // 
            // ViewInventoryMenuButton
            // 
            ViewInventoryMenuButton.BackColor = Color.FromArgb(128, 255, 128);
            ViewInventoryMenuButton.Location = new Point(244, 142);
            ViewInventoryMenuButton.Name = "ViewInventoryMenuButton";
            ViewInventoryMenuButton.Size = new Size(328, 61);
            ViewInventoryMenuButton.TabIndex = 1;
            ViewInventoryMenuButton.Text = "View Inventory";
            ViewInventoryMenuButton.UseVisualStyleBackColor = false;
            ViewInventoryMenuButton.Click += button2_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewInventoryMenuButton);
            Controls.Add(EditInventoryMenuButton);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button EditInventoryMenuButton;
        private Button ViewInventoryMenuButton;
    }
}