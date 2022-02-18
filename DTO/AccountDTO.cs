public class AccountDTO
{
    //For Test

    public static List<AccountDTO> AccountDTOList = new List<AccountDTO>(); 

    public int Id { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public bool isBlocked { get; set; }

    public AccountDTO()
    {
        
    }

    public AccountDTO(int Id, string Email, string Password)
    {
        this.Id = Id;
        this.Email = Email;
        this.Password = Password;
    }
}