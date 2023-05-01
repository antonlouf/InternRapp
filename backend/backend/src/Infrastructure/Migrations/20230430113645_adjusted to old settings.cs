using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adjustedtooldsettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternShips_Departments_UnitId1",
                table: "InternShips");

            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId1",
                table: "PrefaceTranslation");

            migrationBuilder.DropIndex(
                name: "IX_PrefaceTranslation_LanguageId1",
                table: "PrefaceTranslation");

            migrationBuilder.DropIndex(
                name: "IX_InternShips_UnitId1",
                table: "InternShips");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "PrefaceTranslation");

            migrationBuilder.DropColumn(
                name: "UnitId1",
                table: "InternShips");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId1",
                table: "PrefaceTranslation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnitId1",
                table: "InternShips",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrefaceTranslation_LanguageId1",
                table: "PrefaceTranslation",
                column: "LanguageId1");

            migrationBuilder.CreateIndex(
                name: "IX_InternShips_UnitId1",
                table: "InternShips",
                column: "UnitId1");

            migrationBuilder.AddForeignKey(
                name: "FK_InternShips_Departments_UnitId1",
                table: "InternShips",
                column: "UnitId1",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId1",
                table: "PrefaceTranslation",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "Id");
        }
    }
}
