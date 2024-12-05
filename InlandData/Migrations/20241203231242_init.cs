using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Docks",
                columns: table => new
                {
                    DockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterService = table.Column<bool>(type: "bit", nullable: false),
                    ElectricalService = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docks", x => x.DockId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                });

            migrationBuilder.CreateTable(
                name: "Slips",
                columns: table => new
                {
                    SlipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DockID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slips", x => x.SlipId);
                    table.ForeignKey(
                        name: "FK_Slips_Docks_DockID",
                        column: x => x.DockID,
                        principalTable: "Docks",
                        principalColumn: "DockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leases",
                columns: table => new
                {
                    LeaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlipID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leases", x => x.LeaseId);
                    table.ForeignKey(
                        name: "FK_Leases_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leases_Slips_SlipID",
                        column: x => x.SlipID,
                        principalTable: "Slips",
                        principalColumn: "SlipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "City", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Los Angeles", "John", "Smith", "3234567890" },
                    { 2, "San Francisco", "Emily", "Johnson", "4152345678" },
                    { 3, "San Diego", "David", "Brown", "8581234567" },
                    { 4, "Sacramento", "Jessica", "Davis", "9162345678" },
                    { 5, "Fresno", "Michael", "Miller", "5593456789" },
                    { 6, "Phoenix", "Sarah", "Wilson", "6022345678" },
                    { 7, "Tucson", "Daniel", "Moore", "5203456789" },
                    { 8, "Mesa", "Olivia", "Taylor", "4804567890" },
                    { 9, "Chandler", "Matthew", "Anderson", "4805678901" },
                    { 10, "Scottsdale", "Sophia", "Thomas", "6026789012" },
                    { 11, "Las Vegas", "James", "Jackson", "7027890123" },
                    { 12, "Reno", "Isabella", "White", "7758901234" },
                    { 13, "Henderson", "Alexander", "Harris", "7029012345" },
                    { 14, "Carson City", "Ava", "Martin", "7752345678" },
                    { 15, "Elko", "Ethan", "Garcia", "7023456789" },
                    { 16, "Salt Lake City", "Charlotte", "Lee", "8012345678" },
                    { 17, "Provo", "Henry", "Perez", "3853456789" },
                    { 18, "Ogden", "Amelia", "Martinez", "8014567890" },
                    { 19, "St. George", "Benjamin", "Rodriguez", "4355678901" },
                    { 20, "West Valley City", "Grace", "Gonzalez", "3856789012" }
                });

            migrationBuilder.InsertData(
                table: "Docks",
                columns: new[] { "DockId", "ElectricalService", "Name", "WaterService" },
                values: new object[,]
                {
                    { 1, true, "Seabreeze Cove", true },
                    { 2, false, "Sunset Haven", true },
                    { 3, false, "Whispering Pines", false }
                });

            migrationBuilder.InsertData(
                table: "Slips",
                columns: new[] { "SlipId", "DockID", "Length", "Width" },
                values: new object[,]
                {
                    { 1, 2, 20m, 9m },
                    { 2, 3, 25m, 12m },
                    { 3, 1, 18m, 8m },
                    { 4, 3, 22m, 10m },
                    { 5, 1, 30m, 12m },
                    { 6, 2, 26m, 11m },
                    { 7, 1, 21m, 9m },
                    { 8, 3, 27m, 11m },
                    { 9, 2, 23m, 10m },
                    { 10, 1, 29m, 9m },
                    { 11, 2, 18m, 8m },
                    { 12, 3, 30m, 12m },
                    { 13, 1, 22m, 9m },
                    { 14, 3, 27m, 11m },
                    { 15, 2, 24m, 10m },
                    { 16, 1, 26m, 9m },
                    { 17, 3, 20m, 8m },
                    { 18, 1, 28m, 12m },
                    { 19, 2, 23m, 10m },
                    { 20, 1, 25m, 11m },
                    { 21, 2, 27m, 12m },
                    { 22, 3, 21m, 9m },
                    { 23, 1, 19m, 8m },
                    { 24, 2, 25m, 10m },
                    { 25, 3, 24m, 11m },
                    { 26, 1, 29m, 12m },
                    { 27, 3, 21m, 8m },
                    { 28, 1, 22m, 10m },
                    { 29, 2, 18m, 9m },
                    { 30, 3, 30m, 11m },
                    { 31, 2, 26m, 12m },
                    { 32, 1, 27m, 10m },
                    { 33, 3, 22m, 8m },
                    { 34, 1, 23m, 9m },
                    { 35, 2, 20m, 11m },
                    { 36, 3, 25m, 8m },
                    { 37, 1, 28m, 10m },
                    { 38, 2, 24m, 12m },
                    { 39, 1, 29m, 9m },
                    { 40, 3, 22m, 11m },
                    { 41, 2, 23m, 12m },
                    { 42, 1, 26m, 10m },
                    { 43, 3, 27m, 8m },
                    { 44, 2, 24m, 9m },
                    { 45, 1, 21m, 11m },
                    { 46, 2, 22m, 12m },
                    { 47, 3, 23m, 8m },
                    { 48, 1, 21m, 10m },
                    { 49, 2, 25m, 9m },
                    { 50, 1, 28m, 11m },
                    { 51, 3, 29m, 12m },
                    { 52, 2, 24m, 8m },
                    { 53, 3, 30m, 10m },
                    { 54, 1, 28m, 9m },
                    { 55, 2, 29m, 11m },
                    { 56, 3, 25m, 12m },
                    { 57, 1, 30m, 8m },
                    { 58, 3, 24m, 10m },
                    { 59, 2, 22m, 9m },
                    { 60, 1, 23m, 11m },
                    { 61, 3, 18m, 12m },
                    { 62, 2, 26m, 8m },
                    { 63, 1, 19m, 10m },
                    { 64, 3, 30m, 9m },
                    { 65, 2, 25m, 11m },
                    { 66, 1, 27m, 12m },
                    { 67, 3, 19m, 8m },
                    { 68, 2, 22m, 10m },
                    { 69, 1, 21m, 9m },
                    { 70, 3, 30m, 11m },
                    { 71, 1, 26m, 12m },
                    { 72, 2, 28m, 8m },
                    { 73, 3, 30m, 10m },
                    { 74, 1, 27m, 9m },
                    { 75, 2, 22m, 11m },
                    { 76, 3, 23m, 12m },
                    { 77, 1, 30m, 8m },
                    { 78, 2, 26m, 10m },
                    { 79, 3, 20m, 9m },
                    { 80, 1, 29m, 11m },
                    { 81, 3, 24m, 12m },
                    { 82, 2, 22m, 8m },
                    { 83, 1, 25m, 10m },
                    { 84, 3, 18m, 9m },
                    { 85, 2, 21m, 11m },
                    { 86, 1, 28m, 12m },
                    { 87, 3, 19m, 8m },
                    { 88, 2, 27m, 10m },
                    { 89, 1, 23m, 9m },
                    { 90, 3, 23m, 10m }
                });

            migrationBuilder.InsertData(
                table: "Leases",
                columns: new[] { "LeaseId", "CustomerID", "SlipID" },
                values: new object[,]
                {
                    { 1, 1, 53 },
                    { 2, 2, 18 },
                    { 3, 3, 72 },
                    { 4, 4, 4 },
                    { 5, 5, 64 },
                    { 6, 6, 10 },
                    { 7, 7, 81 },
                    { 8, 8, 30 },
                    { 9, 9, 5 },
                    { 10, 10, 37 },
                    { 11, 11, 56 },
                    { 12, 12, 68 },
                    { 13, 13, 22 },
                    { 14, 14, 89 },
                    { 15, 15, 44 },
                    { 16, 16, 12 },
                    { 17, 17, 79 },
                    { 18, 18, 29 },
                    { 19, 19, 60 },
                    { 20, 20, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomerId",
                table: "AspNetUsers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Leases_CustomerID",
                table: "Leases",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Leases_SlipID",
                table: "Leases",
                column: "SlipID");

            migrationBuilder.CreateIndex(
                name: "IX_Slips_DockID",
                table: "Slips",
                column: "DockID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Leases");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Slips");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Docks");
        }
    }
}
