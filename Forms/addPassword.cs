using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazi2
{
    public partial class addPassword : Form
    {
        private int userId;
        private Home _homeForm;
        public addPassword(int userId, Home homeForm)
        {
            InitializeComponent();
            _homeForm = homeForm;
            this.userId = userId;   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addPasswordButton_Click(object sender, EventArgs e)
        {
            Vault vault = new Vault(userId, webNameTextBox.Text,webPasswordTextBox.Text,websiteTextBox.Text);
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.InsertVault(vault);
            _homeForm.AddNewRowToDataGridView(vault);
            this.Close();
            System.Diagnostics.Debug.WriteLine(userId);
        }
    }
}
