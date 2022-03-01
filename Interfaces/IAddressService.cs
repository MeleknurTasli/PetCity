using System.Collections.Generic;

public interface IAddressService
{
    public List<Address> GetAllAddresses();
    public Address GetAddress(int id);
    public Task< List<Country>> GetAllCountries();
    public List<State> GetAllStatesByCountryId(int id);
    public List<City> GetAllCitiesByStateId(int id);
    public List<City> GetAllCitiesByContryId(int id);
    public List<District> GetAllDistrictsByCityId(int id);
    public List<Neighborhood> GetAllNeighborhoodsByDistrictId(int id);
    public List<Street> GetAllStreetsByNeighborhoodtId(int id);
    public Address RegisterAddress();
    public Address DeleteAddress(int id);
    public Address UpdateAddress(int id);

}