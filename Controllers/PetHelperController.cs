using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetHelperController : ControllerBase
{
    private readonly IPetHelperService _petHelperService;
    private PetHelperValidator _validator;
    private ResponseGeneratorHelper ResponseGeneratorHelper;

    public PetHelperController(IPetHelperService petHelperService, PetHelperValidator validator)
    {
        _petHelperService = petHelperService;
        _validator = validator;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();
    }

    [HttpGet ("getall")]
    public ActionResult<ServiceResponse<List<PetHelper>>> GetAll()
        {
            return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.GetAll());
        }
        
    [HttpPost]
    public ActionResult<ServiceResponse<PetHelper>> Add(PetHelper petHelper)
    {
       return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.Add(petHelper));
    }
    [HttpGet("{latitude}/{longtitude}")]
    public ActionResult<ServiceResponse<PetHelper>> FindPetHelperByLatLong(string latitude,string longtitude){
       return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.FindPetHelperByLatLong(latitude,longtitude));
    }

    [HttpPut]
    public ActionResult<ServiceResponse<PetHelper>> Update([FromQuery] int id, [FromBody]PetHelper petHelper)
    {
        return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.Update(id,petHelper)); 
    }
    [HttpGet]
    public ActionResult<ServiceResponse<PetHelper>> GetById([FromQuery] int id)
    {
        return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.GetById(id));
    }

    [HttpDelete]
    public ActionResult<ServiceResponse<string>> Delete([FromQuery]int id)
    {
        return ResponseGeneratorHelper.ResponseGenerator(_petHelperService.Delete(id));
    }
}

