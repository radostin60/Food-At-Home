using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName" },
                values: new object[] { "8cbca5a1-653e-40b2-b210-332d9c1a0823", "ADMIN@ABV.BG", "ADMIN" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName" },
                values: new object[] { "21adaad6-26ab-484c-ba25-3faa289e789c", "DOMINOS@ABV.BG", "DOMINOS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName" },
                values: new object[] { "bb0479bf-e8bd-41db-81cd-0752186029c5", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a973225-4c93-4e6c-9bfb-327e4c5363c8", "AQAAAAEAACcQAAAAEKSrkP2giLR9DH+sv/phWLvQ33kO3SPqd6r1CgzEN1fI3wsjNv19G+TNVzK5WVND5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName" },
                values: new object[] { "996015ce-17a9-4f95-ae6c-403e9bdd34c7", null, null });
        }
    }
}
