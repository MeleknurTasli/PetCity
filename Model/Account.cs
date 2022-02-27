public class Account {
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsBlocked { get; set; }
    public bool Visibility { get; set; }
    public Account()
    {
        
    }
    public Account(int id,string email,string password,bool isblocked,bool visibility)
    {
        this.Id=id;
        this.Email=email;
        this.Password=password;
        this.IsBlocked=isblocked;
        this.Visibility=visibility;
    }
}
