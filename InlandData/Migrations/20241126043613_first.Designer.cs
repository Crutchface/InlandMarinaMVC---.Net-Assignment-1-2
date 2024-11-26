﻿// <auto-generated />
using InlandData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InlandData.Migrations
{
    [DbContext(typeof(InlandContext))]
    [Migration("20241126043613_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InlandData.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            City = "Los Angeles",
                            FirstName = "John",
                            LastName = "Smith",
                            Phone = "3234567890"
                        },
                        new
                        {
                            CustomerId = 2,
                            City = "San Francisco",
                            FirstName = "Emily",
                            LastName = "Johnson",
                            Phone = "4152345678"
                        },
                        new
                        {
                            CustomerId = 3,
                            City = "San Diego",
                            FirstName = "David",
                            LastName = "Brown",
                            Phone = "8581234567"
                        },
                        new
                        {
                            CustomerId = 4,
                            City = "Sacramento",
                            FirstName = "Jessica",
                            LastName = "Davis",
                            Phone = "9162345678"
                        },
                        new
                        {
                            CustomerId = 5,
                            City = "Fresno",
                            FirstName = "Michael",
                            LastName = "Miller",
                            Phone = "5593456789"
                        },
                        new
                        {
                            CustomerId = 6,
                            City = "Phoenix",
                            FirstName = "Sarah",
                            LastName = "Wilson",
                            Phone = "6022345678"
                        },
                        new
                        {
                            CustomerId = 7,
                            City = "Tucson",
                            FirstName = "Daniel",
                            LastName = "Moore",
                            Phone = "5203456789"
                        },
                        new
                        {
                            CustomerId = 8,
                            City = "Mesa",
                            FirstName = "Olivia",
                            LastName = "Taylor",
                            Phone = "4804567890"
                        },
                        new
                        {
                            CustomerId = 9,
                            City = "Chandler",
                            FirstName = "Matthew",
                            LastName = "Anderson",
                            Phone = "4805678901"
                        },
                        new
                        {
                            CustomerId = 10,
                            City = "Scottsdale",
                            FirstName = "Sophia",
                            LastName = "Thomas",
                            Phone = "6026789012"
                        },
                        new
                        {
                            CustomerId = 11,
                            City = "Las Vegas",
                            FirstName = "James",
                            LastName = "Jackson",
                            Phone = "7027890123"
                        },
                        new
                        {
                            CustomerId = 12,
                            City = "Reno",
                            FirstName = "Isabella",
                            LastName = "White",
                            Phone = "7758901234"
                        },
                        new
                        {
                            CustomerId = 13,
                            City = "Henderson",
                            FirstName = "Alexander",
                            LastName = "Harris",
                            Phone = "7029012345"
                        },
                        new
                        {
                            CustomerId = 14,
                            City = "Carson City",
                            FirstName = "Ava",
                            LastName = "Martin",
                            Phone = "7752345678"
                        },
                        new
                        {
                            CustomerId = 15,
                            City = "Elko",
                            FirstName = "Ethan",
                            LastName = "Garcia",
                            Phone = "7023456789"
                        },
                        new
                        {
                            CustomerId = 16,
                            City = "Salt Lake City",
                            FirstName = "Charlotte",
                            LastName = "Lee",
                            Phone = "8012345678"
                        },
                        new
                        {
                            CustomerId = 17,
                            City = "Provo",
                            FirstName = "Henry",
                            LastName = "Perez",
                            Phone = "3853456789"
                        },
                        new
                        {
                            CustomerId = 18,
                            City = "Ogden",
                            FirstName = "Amelia",
                            LastName = "Martinez",
                            Phone = "8014567890"
                        },
                        new
                        {
                            CustomerId = 19,
                            City = "St. George",
                            FirstName = "Benjamin",
                            LastName = "Rodriguez",
                            Phone = "4355678901"
                        },
                        new
                        {
                            CustomerId = 20,
                            City = "West Valley City",
                            FirstName = "Grace",
                            LastName = "Gonzalez",
                            Phone = "3856789012"
                        });
                });

            modelBuilder.Entity("InlandData.Dock", b =>
                {
                    b.Property<int>("DockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DockId"));

                    b.Property<bool>("ElectricalService")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WaterService")
                        .HasColumnType("bit");

                    b.HasKey("DockId");

                    b.ToTable("Docks");

                    b.HasData(
                        new
                        {
                            DockId = 1,
                            ElectricalService = true,
                            Name = "Seabreeze Cove",
                            WaterService = true
                        },
                        new
                        {
                            DockId = 2,
                            ElectricalService = false,
                            Name = "Sunset Haven",
                            WaterService = true
                        },
                        new
                        {
                            DockId = 3,
                            ElectricalService = false,
                            Name = "Whispering Pines",
                            WaterService = false
                        });
                });

            modelBuilder.Entity("InlandData.Lease", b =>
                {
                    b.Property<int>("LeaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaseId"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("SlipID")
                        .HasColumnType("int");

                    b.HasKey("LeaseId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("SlipID");

                    b.ToTable("Leases");

                    b.HasData(
                        new
                        {
                            LeaseId = 1,
                            CustomerID = 1,
                            SlipID = 53
                        },
                        new
                        {
                            LeaseId = 2,
                            CustomerID = 2,
                            SlipID = 18
                        },
                        new
                        {
                            LeaseId = 3,
                            CustomerID = 3,
                            SlipID = 72
                        },
                        new
                        {
                            LeaseId = 4,
                            CustomerID = 4,
                            SlipID = 4
                        },
                        new
                        {
                            LeaseId = 5,
                            CustomerID = 5,
                            SlipID = 64
                        },
                        new
                        {
                            LeaseId = 6,
                            CustomerID = 6,
                            SlipID = 10
                        },
                        new
                        {
                            LeaseId = 7,
                            CustomerID = 7,
                            SlipID = 81
                        },
                        new
                        {
                            LeaseId = 8,
                            CustomerID = 8,
                            SlipID = 30
                        },
                        new
                        {
                            LeaseId = 9,
                            CustomerID = 9,
                            SlipID = 5
                        },
                        new
                        {
                            LeaseId = 10,
                            CustomerID = 10,
                            SlipID = 37
                        },
                        new
                        {
                            LeaseId = 11,
                            CustomerID = 11,
                            SlipID = 56
                        },
                        new
                        {
                            LeaseId = 12,
                            CustomerID = 12,
                            SlipID = 68
                        },
                        new
                        {
                            LeaseId = 13,
                            CustomerID = 13,
                            SlipID = 22
                        },
                        new
                        {
                            LeaseId = 14,
                            CustomerID = 14,
                            SlipID = 89
                        },
                        new
                        {
                            LeaseId = 15,
                            CustomerID = 15,
                            SlipID = 44
                        },
                        new
                        {
                            LeaseId = 16,
                            CustomerID = 16,
                            SlipID = 12
                        },
                        new
                        {
                            LeaseId = 17,
                            CustomerID = 17,
                            SlipID = 79
                        },
                        new
                        {
                            LeaseId = 18,
                            CustomerID = 18,
                            SlipID = 29
                        },
                        new
                        {
                            LeaseId = 19,
                            CustomerID = 19,
                            SlipID = 60
                        },
                        new
                        {
                            LeaseId = 20,
                            CustomerID = 20,
                            SlipID = 14
                        });
                });

            modelBuilder.Entity("InlandData.Slip", b =>
                {
                    b.Property<int>("SlipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SlipId"));

                    b.Property<int>("DockID")
                        .HasColumnType("int");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SlipId");

                    b.HasIndex("DockID");

                    b.ToTable("Slips");

                    b.HasData(
                        new
                        {
                            SlipId = 1,
                            DockID = 1,
                            Length = 20m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 2,
                            DockID = 1,
                            Length = 25m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 3,
                            DockID = 1,
                            Length = 18m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 4,
                            DockID = 1,
                            Length = 22m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 5,
                            DockID = 1,
                            Length = 30m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 6,
                            DockID = 1,
                            Length = 26m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 7,
                            DockID = 1,
                            Length = 21m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 8,
                            DockID = 1,
                            Length = 27m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 9,
                            DockID = 1,
                            Length = 23m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 10,
                            DockID = 1,
                            Length = 29m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 11,
                            DockID = 1,
                            Length = 18m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 12,
                            DockID = 1,
                            Length = 30m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 13,
                            DockID = 1,
                            Length = 22m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 14,
                            DockID = 1,
                            Length = 27m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 15,
                            DockID = 1,
                            Length = 24m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 16,
                            DockID = 1,
                            Length = 26m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 17,
                            DockID = 1,
                            Length = 20m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 18,
                            DockID = 1,
                            Length = 28m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 19,
                            DockID = 1,
                            Length = 23m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 20,
                            DockID = 1,
                            Length = 25m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 21,
                            DockID = 1,
                            Length = 27m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 22,
                            DockID = 1,
                            Length = 21m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 23,
                            DockID = 1,
                            Length = 19m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 24,
                            DockID = 1,
                            Length = 25m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 25,
                            DockID = 1,
                            Length = 24m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 26,
                            DockID = 1,
                            Length = 29m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 27,
                            DockID = 1,
                            Length = 21m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 28,
                            DockID = 1,
                            Length = 22m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 29,
                            DockID = 1,
                            Length = 18m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 30,
                            DockID = 1,
                            Length = 30m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 31,
                            DockID = 1,
                            Length = 26m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 32,
                            DockID = 1,
                            Length = 27m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 33,
                            DockID = 1,
                            Length = 22m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 34,
                            DockID = 1,
                            Length = 23m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 35,
                            DockID = 1,
                            Length = 20m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 36,
                            DockID = 1,
                            Length = 25m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 37,
                            DockID = 1,
                            Length = 28m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 38,
                            DockID = 1,
                            Length = 24m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 39,
                            DockID = 1,
                            Length = 29m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 40,
                            DockID = 1,
                            Length = 22m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 41,
                            DockID = 1,
                            Length = 23m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 42,
                            DockID = 1,
                            Length = 26m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 43,
                            DockID = 1,
                            Length = 27m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 44,
                            DockID = 1,
                            Length = 24m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 45,
                            DockID = 1,
                            Length = 21m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 46,
                            DockID = 1,
                            Length = 22m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 47,
                            DockID = 1,
                            Length = 23m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 48,
                            DockID = 1,
                            Length = 21m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 49,
                            DockID = 1,
                            Length = 25m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 50,
                            DockID = 1,
                            Length = 28m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 51,
                            DockID = 1,
                            Length = 29m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 52,
                            DockID = 1,
                            Length = 24m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 53,
                            DockID = 1,
                            Length = 30m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 54,
                            DockID = 1,
                            Length = 28m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 55,
                            DockID = 1,
                            Length = 29m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 56,
                            DockID = 1,
                            Length = 25m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 57,
                            DockID = 1,
                            Length = 30m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 58,
                            DockID = 1,
                            Length = 24m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 59,
                            DockID = 1,
                            Length = 22m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 60,
                            DockID = 1,
                            Length = 23m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 61,
                            DockID = 1,
                            Length = 18m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 62,
                            DockID = 1,
                            Length = 26m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 63,
                            DockID = 1,
                            Length = 19m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 64,
                            DockID = 1,
                            Length = 30m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 65,
                            DockID = 1,
                            Length = 25m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 66,
                            DockID = 1,
                            Length = 27m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 67,
                            DockID = 1,
                            Length = 19m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 68,
                            DockID = 1,
                            Length = 22m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 69,
                            DockID = 1,
                            Length = 21m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 70,
                            DockID = 1,
                            Length = 30m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 71,
                            DockID = 1,
                            Length = 26m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 72,
                            DockID = 1,
                            Length = 28m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 73,
                            DockID = 1,
                            Length = 30m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 74,
                            DockID = 1,
                            Length = 27m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 75,
                            DockID = 1,
                            Length = 22m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 76,
                            DockID = 1,
                            Length = 23m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 77,
                            DockID = 1,
                            Length = 30m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 78,
                            DockID = 1,
                            Length = 26m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 79,
                            DockID = 1,
                            Length = 20m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 80,
                            DockID = 1,
                            Length = 29m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 81,
                            DockID = 1,
                            Length = 24m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 82,
                            DockID = 1,
                            Length = 22m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 83,
                            DockID = 1,
                            Length = 25m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 84,
                            DockID = 1,
                            Length = 18m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 85,
                            DockID = 1,
                            Length = 21m,
                            Width = 11m
                        },
                        new
                        {
                            SlipId = 86,
                            DockID = 1,
                            Length = 28m,
                            Width = 12m
                        },
                        new
                        {
                            SlipId = 87,
                            DockID = 1,
                            Length = 19m,
                            Width = 8m
                        },
                        new
                        {
                            SlipId = 88,
                            DockID = 1,
                            Length = 27m,
                            Width = 10m
                        },
                        new
                        {
                            SlipId = 89,
                            DockID = 1,
                            Length = 23m,
                            Width = 9m
                        },
                        new
                        {
                            SlipId = 90,
                            DockID = 1,
                            Length = 23m,
                            Width = 10m
                        });
                });

            modelBuilder.Entity("InlandData.Lease", b =>
                {
                    b.HasOne("InlandData.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlandData.Slip", "Slip")
                        .WithMany()
                        .HasForeignKey("SlipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Slip");
                });

            modelBuilder.Entity("InlandData.Slip", b =>
                {
                    b.HasOne("InlandData.Dock", "Dock")
                        .WithMany()
                        .HasForeignKey("DockID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dock");
                });
#pragma warning restore 612, 618
        }
    }
}
