using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryTime",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "424073ec-cce4-45b2-8856-58d0b8641001");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "94eda508-3251-477f-a97a-f499d690c70e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "851b611d-e418-4a86-b5cf-9486a46b201f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef7a649-058b-4474-95a2-caf8a03a6a7a", "AQAAAAEAACcQAAAAEFZZZfCKzpGHQQ7y+0eVFxmWcnlWFUlispPdbSqZZ76Gt/BodtntdSY7hy9pfCGClQ==", "b62f3b62-df5f-4bb5-a1d9-c8d11804ffb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "817ebba9-47ef-4b4f-b62a-537054e77f1b", "AQAAAAEAACcQAAAAEDrq8g25Oj8icAVe6eLbh8yA0ec5hwQt7NLR0WyQ/Nj0oCxtGAOvzNvGoX1LCFJQLQ==", "dcb96768-9f7e-4220-ac8a-7913b4bd3c4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e82eb3d0-23df-473d-ba00-8f0daa191fce", "AQAAAAEAACcQAAAAEEhE7wulXsHTmlYRUqocBymZWK9hqL9AjXV0OMzpB/VABV1vuNzIyoGavrZShPKmIA==", "9d7b7b20-8810-4bd6-a0e6-2d4cce5d8b86" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeliveryTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1e1fd1db-4ee5-4933-a51a-ead302e6db41"),
                column: "ConcurrencyStamp",
                value: "b704107a-4814-4056-b396-cc1d1f93b088");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5534ff36-7149-4ffa-8581-16958c5f7d22"),
                column: "ConcurrencyStamp",
                value: "453e49bd-bd66-4721-ac60-15eb1f1e1c4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d7a6c5ef-dbd7-4e21-bafc-258257e0894f"),
                column: "ConcurrencyStamp",
                value: "e81424c1-ce33-4928-8e7b-d556a2dc8e8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1188c17d-0b5b-4041-90eb-6f1bdfbc6d71"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9e5cbe-4a30-417a-af70-f8cb2a074754", "AQAAAAEAACcQAAAAEJdAm/SGW5ZEIQ7N5YrMAkfO3gxDKjdoF0zfX8JTG8y6v7MLAehi8DvgwwgSs4xKiw==", "89bd1f7c-3028-4e93-b58b-087a07bd607c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bcc98c-0b7b-4ea1-8168-e8d4fb6873c9", "AQAAAAEAACcQAAAAEK6mYFNs2Rbko0aRMZvRncahSrEWttYcALBxz7ysTFt/wUN3+lRxxg7PW2O441wmIg==", "86214b0d-8c94-4c2b-85eb-6c1599bb40e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eaebd4d-a5af-41c7-8c4f-78338788c9be", "AQAAAAEAACcQAAAAEAi5h5PeuF87ZgSdr95AAhhmtNsnAPVQrLfHAs7AcvJBvCvMoxNR8j85HPlfa2e6Xg==", "6ef37edb-c9dd-4a48-9ebe-50f2f05272c3" });
        }
    }
}
