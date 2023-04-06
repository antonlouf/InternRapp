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
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_InternShips_InternShipId",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_InternShipId",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "InternShipId",
                table: "Locations");

            migrationBuilder.CreateTable(
                name: "InternShipLocation",
                columns: table => new
                {
                    InternshipsId = table.Column<int>(type: "int", nullable: false),
                    LocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternShipLocation", x => new { x.InternshipsId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_InternShipLocation_InternShips_InternshipsId",
                        column: x => x.InternshipsId,
                        principalTable: "InternShips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InternShipLocation_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InternShipLocation_LocationsId",
                table: "InternShipLocation",
                column: "LocationsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternShipLocation");

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
    }
}
