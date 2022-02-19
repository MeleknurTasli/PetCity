using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetHelperController : ControllerBase
{
    private readonly IPetHelperService _petHelperService;

    public PetHelperController(IPetHelperService petHelperService)
    {
        _petHelperService = petHelperService;
    }

    [HttpGet]
    public List<PetHelper> Get()
    {
        return _petHelperService.GetPetHelper();
    }
    [HttpPost]
    public string Add(PetHelper petHelper)
    {
        _petHelperService.Add(petHelper);
        return "Ok";
    }
    [HttpGet("{latitude}/{longtitude}")]
    public PetHelper FindPetHelperByLatLong(string latitude,string longtitude){
        var result = _petHelperService.FindPetHelperByLatLong(latitude,longtitude);
        return result;
    }
}
