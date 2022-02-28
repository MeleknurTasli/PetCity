
public interface ISupplierRepository
{
    Task<IEnumerable<Supplier>> GetAllSupplier();
    Task<Supplier> GetSupplierById(int id);
    Task<Supplier> GetSupplierByName(string Name);
    Task<Supplier> GetSupplierByEmail(string Email);
    Task<IEnumerable<Supplier>> GetSupplierByAddress(AddressSearchDTO addressSearch);
    Task<IEnumerable<Supplier>> GetSupplierByRating(double Rating);
    Task<IEnumerable<Supplier>> GetSupplierByMinRatingAndAbove(double MinRating);
    Task<IEnumerable<Supplier>> GetSupplierByRatingRange(double DownRating,double UpRating);
    Task<Supplier> CreateSupplierOperation(Supplier supplier);
    Task<Supplier> UpdateSupplierOperation(Supplier supplier);
    Task<Supplier> ChangeSupplierVisibility(int id);




}