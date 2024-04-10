using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "04b1872e-28d5-47ad-985e-f0c4c455f9b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "cd2c92f2-8353-41df-bdbd-64d117ec7575");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "85e5dbb3-a61c-40b7-aab0-f49fda927577");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78180099-afdc-4b02-8700-2da3996a2cc5", "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712767540/k1i32lmyp6du5abwwyot.jpg", "AQAAAAEAACcQAAAAEHhIc4955XlZc18798zhGpqYArZ+JsJ/+jwdcoAsumSf8JXk0AfYetIBk+YDDZ+JoQ==", "97347b38-e98a-4f4c-8496-5de23fd17cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab30c4ec-2629-46e3-a4fb-6b1a95e8c5f8", "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712767712/xlnkbydge1fm49l1lvto.jpg", "AQAAAAEAACcQAAAAEFKrUUS/UYjQ4L9w5CYZuk6VBnI6Ei5g9jN9654vWAFQYuUpQt4489c+USZb1AdaAA==", "ea7a490d-12a9-4c04-a205-87609a0856d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49e8eb3-2884-4b34-b1a6-aeaa533e2ddd", "https://res.cloudinary.com/dqtuni8ed/image/upload/v1712766785/cu4hlsiiqarbuiejvc5g.png", "AQAAAAEAACcQAAAAEMK3n8SnkDPOGie3I0IWXiiP739fFI3gv7zgnDJ3iiuEzbhpB3RTVd6MTDy9M+NlBQ==", "5bc1d2e7-bf6e-4428-a280-154ae89e21f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "2025b82f-4c32-4b33-8798-58e4c5e59fd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "498d41e0-f73b-4e23-9afd-11c8517f6b28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "7d3d883d-acf4-46eb-9a70-6ac4cb530a58");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c6916d2-26f7-49d4-9f2b-7bcbae29f99a", "", "AQAAAAEAACcQAAAAEHEDdTX8zh+B/oUJZbPkRxf+4DBXkImuMZsDMDgxbhxr4h3Q6NeWYu3Xm/DgJKlUMQ==", "26f993b0-e84e-48a2-a774-b45f3dda7942" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af654062-8efd-4131-a082-5a1807af911b", "", "AQAAAAEAACcQAAAAEPoDcqsSVJZ/y+vSG2CnLz4pphF0wqOnjkOJIyeIoofmLtJFLb0AkBl4m78OkRTBxg==", "4b5dbe23-4c52-495e-af2f-8ca56a158a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "ImageUrl", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c95221d9-accd-4ce8-99e8-041715d30a65", "", "AQAAAAEAACcQAAAAEB3aVMx7Z3s2icIcJoFVV5kXeyF3Cf3dU/4cEX3UwTRn9lZLDho9ebHQGxC4ZI/pUw==", "db159ed6-65ca-4562-9134-22a4a17c82a7" });
        }
    }
}
