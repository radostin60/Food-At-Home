using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "757145ec-04fd-4fcb-ad30-6be2c2f48466");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "c142a203-d5ea-4361-b0bc-0741bad0323c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "be8103e7-bc53-4684-8f48-e4612be62d1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2235698e-751f-4617-88c4-41e532053af1", "AQAAAAEAACcQAAAAEFPgYUZvrt9UM/6kEUnjDxfQqEqV8n7mAD3/z5pTinbZCFvBc4YPCE2nDw4FNbgeIQ==", "a0c4b721-48e5-4066-bb52-982397d3eb41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e15050b-cfa5-43a6-a1fc-5c3a41217326", "AQAAAAEAACcQAAAAEJWa4jPp4JV8RvN4aK6VZXhLyS4kYUDhOY9aDdjdurY6Py9c/OkiGkzx2o0uGlsH1Q==", "2f1e6502-0963-407c-9da2-6bf57c831fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec51d394-0833-4dc3-b77e-8c2d3d676d33", "AQAAAAEAACcQAAAAEM7tHZ2nw7agrvxhPe+0MDYMJ1aeqZqNk+nu/GWYR4br1le1JgChTJVhIQYKi0LCnA==", "534276f9-b378-46b5-aa13-ac8e52eda90f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Payments",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "57d6a8ba-f624-44a8-ad30-bc0ff01092d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "3e7d64d8-a2a8-479c-a985-6acb9e3cdc37");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "178f906e-0d4b-4fdf-93f5-efc722efc73b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a08dd00f-c126-48c9-a54d-5492cf11a20b", "AQAAAAEAACcQAAAAEJN6EjhfZBGmOJp3+CEZF7pzTiAKCZ6rhlZv5h0sG+zW3kReBbosR4owlMe6TLKAqA==", "8bcd7f3d-4767-4a23-86b3-405ccfd2a355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac8c6835-9bee-4533-a23f-48832e168d13", "AQAAAAEAACcQAAAAEIt1l548cz99ym0EQN3wfkX1c6PIzG6e0DxvpvbWye0Gc1DunEKy7eV4Fw4tTz38ug==", "328dc6fb-4fac-4fa4-88bc-956bf21c442c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd9e9428-015a-4b25-b6fe-78e54d3db512", "AQAAAAEAACcQAAAAEK1nwFbU7X6qdLofnLGTcr84GqkWdpeHsXebtWohfkI8YRb6Vv7Btywv4gSGZ/QDXw==", "95af92fb-0595-46af-ad06-0ebd9af7d744" });
        }
    }
}
