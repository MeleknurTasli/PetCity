public static class IncidenceDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Incidence>().HasData(
            new Incidence{
                Id=1,
                Name="Kedi ac",
                Visibility=true,
                Description = "kedi çok aç",
                UserId = 1
            },
            new Incidence{
                Id=2,
                Name="Kopek ac",
                Visibility=true ,
                Description = "köpek çok aç",
                UserId = 2
            }
        );

        //geçici olarak
        modelBuilder.Entity<User>().HasData(
            new User{
                Id=1,
                Name="Melek"
            },
             new User{
                Id=2,
                Name="Furkan"
            }
        );
    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Incidence>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.District).WithMany(c => c!.IncidenceList).HasForeignKey(e=>e.DistrictId);
            entity.HasOne(b => b.User).WithMany(c => c!.IncidenceList).HasForeignKey(e=>e.UserId);
            entity.Property(e=>e.Visibility);
            entity.Property(e=>e.Description);
            entity.Property(e=>e.Image);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
        });

        SetDataToDB(modelBuilder);
    }

}