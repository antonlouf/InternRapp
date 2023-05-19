using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("399b9b58-685e-44c8-822d-605f99095415"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("ceca9388-f3eb-4dc0-92f9-4a179d99a90b"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("9d05477f-d5ee-48f2-aefe-f9e0a601dd8a"));

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolYear",
                value: "2023-2024");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolYear",
                value: "2021-2022");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                column: "SchoolYear",
                value: "2022-2023");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                column: "SchoolYear",
                value: "2022-2023");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                column: "SchoolYear",
                value: "2023-2024");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                column: "SchoolYear",
                value: "2021-2022");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                column: "SchoolYear",
                value: "2023-2024");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("aaf5a015-661c-44e7-b150-3779997a4fb6"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("dc742509-0fe6-4c57-8dd5-ffb8889badf9"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("65d35426-9103-4ada-b5d8-9794f3ca494b"));

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolYear",
                value: "2021-2022");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolYear",
                value: "2023-2024");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                column: "SchoolYear",
                value: "2023-2024");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                column: "SchoolYear",
                value: "2021-2022");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                column: "SchoolYear",
                value: "2022-2023");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                column: "SchoolYear",
                value: "2023-2024");

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                column: "SchoolYear",
                value: "2021-2022");
        }
    }
}
