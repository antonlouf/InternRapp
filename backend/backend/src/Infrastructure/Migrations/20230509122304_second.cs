using System;
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
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Translations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Translations",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ObjectIdentifier",
                value: new Guid("397d322d-415f-4d7e-9130-4b524f365a88"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 2,
                column: "ObjectIdentifier",
                value: new Guid("51004831-7531-44dd-a117-372a40e43cc2"));

            migrationBuilder.UpdateData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 3,
                column: "ObjectIdentifier",
                value: new Guid("6fefbf04-1280-4548-a964-090c94725168"));

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "blabla");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "blabla");

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "blabla");
        }
    }
}
