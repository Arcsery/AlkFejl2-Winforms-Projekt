using System.Security.Cryptography;
using System.Text;
public class User
{
    public int Guid { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        this.Username = username;
        this.Password = HashPassword(password);
    }

    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] jelszoBytes = Encoding.UTF8.GetBytes(password);

            byte[] hasheltBytes = sha256.ComputeHash(jelszoBytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hasheltBytes.Length; i++)
            {
                builder.Append(hasheltBytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
