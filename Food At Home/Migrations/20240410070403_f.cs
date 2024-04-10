using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class f : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "10e0e91a-b2ca-4705-ad59-e3875e9083c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "c742b7ed-c7e0-4060-a4fb-3eb510657084");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "bf23fd8a-31e8-44ab-9f3e-d47d8e28ce32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db37c85a-14ff-4c72-b340-7c98409f47be", "AQAAAAEAACcQAAAAEFUl6x/cSFln15FwAz7Bfy3+u24nL8jS1qhg4nfRpbqcRKqBDesA8Baad0rHCb+vbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0378873-dec1-465c-816b-de9a40c8b98b", "AQAAAAEAACcQAAAAEEo4MC9p9jN1q4B8A5e3qWYuFkUP/ItKDWCQqLRDBUqa031PvrLtjmpgHwJLwGenuw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "851a617c-3274-422d-aa4f-58007b2a1297", "AQAAAAEAACcQAAAAEJ/M3myWCzmi/+M61A1QY1nJBPC6eyW2GdLI42ZFrsEYGxXjGQS9S1WVXC0NOva/9Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "1186889d-4081-423f-825f-7cdf52e4fd4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "ea997571-2363-461f-9351-67db047964f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "33728ee2-7d21-4eb3-8350-0b17e7c0b774");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "193a8b4e-6ae0-43b7-a0df-507fb35a169d", null });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c31340b-f44e-4a22-9e67-45aadfd769a5", null });
        }
    }
}
