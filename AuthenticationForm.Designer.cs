namespace ISDS454_IMS_Forms
{
    partial class InventoryManagementSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignInLabel = new Label();
            EmployeeIDInputBox = new TextBox();
            PasswordInputBox = new TextBox();
            EmployeeIDLabel = new Label();
            PasswordLabel = new Label();
            SignInButton = new Button();
            LoginCancelButton = new Button();
            SuspendLayout();
            // 
            // SignInLabel
            // 
            SignInLabel.Anchor = AnchorStyles.Top;
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInLabel.Location = new Point(135, 9);
            SignInLabel.MaximumSize = new Size(500, 0);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(487, 90);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Inventory Management System  Employee Verification";
            SignInLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeeIDInputBox
            // 
            EmployeeIDInputBox.Anchor = AnchorStyles.None;
            EmployeeIDInputBox.Location = new Point(135, 239);
            EmployeeIDInputBox.Name = "EmployeeIDInputBox";
            EmployeeIDInputBox.Size = new Size(476, 23);
            EmployeeIDInputBox.TabIndex = 1;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Anchor = AnchorStyles.None;
            PasswordInputBox.Location = new Point(135, 351);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(476, 23);
            PasswordInputBox.TabIndex = 2;
            PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.Anchor = AnchorStyles.None;
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeIDLabel.Location = new Point(135, 215);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(100, 21);
            EmployeeIDLabel.TabIndex = 3;
            EmployeeIDLabel.Text = "Employee ID:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(135, 327);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(79, 21);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SignInButton.BackColor = Color.CornflowerBlue;
            SignInButton.Location = new Point(571, 524);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(160, 35);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += button1_Click;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            LoginCancelButton.Location = new Point(405, 524);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(160, 35);
            LoginCancelButton.TabIndex = 6;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = false;
            LoginCancelButton.Click += button2_Click;
            // 
            // InventoryManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 591);
            Controls.Add(LoginCancelButton);
            Controls.Add(SignInButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmployeeIDLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmployeeIDInputBox);
            Controls.Add(SignInLabel);
            Name = "InventoryManagementSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignInLabel;
        private TextBox EmployeeIDInputBox;
        private TextBox PasswordInputBox;
        private Label EmployeeIDLabel;
        private Label PasswordLabel;
        private Button SignInButton;
        private Button LoginCancelButton;
    }
}
