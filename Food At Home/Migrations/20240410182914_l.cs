﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_At_Home.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Dishes",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)",
                oldPrecision: 3,
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

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("ce604d6e-1a66-4059-9777-388cbc34ef84"),
                column: "Description",
                value: "Welcome to Dominos Pizza! Where every meal is a journey of flavors and every moment is savored. We're delighted to have you dine with us today.  ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Dishes",
                type: "decimal(3,2)",
                precision: 3,
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78180099-afdc-4b02-8700-2da3996a2cc5", "AQAAAAEAACcQAAAAEHhIc4955XlZc18798zhGpqYArZ+JsJ/+jwdcoAsumSf8JXk0AfYetIBk+YDDZ+JoQ==", "97347b38-e98a-4f4c-8496-5de23fd17cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2341fe11-cd36-40c1-b5e4-5c5831ee501d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab30c4ec-2629-46e3-a4fb-6b1a95e8c5f8", "AQAAAAEAACcQAAAAEFKrUUS/UYjQ4L9w5CYZuk6VBnI6Ei5g9jN9654vWAFQYuUpQt4489c+USZb1AdaAA==", "ea7a490d-12a9-4c04-a205-87609a0856d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b7892962-0426-48de-bd62-8ca55ebe930e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f49e8eb3-2884-4b34-b1a6-aeaa533e2ddd", "AQAAAAEAACcQAAAAEMK3n8SnkDPOGie3I0IWXiiP739fFI3gv7zgnDJ3iiuEzbhpB3RTVd6MTDy9M+NlBQ==", "5bc1d2e7-bf6e-4428-a280-154ae89e21f7" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("ce604d6e-1a66-4059-9777-388cbc34ef84"),
                column: "Description",
                value: "Welcome to Food At Home! Where every meal is a journey of flavors and every moment is savored. We're delighted to have you dine with us today. Sit back, relax, and get ready to indulge in culinary delights crafted just for you. Enjoy your time with us!");
        }
    }
}
