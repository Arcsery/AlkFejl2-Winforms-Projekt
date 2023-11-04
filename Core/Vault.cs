using System.Text;

public class Vault
{
    public int userId { get; set; }
    public string webUsername { get; set; }
    public string webPassword { get; set; }
    public string webSite { get; set; }

    public Vault(int userId, string webUsername, string webPassword, string webSite)
    {
        this.userId = userId;
        this.webUsername = webUsername;
        this.webPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(webPassword));
        this.webSite = webSite;
    }
}