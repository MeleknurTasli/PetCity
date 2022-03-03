public static class SupplierDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {
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
                }
 
            );
    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.HasOne(e=>e.Account);
            entity.HasOne(e=>e.Address);
            entity.HasMany(e=>e.Brand).WithMany(p=>p.Suppliers).UsingEntity(j=>j.ToTable("SupplierBrand"));
            entity.Property(e=>e.Rating);            
            
        });
    }

}