public class AddressRepository
{


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

//  public List<Country> GetAllCountry()
//     {

//         return MockData.ListOfCountry;
//     }


//     public Country GetCountry(int id)
//     {
//         var Countrycontroller = MockData.ListOfCountry.FirstOrDefault(x => x.Id == id);

//         if (Countrycontroller != null)
//         {

//             return Countrycontroller;

//         }
//         else
//         {
//             return null;
//         }
//     }



}