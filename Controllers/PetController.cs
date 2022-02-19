using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace PetCity.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{



    private readonly IPetService _IPetService;
    public PetController(IPetService petService)
    {
        _IPetService = petService;
    }


    [HttpGet]
    public List<Pet> GetAll()
    {
        return _IPetService.GetAll();
    }

    [HttpGet("{id}")]
    public Pet GetPet(int id)
    {
        return _IPetService.GetPet(id);
    }
    [HttpPost]
    public string PetAdd(Pet pet)
    {
        string eror = "";
        PetValidator validator = new PetValidator();
        ValidationResult results = validator.Validate(pet);
        if (results.IsValid)
        {
            return _IPetService.PetAdd(pet);
        }
        foreach (var Errors in results.Errors)
        {
            eror += Errors.ErrorMessage + "\n";
        }
        return eror;

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _IPetService.Delete(id);
    }

    [HttpPut("{id}")]
    public Pet Put(Pet pet, int id)
    {

        return _IPetService.PetEdit(pet, id);

    }
}

