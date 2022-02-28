﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PetCity.Migrations
{
    [DbContext(typeof(PetCityContext))]
    partial class PetCityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Name = "Pro Plan"
                        },
                        new
                        {
                            BrandId = 2,
                            Name = "Pro Line"
                        });
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Cat Food"
                        },
                        new
                        {
                            CategoryId = 2,
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
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            Name = "BlaBla Sirketi"
                        },
                        new
                        {
                            CompanyId = 2,
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

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("ProductId")
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

                    b.Property<short>("QuantityPerUnit")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            CompanyId = 1,
                            Name = "Pro Plan Active",
                            QuantityPerUnit = (short)0,
                            UnitPrice = 15m,
                            UnitsInStock = (short)10
                        },
                        new
                        {
                            ProductId = 2,
                            BrandId = 2,
                            CategoryId = 2,
                            CompanyId = 2,
                            Name = "Pro Line Active",
                            QuantityPerUnit = (short)0,
                            UnitPrice = 10m,
                            UnitsInStock = (short)15
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

            modelBuilder.Entity("State", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
