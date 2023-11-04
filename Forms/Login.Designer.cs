namespace hazi2
{
    partial class Login
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
            label2 = new Label();
            label3 = new Label();
            loginUsernameTextBox = new TextBox();
            loginPasswordTextBox = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(313, 63);
            label1.Name = "label1";
            label1.Size = new Size(176, 37);
            label1.TabIndex = 0;
            label1.Text = "Bejelentkezés";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 168);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 1;
            label2.Text = "Felhasználó név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(151, 229);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Jelszó";
            label3.Click += label3_Click;
            // 
            // loginUsernameTextBox
            // 
            loginUsernameTextBox.Location = new Point(320, 174);
            loginUsernameTextBox.Name = "loginUsernameTextBox";
            loginUsernameTextBox.Size = new Size(169, 23);
            loginUsernameTextBox.TabIndex = 3;
            // 
            // loginPasswordTextBox
            // 
            loginPasswordTextBox.Location = new Point(320, 232);
            loginPasswordTextBox.Name = "loginPasswordTextBox";
            loginPasswordTextBox.Size = new Size(169, 23);
            loginPasswordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(353, 282);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 31);
            loginButton.TabIndex = 5;
            loginButton.Text = "Bejelentkezés";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginButton);
            Controls.Add(loginPasswordTextBox);
            Controls.Add(loginUsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox loginUsernameTextBox;
        private TextBox loginPasswordTextBox;
        private Button loginButton;
    }
}