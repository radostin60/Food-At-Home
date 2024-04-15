using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class n : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Payments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
