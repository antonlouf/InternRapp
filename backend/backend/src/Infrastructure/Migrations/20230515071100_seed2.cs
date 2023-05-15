using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LanguageId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "LanguageId",
                value: 1);
        }
    }
}
