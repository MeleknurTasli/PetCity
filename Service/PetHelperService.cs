public class PetHelperService : IPetHelperService
{
    private PetHelperRepository petHelperRepository;
    public PetHelperService()
    {
        petHelperRepository = new PetHelperRepository();
    }

    public ServiceResponse<PetHelper> Add(PetHelper petHelper)
    {
         ServiceResponse<PetHelper> response = new ServiceResponse<PetHelper>();
         var petHelperData = petHelperRepository.FindPetHelperByLatLong(petHelper.Latitude,petHelper.Longtitude);
        if (petHelperData==null)
        {
            petHelperRepository.Add(petHelper);
            response.ResponseCode = ResponseCodeEnum.PetHelperAddSuccess;
            response.Data = petHelper;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.PetHelperAddFail;
        return response;
    }

    public ServiceResponse<PetHelper> FindPetHelperByLatLong(string latitude, string longtitude)
    {
        ServiceResponse<PetHelper> response = new ServiceResponse<PetHelper>();
        var petHelper = petHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
        if (latitude != null && longtitude != null)
        {
            response.ResponseCode = ResponseCodeEnum.FindPetHelperByLatLongSuccess;
            response.Data = petHelper;
            return response;
        }
        response.ResponseCode = ResponseCodeEnum.FindPetHelperByLatLongFail;
        return response;
    }

    public ServiceResponse<List<PetHelper>> GetPetHelper()
    {
        ServiceResponse<List<PetHelper>> response = new ServiceResponse<List<PetHelper>>();

        try
        {
            response.Data = petHelperRepository.GetPetHelper();
            response.ResponseCode = ResponseCodeEnum.GetAllPetHelperSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllPetHelperFail;
            return response;
        }
    }


}