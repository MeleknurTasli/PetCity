public interface IAccountRepository{
    Task<List<Account>> GetAllAccounts();
    Task<Account>CreateAccount(Account account);
     Task<Account> GetAccountByEmail(string email);
    Task<Account> UpdateAccountByEmail(string email,Account account);
     Task<Account> UpdateAccountPassword(string oldpassword,string newpassword);
      Task<Account> ChangeVisibilityOfAccount(); 
     Task<Account> BlockAccount();
     Task<Account> Role();
}