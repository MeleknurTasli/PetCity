
public class LibraryContext : DbContext
{
    public DbSet<Book>? Books { get; set; }
    public DbSet<Publisher>? Publishers { get; set; }
    public DbSet<Supplier>? Suppliers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=sahabt;user=root;port=3306;password=toortoor");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Supplier>(entity=>{
            entity.HasKey(e=>e.Id);
            entity.Property(e=>e.Name);
            entity.Property(e=>e.Email);
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId);
            entity.Property(e => e.Name).IsRequired();
        });
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.ISBN);
            entity.Property(e => e.Title).IsRequired();
            entity.HasOne(d => d.Publisher)
            .WithMany(p => p!.Books);
        });
        modelBuilder.Entity<Supplier>().HasData(
            new Supplier{
                Id=1,
                Name="Koc Holding",
                Email="kocholding@gmail.com"                
            },
            new Supplier{
                Id=2,
                Name="Sabanci Holding",
                Email="sabanciholding@gmail.com"                
            },
            new Supplier{
                Id=3,
                Name="Zorlu Holding",
                Email="zorluholding@gmail.com"                
            },
            new Supplier{
                Id=4,
                Name="Dogan Holding",
                Email="doganholding@gmail.com"                
            },
            new Supplier{
                Id=5,
                Name="Kamci Holding",
                Email="kamciholding@gmail.com"                
            }
            
        );

        modelBuilder.Entity<Publisher>().HasData(
            new Publisher
            {
                PublisherId = 1,
                Name = "Mariner Books"
            },
            new Publisher
            {
                PublisherId = 2,
                Name = "Penguin Books"
            }
        );
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                ISBN = "978-0544003415",
                Title = "The Lord of the Rings",
                Author = "J.R.R. Tolkien",
                Language = "English",
                Pages = 1216,
                PublisherId = 1
            },
            new Book
            {
                ISBN = "978-0547247762",
                Title = "The Sealed Letter",
                Author = "Emma Donoghue",
                Language = "English",
                Pages = 416,
                PublisherId = 1
            },
            new Book
            {
                ISBN = "978-0143107569",
                Title = "Les Miserables",
                Author = "Victor Hugo",
                Language = "English",
                Pages = 1456,
                PublisherId = 2
            },
            new Book
            {
                ISBN = "978-0140449174",
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                Language = "English",
                Pages = 880,
                PublisherId = 2
            }
        );
    }
}