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

    Pet IPetService.getPetsByPetId(int id)
    {
        throw new NotImplementedException();
    }

    string IPetService.PetAdd(Pet pet)
    {
        throw new NotImplementedException();
    }

    Pet IPetService.PetEdit(Pet pet, int id)
    {
        throw new NotImplementedException();
    }
}