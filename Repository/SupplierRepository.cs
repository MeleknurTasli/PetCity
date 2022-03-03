using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SupplierRepository : ISupplierRepository
{
    private readonly PetCityContext _context;

    public SupplierRepository(PetCityContext context)
    {
        _context = context;
    }
    async Task<SupplierDTO> ISupplierRepository.ChangeSupplierVisibility(int id)
    {
        try
        {
            Supplier sp = await _context.Suppliers.FindAsync(id);
            sp.IsVisibility = false;

            await _context.SaveChangesAsync();

            return new SupplierDTO(sp);
        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }

    }

    async Task<SupplierDTO> ISupplierRepository.CreateSupplierOperation(SupplierDTO supplier)
    {
        try
        {
            Supplier persistSupplier = new Supplier(supplier);
            
            _context.Set<Supplier>().Add(persistSupplier);
            await _context.SaveChangesAsync();
            return supplier;
        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }

    }

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetAllSupplier()
    {
        try
        {
            List<SupplierDTO> temp = await (from db in _context.Suppliers
                                            select new SupplierDTO(db.Name,db.Account,db.Address,db.Brand,db.Rating,db.IsVisibility)
                                            ).ToListAsync();
            return temp;
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }

    }

    async Task<SupplierDTO> ISupplierRepository.GetSupplierByEmail(string email)
    {
        try
        {
            Supplier? supplier = await (from sp in _context.Suppliers
                                        where sp.Account.Email == email
                                        select sp).FirstOrDefaultAsync();
            if (supplier != null)
            {
                return new SupplierDTO(supplier);
            }
            return new SupplierDTO(null);


        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }

    }

    async Task<SupplierDTO> ISupplierRepository.GetSupplierById(int id)
    {
        try
        {
            Supplier? supplier = await _context.Suppliers!.FindAsync(id);
            if (supplier != null)
            {
                return new SupplierDTO(supplier);
            }
            return new SupplierDTO(null);
        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }

    }

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetSupplierByMinRatingAndAbove(double MinRating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where item.Rating >= MinRating
                                           select new SupplierDTO(item.Name,item.Account,item.Address,item.Brand,item.Rating,item.IsVisibility)
                                           ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }

    }

    async Task<SupplierDTO> ISupplierRepository.GetSupplierByName(string Name)
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
                return new SupplierDTO(supplier);
            }
            return null;
        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }

    }

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetSupplierByRating(double Rating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where item.Rating == Rating
                                           select new SupplierDTO(item.Name,item.Account,item.Address,item.Brand,item.Rating,item.IsVisibility)
                                           ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }
    }

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetSupplierByRatingRange(double DownRating, double UpRating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where (item.Rating >= DownRating && item.Rating <= UpRating)
                                           select new SupplierDTO(item.Name,item.Account,item.Address,item.Brand,item.Rating,item.IsVisibility)
                                           ).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }
    }

    async Task<SupplierDTO> ISupplierRepository.UpdateSupplierOperation(int id, SupplierDTO supplier)
    {
        /*
       _context.Entry(supplier).State = EntityState.Modified;
        try{
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            throw;
        }
        */
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
        }
        catch (Exception ex)
        {
            return new SupplierDTO(null);
        }


        return supplier;

    }
}