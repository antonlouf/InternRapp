using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
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


        
        await _dbContext.InternShips.AddAsync(new() { MaxStudents = request.Dto.MaxCountOfStudents, RequiredTrainingType = request.Dto.TrainingType, SchoolYear = request.Dto.SchoolYear, UnitId = request.Dto.UnitId });
        // also add command for translationss!! (for english etc) for loop for each language

    }
}

