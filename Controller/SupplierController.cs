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

    //https://localhost:7278/Supplier
    [HttpGet]
    public async Task<IEnumerable<SupplierDTO>> GetAllSupplier()
    {         
        return await _supplierService.GetAllSupplier();
    }

    //https://localhost:7278/Supplier/1
    [HttpGet("{id}")]
    public async Task<SupplierDTO> GetSupplierById(int id)
    {
        return await _supplierService.GetSupplierById(id);
    }

    //https://localhost:7278/Supplier/name?name=KocHolding
    [HttpGet("name")]
    public async Task<SupplierDTO> GetSupplierByName(string name)
    {
        return await _supplierService.GetSupplierByName(name);
    }

    //https://localhost:7278/Supplier/email?email=KocHolding
    [HttpGet("email")]
    public async Task<SupplierDTO> GetSupplierByEmail(string email)
    {
        return await _supplierService.GetSupplierByEmail(email);
    }

    [HttpGet("{search}/{id}")]
    public async Task<IEnumerable<SupplierDTO>> GetSupplierByAddress(int id,AddressSearchDTO address)
    {
        return await _supplierService.GetSupplierByAddress(address);
    }
    



    //https://localhost:7278/Supplier
    [HttpPost]
    public async Task<SupplierDTO> CreateSupplierOperation(Supplier supplier)
    {
        return await _supplierService.CreateSupplierOperation(supplier);
    }

    //https://localhost:7278/Supplier/1
    [HttpPut("{id}")]
    public async Task<SupplierDTO> UpdateSupplierOperation(int id, SupplierDTO supplier)
    {
        return await _supplierService.UpdateSupplierOperation(id,supplier);
    }
    
    [HttpDelete("{id}")]
    public async Task<SupplierDTO> DeleteSupplierOperation(int id)
    {
        return await _supplierService.DeleteSupplierOperation(id);
    }
}