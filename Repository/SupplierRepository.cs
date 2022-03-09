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
        Supplier? DeleteSupplier = await (from supplier in _context.Suppliers
                                          join address in _context.Address on supplier.AddressId equals address.Id
                                          join country in _context.Country on address.CountryId equals country.Id
                                          join district in _context.District on address.DistrictId equals district.Id
                                          where supplier.Id == id
                                          select new Supplier()
                                          {
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = new Address
                                              {
                                                  Id = supplier.Address.Id,
                                                  Name = supplier.Address.Name,
                                                  OpenAddress1 = supplier.Address.OpenAddress1,
                                                  OpenAddress2 = supplier.Address.OpenAddress2,
                                                  Country = address.Country,
                                                  State = address.State,
                                                  City = address.City,
                                                  District = address.District
                                              }
                                          }).FirstOrDefaultAsync();

        DeleteSupplier.IsVisibility = false;

        _context.Suppliers.Attach(DeleteSupplier).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return DeleteSupplier;
    }

    async Task<Supplier> ISupplierRepository.CreateSupplierOperation(Supplier supplier)
    {
        _context.Suppliers.Attach(supplier).State = EntityState.Added;
        await _context.SaveChangesAsync();
        return supplier;
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetAllSupplier()
    {

        List<Supplier> AllSupplier = await (from supplier in _context.Suppliers
                                            join address in _context.Address on supplier.AddressId equals address.Id
                                            join country in _context.Country on address.CountryId equals country.Id
                                            join district in _context.District on address.DistrictId equals district.Id
                                            select new Supplier()
                                            {
                                                Id = supplier.Id,
                                                Name = supplier.Name,
                                                Email = supplier.Email,
                                                Rating = supplier.Rating,
                                                IsVisibility = supplier.IsVisibility,
                                                Account = supplier.Account,
                                                Brand = supplier.Brand,
                                                Address = new Address
                                                {
                                                    Id = supplier.Address.Id,
                                                    Name = supplier.Address.Name,
                                                    OpenAddress1 = supplier.Address.OpenAddress1,
                                                    OpenAddress2 = supplier.Address.OpenAddress2,
                                                    Country = address.Country,
                                                    State = address.State,
                                                    City = address.City,
                                                    District = address.District
                                                }
                                            }).ToListAsync();

        return AllSupplier;

    }

    async Task<Supplier> ISupplierRepository.GetSupplierByEmail(string email)
    {
        Supplier? SupplierByEmail = await (from supplier in _context.Suppliers
                                           join address in _context.Address on supplier.AddressId equals address.Id
                                           join country in _context.Country on address.CountryId equals country.Id
                                           join district in _context.District on address.DistrictId equals district.Id
                                           where supplier.Email == email
                                           select new Supplier()
                                           {
                                               Id = supplier.Id,
                                               Name = supplier.Name,
                                               Email = supplier.Email,
                                               Rating = supplier.Rating,
                                               IsVisibility = supplier.IsVisibility,
                                               Account = supplier.Account,
                                               Brand = supplier.Brand,
                                               Address = new Address
                                               {
                                                   Id = supplier.Address.Id,
                                                   Name = supplier.Address.Name,
                                                   OpenAddress1 = supplier.Address.OpenAddress1,
                                                   OpenAddress2 = supplier.Address.OpenAddress2,
                                                   Country = address.Country,
                                                   State = address.State,
                                                   City = address.City,
                                                   District = address.District
                                               }
                                           }).FirstOrDefaultAsync();

        return SupplierByEmail;

    }

    async Task<Supplier> ISupplierRepository.GetSupplierById(int id)
    {
        Supplier? SupplierById = await (from supplier in _context.Suppliers
                                        join address in _context.Address on supplier.AddressId equals address.Id
                                        join country in _context.Country on address.CountryId equals country.Id
                                        join district in _context.District on address.DistrictId equals district.Id
                                        where supplier.Id == id
                                        select new Supplier()
                                        {
                                            Id = supplier.Id,
                                            Name = supplier.Name,
                                            Email = supplier.Email,
                                            Rating = supplier.Rating,
                                            IsVisibility = supplier.IsVisibility,
                                            Account = supplier.Account,
                                            Brand = supplier.Brand,
                                            Address = new Address
                                            {
                                                Id = supplier.Address.Id,
                                                Name = supplier.Address.Name,
                                                OpenAddress1 = supplier.Address.OpenAddress1,
                                                OpenAddress2 = supplier.Address.OpenAddress2,
                                                Country = address.Country,
                                                State = address.State,
                                                City = address.City,
                                                District = address.District
                                            }
                                        }).FirstOrDefaultAsync();
        return SupplierById;


    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByMinRatingAndAbove(double MinRating)
    {
        IEnumerable<Supplier> SuppliersByMinRating = await (from supplier in _context.Suppliers
                                                            join address in _context.Address on supplier.AddressId equals address.Id
                                                            join country in _context.Country on address.CountryId equals country.Id
                                                            join district in _context.District on address.DistrictId equals district.Id
                                                            where supplier.Rating >= MinRating
                                                            select new Supplier()
                                                            {
                                                                Id = supplier.Id,
                                                                Name = supplier.Name,
                                                                Email = supplier.Email,
                                                                Rating = supplier.Rating,
                                                                IsVisibility = supplier.IsVisibility,
                                                                Account = supplier.Account,
                                                                Brand = supplier.Brand,
                                                                Address = new Address
                                                                {
                                                                    Id = supplier.Address.Id,
                                                                    Name = supplier.Address.Name,
                                                                    OpenAddress1 = supplier.Address.OpenAddress1,
                                                                    OpenAddress2 = supplier.Address.OpenAddress2,
                                                                    Country = address.Country,
                                                                    State = address.State,
                                                                    City = address.City,
                                                                    District = address.District
                                                                }
                                                            }).ToListAsync();
        return SuppliersByMinRating;
    }

    async Task<Supplier> ISupplierRepository.GetSupplierByName(string Name)
    {
        Supplier? SupplierByName = await (from supplier in _context.Suppliers
                                          join address in _context.Address on supplier.AddressId equals address.Id
                                          join country in _context.Country on address.CountryId equals country.Id
                                          join district in _context.District on address.DistrictId equals district.Id
                                          where supplier.Name == Name
                                          select new Supplier()
                                          {
                                              Id = supplier.Id,
                                              Name = supplier.Name,
                                              Email = supplier.Email,
                                              Rating = supplier.Rating,
                                              IsVisibility = supplier.IsVisibility,
                                              Account = supplier.Account,
                                              Brand = supplier.Brand,
                                              Address = new Address
                                              {
                                                  Id = supplier.Address.Id,
                                                  Name = supplier.Address.Name,
                                                  OpenAddress1 = supplier.Address.OpenAddress1,
                                                  OpenAddress2 = supplier.Address.OpenAddress2,
                                                  Country = address.Country,
                                                  State = address.State,
                                                  City = address.City,
                                                  District = address.District
                                              }
                                          }).FirstOrDefaultAsync();
        return SupplierByName;

    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRating(double Rating)
    {
        IEnumerable<Supplier> SuppliersByRating = await (from supplier in _context.Suppliers
                                                         join address in _context.Address on supplier.AddressId equals address.Id
                                                         join country in _context.Country on address.CountryId equals country.Id
                                                         join district in _context.District on address.DistrictId equals district.Id
                                                         where supplier.Rating == Rating
                                                         select new Supplier()
                                                         {
                                                             Id = supplier.Id,
                                                             Name = supplier.Name,
                                                             Email = supplier.Email,
                                                             Rating = supplier.Rating,
                                                             IsVisibility = supplier.IsVisibility,
                                                             Account = supplier.Account,
                                                             Brand = supplier.Brand,
                                                             Address = new Address
                                                             {
                                                                 Id = supplier.Address.Id,
                                                                 Name = supplier.Address.Name,
                                                                 OpenAddress1 = supplier.Address.OpenAddress1,
                                                                 OpenAddress2 = supplier.Address.OpenAddress2,
                                                                 Country = address.Country,
                                                                 State = address.State,
                                                                 City = address.City,
                                                                 District = address.District
                                                             }
                                                         }).ToListAsync();

        return SuppliersByRating;
    }

    async Task<IEnumerable<Supplier>> ISupplierRepository.GetSupplierByRatingRange(double DownRating, double UpRating)
    {
        IEnumerable<Supplier> SuppliersByRatingRange = await (from supplier in _context.Suppliers
                                                              join address in _context.Address on supplier.AddressId equals address.Id
                                                              join country in _context.Country on address.CountryId equals country.Id
                                                              join district in _context.District on address.DistrictId equals district.Id
                                                              where supplier.Rating >= DownRating && supplier.Rating <= UpRating
                                                              select new Supplier()
                                                              {
                                                                  Id = supplier.Id,
                                                                  Name = supplier.Name,
                                                                  Email = supplier.Email,
                                                                  Rating = supplier.Rating,
                                                                  IsVisibility = supplier.IsVisibility,
                                                                  Account = supplier.Account,
                                                                  Brand = supplier.Brand,
                                                                  Address = new Address
                                                                  {
                                                                      Id = supplier.Address.Id,
                                                                      Name = supplier.Address.Name,
                                                                      OpenAddress1 = supplier.Address.OpenAddress1,
                                                                      OpenAddress2 = supplier.Address.OpenAddress2,
                                                                      Country = address.Country,
                                                                      State = address.State,
                                                                      City = address.City,
                                                                      District = address.District
                                                                  }
                                                              }).ToListAsync();
        return SuppliersByRatingRange;
    }

    async Task<Supplier> ISupplierRepository.UpdateSupplierOperation(int id, Supplier supplier)
    {
        Supplier? sp = await (from supp in _context.Suppliers
                              where supp.Id == id
                              select new Supplier()
                              {
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
}