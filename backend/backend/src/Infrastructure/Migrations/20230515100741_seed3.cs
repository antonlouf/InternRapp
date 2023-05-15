using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>Dit is een standaard descriptie horende bij een unit</p></body></html>");

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>Ce ici c'est un description standard d un departement</p></body></html>");

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a standard description for a unit</p></body></html>");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Dit is het voorwoord voor de .net competence center");

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Dit is het voorwoord voor het Java departement center");

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Dit is het voorwoord voor het Low Code departement center");
        }
    }
}
