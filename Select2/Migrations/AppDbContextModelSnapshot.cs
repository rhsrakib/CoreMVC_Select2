﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Select2.Models;

#nullable disable

namespace Select2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Select2.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Toys"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Garden"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Office Supplies"
                        });
                });

            modelBuilder.Entity("Select2.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 10,
                            Description = "Description for product 1",
                            Name = "Product 1",
                            Price = 438.05m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 8,
                            Description = "Description for product 2",
                            Name = "Product 2",
                            Price = 142.39m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Description for product 3",
                            Name = "Product 3",
                            Price = 149.84m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Description for product 4",
                            Name = "Product 4",
                            Price = 131.24m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "Description for product 5",
                            Name = "Product 5",
                            Price = 378.87m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Description = "Description for product 6",
                            Name = "Product 6",
                            Price = 480.91m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Description for product 7",
                            Name = "Product 7",
                            Price = 14.33m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Description = "Description for product 8",
                            Name = "Product 8",
                            Price = 173.04m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 6,
                            Description = "Description for product 9",
                            Name = "Product 9",
                            Price = 48.94m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 4,
                            Description = "Description for product 10",
                            Name = "Product 10",
                            Price = 498.16m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 5,
                            Description = "Description for product 11",
                            Name = "Product 11",
                            Price = 100.90m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Description = "Description for product 12",
                            Name = "Product 12",
                            Price = 498.57m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Description for product 13",
                            Name = "Product 13",
                            Price = 418.30m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 10,
                            Description = "Description for product 14",
                            Name = "Product 14",
                            Price = 94.88m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Description = "Description for product 15",
                            Name = "Product 15",
                            Price = 58.24m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 9,
                            Description = "Description for product 16",
                            Name = "Product 16",
                            Price = 331.84m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Description = "Description for product 17",
                            Name = "Product 17",
                            Price = 491.91m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Description for product 18",
                            Name = "Product 18",
                            Price = 396.50m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 9,
                            Description = "Description for product 19",
                            Name = "Product 19",
                            Price = 40.00m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 7,
                            Description = "Description for product 20",
                            Name = "Product 20",
                            Price = 357.12m
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 9,
                            Description = "Description for product 21",
                            Name = "Product 21",
                            Price = 372.93m
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 5,
                            Description = "Description for product 22",
                            Name = "Product 22",
                            Price = 106.03m
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Description for product 23",
                            Name = "Product 23",
                            Price = 344.89m
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 9,
                            Description = "Description for product 24",
                            Name = "Product 24",
                            Price = 177.95m
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 1,
                            Description = "Description for product 25",
                            Name = "Product 25",
                            Price = 72.62m
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 10,
                            Description = "Description for product 26",
                            Name = "Product 26",
                            Price = 158.07m
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 6,
                            Description = "Description for product 27",
                            Name = "Product 27",
                            Price = 74.93m
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 9,
                            Description = "Description for product 28",
                            Name = "Product 28",
                            Price = 130.90m
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 3,
                            Description = "Description for product 29",
                            Name = "Product 29",
                            Price = 41.56m
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 10,
                            Description = "Description for product 30",
                            Name = "Product 30",
                            Price = 442.51m
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 7,
                            Description = "Description for product 31",
                            Name = "Product 31",
                            Price = 170.10m
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 8,
                            Description = "Description for product 32",
                            Name = "Product 32",
                            Price = 225.36m
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 8,
                            Description = "Description for product 33",
                            Name = "Product 33",
                            Price = 157.66m
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 7,
                            Description = "Description for product 34",
                            Name = "Product 34",
                            Price = 19.14m
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 4,
                            Description = "Description for product 35",
                            Name = "Product 35",
                            Price = 297.50m
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 7,
                            Description = "Description for product 36",
                            Name = "Product 36",
                            Price = 92.16m
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 9,
                            Description = "Description for product 37",
                            Name = "Product 37",
                            Price = 497.74m
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 9,
                            Description = "Description for product 38",
                            Name = "Product 38",
                            Price = 473.84m
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 6,
                            Description = "Description for product 39",
                            Name = "Product 39",
                            Price = 292.12m
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 3,
                            Description = "Description for product 40",
                            Name = "Product 40",
                            Price = 215.44m
                        },
                        new
                        {
                            Id = 41,
                            CategoryId = 4,
                            Description = "Description for product 41",
                            Name = "Product 41",
                            Price = 404.58m
                        },
                        new
                        {
                            Id = 42,
                            CategoryId = 8,
                            Description = "Description for product 42",
                            Name = "Product 42",
                            Price = 227.57m
                        },
                        new
                        {
                            Id = 43,
                            CategoryId = 2,
                            Description = "Description for product 43",
                            Name = "Product 43",
                            Price = 116.82m
                        },
                        new
                        {
                            Id = 44,
                            CategoryId = 3,
                            Description = "Description for product 44",
                            Name = "Product 44",
                            Price = 382.91m
                        },
                        new
                        {
                            Id = 45,
                            CategoryId = 8,
                            Description = "Description for product 45",
                            Name = "Product 45",
                            Price = 14.67m
                        },
                        new
                        {
                            Id = 46,
                            CategoryId = 9,
                            Description = "Description for product 46",
                            Name = "Product 46",
                            Price = 98.47m
                        },
                        new
                        {
                            Id = 47,
                            CategoryId = 8,
                            Description = "Description for product 47",
                            Name = "Product 47",
                            Price = 413.63m
                        },
                        new
                        {
                            Id = 48,
                            CategoryId = 9,
                            Description = "Description for product 48",
                            Name = "Product 48",
                            Price = 54.44m
                        },
                        new
                        {
                            Id = 49,
                            CategoryId = 8,
                            Description = "Description for product 49",
                            Name = "Product 49",
                            Price = 290.03m
                        },
                        new
                        {
                            Id = 50,
                            CategoryId = 9,
                            Description = "Description for product 50",
                            Name = "Product 50",
                            Price = 249.30m
                        },
                        new
                        {
                            Id = 51,
                            CategoryId = 6,
                            Description = "Description for product 51",
                            Name = "Product 51",
                            Price = 245.98m
                        },
                        new
                        {
                            Id = 52,
                            CategoryId = 8,
                            Description = "Description for product 52",
                            Name = "Product 52",
                            Price = 449.41m
                        },
                        new
                        {
                            Id = 53,
                            CategoryId = 4,
                            Description = "Description for product 53",
                            Name = "Product 53",
                            Price = 23.30m
                        },
                        new
                        {
                            Id = 54,
                            CategoryId = 1,
                            Description = "Description for product 54",
                            Name = "Product 54",
                            Price = 396.58m
                        },
                        new
                        {
                            Id = 55,
                            CategoryId = 7,
                            Description = "Description for product 55",
                            Name = "Product 55",
                            Price = 134.65m
                        },
                        new
                        {
                            Id = 56,
                            CategoryId = 9,
                            Description = "Description for product 56",
                            Name = "Product 56",
                            Price = 164.07m
                        },
                        new
                        {
                            Id = 57,
                            CategoryId = 3,
                            Description = "Description for product 57",
                            Name = "Product 57",
                            Price = 247.69m
                        },
                        new
                        {
                            Id = 58,
                            CategoryId = 5,
                            Description = "Description for product 58",
                            Name = "Product 58",
                            Price = 475.55m
                        },
                        new
                        {
                            Id = 59,
                            CategoryId = 9,
                            Description = "Description for product 59",
                            Name = "Product 59",
                            Price = 57.99m
                        },
                        new
                        {
                            Id = 60,
                            CategoryId = 7,
                            Description = "Description for product 60",
                            Name = "Product 60",
                            Price = 102.34m
                        },
                        new
                        {
                            Id = 61,
                            CategoryId = 10,
                            Description = "Description for product 61",
                            Name = "Product 61",
                            Price = 45.18m
                        },
                        new
                        {
                            Id = 62,
                            CategoryId = 3,
                            Description = "Description for product 62",
                            Name = "Product 62",
                            Price = 357.63m
                        },
                        new
                        {
                            Id = 63,
                            CategoryId = 3,
                            Description = "Description for product 63",
                            Name = "Product 63",
                            Price = 342.93m
                        },
                        new
                        {
                            Id = 64,
                            CategoryId = 1,
                            Description = "Description for product 64",
                            Name = "Product 64",
                            Price = 330.37m
                        },
                        new
                        {
                            Id = 65,
                            CategoryId = 8,
                            Description = "Description for product 65",
                            Name = "Product 65",
                            Price = 418.75m
                        },
                        new
                        {
                            Id = 66,
                            CategoryId = 3,
                            Description = "Description for product 66",
                            Name = "Product 66",
                            Price = 14.42m
                        },
                        new
                        {
                            Id = 67,
                            CategoryId = 9,
                            Description = "Description for product 67",
                            Name = "Product 67",
                            Price = 143.72m
                        },
                        new
                        {
                            Id = 68,
                            CategoryId = 9,
                            Description = "Description for product 68",
                            Name = "Product 68",
                            Price = 156.73m
                        },
                        new
                        {
                            Id = 69,
                            CategoryId = 8,
                            Description = "Description for product 69",
                            Name = "Product 69",
                            Price = 230.51m
                        },
                        new
                        {
                            Id = 70,
                            CategoryId = 4,
                            Description = "Description for product 70",
                            Name = "Product 70",
                            Price = 452.49m
                        },
                        new
                        {
                            Id = 71,
                            CategoryId = 4,
                            Description = "Description for product 71",
                            Name = "Product 71",
                            Price = 65.43m
                        },
                        new
                        {
                            Id = 72,
                            CategoryId = 1,
                            Description = "Description for product 72",
                            Name = "Product 72",
                            Price = 113.36m
                        },
                        new
                        {
                            Id = 73,
                            CategoryId = 9,
                            Description = "Description for product 73",
                            Name = "Product 73",
                            Price = 25.93m
                        },
                        new
                        {
                            Id = 74,
                            CategoryId = 5,
                            Description = "Description for product 74",
                            Name = "Product 74",
                            Price = 92.12m
                        },
                        new
                        {
                            Id = 75,
                            CategoryId = 2,
                            Description = "Description for product 75",
                            Name = "Product 75",
                            Price = 263.28m
                        },
                        new
                        {
                            Id = 76,
                            CategoryId = 7,
                            Description = "Description for product 76",
                            Name = "Product 76",
                            Price = 101.19m
                        },
                        new
                        {
                            Id = 77,
                            CategoryId = 4,
                            Description = "Description for product 77",
                            Name = "Product 77",
                            Price = 345.38m
                        },
                        new
                        {
                            Id = 78,
                            CategoryId = 1,
                            Description = "Description for product 78",
                            Name = "Product 78",
                            Price = 296.14m
                        },
                        new
                        {
                            Id = 79,
                            CategoryId = 5,
                            Description = "Description for product 79",
                            Name = "Product 79",
                            Price = 441.54m
                        },
                        new
                        {
                            Id = 80,
                            CategoryId = 5,
                            Description = "Description for product 80",
                            Name = "Product 80",
                            Price = 115.81m
                        },
                        new
                        {
                            Id = 81,
                            CategoryId = 8,
                            Description = "Description for product 81",
                            Name = "Product 81",
                            Price = 327.01m
                        },
                        new
                        {
                            Id = 82,
                            CategoryId = 7,
                            Description = "Description for product 82",
                            Name = "Product 82",
                            Price = 242.11m
                        },
                        new
                        {
                            Id = 83,
                            CategoryId = 4,
                            Description = "Description for product 83",
                            Name = "Product 83",
                            Price = 481.51m
                        },
                        new
                        {
                            Id = 84,
                            CategoryId = 8,
                            Description = "Description for product 84",
                            Name = "Product 84",
                            Price = 449.93m
                        },
                        new
                        {
                            Id = 85,
                            CategoryId = 1,
                            Description = "Description for product 85",
                            Name = "Product 85",
                            Price = 218.52m
                        },
                        new
                        {
                            Id = 86,
                            CategoryId = 9,
                            Description = "Description for product 86",
                            Name = "Product 86",
                            Price = 308.76m
                        },
                        new
                        {
                            Id = 87,
                            CategoryId = 4,
                            Description = "Description for product 87",
                            Name = "Product 87",
                            Price = 90.85m
                        },
                        new
                        {
                            Id = 88,
                            CategoryId = 3,
                            Description = "Description for product 88",
                            Name = "Product 88",
                            Price = 215.28m
                        },
                        new
                        {
                            Id = 89,
                            CategoryId = 7,
                            Description = "Description for product 89",
                            Name = "Product 89",
                            Price = 400.44m
                        },
                        new
                        {
                            Id = 90,
                            CategoryId = 8,
                            Description = "Description for product 90",
                            Name = "Product 90",
                            Price = 454.71m
                        },
                        new
                        {
                            Id = 91,
                            CategoryId = 5,
                            Description = "Description for product 91",
                            Name = "Product 91",
                            Price = 61.04m
                        },
                        new
                        {
                            Id = 92,
                            CategoryId = 1,
                            Description = "Description for product 92",
                            Name = "Product 92",
                            Price = 491.80m
                        },
                        new
                        {
                            Id = 93,
                            CategoryId = 1,
                            Description = "Description for product 93",
                            Name = "Product 93",
                            Price = 223.55m
                        },
                        new
                        {
                            Id = 94,
                            CategoryId = 3,
                            Description = "Description for product 94",
                            Name = "Product 94",
                            Price = 126.44m
                        },
                        new
                        {
                            Id = 95,
                            CategoryId = 8,
                            Description = "Description for product 95",
                            Name = "Product 95",
                            Price = 57.91m
                        },
                        new
                        {
                            Id = 96,
                            CategoryId = 6,
                            Description = "Description for product 96",
                            Name = "Product 96",
                            Price = 4.02m
                        },
                        new
                        {
                            Id = 97,
                            CategoryId = 2,
                            Description = "Description for product 97",
                            Name = "Product 97",
                            Price = 419.43m
                        },
                        new
                        {
                            Id = 98,
                            CategoryId = 7,
                            Description = "Description for product 98",
                            Name = "Product 98",
                            Price = 119.65m
                        },
                        new
                        {
                            Id = 99,
                            CategoryId = 3,
                            Description = "Description for product 99",
                            Name = "Product 99",
                            Price = 178.97m
                        },
                        new
                        {
                            Id = 100,
                            CategoryId = 8,
                            Description = "Description for product 100",
                            Name = "Product 100",
                            Price = 157.92m
                        });
                });

            modelBuilder.Entity("Select2.Models.Product", b =>
                {
                    b.HasOne("Select2.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Select2.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
