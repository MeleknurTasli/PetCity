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
    [HttpPost("add")]
    public async Task<Account> Create(Account account)
    {
        await _accountService.CreateNewAccount(account);
        return account;
    }
    [HttpPut("delete")]
    public async Task<Account> Delete(Account account)
    {
        await _accountService.DeleteAcccount(account);
        
    }
    [HttpGet("getall")]
    public async Task<List<Account>> GetAllAccounts(Account account)
    {
        
        return await _accountService.GetAllAccounts(account);
    }
     [HttpPut("update")]
    public async Task<Account> UpdateAccount(int id, Account account)
    {
        var finalSituation= await _accountService.UpdateAcccount(account);
        return finalSituation;
    }

}
        
