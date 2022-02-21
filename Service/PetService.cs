public class PetService : IPetService
{
    private PetRepository petRepository;
    public PetService()
    {
        petRepository = new PetRepository();
    }

    public string Delete(int id)
    {
        if (id != null)
        {
            petRepository.Delete(id);
            return "Kayıt Silindi";
        }
        return "Girilen id ile eşleşen kayıt yok";

    }


    public ServiceResponse<List<Pet>> GetAll()
    {
        ServiceResponse<List<Pet>> response = new ServiceResponse<List<Pet>>();

        try
        {
            response.Data = petRepository.GetAll();
            response.ResponseCode = ResponseCodeEnum.GetAllPetOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationFail;
            return response;
        }
    }

    public ServiceResponse<Pet> GetPet(int id)
    {
        ServiceResponse<Pet> response = new ServiceResponse<Pet>();
        var pet = petRepository.GetPet(id);
        if (pet != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetPetByIDOperationOperationSuccess;
            response.Data = pet;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.GetPetByIDOperationFail;
        return response;

    }

    public ServiceResponse<string> PetAdd(Pet pet)
    {
        ServiceResponse<string> response = new ServiceResponse<string>();
        if (petRepository.GetPet(pet.id) == null)
        {
            petRepository.PetAdd(pet);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.DuplicatePetError;
        return response;
    }

    public ServiceResponse<Pet> PetEdit(Pet pet, int id)
    {
        ServiceResponse<Pet> response = new ServiceResponse<Pet>();
        var edited = petRepository.PetEdit(pet, id);

        if (edited != null)
        {
            petRepository.PetEdit(pet, id);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PetIDNotFoundError;
            return response;
        }

    }

}