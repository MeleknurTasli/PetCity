using Microsoft.AspNetCore.Mvc;
public interface IAccountService{
     Task<List<Account>> GetAllAccounts();
     Task<Account> GetAccountByEmail(string email);
     Task<Account> CreateNewAccount(Account account);
     Task<Account> ChangeVisibilityOfAccount(); 
     Task<Account> UpdateAccountByEmail(Account account,string email);
     Task<Account> UpdateAccountPassword(string oldpassword,string newpassword);
     Task<Account> BlockAccount();
     Task<Account> Role();

}