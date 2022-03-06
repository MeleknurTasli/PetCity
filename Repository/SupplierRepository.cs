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
            Supplier? sp = await (from supp in _context.Suppliers
                                        where supp.Id == id
                                        select new Supplier(){
                                              Id = supp.Id,
                                              Name = supp.Name,
                                              Email = supp.Email,
                                              Rating = supp.Rating,
                                              IsVisibility = supp.IsVisibility,                                                                                                        
                                          }).FirstOrDefaultAsync();
            sp.IsVisibility = !sp.IsVisibility;

            _context.Suppliers.Attach(sp).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return sp;
        }
        catch (Exception ex)
        {
            return null;
        }

    }

    async Task<Supplier> ISupplierRepository.CreateSupplierOperation(Supplier supplier)
    {
        try
        {            
            _context.Suppliers.Attach(supplier).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return supplier;
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
            List<Supplier> temp = await ( from supplier in _context.Suppliers                                                                           
                                          select new Supplier(){
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = supplier.Address                                                                                                           
                                          }
                                        ).ToListAsync();
            //ToDo guncellenicek
            /*List<Supplier> temp2 = await ( from sp in temp where 

                                        );*/
            
            
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
            Supplier? supplier = await (from supp in _context.Suppliers
                                        where supp.Email == email
                                        select new Supplier(){
                                              Id = supp.Id,
                                              Name = supp.Name,
                                              Email = supp.Email,
                                              Rating = supp.Rating,
                                              IsVisibility = supp.IsVisibility,
                                              Account = supp.Account,
                                              Brand = supp.Brand,
                                              Address = supp.Address                                                                                                           
                                          }).FirstOrDefaultAsync();
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
            Supplier? supplier = await (from supp in _context.Suppliers
                                        where supp.Id == id
                                        select new Supplier(){
                                              Id = supp.Id,
                                              Name = supp.Name,
                                              Email = supp.Email,
                                              Rating = supp.Rating,
                                              IsVisibility = supp.IsVisibility,
                                              Account = supp.Account,
                                              Brand = supp.Brand,
                                              Address = supp.Address                                                                                                           
                                          }).FirstOrDefaultAsync();
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
            var SupplierListAsync = await (from supplier in _context.Suppliers
                                           where supplier.Rating >= MinRating
                                           select new Supplier(){
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = supplier.Address                                                                                                           
                                          }
                                        ).ToListAsync();
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
            Supplier? supplier = await (from supp in _context.Suppliers
                                        where supp.Name == name
                                        select new Supplier(){
                                              Id = supp.Id,
                                              Name = supp.Name,
                                              Email = supp.Email,
                                              Rating = supp.Rating,
                                              IsVisibility = supp.IsVisibility,
                                              Account = supp.Account,
                                              Brand = supp.Brand,
                                              Address = supp.Address                                                                                                           
                                          }).FirstOrDefaultAsync();
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
            var SupplierListAsync = await (from supplier in _context.Suppliers
                                           where supplier.Rating == Rating
                                           select new Supplier(){
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = supplier.Address                                                                                                           
                                          }
                                        ).ToListAsync();
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
            var SupplierListAsync = await (from supplier in _context.Suppliers
                                           where (supplier.Rating >= DownRating && supplier.Rating <= UpRating)
                                           select new Supplier(){
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = supplier.Address                                                                                                           
                                          }
                                        ).ToListAsync();
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

    async Task<Supplier> ISupplierRepository.UpdateSupplierOperation(int id, Supplier supplier)
    {
        try
        {
            Supplier? sp = await (from supp in _context.Suppliers
                                        where supp.Id == id
                                        select new Supplier(){
                                              Id = supp.Id,
                                              Name = supp.Name,
                                              Email = supp.Email,
                                              Rating = supp.Rating,
                                              IsVisibility = supp.IsVisibility,
                                              Account = supp.Account,
                                              Brand = supp.Brand,
                                              Address = supp.Address                                                                                                        
                                          }).FirstOrDefaultAsync();
            
            sp.Name = supplier.Name;
            sp.Email = supplier.Email;
            sp.Rating = supplier.Rating;
            sp.IsVisibility = supplier.IsVisibility;

            _context.Suppliers.Attach(sp).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return sp;
        }
        catch (Exception ex)
        {
            return null;
        }
        

    }
}