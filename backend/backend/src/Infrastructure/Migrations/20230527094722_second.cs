using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_ObjectIdentifier",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "ObjectIdentifier",
                table: "ApplicationUsers");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "ApplicationUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1465), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1471), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1473), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1573), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1940), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1951), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1963), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2012), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2023), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2463), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2473), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2588), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2598), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2608), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2820), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2826), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2858), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2864), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2898), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2904), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2911), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1568), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1938), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2011), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2011), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2127), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2462), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2462), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2587), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2812), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2812), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2851), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2898), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2897), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1455), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1457), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1458), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1460), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1449), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1452), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1454), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2938), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2970), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2978), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2985), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2991), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2998), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3005), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3011), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3017), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1904), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1977), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2106), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2314), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2531), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2554), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2833), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2841), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2871), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2878), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2886), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2918), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2918) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "ApplicationUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "ObjectIdentifier",
                table: "ApplicationUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1285), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1289), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1291), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1423), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1816), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2104), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2216), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2240), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2245), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2250), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2337), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2343), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2407), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2413), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2418), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2437), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2443), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2449), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2475), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2486), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2520), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2553), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2560), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1421), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1421), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2087), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2087), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2159), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2207), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2239), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2277), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2277), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2407), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2406), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2437), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2436), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2474), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2474), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2520), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2519), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1273), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1275), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1276), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1277), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1268), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2590), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2601), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2607), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2612), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2618), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2624), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2635), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2640), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2002), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2228), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2257), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2264), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2350), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2387), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2395), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2426), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2455), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2463), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2493), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2500), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2508), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 5, 26, 13, 45, 42, 593, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_ObjectIdentifier",
                table: "ApplicationUsers",
                column: "ObjectIdentifier");
        }
    }
}
