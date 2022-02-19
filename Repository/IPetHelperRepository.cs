public interface IPetHelperRepository{
    IResult Add(PetHelper petHelper);
    IDataResult<PetHelper> FindPetHelperByLatLong(string latitude, string longtitude);
    IDataResult<List<PetHelper>> GetPetHelper();
}