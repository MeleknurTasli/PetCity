public class PetRepository
{
    public List<Pet> GetAll()
    {

        return MockData.PetMockDataList;
    }

    public Pet GetPet(int id)
    {

        var petController = MockData.PetMockDataList.First(x => x.id == id);
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
    public string PetEdit(Pet pet, int id)
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

            return "Kayıt Başarılı";
        }
        else
        {
            return "BÖyle Id Bulunamadı";
        }

    }


}