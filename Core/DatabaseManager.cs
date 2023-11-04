using hazi2;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text;

public class DatabaseManager
{
    private string connectionString = "Data Source=database.db;Version=3;";
    private string dbFilePath = "database.db";


    public void CreateDatabaseAndTables()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {

            if (!File.Exists(dbFilePath))
            {
                connection.Open();

                // Táblák létrehozása
                string createUsersTableQuery = "CREATE TABLE User (id INTEGER PRIMARY KEY AUTOINCREMENT, username TEXT NOT NULL UNIQUE, password TEXT NOT NULL)";
                string createVaultsTableQuery = "CREATE TABLE Vault (id INTEGER PRIMARY KEY AUTOINCREMENT, userid INTEGER, webUsername TEXT NOT NULL, webPassword TEXT NOT NULL, website TEXT NOT NULL, FOREIGN KEY (userid) REFERENCES Users(id) ON DELETE CASCADE ON UPDATE CASCADE)";

                using (SQLiteCommand cmd = new SQLiteCommand(createUsersTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (SQLiteCommand cmd = new SQLiteCommand(createVaultsTableQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }

    public void InsertUserData(User user)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string insertUserQuery = "INSERT INTO User (username, password) VALUES (@username, @password)";

            using (SQLiteCommand cmd = new SQLiteCommand(insertUserQuery, connection))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void InsertVault(Vault vault)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Vault (userid, webUsername, webPassword, website) VALUES (@userid, @webUsername, @webPassword, @website)";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userid", vault.userId);
                command.Parameters.AddWithValue("@webUsername", vault.webUsername);
                command.Parameters.AddWithValue("@webPassword", vault.webPassword);
                command.Parameters.AddWithValue("@website", vault.webSite);

                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }


    public void SelectAllUsers()
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectUsersQuery = "SELECT * FROM User";

            using (SQLiteCommand cmd = new SQLiteCommand(selectUsersQuery, connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string username = reader["username"].ToString();
                        string password = reader["password"].ToString();

                        System.Diagnostics.Debug.WriteLine($"ID: {id}, Username: {username}, Password: {password}");
                    }
                }
            }

            connection.Close();
        }
    }

    public bool IsUserValid(User user)
    {
        bool isValid = false;

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string checkUserQuery = "SELECT COUNT(*) FROM User WHERE username = @username AND password = @password";

            using (SQLiteCommand cmd = new SQLiteCommand(checkUserQuery, connection))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                isValid = count > 0;
            }

            connection.Close();
        }

        return isValid;
    }

    public int GetUserIdByUsername(string username)
    {
        int userId = -1; // Alapértelmezett érték, ha a felhasználót nem találjuk

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string getUserIdQuery = "SELECT id FROM User WHERE username = @username";

            using (SQLiteCommand cmd = new SQLiteCommand(getUserIdQuery, connection))
            {
                cmd.Parameters.AddWithValue("@username", username);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                }
            }

            connection.Close();
        }

        return userId;
    }

    public DataTable GetVaultDataByUserId(int userId)
    {
        DataTable dataTable = new DataTable();
        dataTable.Columns.Add("userid", typeof(int));
        dataTable.Columns.Add("webUsername", typeof(string));
        dataTable.Columns.Add("webPassword", typeof(string));
        dataTable.Columns.Add("website", typeof(string));

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string getVaultDataQuery = "SELECT userid,webUsername,webPassword,website FROM Vault WHERE UserID = @userId";

            using (SQLiteCommand cmd = new SQLiteCommand(getVaultDataQuery, connection))
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string webPasswordBase64 = reader["webPassword"].ToString();
                        string webPasswordDecoded = DecodeBase64(webPasswordBase64);

                        dataTable.Rows.Add(reader["userid"], reader["webUsername"], webPasswordDecoded, reader["website"]);
                    }
                }
            }

            connection.Close();
        }

        return dataTable;
    }

    private string DecodeBase64(string base64Encoded)
    {
        byte[] data = Convert.FromBase64String(base64Encoded);
        return Encoding.UTF8.GetString(data);
    }

}