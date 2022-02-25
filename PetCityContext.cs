using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
     : base(options)
    {
    }
    public DbSet<Incidence> Incidences { get; set; } = null!;
}
