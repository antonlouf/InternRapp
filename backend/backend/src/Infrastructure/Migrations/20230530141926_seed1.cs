using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 5, 30, 14, 19, 26, 448, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1185), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1216), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1223), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1229), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1235), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1242), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1282), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1289), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1296), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1301), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1307), new DateTime(2023, 5, 30, 14, 19, 26, 451, DateTimeKind.Utc).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7829), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7831), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7832), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7833), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3718), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3723), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3724), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3724), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5361), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5366), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>En tant que centre de comp&eacute;tence Microsoft d&#39;Inetum-Realdolmen, nous sommes la plus grande organisation de d&eacute;veloppement Microsoft .NET en Belgique, avec plus de 150 employ&eacute;s. Nous sommes actifs dans la r&eacute;alisation compl&egrave;te de projets Microsoft, notamment dans les domaines de la strat&eacute;gie, de l&#39;architecture, de la mise en &oelig;uvre, de l&#39;int&eacute;gration de syst&egrave;mes, de la maintenance, de la formation et du support. Nos connaissances et notre exp&eacute;rience se situent actuellement dans les domaines et technologies suivants :</p><ul><li>D&eacute;veloppement d&#39;applications Windows, web et client intelligent (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li><li>Mobilit&eacute; (applications universelles, Xamarin)</li><li>Int&eacute;gration - EAI (Biztalk &amp; WCF)</li><li>Projets d&#39;int&eacute;gration CAD/GIS</li><li>Cloud Azure</li><li>Formation</li></ul><p>Au sein de notre organisation interne, nous accordons une grande importance &agrave; la technologie, qui est en quelque sorte la mati&egrave;re premi&egrave;re de notre division. C&#39;est pourquoi de nombreuses initiatives sont en cours pour mener des recherches sur toutes les nouveaut&eacute;s de l&#39;&eacute;cosyst&egrave;me technologique Microsoft. Et c&#39;est l&agrave; que vous intervenez ! Nous sommes convaincus que vous pouvez nous aider, avec toute votre &eacute;nergie, votre enthousiasme et votre cr&eacute;ativit&eacute;, &agrave; explorer ces nouvelles technologies et &agrave; les pr&eacute;parer pour une utilisation dans les applications m&eacute;tier du futur. Ci-dessous, vous trouverez une liste des technologies et/ou sujets sur lesquels nous souhaitons d&eacute;velopper des missions compl&egrave;tes au cours de l&#39;ann&eacute;e acad&eacute;mique &agrave; venir.</p><p>Il est clair que la complexit&eacute; des missions ne sera pas facile, nous nous attendons donc &agrave; ce que vous ayez d&eacute;j&agrave; une solide connaissance de base de .NET. Ne vous laissez pas d&eacute;courager, car nous sommes &agrave; la recherche du &quot;meilleur parmi les meilleurs&quot;. &Ecirc;tes-vous pr&ecirc;t &agrave; contribuer &agrave; fa&ccedil;onner les applications m&eacute;tier de l&#39;avenir ? N&#39;h&eacute;sitez pas &agrave; demander un stage au sein de la division Microsoft de Realdolmen. En plus des missions mentionn&eacute;es par notre division Applications Microsoft, nous sommes &eacute;galement actifs dans les Solutions Entreprise avec Microsoft (Sharepoint, CRM, Business Intelligence). L&agrave; aussi, des missions passionnantes sont disponibles.</p><p>Realdolmen attache une grande importance &agrave; un flux constant d&#39;innovation, d&#39;optimisation et d&#39;expansion des connaissances. Nous ne manquons pas de nouvelles id&eacute;es cr&eacute;atives pour int&eacute;grer ou &eacute;tudier de nouvelles technologies. C&#39;est l&agrave; que r&eacute;sident de nouvelles opportunit&eacute;s stimulantes pour vous. &Agrave; travers une large gamme de missions de stage, nous vous offrons la possibilit&eacute; de d&eacute;velopper ces nouvelles id&eacute;es au sein du Centre de Comp&eacute;tence Microsoft de Realdolmen et de nous convaincre de leur valeur ajout&eacute;e pour notre offre actuelle.</p><p>Si vous &ecirc;tes int&eacute;ress&eacute; et que vous n&#39;avez pas peur des d&eacute;fis, si vous souhaitez vous plonger dans l&#39;une des piles technologiques les plus &eacute;tendues &agrave; l&#39;heure actuelle et si vous ma&icirc;trisez le d&eacute;veloppement Microsoft .NET, c&#39;est le moment de saisir votre chance ! Convainquez-nous de votre enthousiasme, de vos comp&eacute;tences techniques et analytiques en travaillant sur l&#39;un des nombreux projets</p><p>&nbsp;</p><p>&nbsp;</p><p><strong>Contactez nous a </strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>pour demander votre stage</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6774), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>As the Inetum-Realdolmen Microsoft Competence Center, we are the largest Microsoft .NET development organization in Belgium, with over 150 employees. We are involved in the complete realization of Microsoft projects, including strategy, architecture, implementation, system integration, maintenance, training, and support. Our knowledge and experience are focused on the following technologies and solution domains:</p>\\r\\n\\r\\n<ol>\\r\\n\\t<li>Development of Windows, web, and smart client applications (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li>\\r\\n\\t<li>Mobility (Universal apps, Xamarin)</li>\\r\\n\\t<li>Integration - EAI (Biztalk &amp; WCF)</li>\\r\\n\\t<li>CAD/GIS integration projects</li>\\r\\n\\t<li>Azure Cloud</li>\\r\\n\\t<li>Training</li>\\r\\n</ol>\\r\\n\\r\\n<p>Within our internal operations, we place a high emphasis on technology, as it is the cornerstone of our division. That&#39;s why we have numerous initiatives to conduct research on everything new within the Microsoft technology stack. And this is where you come into the picture! We are confident that with all your energy, enthusiasm, and creativity, you can help us explore these new technologies and prepare them for use in future business applications. Below you will find a list of technologies and/or topics for which we want to develop complete assignments in the upcoming academic year.</p>\\r\\n\\r\\n<p>Let it be clear that the complexity of the assignments will not be easy. We expect you to already have a solid basic knowledge of .NET. However, don&#39;t let this discourage you, as we are looking for the best of the best. Are you the one who wants to shape the business applications of the future? Don&#39;t hesitate to apply for an internship at the Realdolmen Microsoft Division. In addition to the mentioned assignments from our Applications Microsoft division, we are also active in Enterprise Solutions with Microsoft (SharePoint, CRM, Business Intelligence), where exciting projects are available.</p>\\r\\n\\r\\n<p>Realdolmen attaches great importance to a constant flow of innovation, optimization, and expansion of knowledge. The influx of creative ideas for integrating or studying new technologies is substantial. This is where new and challenging opportunities lie for you. Through a wide range of internship assignments, we give you the opportunity to work on these new ideas within the Realdolmen Microsoft Competence Center and convince us whether or not they can add value to our current offerings.</p>\\r\\n\\r\\n<p>If you are interested and ready to take on challenges, if you want to delve into one of the most extensive technology stacks at the moment, and if you are proficient in Microsoft .NET development, then seize the opportunity now! Convince us of your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p>\\r\\n<p><strong>Contact us via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>to request an internship</strong></p>\\r\\n", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Het Inetum-Realdolmen Java Competence Center is met meer dan 150 Java consultants het grootste onafhankelijke Java expertisecentrum op het Vlaams/Belgisch grondgebied. Naast zijn jarenlange ervaring in de sector, beschikt het over een technologische knowhow die gerust als uniek beschouwd mag worden. Binnen Inetum-Realdolmen noemen we dit expertisecentrum niet zomaar onze &ldquo;Java Community&rdquo;. Onze gepassioneerde Java professionals geven dagelijks het beste van zichzelf om projecten bij klanten op tijd en binnen het overeengekomen budget op te leveren. Java is een technologie die van meet af aan opgezet is als een open technologie. &ldquo;Open&rdquo; wil zeggen dat technologische evoluties gedreven worden vanuit communities. Hierin zijn zowel mensen uit de industrie als leveranciers vertegenwoordigd. De vele innovaties die gegroeid zijn uit deze communities, hebben voor een groot deel het IT-landschap gevormd tot wat het vandaag is. Een greep uit de expertise van het Java Competence Center omvat technologie&euml;n en methodologie&euml;n zoals:</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces o Enterprise Java Beans (EJB</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Web services (REST / SOAP) / Service-Oriented Architecture (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / Test Driven Development / Behavior Driven Development</li><li>User Experience (UX) / Quality Assurance (QA)</li></ul><p>Inetum-Realdolmen hecht een groot belang aan een constante flow van innovatie, optimalisatie en uitbreiding van kennis. De instroom aan creatieve idee&euml;n over het integreren of bestuderen van nieuwe technologie&euml;n is allerminst gering. Dit is het punt waar nieuwe en uitdagende opportuniteiten liggen voor jullie. Via een grote waaier aan stageopdrachten geven we jullie de kans om binnen het Inetum Realdolmen Java Competence Center deze nieuwe idee&euml;n uit te werken en ons te overtuigen of dit al dan niet een meerwaarde kan betekenen binnen ons huidig aanbod. Ben je ge&iuml;nteresseerd en ga je geen uitdaging uit de weg, wil je je verdiepen in een van de meest uitgebreide technology stacks op dit moment, en ben je bedreven in Java? Dan is nu het moment om je kans te grijpen! Overtuig ons van je enthousiasme, technische en analytische skills tijdens het uitwerken van een van de vele projecten.</p><p>&nbsp;</p><p><strong>Contacteer ons via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>om jouw stageplaats aan te vragen</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Le centre de comp&eacute;tences Java d&#39;Inetum-Realdolmen est le plus grand centre d&#39;expertise Java ind&eacute;pendant en Flandre/Belgique, avec plus de 150 consultants Java. En plus de sa longue exp&eacute;rience dans le secteur, il poss&egrave;de un savoir-faire technologique qui peut &ecirc;tre consid&eacute;r&eacute; comme unique. Chez Inetum-Realdolmen, nous ne d&eacute;signons pas ce centre d&#39;expertise simplement comme notre &quot;Communaut&eacute; Java&quot;. Nos professionnels Java passionn&eacute;s donnent chaque jour le meilleur d&#39;eux-m&ecirc;mes pour livrer des projets chez les clients dans les d&eacute;lais et le budget convenus.</p><p>Java est une technologie qui a &eacute;t&eacute; con&ccedil;ue d&egrave;s le d&eacute;part comme une technologie ouverte. &quot;Ouverte&quot; signifie que les &eacute;volutions technologiques sont pilot&eacute;es par des communaut&eacute;s, comprenant &agrave; la fois des personnes de l&#39;industrie et des fournisseurs. Les nombreuses innovations qui ont &eacute;merg&eacute; de ces communaut&eacute;s ont largement fa&ccedil;onn&eacute; le paysage informatique tel qu&#39;il est aujourd&#39;hui.</p><p>Une s&eacute;lection de l&#39;expertise du Centre de comp&eacute;tences Java comprend des technologies et des m&eacute;thodologies telles que :</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces</li><li>Enterprise Java Beans (EJB)</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Services Web (REST / SOAP) / Architecture Orient&eacute;e Services (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / D&eacute;veloppement Pilot&eacute; par les Tests / D&eacute;veloppement Pilot&eacute; par le Comportement</li><li>Exp&eacute;rience Utilisateur (UX) / Assurance Qualit&eacute; (QA)</li></ul><p>Inetum-Realdolmen attache une grande importance &agrave; un flux constant d&#39;innovation, d&#39;optimisation et d&#39;extension des connaissances. L&#39;afflux d&#39;id&eacute;es cr&eacute;atives pour int&eacute;grer ou &eacute;tudier de nouvelles technologies est loin d&#39;&ecirc;tre n&eacute;gligeable. C&#39;est l&agrave; que se trouvent de nouvelles opportunit&eacute;s stimulantes pour vous. &Agrave; travers une large gamme de stages, nous vous offrons la possibilit&eacute; de d&eacute;velopper ces nouvelles id&eacute;es au sein du Centre de comp&eacute;tences Java d&#39;Inetum-Realdolmen et de nous convaincre de leur valeur ajout&eacute;e pour notre offre actuelle.</p><p>Si vous &ecirc;tes int&eacute;ress&eacute; et que vous n&#39;avez pas peur des d&eacute;fis, si vous souhaitez vous plonger dans l&#39;une des piles technologiques les plus &eacute;tendues du moment et que vous ma&icirc;trisez Java, c&#39;est le moment de saisir votre chance ! Impressionnez-nous avec votre enthousiasme, vos comp&eacute;tences techniques et analytiques en travaillant sur l&#39;un des nombreux projets.</p><p>&nbsp;</p><p><strong>Contactez nous a </strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>pour demander votre stage</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6776), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>The Java Competence Center of Inetum-Realdolmen is the largest independent Java expertise center in Flanders/Belgium, with over 150 Java consultants. In addition to its extensive experience in the industry, it possesses technological expertise that can be considered unique. At Inetum-Realdolmen, we don&#39;t simply refer to this expertise center as our &quot;Java Community.&quot; Our passionate Java professionals give their best every day to deliver projects to clients on time and within the agreed budget.</p><p>Java is a technology that has been designed from the beginning as an open technology. &quot;Open&quot; means that technological advancements are driven by communities, including both industry professionals and suppliers. The many innovations that have emerged from these communities have greatly shaped the IT landscape as it is today.</p><p>A selection of the expertise of the Java Competence Center includes technologies and methodologies such as:</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces</li><li>Enterprise Java Beans (EJB)</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Web services (REST / SOAP) / Service-Oriented Architecture (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / Test Driven Development / Behavior Driven Development</li><li>User Experience (UX) / Quality Assurance (QA)</li></ul><p>Inetum-Realdolmen places great importance on a constant flow of innovation, optimization, and knowledge expansion. The influx of creative ideas for integrating or studying new technologies is significant. This is where new and challenging opportunities lie for you. Through a wide range of internships, we offer you the opportunity to develop these new ideas within the Inetum-Realdolmen Java Competence Center and convince us of their added value to our current offerings.</p><p>If you are interested and unafraid of challenges, if you want to immerse yourself in one of the most extensive technology stacks at the moment, and if you have proficiency in Java, now is the time to seize your chance! Impress us with your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p><p>&nbsp;</p><p><strong>Contact us via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>to request an internship</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Naast ontwikkelingen in High Code (.NET, Java, ...) werkt Inetum-Realdolmen ook aan Enterprise-projecten in Low Code en dat in verschillende omgevingen: Microsoft Power-Platform, Salesforce, Mendix, Appian en Outsystems.</p><p><strong>Contacteer ons via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>om jouw stageplaats aan te vragen</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>En plus des d&eacute;veloppements en High Code (.NET, Java, ...), Inetum-Realdolmen travaille &eacute;galement sur des projets d&#39;entreprise en Low Code et ce, dans divers environnements : Microsoft Power-Platform, Salesforce, Mendix, Appian et Outsystems.</p><p><strong>Contactez nous a </strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>pour demander votre stage</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>In addition to developments in High Code (.NET, Java, ...), Inetum-Realdolmen is also working on Enterprise projects in Low Code and that in various environments: Microsoft Power-Platform, Salesforce, Mendix, Appian and Outsystems.</p><p><strong>Contact us via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>to request an internship</strong></p>", new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6779), new DateTime(2023, 5, 30, 14, 19, 26, 450, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9804), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9808), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9809), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9831), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9832), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9833), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9834), "<p>In de Inetum-Realdolmen Project Factory (PF) ontwikkelen developers van Inetum Realdolmen software in opdracht van een klant. Al het development gebeurd in house, met de tooling van Inetum-Realdolmen. De klant krijgt dus zijn deliverable op&nbsp;bepaalde tijdstippen en hoeft geen volledig development team te hebben.&nbsp;</p><p>Om onze PF te ondersteunen, hebben enkele collega&rsquo;s een bibliotheek opgericht. Hier&nbsp;kunnen onze developers boeken uitlenen. Momenteel wordt het uitleen-gedrag&nbsp;bijgehouden op een blad papier. Alsook aanvragen om nieuwe boeken aan te kopen&nbsp;worden op papier bijgehouden. Dit is een bewuste keuze. Als we het uitleen-gedrag&nbsp;digitaliseren op basis van bestaande tools (Google Drive, SharePoint...) zorgt dit voor&nbsp;extra overhead, dit be&iuml;nvloedt de toegankelijkheid van de bibliotheek.</p><p>In deze stageopdracht is het de bedoeling om een App uit te werken om dit uitleengedrag te gaan beheren. Er zijn tal van uitbreidingsmogelijkheden (synchroniseren&nbsp;met een service, scannen van barcodes om te lenen/terug te brengen, aanvragen&nbsp;van boeken&hellip;). Hiervoor zal de student zelf kunnen kiezen welke functionaliteit er&nbsp;volbracht wordt, uiteraard in samenspraak met stagebegeleider en &lsquo;klant&rsquo;.</p><p>Er wordt verwacht van de student dat hij/zij deze opdracht opneemt in de mentaliteit&nbsp;van de PF. Dit wil zeggen dat wij, de developers, de klant zullen zijn. Hij/zij zal&nbsp;correct moeten schatten, implementeren en met iteraties werkende, kwaliteitsvolle&nbsp;software opleveren.&nbsp;Hierbij zal de student begeleiding beschikbaar hebben. In de PF zijn immers enkele&nbsp;ScrumMaster&rsquo;s, tal van developers en bovendien een Agile/SCRUM coach.</p>", new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9835), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9835), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9836), new DateTime(2023, 5, 30, 14, 19, 26, 449, DateTimeKind.Utc).AddTicks(9836) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7462), new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7465), new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7466), new DateTime(2023, 5, 30, 11, 42, 45, 284, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6823), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6859), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6866), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6871), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6877), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6889), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6906), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 2 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6911), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "InternShipLocation",
                keyColumns: new[] { "InternShipId", "LocationsId" },
                keyValues: new object[] { 4, 3 },
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1854), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "InternShips",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1860), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8123), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8126), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8127), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(39), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(42), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1699), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>En tant que centre de comp&eacute;tence Microsoft d&#39;Inetum-Realdolmen, nous sommes la plus grande organisation de d&eacute;veloppement Microsoft .NET en Belgique, avec plus de 150 employ&eacute;s. Nous sommes actifs dans la r&eacute;alisation compl&egrave;te de projets Microsoft, notamment dans les domaines de la strat&eacute;gie, de l&#39;architecture, de la mise en &oelig;uvre, de l&#39;int&eacute;gration de syst&egrave;mes, de la maintenance, de la formation et du support. Nos connaissances et notre exp&eacute;rience se situent actuellement dans les domaines et technologies suivants :</p><ul><li>D&eacute;veloppement d&#39;applications Windows, web et client intelligent (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li><li>Mobilit&eacute; (applications universelles, Xamarin)</li><li>Int&eacute;gration - EAI (Biztalk &amp; WCF)</li><li>Projets d&#39;int&eacute;gration CAD/GIS</li><li>Cloud Azure</li><li>Formation</li></ul><p>Au sein de notre organisation interne, nous accordons une grande importance &agrave; la technologie, qui est en quelque sorte la mati&egrave;re premi&egrave;re de notre division. C&#39;est pourquoi de nombreuses initiatives sont en cours pour mener des recherches sur toutes les nouveaut&eacute;s de l&#39;&eacute;cosyst&egrave;me technologique Microsoft. Et c&#39;est l&agrave; que vous intervenez ! Nous sommes convaincus que vous pouvez nous aider, avec toute votre &eacute;nergie, votre enthousiasme et votre cr&eacute;ativit&eacute;, &agrave; explorer ces nouvelles technologies et &agrave; les pr&eacute;parer pour une utilisation dans les applications m&eacute;tier du futur. Ci-dessous, vous trouverez une liste des technologies et/ou sujets sur lesquels nous souhaitons d&eacute;velopper des missions compl&egrave;tes au cours de l&#39;ann&eacute;e acad&eacute;mique &agrave; venir.</p><p>Il est clair que la complexit&eacute; des missions ne sera pas facile, nous nous attendons donc &agrave; ce que vous ayez d&eacute;j&agrave; une solide connaissance de base de .NET. Ne vous laissez pas d&eacute;courager, car nous sommes &agrave; la recherche du &quot;meilleur parmi les meilleurs&quot;. &Ecirc;tes-vous pr&ecirc;t &agrave; contribuer &agrave; fa&ccedil;onner les applications m&eacute;tier de l&#39;avenir ? N&#39;h&eacute;sitez pas &agrave; demander un stage au sein de la division Microsoft de Realdolmen. En plus des missions mentionn&eacute;es par notre division Applications Microsoft, nous sommes &eacute;galement actifs dans les Solutions Entreprise avec Microsoft (Sharepoint, CRM, Business Intelligence). L&agrave; aussi, des missions passionnantes sont disponibles.</p><p>Realdolmen attache une grande importance &agrave; un flux constant d&#39;innovation, d&#39;optimisation et d&#39;expansion des connaissances. Nous ne manquons pas de nouvelles id&eacute;es cr&eacute;atives pour int&eacute;grer ou &eacute;tudier de nouvelles technologies. C&#39;est l&agrave; que r&eacute;sident de nouvelles opportunit&eacute;s stimulantes pour vous. &Agrave; travers une large gamme de missions de stage, nous vous offrons la possibilit&eacute; de d&eacute;velopper ces nouvelles id&eacute;es au sein du Centre de Comp&eacute;tence Microsoft de Realdolmen et de nous convaincre de leur valeur ajout&eacute;e pour notre offre actuelle.</p><p>Si vous &ecirc;tes int&eacute;ress&eacute; et que vous n&#39;avez pas peur des d&eacute;fis, si vous souhaitez vous plonger dans l&#39;une des piles technologiques les plus &eacute;tendues &agrave; l&#39;heure actuelle et si vous ma&icirc;trisez le d&eacute;veloppement Microsoft .NET, c&#39;est le moment de saisir votre chance ! Convainquez-nous de votre enthousiasme, de vos comp&eacute;tences techniques et analytiques en travaillant sur l&#39;un des nombreux projets</p><p>&nbsp;</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>As the Inetum-Realdolmen Microsoft Competence Center, we are the largest Microsoft .NET development organization in Belgium, with over 150 employees. We are involved in the complete realization of Microsoft projects, including strategy, architecture, implementation, system integration, maintenance, training, and support. Our knowledge and experience are focused on the following technologies and solution domains:</p>\r\n\r\n<ol>\r\n	<li>Development of Windows, web, and smart client applications (ASP.NET Core MVC &amp; WebApi, Azure, Angular, WPF, WinForms, ...)</li>\r\n	<li>Mobility (Universal apps, Xamarin)</li>\r\n	<li>Integration - EAI (Biztalk &amp; WCF)</li>\r\n	<li>CAD/GIS integration projects</li>\r\n	<li>Azure Cloud</li>\r\n	<li>Training</li>\r\n</ol>\r\n\r\n<p>Within our internal operations, we place a high emphasis on technology, as it is the cornerstone of our division. That&#39;s why we have numerous initiatives to conduct research on everything new within the Microsoft technology stack. And this is where you come into the picture! We are confident that with all your energy, enthusiasm, and creativity, you can help us explore these new technologies and prepare them for use in future business applications. Below you will find a list of technologies and/or topics for which we want to develop complete assignments in the upcoming academic year.</p>\r\n\r\n<p>Let it be clear that the complexity of the assignments will not be easy. We expect you to already have a solid basic knowledge of .NET. However, don&#39;t let this discourage you, as we are looking for the best of the best. Are you the one who wants to shape the business applications of the future? Don&#39;t hesitate to apply for an internship at the Realdolmen Microsoft Division. In addition to the mentioned assignments from our Applications Microsoft division, we are also active in Enterprise Solutions with Microsoft (SharePoint, CRM, Business Intelligence), where exciting projects are available.</p>\r\n\r\n<p>Realdolmen attaches great importance to a constant flow of innovation, optimization, and expansion of knowledge. The influx of creative ideas for integrating or studying new technologies is substantial. This is where new and challenging opportunities lie for you. Through a wide range of internship assignments, we give you the opportunity to work on these new ideas within the Realdolmen Microsoft Competence Center and convince us whether or not they can add value to our current offerings.</p>\r\n\r\n<p>If you are interested and ready to take on challenges, if you want to delve into one of the most extensive technology stacks at the moment, and if you are proficient in Microsoft .NET development, then seize the opportunity now! Convince us of your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p>\r\n<p><strong>Contacteer ons via</strong><a href=\"mailto: internship@inetum-realdolmen.world\"> internship@inetum-realdolmen.world</a> <strong>om jouw stageplaats aan te vragen</strong></p>\r\n", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Het Inetum-Realdolmen Java Competence Center is met meer dan 150 Java consultants het grootste onafhankelijke Java expertisecentrum op het Vlaams/Belgisch grondgebied. Naast zijn jarenlange ervaring in de sector, beschikt het over een technologische knowhow die gerust als uniek beschouwd mag worden. Binnen Inetum-Realdolmen noemen we dit expertisecentrum niet zomaar onze &ldquo;Java Community&rdquo;. Onze gepassioneerde Java professionals geven dagelijks het beste van zichzelf om projecten bij klanten op tijd en binnen het overeengekomen budget op te leveren. Java is een technologie die van meet af aan opgezet is als een open technologie. &ldquo;Open&rdquo; wil zeggen dat technologische evoluties gedreven worden vanuit communities. Hierin zijn zowel mensen uit de industrie als leveranciers vertegenwoordigd. De vele innovaties die gegroeid zijn uit deze communities, hebben voor een groot deel het IT-landschap gevormd tot wat het vandaag is. Een greep uit de expertise van het Java Competence Center omvat technologie&euml;n en methodologie&euml;n zoals:</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces o Enterprise Java Beans (EJB</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Web services (REST / SOAP) / Service-Oriented Architecture (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / Test Driven Development / Behavior Driven Development</li><li>User Experience (UX) / Quality Assurance (QA)</li></ul><p>Inetum-Realdolmen hecht een groot belang aan een constante flow van innovatie, optimalisatie en uitbreiding van kennis. De instroom aan creatieve idee&euml;n over het integreren of bestuderen van nieuwe technologie&euml;n is allerminst gering. Dit is het punt waar nieuwe en uitdagende opportuniteiten liggen voor jullie. Via een grote waaier aan stageopdrachten geven we jullie de kans om binnen het Inetum Realdolmen Java Competence Center deze nieuwe idee&euml;n uit te werken en ons te overtuigen of dit al dan niet een meerwaarde kan betekenen binnen ons huidig aanbod. Ben je ge&iuml;nteresseerd en ga je geen uitdaging uit de weg, wil je je verdiepen in een van de meest uitgebreide technology stacks op dit moment, en ben je bedreven in Java? Dan is nu het moment om je kans te grijpen! Overtuig ons van je enthousiasme, technische en analytische skills tijdens het uitwerken van een van de vele projecten.</p><p>&nbsp;</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Le centre de comp&eacute;tences Java d&#39;Inetum-Realdolmen est le plus grand centre d&#39;expertise Java ind&eacute;pendant en Flandre/Belgique, avec plus de 150 consultants Java. En plus de sa longue exp&eacute;rience dans le secteur, il poss&egrave;de un savoir-faire technologique qui peut &ecirc;tre consid&eacute;r&eacute; comme unique. Chez Inetum-Realdolmen, nous ne d&eacute;signons pas ce centre d&#39;expertise simplement comme notre &quot;Communaut&eacute; Java&quot;. Nos professionnels Java passionn&eacute;s donnent chaque jour le meilleur d&#39;eux-m&ecirc;mes pour livrer des projets chez les clients dans les d&eacute;lais et le budget convenus.</p><p>Java est une technologie qui a &eacute;t&eacute; con&ccedil;ue d&egrave;s le d&eacute;part comme une technologie ouverte. &quot;Ouverte&quot; signifie que les &eacute;volutions technologiques sont pilot&eacute;es par des communaut&eacute;s, comprenant &agrave; la fois des personnes de l&#39;industrie et des fournisseurs. Les nombreuses innovations qui ont &eacute;merg&eacute; de ces communaut&eacute;s ont largement fa&ccedil;onn&eacute; le paysage informatique tel qu&#39;il est aujourd&#39;hui.</p><p>Une s&eacute;lection de l&#39;expertise du Centre de comp&eacute;tences Java comprend des technologies et des m&eacute;thodologies telles que :</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces</li><li>Enterprise Java Beans (EJB)</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Services Web (REST / SOAP) / Architecture Orient&eacute;e Services (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / D&eacute;veloppement Pilot&eacute; par les Tests / D&eacute;veloppement Pilot&eacute; par le Comportement</li><li>Exp&eacute;rience Utilisateur (UX) / Assurance Qualit&eacute; (QA)</li></ul><p>Inetum-Realdolmen attache une grande importance &agrave; un flux constant d&#39;innovation, d&#39;optimisation et d&#39;extension des connaissances. L&#39;afflux d&#39;id&eacute;es cr&eacute;atives pour int&eacute;grer ou &eacute;tudier de nouvelles technologies est loin d&#39;&ecirc;tre n&eacute;gligeable. C&#39;est l&agrave; que se trouvent de nouvelles opportunit&eacute;s stimulantes pour vous. &Agrave; travers une large gamme de stages, nous vous offrons la possibilit&eacute; de d&eacute;velopper ces nouvelles id&eacute;es au sein du Centre de comp&eacute;tences Java d&#39;Inetum-Realdolmen et de nous convaincre de leur valeur ajout&eacute;e pour notre offre actuelle.</p><p>Si vous &ecirc;tes int&eacute;ress&eacute; et que vous n&#39;avez pas peur des d&eacute;fis, si vous souhaitez vous plonger dans l&#39;une des piles technologiques les plus &eacute;tendues du moment et que vous ma&icirc;trisez Java, c&#39;est le moment de saisir votre chance ! Impressionnez-nous avec votre enthousiasme, vos comp&eacute;tences techniques et analytiques en travaillant sur l&#39;un des nombreux projets.</p><p>&nbsp;</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>The Java Competence Center of Inetum-Realdolmen is the largest independent Java expertise center in Flanders/Belgium, with over 150 Java consultants. In addition to its extensive experience in the industry, it possesses technological expertise that can be considered unique. At Inetum-Realdolmen, we don&#39;t simply refer to this expertise center as our &quot;Java Community.&quot; Our passionate Java professionals give their best every day to deliver projects to clients on time and within the agreed budget.</p><p>Java is a technology that has been designed from the beginning as an open technology. &quot;Open&quot; means that technological advancements are driven by communities, including both industry professionals and suppliers. The many innovations that have emerged from these communities have greatly shaped the IT landscape as it is today.</p><p>A selection of the expertise of the Java Competence Center includes technologies and methodologies such as:</p><ul><li>Java Enterprise Edition<ul><li>Java Persistence API (JPA) + Hibernate / Eclipselink</li><li>Java Server Faces (JSF) + PrimeFaces</li><li>Enterprise Java Beans (EJB)</li><li>Context and Dependency Injection (CDI)</li></ul></li><li>Spring (Boot)</li><li>Web services (REST / SOAP) / Service-Oriented Architecture (SOA)</li><li>HTML5 / CSS3</li><li>JavaScript / jQuery / Node.js / TypeScript / Angular / React</li><li>Android / iOS / Cordova / PhoneGap</li><li>Agile / Scrum / Test Driven Development / Behavior Driven Development</li><li>User Experience (UX) / Quality Assurance (QA)</li></ul><p>Inetum-Realdolmen places great importance on a constant flow of innovation, optimization, and knowledge expansion. The influx of creative ideas for integrating or studying new technologies is significant. This is where new and challenging opportunities lie for you. Through a wide range of internships, we offer you the opportunity to develop these new ideas within the Inetum-Realdolmen Java Competence Center and convince us of their added value to our current offerings.</p><p>If you are interested and unafraid of challenges, if you want to immerse yourself in one of the most extensive technology stacks at the moment, and if you have proficiency in Java, now is the time to seize your chance! Impress us with your enthusiasm, technical skills, and analytical abilities while working on one of the many projects.</p><p>&nbsp;</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1707), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>Naast ontwikkelingen in High Code (.NET, Java, ...) werkt Inetum-Realdolmen ook aan Enterprise-projecten in Low Code en dat in verschillende omgevingen: Microsoft Power-Platform, Salesforce, Mendix, Appian en Outsystems.</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>En plus des d&eacute;veloppements en High Code (.NET, Java, ...), Inetum-Realdolmen travaille &eacute;galement sur des projets d&#39;entreprise en Low Code et ce, dans divers environnements : Microsoft Power-Platform, Salesforce, Mendix, Appian et Outsystems.</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "PrefaceTranslations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "<p>In addition to developments in High Code (.NET, Java, ...), Inetum-Realdolmen is also working on Enterprise projects in Low Code and that in various environments: Microsoft Power-Platform, Salesforce, Mendix, Appian and Outsystems.</p>", new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 5, 30, 11, 42, 45, 287, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4082), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4086), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4087), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4088), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4089), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4090), "<p>In de Inetum-Realdolmen Project Factory (PF) ontwikkelen developers van Inetum Realdolmen software in opdracht van een klant. Al het development gebeurd in house, met de tooling van Inetum-Realdolmen. De klant krijgt dus zijn deliverable op&nbsp;bepaalde tijdstippen en hoeft geen volledig development team te hebben.&nbsp;Om onze PF te ondersteunen, hebben enkele collega&rsquo;s een bibliotheek opgericht. Hier&nbsp;kunnen onze developers boeken uitlenen. Momenteel wordt het uitleen-gedrag&nbsp;bijgehouden op een blad papier. Alsook aanvragen om nieuwe boeken aan te kopen&nbsp;worden op papier bijgehouden. Dit is een bewuste keuze. Als we het uitleen-gedrag&nbsp;digitaliseren op basis van bestaande tools (Google Drive, SharePoint...) zorgt dit voor&nbsp;extra overhead, dit be&iuml;nvloedt de toegankelijkheid van de bibliotheek. In deze stageopdracht is het de bedoeling om een App uit te werken om dit uitleengedrag te gaan beheren. Er zijn tal van uitbreidingsmogelijkheden (synchroniseren&nbsp;met een service, scannen van barcodes om te lenen/terug te brengen, aanvragen&nbsp;van boeken&hellip;). Hiervoor zal de student zelf kunnen kiezen welke functionaliteit er&nbsp;volbracht wordt, uiteraard in samenspraak met stagebegeleider en &lsquo;klant&rsquo;. Er wordt verwacht van de student dat hij/zij deze opdracht opneemt in de mentaliteit&nbsp;van de PF. Dit wil zeggen dat wij, de developers, de klant zullen zijn. Hij/zij zal&nbsp;correct moeten schatten, implementeren en met iteraties werkende, kwaliteitsvolle&nbsp;software opleveren.&nbsp;Hierbij zal de student begeleiding beschikbaar hebben. In de PF zijn immers enkele&nbsp;ScrumMaster&rsquo;s, tal van developers en bovendien een Agile/SCRUM coach.</p>", new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4090), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4091), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4092), new DateTime(2023, 5, 30, 11, 42, 45, 286, DateTimeKind.Utc).AddTicks(4092) });
        }
    }
}
