public interface IAccountRepository
{
    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateAccount(Account account);
    Task<Account> GetAccountByEmail(string email);
    Task<Account> UpdateAccountByEmail(string email, Account account);
    Task<Account> UpdateAccountPassword(Account acount,string oldpassword, string newpassword); //burayı yok edicez, çünkü repoyu daraltıcaz, (atomdan hücreye mevzusu)...
    Task<Account> ChangeVisibilityOfAccount();
    Task<Account> BlockAccount();
    Task<Account> Role();
    Task<AccountDTO> CreateAccount(AccountDTO account);   
    Account FindAccountByEmailAndPassword(LoginDTO loginDTO);       //TAskları eklenecek,unutma...
    Account findAccountById(int id);
}