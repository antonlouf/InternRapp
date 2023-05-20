using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using backend.Application.Common.Interfaces;
using backend.Domain.BaseDefinitions;
using backend.Domain.Entities;
using backend.Domain.Enums;
using DocumentFormat.OpenXml.Drawing.Charts;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using static Azure.Core.HttpHeader;
using Department = backend.Domain.Entities.Department;
using DocumentFormat.OpenXml.Wordprocessing;

namespace backend.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    private readonly IMediator _mediator;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
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


        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            //If the actual entity is an auditable type. 
            if (typeof(ISoftDeletable).IsAssignableFrom(entityType.ClrType))
            {
               entityType.AddProperty("IsDeleted", typeof(bool));

                // 2. Create the query filter
                var parameter = Expression.Parameter(entityType.ClrType);

                // EF.Property<bool>(post, "IsDeleted")
                var propertyMethodInfo = typeof(EF).GetMethod("Property")!.MakeGenericMethod(typeof(bool));
                var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("IsDeleted"));

                // EF.Property<bool>(post, "IsDeleted") == false
                BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));

                // post => EF.Property<bool>(post, "IsDeleted") == false
                var lambda = Expression.Lambda(compareExpression, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);


            }
        }

        base.OnModelCreating(builder);

        //seeding 
        var locationHuizingen = new 
        {
            Id = 1,
            City = "Huizingen",
            ZipCode = "1654",
            HouseNumber = 42,
            StreetName = "Vaucampslaan",
            IsDeleted = false,
        };

        var locationGent = new 
        {
            Id = 2,
            City = "Gent",
            ZipCode = "9050",
            HouseNumber = 4,
            StreetName = "Gaston Crommenlaan",
            IsDeleted = false,
        };

        var locationKontich = new 
        {
            Id = 3,
            City = "Kontich",
            ZipCode = "2550",
            HouseNumber = 26,
            StreetName = "Prins Boudewijnlaan",
            IsDeleted = false,
        };

        var langNl = new 
        {
            Id = 1,
            Code = "nl",
            Name = "nederlands",
            IsDeleted = false,
        };

        var langFr = new 
        {
            Id = 2,
            Code = "fr",
            Name = "frans",
            IsDeleted = false,
        };

        var langEng = new 
        {
            Id = 3,
            Code = "eng",
            Name = "engels",
            IsDeleted = false,
        };


        /*
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
        */

        var microsoftCompetence = new 
        {
            Id = 1,
            Name = ".net",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
            IsDeleted = false
        };

        var javaUnit = new 
        {
            Id = 2,
            Name = "Java",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
            IsDeleted = false
        };

        var lowCodeUnit = new 
        {
            Id = 3,
            Name = "Low Code",
            ManagerEmails = new List<string> { "anton.louf@student.ehb.be" },
            IsDeleted = false,
        };

        List<string> schoolyears = new List<string> { "2021-2022", "2022-2023", "2023-2024" };

        //languages
        builder.Entity<Language>().HasData(langEng, langFr, langNl);

        //Locations
        builder.Entity<Location>().HasData(locationHuizingen, locationGent, locationKontich);

        /*
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
        */

        
        
        //loop to make new internships with different translations
        int trnslIndex = 1;
        string prefaceDescrNl = @"<p>Dit is een standaard descriptie horende bij een unit</p>";
        string prefaceDescrFr = @"<p>Ce ici c'est un description standard d un departement</p>";
        string prefaceDescrEng = @"<p>This is a standard description for a unit</p>";
        string prefaceDescr = "";
        Random rnd = new Random();

        for (int intrnShipIndex = 0; intrnShipIndex < 10; intrnShipIndex++)
        {
            var index = (intrnShipIndex % 3) + 1;

            //make internship and go to next internship in next unit 
            var standardInternShip = new 
            {
                Id = intrnShipIndex + 1,
                CurrentCountOfStudents = 0,
                MaxStudents = 10,
                RequiredTrainingType = TrainingType.Bachelor,
                SchoolYear = schoolyears[rnd.Next(3)],
                UnitId = index,
                IsDeleted = false,
            };

            //for lus waarbij internship meerdere locations heeft --> checken
            for (int i = 1; i <= 3; i++)
            {
                var standardInternShipLocation = new 
                {
                    InternShipId = standardInternShip.Id,
                    LocationsId = i,
                    IsDeleted = false,
                };
            //InternShipLocations
            builder.Entity<InternShipLocation>().HasData(standardInternShipLocation);
            }
           

            //loop eerste keer 1 trnsl, tweede intrsnship 2 trnslaties, derde intrship x 3trnsl, --- > restart  
            for (int langIndex = 0; langIndex < (intrnShipIndex % 3) + 1; langIndex++)
            {
                var standardTrnsl = new 
                {
                    Id = trnslIndex, //steeds hoger 
                    TitleContent = "Standard Internship Title",
                    Description = @"<p>quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>",
                    KnowledgeToDevelop = @"<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>",
                    NeededKnowledge = @"<p>This is a text editor</p><ul><li>With some styling</li><li>And some more styling</li><li>To test if text is converted to HTML</li></ul>",
                    Comment = $@"<p>required diploma for this internship is: {TrainingType.Bachelor}</p>", //+1 of random
                    LanguageId = langIndex + 1,
                    InternShipId = standardInternShip.Id,
                    IsDeleted = false,
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
                var standardPrefaceTrnsl = new 
                {
                    Id = prefaceIndex, //check?
                    Content = prefaceDescr,
                    UnitId = unitIndex,
                    LanguageId = langI,
                    IsDeleted = false,
                };
                prefaceIndex++;

                //Prefaces
                builder.Entity<PrefaceTranslation>().HasData(standardPrefaceTrnsl);
            }
        }
        
    }
    


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
