public interface IPetHelperService{
    ServiceResponse<List<PetHelper>> GetPetHelper();
    ServiceResponse<PetHelper> Add(PetHelper petHelper);
    ServiceResponse <PetHelper> FindPetHelperByLatLong(string latitude, string longtitude);
    ServiceResponse<PetHelper> GetById (int id);
    ServiceResponse<PetHelper> UpdatePetHelper(int id, PetHelper petHelper);
}