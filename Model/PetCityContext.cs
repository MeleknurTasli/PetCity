public class PetCityContext : DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Company>? Companies { get; set; }
    public DbSet<Brand>? Brands { get; set; }
    public DbSet<Pet>? Pets {get;set;}
    public DbSet<PetSpecies>? PetSpecies { get; set; }
    public DbSet<PetHealthStatus>? HealthStatuses { get; set; }
    public DbSet<PetGender>? PetGenders { get; set; }
    public DbSet<PetSubSpecies>? PetSubSpecies { get; set; }

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

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Pet>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e=> e.Species).IsRequired();
            entity.Property(e=> e.HealthStatus).IsRequired();
        });

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PetSpecies>(entity=>{
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            
        });

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PetSubSpecies>(entity =>{
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PetGender>(entity =>{
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PetHealthStatus>(entity =>{
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });
        
    }
}