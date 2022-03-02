using FluentValidation;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase 
{
    private readonly IAccountService _accountService;

    
    public AccountController (IAccountService accountService)
    {
        _accountService=accountService;
    }
    [HttpPost]
    public AccountDTO Create(AccountDTO account)
    {
        return _accountService.CreateNewAccount(account);
    }
}
        
