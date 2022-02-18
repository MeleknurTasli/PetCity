
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Gender Gender { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public Byte[]? Image {get; set;}
    public Account? Account { get; set; }
    
}