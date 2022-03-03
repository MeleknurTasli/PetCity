using System.Collections.Generic;

public interface IAddressRepository
{
    Task<List<Address>> GetAllAddress();
    Task<Address> GetAddress(int id);
    Task<List<Country>> GetAllCountry();
    Task<List<State>> GetAllStatesByCountryId(int id);
    Task<List<City>> GetAllCitiesByStateId(int id);
    Task<List<City>> GetAllCitiesByContryId(int id);
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task<Address> RegisterAddress();
    Task<Address> DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);

}