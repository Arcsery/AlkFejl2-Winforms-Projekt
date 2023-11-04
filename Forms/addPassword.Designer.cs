namespace hazi2
{
    partial class addPassword
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
            addPasswordButton = new Button();
            websiteTextBox = new TextBox();
            webNameTextBox = new TextBox();
            webPasswordTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(244, 202);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Webes név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 279);
            label2.Name = "label2";
            label2.Size = new Size(124, 28);
            label2.TabIndex = 1;
            label2.Text = "Webes jelszó";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(244, 116);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Weboldal";
            // 
            // addPasswordButton
            // 
            addPasswordButton.Location = new Point(323, 351);
            addPasswordButton.Name = "addPasswordButton";
            addPasswordButton.Size = new Size(128, 46);
            addPasswordButton.TabIndex = 3;
            addPasswordButton.Text = "Hozzáad";
            addPasswordButton.UseVisualStyleBackColor = true;
            addPasswordButton.Click += addPasswordButton_Click;
            // 
            // websiteTextBox
            // 
            websiteTextBox.Location = new Point(411, 121);
            websiteTextBox.Name = "websiteTextBox";
            websiteTextBox.Size = new Size(179, 23);
            websiteTextBox.TabIndex = 4;
            // 
            // webNameTextBox
            // 
            webNameTextBox.Location = new Point(411, 204);
            webNameTextBox.Name = "webNameTextBox";
            webNameTextBox.Size = new Size(179, 23);
            webNameTextBox.TabIndex = 5;
            // 
            // webPasswordTextBox
            // 
            webPasswordTextBox.Location = new Point(411, 294);
            webPasswordTextBox.Name = "webPasswordTextBox";
            webPasswordTextBox.Size = new Size(179, 23);
            webPasswordTextBox.TabIndex = 6;
            // 
            // addPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webPasswordTextBox);
            Controls.Add(webNameTextBox);
            Controls.Add(websiteTextBox);
            Controls.Add(addPasswordButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addPassword";
            Text = "addPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button addPasswordButton;
        private TextBox websiteTextBox;
        private TextBox webNameTextBox;
        private TextBox webPasswordTextBox;
    }
}