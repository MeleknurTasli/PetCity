public static class IncidenceDatabaseBuilder
{
    static void SetDataToDB(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<Incidence>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.HasOne(p => p.District).WithMany(c => c!.IncidenceList).HasForeignKey(c => c.DistrictId);
            entity.HasOne(b => b.User).WithMany(c => c!.IncidenceList).HasForeignKey(c => c.UserId);
            entity.Property(e=>e.Visibility);
            entity.Property(e=>e.UserId);
            entity.Property(e=>e.DistrictId);
            entity.Property(e=>e.Description);
            entity.Property(e=>e.Image);
        });
        modelBuilder.Entity<Incidence>().HasData(
            new Incidence{
                Id=1,
                Name="Kedi ac",
                Visibility=true,
                UserId = 1,
                DistrictId = 1,
                Description = "kedi çok aç"
            },
            new Incidence{
                Id=2,
                Name="Kopek ac",
                Visibility=true ,
                UserId = 1,
                DistrictId = 1 ,
                Description = "köpek çok aç"  
            }
        );
    SetDataToDB(modelBuilder);
    }
}