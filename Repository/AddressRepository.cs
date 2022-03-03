
public class AddressRepository : IAddressRepository
{

    PetCityContext _petCityContext;

    public AddressRepository()
    {
        _petCityContext = new PetCityContext();
    }

    public Address RegisterAddress()
    {
        return null;
    }


    public  List<Address> GetAllAddress()
    {

        return  _petCityContext.Set<Address>().ToList();
    }
    public  Address GetAddress(int id)
    {

        var getAddress =  _petCityContext.Set<Address>().SingleOrDefault(p => p.Id == id);

        if (getAddress != null)
        {

            return getAddress;

        }
        else
        {
            return null;
        }
    }

    public List<Country> GetAllCountry()
    {

        return  _petCityContext.Set<Country>().ToList();
    }

    string name;
    public  List<State> GetAllStatesByCountryId(int id)
    {
        Country countryname = _petCityContext.Country.SingleOrDefault(x => x.Id == id);
        var name = countryname.Name;
        var getState =  _petCityContext.Set<State>().Where(p => p.Id == id).ToList();
        if (getState != null)
        {

            return getState;

        }
        else
        {
            return null;
        }
    }

    public  List<City> GetAllCitiesByStateId(int id)
    {
        var getCity =  _petCityContext.Set<City>().Where(p => p.Id == id).ToList();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public  List<City> GetAllCitiesByContryId(int id)
    {
        var getCity =  _petCityContext.Set<City>().Where(p => p.Id == id).ToList();
        if (getCity != null)
        {

            return getCity;

        }
        else
        {
            return null;
        }
    }

    public  List<District> GetAllDistrictsByCityId(int id)
    {
        var getDistricts =  _petCityContext.Set<District>().Where(p => p.Id == id).ToList();
        if (getDistricts != null)
        {

            return getDistricts;

        }
        else
        {
            return null;
        }
    }
    public  Address DeleteAddress(int id)
    {


        var DeletedAddress =  _petCityContext.Address.FirstOrDefault(x => x.Id == id);
        _petCityContext.Address.Remove(DeletedAddress);
        _petCityContext.SaveChangesAsync();

        return null;


    }


    public  Address RegisterAddress(Address address)
    {
        address.City.Name = name;



        return null;
    }



    public Address UpdateAddress(int id)
    {
        throw new NotImplementedException();
    }


}


