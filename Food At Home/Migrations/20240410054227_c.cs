using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                column: "ConcurrencyStamp",
                value: "bb0479bf-e8bd-41db-81cd-0752186029c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "3a973225-4c93-4e6c-9bfb-327e4c5363c8", "RADOSTIN1@ABV.BG", "RADOSTIN1", "AQAAAAEAACcQAAAAEKSrkP2giLR9DH+sv/phWLvQ33kO3SPqd6r1CgzEN1fI3wsjNv19G+TNVzK5WVND5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                column: "ConcurrencyStamp",
                value: "996015ce-17a9-4f95-ae6c-403e9bdd34c7");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                column: "ConcurrencyStamp",
                value: "04293b5b-77b7-4570-afdc-a9b0256ca93c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "bbbd2e4e-cacf-4a94-8462-b8ecfb0843cd", null, null, "AQAAAAEAACcQAAAAEF5JJpJB/79TWvoDwpBqYna49nJLd0DHT9BnklvoIYsu2kQYakNbYxyctIDaDfuiMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                column: "ConcurrencyStamp",
                value: "a85eaa8f-315f-4e01-ad59-39b47712889a");
        }
    }
}
