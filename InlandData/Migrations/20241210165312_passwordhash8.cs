using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class passwordhash8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40b5a06d-5458-40ed-91c2-ee7aeb031f8a", 0, "5df93454-97dc-4fab-931a-abf2f9d567d4", 1, "john.smith@example.com", false, false, null, "John", "JOHN.SMITH@EXAMPLE.COM", "JSMITH", "AQAAAAIAAYagAAAAEKJmxAbf6dZ9djyECGY2OUCZziJ6vkC3Y94FWfy/U33tbu48l72lrJCo1M8arHQG1Q==", null, false, "43208948-1a9f-4ee4-bfbd-d4a370221e20", false, "jsmith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b5a06d-5458-40ed-91c2-ee7aeb031f8a");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30ff5eca-3487-4613-8f7e-d0ea373688d2", 0, "d646d522-2a5f-4fd0-ae09-c936d44c0091", null, false, false, null, null, "MYUSER", "AQAAAAIAAYagAAAAEEAQLDoUuon5XME6MjR4NSeMJ7fcAC25Uig0cuqMs66+uQ2v6hWo3BXIheRxlTbW3g==", null, false, "4a86c67c-f10a-426b-a8ed-ba96b83cf739", false, "myuser" });
        }
    }
}
