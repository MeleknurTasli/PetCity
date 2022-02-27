using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
     : base(options)
    {
    }
    public DbSet<Incidence> Incidences { get; set; } = null!;
    public DbSet<Supplier> Suppliers{get;set;} = null!;
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
       
    }
}
