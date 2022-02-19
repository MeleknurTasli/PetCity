using FluentValidation.Results;
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
    public IActionResult Add(PetHelper petHelper)
    {
       ValidationResult results = _validator.Validate(petHelper);
       if(results.IsValid){
       var result = _petHelperService.Add(petHelper);
        if(result.Success){
            return Ok(result);
        }
       }
        return BadRequest();
    }
    [HttpGet("{latitude}/{longtitude}")]
    public PetHelper FindPetHelperByLatLong(string latitude,string longtitude){
        var result = _petHelperService.FindPetHelperByLatLong(latitude,longtitude);
        return result;
    }
}
