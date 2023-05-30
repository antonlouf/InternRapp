using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "InternShips",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1687), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1688), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1880), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2047), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2054), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2061), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2093), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2170), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2229), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2235), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2241), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2270), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2275), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2281), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2398), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2429), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2438), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2449), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2509), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2518), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2528), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1849), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1849), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2047), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2046), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2087), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2164), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2163), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2194), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2193), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2229), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2270), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2269), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2385), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2385), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2428), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2428), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2508), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2508), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1635), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1637), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1639), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1679), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1631), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1634), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "CreatorId", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1635), null, new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2574), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2590), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2600), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2648), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2658), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2668), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2678), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2687), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2697), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2019), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2077), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2118), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2217), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2248), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2254), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2260), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2405), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2412), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 5, 30, 11, 3, 14, 72, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CreatorId",
                table: "Locations",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CreatorId",
                table: "Languages",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_InternShips_CreatorId",
                table: "InternShips",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternShips_ApplicationUsers_CreatorId",
                table: "InternShips",
                column: "CreatorId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_ApplicationUsers_CreatorId",
                table: "Languages",
                column: "CreatorId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_ApplicationUsers_CreatorId",
                table: "Locations",
                column: "CreatorId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternShips_ApplicationUsers_CreatorId",
                table: "InternShips");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_ApplicationUsers_CreatorId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_ApplicationUsers_CreatorId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CreatorId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Languages_CreatorId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_InternShips_CreatorId",
                table: "InternShips");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "InternShips");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7937), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8046), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8221), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8228), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8254), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8259), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8264), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8296), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8301), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8344), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8349), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8355), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8382), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8387), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8394), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8423), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8428), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8433), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8455), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8460), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8506), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8511), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8516), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8554), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8559), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8043), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8213), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8253), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8295), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8295), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8322), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8322), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8381), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8422), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8422), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8450), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8450), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8506), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8505), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8549), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7932), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7926), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7929), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8584), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8593), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8599), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8615), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8626), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8631), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8181), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8235), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8243), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8271), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8278), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8284), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8312), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8362), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8368), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8407), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8412), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8439), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8466), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8473), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8523), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8537), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8566), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8566) });
        }
    }
}
