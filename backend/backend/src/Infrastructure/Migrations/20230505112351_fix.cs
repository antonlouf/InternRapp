using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslation_Departments_UnitId",
                table: "PrefaceTranslation");

            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId",
                table: "PrefaceTranslation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrefaceTranslation",
                table: "PrefaceTranslation");

            migrationBuilder.RenameTable(
                name: "PrefaceTranslation",
                newName: "PrefaceTranslations");

            migrationBuilder.RenameIndex(
                name: "IX_PrefaceTranslation_UnitId",
                table: "PrefaceTranslations",
                newName: "IX_PrefaceTranslations_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_PrefaceTranslation_LanguageId",
                table: "PrefaceTranslations",
                newName: "IX_PrefaceTranslations_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrefaceTranslations",
                table: "PrefaceTranslations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslations_Departments_UnitId",
                table: "PrefaceTranslations",
                column: "UnitId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslations_Languages_LanguageId",
                table: "PrefaceTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslations_Departments_UnitId",
                table: "PrefaceTranslations");

            migrationBuilder.DropForeignKey(
                name: "FK_PrefaceTranslations_Languages_LanguageId",
                table: "PrefaceTranslations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrefaceTranslations",
                table: "PrefaceTranslations");

            migrationBuilder.RenameTable(
                name: "PrefaceTranslations",
                newName: "PrefaceTranslation");

            migrationBuilder.RenameIndex(
                name: "IX_PrefaceTranslations_UnitId",
                table: "PrefaceTranslation",
                newName: "IX_PrefaceTranslation_UnitId");

            migrationBuilder.RenameIndex(
                name: "IX_PrefaceTranslations_LanguageId",
                table: "PrefaceTranslation",
                newName: "IX_PrefaceTranslation_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrefaceTranslation",
                table: "PrefaceTranslation",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslation_Departments_UnitId",
                table: "PrefaceTranslation",
                column: "UnitId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrefaceTranslation_Languages_LanguageId",
                table: "PrefaceTranslation",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
