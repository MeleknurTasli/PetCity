using Microsoft.AspNetCore.Mvc;

public interface ISupplierService
{
    Task<IEnumerable<Supplier>> GetAllSupplier();
    Task<Supplier> GetSupplierById(int id);
    Task<Supplier> GetSupplierByName(string name);

    Task<Supplier> CreateSupplierOperation(Supplier supplier);
    Task<Supplier> UpdateSupplierOperation(int id, Supplier supplier);
    Task<Supplier> DeleteSupplierOperation(int id);

}