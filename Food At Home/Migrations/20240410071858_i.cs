using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class i : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "1e87fba7-d386-4533-bb47-4d34d15393f2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "8c05b1d2-734b-4338-8959-7f7a5daf8d28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "3dc3f85b-4db4-410d-8e3b-54194442376c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca027abb-28bb-4a90-8501-15b96c3172f2", "AQAAAAEAACcQAAAAEBrNwXo1+ZGmKmF7CdrjCavHpgxWGjc8Wqnfok0EUiJKFOJV865CVpqF+A6A5gTjgw==", "66942fd9-f47f-4335-848c-5714e4f35bbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e578cd40-26fc-4e8b-b5d7-88f30fd83460", "AQAAAAEAACcQAAAAEEso3NuESgVMepyZ8JdXQk7zfufroBldmuAbS4p1Etw9XbY379uRpGxGbsynwhftRQ==", "966cbbad-decd-4c52-9b38-1c69bdec327a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "925ef142-bd13-4360-9dd0-7119b3d1e659", "AQAAAAEAACcQAAAAEPijrjO/QlwnfDRziaLupGyzxMLkS217hBVYDuXbXu0XOsfPV/gHu813znazfMDflw==", "a3db4397-94f1-4afc-838d-f30f6e2a5413" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

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
    }
}
