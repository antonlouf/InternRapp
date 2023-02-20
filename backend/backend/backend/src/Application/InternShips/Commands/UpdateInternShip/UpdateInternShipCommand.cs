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



        //this part is later be placed by operations in translations
        var versions = await _dbContext.Translations.Where(x => x.InternShipId == request.Dto.internShipId).ToListAsync();
        int counter = 0;
        if (request.Dto.Versions.Count != versions.Count)
        {
            versions = versions.Where(x => x.Id == request.Dto.Versions[counter].TranslationId).ToList();
        }

        foreach (var version in versions)
        {
            foreach(var sendedVersion in request.Dto.Versions)
            {
                if (sendedVersion.TranslationId == version.Id)
                {
                    version.NeededKnowledge=sendedVersion.NeededKnowledge;
                    version.KnowledgeToDevelop = sendedVersion.KnowledgeToDevelop;
                    version.Comment=sendedVersion.Comment;
                    version.Content = sendedVersion.Content;
                    version.Description = sendedVersion.Description;
                    version.Location = sendedVersion.Location;
                    version.TitleContent = sendedVersion.TitleContent;
                }
            }
        }

        await _dbContext.SaveChangesAsync(cancellationToken);

        
    }
}
