using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerDepartmentId",
                table: "ApplicationUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "ApplicationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Contributor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    TypeOfContributor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contributor_ApplicationUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contributor_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_ManagerDepartmentId",
                table: "ApplicationUsers",
                column: "ManagerDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributor_AppUserId",
                table: "Contributor",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributor_DepartmentId",
                table: "Contributor",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_Departments_ManagerDepartmentId",
                table: "ApplicationUsers",
                column: "ManagerDepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_Departments_ManagerDepartmentId",
                table: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Contributor");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_ManagerDepartmentId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "ManagerDepartmentId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ApplicationUsers");
        }
    }
}
