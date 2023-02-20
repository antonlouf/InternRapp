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


        
       var result= await _dbContext.InternShips.AddAsync(new() { MaxStudents = request.Dto.MaxCountOfStudents, RequiredTrainingType = request.Dto.TrainingType, SchoolYear = request.Dto.SchoolYear, UnitId = request.Dto.UnitId,LocationId=request.Dto.LocationId });
        // also add command for translationss!! (for english etc) for loop for each language
        await _dbContext.SaveChangesAsync(cancellationToken);
        var list = new List<Translation>();
        for (int i = 0; i < request.Dto.Versions.Count; i++)
        {
            list.Add(new()
            {
                InternShipId = result.Entity.Id,
                Comment = request.Dto.Versions[i].Comment,
                Description = request.Dto.Versions[i].Description,
                Content = request.Dto.Versions[i].Content,
                KnowledgeToDevelop = request.Dto.Versions[i].KnowledgeToDevelop,
                NeededKnowledge = request.Dto.Versions[i].NeededKnowledge,
                TitleContent = request.Dto.Versions[i].TitleContent,
                Location= request.Dto.Versions[i].Location,
                LanguageId = request.Dto.Versions[i].LanguageId
            });
        }
        await _dbContext.Translations.AddRangeAsync(list);
        await _dbContext.SaveChangesAsync(cancellationToken);

    }
}

