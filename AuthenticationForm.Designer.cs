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
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInLabel.Location = new Point(132, 30);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(840, 45);
            SignInLabel.TabIndex = 0;
            SignInLabel.Text = "Inventory Management System : Employee Verification";
            SignInLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeeIDInputBox
            // 
            EmployeeIDInputBox.Location = new Point(340, 229);
            EmployeeIDInputBox.Name = "EmployeeIDInputBox";
            EmployeeIDInputBox.Size = new Size(476, 23);
            EmployeeIDInputBox.TabIndex = 1;
            EmployeeIDInputBox.Text = "Enter Employee ID";
            // 
            // PasswordInputBox
            // 
            PasswordInputBox.Location = new Point(340, 341);
            PasswordInputBox.Name = "PasswordInputBox";
            PasswordInputBox.Size = new Size(476, 23);
            PasswordInputBox.TabIndex = 2;
            PasswordInputBox.Text = "Please Enter Password";
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmployeeIDLabel.Location = new Point(340, 205);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(100, 21);
            EmployeeIDLabel.TabIndex = 3;
            EmployeeIDLabel.Text = "Employee ID:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(340, 317);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(79, 21);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(980, 504);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(160, 35);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += button1_Click;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.Location = new Point(814, 504);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(160, 35);
            LoginCancelButton.TabIndex = 6;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = true;
            LoginCancelButton.Click += button2_Click;
            // 
            // InventoryManagementSystem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 571);
            Controls.Add(LoginCancelButton);
            Controls.Add(SignInButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmployeeIDLabel);
            Controls.Add(PasswordInputBox);
            Controls.Add(EmployeeIDInputBox);
            Controls.Add(SignInLabel);
            Name = "InventoryManagementSystem";
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
