public static class AddressDatabaseBuilder
{


    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {        modelBuilder.Entity<Address>(entity =>
               {
                   entity.HasKey(e => e.Id);
                   entity.Property(e => e.AddressName).IsRequired();
                   entity.Property(e => e.OpenAddres1);
                   entity.Property(e => e.OpenAddres2);
                   entity.HasOne(e => e.City);
                   entity.HasOne(e => e.Country);
                   entity.HasOne(e => e.District);
                   entity.HasOne(e => e.State);
                 

               });
        modelBuilder.Entity<Country>(entity =>
       {
           entity.HasKey(e => e.Id);
           entity.Property(e => e.Name).IsRequired();
           entity.Property(e => e.Code);
       });

        modelBuilder.Entity<State>(entity =>
         {
             entity.HasKey(e => e.Id);

             entity.Property(e => e.Name).IsRequired();
             entity.HasOne(e => e.Country).WithMany(c => c.state).HasForeignKey(e => e.CountryId);

         });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name);
            entity.HasOne(c => c!.Country).WithMany(c => c!.city).HasForeignKey(c=>c.CountryId);
            entity.HasOne(c => c.State).WithMany(c => c.city).HasForeignKey(c=> c.StateId);

        });

        modelBuilder.Entity<District>(entity =>
       {
           entity.HasKey(e => e.Id);

           entity.Property(e => e.Name);
           entity.HasOne(c => c.City).WithMany(c => c.District).HasForeignKey(c => c.CityId);
       });

       

       

               modelBuilder.Entity<Country>().HasData(
           new Country
           {
               Id = 1,
               Name = "Turkey",
               Code = 001

           },
           new Country
           {
               Id = 2,
               Name = "Usa",
               Code = 002

           },
             new Country
           {
               Id = 3,
               Name = "Germany",
               Code = 003

           },
             new Country
           {
               Id = 4,
               Name = "England",
               Code = 004

           }
       );
       modelBuilder.Entity<City>().HasData(
           new City
           {
               Id = 1,
               Name = "Ankara",
               CountryId=1,
               
               

           },
             new City
           {
               Id = 2,
               Name = "Istanbul",
               CountryId=1,
               

           },
           new City
           {
               Id = 3,
               Name = "New York City",
               CountryId=2,
               StateId =1

           },
             new City
           {
               Id = 4,
               Name = "Los Angeles",
               CountryId=2,
               StateId =2

           },
             new City
           {
               Id = 5,
               Name = "Munich",
               CountryId=3,
               StateId =3

           },
             new City
           {
               Id = 6,
               Name = "Londra",
               CountryId=4,
             

           }

           
       );

        modelBuilder.Entity<State>().HasData(
           new State
           {
               Id = 1,
               Name = "New York",
               CountryId =2

           },
           
           new State
           {
               Id = 2,
               Name = "California",
               CountryId =2

           },
           new State
           {
               Id = 3,
               Name = "Bavyera",
               CountryId =3

           }

        );

         modelBuilder.Entity<District>().HasData(
           new District
           {
               Id = 1,
               Name = "Kecioren",
               CityId=1

           },
           new District
           {
               Id = 2,
               Name = "Mamak",
               CityId=1

           },
           new District
           {
               Id = 3,
               Name = "Bagcılar",
               CityId=2

           },
           new District
           {
               Id = 4,
               Name = "Besiktas",
               CityId=2

           },
           new District
           {
               Id = 5,
               Name = "Manhattan",
               CityId=3

           },
           new District
           {
               Id = 6,
               Name = "Brooklyn",
               CityId=3

           },
           new District
           {
               Id = 7,
               Name = "Hollywood",
               CityId=4

           },
           new District
           {
               Id = 8,
               Name = "Santa Monica",
               CityId=4

           },
           new District
           {
               Id = 9,
               Name = "Altstadt",
               CityId=5

           },
           new District
           {
               Id = 10,
               Name = "Neuhausen",
               CityId=5

           },
           new District
           {
               Id = 11,
               Name = "Greenwich",
               CityId=6

           },
           new District
           {
               Id = 12,
               Name = "Soho",
               CityId=6

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


        SetDataToDB(modelBuilder);
    }
}


