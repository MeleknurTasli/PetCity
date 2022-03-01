using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SupplierRepository : ISupplierRepository
{
    private readonly PetCityContext _context;

    public SupplierRepository(PetCityContext context)
    {
        _context = context;
    }
    async Task<Supplier> ISupplierRepository.ChangeSupplierVisibility(int id)
    {
        var sp = await _context.Suppliers.FindAsync(id);        
        sp.IsVisibility = false;
        await _context.SaveChangesAsync();
        
        return sp;
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

    Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByAddress(AddressSearchDTO addressSearch)
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

    async Task<Supplier> ISupplierRepository.UpdateSupplierOperation(Supplier supplier )
    {
        /*
       _context.Entry(supplier).State = EntityState.Modified;
        try{
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            throw;
        }
        */
      
        var sp = await _context.Suppliers.FindAsync(supplier.Id);

        sp.Name = supplier.Name;
        sp.Account = supplier.Account;
        sp.Address = supplier.Address;
        sp.Brand = supplier.Brand;
        sp.Rating = supplier.Rating;
        sp.IsVisibility = supplier.IsVisibility;

        await _context.SaveChangesAsync();

        return supplier;

    }
}