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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = new User(loginUsernameTextBox.Text,loginPasswordTextBox.Text);
            DatabaseManager databaseManager = new DatabaseManager();
            if(databaseManager.IsUserValid(user))
            {
                Home home = new Home(loginUsernameTextBox.Text);
                home.Show();
                this.Close();
            }

        }
    }
}
