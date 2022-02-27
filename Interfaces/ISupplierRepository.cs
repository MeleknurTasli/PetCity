
public interface ISupplierRepository
{
    IEnumerable<Supplier> GetAllSupplier();
    Supplier GetSupplierById(int id);
    Supplier GetSupplierByName(string Name);
    Supplier GetSupplierByEmail(string Email);
    IEnumerable<Supplier> GetSupplierByCountry(string Country);
    IEnumerable<Supplier> GetSupplierByCountryAndState(string Country,string State);
    IEnumerable<Supplier> GetSupplierByCountryAndStateAndCity(string Country,string State, string City);
    IEnumerable<Supplier> GetSupplierByCountryAndCity(string Country, string City);
    IEnumerable<Supplier> GetSupplierByRating();
    IEnumerable<Supplier> GetSupplierByRating(double Rating);
    IEnumerable<Supplier> GetSupplierByMinRatingAndAbove(double MinRating);
    IEnumerable<Supplier> GetSupplierByRatingRange(double UpRating,double DownRating);
    void CreateSupplierOperation(Supplier supplier);
    void UpdateSupplierOperation(int id, Supplier supplier);
    void ChangeSupplierVisibility(Supplier supplier);




}