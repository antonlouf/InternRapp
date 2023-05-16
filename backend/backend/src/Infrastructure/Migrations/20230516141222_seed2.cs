using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 10, 2 },
                    { 10, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 });
        }
    }
}
