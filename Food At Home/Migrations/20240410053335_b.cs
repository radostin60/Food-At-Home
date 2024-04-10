using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"), 0, "6-ti Septemvri 9", "Kazanlak", "04293b5b-77b7-4570-afdc-a9b0256ca93c", "admin@abv.bg", false, "", false, null, "Admin Account", null, null, null, "0891231234", false, null, false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"), 0, "Mazalat 16", "Kazanlak", "bbbd2e4e-cacf-4a94-8462-b8ecfb0843cd", "radostin1@abv.bg", false, "", false, null, "Radostin Dimitrov", null, null, "AQAAAAEAACcQAAAAEF5JJpJB/79TWvoDwpBqYna49nJLd0DHT9BnklvoIYsu2kQYakNbYxyctIDaDfuiMg==", "0877311440", false, null, false, "radostin1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "ImageUrl", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"), 0, "Al. Batenberg 46", "Kazanlak", "a85eaa8f-315f-4e01-ad59-39b47712889a", "dominos@abv.bg", false, "", false, null, "Domino's Pizza", null, null, null, "0882759837", false, null, false, "dominos" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"));
        }
    }
}
