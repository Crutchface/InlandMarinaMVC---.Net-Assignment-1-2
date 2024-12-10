using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class passwordhash6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07028c76-a01b-44cd-97b1-b760129b7dda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d6b8a50-203a-4b2c-bbba-5c8f128a027e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37c12034-5a3f-4738-b15a-70a4e56f51d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46b343ca-86b9-41b9-816a-bcf76f6b755a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "485910b7-b3a0-44ee-a0ef-e20321028cac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5eb8efba-b9dc-4c6e-8b7c-d0fee41964b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "645c5dc9-918e-4600-abbc-f0663e0fd031");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "882f2ef6-9f0b-4646-ab85-0c95753deccb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88c82412-0799-469a-a966-992f000096a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c97ac34-d1ed-4347-bd82-7b8d07278d6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "959b5435-7f99-4d82-bcbc-db9d5cd3bb3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3b2e8e1-a5b7-4395-af16-059556823913");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3cbba68-9b96-4146-b98c-68fc0a7bfc0c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8580ae9-4f2b-4cdb-b03a-bb03766bead9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9241108-2f43-48a6-82a0-088394386cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caadf696-3b02-4bb7-8e0a-1c4df173092d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eec2c354-9f94-407d-90d9-c89d4ba62b5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f40156ea-0482-43a5-8c20-4024d1ff3aa9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faf6ce04-fba6-481b-b8a3-e3f5a4ab7f7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9d07f8-88b7-4554-90ca-3c8a72d31cb9");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c449d541-de94-4d8f-a278-4b72de547380", 0, "41f0a546-a53b-4d6c-aa75-96f62803dcaa", null, false, false, null, null, "user", "AQAAAAIAAYagAAAAENoRwjSv6hVGHMVGjXG/4GZv8X8cx06rGjQp5ubw0gGndiM7SJUCvO/FhVTW5U1oJw==", null, false, "bf791a02-48e4-4ec7-b3df-3d81c0cf0f60", false, "myuser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07028c76-a01b-44cd-97b1-b760129b7dda", 0, "0f5f90dd-a49f-4d29-8cb1-8b581037f3f0", 9, "matthew.anderson@example.com", false, false, null, "Matthew", null, null, "AQAAAAIAAYagAAAAEGMOZUhdqulLZN03Mq9++t2LRQIpja5wy25bDu1YnWyhQWymt46PY5VA3E+D0KSqTA==", null, false, "98b549d0-ff36-4ba6-9f4d-996e34e72857", false, "manderson" },
                    { "2d6b8a50-203a-4b2c-bbba-5c8f128a027e", 0, "e10fba36-ffbc-4ef4-b878-80b6e3b469e1", 2, "emily.johnson@example.com", false, false, null, "Emily", null, null, "AQAAAAIAAYagAAAAEIt2LJhCShohm60N5DZ3307prcWXf2RNMsA0GZkDDt2/Kjcp7mjmUnFBV9wLKZTA1A==", null, false, "1e05c917-4d8d-46e0-965d-960734ee9158", false, "ejohnson" },
                    { "37c12034-5a3f-4738-b15a-70a4e56f51d9", 0, "e2195c9d-f644-4b83-9b8c-8adeecf02ad5", 6, "sarah.wilson@example.com", false, false, null, "Sarah", null, null, "AQAAAAIAAYagAAAAEGK7y77e6l72G2N9N5/lG1k+zD1E58ioEIlj6z2IYrwjp0BaTHTnZVqnFGf/Z2j3PA==", null, false, "a2edaf8b-121a-46d2-86d0-7d32d854ee5c", false, "swilson" },
                    { "46b343ca-86b9-41b9-816a-bcf76f6b755a", 0, "88d44a4d-07be-4b28-928e-7a8a12d5bc94", 14, "ava.martin@example.com", false, false, null, "Ava", null, null, "AQAAAAIAAYagAAAAEKpfvk3vfZN0b54iZX1IPBCwzUA23lZADd6EDmjRflYDE5iQSCQ3iZCmH+QgZNFJFw==", null, false, "976512d2-8c02-475b-8c98-d69a6f00562a", false, "amartin" },
                    { "485910b7-b3a0-44ee-a0ef-e20321028cac", 0, "76d6dc52-6e99-401c-ad7e-3387801776af", 17, "henry.perez@example.com", false, false, null, "Henry", null, null, "AQAAAAIAAYagAAAAENBMSHxFDfFx9o1UFlsagCyOyrVUSJKwrCsFqG9QhTHxUaB5lvUhEzk9McSe2rFFIw==", null, false, "347959d4-f787-453d-97fc-2f6b68054c29", false, "hperez" },
                    { "5eb8efba-b9dc-4c6e-8b7c-d0fee41964b9", 0, "e2f5d1e8-1391-4011-9099-cde282abaf34", 16, "charlotte.lee@example.com", false, false, null, "Charlotte", null, null, "AQAAAAIAAYagAAAAECr+1EfexRfJ0lcsgyvY2OXQMxsN3mQyjYg4lZuD6x+dyrBjBLpQEjlGXqWLH9a5JA==", null, false, "2c9984af-3e47-4a96-802c-774df4deb81d", false, "clee" },
                    { "645c5dc9-918e-4600-abbc-f0663e0fd031", 0, "2df4e48d-ffba-43f2-80f5-a0cb9fef9279", 15, "ethan.garcia@example.com", false, false, null, "Ethan", null, null, "AQAAAAIAAYagAAAAEDVtJs8W45PBhGI3EIyZx5M6tVc/JXYpUq/xu9HTR3nPuMTulxjJXgVzeG7QpOaZ3w==", null, false, "76519e98-8570-4894-85ef-cc375b38cb9c", false, "egarcia" },
                    { "882f2ef6-9f0b-4646-ab85-0c95753deccb", 0, "f79ddfce-e1c6-46b6-98c1-03aa5e900037", 12, "isabella.white@example.com", false, false, null, "Isabella", null, null, "AQAAAAIAAYagAAAAEOa2I86U9xyU5EvNgHhNhMhp4Pr2XpMbL6tCpZQ504HvF1m46YZD8bU6hKHxhm9yLg==", null, false, "6310b4e3-c900-4f55-b79b-50762f9547b4", false, "iwhite" },
                    { "88c82412-0799-469a-a966-992f000096a5", 0, "d922669a-45de-4baf-ac2f-313ef5f97b85", 13, "alexander.harris@example.com", false, false, null, "Alexander", null, null, "AQAAAAIAAYagAAAAEF8pRLsPoYXLgq9pTj9kbeUrpec6BHJKOQ3hPnRLiJQLl2XA3+/yDAs+2exQy3r1Xg==", null, false, "29d8ef72-71f4-40e5-a36f-b60b6d7581d1", false, "aharris" },
                    { "8c97ac34-d1ed-4347-bd82-7b8d07278d6f", 0, "8c961f24-3bbb-4849-b138-90b9cb462dbd", 7, "daniel.moore@example.com", false, false, null, "Daniel", null, null, "AQAAAAIAAYagAAAAEEjU7U2XtGthNDfC/JfNC0J5iJPDOL49FU5slZL1l4gix25RKcpZIv/tqBQqTSsaRQ==", null, false, "beab2b86-a187-4219-8ed0-9509896ec71e", false, "dmoore" },
                    { "959b5435-7f99-4d82-bcbc-db9d5cd3bb3c", 0, "b818c26b-9b86-4cc5-8535-d0e985db3d23", 5, "michael.miller@example.com", false, false, null, "Michael", null, null, "AQAAAAIAAYagAAAAEEWWTcT3zxJrEePLEKvBoZE+cq32i1UDfXJu75fM+duGZUJilTba6+ufDm2dmRbYtA==", null, false, "1ffc5591-9ea5-434f-9c58-c6989b994299", false, "mmiller" },
                    { "b3b2e8e1-a5b7-4395-af16-059556823913", 0, "0e1cdb29-cf58-4d5a-bb6d-d0d63dbc378d", 20, "grace.gonzalez@example.com", false, false, null, "Grace", null, null, "AQAAAAIAAYagAAAAEKelg+UrrpvDtGTNi88mTBfNZ/jSZyu2bWgdw8TUE3YANWyn5MJbt9mWAHE1N0koDQ==", null, false, "d27ccfe6-a644-4c0c-82a1-be08f90513ec", false, "ggonzalez" },
                    { "b3cbba68-9b96-4146-b98c-68fc0a7bfc0c", 0, "6833b36a-5685-4aa1-a164-acdf2e93e5fa", 3, "david.brown@example.com", false, false, null, "David", null, null, "AQAAAAIAAYagAAAAEIqm5HGsXOC16KEIpPlo1VVIVC5NwImnKjVJFekdG9Fz3NUbcfCobhjRrReNct6ypw==", null, false, "0683f04f-fd8e-44bd-83bc-2cb792cb4ccf", false, "dbrown" },
                    { "b8580ae9-4f2b-4cdb-b03a-bb03766bead9", 0, "38d332f2-acef-4d97-9620-2732efd4054f", 19, "benjamin.rodriguez@example.com", false, false, null, "Benjamin", null, null, "AQAAAAIAAYagAAAAEEHTdTp3SSyA8IEEkJPjlST4SKvDqqBHKLTGQZJAoqgC/tOTjtJG0QI6uHSpeCiScA==", null, false, "1c72a523-a5bb-458a-906a-f4f4d7668dcd", false, "brodriguez" },
                    { "c9241108-2f43-48a6-82a0-088394386cd4", 0, "28b497bf-675f-45d9-937c-f8abd12f5e17", 10, "sophia.thomas@example.com", false, false, null, "Sophia", null, null, "AQAAAAIAAYagAAAAEF0L/Xp4zsm70SX5Vb4ozAoSXV+0n1I3qgkBBx0brJLnPxCSDptAuPl1ycJAOc/8MA==", null, false, "61d19bb9-b669-48a6-90ce-851099c51f28", false, "sthomas" },
                    { "caadf696-3b02-4bb7-8e0a-1c4df173092d", 0, "f52d0b25-720f-4831-aeb5-08ebef2cd0d1", 11, "james.jackson@example.com", false, false, null, "James", null, null, "AQAAAAIAAYagAAAAEEej9Gz02ET3DxsrHVqF0OfZCu00/JT9HAfnFMBVwHhGfR62glOp9FFJ7tMP6SxYYQ==", null, false, "a329f47d-4061-4c83-804e-995b17fda1fa", false, "jjackson" },
                    { "eec2c354-9f94-407d-90d9-c89d4ba62b5b", 0, "ffc3f88f-229b-423c-9098-1cb4ca43f13a", 8, "olivia.taylor@example.com", false, false, null, "Olivia", null, null, "AQAAAAIAAYagAAAAEOvycuBuviwQLohF3lxw6E7SH+YbHeDJVrx94ISd9V8Zoc15sj7hR5oSKqT6iWAdng==", null, false, "bd694020-fc72-4f8c-96c6-6a9ba3f46c4e", false, "otaylor" },
                    { "f40156ea-0482-43a5-8c20-4024d1ff3aa9", 0, "f08512ba-d1d5-4199-bde3-b51b2fa600b3", 1, "john.smith@example.com", false, false, null, "John", null, null, "AQAAAAIAAYagAAAAEKkyQcuS6j80MezJuavgHE2eItkN5Oony2eoroVzMs0tPNAt+ivYv52YDrQlB0+kWA==", null, false, "4857bc42-c28e-4640-a9fc-4de267bc5aa0", false, "jsmith" },
                    { "faf6ce04-fba6-481b-b8a3-e3f5a4ab7f7d", 0, "048960d1-ecf5-4d9b-a071-6360db2aac50", 18, "amelia.martinez@example.com", false, false, null, "Amelia", null, null, "AQAAAAIAAYagAAAAEAVyU/YNYsoUIVabvrCKmVW/ATlDotPssq68Apll5RmcwtIZ9gs43Q/748s/MHAcvA==", null, false, "9af8a223-e604-489e-a0f1-6e030e7d3da9", false, "amartinez" },
                    { "fd9d07f8-88b7-4554-90ca-3c8a72d31cb9", 0, "8a4c1458-e3a0-4401-99f8-4196d78b19f3", 4, "jessica.davis@example.com", false, false, null, "Jessica", null, null, "AQAAAAIAAYagAAAAEKXSrXzdrkeiKNhFgBSpjHtTDGu+31jGVecWaCNEU+JHZxIILc5BLZXsc4Pn4vASsg==", null, false, "1da9b1c7-51ee-42b7-9b50-3d52ec68d3f0", false, "jdavis" }
                });
        }
    }
}
