using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.InternShips.Commands.UpdateInternShip;
public class UpdateInternShipCommand : IRequest
{
    public InternShipUpdateDto Dto { get; set; }
}
public class UpdateInternShipCommandHandler : AsyncRequestHandler<UpdateInternShipCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public UpdateInternShipCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected async override Task Handle(UpdateInternShipCommand request, CancellationToken cancellationToken)
    {
        var convertedLocations = request.Dto.Locations.Select(x => new Location() { City = x.City, HouseNumber = x.Housenumber, Id = x.Id, StreetName = x.Streetname, ZipCode = x.Zipcode }).ToList();
        _dbContext.Locations.UpdateRange(convertedLocations);
        var internShip = await _dbContext.InternShips.Include(x=>x.Locations).Include(x=>x.Translations).FirstOrDefaultAsync(x => x.Id == request.Dto.InternShipId);
       // _dbContext.InternShips.Update(internShip);
        internShip.MaxStudents = request.Dto.MaxCountOfStudents;
        internShip.SchoolYear = request.Dto.SchoolYear;
        internShip.RequiredTrainingType = request.Dto.TrainingType;
        internShip.Locations=null;
        internShip.UnitId = request.Dto.UnitId;
        internShip.CurrentCountOfStudents = request.Dto.CurrentCountOfStudents;
        //this part is later be placed by operations in translations
        internShip.Translations = new List<InternShipContentTranslation>();
        
        foreach (var sendedVersion in request.Dto.Versions)
        {
            if (sendedVersion.TranslationId!=null)
            {
                internShip.Translations.Add(new()
                {
                    Id = (int)sendedVersion.TranslationId,
                    LanguageId = sendedVersion.LanguageId,
                    NeededKnowledge = sendedVersion.NeededKnowledge,
                    KnowledgeToDevelop = sendedVersion.KnowledgeToDevelop,
                    Comment = sendedVersion.Comment,
                    Content = sendedVersion.Content,
                    Description = sendedVersion.Description,
                    Location = sendedVersion.Location,
                    TitleContent = sendedVersion.TitleContent
                });
            }
            else
            {

           
               internShip.Translations.Add(new()
               {

                   NeededKnowledge = sendedVersion.NeededKnowledge,
                   KnowledgeToDevelop = sendedVersion.KnowledgeToDevelop,
                   Comment = sendedVersion.Comment,
                   Content = sendedVersion.Content,
                   Description = sendedVersion.Description,
                   Location = sendedVersion.Location,
                   TitleContent = sendedVersion.TitleContent,
                   InternShipId=internShip.Id,
                   LanguageId = sendedVersion.LanguageId,

               });
               
            }

        }
        internShip.Locations = convertedLocations;
        await _dbContext.SaveChangesAsync(cancellationToken);

    }


    


}

