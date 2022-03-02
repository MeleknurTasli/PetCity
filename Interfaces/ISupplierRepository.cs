
public interface ISupplierRepository
{
    Task<IEnumerable<SupplierDTO>> GetAllSupplier();
    Task<SupplierDTO> GetSupplierById(int id);
    Task<SupplierDTO> GetSupplierByName(string Name);
    Task<SupplierDTO> GetSupplierByEmail(string Email);
    Task<IEnumerable<SupplierDTO>> GetSupplierByAddress(AddressSearchDTO address);
    Task<IEnumerable<SupplierDTO>> GetSupplierByRating(double Rating);
    Task<IEnumerable<SupplierDTO>> GetSupplierByMinRatingAndAbove(double MinRating);
    Task<IEnumerable<SupplierDTO>> GetSupplierByRatingRange(double DownRating,double UpRating);
    Task<SupplierDTO> CreateSupplierOperation(Supplier supplier);
    Task<SupplierDTO> UpdateSupplierOperation(int id, SupplierDTO supplier);
    Task<SupplierDTO> ChangeSupplierVisibility(int id);




}