
public interface ISupplierRepository
{
    Task<IEnumerable<Supplier>> GetAllSupplier();
    Task<Supplier> GetSupplierById(int id);
    Task<Supplier> GetSupplierByName(string Name);
    Task<Supplier> GetSupplierByEmail(string Email);
    Task<IEnumerable<Supplier>> GetSupplierByCountry(Supplier Address,string Country);
    Task<IEnumerable<Supplier>> GetSupplierByCountryAndState(Supplier Address, string Country,string State);
    Task<IEnumerable<Supplier>> GetSupplierByCountryAndStateAndCity(Supplier Address,string Country,string State, string City);
    Task<IEnumerable<Supplier>> GetSupplierByCountryAndCity(Supplier Address, string Country, string City);
    Task<IEnumerable<Supplier>> GetSupplierByRating(double Rating);
    Task<IEnumerable<Supplier>> GetSupplierByMinRatingAndAbove(double MinRating);
    Task<IEnumerable<Supplier>> GetSupplierByRatingRange(double DownRating,double UpRating);
    Task<Supplier> CreateSupplierOperation(Supplier supplier);
    Task<Supplier> UpdateSupplierOperation(int id, Supplier supplier);
    Task<Supplier> ChangeSupplierVisibility(Supplier supplier);




}