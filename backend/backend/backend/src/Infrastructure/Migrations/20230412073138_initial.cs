using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                name: "InternShipLocation",
                columns: table => new
                {
                    InternshipsId = table.Column<int>(type: "int", nullable: false),
                    LocationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternShipLocation", x => new { x.InternshipsId, x.LocationsId });
                    table.ForeignKey(
                        name: "FK_InternShipLocation_InternShips_InternshipsId",
                        column: x => x.InternshipsId,
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
                name: "IX_Languages_Name",
                table: "Languages",
                column: "Name",
                unique: true);

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
