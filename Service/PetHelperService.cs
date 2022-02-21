public class PetHelperService : IPetHelperService
{
    private PetHelperRepository petHelperRepository;
    public PetHelperService()
    {
        petHelperRepository = new PetHelperRepository();
    }

    public IResult Add(PetHelper petHelper)
    {
        petHelperRepository.Add(petHelper);
        return new SuccessResult();
    }

    public IDataResult<PetHelper> FindPetHelperByLatLong(string latitude, string longtitude)
    {
        var petHelper = petHelperRepository.FindPetHelperByLatLong(latitude,longtitude);
        if (latitude != null && longtitude != null)
        {
        return new SuccessDataResult<PetHelper>(petHelper.Data);
        }
        return null;
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