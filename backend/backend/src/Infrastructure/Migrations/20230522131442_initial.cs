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
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedDate", "IsDeleted", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "nl", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4863), false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4863), "Dutch" },
                    { 2, "fr", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4866), false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4865), "French" },
                    { 3, "en", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4867), false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4866), "English" },
                    { 4, "de", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4868), false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4867), "German" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "CreatedDate", "HouseNumber", "IsDeleted", "LastModifiedDate", "StreetName", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Huizingen", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4858), 42, false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4849), "Vaucampslaan", "1654" },
                    { 2, "Gent", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4861), 4, false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4861), "Gaston Crommenlaan", "9050" },
                    { 3, "Kontich", new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4862), 26, false, new DateTime(2023, 5, 22, 13, 14, 42, 635, DateTimeKind.Utc).AddTicks(4862), "Prins Boudewijnlaan", "2550" }
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
