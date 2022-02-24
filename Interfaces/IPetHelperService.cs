public interface IPetHelperService{
    ServiceResponse<List<PetHelper>> GetAll();
    ServiceResponse<PetHelper> Add(PetHelper petHelper);
    ServiceResponse <PetHelper> FindPetHelperByLatLong(string latitude, string longtitude);
    ServiceResponse<PetHelper> GetById (int id);
    ServiceResponse<PetHelper> Update(int id, PetHelper petHelper);
    ServiceResponse<string> Delete(int id);


}