using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changesdatamodelofprefacetranslation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "PrefaceTranslation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PrefaceTranslation_LanguageId",
                table: "PrefaceTranslation",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId",
                table: "PrefaceTranslation",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId",
                table: "PrefaceTranslation");

            migrationBuilder.DropIndex(
                name: "IX_PrefaceTranslation_LanguageId",
                table: "PrefaceTranslation");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "PrefaceTranslation");
        }
    }
}
