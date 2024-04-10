using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"), "1186889d-4081-423f-825f-7cdf52e4fd4b", "Administrator", null },
                    { new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"), "ea997571-2363-461f-9351-67db047964f5", "Restaurant", null },
                    { new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"), "33728ee2-7d21-4eb3-8350-0b17e7c0b774", "Customer", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                column: "ConcurrencyStamp",
                value: "193a8b4e-6ae0-43b7-a0df-507fb35a169d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "516a59f9-bcf5-4067-9630-f6e4476095e5", "AQAAAAEAACcQAAAAEM719sKI7G0zteVwt3hraSgXRcymj+GQkMJ4eORmHi9uFdTtzkKrazUSlcrkd2C59g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                column: "ConcurrencyStamp",
                value: "5c31340b-f44e-4a22-9e67-45aadfd769a5");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5c769ba4-1b92-496d-b18d-2bbde73e6ba1"), "Desserts" },
                    { new Guid("87f0373e-6d3d-468d-8989-9894937d6517"), "Burgers" },
                    { new Guid("adf04d8f-4d96-4180-a7cd-19053a23bc81"), "Salads" },
                    { new Guid("c0a8af9e-feaf-46d6-92e7-5f44592947e0"), "Drinks" },
                    { new Guid("cbc7df0c-83f8-4ccd-acc8-d0bea62d0b33"), "Pizzas" },
                    { new Guid("e4f042b4-52d4-43fc-bfb2-53102b11b719"), "Appetizers" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { new Guid("5646fe32-cf59-45db-b27d-9ddb76d0b8d6"), new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d") });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Description", "UserId" },
                values: new object[] { new Guid("ce604d6e-1a66-4059-9777-388cbc34ef84"), "Welcome to Food At Home! Where every meal is a journey of flavors and every moment is savored. We're delighted to have you dine with us today. Sit back, relax, and get ready to indulge in culinary delights crafted just for you. Enjoy your time with us!", new Guid("b7892962-0426-48de-bd62-8ca55ebe930e") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"), new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"), new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"), new Guid("b7892962-0426-48de-bd62-8ca55ebe930e") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"), new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"), new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"), new Guid("b7892962-0426-48de-bd62-8ca55ebe930e") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5c769ba4-1b92-496d-b18d-2bbde73e6ba1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87f0373e-6d3d-468d-8989-9894937d6517"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("adf04d8f-4d96-4180-a7cd-19053a23bc81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0a8af9e-feaf-46d6-92e7-5f44592947e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbc7df0c-83f8-4ccd-acc8-d0bea62d0b33"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4f042b4-52d4-43fc-bfb2-53102b11b719"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("5646fe32-cf59-45db-b27d-9ddb76d0b8d6"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("ce604d6e-1a66-4059-9777-388cbc34ef84"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                column: "ConcurrencyStamp",
                value: "8cbca5a1-653e-40b2-b210-332d9c1a0823");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "791db434-e156-44dd-bc9b-4ec4eadb331e", "AQAAAAEAACcQAAAAEE7ZeqXvjciNIjPqm0n9woW8UYzZr4keEirTDLHYMZb/HC5rOOWlqAH8TDkfH5jE/Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                column: "ConcurrencyStamp",
                value: "21adaad6-26ab-484c-ba25-3faa289e789c");
        }
    }
}
