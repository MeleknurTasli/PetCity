using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost("add")]
    public async Task<Account> Add(Account account)
    {
        await _accountService.CreateNewAccount(account); //AccountDTO mu yapılacak??
        return account;
    }
   /* [HttpPut("delete")]
    public async Task TaskDelete(Account account)
    {
        await _accountService.DeleteAccount(account);           burası visiblea çevrilecek
        
    }*/
    [HttpPut("update")]
    public async Task<Account> UpdateAccountByEmail(Account account,string email)
    {
        var result = await _accountService.UpdateAccountByEmail(account,email); //controllerdaki parametre içindeki sıralama önemli değil,serviceteki parametre sıralaması önemli yine de hepsini aynı yap
        return result;
        
    }

    [HttpGet("getall")]
    public async Task<List<Account>> GetAll()
    {
       var allAccounts= await _accountService.GetAllAccounts();  
       return allAccounts;
    }
    [HttpGet("getbyemail")]
    public async Task<Account> GetByAccountEmail(string email)
    {
        var result = await _accountService.GetAccountByEmail(email);
        return result;
    }
}