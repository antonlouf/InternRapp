using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(22), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(25), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(133), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(147), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(153), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(322), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(355), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(388), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(394), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(400), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(436), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(467), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(472), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(478), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(586), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(593), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(600), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(637), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(643), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(666), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(671), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(677), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(707), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(770), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(776), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(781), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(130), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(129), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(315), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(387), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(387), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(435), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(435), "2023-2024" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(466), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(466), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(505), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(505), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(636), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(665), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(769), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(17), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(811), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(822), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(827), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(833), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(838), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(844), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(282), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(364), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(374), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(408), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(415), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(423), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(455), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(485), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(492), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(608), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(624), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(655), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(683), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(718), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(788) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "ApplicationUsers");

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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(1938) });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2181), "2023-2024" });

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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2812), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2852), new DateTime(2023, 5, 27, 9, 47, 22, 191, DateTimeKind.Utc).AddTicks(2851) });

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
    }
}
