using backend.Application.Common.Interfaces;
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
        internShip.CurrentCountOfStudents= request.Dto.CurrentCountOfStudents;


        //this part is later be placed by operations in translations
        
        foreach( var version in internShip.Translations)
        {
            var sendedVersion = request.Dto.Versions.FirstOrDefault(x => x.TranslationId == version.Id);

            if (sendedVersion == null)
            {
                continue;
            }

            version.NeededKnowledge = sendedVersion.NeededKnowledge;
            version.KnowledgeToDevelop = sendedVersion.KnowledgeToDevelop;
            version.Comment = sendedVersion.Comment;
            version.Content = sendedVersion.Content;
            version.Description = sendedVersion.Description;
            version.Location = sendedVersion.Location;
            version.TitleContent = sendedVersion.TitleContent;
        }
      
        await _dbContext.SaveChangesAsync(cancellationToken);
        
    }
}
