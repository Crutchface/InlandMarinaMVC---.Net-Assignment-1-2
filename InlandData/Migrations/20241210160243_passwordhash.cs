using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InlandData.Migrations
{
    /// <inheritdoc />
    public partial class passwordhash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08795fa6-e5ae-438d-bf53-5a4a45b7016c", 0, "f267327c-6c14-405e-9a67-c2d92103cb5d", 5, "michael.miller@example.com", false, false, null, "Michael", null, null, "AQAAAAIAAYagAAAAEEqbV+yA01ZkP0wF2Rroq4Af0DB3+y8ANe9vrKytsMO1slJ1TSILULV93UfPn/LO2g==", null, false, "d26ee039-9450-49b0-b16f-ccdd4e0722ce", false, "mmiller" },
                    { "1fc678a8-9a11-49fa-8dbe-28e11e35d64a", 0, "2d7db6df-6613-48c7-8ae7-8b62cae0454e", 17, "henry.perez@example.com", false, false, null, "Henry", null, null, "AQAAAAIAAYagAAAAEKqgw0z8fGnNTKGfa31K1MjFtYs2Tnk0W1IHuy+2dH1iqPseq0WkSkURWFzc/mzddQ==", null, false, "1ea8c2d9-5aa1-4b60-9805-8a54bf5394f6", false, "hperez" },
                    { "2327a8cf-c3b0-42e9-b5f1-145b2f7d5183", 0, "5c628c0a-f4ed-4c17-b889-2e80b573eca8", 6, "sarah.wilson@example.com", false, false, null, "Sarah", null, null, "AQAAAAIAAYagAAAAEAIcFY9cqYbR15l3GUrMO3+wqvUYOpvYX7oI9KfmbEVGCit8ckJdgy7Ik4Zy+WR7EQ==", null, false, "7dbe21ff-6c69-49c3-9a2b-6df81a7fdd66", false, "swilson" },
                    { "286c5c67-0a7f-42cf-a648-39970132204d", 0, "ce154034-52c5-49ac-a31c-a8ede197c9ab", 16, "charlotte.lee@example.com", false, false, null, "Charlotte", null, null, "AQAAAAIAAYagAAAAEGcxWWkIW3IOvHMf9khqA9aVXbTKS0nAxLrqRrsz4LKhugGG3BrhWUM5Ho0mE4eOPA==", null, false, "e9280e49-3f6f-4a35-82e8-282981d4ff2e", false, "clee" },
                    { "35a7e77a-10d6-4999-9ce8-f0372b1b2d16", 0, "8be007ac-1ddf-4290-9623-64352230b2c3", 18, "amelia.martinez@example.com", false, false, null, "Amelia", null, null, "AQAAAAIAAYagAAAAEIHFnTIr2838BKxTw9jTmtUEoGKOLjC68bowWcwyjDFESVNb/zlVG6SW8aSfx2FRmQ==", null, false, "ad260aeb-9df7-4934-b9c5-4649574ad332", false, "amartinez" },
                    { "55f5e059-97a3-48a1-819b-4a5701f4912d", 0, "2578fe47-5e0e-41d5-96bd-afbf4016a9cc", 3, "david.brown@example.com", false, false, null, "David", null, null, "AQAAAAIAAYagAAAAEGcuCLGot+Czzg4XbZ/2sQMp+pvjzLG8m4DLWpJ/Pmc+n0Cq9Wgji7ew1wtl8HMbHA==", null, false, "7470a9d1-d333-4311-a2ff-0aa7f308fea1", false, "dbrown" },
                    { "668d8ffa-6837-4970-ace1-618a0f3feaf8", 0, "f415799c-ff9a-4658-a872-2edb8f19d500", 1, "john.smith@example.com", false, false, null, "John", null, null, "AQAAAAIAAYagAAAAEORQDvGy35ac7HFQ6tvbGZCHL1mOh+ejD84yyfzCZLFI0BXKEvShtvyteYZ/M/JfMg==", null, false, "0e68cdc0-a2f9-40fe-80f2-b4a635d35f19", false, "jsmith" },
                    { "786740e1-690a-4f19-a1b6-d6990c80a3b2", 0, "6d7973ef-2d41-4e81-9e22-d3d57f7b123d", 12, "isabella.white@example.com", false, false, null, "Isabella", null, null, "AQAAAAIAAYagAAAAEAJWdgiJSdwn+BV7JZj5YekX9yS669mG/lN9f5vtdMoWyQgnJktUd4/6+iAmJYuDTA==", null, false, "75d51e14-ed93-481c-89fd-5adff1826e5a", false, "iwhite" },
                    { "9a418441-fa2d-44f4-89ca-a47b24b35cce", 0, "4834f869-9d47-40d1-95c0-fca687a9c55c", 11, "james.jackson@example.com", false, false, null, "James", null, null, "AQAAAAIAAYagAAAAEHMoq60ua8Pi3gYXkDOJW3JkhC0JO75MmVd1FnuZF/bszPOtMJ12YvHUMd3kANllOA==", null, false, "aa2f494e-2d19-4f0f-b319-6b4eb1088b17", false, "jjackson" },
                    { "9b9bf6b2-825a-4e12-9e68-876fd578b738", 0, "37b4d1c7-aec7-43f9-869b-9bd08e077826", 20, "grace.gonzalez@example.com", false, false, null, "Grace", null, null, "AQAAAAIAAYagAAAAEEjUfI5Zn3VAS7FqbaaCgZdZu2wRp7qAC9DOaFC5cJsGr4iMBVuy3JCV6glp7UOlwA==", null, false, "cdfdd5be-8bcc-4324-8f29-f03f9f31fecf", false, "ggonzalez" },
                    { "9ef75725-ffa7-4bc4-8b4e-26581446b14d", 0, "f59a003f-602e-4eed-9e26-5bf7782ee304", 19, "benjamin.rodriguez@example.com", false, false, null, "Benjamin", null, null, "AQAAAAIAAYagAAAAEIILdf4p2ZuIXFJKVPlj85ScpkqFkQHDUe+OSGhlVnOZf+S6VAF+RQJLXIzQ6uJNHw==", null, false, "4e823924-86ac-4bed-9c32-9558c4d9cd01", false, "brodriguez" },
                    { "aad70a27-5e4e-4516-9324-8dac02c618f7", 0, "c3c97010-6730-4592-81b9-0ebe8faa106e", 9, "matthew.anderson@example.com", false, false, null, "Matthew", null, null, "AQAAAAIAAYagAAAAEH7fTi+wmEH55GVG5giPkOa4rbtrs+Aka0fPIA5m9goX6ket6cHoAC8ShXJHmM0Kfw==", null, false, "842e71c6-f220-45c4-a426-5aa8b6f93bb2", false, "manderson" },
                    { "c504379b-8e1c-4443-83e5-f19b8f4fdba2", 0, "384a750c-3380-44fc-8c3f-cc0b48ae8886", 14, "ava.martin@example.com", false, false, null, "Ava", null, null, "AQAAAAIAAYagAAAAEFByTygG6GfA3pBcTuuIaKLre3rKDgIG1lKkAQ7u3WOHK812lqHkpIgsPorxtxDMNA==", null, false, "dcde6787-2c6f-4c88-9dc1-b3b8b5aef49d", false, "amartin" },
                    { "e3a27c42-a9dd-438b-b117-8ef2493e3b7f", 0, "6441c280-3d3f-4af0-9bc4-df4a69744d01", 13, "alexander.harris@example.com", false, false, null, "Alexander", null, null, "AQAAAAIAAYagAAAAEJ2V3/1C9Wj6m7EO7/RI9JtK2kh+CwnxyV4XK2fXiqCp0BG0LkYa+V1Kn6LfpoJGww==", null, false, "554f6514-414e-40a7-94ff-47ba2702d2ff", false, "aharris" },
                    { "e7217dfe-1667-44d6-8e11-e829c24dcc81", 0, "8605a2fa-410d-488c-8255-62a42ff3b78e", 15, "ethan.garcia@example.com", false, false, null, "Ethan", null, null, "AQAAAAIAAYagAAAAEFSI4VJ8PB0E96vRLOkaILNPG8cOm5CBi1Hd5H0WbSqN7uDHHBwmlYXsLQSp811Prw==", null, false, "afadc483-0263-484f-ba06-d1cd3e8cc213", false, "egarcia" },
                    { "e8009958-3a93-468f-a849-a28150572364", 0, "16112c77-c553-45a1-8ebe-50c9be9faf5a", 2, "emily.johnson@example.com", false, false, null, "Emily", null, null, "AQAAAAIAAYagAAAAEL6NM8zKFKTNmz2wptJNtCVS+Og3mbB7QOFUWhlj1ZP2C6OrUuH1/ruOAgJIqeYr/Q==", null, false, "aa8b68f6-fed1-48c1-a1b6-afe17ba75479", false, "ejohnson" },
                    { "e9a34fa1-3c77-4c5c-967d-348d26f5bf85", 0, "453dbac5-a569-41b9-9989-7ed894b04b3c", 4, "jessica.davis@example.com", false, false, null, "Jessica", null, null, "AQAAAAIAAYagAAAAEEgKVwAsKedUsjddcs/QmbTsxVgWG3c77BAvUOFQ97P7iKhIwYL2Vm9W+EgIt87AKw==", null, false, "31c5c9fd-5dd0-4f75-9ae8-4cd7ce1b9a91", false, "jdavis" },
                    { "ecae28de-9686-41a4-8353-5496c4224fe7", 0, "38d6aac3-d3da-441b-8780-c7680b1d1d1a", 8, "olivia.taylor@example.com", false, false, null, "Olivia", null, null, "AQAAAAIAAYagAAAAEO0b7P4X1aWUZrz+Z2AoGFVMagU/VFP8VSqCyHQTBD9hQsV8EohAB7OfOitE30M9Pg==", null, false, "a8675ca7-9f8c-46c4-9dec-a946461e5161", false, "otaylor" },
                    { "ecd0e713-76c4-496c-a08c-997c37e880da", 0, "2f1efd36-e06a-450b-ba75-0e45df1ad49f", 10, "sophia.thomas@example.com", false, false, null, "Sophia", null, null, "AQAAAAIAAYagAAAAENyYVdmX6F2nFHacg/hAPg2TL/Jqz6Q3SmLxcWcopE/G3dJPfsQE0T1z9W1QqF9zUQ==", null, false, "6aeb0249-038a-4c9c-ade2-f75e6b007a7c", false, "sthomas" },
                    { "edda3054-b347-4f23-9fb6-39ecd06b1bfb", 0, "58709e6f-1934-40b2-bf8c-8b1901ed0b74", 7, "daniel.moore@example.com", false, false, null, "Daniel", null, null, "AQAAAAIAAYagAAAAECKm/67+NDevNE6OqDR9x24YSThcPTzuIGB7R95YyUbeU5chEG67tCuWgK82DiHQ3g==", null, false, "adf578e7-a170-44ff-9bdb-915307df46a2", false, "dmoore" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08795fa6-e5ae-438d-bf53-5a4a45b7016c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fc678a8-9a11-49fa-8dbe-28e11e35d64a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2327a8cf-c3b0-42e9-b5f1-145b2f7d5183");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "286c5c67-0a7f-42cf-a648-39970132204d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35a7e77a-10d6-4999-9ce8-f0372b1b2d16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55f5e059-97a3-48a1-819b-4a5701f4912d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "668d8ffa-6837-4970-ace1-618a0f3feaf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "786740e1-690a-4f19-a1b6-d6990c80a3b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a418441-fa2d-44f4-89ca-a47b24b35cce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b9bf6b2-825a-4e12-9e68-876fd578b738");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef75725-ffa7-4bc4-8b4e-26581446b14d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aad70a27-5e4e-4516-9324-8dac02c618f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c504379b-8e1c-4443-83e5-f19b8f4fdba2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3a27c42-a9dd-438b-b117-8ef2493e3b7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7217dfe-1667-44d6-8e11-e829c24dcc81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8009958-3a93-468f-a849-a28150572364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9a34fa1-3c77-4c5c-967d-348d26f5bf85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecae28de-9686-41a4-8353-5496c4224fe7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd0e713-76c4-496c-a08c-997c37e880da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edda3054-b347-4f23-9fb6-39ecd06b1bfb");

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
    }
}
