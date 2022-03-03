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

    //http://localhost:5281/Supplier
    [HttpGet]
    public async Task<IEnumerable<SupplierDTO>> GetAllSupplier()
    {         
        return await _supplierService.GetAllSupplier();
    }

    //http://localhost:5281/Supplier/1
    [HttpGet("{id}")]
    public async Task<SupplierDTO> GetSupplierById(int id)
    {
        return await _supplierService.GetSupplierById(id);
    }

    //http://localhost:5281/Supplier/name?name=KocHolding
    [HttpGet("name")]
    public async Task<SupplierDTO> GetSupplierByName(string name)
    {
        return await _supplierService.GetSupplierByName(name);
    }

    //http://localhost:5281/Supplier/email?email=kocholding@gmail.com
    [HttpGet("email")]
    public async Task<SupplierDTO> GetSupplierByEmail(string email)
    {
        return await _supplierService.GetSupplierByEmail(email);
    }

    //http://localhost:5281/Supplier/rating?rating=5.1
    [HttpGet("rating")]
    public async Task<IEnumerable<SupplierDTO>> GetSupplierByRating(string Rating)
    {
        return await _supplierService.GetSupplierByRating(Rating);
    }

    //http://localhost:5281/Supplier/MinRating?minrating=5.4
    [HttpGet("minrating")]
    public async Task<IEnumerable<SupplierDTO>> GetSupplierByMinRatingAndAbove(string MinRating)
    {
        return await _supplierService.GetSupplierByMinRatingAndAbove(MinRating);
    }

    //http://localhost:5281/Supplier/ratingrange?DownRating=6.4&UpRating=8.8
    [HttpGet("ratingrange")]
    public async Task<IEnumerable<SupplierDTO>> GetSupplierByRatingRange(string DownRating, string UpRating)
    {
        return await _supplierService.GetSupplierByRatingRange(DownRating,UpRating);
    }

    //http://localhost:5281/Supplier
    [HttpPost]
    public async Task<SupplierDTO> CreateSupplierOperation(SupplierDTO supplier)
    {
        return await _supplierService.CreateSupplierOperation(supplier);
    }

    //http://localhost:5281/Supplier/1
    [HttpPut("{id}")]
    public async Task<SupplierDTO> UpdateSupplierOperation(int id, SupplierDTO supplier)
    {
        return await _supplierService.UpdateSupplierOperation(id,supplier);
    }
    
    //http://localhost:5281/Supplier/1
    [HttpDelete("{id}")]
    public async Task<SupplierDTO> DeleteSupplierOperation(int id)
    {
        return await _supplierService.DeleteSupplierOperation(id);
    }
}