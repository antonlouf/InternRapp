using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "KnowledgeToDevelop", "NeededKnowledge" },
                values: new object[] { "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>", "<html><body style=\"font-family:Verdana; font-size:14.5px\"><p>This is a text editor&nbsp;</p>\\r\\n\\r\\n<ul>\\r\\n\\t<li>With some styling</li>\\r\\n\\t<li>And some more styling</li>\\r\\n\\t<li>To test if text is converted to HTML&nbsp;</li>\\r\\n</ul>\\r\\n\\r\\n<p>&nbsp;</p></body></html>" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "KnowledgeToDevelop", "NeededKnowledge" },
                values: new object[] { "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>", "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>", "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n	<li>With some styling</li>\r\n	<li>And some more styling</li>\r\n	<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>" });
        }
    }
}
