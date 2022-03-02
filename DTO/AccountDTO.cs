[Serializable]
public class AccountDTO
{

    public AccountDTO() {
        
    }
    public AccountDTO(Account account) {
        this.Email = account.Email;
        this.IsBlocked = account.IsBlocked;
    }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsBlocked { get; set; }
}