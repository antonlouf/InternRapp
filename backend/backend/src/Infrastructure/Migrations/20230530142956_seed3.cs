using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6423), new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6426), new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 5, 30, 14, 29, 56, 168, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3692), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3723), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3729), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3734), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3740), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3746), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3751), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3786), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3791), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3796), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3801), new DateTime(2023, 5, 30, 14, 29, 56, 171, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8454), new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8457), new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8458), new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8458), new DateTime(2023, 5, 30, 14, 29, 56, 169, DateTimeKind.Utc).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4741), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4745), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7194), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7197), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7198), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9103), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9106), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>As the Inetum-Realdolmen Microsoft Competence Center, we are the largest Microsoft .NET development organization in Belgium, with over 150 employees. We are involved in the complete realization of Microsoft projects, including strategy, architecture, implementation, system integration, maintenance, training, and support. Our knowledge and experience are focused on the following technologies and solution domains:</p><ul><li>Development of Windows, web, and smart client applications (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li><li>Mobility (Universal apps, Xamarin)</li><li>Integration - EAI (Biztalk &amp; WCF)</li><li>CAD/GIS integration projects</li><li>Azure Cloud</li><li>Training</li></ul><p>Within our internal operations, we place a high emphasis on technology, as it is the cornerstone of our division. That&#39;s why we have numerous initiatives to conduct research on everything new within the Microsoft technology stack. And this is where you come into the picture! We are confident that with all your energy, enthusiasm, and creativity, you can help us explore these new technologies and prepare them for use in future business applications. Below you will find a list of technologies and/or topics for which we want to develop complete assignments in the upcoming academic year.</p><p>Let it be clear that the complexity of the assignments will not be easy. We expect you to already have a solid basic knowledge of .NET. However, don&#39;t let this discourage you, as we are looking for the best of the best. Are you the one who wants to shape the business applications of the future? Don&#39;t hesitate to apply for an internship at the Realdolmen Microsoft Division. In addition to the mentioned assignments from our Applications Microsoft division, we are also active in Enterprise Solutions with Microsoft (SharePoint, CRM, Business Intelligence), where exciting projects are available.</p><p>Realdolmen attaches great importance to a constant flow of innovation, optimization, and expansion of knowledge. The influx of creative ideas for integrating or studying new technologies is substantial. This is where new and challenging opportunities lie for you. Through a wide range of internship assignments, we give you the opportunity to work on these new ideas within the Realdolmen Microsoft Competence Center and convince us whether or not they can add value to our current offerings.</p><p>If you are interested and ready to take on challenges, if you want to delve into one of the most extensive technology stacks at the moment, and if you are proficient in Microsoft .NET development, then seize the opportunity now! Convince us of your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p>", new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9107), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9108), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9109), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9111), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9111), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9112), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9113), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(416), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(418), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(418), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(445), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(446), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(447), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 5, 30, 14, 29, 56, 170, DateTimeKind.Utc).AddTicks(447) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4611), new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4613), new DateTime(2023, 5, 30, 14, 27, 0, 514, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2674), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2711), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2718), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2873), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2879), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2887), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2893), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2898), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2903), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2909), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2915), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2920), new DateTime(2023, 5, 30, 14, 27, 0, 517, DateTimeKind.Utc).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8573), new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8576), new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8577), new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 5, 30, 14, 27, 0, 515, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3983), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3985), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3986), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3987), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5655), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5658), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5659), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7081), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7084), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>As the Inetum-Realdolmen Microsoft Competence Center, we are the largest Microsoft .NET development organization in Belgium, with over 150 employees. We are involved in the complete realization of Microsoft projects, including strategy, architecture, implementation, system integration, maintenance, training, and support. Our knowledge and experience are focused on the following technologies and solution domains:</p><ol><li>Development of Windows, web, and smart client applications (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li><li>Mobility (Universal apps, Xamarin)</li><li>Integration - EAI (Biztalk &amp; WCF)</li><li>CAD/GIS integration projects</li><li>Azure Cloud</li><li>Training</li></ol><p>Within our internal operations, we place a high emphasis on technology, as it is the cornerstone of our division. That&#39;s why we have numerous initiatives to conduct research on everything new within the Microsoft technology stack. And this is where you come into the picture! We are confident that with all your energy, enthusiasm, and creativity, you can help us explore these new technologies and prepare them for use in future business applications. Below you will find a list of technologies and/or topics for which we want to develop complete assignments in the upcoming academic year.</p><p>Let it be clear that the complexity of the assignments will not be easy. We expect you to already have a solid basic knowledge of .NET. However, don&#39;t let this discourage you, as we are looking for the best of the best. Are you the one who wants to shape the business applications of the future? Don&#39;t hesitate to apply for an internship at the Realdolmen Microsoft Division. In addition to the mentioned assignments from our Applications Microsoft division, we are also active in Enterprise Solutions with Microsoft (SharePoint, CRM, Business Intelligence), where exciting projects are available.</p><p>Realdolmen attaches great importance to a constant flow of innovation, optimization, and expansion of knowledge. The influx of creative ideas for integrating or studying new technologies is substantial. This is where new and challenging opportunities lie for you. Through a wide range of internship assignments, we give you the opportunity to work on these new ideas within the Realdolmen Microsoft Competence Center and convince us whether or not they can add value to our current offerings.</p><p>If you are interested and ready to take on challenges, if you want to delve into one of the most extensive technology stacks at the moment, and if you are proficient in Microsoft .NET development, then seize the opportunity now! Convince us of your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p><p><strong>Contact us via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>to request an internship</strong></p>", new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7085), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7086), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7087), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7088), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7088), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7089), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(552), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(556), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(557), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(557), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(559), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(561), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(562), new DateTime(2023, 5, 30, 14, 27, 0, 516, DateTimeKind.Utc).AddTicks(562) });
        }
    }
}
