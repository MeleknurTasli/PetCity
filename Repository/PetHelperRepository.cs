public class PetHelperRepository : IPetHelperRepository
{

    public IResult Add(PetHelper petHelper)
    {
        MockData.PetHelperMockDataList.Add(petHelper);
        
        return new SuccessResult();
    }
    public IDataResult <List<PetHelper>> GetPetHelper()
    {
        return new SuccessDataResult<List<PetHelper>>( MockData.PetHelperMockDataList);
    }
    public  IDataResult<PetHelper> FindPetHelperByLatLong(string latitude, string longtitude){
        var result = MockData.PetHelperMockDataList.SingleOrDefault(p => p.Latitude == latitude && p.Longtitude == longtitude);
        return new SuccessDataResult<PetHelper>( result);

    }


}