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
    public ActionResult<List<Address>> GetAllAddresses()
    {
        return _IAddressService.GetAllAddresses();
    }

    [HttpGet("id")]
    public ActionResult<Address> GetAddress([FromQuery] int id)
    {
        return _IAddressService.GetAddress(id);
    }

    [HttpGet("register")]
    public ActionResult<List<Country>> GetAllCountries()
    {
        return _IAddressService.GetAllCountries();
    }

    [HttpGet("GetAllStates")]
    public ActionResult<List<State>> GetAllStatesByCountryId([FromQuery] int id)
    {
        return _IAddressService.GetAllStatesByCountryId(id);
    }

    [HttpGet("GetAllCities")]
    public ActionResult<List<City>> GetAllCitiesByStateId([FromQuery] int id)
    {
        return _IAddressService.GetAllCitiesByStateId(id);
    }

    [HttpGet("GetAllCities")]
    public ActionResult<List<City>> GetAllCitiesByContryId([FromQuery] int id)
    {
        return _IAddressService.GetAllCitiesByContryId(id);
    }

    [HttpGet("GetAllDistricts")]
    public ActionResult<List<District>> GetAllDistrictsByCityId([FromQuery] int id)
    {
        return _IAddressService.GetAllDistrictsByCityId(id);
    }

    [HttpGet("GetAllNeighborhoods")]
    public ActionResult<List<Neighborhood>> GetAllNeighborhoodsByDistrictId([FromQuery] int id)
    {
        return _IAddressService.GetAllNeighborhoodsByDistrictId(id);
    }

    [HttpGet("GetAllStreets")]
    public ActionResult<List<Street>> GetAllStreetsByNeighborhoodtId([FromQuery] int id)
    {
        return _IAddressService.GetAllStreetsByNeighborhoodtId(id);
    }

    [HttpPost]
    public ActionResult<Address> RegisterAddress([FromQuery] int id)
    {
        return _IAddressService.RegisterAddress();
    }

    [HttpDelete("DeleteAddress")]
    public ActionResult<Address> DeleteAddress([FromQuery] int id)
    {
        return _IAddressService.DeleteAddress(id);
    }


    [HttpPut("UpdateAddress")]
    public ActionResult<Address> UpdateAddress([FromQuery] int id)
    {
        return _IAddressService.UpdateAddress(id);
    }

}