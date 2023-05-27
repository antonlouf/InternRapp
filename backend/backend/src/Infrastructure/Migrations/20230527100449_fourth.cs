using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8213) });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8381), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8381), "2022-2023" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8422), new DateTime(2023, 5, 27, 10, 4, 49, 491, DateTimeKind.Utc).AddTicks(8422) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(387), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(387) });

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
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(665), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(665), "2021-2022" });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate", "SchoolYear" },
                values: new object[] { new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701), new DateTime(2023, 5, 27, 10, 3, 9, 871, DateTimeKind.Utc).AddTicks(701), "2021-2022" });

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
    }
}
