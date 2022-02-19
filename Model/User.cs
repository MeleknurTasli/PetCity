
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirdthDay { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public Byte[]? Image { get; set; }
    public Account? Account { get; set; }


    public User()
    {

    }

    public User(int Id, string Name, string Surname, Gender Gender, DateTime BirdthDay, string PhoneNumber, string Address, Byte[] Image, Account Account)
    {
        this.Id = Id;
        this.Name = Name;
        this.Surname = Surname;
        this.Gender = Gender;
        this.BirdthDay = BirdthDay;
        this.PhoneNumber = PhoneNumber;
        this.Address = Address;
        this.Image = Image;
        this.Account = Account;
    }
}