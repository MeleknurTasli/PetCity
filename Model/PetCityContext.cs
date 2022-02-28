public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }

    public DbSet<Address>? Address { get; set; }
    public DbSet<Country>? Country { get; set; }
    public DbSet<City>? City { get; set; }

    public DbSet<Neighborhood>? Neighborhood { get; set; }
    public DbSet<State>? State { get; set; }
    public DbSet<Street>? Street { get; set; }







    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

        optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.Category)
            .WithMany(c => c!.Products);
            entity.HasOne(b => b.Brand)
            .WithMany(c => c!.Products);
            entity.HasOne(c => c.Company)
            .WithMany(c => c!.Products);
        });


        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                Name = "Cat Food"
            },
            new Category
            {
                CategoryId = 2,
                Name = "Dog Food"
            }
        );
        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                CompanyId = 1,
                Name = "BlaBla Sirketi"
            },
            new Company
            {
                CompanyId = 2,
                Name = "BlaBlaBla Sirketi"
            }
        );
        modelBuilder.Entity<Brand>().HasData(
        new Brand
        {
            BrandId = 1,
            Name = "Pro Plan"
        },
        new Brand
        {
            BrandId = 2,
            Name = "Pro Line"
        }
    );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Pro Plan Active",
                UnitPrice = 15,
                UnitsInStock = 10,
                BrandId = 1,
                CategoryId = 1,
                CompanyId = 1
            },
            new Product
            {
                ProductId = 2,
                Name = "Pro Line Active",
                UnitPrice = 10,
                UnitsInStock = 15,
                BrandId = 2,
                CategoryId = 2,
                CompanyId = 2
            }
        );





        modelBuilder.Entity<Address>(entity =>
               {
                   entity.HasKey(e => e.AddressId);
                   entity.Property(e => e.AddressName).IsRequired();
                   entity.Property(e => e.OpenAddres1);
                   entity.Property(e => e.OpenAddres2);
                   



               });


        modelBuilder.Entity<City>(entity =>
           {
               entity.HasKey(e => e.CityId);

               entity.Property(e => e.Name).IsRequired();
               entity.Property(e => e.CountryId);
            
               entity.HasOne(b => b.Country)
                     .WithMany(c => c!.City);
                     entity.HasOne(b => b.State)
                     .WithMany(c => c!.City);

           });

        modelBuilder.Entity<Country>(entity =>
       {
           entity.HasKey(e => e.CountryId);

           entity.Property(e => e.CountryName).IsRequired();
           entity.Property(e => e.CountryCode);
           entity.Property(e => e.AddressId);
           entity.HasOne(b => b.Address)
                     .WithMany(c => c!.Country);



       });

        modelBuilder.Entity<District>(entity =>
       {
           entity.HasKey(e => e.DistrictId);

           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.CityId);
           entity.HasOne(b => b.City)
                     .WithMany(c => c!.District);
           

       });

        modelBuilder.Entity<Neighborhood>(entity =>
              {
                  entity.HasKey(e => e.NeighborhoodId);

                  entity.Property(e => e.Name).IsRequired();
                  entity.Property(e => e.DistrictId);
                  entity.HasOne(b => b.District)
                     .WithMany(c => c!.Neighborhood);




              });

        modelBuilder.Entity<State>(entity =>
               {
                   entity.HasKey(e => e.StateId);

                   entity.Property(e => e.Name).IsRequired();
                   entity.Property(e => e.CountryId);
                   entity.HasOne(b => b.Country)
                     .WithMany(c => c!.State);




               });

        modelBuilder.Entity<Street>(entity =>
               {
                   entity.HasKey(e => e.StreetId);

                   entity.Property(e => e.Name).IsRequired();
                   entity.Property(e => e.NeighborhoodId);

                   entity.HasOne(b => b.Neighborhood);
                
               });




    }
}