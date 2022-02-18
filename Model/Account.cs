public class Account
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool isBlocked { get; set; }

    public Account()
    {

    }

    public Account(int Id, string Email, string Password)
    {
        this.Id = Id;
        this.Email = Email;
        this.Password = Password;
    }
}