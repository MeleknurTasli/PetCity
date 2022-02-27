public class AddressService : IAddressService


{   private AddressRepository addressRepository;
    public AddressService()
    {
        addressRepository = new AddressRepository();
    }
     List<Address> GetAllAdress()
    {
        List<Address> Response=new List<Address>();
       Response = addressRepository.GetAllAddress();
        return Response;
    }

    List<Address> IAddressService.GetAdress(int id)
    {
        throw new NotImplementedException();
    }

    List<City> IAddressService.GetAllCity()
    {
        throw new NotImplementedException();
    }

    List<Country> IAddressService.GetAllCountry()
    {
        throw new NotImplementedException();
    }

    List<District> IAddressService.GetAllDistricts()
    {
        throw new NotImplementedException();
    }

    List<State> IAddressService.GetAllState()
    {
        throw new NotImplementedException();
    }

    List<City> IAddressService.GetCity(int id)
    {
        throw new NotImplementedException();
    }

    List<Country> IAddressService.GetCountry(int id)
    {
        throw new NotImplementedException();
    }

    List<District> IAddressService.GetDistricts(int id)
    {
        throw new NotImplementedException();
    }

    List<State> IAddressService.GetState(int id)
    {
        throw new NotImplementedException();
    }
}