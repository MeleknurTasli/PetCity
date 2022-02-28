using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class SupplierController : ControllerBase 
{
    private readonly ISupplierService _supplierService;

    public SupplierController(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }

    [HttpGet]
    public async Task<IEnumerable<Supplier>> GetAllSupplier()
    {         
        return await _supplierService.GetAllSupplier();
    }

    //https://localhost:7278/Supplier/id?id=1
    [HttpGet("id")]
    public async Task<Supplier> GetSupplierById(int id)
    {
        return await _supplierService.GetSupplierById(id);
    }

    [HttpGet("name")]
    public async Task<Supplier> GetSupplierByName(string name)
    {
        return await _supplierService.GetSupplierByName(name);
    }

    [HttpPost]
    public async Task<Supplier> CreateSupplierOperation(Supplier supplier)
    {
        return await _supplierService.CreateSupplierOperation(supplier);
    }

    //https://localhost:7278/Supplier/1
    [HttpPut("{id}")]
    public async Task<Supplier> UpdateSupplierOperation(int id, Supplier supplier)
    {
        return await _supplierService.UpdateSupplierOperation(id,supplier);
    }
    
    [HttpDelete("{id}")]
    public async Task<Supplier> DeleteSupplierOperation(int id)
    {
        return await _supplierService.DeleteSupplierOperation(id);
    }
}