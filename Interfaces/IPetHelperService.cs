public interface IPetHelperService{
    ServiceResponse<List<PetHelper>> GetPetHelper();
    IResult Add(PetHelper petHelper);
    IDataResult <PetHelper> FindPetHelperByLatLong(string latitude, string longtitude);
}