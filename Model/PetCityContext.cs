public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Incidence>? Incidences { get; set; }
    public DbSet<User>? Users { get; set; } 
    public DbSet<Region>? Regions { get; set; } 
    public DbSet<Supplier>? Suppliers{get;set;} 
    public DbSet<Account>? Account { get; set; }

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
            entity.Property(ahmetAmca => ahmetAmca.TestPropInt);
            entity.Property(ahmetAmca => ahmetAmca.TestPropString);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.Category).WithMany(c => c!.Products);
            entity.HasOne(b => b.Brand).WithMany(c => c!.Products);
            entity.HasOne(c => c.Company)
            .WithMany(c => c!.Products);
        });
        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.HasMany(e=>e.Brand).WithMany(p=>p.Suppliers).UsingEntity(j=>j.ToTable("SupplierBrand"));
            entity.Property(e=>e.Rating);            
            
        });

        modelBuilder.Entity<Account>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Email).IsRequired();
           entity.Property(e => e.Password).IsRequired();
           entity.Property(e => e.IsBlocked).IsRequired();
           entity.Property(e => e.Visibility).IsRequired();
           entity.HasMany(e => e.Role).WithMany(e => e.Account).UsingEntity(j => j.ToTable("Account_Role"));

       });



        modelBuilder.Entity<Role>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Name).IsRequired();
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
                    Brand = null,
                    Rating = 5.1
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Sabanci Holding",
                    Brand = null,
                    Rating = 5.5
                },
                new Supplier
                {
                    Id = 3,
                    Name = "Zorlu Holding",
                    Brand = null,
                    Rating = 5.7
                },
                new Supplier
                {
                    Id = 4,
                    Name = "Dogan Holding",
                    Brand = null,
                    Rating = 5.5
                },
                new Supplier
                {
                    Id = 5,
                    Name = "Kamci Holding",
                    Brand = null,
                    Rating = 8.1
                }

            );


       
       modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e=>e.Id);
            entity.Property(e=> e.Name);
        });
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e=>e.Id);
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
        });
        modelBuilder.Entity<Incidence>().HasData(
            new Incidence{
                Id=1,
                Name="Kedi ac",
                Visibility=true,
                UserId = 1,
                RegionId = 1
            },
            new Incidence{
                Id=2,
                Name="Kopek ac",
                Visibility=true ,
                UserId = 1,
                RegionId = 1      
            }
        );
        modelBuilder.Entity<Region>().HasData(
            new Region{
                Id=1,
                Name="r1"
            });
        modelBuilder.Entity<User>().HasData(
            new User{
                Id=1
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
    }
}