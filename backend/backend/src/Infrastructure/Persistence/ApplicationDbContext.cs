using System.Reflection;
using System.Runtime.Intrinsics.X86;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using backend.Domain.Enums;
using DocumentFormat.OpenXml.Drawing.Charts;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static Azure.Core.HttpHeader;
using Department = backend.Domain.Entities.Department;

namespace backend.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    private readonly IMediator _mediator;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions,
        IMediator mediator)
        : base(options)
    {
        _mediator = mediator;

    }
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Location> Locations => Set<Location>();

    public DbSet<InternShip> InternShips => Set<InternShip>();

    public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<PrefaceTranslation> PrefaceTranslations => Set<PrefaceTranslation>();
    public DbSet<InternShipContentTranslation> Translations => Set<InternShipContentTranslation>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());



        base.OnModelCreating(builder);

        var locationHuizingen = new Location
        {
            Id = 1,
            City = "Huizingen",
            ZipCode = "1654",
            HouseNumber = 42,
            StreetName = "Vaucampslaan",
            //InternShipIds = new List<int> { 1 }
        };

        var locationGent = new Location
        {
            Id = 2,
            City = "Gent",
            ZipCode = "9050",
            HouseNumber = 4,
            StreetName = "Gaston Crommenlaan",
            //InternShipIds = new List<int> { 1, 2 }
        };

        var locationKontich = new Location
        {
            Id = 3,
            City = "Kontich",
            ZipCode = "2550",
            HouseNumber = 26,
            StreetName = "Prins Boudewijnlaan",
            //InternShipIds = new List<int> { 1, 2, 3 }
        };

        var langNl = new Language
        {
            Id = 1,
            Code = "nl",
            Name = "nederlands",
        };

        var langEng = new Language
        {
            Id = 2,
            Code = "eng",
            Name = "engels"
        };

        var langFr = new Language
        {
            Id = 3,
            Code = "fr",
            Name = "frans"
        };

   
        var internRappTrnslNl = new InternShipContentTranslation
        {
            Id = 1,
            TitleContent = "InternRapp",
            Description = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p></body></html>",
            KnowledgeToDevelop = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p></body></html>",
            NeededKnowledge = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p></body></html>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.Bachelor}<p>",
            LanguageId = 1,
            InternShipId = 1,
        };

        var mobileAppTrnsFr = new InternShipContentTranslation
        {
            Id = 2,
            TitleContent = "Mobile App",
            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.Master}<p>",
            LanguageId = 2,
            InternShipId = 2,
        };

        var androidAppTrnslEng = new InternShipContentTranslation
        {
            Id = 3,
            TitleContent = "Android App",
            Description = "<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore<p>",
            KnowledgeToDevelop = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            Comment = $"<p>required diploma for this internship is: {TrainingType.MasterAfterMaster}<p>",
            NeededKnowledge = "<p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p>",
            LanguageId = 3,
            InternShipId = 3,
        };
        
        var internRapp = new InternShip
        {
            Id = 1,
            CurrentCountOfStudents = 0,
            MaxStudents = 10,
            RequiredTrainingType = TrainingType.Bachelor,
            SchoolYear = "2023-2024",
            UnitId = 1,
            //LocationIds = new List<int> { locationGent.Id, locationHuizingen.Id }
        };

        var mobileApp = new InternShip
        {
            Id = 2,
            CurrentCountOfStudents = 0,
            MaxStudents = 10,
            RequiredTrainingType = TrainingType.Master,
            SchoolYear = "2023-2024",
            UnitId = 2,
            //LocationIds = new List<int> { locationGent.Id, locationHuizingen.Id }
        };

        var androidApp = new InternShip
        {
            Id = 3,
            CurrentCountOfStudents = 0,
            MaxStudents = 15,
            RequiredTrainingType = TrainingType.MasterAfterMaster,
            SchoolYear = "2023-2024",
            UnitId = 3,
            //LocationIds = new List<int> { locationGent.Id, locationHuizingen.Id}
        };

        var internRappHuizingen = new InternShipLocation
        {
            InternShipId = 1,
            LocationsId = 1,
        };

        var internRappGent = new InternShipLocation
        {
            InternShipId = 1,
            LocationsId = 2,
        };

        var internRappKontich = new InternShipLocation
        {
            InternShipId = 1,
            LocationsId = 3,
        };

        var mobileAppHuizingen = new InternShipLocation
        {
            InternShipId = 2,
            LocationsId = 1,
        };

        var microsoftPrefaceNl = new PrefaceTranslation
        {
            Id = 1,
            Content = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>Dit is een standaard descriptie horende bij een unit</p></body></html>",
            UnitId = 1,
            LanguageId = 1,
        };

        var javaPrefaceFr = new PrefaceTranslation
        {
            Id = 2,
            Content = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>Ce ici c'est un description standard d un departement</p></body></html>",
            UnitId = 2,
            LanguageId = 3,
        };

        var lowCodePrefaceEng = new PrefaceTranslation
        {
            Id = 3,
            Content = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>This is a standard description for a unit</p></body></html>",
            UnitId = 3,
            LanguageId = 2,
        };


        var microsoftCompetence = new Department
        {
            Id = 1,
            Name = ".net",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
        };

        var javaUnit = new Department
        {
            Id = 2,
            Name = "Java",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
        };

        var lowCodeUnit = new Department
        {
            Id = 3,
            Name = "Low Code",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
        };

  
        //languages
        builder.Entity<Language>().HasData(langEng, langFr, langNl);

        //Locations
        builder.Entity<Location>().HasData(locationHuizingen, locationGent, locationKontich);

        //InternShipLocations
        builder.Entity<InternShipLocation>().HasData(internRappHuizingen, internRappGent, internRappKontich, mobileAppHuizingen);

        //Translations
        builder.Entity<InternShipContentTranslation>().HasData(internRappTrnslNl, mobileAppTrnsFr, androidAppTrnslEng);

        //Internships
        builder.Entity<InternShip>().HasData(internRapp, mobileApp, androidApp);

        //Departments
        builder.Entity<Department>().HasData(microsoftCompetence, javaUnit, lowCodeUnit);

        //Prefaces
        builder.Entity<PrefaceTranslation>().HasData(microsoftPrefaceNl, javaPrefaceFr, lowCodePrefaceEng);

        /*
        //loop to make new internships with different translations
        int trnslIndex = 1;
        string prefaceDescrNl = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>Dit is een standaard descriptie horende bij een unit</p></body></html>";
        string prefaceDescrFr = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>Ce ici c'est un description standard d un departement</p></body></html>";
        string prefaceDescrEng = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>This is a standard description for a unit</p></body></html>";
        string prefaceDescr = "";


        for (int intrnShipIndex = 0; intrnShipIndex < 10; intrnShipIndex++)
        {
            var index = (intrnShipIndex % 3) + 1;

            //make internship and go to next internship in next unit 
            var standardInternShip = new InternShip
            {
                Id = intrnShipIndex + 1,
                CurrentCountOfStudents = 0,
                MaxStudents = 10,
                RequiredTrainingType = TrainingType.Bachelor,
                SchoolYear = "2023 -2024",
                UnitId = index,
            };

            //for lus waarbij internship meerdere locations heeft --> checken
            var standardInternShipLocation = new InternShipLocation
            {
                InternShipId = standardInternShip.Id,
                LocationsId = index,
            };

            //InternShipLocations
            builder.Entity<InternShipLocation>().HasData(standardInternShipLocation);

            //4 x 1 trnsl 
            //loop eerste keer 1 trnsl, tweede intrsnship 2 trnslaties, derde intrship x 3trnsl, --- > restart  
            for (int langIndex = 0; langIndex < (intrnShipIndex % 3) + 1; langIndex++)
            {
                var standardTrnsl = new InternShipContentTranslation
                {
                    Id = trnslIndex, //steeds hoger 
                    TitleContent = "Standard Internship Title",
                    Description = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p></body></html>",
                    KnowledgeToDevelop = @"<html><body style=""font-family:Verdana; font-size:14.5px""><p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p></body></html>",
                    NeededKnowledge = @"<html><body style=""font-family:Verdana; font-size:14.5px"">><p>This is a text editor&nbsp;</p>\r\n\r\n<ul>\r\n\t<li>With some styling</li>\r\n\t<li>And some more styling</li>\r\n\t<li>To test if text is converted to HTML&nbsp;</li>\r\n</ul>\r\n\r\n<p>&nbsp;</p></body></html>",
                    Comment = $@"<html><body style=""font-family:Verdana; font-size:14.5px""><p>required diploma for this internship is: {TrainingType.Bachelor}</p></body></html>", //+1 of random
                    LanguageId = langIndex + 1,
                    InternShipId = standardInternShip.Id,
                };


                trnslIndex++;

                //Translations
                builder.Entity<InternShipContentTranslation>().HasData(standardTrnsl);

            }

            //Internships
            builder.Entity<InternShip>().HasData(standardInternShip);
        }


        //Departments
        builder.Entity<Department>().HasData(microsoftCompetence, javaUnit, lowCodeUnit);

        int prefaceIndex = 1;
        //loop over prefaces of units 
        for (int unitIndex = 1; unitIndex <= 3; unitIndex++)
        {

            for (int langI = 1; langI <= 3; langI++)
            {
                switch (langI)
                {
                    case 1: prefaceDescr = prefaceDescrNl; break;
                    case 2: prefaceDescr = prefaceDescrFr; break;
                    case 3: prefaceDescr = prefaceDescrEng; break;
                }
                var standardPrefaceTrnsl = new PrefaceTranslation
                {
                    Id = prefaceIndex, //check?
                    Content = prefaceDescr,
                    UnitId = unitIndex,
                    LanguageId = langI,
                };
                prefaceIndex++;

                //Prefaces
                builder.Entity<PrefaceTranslation>().HasData(standardPrefaceTrnsl);
            }
        }

        */
    }


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
