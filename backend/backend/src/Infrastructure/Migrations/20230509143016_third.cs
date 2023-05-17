using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Translations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("d550c298-765c-48b7-a6e7-6e48079bc1fd"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("faccb848-eaca-4e58-8e8b-635efdb54973"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("458b66a1-2bcb-43d6-865f-085fb362ddc0"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Translations",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("3b741859-da11-4bf7-b2fd-f571279042ea"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("14a31e37-ecd0-4b23-8f65-d79d3788ac3a"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("8cd6fb7a-e491-49b9-8712-69bf7562d736"));
        }
    }
}
