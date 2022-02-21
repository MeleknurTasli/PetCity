public class PetRepository
{
    public List<Pet> GetAll()
    {

        return MockData.PetMockDataList;
    }

    public Pet GetPet(int id)
    {

        var petController = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        if (petController != null)
        {
            return petController;

        }
        else
        {
            return null;
        }

    }
    /*Update*/
    public Pet PetEdit(Pet pet, int id)
    {
        var editedPet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        if (editedPet != null)
        {
            editedPet.name = pet.name;
            editedPet.About = pet.About;
            editedPet.BirthDate = pet.BirthDate;
            editedPet.Family = pet.Family;
            editedPet.Gender = pet.Gender;
            editedPet.Genus = pet.Genus;
            editedPet.UserID = pet.UserID;

            return editedPet;
        }
        else
        {
            return null;
        }

    }


    public string PetAdd(Pet pet)
    {
          if(GetPet(pet.id) == null)
        {
            MockData.PetMockDataList.Add(pet);
        }else{
            return "kayıtlı pet";
        }
        
        return "Ok";
    }

    public string Delete(int id)
    {

        var deletePet = MockData.PetMockDataList.FirstOrDefault(x => x.id == id);
        MockData.PetMockDataList.Remove(deletePet);
        return "Veri Silindi";

    }


}