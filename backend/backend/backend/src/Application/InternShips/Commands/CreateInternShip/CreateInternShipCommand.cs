using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;

namespace backend.Application.InternShips.Commands.CreateInternShip;
public class CreateInternShipCommand:IRequest
{
    public InternShipCreateDto Dto { get; set; }
}
public class CreateInternShipCommandHandler : AsyncRequestHandler<CreateInternShipCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateInternShipCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected async override Task Handle(CreateInternShipCommand request, CancellationToken cancellationToken)
    {
        var convertedLocations = request.Dto.Locations.Select(x => new Location() { City = x.City, HouseNumber = x.Housenumber, Id = x.Id, StreetName = x.Streetname, ZipCode = x.Zipcode }).ToList();
        _dbContext.Locations.AttachRange(convertedLocations);
        var result = await _dbContext.InternShips.AddAsync(new() { MaxStudents = request.Dto.MaxCountOfStudents, RequiredTrainingType = request.Dto.TrainingType, Locations= convertedLocations, SchoolYear = request.Dto.SchoolYear, UnitId = request.Dto.UnitId,CurrentCountOfStudents=request.Dto.CurrentCountOfStudents });
        //await _dbContext.SaveChangesAsync(cancellationToken);
        result.Entity.Translations = new List<InternShipContentTranslation>();
        for (int i = 0; i < request.Dto.Versions.Count; i++)
        {
            result.Entity.Translations.Add(new()
            {
                InternShipId = result.Entity.Id,
                Comment = request.Dto.Versions[i].Comment,
                Description = request.Dto.Versions[i].Description,
                Content = request.Dto.Versions[i].Content,
                KnowledgeToDevelop = request.Dto.Versions[i].KnowledgeToDevelop,
                NeededKnowledge = request.Dto.Versions[i].NeededKnowledge,
                TitleContent = request.Dto.Versions[i].TitleContent,
                Location= request.Dto.Versions[i].Location,
                LanguageId = request.Dto.Versions[i].LanguageId,
                
            });
        }
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}

