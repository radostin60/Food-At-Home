using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class h : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "092da816-404a-4b12-a27b-8f939675b854");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "b33eac24-3fb4-4363-a7be-b2fd5c5e5df6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "7aa621bf-12f9-486c-a1b4-61805a610604");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aa81dd4-ce33-4f5b-b9ff-f8728a11cf74", "AQAAAAEAACcQAAAAEKCERA06ELMEYPrQDc2VuSjWkBFyJqhOFVCLyV6Sc0Wok62zoUgWqrgMGm8vV9RI6w==", "8485dd9f-7b52-41ac-b36d-44c04d5b33ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d950e91b-fd0c-4b91-9341-395544b2728a", "AQAAAAEAACcQAAAAEOs25TuP3l8NgdlHkK1M5lcUFkzK/TE1x1lgcZyHzNVvs4Y89kGGHnEgCF4LyRrnkg==", "f7126964-ac7f-46b2-ac09-d184fa262059" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59644cb6-9d3d-47bb-bafb-ffbaa05b1156", "AQAAAAEAACcQAAAAEE86NAYtz9lw2QAiOx3cZIjYJvBpQx36UaOfyr03dHEWGg0Urf4YJ5ep3y1946vRDA==", "88a7f3be-ef2d-4cc1-9b0a-9f6ad1cc1feb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
