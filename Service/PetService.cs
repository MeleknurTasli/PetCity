public class PetService : IPetService
{
      private PetRepository petRepository;
    public PetService()
    {
        petRepository = new PetRepository();
    }

    string IPetService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    List<Pet> IPetService.GetAll()
    {
        return petRepository.GetAll();
    }

    public Pet GetPet(int id)
    {
        var user = petRepository.GetPet(id);
        if (user != null)
        {
            return user;
        }
        return null;
    }

    public string PetAdd(Pet pet)
    {
     if(GetPet(pet.id) == null)
        {
            petRepository.PetAdd(pet);
        }else{
            return "Kayıtlı pet!";
        }
        
        return "Ok";
    }

    Pet IPetService.PetEdit(Pet pet, int id)
    {
        throw new NotImplementedException();
    }
}