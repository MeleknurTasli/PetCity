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
    public async Task<List<Address>> GetAllAddresses()
    {
        return await _IAddressService.GetAllAddresses();
    }

    [HttpGet("id")]
    public async Task<Address> GetAddress([FromQuery] int id)
    {
        return await _IAddressService.GetAddress(id);
    }

    [HttpGet("register")]
    public async Task<ActionResult<List<Country>>> GetAllCountries()
    {
        return  await _IAddressService.GetAllCountries();
    }

    [HttpGet("GetAllStates")]
    public async Task<List<State>> GetAllStatesByCountryId([FromQuery] int id)
    {
        return await _IAddressService.GetAllStatesByCountryId(id);
    }

    [HttpGet("GetAllCities")]
    public async Task<List<City>> GetAllCitiesByStateId([FromQuery] int id)
    {
        return await _IAddressService.GetAllCitiesByStateId(id);
    }

    [HttpGet("GetAllCities")]
    public async Task<List<City>> GetAllCitiesByContryId([FromQuery] int id)
    {
        return await _IAddressService.GetAllCitiesByContryId(id);
    }

    [HttpGet("GetAllDistricts")]
    public async Task<List<District>> GetAllDistrictsByCityId([FromQuery] int id)
    {
        return await _IAddressService.GetAllDistrictsByCityId(id);
    }

    [HttpGet("GetAllNeighborhoods")]
    public async Task<List<Neighborhood>> GetAllNeighborhoodsByDistrictId([FromQuery] int id)
    {
        return await _IAddressService.GetAllNeighborhoodsByDistrictId(id);
    }

    [HttpGet("GetAllStreets")]
    public async Task<List<Street>> GetAllStreetsByNeighborhoodtId([FromQuery] int id)
    {
        return await _IAddressService.GetAllStreetsByNeighborhoodtId(id);
    }

    [HttpPost]
    public async Task<Address> RegisterAddress([FromQuery] int id)
    {
        return await _IAddressService.RegisterAddress();
    }

    [HttpDelete("DeleteAddress")]
    public async Task<Address> DeleteAddress([FromQuery] int id)
    {
        return await _IAddressService.DeleteAddress(id);
    }


    [HttpPut("UpdateAddress")]
    public async Task<Address> UpdateAddress([FromQuery] int id)
    {
        return await _IAddressService.UpdateAddress(id);
    }

}