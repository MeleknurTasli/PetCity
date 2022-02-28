using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;





public class SupplierRepository : ISupplierRepository
{
    private readonly PetCityContext _context;

    public SupplierRepository(PetCityContext context)
    {
        _context = context;
    }
    Task<Supplier> ISupplierRepository.ChangeSupplierVisibility(Supplier supplier)
    {
        throw new NotImplementedException();
    }

    async Task<Supplier> ISupplierRepository.CreateSupplierOperation(Supplier supplier)
    {
        _context.Suppliers.Add(supplier);
        await _context.SaveChangesAsync();
        return supplier;
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetAllSupplier()
    {
        return await _context.Suppliers!.ToListAsync();        
    }

    Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByCountry(Supplier Address, string Country)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByCountryAndCity(Supplier Address, string Country, string City)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByCountryAndState(Supplier Address, string Country, string State)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByCountryAndStateAndCity(Supplier Address, string Country, string State, string City)
    {
        throw new NotImplementedException();
    }

    async Task<Supplier> ISupplierRepository.GetSupplierByEmail(string Email)
    {
        Supplier? supplier = await (from sp in _context.Suppliers
                                where sp.Account.Email == Email
                                select sp).FirstOrDefaultAsync();
        if(supplier != null)
        {
            return supplier;
        }
        return null;  
    }

    async Task<Supplier> ISupplierRepository.GetSupplierById(int id)
    {
        Supplier? supplier = await _context.Suppliers!.FindAsync(id);
        if(supplier != null)
        {
            return supplier;
        }
        return null;   
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByMinRatingAndAbove(double MinRating)
    {
        var SupplierListAsync = await (from item in _context.Suppliers
                                where item.Rating >= MinRating
                                select item).ToListAsync(); 
        if(SupplierListAsync != null) 
        {
            return SupplierListAsync;
        }
        return null;
    }

    async Task<Supplier> ISupplierRepository.GetSupplierByName(string Name)
    {
        Supplier? supplier = await (from sp in _context.Suppliers
                                where sp.Account.Email == Name
                                select sp).FirstOrDefaultAsync();
        if(supplier != null)
        {
            return supplier;
        }
        return null; 
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRating(double Rating)
    {
        var SupplierListAsync = await (from item in _context.Suppliers
                                where item.Rating == Rating
                                select item).ToListAsync(); 
        if(SupplierListAsync != null) 
        {
            return SupplierListAsync;
        }
        return null;
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRatingRange(double DownRating, double UpRating)
    {
        var SupplierListAsync = await (from item in _context.Suppliers
                                where (item.Rating>= DownRating && item.Rating<=UpRating)
                                select item).ToListAsync(); 
        if(SupplierListAsync != null) 
        {
            return SupplierListAsync;
        }
        return null;
    }

    async Task<Supplier> ISupplierRepository.UpdateSupplierOperation(int id, Supplier supplier )
    {
        if(id != supplier.Id){
            return null;
        }
        _context.Entry(supplier).State = EntityState.Modified;
        try{
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            throw;
        }
        return supplier;

    }
}