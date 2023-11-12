namespace hazi2
{
    partial class Home
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
            usernameHomeText = new Label();
            vaultDataGriedView = new DataGridView();
            addPassword = new Button();
            ((System.ComponentModel.ISupportInitialize)vaultDataGriedView).BeginInit();
            SuspendLayout();
            // 
            // usernameHomeText
            // 
            usernameHomeText.AutoSize = true;
            usernameHomeText.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            usernameHomeText.Location = new Point(129, 36);
            usernameHomeText.Name = "usernameHomeText";
            usernameHomeText.Size = new Size(59, 25);
            usernameHomeText.TabIndex = 0;
            usernameHomeText.Text = "label1";
            usernameHomeText.Click += usernameHomeText_Click;
            // 
            // vaultDataGriedView
            // 
            vaultDataGriedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vaultDataGriedView.Location = new Point(380, 36);
            vaultDataGriedView.Name = "vaultDataGriedView";
            vaultDataGriedView.RowTemplate.Height = 25;
            vaultDataGriedView.Size = new Size(650, 402);
            vaultDataGriedView.TabIndex = 1;
            vaultDataGriedView.CellClick += vaultDataGriedView_CellClick;
            vaultDataGriedView.CellContentClick += vaultDataGriedView_CellContentClick;
            // 
            // addPassword
            // 
            addPassword.Location = new Point(12, 165);
            addPassword.Name = "addPassword";
            addPassword.Size = new Size(289, 70);
            addPassword.TabIndex = 2;
            addPassword.Text = "Új jelszó";
            addPassword.UseVisualStyleBackColor = true;
            addPassword.Click += addPassword_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 450);
            Controls.Add(addPassword);
            Controls.Add(vaultDataGriedView);
            Controls.Add(usernameHomeText);
            Name = "Home";
            Text = "Home";
            FormClosed += Home_FormClosed;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)vaultDataGriedView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameHomeText;
        private DataGridView vaultDataGriedView;
        private Button addPassword;
    }
}