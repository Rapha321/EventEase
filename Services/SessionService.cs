using System.Threading.Tasks;

namespace EventEase.Services;

public class SessionService
{
    public string? UserEmail { get; private set; }
    public string? UserName { get; private set; }

    public bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserEmail);

    public string? LastSearch { get; set; }
    public string? LastLocationFilter { get; set; }
    public string? LastMonthFilter { get; set; }

    public void Login(string email, string name) 
    { 
        UserEmail = email; 
        UserName = name; 
    } 
    
    public void Logout() 
    { 
        UserEmail = null; 
        UserName = null; 
    }

    public void SetUser(string email, string name)
    {
        UserEmail = email;
        UserName = name;
    }

    public void ClearUser()
    {
        UserEmail = null;
        UserName = null;
    }
}
