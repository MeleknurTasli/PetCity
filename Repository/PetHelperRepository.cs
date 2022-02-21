public class PetHelperRepository
{

    public PetHelper Add(PetHelper petHelper)
    {
        MockData.PetHelperMockDataList.Add(petHelper);
        
        return petHelper;
    }
    public List<PetHelper> GetPetHelper()
    {
        return  MockData.PetHelperMockDataList;
    }
    public  PetHelper FindPetHelperByLatLong(string latitude, string longtitude){
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Latitude == latitude && p.Longtitude == longtitude);
        return result;

    }

    public PetHelper UpdatePetHelper (int id, PetHelper petHelper)
    {
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Id == id);
        if(result != null)
        {
            result.UserId = petHelper.UserId;
            result.Image = petHelper.Image;
            result.Date = petHelper.Date;
            result.Description = petHelper.Description;
            result.Latitude = petHelper.Latitude;
            result.Longtitude = petHelper.Longtitude;
        }
        return result;
    }
    public PetHelper GetById (int id)
    {
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Id == id);
         return result;
    }
   
    public string GetPetHelperDelete(int id)
    {
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Id == id);
       int index=MockData.PetHelperMockDataList.IndexOf(result);
       MockData.PetHelperMockDataList.RemoveAt(index);
       return "ok";
        
    }

}