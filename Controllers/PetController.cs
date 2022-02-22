using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetService _IPetService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;
    public PetController(IPetService petService)
    {
        _IPetService = petService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();
    }


    [HttpGet]
    public ActionResult<ServiceResponse<List<Pet>>> GetAll()
    {
        return ResponseGeneratorHelper.ResponseGenerator(_IPetService.GetAll());
    }

    /////GetPet Urlden id girlen yöntem//////
    /*[HttpGet("{id}")]
    public ActionResult<ServiceResponse<Pet>> GetPet(int id)
    {
         return ResponseGeneratorHelper.ResponseGenerator(_IPetService.GetPet(id));
    }*/

///

    [HttpGet("{id}")]
    public ActionResult<ServiceResponse<Pet>> GetPet(int id)
    {

         return ResponseGeneratorHelper.ResponseGenerator(_IPetService.GetPet(id));
    }

    ///////GetPet Metodu QueryString ile çekilmiş 2. yöntem https://localhost:7278/Pet/GetPet?id=2 şeklinde girilecek /////
    // [HttpGet("{id}")]
    // public ActionResult<ServiceResponse<Pet>> GetPet()
    // {
    //     var QueryString= Request.QueryString;
    //     var id=Request.Query["id"].ToString();
    //      return ResponseGeneratorHelper.ResponseGenerator(_IPetService.GetPet(Convert.ToInt32(id)));
    // }

    [HttpPost]
    public ActionResult<ServiceResponse<string>> PetAdd(Pet pet)
    {

        return ResponseGeneratorHelper.ResponseGenerator(_IPetService.PetAdd(pet));

        // string eror = "";
        // PetValidator validator = new PetValidator();
        // ValidationResult results = validator.Validate(pet);
        // if (results.IsValid)
        // {
        //     return _IPetService.PetAdd(pet);
        // }
        // foreach (var Errors in results.Errors)
        // {
        //     eror += Errors.ErrorMessage + "\n";
        // }
        // return eror;

    }

    [HttpDelete("{id}")]
    public ActionResult<ServiceResponse<string>> PetAdd(int id)
    {

        return ResponseGeneratorHelper.ResponseGenerator(_IPetService.Delete(id));

        // _IPetService.Delete(id);
    }

    [HttpPut("{id}")]
    public ActionResult<ServiceResponse<Pet>> Put(Pet pet, int id)
    {
        return ResponseGeneratorHelper.ResponseGenerator(_IPetService.PetEdit(pet,id));
        // return _IPetService.PetEdit(pet, id);
    }
}

