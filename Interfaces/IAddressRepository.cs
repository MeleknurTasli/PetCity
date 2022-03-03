using System.Collections.Generic;

public interface IAddressRepository
{
    List<Address> GetAllAddress();
    Address GetAddress(int id);
 
    List<Country> GetAllCountry();
    List<State> GetAllStatesByCountryId(int id);
    List<City> GetAllCitiesByStateId(int id);
    List<City> GetAllCitiesByContryId(int id);
    List<District> GetAllDistrictsByCityId(int id);
    Address RegisterAddress();
    Address DeleteAddress(int id);
    Address UpdateAddress(int id);

}