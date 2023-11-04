using System.Text;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;

namespace hazi2
{
    public partial class registerForm : Form
    {
        private DatabaseManager dbManager;
        public registerForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            dbManager.CreateDatabaseAndTables();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User(usernameTextBox.Text, passwordTextBox.Text);
            dbManager.InsertUserData(user);

            Home home = new Home(user.Username);
            home.Show();
            this.Hide();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
