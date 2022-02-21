using Microsoft.AspNetCore.Mvc;

public class AccountService : IAccountService
{

    private AccountRepository accountRepository;

    public AccountService()
    {
        accountRepository = new AccountRepository();
    }

    public ServiceResponse<List<Account>> getAccount()
    {
        ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();

        try
        {
            response.Data = accountRepository.getAccount();
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationFail;
            return response;
        }

    }

    public ServiceResponse<Account> getAccountByEmail(string email)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();
        var user = accountRepository.getAccountByEmail(email);
        if (user != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetAccountByEmailOperationSuccess;
            response.Data = user;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.GetAccountByEmailOperationFail;
        return response;
    }

    public ServiceResponse<string> setAccount(Account account)
    {
        ServiceResponse<string> response = new ServiceResponse<string>();
        if (accountRepository.getAccountByEmail(account.Email) == null)
        {
            accountRepository.setAccount(account);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.DuplicateAccountError;
        return response;
    }


}