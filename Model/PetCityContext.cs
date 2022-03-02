public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Incidence>? Incidences { get; set; }
    public DbSet<User>? Users { get; set; } 
    public DbSet<Region>? Regions { get; set; } 
    public DbSet<Pet>? Pets { get; set; }
    public DbSet<PetSpecies>? PetSpecies { get; set; }
    public DbSet<PetGender>? PetGenders { get; set; }
    public DbSet<PetSubSpecies>? PetSubSpecies { get; set; }
    public DbSet<Account>? Account { get; set; }

    public DbSet<Address>? Address { get; set; }
    public DbSet<Country>? Country { get; set; }
    public DbSet<City>? City { get; set; }

    public DbSet<Neighborhood>? Neighborhood { get; set; }
    public DbSet<State>? State { get; set; }
    public DbSet<Street>? Street { get; set; }

    public DbSet<Supplier>? Suppliers {get; set;}







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
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.Category).WithMany(c => c!.Products).HasForeignKey(p=>p.CategoryId);
            entity.HasOne(b => b.Brand).WithMany(c => c!.Products).HasForeignKey(b=>b.BrandId);
            entity.HasOne(c => c.Company).WithMany(c => c!.Products).HasForeignKey(c=>c.CompanyId);
        });
        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.HasOne(e=>e.Account);
            entity.HasOne(e=>e.Address);
            entity.HasMany(e=>e.Brand).WithMany(p=>p.Suppliers).UsingEntity(j=>j.ToTable("SupplierBrand"));
            entity.Property(e=>e.Rating);            
            
        });

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Cat Food"
            },
            new Category
            {
                Id = 2,
                Name = "Dog Food"
            }
        );
        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = 1,
                Name = "BlaBla Sirketi"
            },
            new Company
            {
                Id = 2,
                Name = "BlaBlaBla Sirketi"
            }
        );
        modelBuilder.Entity<Brand>().HasData(
        new Brand
        {
            Id = 1,
            Name = "Pro Plan"
        },
        new Brand
        {
            Id = 2,
            Name = "Pro Line"
        }
    );
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Pro Plan Active",
                UnitPrice = 15,
                UnitsInStock = 10,
                BrandId = 1,
                CategoryId = 1,
                CompanyId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Pro Line Active",
                UnitPrice = 10,
                UnitsInStock = 15,
                BrandId = 2,
                CategoryId = 2,
                CompanyId = 2
            }
        );

        modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = 1,
                    Name = "Koc Holding",
                    Account = null,
                    Address = null,
                    Brand = null,
                    Rating = 5.1
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Sabanci Holding",
                    Account = null,
                    Address = null,
                    Brand = null,
                    Rating = 5.5
                },
                new Supplier
                {
                    Id = 3,
                    Name = "Zorlu Holding",
                    Account = null,
                    Address = null,
                    Brand = null,
                    Rating = 5.7
                },
                new Supplier
                {
                    Id = 4,
                    Name = "Dogan Holding",
                    Account = null,
                    Address = null,
                    Brand = null,
                    Rating = 5.5
                },
                new Supplier
                {
                    Id = 5,
                    Name = "Kamci Holding",
                    Account = null,
                    Address = null,
                    Brand = null,
                    Rating = 8.1
                });

            
       modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e=>e.Id);
            entity.Property(e=> e.Name);
        });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e=>e.Id);
            entity.Property(e=> e.Name);
        });
         modelBuilder.Entity<Incidence>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.Region).WithMany(c => c!.IncidenceList).HasForeignKey(c => c.RegionId);
            entity.HasOne(b => b.User).WithMany(c => c!.IncidenceList).HasForeignKey(c => c.UserId);
            entity.Property(e=>e.Visibility);
            entity.Property(e=>e.UserId);
            entity.Property(e=>e.RegionId);
            entity.Property(e=>e.Description);
            entity.Property(e=>e.Image);
        });
        modelBuilder.Entity<Incidence>().HasData(
            new Incidence{
                Id=1,
                Name="Kedi ac",
                Visibility=true,
                UserId = 1,
                RegionId = 1,
                Description = "kedi çok aç"
            },
            new Incidence{
                Id=2,
                Name="Kopek ac",
                Visibility=true ,
                UserId = 1,
                RegionId = 1 ,
                Description = "köpek çok aç"  
            }
        );
        modelBuilder.Entity<Region>().HasData(
            new Region{
                Id=1,
                Name="region1"
            });
        modelBuilder.Entity<User>().HasData(
            new User{
                Id=1,
                Name="melek"
            });    



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





        modelBuilder.Entity<Role>().HasData(
           new Role
           {
               Id = 1,
               Name = "admin"

           },
           new Role
           {
               Id = 2,
               Name = "moderator"

           }
       );

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Password).IsRequired();
            entity.Property(e => e.IsBlocked);
            entity.Property(e => e.Visibility);
            entity.HasMany(e => e.Role).WithMany(e => e.Account).UsingEntity(j => j.ToTable("Account_Role"));

        });



        modelBuilder.Entity<Role>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Name).IsRequired();
       });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<PetSpecies>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();

        });

        modelBuilder.Entity<PetSubSpecies>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<PetGender>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<PetHealthStatus>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        modelBuilder.Entity<Account>().HasData(
           new Account
           {
               Id = 1,
               Email = "meryem.dogan@sahabt.com",
               Password = "123123",
               IsBlocked = true,
               Visibility = true
           },
           new Account
           {
               Id = 2,
               Email = "galipcan.karaaslan@sahabt.com",
               Password = "555555",
               IsBlocked = true,
               Visibility = true
           }
       );

    }
}