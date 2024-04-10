using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "f2a302cf-1a21-4168-b602-fa2e8e3a9198");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "052e58e6-f72a-4564-a025-7e6affe00f1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "a05bea05-7ded-4720-b07f-700465f3fe9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4a2458-063a-42d3-bee9-4778ec33f6e4", "AQAAAAEAACcQAAAAEKNsIG8YKwxxN3/ajkqIb9O1oIFCvv8wAvw3y7KY/OODMvnhYoXDqGZqUAiRB0R7Hw==", "1c125e5b-3286-43a2-bad5-dd773b987157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a28ca661-79df-4cba-8252-10d31d4ed2fe", "AQAAAAEAACcQAAAAEPBzdKaN7UW/PMidbVlnGAbjxGYr7kpNTd98N4uMmzU09Tl2avuPF36cl5uScm8UHw==", "d5c99742-edc8-4778-8b24-c6cbf2902028" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c666a9-fc0e-4fb0-a14a-95a378ed0bf4", "AQAAAAEAACcQAAAAEA5USRPe5yJATSXGHWp9Xv2x3EiW+wKEdzwAPknlcINdhUdGcebAbbhpJYFzHSMQZA==", "69784f2d-22a5-4e3b-ace8-5fefba7b704b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db37c85a-14ff-4c72-b340-7c98409f47be", "AQAAAAEAACcQAAAAEFUl6x/cSFln15FwAz7Bfy3+u24nL8jS1qhg4nfRpbqcRKqBDesA8Baad0rHCb+vbw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0378873-dec1-465c-816b-de9a40c8b98b", "AQAAAAEAACcQAAAAEEo4MC9p9jN1q4B8A5e3qWYuFkUP/ItKDWCQqLRDBUqa031PvrLtjmpgHwJLwGenuw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "851a617c-3274-422d-aa4f-58007b2a1297", "AQAAAAEAACcQAAAAEJ/M3myWCzmi/+M61A1QY1nJBPC6eyW2GdLI42ZFrsEYGxXjGQS9S1WVXC0NOva/9Q==", null });
        }
    }
}
