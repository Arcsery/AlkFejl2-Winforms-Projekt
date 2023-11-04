namespace hazi2
{
    partial class registerForm
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
            registerText = new Label();
            usernameText = new Label();
            passwordText = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            loginButton = new Button();
            signInText = new Label();
            SuspendLayout();
            // 
            // registerText
            // 
            registerText.AutoSize = true;
            registerText.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            registerText.Location = new Point(326, 50);
            registerText.Name = "registerText";
            registerText.Size = new Size(159, 37);
            registerText.TabIndex = 0;
            registerText.Text = "Regisztráció";
            // 
            // usernameText
            // 
            usernameText.AutoSize = true;
            usernameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameText.Location = new Point(160, 144);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(120, 21);
            usernameText.TabIndex = 1;
            usernameText.Text = "Felhasználó név";
            // 
            // passwordText
            // 
            passwordText.AutoSize = true;
            passwordText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.Location = new Point(160, 201);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(51, 21);
            passwordText.TabIndex = 2;
            passwordText.Text = "Jelszó";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(326, 144);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(192, 23);
            usernameTextBox.TabIndex = 3;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(326, 199);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(192, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(326, 268);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(88, 23);
            registerButton.TabIndex = 5;
            registerButton.Text = "Regisztráció";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(420, 268);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(92, 23);
            loginButton.TabIndex = 6;
            loginButton.Text = "Bejelentkezés";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signInText
            // 
            signInText.AutoSize = true;
            signInText.Location = new Point(426, 245);
            signInText.Name = "signInText";
            signInText.Size = new Size(92, 15);
            signInText.TabIndex = 7;
            signInText.Text = "Van már fiókod?";
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signInText);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(registerText);
            Name = "registerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerText;
        private Label usernameText;
        private Label passwordText;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Button loginButton;
        private Label signInText;
    }
}