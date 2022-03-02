using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase         //eksiklermiz var düzenleme yapacağız...
{
    private readonly IAccountService _accountService;

    public AccountController(IAccountService accountService)
    {
        _accountService=accountService;
    }
    [HttpPost]
    public async Task<Account> CreateNewAccount(Account account)
    {
        return await _accountService.CreateNewAccount(account);
    }

        
    
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