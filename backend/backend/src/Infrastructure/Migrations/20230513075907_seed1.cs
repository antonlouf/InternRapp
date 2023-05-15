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
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "ManagerEmails", "Name" },
                values: new object[,]
                {
                    { 1, "anton.louf@student.ehb.be", ".net" },
                    { 2, "anton.louf@student.ehb.be", "Java" },
                    { 3, "anton.louf@student.ehb.be", "Low Code" }
                });

            migrationBuilder.InsertData(
                table: "InternShips",
                columns: new[] { "Id", "CurrentCountOfStudents", "MaxStudents", "RequiredTrainingType", "SchoolYear", "UnitId" },
                values: new object[,]
                {
                    { 1, (byte)0, (byte)10, 0, "2023-2024", 1 },
                    { 2, (byte)0, (byte)10, 1, "2023-2024", 2 },
                    { 3, (byte)0, (byte)15, 2, "2023-2024", 3 }
                });

            migrationBuilder.InsertData(
                table: "PrefaceTranslations",
                columns: new[] { "Id", "Content", "LanguageId", "UnitId" },
                values: new object[,]
                {
                    { 1, "Dit is het voorwoord voor de .net competence center", 1, 1 },
                    { 2, "Dit is het voorwoord voor het Java departement center", 1, 2 },
                    { 3, "Dit is het voorwoord voor het Low Code departement center", 1, 3 }
                });

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

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Comment", "Description", "InternShipId", "KnowledgeToDevelop", "LanguageId", "NeededKnowledge", "TitleContent" },
                values: new object[,]
                {
                    { 1, "<p>required diploma for this internship is: Bachelor<p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 1, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 1, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "InternRapp" },
                    { 2, "<p>required diploma for this internship is: Master<p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 2, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 2, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "Mobile App" },
                    { 3, "<p>required diploma for this internship is: MasterAfterMaster<p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 3, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 3, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "Android App" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
