public interface IAccountRepository
{
    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateAccount(Account account);
    Task<Account> GetAccountByEmail(string email);
    Task<Account> UpdateAccountByEmail(string email, Account account);
    Task<Account> UpdateAccountPassword(Account acount,string oldpassword, string newpassword); 
    Task<Account> ChangeVisibilityOfAccount();
    Task<Account> BlockAccount();
    Task<Account> Role();
    Task<AccountDTO> CreateAccount(AccountDTO account);   
    Task<Account> FindAccountByEmailAndPassword(LoginDTO loginDTO);       
    Account findAccountById(int id);
}