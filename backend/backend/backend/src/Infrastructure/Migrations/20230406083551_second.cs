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
            migrationBuilder.DropForeignKey(
                name: "FK_InternShips_Locations_LocationId",
                table: "InternShips");

            migrationBuilder.DropIndex(
                name: "IX_InternShips_LocationId",
                table: "InternShips");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "InternShips");

            migrationBuilder.AddColumn<int>(
                name: "InternShipId",
                table: "Locations",
                type: "int",
                nullable: true);

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

            migrationBuilder.DropColumn(
                name: "InternShipId",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "InternShips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InternShips_LocationId",
                table: "InternShips",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_InternShips_Locations_LocationId",
                table: "InternShips",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
