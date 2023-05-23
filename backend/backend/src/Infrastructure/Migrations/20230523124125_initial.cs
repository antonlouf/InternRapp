using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Infrastructure.Migrations
{
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
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ManagerEmails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ZipCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    RequiredTrainingType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    LocationsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    KnowledgeToDevelop = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NeededKnowledge = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    InternShipId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LastModifiedDate", "ManagerEmails", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1694), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1694), "anton.louf@student.ehb.be", ".net" },
                    { 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1697), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1696), "anton.louf@student.ehb.be", "Java" },
                    { 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1698), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1698), "anton.louf@student.ehb.be", "Low Code" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "IsDeleted", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "nl", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1687), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1687), "Dutch" },
                    { 2, "fr", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1689), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1689), "French" },
                    { 3, "en", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1690), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1689), "English" },
                    { 4, "de", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1690), false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1690), "German" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "CreatedDate", "HouseNumber", "IsDeleted", "LastModifiedDate", "StreetName", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Huizingen", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1683), 42, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1681), "Vaucampslaan", "1654" },
                    { 2, "Gent", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1685), 4, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1685), "Gaston Crommenlaan", "9050" },
                    { 3, "Kontich", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1686), 26, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1686), "Prins Boudewijnlaan", "2550" }
                });

            migrationBuilder.InsertData(
                table: "InternShips",
                columns: new[] { "Id", "CreatedDate", "CurrentCountOfStudents", "IsDeleted", "LastModifiedDate", "MaxStudents", "RequiredTrainingType", "SchoolYear", "UnitId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1812), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1812), (byte)10, 0, "2021-2022", 1 },
                    { 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1992), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1992), (byte)10, 0, "2021-2022", 2 },
                    { 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2032), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2032), (byte)10, 0, "2022-2023", 3 },
                    { 4, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2076), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2075), (byte)10, 0, "2023-2024", 1 },
                    { 5, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2103), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2102), (byte)10, 0, "2021-2022", 2 },
                    { 6, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2193), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2193), (byte)10, 0, "2023-2024", 3 },
                    { 7, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2235), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2235), (byte)10, 0, "2021-2022", 1 },
                    { 8, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2262), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2262), (byte)10, 0, "2021-2022", 2 },
                    { 9, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2295), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2295), (byte)10, 0, "2021-2022", 3 },
                    { 10, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2364), (byte)0, false, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2364), (byte)10, 0, "2023-2024", 1 }
                });

            migrationBuilder.InsertData(
                table: "PrefaceTranslations",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "LanguageId", "LastModifiedDate", "UnitId" },
                values: new object[,]
                {
                    { 1, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2401), false, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2400), 1 },
                    { 2, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2410), false, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2410), 1 },
                    { 3, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2416), false, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2415), 1 },
                    { 4, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2421), false, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2421), 2 },
                    { 5, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2426), false, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2426), 2 },
                    { 6, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2432), false, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2432), 2 },
                    { 7, "<p>Dit is een standaard descriptie horende bij een unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2437), false, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2437), 3 },
                    { 8, "<p>Ce ici c'est un description standard d un departement</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2443), false, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2442), 3 },
                    { 9, "<p>This is a standard description for a unit</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2448), false, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2447), 3 }
                });

            migrationBuilder.InsertData(
                table: "InternShipLocation",
                columns: new[] { "InternShipId", "LocationsId", "CreatedDate", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1816), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1815) },
                    { 1, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1830), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1830) },
                    { 1, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1835) },
                    { 2, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1993), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1993) },
                    { 2, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1999), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1999) },
                    { 2, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2006), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2006) },
                    { 3, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2032), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2032) },
                    { 3, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2038), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2038) },
                    { 3, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2044), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2043) },
                    { 4, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2076), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2076) },
                    { 4, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2081) },
                    { 4, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2086), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2086) },
                    { 5, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2103), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2103) },
                    { 5, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2109), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2109) },
                    { 5, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2113) },
                    { 6, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2194) },
                    { 6, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2199) },
                    { 6, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2205) },
                    { 7, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2236), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2235) },
                    { 7, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2241), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2241) },
                    { 7, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2246), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2246) },
                    { 8, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2263), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2263) },
                    { 8, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2268) },
                    { 8, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2273), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2273) },
                    { 9, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2296), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2296) },
                    { 9, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2301), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2301) },
                    { 9, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2306), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2306) },
                    { 10, 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2365), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2365) },
                    { 10, 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2370), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2370) },
                    { 10, 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2376), new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2375) }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "Comment", "CreatedDate", "Description", "InternShipId", "IsDeleted", "KnowledgeToDevelop", "LanguageId", "LastModifiedDate", "Location", "NeededKnowledge", "TitleContent" },
                values: new object[,]
                {
                    { 1, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1942), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 1, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(1942), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 2, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2013), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2013), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 3, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2021), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 2, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2021), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 4, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2051), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2051), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 5, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2059), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2058), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 6, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2065), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 3, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2065), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 7, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2093), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 4, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2093), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 8, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2120), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2119), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 9, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2126), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 5, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2126), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 10, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2212), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2212), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 11, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2219), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2218), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 12, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2225), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 6, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2225), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 13, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2253), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 7, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2252), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 14, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2279), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2279), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 15, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2286), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 8, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2286), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 16, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2339), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2339), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 17, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2347), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 2, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2346), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 18, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2353), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 9, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 3, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2353), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" },
                    { 19, "<p>required diploma for this internship is: Bachelor</p>", new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2382), "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>", 10, false, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", 1, new DateTime(2023, 5, 23, 12, 41, 25, 162, DateTimeKind.Utc).AddTicks(2381), null, "<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>", "Standard Internship Title" }
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
}
