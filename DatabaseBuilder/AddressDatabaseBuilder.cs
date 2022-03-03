public static class AddressDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
         {
             entity.HasKey(e => e.AddressId);
             entity.Property(e => e.AddressName).IsRequired();
             entity.Property(e => e.OpenAddres1);
             entity.Property(e => e.OpenAddres2);
         });


        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.CountryId);
            entity.HasOne(b => b.Country)
                  .WithMany(c => c!.City);
            entity.HasOne(b => b.State)
            .WithMany(c => c!.City);

        });

        modelBuilder.Entity<Country>(entity =>
       {
           entity.HasKey(e => e.CountryId);
           entity.Property(e => e.CountryName).IsRequired();
           entity.Property(e => e.CountryCode);
           entity.Property(e => e.AddressId);
           entity.HasOne(b => b.Address)
                     .WithMany(c => c!.Country);
       });

        modelBuilder.Entity<District>(entity =>
       {
           entity.HasKey(e => e.DistrictId);
           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.CityId);
           entity.HasOne(b => b.City)
                     .WithMany(c => c!.District);
       });

        modelBuilder.Entity<Neighborhood>(entity =>
              {
                  entity.HasKey(e => e.NeighborhoodId);
                  entity.Property(e => e.Name).IsRequired();
                  entity.Property(e => e.DistrictId);
                  entity.HasOne(b => b.District)
                     .WithMany(c => c!.Neighborhood);
              });

        modelBuilder.Entity<State>(entity =>
               {
                   entity.HasKey(e => e.StateId);
                   entity.Property(e => e.Name).IsRequired();
                   entity.Property(e => e.CountryId);
                   entity.HasOne(b => b.Country)
                     .WithMany(c => c!.State);

               });

        modelBuilder.Entity<Street>(entity =>
               {
                   entity.HasKey(e => e.StreetId);
                   entity.Property(e => e.Name).IsRequired();
                   entity.Property(e => e.NeighborhoodId);
                   entity.HasOne(b => b.Neighborhood);
               });

        SetDataToDB(modelBuilder);
    }
}