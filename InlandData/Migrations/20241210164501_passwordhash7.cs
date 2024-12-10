using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class passwordhash7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "c449d541-de94-4d8f-a278-4b72de547380");

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30ff5eca-3487-4613-8f7e-d0ea373688d2", 0, "d646d522-2a5f-4fd0-ae09-c936d44c0091", null, false, false, null, null, "MYUSER", "AQAAAAIAAYagAAAAEEAQLDoUuon5XME6MjR4NSeMJ7fcAC25Uig0cuqMs66+uQ2v6hWo3BXIheRxlTbW3g==", null, false, "4a86c67c-f10a-426b-a8ed-ba96b83cf739", false, "myuser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityUser",
                keyColumn: "Id",
                keyValue: "30ff5eca-3487-4613-8f7e-d0ea373688d2");

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c449d541-de94-4d8f-a278-4b72de547380", 0, "41f0a546-a53b-4d6c-aa75-96f62803dcaa", null, false, false, null, null, "user", "AQAAAAIAAYagAAAAENoRwjSv6hVGHMVGjXG/4GZv8X8cx06rGjQp5ubw0gGndiM7SJUCvO/FhVTW5U1oJw==", null, false, "bf791a02-48e4-4ec7-b3df-3d81c0cf0f60", false, "myuser" });
        }
    }
}
