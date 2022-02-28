public class AddressService : IAddressService


{
    private AddressRepository addressRepository;


    public AddressService()
    {
        addressRepository = new AddressRepository();
    }
    List<Address> GetAllAdress()
    {


        return addressRepository.GetAllAddress();
    }

    Address IAddressService.GetAdress(int id)
    {
        if (id != null)
        {
            return addressRepository.GetAdress(id);

        }
        return null;

    }

    List<City> IAddressService.GetAllCity()
    {

        return addressRepository.GetAllCity();
    }

    List<Country> IAddressService.GetAllCountry()
    {
         return addressRepository.GetAllCountry();
    }

    List<District> IAddressService.GetAllDistricts()
    {
         return addressRepository.GetAllDistricts();
    }

    List<State> IAddressService.GetAllState()
    {
    
         return addressRepository.GetAllState();
    }

    City IAddressService.GetCity(int id)
    {
         if (id != null)
        {
            return addressRepository.GetCity(id);

        }
        return null;

    Country IAddressService.GetCountry(int id)
    {
         if (id != null)
        {
            return addressRepository.GetAdress(id);

        }
        return null;
    }

   District IAddressService.GetDistrict(int id)
    {
         if (id != null)
        {
            return addressRepository.GetDistrict(id);

        }
        return null;
    }

    State IAddressService.GetState(int id)
    {
         if (id != null)
        {
            return addressRepository.GetState(id);

        }
        return null;
    }
    Neighborhood IAddressService.GetNeigborhood(int id)
    {
         if (id != null)
        {
            return addressRepository.GetNeigborhood(id);

        }
        return null;
    }
    List<Neighborhood> IAddressService.GetAllNeighborhood()
    {
         return addressRepository.GetAllCountry();
    }
    List<Country> IAddressService.GetAllCountry()
    {
         return addressRepository.GetAllCountry();
    }

    Street IAddressService.GetStreet(int id)
    {
         if (id != null)
        {
            return addressRepository.GetStreet(id);

        }
        return null;
    }



}