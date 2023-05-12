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
                table: "InternShips",
                columns: new[] { "Id", "CurrentCountOfStudents", "MaxStudents", "RequiredTrainingType", "SchoolYear", "UnitId" },
                values: new object[,]
                {
                    { 1, (byte)0, (byte)10, 0, "2023-2024", 1 },
                    { 2, (byte)0, (byte)10, 0, "2023-2024", 2 },
                    { 3, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 4, (byte)0, (byte)10, 0, "2023-2024", 1 },
                    { 5, (byte)0, (byte)10, 0, "2023-2024", 2 },
                    { 6, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 7, (byte)0, (byte)10, 0, "2023-2024", 1 },
                    { 8, (byte)0, (byte)10, 0, "2023-2024", 2 },
                    { 9, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 10, (byte)0, (byte)10, 0, "2023-2024", 1 }
                });

            migrationBuilder.InsertData(
                table: "PrefaceTranslations",
                columns: new[] { "Id", "Content", "LanguageId", "UnitId" },
                values: new object[,]
                {
                    { 1, "", 1, 1 },
                    { 2, "Dit is een standaard descriptie horende bij een unit", 2, 1 },
                    { 3, "Ce ici c'est un description standard d un departement", 3, 1 },
                    { 4, "Ce ici c'est un description standard d un departement", 1, 2 },
                    { 5, "Dit is een standaard descriptie horende bij een unit", 2, 2 },
                    { 6, "Ce ici c'est un description standard d un departement", 3, 2 },
                    { 7, "This is a standard description for a unit", 4, 2 },
                    { 8, "This is a standard description for a unit", 1, 3 },
                    { 9, "Dit is een standaard descriptie horende bij een unit", 2, 3 },
                    { 10, "Dit is een standaard descriptie horende bij een unit", 1, 1 },
                    { 11, "Dit is een standaard descriptie horende bij een unit", 2, 1 },
                    { 12, "Ce ici c'est un description standard d un departement", 3, 1 },
                    { 13, "Ce ici c'est un description standard d un departement", 1, 2 },
                    { 14, "Dit is een standaard descriptie horende bij een unit", 2, 2 },
                    { 15, "Ce ici c'est un description standard d un departement", 3, 2 },
                    { 16, "This is a standard description for a unit", 4, 2 },
                    { 17, "This is a standard description for a unit", 1, 3 },
                    { 18, "Dit is een standaard descriptie horende bij een unit", 2, 3 },
                    { 19, "Dit is een standaard descriptie horende bij een unit", 1, 1 },
                    { 20, "Dit is een standaard descriptie horende bij een unit", 2, 1 },
                    { 21, "Ce ici c'est un description standard d un departement", 3, 1 },
                    { 22, "Ce ici c'est un description standard d un departement", 1, 2 },
                    { 23, "Dit is een standaard descriptie horende bij een unit", 2, 2 },
                    { 24, "Ce ici c'est un description standard d un departement", 3, 2 },
                    { 25, "This is a standard description for a unit", 4, 2 },
                    { 26, "This is a standard description for a unit", 1, 3 },
                    { 27, "Dit is een standaard descriptie horende bij een unit", 2, 3 },
                    { 28, "Dit is een standaard descriptie horende bij een unit", 1, 1 },
                    { 29, "Dit is een standaard descriptie horende bij een unit", 2, 1 },
                    { 30, "Ce ici c'est un description standard d un departement", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 8, 2 },
                    { 9, 3 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Comment", "Description", "InternShipId", "KnowledgeToDevelop", "LanguageId", "NeededKnowledge", "TitleContent" },
                values: new object[,]
                {
                    { 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 5, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 6, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 7, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 8, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 9, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 10, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 11, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 12, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 13, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 5, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 14, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 5, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 15, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 5, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 16, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 5, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 17, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 6, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 18, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 6, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 19, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 7, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 20, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 7, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 21, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 7, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 22, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 8, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 23, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 8, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 24, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 8, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 25, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 8, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 4, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 26, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 9, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 27, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 9, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 28, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 10, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 1, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 29, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 10, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 2, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" },
                    { 30, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>required diploma for this internship is: Bachelor<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", 10, "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", 3, "<html><body style=\"font-family:Verdana; font-size:14.5px\">><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "standard" }
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
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 });

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
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 30);

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
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 30);

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
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
