using System;
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
            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("aaf5a015-661c-44e7-b150-3779997a4fb6"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("dc742509-0fe6-4c57-8dd5-ffb8889badf9"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("65d35426-9103-4ada-b5d8-9794f3ca494b"));

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
                    { 1, (byte)0, (byte)10, 0, "2021-2022", 1 },
                    { 2, (byte)0, (byte)10, 0, "2022-2023", 2 },
                    { 3, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 4, (byte)0, (byte)10, 0, "2021-2022", 1 },
                    { 5, (byte)0, (byte)10, 0, "2022-2023", 2 },
                    { 6, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 7, (byte)0, (byte)10, 0, "2021-2022", 1 },
                    { 8, (byte)0, (byte)10, 0, "2022-2023", 2 },
                    { 9, (byte)0, (byte)10, 0, "2023-2024", 3 },
                    { 10, (byte)0, (byte)10, 0, "2021-2022", 1 }
                });

            migrationBuilder.InsertData(
                table: "PrefaceTranslations",
                columns: new[] { "Id", "Content", "LanguageId", "UnitId" },
                values: new object[,]
                {
                    { 1, "<p>Dit is een standaard descriptie horende bij een unit</p>", 1, 1 },
                    { 2, "<p>Ce ici c'est un description standard d un departement</p>", 2, 1 },
                    { 3, "<p>This is a standard description for a unit</p>", 3, 1 },
                    { 4, "<p>Dit is een standaard descriptie horende bij een unit</p>", 1, 2 },
                    { 5, "<p>Ce ici c'est un description standard d un departement</p>", 2, 2 },
                    { 6, "<p>This is a standard description for a unit</p>", 3, 2 },
                    { 7, "<p>Dit is een standaard descriptie horende bij een unit</p>", 1, 3 },
                    { 8, "<p>Ce ici c'est un description standard d un departement</p>", 2, 3 },
                    { 9, "<p>This is a standard description for a unit</p>", 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Comment", "Description", "InternShipId", "KnowledgeToDevelop", "LanguageId", "Location", "NeededKnowledge", "TitleContent" },
                values: new object[,]
                {
                    { 1, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 1, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 2, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 3, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 4, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 5, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 6, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 7, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 4, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 8, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 9, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 10, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 11, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 12, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 13, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 7, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 14, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 15, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 16, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 17, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 18, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 19, "<p>required diploma for this internship is: Bachelor</p>", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 10, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" }
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
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 });

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
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 6, 2 });

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
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 10, 3 });

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

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("4b202bdf-b8b8-48e1-99fa-8196e341c8b5"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("8d6e9afb-c513-4d89-b1a4-89c4d1c1591e"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("ed006eae-4a4d-478a-838b-4310f56c0b92"));
        }
    }
}
