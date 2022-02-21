using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{

    private readonly IAccountService _accountService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;

    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]

    public ActionResult<ServiceResponse<List<Account>>> getAccount()
    {
        return ResponseGeneratorHelper.ResponseGenerator(_accountService.getAccount());
    }

    [HttpGet("{email}")]
    public  ActionResult<ServiceResponse<Account>> getAccountByEmail(string email)
    {
        return _accountService.getAccountByEmail(email);
    }


    [HttpPost]
    public ActionResult<ServiceResponse<string>> setAccount(Account account)
    {
        return ResponseGeneratorHelper.ResponseGenerator(_accountService.setAccount(account));
    }

}