public class PetRepository : IPetRepository
{
    Pet IPetRepository.CreatePet(Pet pet)
    {
        throw new NotImplementedException();
    }

    void IPetRepository.DeletePet(int id)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IPetRepository.GetAllPets()
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IPetRepository.GetAllPetsHealthStatus(HealthStatus health)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IPetRepository.GetByPetsSpecies(string species)
    {
        throw new NotImplementedException();
    }

    Pet IPetRepository.GetPetById(int id)
    {
        throw new NotImplementedException();
    }

    void IPetRepository.GetPetHealthStatus(int id)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IPetRepository.GetPetsByGender(PetGender gender)
    {
        throw new NotImplementedException();
    }

    IEnumerable<Pet> IPetRepository.GetPetsByName(string name)
    {
        throw new NotImplementedException();
    }

    void IPetRepository.SetPetHealthStatus(int id)
    {
        throw new NotImplementedException();
    }

    Pet IPetRepository.UpdatePet(int id, Pet pet)
    {
        throw new NotImplementedException();
    }
}