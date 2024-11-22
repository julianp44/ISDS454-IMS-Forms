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
            SignInLabel.Location = new Point(154, 12);
            SignInLabel.MaximumSize = new Size(571, 0);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(471, 162);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Inventory Management System  Employee Verification";
            SignInLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeeIDInputBox
            // 
            EmployeeIDInputBox.Anchor = AnchorStyles.None;
            EmployeeIDInputBox.Location = new Point(154, 319);
            EmployeeIDInputBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeIDInputBox.Name = "EmployeeIDInputBox";
            EmployeeIDInputBox.Size = new Size(543, 27);
            EmployeeIDInputBox.TabIndex = 1;
            EmployeeIDInputBox.TextChanged += EmployeeIDInputBox_TextChanged;
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Anchor = AnchorStyles.None;
            PasswordInputBox.Location = new Point(154, 468);
            PasswordInputBox.Margin = new Padding(3, 4, 3, 4);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(543, 27);
            PasswordInputBox.TabIndex = 2;
            PasswordInputBox.UseSystemPasswordChar = true;
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.Anchor = AnchorStyles.None;
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeIDLabel.Location = new Point(154, 287);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(126, 28);
            EmployeeIDLabel.TabIndex = 3;
            EmployeeIDLabel.Text = "Employee ID:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.None;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(154, 436);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(97, 28);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SignInButton.BackColor = Color.CornflowerBlue;
            SignInButton.Location = new Point(653, 699);
            SignInButton.Margin = new Padding(3, 4, 3, 4);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(183, 47);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += button1_Click;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoginCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            LoginCancelButton.Location = new Point(463, 699);
            LoginCancelButton.Margin = new Padding(3, 4, 3, 4);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(183, 47);
            LoginCancelButton.TabIndex = 6;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = false;
            LoginCancelButton.Click += button2_Click;
            // 
            // InventoryManagementSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 788);
            Controls.Add(LoginCancelButton);
            Controls.Add(SignInButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmployeeIDLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmployeeIDInputBox);
            Controls.Add(SignInLabel);
            Margin = new Padding(3, 4, 3, 4);
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
