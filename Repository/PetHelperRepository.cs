public class PetHelperRepository
{

    public string Add(PetHelper petHelper)
    {
        MockData.PetHelperMockDataList.Add(petHelper);
        return "Ok";
    }
    public List<PetHelper> GetPetHelper()
    {
        return MockData.PetHelperMockDataList;
    }
    public PetHelper FindPetHelperByLatLong(string latitude, string longtitude){
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Latitude == latitude && p.Longtitude == longtitude);
        return result;

    }
    
}