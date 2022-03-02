using Microsoft.AspNetCore.Mvc;

public interface ISupplierService
{
    Task<IEnumerable<SupplierDTO>> GetAllSupplier();
    Task<SupplierDTO> GetSupplierById(int id);
    Task<SupplierDTO> GetSupplierByName(string name);
    Task<SupplierDTO> GetSupplierByEmail(string email);
    Task<IEnumerable<SupplierDTO>> GetSupplierByAddress(AddressSearchDTO address);

    Task<SupplierDTO> CreateSupplierOperation(Supplier supplier);
    Task<SupplierDTO> UpdateSupplierOperation(int id, SupplierDTO supplier);
    Task<SupplierDTO> DeleteSupplierOperation(int id);

}