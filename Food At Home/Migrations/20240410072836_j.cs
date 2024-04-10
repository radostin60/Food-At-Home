using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class j : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "2025b82f-4c32-4b33-8798-58e4c5e59fd6", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "498d41e0-f73b-4e23-9afd-11c8517f6b28", "RESTAURANT" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "7d3d883d-acf4-46eb-9a70-6ac4cb530a58", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6916d2-26f7-49d4-9f2b-7bcbae29f99a", "AQAAAAEAACcQAAAAEHEDdTX8zh+B/oUJZbPkRxf+4DBXkImuMZsDMDgxbhxr4h3Q6NeWYu3Xm/DgJKlUMQ==", "26f993b0-e84e-48a2-a774-b45f3dda7942" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af654062-8efd-4131-a082-5a1807af911b", "AQAAAAEAACcQAAAAEPoDcqsSVJZ/y+vSG2CnLz4pphF0wqOnjkOJIyeIoofmLtJFLb0AkBl4m78OkRTBxg==", "4b5dbe23-4c52-495e-af2f-8ca56a158a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c95221d9-accd-4ce8-99e8-041715d30a65", "AQAAAAEAACcQAAAAEB3aVMx7Z3s2icIcJoFVV5kXeyF3Cf3dU/4cEX3UwTRn9lZLDho9ebHQGxC4ZI/pUw==", "db159ed6-65ca-4562-9134-22a4a17c82a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "1e87fba7-d386-4533-bb47-4d34d15393f2", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "8c05b1d2-734b-4338-8959-7f7a5daf8d28", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "3dc3f85b-4db4-410d-8e3b-54194442376c", null });

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
    }
}
