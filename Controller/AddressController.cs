using Microsoft.AspNetCore.Mvc;
namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _IAddressService;
    public AddressController(IAddressService addressService)
    {
        _IAddressService = addressService;
    }

    [HttpGet]
    public ActionResult<List<Address>> GetAllAddress()
    {
        return _IAddressService.GetAllAdress();
    }

}