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
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastModifiedDate", "ManagerEmails", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5818), false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5818), "anton.louf@student.ehb.be", ".net" },
                    { 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5821), false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5820), "anton.louf@student.ehb.be", "Java" },
                    { 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5822), false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5822), "anton.louf@student.ehb.be", "Low Code" }
                });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5811), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5812), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5814), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5807), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5809), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5810), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.InsertData(
                table: "InternShips",
                columns: new[] { "Id", "CreatedDate", "CurrentCountOfStudents", "IsDeleted", "LastModifiedDate", "MaxStudents", "RequiredTrainingType", "SchoolYear", "UnitId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5945), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5945), (byte)10, 0, "2023-2024", 1 },
                    { 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6091), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6090), (byte)10, 0, "2021-2022", 2 },
                    { 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6150), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6150), (byte)10, 0, "2022-2023", 3 },
                    { 4, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6191), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6191), (byte)10, 0, "2022-2023", 1 },
                    { 5, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6218), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6217), (byte)10, 0, "2022-2023", 2 },
                    { 6, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6274), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6274), (byte)10, 0, "2023-2024", 3 },
                    { 7, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6315), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6314), (byte)10, 0, "2022-2023", 1 },
                    { 8, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6341), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6341), (byte)10, 0, "2021-2022", 2 },
                    { 9, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6371), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6371), (byte)10, 0, "2021-2022", 3 },
                    { 10, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6435), (byte)0, false, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6435), (byte)10, 0, "2021-2022", 1 }
                });

            migrationBuilder.InsertData(
                table: "PrefaceTranslations",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "LanguageId", "LastModifiedDate", "UnitId" },
                values: new object[,]
                {
                    { 1, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6470), false, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6470), 1 },
                    { 2, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6478), false, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6477), 1 },
                    { 3, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6483), false, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6483), 1 },
                    { 4, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6487), false, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6487), 2 },
                    { 5, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6492), false, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6492), 2 },
                    { 6, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6498), false, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6498), 2 },
                    { 7, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6503), false, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6503), 3 },
                    { 8, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6508), false, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6507), 3 },
                    { 9, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6512), false, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6512), 3 }
                });

            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId", "CreatedDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5949) },
                    { 1, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5959) },
                    { 1, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(5964) },
                    { 2, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6091), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6091) },
                    { 2, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6097), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6096) },
                    { 2, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6125), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6124) },
                    { 3, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6151), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6151) },
                    { 3, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6156), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6156) },
                    { 3, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6161), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6161) },
                    { 4, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6191), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6191) },
                    { 4, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6197), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6196) },
                    { 4, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6201), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6201) },
                    { 5, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6218), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6218) },
                    { 5, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6223), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6222) },
                    { 5, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6228), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6227) },
                    { 6, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6275), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6274) },
                    { 6, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6280), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6280) },
                    { 6, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6286), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6286) },
                    { 7, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6315), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6315) },
                    { 7, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6320), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6320) },
                    { 7, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6325), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6325) },
                    { 8, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6341), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6341) },
                    { 8, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6346), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6346) },
                    { 8, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6351), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6350) },
                    { 9, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6372), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6372) },
                    { 9, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6376) },
                    { 9, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6381), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6381) },
                    { 10, 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6435), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6435) },
                    { 10, 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6440) },
                    { 10, 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6445), new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6445) }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Comment", "CreatedDate", "Description", "InternShipId", "IsDeleted", "KnowledgeToDevelop", "LanguageId", "LastModifiedDate", "Location", "NeededKnowledge", "TitleContent" },
                values: new object[,]
                {
                    { 1, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6068), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 1, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6068), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 2, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6132), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6132), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 3, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6140), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6139), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 4, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6168), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6168), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 5, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6174), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6174), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 6, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6181), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6181), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 7, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6208), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 4, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6207), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 8, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6234), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6233), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 9, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6239), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6239), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 10, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6293), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6292), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 11, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6299), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6298), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 12, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6305), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6305), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 13, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6331), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 7, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6331), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 14, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6356), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6356), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 15, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6362), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6362), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 16, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6386), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6386), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 17, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6415), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6415), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 18, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6424), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6423), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 19, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6452), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 10, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 22, 13, 15, 54, 371, DateTimeKind.Utc).AddTicks(6452), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" }
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
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4863), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4866), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4867), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4868), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4858), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4861), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4862), new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4862) });
        }
    }
}
