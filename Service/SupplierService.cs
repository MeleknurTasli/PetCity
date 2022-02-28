using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

public class SupplierService : ISupplierService
{

    private readonly ISupplierRepository _supplierRepository;

    public SupplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    async Task<Supplier> ISupplierService.CreateSupplierOperation(Supplier supplier)
    {
        var sp_id = await _supplierRepository.GetSupplierById(supplier.Id);
        var sp_name = await _supplierRepository.GetSupplierByName(supplier.Name);
        if(sp_id == null && sp_name == null)
        {
            return await _supplierRepository.CreateSupplierOperation(supplier);
        }
        return null;
    }

    async Task<Supplier> ISupplierService.DeleteSupplierOperation(int id)
    {
        var supplier = await _supplierRepository.GetSupplierById(id);
        if(supplier != null){
            return await _supplierRepository.ChangeSupplierVisibility(id);
        }
        return null;
    }

    async Task<IEnumerable<Supplier>> ISupplierService.GetAllSupplier()
    {
        var suppliers = await _supplierRepository.GetAllSupplier();
        if(suppliers != null)
        {
            return suppliers;
        }
        return null;
    }

    async Task<Supplier> ISupplierService.GetSupplierById(int id)
    {
        var supplier = await _supplierRepository.GetSupplierById(id);
        if(supplier != null)
        {
            return supplier;
        }
        return null;
    }

    async Task<Supplier> ISupplierService.GetSupplierByName(string name)
    {
        var supplier = await _supplierRepository.GetSupplierByName(name);
        if(supplier != null)
        {
            return supplier;
        }
        return null;
    }

    async Task<Supplier> ISupplierService.UpdateSupplierOperation(int id, Supplier supplier)
    {
        var sp = await _supplierRepository.GetSupplierById(id);
        if(sp!=null && sp.Id == supplier.Id){
            return await _supplierRepository.UpdateSupplierOperation(supplier);
        }
        return null;
    }
}