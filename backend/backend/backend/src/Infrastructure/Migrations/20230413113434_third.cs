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
                name: "FK_Translations_InternShips_InternShipId",
                table: "Translations");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_InternShips_InternShipId",
                table: "Translations",
                column: "InternShipId",
                principalTable: "InternShips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Translations_InternShips_InternShipId",
                table: "Translations");

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_InternShips_InternShipId",
                table: "Translations",
                column: "InternShipId",
                principalTable: "InternShips",
                principalColumn: "Id");
        }
    }
}
