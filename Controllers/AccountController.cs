using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    private AccountService service = new AccountService();

    [HttpPost]

    public string SetAccount(AccountDTO account)
    {
        
        return service.setAccount(account);
    }

    [HttpGet]
    public List<AccountDTO> getAccount()
    {
        return service.getAccount();
    }

    [HttpGet("{email}")]
    public AccountDTO getAccountByEmail(string email)
    {
        return service.getAccountByEmail(email);
    }

}