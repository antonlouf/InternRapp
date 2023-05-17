﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Infrastructure.Migrations;

/// <inheritdoc />
public partial class initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "ApplicationUsers",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                ObjectIdentifier = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                table.UniqueConstraint("AK_ApplicationUsers_Email", x => x.Email);
            });

        migrationBuilder.CreateTable(
            name: "Departments",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                ManagerEmails = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Departments", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Languages",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Languages", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Locations",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                HouseNumber = table.Column<int>(type: "int", nullable: false),
                ZipCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Locations", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "InternShips",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                UnitId = table.Column<int>(type: "int", nullable: false),
                SchoolYear = table.Column<string>(type: "nvarchar(450)", nullable: false),
                MaxStudents = table.Column<byte>(type: "tinyint", nullable: false),
                CurrentCountOfStudents = table.Column<byte>(type: "tinyint", nullable: false),
                RequiredTrainingType = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_InternShips", x => x.Id);
                table.ForeignKey(
                    name: "FK_InternShips_Departments_UnitId",
                    column: x => x.UnitId,
                    principalTable: "Departments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "PrefaceTranslations",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                LanguageId = table.Column<int>(type: "int", nullable: false),
                UnitId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PrefaceTranslations", x => x.Id);
                table.ForeignKey(
                    name: "FK_PrefaceTranslations_Departments_UnitId",
                    column: x => x.UnitId,
                    principalTable: "Departments",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_PrefaceTranslations_Languages_LanguageId",
                    column: x => x.LanguageId,
                    principalTable: "Languages",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "InternShipLocation",
            columns: table => new
            {
                InternShipId = table.Column<int>(type: "int", nullable: false),
                LocationsId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_InternShipLocation", x => new { x.InternShipId, x.LocationsId });
                table.ForeignKey(
                    name: "FK_InternShipLocation_InternShips_InternShipId",
                    column: x => x.InternShipId,
                    principalTable: "InternShips",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_InternShipLocation_Locations_LocationsId",
                    column: x => x.LocationsId,
                    principalTable: "Locations",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Translations",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                TitleContent = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                KnowledgeToDevelop = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                NeededKnowledge = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                Location = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                Comment = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                Content = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                InternShipId = table.Column<int>(type: "int", nullable: false),
                LanguageId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Translations", x => x.Id);
                table.ForeignKey(
                    name: "FK_Translations_InternShips_InternShipId",
                    column: x => x.InternShipId,
                    principalTable: "InternShips",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Translations_Languages_LanguageId",
                    column: x => x.LanguageId,
                    principalTable: "Languages",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.InsertData(
            table: "ApplicationUsers",
            columns: new[] { "Id", "Email", "ObjectIdentifier" },
            values: new object[,]
            {
                { 1, "recep@inetum-realdolmen.world", new Guid("397d322d-415f-4d7e-9130-4b524f365a88") },
                { 2, "Anton@inetum-realdolmen.world", new Guid("51004831-7531-44dd-a117-372a40e43cc2") },
                { 3, "Nils@inetum-realdolmen.world", new Guid("6fefbf04-1280-4548-a964-090c94725168") }
            });

        migrationBuilder.InsertData(
            table: "Departments",
            columns: new[] { "Id", "ManagerEmails", "Name" },
            values: new object[] { 1, "recep@inetum-realdolmen.world", "Java" });

        migrationBuilder.InsertData(
            table: "Languages",
            columns: new[] { "Id", "Code", "Name" },
            values: new object[,]
            {
                { 1, "nl", "Nederlands" },
                { 2, "en", "Engels" },
                { 3, "fr", "French" }
            });

        migrationBuilder.InsertData(
            table: "Locations",
            columns: new[] { "Id", "City", "HouseNumber", "StreetName", "ZipCode" },
            values: new object[,]
            {
                { 1, "antwerpen", 51, "ellermanstraat", "2260" },
                { 2, "antwerpen", 51, "elleboogtraat", "2260" }
            });

        migrationBuilder.InsertData(
            table: "InternShips",
            columns: new[] { "Id", "CurrentCountOfStudents", "MaxStudents", "RequiredTrainingType", "SchoolYear", "UnitId" },
            values: new object[] { 1, (byte)0, (byte)10, 0, "2023-2024", 1 });

        migrationBuilder.InsertData(
            table: "PrefaceTranslations",
            columns: new[] { "Id", "Content", "LanguageId", "UnitId" },
            values: new object[] { 1, "blabla", 1, 1 });

        migrationBuilder.InsertData(
            table: "Translations",
            columns: new[] { "Id", "Comment", "Content", "Description", "InternShipId", "KnowledgeToDevelop", "LanguageId", "Location", "NeededKnowledge", "TitleContent" },
            values: new object[,]
            {
                { 1, "<p>required diploma for this internship is: Bachelor<p>", "blabla", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 1, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 1, "new location", "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "InternRapp" },
                { 2, "<p>required diploma for this internship is: Bachelor<p>", "blabla", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 1, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 3, "new location", "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "InternRapp" },
                { 3, "<p>required diploma for this internship is: Bachelor<p>", "blabla", "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", 1, "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", 2, "new location", "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "InternRapp" }
            });

        migrationBuilder.CreateIndex(
            name: "IX_ApplicationUsers_ObjectIdentifier",
            table: "ApplicationUsers",
            column: "ObjectIdentifier");

        migrationBuilder.CreateIndex(
            name: "IX_Departments_Name",
            table: "Departments",
            column: "Name");

        migrationBuilder.CreateIndex(
            name: "IX_InternShipLocation_LocationsId",
            table: "InternShipLocation",
            column: "LocationsId");

        migrationBuilder.CreateIndex(
            name: "IX_InternShips_SchoolYear",
            table: "InternShips",
            column: "SchoolYear");

        migrationBuilder.CreateIndex(
            name: "IX_InternShips_UnitId",
            table: "InternShips",
            column: "UnitId");

        migrationBuilder.CreateIndex(
            name: "IX_Languages_Code",
            table: "Languages",
            column: "Code",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "IX_PrefaceTranslations_LanguageId",
            table: "PrefaceTranslations",
            column: "LanguageId");

        migrationBuilder.CreateIndex(
            name: "IX_PrefaceTranslations_UnitId",
            table: "PrefaceTranslations",
            column: "UnitId");

        migrationBuilder.CreateIndex(
            name: "IX_Translations_InternShipId",
            table: "Translations",
            column: "InternShipId");

        migrationBuilder.CreateIndex(
            name: "IX_Translations_LanguageId",
            table: "Translations",
            column: "LanguageId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "ApplicationUsers");

        migrationBuilder.DropTable(
            name: "InternShipLocation");

        migrationBuilder.DropTable(
            name: "PrefaceTranslations");

        migrationBuilder.DropTable(
            name: "Translations");

        migrationBuilder.DropTable(
            name: "Locations");

        migrationBuilder.DropTable(
            name: "InternShips");

        migrationBuilder.DropTable(
            name: "Languages");

        migrationBuilder.DropTable(
            name: "Departments");
    }
}
