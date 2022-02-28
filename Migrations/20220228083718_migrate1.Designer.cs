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
    [Migration("20220228083718_migrate1")]
    partial class migrate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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

            modelBuilder.Entity("Incidence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("Visibility")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Incidences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kedi ac",
                            RegionId = 1,
                            UserId = 1,
                            Visibility = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kopek ac",
                            RegionId = 1,
                            UserId = 1,
                            Visibility = true
                        });
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

            modelBuilder.Entity("Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "kocholding@gmail.com",
                            Name = "Koc Holding"
                        },
                        new
                        {
                            Id = 2,
                            Email = "sabanciholding@gmail.com",
                            Name = "Sabanci Holding"
                        },
                        new
                        {
                            Id = 3,
                            Email = "zorluholding@gmail.com",
                            Name = "Zorlu Holding"
                        },
                        new
                        {
                            Id = 4,
                            Email = "doganholding@gmail.com",
                            Name = "Dogan Holding"
                        },
                        new
                        {
                            Id = 5,
                            Email = "kamciholding@gmail.com",
                            Name = "Kamci Holding"
                        });
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

            modelBuilder.Entity("Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Company", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
