using Microsoft.AspNetCore.Mvc;
public interface IAccountService{
     List<Account> GetAllAccount();
     Account GetAccountByEmail(string email);
     Account CreateNewAccount();
     Account ChangeVisibilityOfAccount(); 
     Account UpdateAccountByEmail(Account account,string email);
     Account UpdateAccountPassword(string oldpassword,string newpassword);
     Account BlockAccount();
     Account Role();

}