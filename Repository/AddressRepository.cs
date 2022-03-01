public class AddressRepository
{

PetCityContext _petCityContext;

    public AddressRepository()
    {
        _petCityContext = new PetCityContext();
    }
 
    public List<Address> GetAllAddresses()
    {

        return MockData.ListOfAddress;
    }
    public Address GetAddress(int id)
    {
        var addresscontroller = MockData.ListOfAddress.FirstOrDefault(x => x.Id == id);

        if (addresscontroller != null)
        {

            return addresscontroller;

        }
        else
        {
            return null;
        }
    }

    public async Task <List<Country>> GetAllCountry()
    {

        return await _petCityContext.Country.ToListAsync();
    }
    


    public Country GetCountry(int id)
    {
        var Countrycontroller = MockData.ListOfCountry.FirstOrDefault(x => x.Id == id);

        if (Countrycontroller != null)
        {

            return Countrycontroller;

        }
        else
        {
            return null;
        }
    }

    public List<City> GetAllCity()
    {

        return MockData.ListOfCity;
    }


    public City GetCity(int id)
    {
        var Citycontroller = MockData.ListOfCity.FirstOrDefault(x => x.Id == id);

        if (Citycontroller != null)
        {

            return Citycontroller;

        }
        else
        {
            return null;
        }
    }

    public List<State> GetAllState()
    {

        return MockData.ListOfState;
    }


    public State GetState(int id)
    {
        var Statecontroller = MockData.ListOfState.FirstOrDefault(x => x.Id== id);

        if (Statecontroller != null)
        {

            return Statecontroller;

        }
        else
        {
            return null;
        }
    }

    public List<District> GetAllDistricts()
    {

        return MockData.ListOfDistrict;
    }


    public District GetDistrict(int id)
    {
        var Districtcontroller = MockData.ListOfDistrict.FirstOrDefault(x => x.Id == id);

        if (Districtcontroller != null)
        {

            return Districtcontroller;

        }
        else
        {
            return null;
        }
    }


    public List<Neighborhood> GetAllNeigborhoods()
    {

        return MockData.ListOfNeighborhood;
    }


    public Neighborhood GetAllNeigborhood(int id)
    {
        var Neigborhoodcontroller = MockData.ListOfNeighborhood.FirstOrDefault(x => x.Id== id);

        if (Neigborhoodcontroller != null)
        {

            return Neigborhoodcontroller;

        }
        else
        {
            return null;
        }
    }

    public List<Street> GetAllStreets()
    {

        return MockData.ListOfStreet;
    }

    public Street GetAllStreet(int id)
    {
        var Streetcontroller = MockData.ListOfStreet.FirstOrDefault(x => x.Id == id);

        if (Streetcontroller != null)
        {

            return Streetcontroller;

        }
        else
        {
            return null;
        }
    }

}