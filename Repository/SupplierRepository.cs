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

    async Task<SupplierDTO> ISupplierRepository.CreateSupplierOperation(Supplier supplier)
    {
        try
        {
            _context.Set<Supplier>().Add(supplier);
            await _context.SaveChangesAsync();
            return new SupplierDTO(supplier);
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
                                            select new SupplierDTO()
                                            {
                                                Name = db.Name,
                                                Account = db.Account,
                                                Address = db.Address,
                                                Brand = db.Brand,
                                                Rating = db.Rating,
                                                IsVisibility = db.IsVisibility
                                            }).ToListAsync();
            return temp;
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }

    }

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetSupplierByAddress(AddressSearchDTO address)
    {
        IEnumerable<SupplierDTO> supplierDTOs = null;
        if(address.Country != null && address.State == null && address.City == null && address.District == null){
            supplierDTOs = await (from supplier in _context.Suppliers
                                    where supplier.Address.Country.Equals(address.Country)
                                    select new SupplierDTO{
                                        Name = supplier.Name,
                                        Account = supplier.Account,
                                        Address = supplier.Address,
                                        Brand = supplier.Brand,
                                        Rating = supplier.Rating,
                                        IsVisibility = supplier.IsVisibility
                                    }
                                ).ToListAsync();
            return supplierDTOs;
        }
        return new List<SupplierDTO> { new SupplierDTO(null) };
    }

    async Task<SupplierDTO> ISupplierRepository.GetSupplierByEmail(string Email)
    {
        try
        {
            Supplier? supplier = await (from sp in _context.Suppliers
                                        where sp.Account.Email == Email
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
                                           select new SupplierDTO()
                                           {
                                               Name = item.Name,
                                               Account = item.Account,
                                               Address = item.Address,
                                               Brand = item.Brand,
                                               Rating = item.Rating,
                                               IsVisibility = item.IsVisibility
                                           }).ToListAsync();
            if (SupplierListAsync != null)
            {
                return SupplierListAsync;
            }
            return new List<SupplierDTO> { new SupplierDTO(null) }; ;
        }
        catch (Exception ex)
        {
            return new List<SupplierDTO> { new SupplierDTO(null) };
        }

    }

    async Task<SupplierDTO> ISupplierRepository.GetSupplierByName(string Name)
    {
        try
        {
            Supplier? supplier = await (from sp in _context.Suppliers
                                        where sp.Name == Name
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

    async Task<IEnumerable<SupplierDTO>> ISupplierRepository.GetSupplierByRating(double Rating)
    {
        try
        {
            var SupplierListAsync = await (from item in _context.Suppliers
                                           where item.Rating == Rating
                                           select new SupplierDTO()
                                           {
                                               Name = item.Name,
                                               Account = item.Account,
                                               Address = item.Address,
                                               Brand = item.Brand,
                                               Rating = item.Rating,
                                               IsVisibility = item.IsVisibility
                                           }).ToListAsync();
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
                                           select new SupplierDTO()
                                           {
                                               Name = item.Name,
                                               Account = item.Account,
                                               Address = item.Address,
                                               Brand = item.Brand,
                                               Rating = item.Rating,
                                               IsVisibility = item.IsVisibility
                                           }).ToListAsync();
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