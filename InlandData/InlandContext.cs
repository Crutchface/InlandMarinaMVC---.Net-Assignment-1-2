using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.AppConfig;


namespace InlandData
{   
    public class InlandContext : IdentityDbContext<User>
    {
        public InlandContext() : base() { } // just calls the base class constructor

        //  Our inland context function that is the constructor for inland context using entity framework with specific options
        public InlandContext(DbContextOptions<InlandContext> options) : base(options) { }
        // Inherits from Dbcontext from ef
        

        public DbSet<Dock> Docks { get; set; }
        public DbSet<Slip> Slips { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // provide connection string
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" +
                "Database=Inland;" +
                "Trusted_Connection=True; " +
                "MultipleActiveResultSets=true; " +
                "TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slip>().HasData(
            new Slip { SlipId = 1, Width = 9, Length = 20, DockID = 2 },
            new Slip { SlipId = 2, Width = 12, Length = 25, DockID = 3 },
            new Slip { SlipId = 3, Width = 8, Length = 18, DockID = 1 },
            new Slip { SlipId = 4, Width = 10, Length = 22, DockID = 3 },
            new Slip { SlipId = 5, Width = 12, Length = 30, DockID = 1 },
            new Slip { SlipId = 6, Width = 11, Length = 26, DockID = 2 },
            new Slip { SlipId = 7, Width = 9, Length = 21, DockID = 1 },
            new Slip { SlipId = 8, Width = 11, Length = 27, DockID = 3 },
            new Slip { SlipId = 9, Width = 10, Length = 23, DockID = 2 },
            new Slip { SlipId = 10, Width = 9, Length = 29, DockID = 1 },
            new Slip { SlipId = 11, Width = 8, Length = 18, DockID = 2 },
            new Slip { SlipId = 12, Width = 12, Length = 30, DockID = 3 },
            new Slip { SlipId = 13, Width = 9, Length = 22, DockID = 1 },
            new Slip { SlipId = 14, Width = 11, Length = 27, DockID = 3 },
            new Slip { SlipId = 15, Width = 10, Length = 24, DockID = 2 },
            new Slip { SlipId = 16, Width = 9, Length = 26, DockID = 1 },
            new Slip { SlipId = 17, Width = 8, Length = 20, DockID = 3 },
            new Slip { SlipId = 18, Width = 12, Length = 28, DockID = 1 },
            new Slip { SlipId = 19, Width = 10, Length = 23, DockID = 2 },
            new Slip { SlipId = 20, Width = 11, Length = 25, DockID = 1 },
            new Slip { SlipId = 21, Width = 12, Length = 27, DockID = 2 },
            new Slip { SlipId = 22, Width = 9, Length = 21, DockID = 3 },
            new Slip { SlipId = 23, Width = 8, Length = 19, DockID = 1 },
            new Slip { SlipId = 24, Width = 10, Length = 25, DockID = 2 },
            new Slip { SlipId = 25, Width = 11, Length = 24, DockID = 3 },
            new Slip { SlipId = 26, Width = 12, Length = 29, DockID = 1 },
            new Slip { SlipId = 27, Width = 8, Length = 21, DockID = 3 },
            new Slip { SlipId = 28, Width = 10, Length = 22, DockID = 1 },
            new Slip { SlipId = 29, Width = 9, Length = 18, DockID = 2 },
            new Slip { SlipId = 30, Width = 11, Length = 30, DockID = 3 },
            new Slip { SlipId = 31, Width = 12, Length = 26, DockID = 2 },
            new Slip { SlipId = 32, Width = 10, Length = 27, DockID = 1 },
            new Slip { SlipId = 33, Width = 8, Length = 22, DockID = 3 },
            new Slip { SlipId = 34, Width = 9, Length = 23, DockID = 1 },
            new Slip { SlipId = 35, Width = 11, Length = 20, DockID = 2 },
            new Slip { SlipId = 36, Width = 8, Length = 25, DockID = 3 },
            new Slip { SlipId = 37, Width = 10, Length = 28, DockID = 1 },
            new Slip { SlipId = 38, Width = 12, Length = 24, DockID = 2 },
            new Slip { SlipId = 39, Width = 9, Length = 29, DockID = 1 },
            new Slip { SlipId = 40, Width = 11, Length = 22, DockID = 3 },
            new Slip { SlipId = 41, Width = 12, Length = 23, DockID = 2 },
            new Slip { SlipId = 42, Width = 10, Length = 26, DockID = 1 },
            new Slip { SlipId = 43, Width = 8, Length = 27, DockID = 3 },
            new Slip { SlipId = 44, Width = 9, Length = 24, DockID = 2 },
            new Slip { SlipId = 45, Width = 11, Length = 21, DockID = 1 },
            new Slip { SlipId = 46, Width = 12, Length = 22, DockID = 2 },
            new Slip { SlipId = 47, Width = 8, Length = 23, DockID = 3 },
            new Slip { SlipId = 48, Width = 10, Length = 21, DockID = 1 },
            new Slip { SlipId = 49, Width = 9, Length = 25, DockID = 2 },
            new Slip { SlipId = 50, Width = 11, Length = 28, DockID = 1 },
            new Slip { SlipId = 51, Width = 12, Length = 29, DockID = 3 },
            new Slip { SlipId = 52, Width = 8, Length = 24, DockID = 2 },
            new Slip { SlipId = 53, Width = 10, Length = 30, DockID = 3 },
            new Slip { SlipId = 54, Width = 9, Length = 28, DockID = 1 },
            new Slip { SlipId = 55, Width = 11, Length = 29, DockID = 2 },
            new Slip { SlipId = 56, Width = 12, Length = 25, DockID = 3 },
            new Slip { SlipId = 57, Width = 8, Length = 30, DockID = 1 },
            new Slip { SlipId = 58, Width = 10, Length = 24, DockID = 3 },
            new Slip { SlipId = 59, Width = 9, Length = 22, DockID = 2 },
            new Slip { SlipId = 60, Width = 11, Length = 23, DockID = 1 },
            new Slip { SlipId = 61, Width = 12, Length = 18, DockID = 3 },
            new Slip { SlipId = 62, Width = 8, Length = 26, DockID = 2 },
            new Slip { SlipId = 63, Width = 10, Length = 19, DockID = 1 },
            new Slip { SlipId = 64, Width = 9, Length = 30, DockID = 3 },
            new Slip { SlipId = 65, Width = 11, Length = 25, DockID = 2 },
            new Slip { SlipId = 66, Width = 12, Length = 27, DockID = 1 },
            new Slip { SlipId = 67, Width = 8, Length = 19, DockID = 3 },
            new Slip { SlipId = 68, Width = 10, Length = 22, DockID = 2 },
            new Slip { SlipId = 69, Width = 9, Length = 21, DockID = 1 },
            new Slip { SlipId = 70, Width = 11, Length = 30, DockID = 3 },
            new Slip { SlipId = 71, Width = 12, Length = 26, DockID = 1 },
            new Slip { SlipId = 72, Width = 8, Length = 28, DockID = 2 },
            new Slip { SlipId = 73, Width = 10, Length = 30, DockID = 3 },
            new Slip { SlipId = 74, Width = 9, Length = 27, DockID = 1 },
            new Slip { SlipId = 75, Width = 11, Length = 22, DockID = 2 },
            new Slip { SlipId = 76, Width = 12, Length = 23, DockID = 3 },
            new Slip { SlipId = 77, Width = 8, Length = 30, DockID = 1 },
            new Slip { SlipId = 78, Width = 10, Length = 26, DockID = 2 },
            new Slip { SlipId = 79, Width = 9, Length = 20, DockID = 3 },
            new Slip { SlipId = 80, Width = 11, Length = 29, DockID = 1 },
            new Slip { SlipId = 81, Width = 12, Length = 24, DockID = 3 },
            new Slip { SlipId = 82, Width = 8, Length = 22, DockID = 2 },
            new Slip { SlipId = 83, Width = 10, Length = 25, DockID = 1 },
            new Slip { SlipId = 84, Width = 9, Length = 18, DockID = 3 },
            new Slip { SlipId = 85, Width = 11, Length = 21, DockID = 2 },
            new Slip { SlipId = 86, Width = 12, Length = 28, DockID = 1 },
            new Slip { SlipId = 87, Width = 8, Length = 19, DockID = 3 },
            new Slip { SlipId = 88, Width = 10, Length = 27, DockID = 2 },
            new Slip { SlipId = 89, Width = 9, Length = 23, DockID = 1 },
            new Slip { SlipId = 90, Width = 10, Length = 23, DockID = 3 }



            );
            modelBuilder.Entity<Dock>().HasData(
                new Dock { DockId = 1, Name = "Seabreeze Cove", WaterService = true, ElectricalService = true },
                new Dock { DockId = 2, Name = "Sunset Haven", WaterService = true, ElectricalService = false },
                new Dock { DockId = 3, Name = "Whispering Pines", WaterService = false, ElectricalService = false }
                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Smith", Phone = "3234567890", City = "Los Angeles" },
                new Customer { CustomerId = 2, FirstName = "Emily", LastName = "Johnson", Phone = "4152345678", City = "San Francisco" },
                new Customer { CustomerId = 3, FirstName = "David", LastName = "Brown", Phone = "8581234567", City = "San Diego" },
                new Customer { CustomerId = 4, FirstName = "Jessica", LastName = "Davis", Phone = "9162345678", City = "Sacramento" },
                new Customer { CustomerId = 5, FirstName = "Michael", LastName = "Miller", Phone = "5593456789", City = "Fresno" },
                new Customer { CustomerId = 6, FirstName = "Sarah", LastName = "Wilson", Phone = "6022345678", City = "Phoenix" },
                new Customer { CustomerId = 7, FirstName = "Daniel", LastName = "Moore", Phone = "5203456789", City = "Tucson" },
                new Customer { CustomerId = 8, FirstName = "Olivia", LastName = "Taylor", Phone = "4804567890", City = "Mesa" },
                new Customer { CustomerId = 9, FirstName = "Matthew", LastName = "Anderson", Phone = "4805678901", City = "Chandler" },
                new Customer { CustomerId = 10, FirstName = "Sophia", LastName = "Thomas", Phone = "6026789012", City = "Scottsdale" },
                new Customer { CustomerId = 11, FirstName = "James", LastName = "Jackson", Phone = "7027890123", City = "Las Vegas" },
                new Customer { CustomerId = 12, FirstName = "Isabella", LastName = "White", Phone = "7758901234", City = "Reno" },
                new Customer { CustomerId = 13, FirstName = "Alexander", LastName = "Harris", Phone = "7029012345", City = "Henderson" },
                new Customer { CustomerId = 14, FirstName = "Ava", LastName = "Martin", Phone = "7752345678", City = "Carson City" },
                new Customer { CustomerId = 15, FirstName = "Ethan", LastName = "Garcia", Phone = "7023456789", City = "Elko" },
                new Customer { CustomerId = 16, FirstName = "Charlotte", LastName = "Lee", Phone = "8012345678", City = "Salt Lake City" },
                new Customer { CustomerId = 17, FirstName = "Henry", LastName = "Perez", Phone = "3853456789", City = "Provo" },
                new Customer { CustomerId = 18, FirstName = "Amelia", LastName = "Martinez", Phone = "8014567890", City = "Ogden" },
                new Customer { CustomerId = 19, FirstName = "Benjamin", LastName = "Rodriguez", Phone = "4355678901", City = "St. George" },
                new Customer { CustomerId = 20, FirstName = "Grace", LastName = "Gonzalez", Phone = "3856789012", City = "West Valley City" }
              );
            modelBuilder.Entity<Lease>().HasData(
                new Lease { LeaseId = 1, SlipID = 53, CustomerID = 1 },
                new Lease { LeaseId = 2, SlipID = 18, CustomerID = 2 },
                new Lease { LeaseId = 3, SlipID = 72, CustomerID = 3 },
                new Lease { LeaseId = 4, SlipID = 4, CustomerID = 4 },
                new Lease { LeaseId = 5, SlipID = 64, CustomerID = 5 },
                new Lease { LeaseId = 6, SlipID = 10, CustomerID = 6 },
                new Lease { LeaseId = 7, SlipID = 81, CustomerID = 7 },
                new Lease { LeaseId = 8, SlipID = 30, CustomerID = 8 },
                new Lease { LeaseId = 9, SlipID = 5, CustomerID = 9 },
                new Lease { LeaseId = 10, SlipID = 37, CustomerID = 10 },
                new Lease { LeaseId = 11, SlipID = 56, CustomerID = 11 },
                new Lease { LeaseId = 12, SlipID = 68, CustomerID = 12 },
                new Lease { LeaseId = 13, SlipID = 22, CustomerID = 13 },
                new Lease { LeaseId = 14, SlipID = 89, CustomerID = 14 },
                new Lease { LeaseId = 15, SlipID = 44, CustomerID = 15 },
                new Lease { LeaseId = 16, SlipID = 12, CustomerID = 16 },
                new Lease { LeaseId = 17, SlipID = 79, CustomerID = 17 },
                new Lease { LeaseId = 18, SlipID = 29, CustomerID = 18 },
                new Lease { LeaseId = 19, SlipID = 60, CustomerID = 19 },
                new Lease { LeaseId = 20, SlipID = 14, CustomerID = 20 });
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    CustomerId = 1,
                    UserName = "jsmith",
                    Email = "john.smith@example.com",
                    NormalizedEmail = "JOHN.SMITH@EXAMPLE.COM",
                    NormalizedUserName = "JSMITH",
                    PasswordHash = hasher.HashPassword(null, "password"),  
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "John"
                },
                new User
                {
                    CustomerId = 2,
                    UserName = "ejohnson",
                    Email = "emily.johnson@example.com",
                    NormalizedEmail = "EMILY.JOHNSON@EXAMPLE.COM",
                    NormalizedUserName = "EJOHNSON",
                    PasswordHash = hasher.HashPassword(null, "password"), 
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Emily"
                },
                new User
                {
                    CustomerId = 3,
                    UserName = "dbrown",
                    Email = "david.brown@example.com",
                    NormalizedEmail = "DAVID.BROWN@EXAMPLE.COM",
                    NormalizedUserName = "DBROWN",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "David"
                },
                new User
                {
                    CustomerId = 4,
                    UserName = "jdavis",
                    Email = "jessica.davis@example.com",
                    NormalizedEmail = "JESSICA.DAVIS@EXAMPLE.COM",
                    NormalizedUserName = "JDAVIS",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Jessica"
                },
                new User
                {
                    CustomerId = 5,
                    UserName = "mmiller",
                    Email = "michael.miller@example.com",
                    NormalizedEmail = "MICHAEL.MILLER@EXAMPLE.COM",
                    NormalizedUserName = "MMILLER",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Michael"
                },
                new User
                {
                    CustomerId = 6,
                    UserName = "swilson",
                    Email = "sarah.wilson@example.com",
                    NormalizedEmail = "SARAH.WILSON@EXAMPLE.COM",
                    NormalizedUserName = "SWILSON",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Sarah"
                },
                new User
                {
                    CustomerId = 7,
                    UserName = "dmoore",
                    Email = "daniel.moore@example.com",
                    NormalizedEmail = "DANIEL.MOORE@EXAMPLE.COM",
                    NormalizedUserName = "DMOORE",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Daniel"
                },
                new User
                {
                    CustomerId = 8,
                    UserName = "otaylor",
                    Email = "olivia.taylor@example.com",
                    NormalizedEmail = "OLIVIA.TAYLOR@EXAMPLE.COM",
                    NormalizedUserName = "OTAYLOR",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Olivia"
                },
                new User
                {
                    CustomerId = 9,
                    UserName = "manderson",
                    Email = "matthew.anderson@example.com",
                    NormalizedEmail = "MATTHEW.ANDERSON@EXAMPLE.COM",
                    NormalizedUserName = "MANDERSON",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Matthew"
                },
                new User
                {
                    CustomerId = 10,
                    UserName = "sthomas",
                    Email = "sophia.thomas@example.com",
                    NormalizedEmail = "SOPHIA.THOMAS@EXAMPLE.COM",
                    NormalizedUserName = "STHOMAS",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Sophia"
                },
                new User
                {
                    CustomerId = 11,
                    UserName = "jjackson",
                    Email = "james.jackson@example.com",
                    NormalizedEmail = "JAMES.JACKSON@EXAMPLE.COM",
                    NormalizedUserName = "JJACKSON",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "James"
                },
                new User
                {
                    CustomerId = 12,
                    UserName = "iwhite",
                    Email = "isabella.white@example.com",
                    NormalizedEmail = "ISABELLA.WHITE@EXAMPLE.COM",
                    NormalizedUserName = "IWHITE",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Isabella"
                },
                new User
                {
                    CustomerId = 13,
                    UserName = "aharris",
                    Email = "alexander.harris@example.com",
                    NormalizedEmail = "ALEXANDER.HARRIS@EXAMPLE.COM",
                    NormalizedUserName = "AHARRIS",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Alexander"
                },
                new User
                {
                    CustomerId = 14,
                    UserName = "amartin",
                    Email = "ava.martin@example.com",
                    NormalizedEmail = "AVA.MARTIN@EXAMPLE.COM",
                    NormalizedUserName = "AMARTIN",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Ava"
                },
                new User
                {
                    CustomerId = 15,
                    UserName = "egarcia",
                    Email = "ethan.garcia@example.com",
                    NormalizedEmail = "ETHAN.GARCIA@EXAMPLE.COM",
                    NormalizedUserName = "EGARCIA",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Ethan"
                },
                new User
                {
                    CustomerId = 16,
                    UserName = "clee",
                    Email = "charlotte.lee@example.com",
                    NormalizedEmail = "CHARLOTTE.LEE@EXAMPLE.COM",
                    NormalizedUserName = "CLEE",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Charlotte"
                },
                new User
                {
                    CustomerId = 17,
                    UserName = "hperez",
                    Email = "henry.perez@example.com",
                    NormalizedEmail = "HENRY.PEREZ@EXAMPLE.COM",
                    NormalizedUserName = "HPEREZ",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Henry"
                },
                new User
                {
                    CustomerId = 18,
                    UserName = "amartinez",
                    Email = "amelia.martinez@example.com",
                    NormalizedEmail = "AMELIA.MARTINEZ@EXAMPLE.COM",
                    NormalizedUserName = "AMARTINEZ",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Amelia"
                },
                new User
                {
                    CustomerId = 19,
                    UserName = "brodriguez",
                    Email = "benjamin.rodriguez@example.com",
                    NormalizedEmail = "BENJAMIN.RODRIGUEZ@EXAMPLE.COM",
                    NormalizedUserName = "BRODRIGUEZ",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Benjamin"
                },
                new User
                {
                    CustomerId = 20,
                    UserName = "ggonzalez",
                    Email = "grace.gonzalez@example.com",
                    NormalizedEmail = "GRACE.GONZALEZ@EXAMPLE.COM",
                    NormalizedUserName = "GGONZALEZ",
                    PasswordHash = hasher.HashPassword(null, "password"),
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    Name = "Grace"
                }

                );

            
        }
        

    }
}
