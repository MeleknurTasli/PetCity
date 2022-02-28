public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Pet>? Pets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseMySQL("server=localhost;database=petcitydb;user=root;port=3306;password=toortoor");

        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));

        optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);

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
                ProductId = 1,
                Name = "Pro Line Active",
                UnitPrice = 10,
                UnitsInStock= 15,
                BrandId =2,
                CategoryId=2,
                CompanyId=2
            }
        );

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
            entity.Property(e => e.PetImageUrl).IsRequired();
            entity.Property(e=> e.HealthStatus).IsRequired();
            
        });

        modelBuilder.Entity<Pet>().HasData(
            new Pet{
                Id = 1,
                Name = "karabaş",
                Age = 2,
                Gender = PetGender.Male,
                HealthStatus = HealthStatus.Green,
                PetImageUrl = "avsba12323",
                Species = new PetSpecies(){
                    Id=1,
                    Name = "Köpek"
                },
                SubSpecies = new PetSubSpecies(){
                    Id = 1,
                    Name = "Kangal"
                }
            },
            new Pet{
                Id = 2,
                Name = "minnoş",
                Age = 5,
                 Gender = PetGender.Female,
                 HealthStatus = HealthStatus.Yellow,
                PetImageUrl = "avsba12343",
                  Species = new PetSpecies(){
                     Id=2,
                     Name = "Kedi"
                 },
                 SubSpecies = new PetSubSpecies(){
                    Id = 1,
                     Name = "Tekir"

                 }


            }
        );

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
                UnitsInStock= 10,
                BrandId =1,
                CategoryId=1,
                CompanyId=1
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
    }
}