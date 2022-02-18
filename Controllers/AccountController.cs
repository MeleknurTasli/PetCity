using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpGet]
    public List<Account> getAccount()
    {
        return _accountService.getAccount();
    }

    [HttpGet("{email}")]
    public Account getAccountByEmail(string email)
    {
        return _accountService.getAccountByEmail(email);
    }

    
    [HttpPost]
    public string setAccount(Account account)
    {
        return _accountService.setAccount(account);
    }

}