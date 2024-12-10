using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class passwordhashWORKING : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40b5a06d-5458-40ed-91c2-ee7aeb031f8a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "033232da-53a4-4ed6-a6d1-7258af3945bf", 0, "3040cbe7-c8b3-45f3-93d0-76d53d2e5184", 10, "sophia.thomas@example.com", false, false, null, "Sophia", "SOPHIA.THOMAS@EXAMPLE.COM", "STHOMAS", "AQAAAAIAAYagAAAAECFORr0oM/BccuQHBw8vBzQFRXuQM04x0Resw92EamVxiZm8OdnxjRYge0H3vL0U2w==", null, false, "3aae9e41-e1b1-446f-9faf-91a76abea5b8", false, "sthomas" },
                    { "09880720-e2a6-41ea-9769-5695ec6e3531", 0, "f20ddd2e-0305-4133-ac72-b1cb4abc92c9", 7, "daniel.moore@example.com", false, false, null, "Daniel", "DANIEL.MOORE@EXAMPLE.COM", "DMOORE", "AQAAAAIAAYagAAAAECXwzgeZzRpP4IVuVfYxETAJa3adsLCcQ3JjkyLBHvO6qKxMpe2NiO+4e8+NfC7PzA==", null, false, "51e7b09a-f2c3-4290-b808-731b292cef3b", false, "dmoore" },
                    { "16e8180d-333e-43f1-9b2f-e91127368319", 0, "32d5948f-19fb-49f6-9738-a43c6cacbe3c", 11, "james.jackson@example.com", false, false, null, "James", "JAMES.JACKSON@EXAMPLE.COM", "JJACKSON", "AQAAAAIAAYagAAAAEJA8i+BP/94iYEqSN5ptNj+HBIB3o5eOaZfUEnUTfBAj9IXbG6OYcyBeZKkW2GqhLA==", null, false, "55f93303-cf45-4784-9c59-8e10efd1347c", false, "jjackson" },
                    { "1a10b869-5e07-419b-bbc4-572a05609c82", 0, "7b9009c3-9ab9-492b-a884-1355962536e8", 2, "emily.johnson@example.com", false, false, null, "Emily", "EMILY.JOHNSON@EXAMPLE.COM", "EJOHNSON", "AQAAAAIAAYagAAAAEOMJ75D/ZQBPein7rB2WlqztLIXt0KIy5oLLEB46BHWwyvjpb3YL2pLwj3LcdywRIQ==", null, false, "1ab103c3-0ad8-4130-b127-f1db4c9cbc13", false, "ejohnson" },
                    { "284eddde-05c5-4166-8bb8-ce18722d65d4", 0, "285f07d3-dd4d-4d83-b23f-e712250cfaa0", 8, "olivia.taylor@example.com", false, false, null, "Olivia", "OLIVIA.TAYLOR@EXAMPLE.COM", "OTAYLOR", "AQAAAAIAAYagAAAAEJgqVxlqEna+P1Axkv+0/MWLp+aRbZAWK2CdT79kRBgAdw2xOPLgj2mZra8M4nDEeA==", null, false, "4616768f-9871-4563-b420-d95d1f1cd924", false, "otaylor" },
                    { "4112b632-8ef3-4b20-a7a3-f6b5f1e9242b", 0, "3c62da64-924d-4cc8-b06a-0d123fae61ef", 1, "john.smith@example.com", false, false, null, "John", "JOHN.SMITH@EXAMPLE.COM", "JSMITH", "AQAAAAIAAYagAAAAEJjHgDbTfcybNwH5w3dLuSyqHhsVWviVT0Y1wB54lwqFBJnDfhiBUGVv3hAulqJyZg==", null, false, "37401a44-7433-4e98-9d1c-61331951fe58", false, "jsmith" },
                    { "56ca84ad-d7cb-45f9-b1f8-1a59ca18a539", 0, "04d7f2c6-440c-41f3-8773-23976ba17ad2", 4, "jessica.davis@example.com", false, false, null, "Jessica", "JESSICA.DAVIS@EXAMPLE.COM", "JDAVIS", "AQAAAAIAAYagAAAAEAZ4EB6XALOjWfrYlJH21xCdVoOsHOgYp8LyUGJCT4LrUe3vWBSjAJT/td2mgAX5fQ==", null, false, "a58ad333-9a14-4e50-b9aa-562c39cc5ab1", false, "jdavis" },
                    { "673fcf96-9c04-45fb-a7fd-3fe6aa2c95be", 0, "699d386e-7efc-4937-8f2c-f24ef3c46d69", 6, "sarah.wilson@example.com", false, false, null, "Sarah", "SARAH.WILSON@EXAMPLE.COM", "SWILSON", "AQAAAAIAAYagAAAAEPo0fJUN7mlFMCgbGSruJDFhf+JPhQhF7ITp4KrH6jZjllzViIxr7kkLO5sSQUwgzw==", null, false, "427173fc-74d5-44de-9f01-0aba57526a12", false, "swilson" },
                    { "6f58d4e4-88a2-4ded-8a53-1131454091b8", 0, "e6e8df43-4056-4524-b703-eeb73532f42d", 3, "david.brown@example.com", false, false, null, "David", "DAVID.BROWN@EXAMPLE.COM", "DBROWN", "AQAAAAIAAYagAAAAEJw/IHBLtdFKfU2vawkngG8xea/OHq6hI3jP9QyRSrhdUN24LBbq0FfImj1e2q/znQ==", null, false, "da767232-7551-4605-9c2c-4b1104ea876d", false, "dbrown" },
                    { "767b3711-2f2a-4403-830f-329e515e23d3", 0, "8bb30c1b-7bd3-4702-9e30-1f989c51958c", 18, "amelia.martinez@example.com", false, false, null, "Amelia", "AMELIA.MARTINEZ@EXAMPLE.COM", "AMARTINEZ", "AQAAAAIAAYagAAAAEH6dn48GHStPm0ePv54NpZlgqip+EiHlwsgHtUkTFnKcFSL91ijsJ3RavrBwA1K+1g==", null, false, "bd9ce58b-2057-4722-b3c9-3a94e2c8c97a", false, "amartinez" },
                    { "7be9bbcf-904b-44f0-aa14-36a8a2b28d92", 0, "d3876f22-301f-40e7-901b-4a901f79ff98", 20, "grace.gonzalez@example.com", false, false, null, "Grace", "GRACE.GONZALEZ@EXAMPLE.COM", "GGONZALEZ", "AQAAAAIAAYagAAAAEIG+0ILWQQ0WezQLfeJx7oCwJLwvS+knT8SVyv1aZ2vkm3ad70YE1zQPmMC6vhUwfg==", null, false, "b7f504cf-a4c6-4c68-8b9d-60e35ef067d4", false, "ggonzalez" },
                    { "85e74e1f-c541-4377-8139-3dbe31ad2a41", 0, "d768ea17-b5c1-4083-8142-28f2445c3aed", 9, "matthew.anderson@example.com", false, false, null, "Matthew", "MATTHEW.ANDERSON@EXAMPLE.COM", "MANDERSON", "AQAAAAIAAYagAAAAEGZhTP5sTlNWlcyR2iagkph4BIIRDw2DqAtNd9P0Jnbxa186dXLrbbubdKtTWPJQkw==", null, false, "de961959-27fc-4d97-b909-21f2edb2e6fe", false, "manderson" },
                    { "8beb493e-bd3e-4819-b37d-711805cddec8", 0, "c723c01d-b2b0-4460-9a9f-407571f71fa6", 5, "michael.miller@example.com", false, false, null, "Michael", "MICHAEL.MILLER@EXAMPLE.COM", "MMILLER", "AQAAAAIAAYagAAAAEJzXosAFcy8VzbpoKDLcoxotiiiavKmTx7cBTJeo5eOMUfuLdkupR+HO+5UjOPKBPA==", null, false, "0821489b-e959-48f5-b3c7-5cd08b28c5de", false, "mmiller" },
                    { "8f19fe98-7536-4570-9f94-52cf3dc20bb2", 0, "dc6a2e8a-2915-4106-9a32-1c8c2f709a97", 14, "ava.martin@example.com", false, false, null, "Ava", "AVA.MARTIN@EXAMPLE.COM", "AMARTIN", "AQAAAAIAAYagAAAAEKyBKfSry13Idw9dTeYeqQzcQYe/fEI36Fy57k0WRlYnb+Z3Ny7QKMLwZT19wBEAmg==", null, false, "608f564e-9d58-4ed4-9d5f-a37407f071cd", false, "amartin" },
                    { "ad1eb3c9-c4e2-4ec7-86e2-e99137cfb798", 0, "3b2b6de7-e810-491f-9179-acd04b1a078d", 19, "benjamin.rodriguez@example.com", false, false, null, "Benjamin", "BENJAMIN.RODRIGUEZ@EXAMPLE.COM", "BRODRIGUEZ", "AQAAAAIAAYagAAAAEG8k0VwElBp/7fqTIEa/Ftc8CqbS7P8efQSGQy0JLAVxuXnpFWQIpdrG2l9QxnNHrw==", null, false, "ff10934f-4cde-41be-bdec-6d94457d846a", false, "brodriguez" },
                    { "c07b4d5b-b43a-457b-96f4-a92be7915783", 0, "2ddd4859-a080-49f1-8b43-9fcaa2ffb906", 15, "ethan.garcia@example.com", false, false, null, "Ethan", "ETHAN.GARCIA@EXAMPLE.COM", "EGARCIA", "AQAAAAIAAYagAAAAELGFGC1ZoMwU3QZxFIhKjmw+wfVxyZAZYkRnPJuU1hPxyGGTWh9LmSE0eGG8SPEEXg==", null, false, "de235558-c340-455e-b36f-694a9b329a09", false, "egarcia" },
                    { "c820326d-adfb-4af1-be2a-794b563e762b", 0, "71f7d61c-fc92-4b26-8a2f-d096c01b2c9e", 16, "charlotte.lee@example.com", false, false, null, "Charlotte", "CHARLOTTE.LEE@EXAMPLE.COM", "CLEE", "AQAAAAIAAYagAAAAEINCDMwDsmsp4ftNEO0HEjwXr3zXSi1dUIvL2GMiSidwx4oMoy9Ap+CDTX6ST7ehow==", null, false, "14a38108-66aa-47df-b382-af5b37e68a3e", false, "clee" },
                    { "e12fab42-ae1b-4ad9-80d9-eb8d6ef4febd", 0, "97f9a6f7-8f89-4b79-aeae-1155d73a1077", 17, "henry.perez@example.com", false, false, null, "Henry", "HENRY.PEREZ@EXAMPLE.COM", "HPEREZ", "AQAAAAIAAYagAAAAEBgAszzG871MPOqwUkIOcg8YQGZFTQTv0+4BpBOtZk0BjZ5AEChPvE51+uLfGGgkAQ==", null, false, "c51f8b43-efff-4444-baf6-abab4fab33fd", false, "hperez" },
                    { "fa339531-c611-4e74-b1fe-c5f85dd52a07", 0, "e278c0de-a46a-4a8e-9be6-10b341228e39", 12, "isabella.white@example.com", false, false, null, "Isabella", "ISABELLA.WHITE@EXAMPLE.COM", "IWHITE", "AQAAAAIAAYagAAAAEHKNJQc2dBe608CvuA72fCeo55QN5CDG3pYYFHqpqjQ4VIeLRiiJJnjrrjacFJo/sA==", null, false, "41efe645-58dc-4c2e-94b7-adc0f2316ded", false, "iwhite" },
                    { "fb83a918-4380-4a80-aa42-d40362c7dc32", 0, "03866c2d-58a1-4f2a-a972-07fc005f6de4", 13, "alexander.harris@example.com", false, false, null, "Alexander", "ALEXANDER.HARRIS@EXAMPLE.COM", "AHARRIS", "AQAAAAIAAYagAAAAEEnFkeetMfqZkY2KT98R9ZqlE7t/xY7HBqZEongLYSr9u5kCWqr+9HQx7M/NvWOkkA==", null, false, "6e1ddbc7-d4bf-4349-87b9-921911ea8aef", false, "aharris" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "033232da-53a4-4ed6-a6d1-7258af3945bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09880720-e2a6-41ea-9769-5695ec6e3531");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16e8180d-333e-43f1-9b2f-e91127368319");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a10b869-5e07-419b-bbc4-572a05609c82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "284eddde-05c5-4166-8bb8-ce18722d65d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4112b632-8ef3-4b20-a7a3-f6b5f1e9242b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56ca84ad-d7cb-45f9-b1f8-1a59ca18a539");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673fcf96-9c04-45fb-a7fd-3fe6aa2c95be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f58d4e4-88a2-4ded-8a53-1131454091b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "767b3711-2f2a-4403-830f-329e515e23d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7be9bbcf-904b-44f0-aa14-36a8a2b28d92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85e74e1f-c541-4377-8139-3dbe31ad2a41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8beb493e-bd3e-4819-b37d-711805cddec8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f19fe98-7536-4570-9f94-52cf3dc20bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad1eb3c9-c4e2-4ec7-86e2-e99137cfb798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c07b4d5b-b43a-457b-96f4-a92be7915783");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c820326d-adfb-4af1-be2a-794b563e762b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e12fab42-ae1b-4ad9-80d9-eb8d6ef4febd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa339531-c611-4e74-b1fe-c5f85dd52a07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb83a918-4380-4a80-aa42-d40362c7dc32");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40b5a06d-5458-40ed-91c2-ee7aeb031f8a", 0, "5df93454-97dc-4fab-931a-abf2f9d567d4", 1, "john.smith@example.com", false, false, null, "John", "JOHN.SMITH@EXAMPLE.COM", "JSMITH", "AQAAAAIAAYagAAAAEKJmxAbf6dZ9djyECGY2OUCZziJ6vkC3Y94FWfy/U33tbu48l72lrJCo1M8arHQG1Q==", null, false, "43208948-1a9f-4ee4-bfbd-d4a370221e20", false, "jsmith" });
        }
    }
}
