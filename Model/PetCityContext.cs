public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }
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