using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Home : Form
    {
        private string username;
        public Home(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            usernameHomeText.Text = username;
        }

        private void vaultDataGriedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usernameHomeText_Click(object sender, EventArgs e)
        {

        }

        private void addPassword_Click(object sender, EventArgs e)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            int userId = databaseManager.GetUserIdByUsername(username);
            addPassword addPasswordForm = new addPassword(userId, this);
            addPasswordForm.ShowDialog();
        }

        private void InitializeDataGridView()
        {


            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "id";
            idColumn.DataPropertyName = "id";
            idColumn.Name = "id";
            vaultDataGriedView.Columns.Add(idColumn);

            DataGridViewTextBoxColumn useridColumn = new DataGridViewTextBoxColumn();
            useridColumn.HeaderText = "userid";
            useridColumn.DataPropertyName = "userid";
            useridColumn.Name = "userid";
            vaultDataGriedView.Columns.Add(useridColumn);

            DataGridViewTextBoxColumn webUsernameColumn = new DataGridViewTextBoxColumn();
            webUsernameColumn.HeaderText = "webUsername";
            webUsernameColumn.DataPropertyName = "webUsername";
            webUsernameColumn.Name = "webUsername";
            vaultDataGriedView.Columns.Add(webUsernameColumn);

            DataGridViewTextBoxColumn webPasswordColumn = new DataGridViewTextBoxColumn();
            webPasswordColumn.HeaderText = "webPassword";
            webPasswordColumn.DataPropertyName = "webPassword";
            webPasswordColumn.Name = "webPassword";
            vaultDataGriedView.Columns.Add(webPasswordColumn);

            DataGridViewTextBoxColumn websiteColumn = new DataGridViewTextBoxColumn();
            websiteColumn.HeaderText = "website";
            websiteColumn.DataPropertyName = "website";
            websiteColumn.Name = "website";
            vaultDataGriedView.Columns.Add(websiteColumn);

            // Egyéb oszlopok hozzáadása hasonló módon

            // Adatok lekérdezése az adatbázisból
            DatabaseManager databaseManager = new DatabaseManager();
            int userId = databaseManager.GetUserIdByUsername(username);
            DataTable vaultData = databaseManager.GetVaultDataByUserId(userId);

            // DataGridView adatforrásának beállítása
            vaultDataGriedView.DataSource = vaultData;

            DataGridViewButtonColumn logUserIdColumn = new DataGridViewButtonColumn();
            logUserIdColumn.HeaderText = "logId";
            logUserIdColumn.Text = "logId";
            logUserIdColumn.Name = "logId";
            logUserIdColumn.UseColumnTextForButtonValue = true;
            vaultDataGriedView.Columns.Add(logUserIdColumn);

            // Wire up the CellContentClick event to handle button clicks
            vaultDataGriedView.CellContentClick += vaultDataGriedView_CellContentClick;

        }

        public void AddNewRowToDataGridView(Vault vault)
        {
            DataTable dataTable = (DataTable)vaultDataGriedView.DataSource;
            byte[] decodedBytes = Convert.FromBase64String(vault.webPassword.ToString());
            string decodedPassword = Encoding.UTF8.GetString(decodedBytes);
            dataTable.Rows.Add(vault.id ,vault.userId, vault.webUsername, decodedPassword, vault.webSite);
            vaultDataGriedView.DataSource = null;
            vaultDataGriedView.DataSource = dataTable;
        }

        private void vaultDataGriedView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == vaultDataGriedView.Columns["logId"].Index && e.RowIndex != -1)
            {
                int id = Convert.ToInt32(vaultDataGriedView.Rows[e.RowIndex].Cells["id"].Value);
                System.Diagnostics.Debug.WriteLine("ID clicked (button): " + id);
            }
        }
    }
}
