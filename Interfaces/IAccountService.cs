using Microsoft.AspNetCore.Mvc;

public interface IAccountService
{
    ServiceResponse<List<Account>> getAccount();
    ServiceResponse<Account> getAccountByEmail(string email);
    ServiceResponse<string> setAccount(Account account);
}