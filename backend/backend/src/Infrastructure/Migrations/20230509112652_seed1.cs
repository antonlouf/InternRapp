using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InternShipId",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "InternShipId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "InternShipId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "InternShipId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_InternShipId",
                table: "Locations",
                column: "InternShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_InternShips_InternShipId",
                table: "Locations",
                column: "InternShipId",
                principalTable: "InternShips",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_InternShips_InternShipId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_InternShipId",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 });

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

            migrationBuilder.DropColumn(
                name: "InternShipId",
                table: "Locations");
        }
    }
}
