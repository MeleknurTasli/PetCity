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
        try
        {
            Supplier sp = await _context.Suppliers.FindAsync(id);
            sp.IsVisibility = !sp.IsVisibility;

            await _context.SaveChangesAsync();

            return sp;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<Supplier> ISupplierRepository.CreateSupplierOperation(SupplierDTO supplier)
    {
        try
        {
            Supplier persistSupplier = new Supplier(supplier);
            
            _context.Set<Supplier>().Add(persistSupplier);
            await _context.SaveChangesAsync();
            return persistSupplier;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetAllSupplier()
    {
        try
        {
            List<Supplier> temp = await (from db in _context.Suppliers select db).ToListAsync();
            return temp;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<Supplier> ISupplierRepository.GetSupplierByEmail(string email)
    {
        try
        {
            Supplier? supplier = await (from sp in _context.Suppliers
                                        where sp.Account.Email == email
                                        select sp).FirstOrDefaultAsync();
            if (supplier != null)
            {
                return supplier;
            }
            return null;


        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<Supplier> ISupplierRepository.GetSupplierById(int id)
    {
        try
        {
            Supplier? supplier = await _context.Suppliers!.FindAsync(id);
            if (supplier != null)
            {
                return supplier;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByMinRatingAndAbove(double MinRating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where item.Rating >= MinRating
                                           select item ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<Supplier> ISupplierRepository.GetSupplierByName(string Name)
    {
        string name="";
        string[] temp = Name.Split('-');
        for(int i=0;i<temp.Length;i++)
        {
            name+=temp[i];
            if(i<temp.Length-1)
                name+=" ";
        }
        try
        {
            Supplier? supplier = await (from sp in _context.Suppliers
                                        where sp.Name == name
                                        select sp).FirstOrDefaultAsync();
            if (supplier != null)
            {
                return supplier;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRating(double Rating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where item.Rating == Rating
                                           select item ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRatingRange(double DownRating, double UpRating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where (item.Rating >= DownRating && item.Rating <= UpRating)
                                           select item ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return null;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    async Task<Supplier> ISupplierRepository.UpdateSupplierOperation(int id, SupplierDTO supplier)
    {
        try
        {
            var sp = await _context.Suppliers.FindAsync(id);
            sp.Name = supplier.Name;
            sp.Account = supplier.Account;
            sp.Address = supplier.Address;
            sp.Brand = supplier.Brand;
            sp.Rating = supplier.Rating;
            sp.IsVisibility = supplier.IsVisibility;

            await _context.SaveChangesAsync();
            return sp;
        }
        catch (Exception ex)
        {
            return null;
        }


        

    }
}