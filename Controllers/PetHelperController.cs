using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetHelperController : ControllerBase
{
    private readonly IPetHelperService _petHelperService;
    private PetHelperValidator _validator;

    public PetHelperController(IPetHelperService petHelperService, PetHelperValidator validator)
    {
        _petHelperService = petHelperService;
        _validator = validator;
    }

    [HttpGet]
    public List<PetHelper> Get()
    {
        return _petHelperService.GetPetHelper();
    }
    [HttpPost]
    public string Add(PetHelper petHelper)
    {
        
        _validator.Validate(petHelper);
        _petHelperService.Add(petHelper);
        return "Ok";
    }
    [HttpGet("{latitude}/{longtitude}")]
    public PetHelper FindPetHelperByLatLong(string latitude,string longtitude){
        var result = _petHelperService.FindPetHelperByLatLong(latitude,longtitude);
        return result;
    }
}
