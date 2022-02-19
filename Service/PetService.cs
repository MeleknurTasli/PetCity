public class PetService : IPetService
{
      private PetRepository petRepository;
    public PetService()
    {
        petRepository = new PetRepository();
    }

     string IPetService.Delete(int id)
    {
        if (id != null)
        {
             petRepository.Delete(id);
             return"Kayıt Silindi";
        }
        return "Girilen id ile eşleşen kayıt yok";
        
    }

    List<Pet> IPetService.GetAll()
    {
        return petRepository.GetAll();
    }

    public Pet GetPet(int id)
    {
        var pet = petRepository.GetPet(id);
        if (pet != null)
        {
            return pet;
        }
        return null;
    }

    public string PetAdd(Pet pet)
    {
     if(GetPet(pet.id) == null)
        {
            petRepository.PetAdd(pet);
        }else{
            return "Aynı id'ye sahip pet bulunmkatadır";
        }
        
        return "Yeni Kayıt Oluşturuldu.";
    }

    Pet IPetService.PetEdit(Pet pet, int id)
    {
       return petRepository.PetEdit(pet,id);
    }

}