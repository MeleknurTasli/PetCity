using Microsoft.AspNetCore.Mvc;
public interface IAccountService{
     List<Account> GetAllAccounts();
     Account GetAccountByEmail(string email);
     AccountDTO CreateNewAccount(AccountDTO account);
     Account ChangeVisibilityOfAccount(); 
     Account UpdateAccountByEmail(Account account,string email);
     Account UpdateAccountPassword(string oldpassword,string newpassword);
     Account BlockAccount();
     Account Role();

}