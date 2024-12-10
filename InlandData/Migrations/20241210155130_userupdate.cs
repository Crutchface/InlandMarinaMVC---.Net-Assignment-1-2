using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class userupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15155303-bb15-4b21-828c-65407c841d62", 0, "4ea2f9db-57c5-4254-852a-47bc9791500c", 1, "john.smith@example.com", false, false, null, "John", null, null, null, null, false, "765a9181-db9a-4655-931a-cb4e91d17d08", false, "jsmith" },
                    { "1f646737-ac3c-4ea4-80fb-dffabf30a19f", 0, "b128cf6c-93d6-4cba-af81-17734ec76ea5", 9, "matthew.anderson@example.com", false, false, null, "Matthew", null, null, null, null, false, "085cce92-3314-43b2-b665-30922e2712a8", false, "manderson" },
                    { "28d3c894-d86b-41df-8935-f067f8061d5d", 0, "11f4b94b-b2a2-4983-aeb8-9d800e2a265b", 8, "olivia.taylor@example.com", false, false, null, "Olivia", null, null, null, null, false, "dda6a04d-aecc-4b08-b55c-a8beeb94f088", false, "otaylor" },
                    { "2a2c5fde-37c7-4a95-b4c0-8c5b47097e43", 0, "6b72c1ba-2983-4401-a03c-1937c47b86ae", 2, "emily.johnson@example.com", false, false, null, "Emily", null, null, null, null, false, "bad02565-08fb-4dfe-841d-e7fe5523808a", false, "ejohnson" },
                    { "2c7e5729-5f2c-4e40-a282-0871ee094391", 0, "1a9c3c89-b470-4d53-8c2a-43052c42bda0", 14, "ava.martin@example.com", false, false, null, "Ava", null, null, null, null, false, "ca0b1811-4849-4a4a-a1d4-f301c044ffc1", false, "amartin" },
                    { "34a2c9e3-bb6f-4338-b6b3-a3fb2831b9c8", 0, "a128ddd9-800a-4a5a-8eb8-39b90afba851", 16, "charlotte.lee@example.com", false, false, null, "Charlotte", null, null, null, null, false, "e10a0f05-530e-4b7b-ae03-1466e69e53d2", false, "clee" },
                    { "549b7d49-9ee6-4ec5-8811-d203ba2b6f74", 0, "9024c307-d010-4baa-bb45-5518c468671f", 13, "alexander.harris@example.com", false, false, null, "Alexander", null, null, null, null, false, "adc72c1d-8a36-49c5-b572-47c270cd86a3", false, "aharris" },
                    { "629156f6-a47f-4b80-a6b6-8dcb5532b181", 0, "a6e1c9f7-445b-4c23-80c5-038b2fa76907", 10, "sophia.thomas@example.com", false, false, null, "Sophia", null, null, null, null, false, "e54b4159-b623-4dcb-9103-a9b498c38b31", false, "sthomas" },
                    { "725a7aa2-ae98-4e52-bf62-c97549449d11", 0, "4e676d77-cce5-45cf-ad34-27e6d81c4b4b", 19, "benjamin.rodriguez@example.com", false, false, null, "Benjamin", null, null, null, null, false, "906d40b4-86fe-4865-8c98-872da1123a3f", false, "brodriguez" },
                    { "78cd20c5-1de4-446a-92e2-1004598205cf", 0, "9bb5cd33-4656-4863-8472-0479f8795676", 7, "daniel.moore@example.com", false, false, null, "Daniel", null, null, null, null, false, "e1ea7409-c940-499b-98fd-1f221526728a", false, "dmoore" },
                    { "80dc85e3-5c5b-48eb-8184-9c68fec4eb57", 0, "507a6ced-6ca4-42a2-98b9-091f1c94c39d", 17, "henry.perez@example.com", false, false, null, "Henry", null, null, null, null, false, "0f7ee790-655f-4b54-9603-1372fc4ee9e7", false, "hperez" },
                    { "8cf2cb9b-6847-4bf1-9399-8b78e2078c6d", 0, "dbc30159-e01f-4006-9ae0-3c0238bf9bea", 20, "grace.gonzalez@example.com", false, false, null, "Grace", null, null, null, null, false, "725dfdc0-58c7-4c49-823d-4ce319aea895", false, "ggonzalez" },
                    { "91f9394a-34b6-4298-abad-9a5a341bc484", 0, "7ddb15fb-f309-4a8b-b646-8f2ed918b79e", 5, "michael.miller@example.com", false, false, null, "Michael", null, null, null, null, false, "49d52978-8672-44da-b48d-6606e5045d38", false, "mmiller" },
                    { "9a37ff54-91ea-4b74-9aeb-600c3a579349", 0, "bc5b226e-3ee5-4556-80ef-d2528fd73f46", 12, "isabella.white@example.com", false, false, null, "Isabella", null, null, null, null, false, "7863a020-c0dd-47be-8815-49b33bbdfcea", false, "iwhite" },
                    { "c28b17dd-403f-4e28-bb5c-26d5680d6489", 0, "f6f4aba1-2628-4875-90ba-421845e8b588", 3, "david.brown@example.com", false, false, null, "David", null, null, null, null, false, "d8c28468-e014-4dac-b505-d055e0cdc8d5", false, "dbrown" },
                    { "d536d3ff-b371-42e2-93bb-c6890bba0bcc", 0, "01f6938e-a637-463b-a58f-66260b7ca498", 4, "jessica.davis@example.com", false, false, null, "Jessica", null, null, null, null, false, "758850bf-0922-43fe-b1b6-05f323be396c", false, "jdavis" },
                    { "dea7d498-61a0-49d9-b9c1-7a9f48ba2cc2", 0, "d31ca0e0-c85c-4c93-b71e-77d88c27c8fc", 15, "ethan.garcia@example.com", false, false, null, "Ethan", null, null, null, null, false, "32ac9e6e-32f0-4e5b-b093-93e3784d990c", false, "egarcia" },
                    { "e243be8d-d507-460f-a528-c0490d2641d8", 0, "f2b8aec8-75eb-4ae7-af3c-f93a68329bd2", 11, "james.jackson@example.com", false, false, null, "James", null, null, null, null, false, "3e73842c-85f1-480c-aec1-173af6480738", false, "jjackson" },
                    { "ecd337d3-6778-46a6-9d46-c0ba1ebc2b1f", 0, "e4976387-38cc-4ffd-9e71-484eead4ba4d", 6, "sarah.wilson@example.com", false, false, null, "Sarah", null, null, null, null, false, "2f11512a-9b88-4d21-9d8b-770be87c4bc5", false, "swilson" },
                    { "f04471d5-168c-4771-a661-634df2d41de8", 0, "c1b9e9e4-f42c-4780-9c0a-8c6bfb54bde2", 18, "amelia.martinez@example.com", false, false, null, "Amelia", null, null, null, null, false, "f19dcbc5-47f4-46b1-8b54-81ebbe2da41c", false, "amartinez" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15155303-bb15-4b21-828c-65407c841d62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f646737-ac3c-4ea4-80fb-dffabf30a19f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28d3c894-d86b-41df-8935-f067f8061d5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a2c5fde-37c7-4a95-b4c0-8c5b47097e43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c7e5729-5f2c-4e40-a282-0871ee094391");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34a2c9e3-bb6f-4338-b6b3-a3fb2831b9c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "549b7d49-9ee6-4ec5-8811-d203ba2b6f74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "629156f6-a47f-4b80-a6b6-8dcb5532b181");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "725a7aa2-ae98-4e52-bf62-c97549449d11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78cd20c5-1de4-446a-92e2-1004598205cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80dc85e3-5c5b-48eb-8184-9c68fec4eb57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cf2cb9b-6847-4bf1-9399-8b78e2078c6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91f9394a-34b6-4298-abad-9a5a341bc484");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a37ff54-91ea-4b74-9aeb-600c3a579349");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c28b17dd-403f-4e28-bb5c-26d5680d6489");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d536d3ff-b371-42e2-93bb-c6890bba0bcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea7d498-61a0-49d9-b9c1-7a9f48ba2cc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e243be8d-d507-460f-a528-c0490d2641d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd337d3-6778-46a6-9d46-c0ba1ebc2b1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f04471d5-168c-4771-a661-634df2d41de8");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
