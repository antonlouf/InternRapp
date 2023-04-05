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

        var internShip = await _dbContext.InternShips.FirstOrDefaultAsync(x => x.Id == request.Dto.internShipId);
        internShip.MaxStudents = request.Dto.MaxCountOfStudents;
        internShip.SchoolYear = request.Dto.SchoolYear;
        internShip.RequiredTrainingType = request.Dto.TrainingType;
        internShip.LocationId = request.Dto.LocationId;
        internShip.UnitId = request.Dto.UnitId;
        internShip.CurrentCountOfStudents = request.Dto.CurrentCountOfStudents;
        //this part is later be placed by operations in translations
        internShip.Translations = new List<InternShipContentTranslation>();
        
        foreach (var sendedVersion in request.Dto.Versions)
        {
            internShip.Translations.Add(new()
            {
                Id=sendedVersion.TranslationId,
                LanguageId=sendedVersion.LanguageId,
                NeededKnowledge = sendedVersion.NeededKnowledge,
                KnowledgeToDevelop = sendedVersion.KnowledgeToDevelop,
                Comment = sendedVersion.Comment,
                Content = sendedVersion.Content,
                Description = sendedVersion.Description,
                Location = sendedVersion.Location,
                TitleContent = sendedVersion.TitleContent
            });
        }
        await _dbContext.SaveChangesAsync(cancellationToken);

    }


    


}

