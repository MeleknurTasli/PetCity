﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PetCity.Migrations
{
    [DbContext(typeof(PetCityContext))]
    [Migration("20220303072633_a1")]
    partial class a1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Visibility")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "meryem.dogan@sahabt.com",
                            IsBlocked = true,
                            Password = "123123",
                            Visibility = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "galipcan.karaaslan@sahabt.com",
                            IsBlocked = true,
                            Password = "555555",
                            Visibility = true
                        });
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("AccountId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Account_Role", (string)null);
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AddressName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddres1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddres2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pro Plan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pro Line"
                        });
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cat Food"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dog Food"
                        });
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "BlaBla Sirketi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BlaBlaBla Sirketi"
                        });
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryCode")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CountryId");

                    b.HasIndex("AddressId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NeighborhoodId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Neighborhood");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("HealthStatusId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PetImageUrl")
                        .HasColumnType("longtext");

                    b.Property<int?>("SpeciesId")
                        .HasColumnType("int");

                    b.Property<int?>("SubSpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("HealthStatusId");

                    b.HasIndex("SpeciesId");

                    b.HasIndex("SubSpeciesId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetGender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetGenders");
                });

            modelBuilder.Entity("PetHealthStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetHealthStatus");
                });

            modelBuilder.Entity("PetSpecies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetSpecies");
                });

            modelBuilder.Entity("PetSubSpecies", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PetSubSpecies");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<int?>("TestPropInt")
                        .HasColumnType("int");

                    b.Property<string>("TestPropString")
                        .HasColumnType("longtext");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CompanyId = 1,
                            Name = "Pro Plan Active",
                            QuantityPerUnit = 0,
                            UnitPrice = 15m,
                            UnitsInStock = 10
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 2,
                            CategoryId = 2,
                            CompanyId = 2,
                            Name = "Pro Line Active",
                            QuantityPerUnit = 0,
                            UnitPrice = 10m,
                            UnitsInStock = 15
                        });
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "moderator"
                        });
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("Street", b =>
                {
                    b.Property<int>("StreetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("int");

                    b.HasKey("StreetId");

                    b.HasIndex("NeighborhoodId");

                    b.ToTable("Street");
                });

            modelBuilder.Entity("AccountRole", b =>
                {
                    b.HasOne("Account", null)
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("City", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany("City")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("State", "State")
                        .WithMany("City")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithMany("Country")
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Neighborhood", b =>
                {
                    b.HasOne("District", "District")
                        .WithMany("Neighborhood")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("Pet", b =>
                {
                    b.HasOne("PetGender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetHealthStatus", "HealthStatus")
                        .WithMany()
                        .HasForeignKey("HealthStatusId");

                    b.HasOne("PetSpecies", "Species")
                        .WithMany()
                        .HasForeignKey("SpeciesId");

                    b.HasOne("PetSubSpecies", "SubSpecies")
                        .WithMany()
                        .HasForeignKey("SubSpeciesId");

                    b.Navigation("Gender");

                    b.Navigation("HealthStatus");

                    b.Navigation("Species");

                    b.Navigation("SubSpecies");
                });

            modelBuilder.Entity("PetSubSpecies", b =>
                {
                    b.HasOne("PetSpecies", "Species")
                        .WithMany("SubSpecies")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company", "Company")
                        .WithMany("Products")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.HasOne("Country", "Country")
                        .WithMany("State")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Street", b =>
                {
                    b.HasOne("Neighborhood", "Neighborhood")
                        .WithMany("StreetList")
                        .HasForeignKey("NeighborhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.Navigation("Country");
                });

            modelBuilder.Entity("Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Navigation("District");
                });

            modelBuilder.Entity("Company", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Country", b =>
                {
                    b.Navigation("City");

                    b.Navigation("State");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("Neighborhood", b =>
                {
                    b.Navigation("StreetList");
                });

            modelBuilder.Entity("PetSpecies", b =>
                {
                    b.Navigation("SubSpecies");
                });

            modelBuilder.Entity("State", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
